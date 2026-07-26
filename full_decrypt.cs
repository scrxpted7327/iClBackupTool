using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using dnlib.DotNet;

class FullDecrypt {
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        byte[] peBytes = File.ReadAllBytes(path);
        
        // Build RVA→file offset mapping from PE headers
        uint e_lfanew = (uint)(peBytes[0x3C] | (peBytes[0x3D] << 8) | (peBytes[0x3E] << 16) | (peBytes[0x3F] << 24));
        ushort numSections = (ushort)(peBytes[e_lfanew + 6] | (peBytes[e_lfanew + 7] << 8));
        ushort optHdrSize = (ushort)(peBytes[e_lfanew + 16] | (peBytes[e_lfanew + 17] << 8));
        uint secOffset = e_lfanew + 24 + optHdrSize;
        
        var sections = new List<Tuple<uint, uint, uint, uint>>();
        for (int i = 0; i < numSections; i++) {
            uint s = secOffset + (uint)(i * 40);
            uint vaddr = (uint)(peBytes[s+12] | (peBytes[s+13] << 8) | (peBytes[s+14] << 16) | (peBytes[s+15] << 24));
            uint vsize = (uint)(peBytes[s+8] | (peBytes[s+9] << 8) | (peBytes[s+10] << 16) | (peBytes[s+11] << 24));
            uint raw = (uint)(peBytes[s+20] | (peBytes[s+21] << 8) | (peBytes[s+22] << 16) | (peBytes[s+23] << 24));
            uint rawSize = (uint)(peBytes[s+16] | (peBytes[s+17] << 8) | (peBytes[s+18] << 16) | (peBytes[s+19] << 24));
            sections.Add(Tuple.Create(vaddr, vsize, raw, rawSize));
        }
        
        Func<uint, uint> rvaToFileOff = rva => {
            foreach (var sec in sections)
                if (rva >= sec.Item1 && rva < sec.Item1 + sec.Item2)
                    return sec.Item3 + (rva - sec.Item1);
            return 0;
        };
        
        // Load assembly and trigger cctor
        Console.WriteLine("Loading assembly...");
        Assembly asm = Assembly.Load(peBytes);
        Console.WriteLine("Triggering cctor...");
        try {
            RuntimeHelpers.RunModuleConstructor(asm.ManifestModule.ModuleHandle);
        } catch { }
        
        // Get dnlib module to access RVAs
        ModuleDefMD dnModule = ModuleDefMD.Load(peBytes);
        
        // Build method RVA list from dnlib, sorted, with body sizes from adjacent RVAs
        var methodsByRva = new List<Tuple<uint, int>>(); // RVA, token
        foreach (var t in dnModule.GetTypes()) {
            foreach (var m in t.Methods) {
                uint rva = (uint)m.RVA;
                if (rva != 0)
                    methodsByRva.Add(Tuple.Create(rva, (int)m.MDToken.Raw));
            }
        }
        methodsByRva.Sort((a, b) => a.Item1.CompareTo(b.Item1));
        Console.WriteLine("Found {0} method RVAs in metadata", methodsByRva.Count);
        
        // For each method, body size = next RVA - current RVA (with max of 0x10000)
        var tokenToEncBytes = new Dictionary<int, byte[]>();
        var tokenToDecBytes = new Dictionary<int, byte[]>();
        
        for (int idx = 0; idx < methodsByRva.Count; idx++) {
            uint rva = methodsByRva[idx].Item1;
            int token = methodsByRva[idx].Item2;
            uint nextRva = (idx + 1 < methodsByRva.Count) ? methodsByRva[idx + 1].Item1 : rva + 0x10000;
            int bodySize = (int)Math.Min(nextRva - rva, 0x10000);
            
            uint fileOff = rvaToFileOff(rva);
            if (fileOff == 0) continue;
            
            int avail = (int)(peBytes.Length - fileOff);
            if (avail <= 0) continue;
            byte[] enc = new byte[Math.Min(bodySize, avail)];
            Array.Copy(peBytes, fileOff, enc, 0, enc.Length);
            tokenToEncBytes[token] = enc;
        }
        
        // Now iterate via reflection to get decrypted bytes
        Type[] types;
        try { types = asm.GetTypes(); }
        catch (ReflectionTypeLoadException rtle) { types = rtle.Types; }
        
        foreach (var type in types) {
            if (type == null) continue;
            foreach (var method in type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)) {
                int token = method.MetadataToken;
                byte[] decBytes = null;
                try {
                    MethodBody mb = method.GetMethodBody();
                    if (mb != null) decBytes = mb.GetILAsByteArray();
                } catch { }
                if (decBytes != null && decBytes.Length > 0) {
                    tokenToDecBytes[token] = decBytes;
                    // Save immediately
                    string fn = string.Format(@"C:\deobfuscate\methods_dump\{0:X8}_{1:X8}.dec", type.MetadataToken, token);
                    File.WriteAllBytes(fn, decBytes);
                }
            }
        }
        Console.WriteLine("Methods with decrypted bodies: {0}", tokenToDecBytes.Count);
        Console.WriteLine("Methods with encrypted bodies: {0}", tokenToEncBytes.Count);
        
        // Debug: check first few tokens
        int debugCount = 0;
        Console.WriteLine("\nSample decrypted tokens:");
        foreach (var kv in tokenToDecBytes) {
            if (debugCount++ < 5)
                Console.WriteLine("  0x{0:X8} ({1} bytes)", kv.Key, kv.Value.Length);
        }
        debugCount = 0;
        Console.WriteLine("Sample encrypted tokens:");
        foreach (var kv in tokenToEncBytes) {
            if (debugCount++ < 5)
                Console.WriteLine("  0x{0:X8} ({1} bytes)", kv.Key, kv.Value.Length);
        }
        
        // Check overlap
        int overlap = 0;
        foreach (var kv in tokenToDecBytes)
            if (tokenToEncBytes.ContainsKey(kv.Key)) overlap++;
        Console.WriteLine("Overlap: {0}", overlap);
        
        // Debug: show all RVAs for first 10 .zN| methods
        Console.WriteLine("\nSorted method RVAs (first 12 and last 12):");
        for (int i = 0; i < Math.Min(12, methodsByRva.Count); i++)
            Console.WriteLine("  [{0}] 0x{1:X8} token=0x{2:X8}", i, methodsByRva[i].Item1, methodsByRva[i].Item2);
        if (methodsByRva.Count > 24) {
            Console.WriteLine("  ...");
            for (int i = methodsByRva.Count - 12; i < methodsByRva.Count; i++)
                Console.WriteLine("  [{0}] 0x{1:X8} token=0x{2:X8}", i, methodsByRva[i].Item1, methodsByRva[i].Item2);
        }
        // Count by token range
        int lowCount = 0, highCount = 0;
        foreach (var kv in tokenToEncBytes) {
            if (kv.Key < 0x06000100) lowCount++; else highCount++;
        }
        Console.WriteLine("Encrypted: low tokens={0}, high tokens={1}", lowCount, highCount);
        lowCount = highCount = 0;
        foreach (var kv in tokenToDecBytes) {
            if (kv.Key < 0x06000100) lowCount++; else highCount++;
        }
        Console.WriteLine("Decrypted: low tokens={0}, high tokens={1}", lowCount, highCount);
        
        // Derive XOR key from first matching pair
        byte[] xorKey = null;
        int keyLen = 0;
        foreach (var kv in tokenToDecBytes) {
            byte[] enc;
            if (tokenToEncBytes.TryGetValue(kv.Key, out enc)) {
                byte[] dec = kv.Value;
                int len = Math.Min(enc.Length, dec.Length);
                if (len > keyLen) {
                    xorKey = new byte[len];
                    keyLen = len;
                    for (int i = 0; i < len; i++)
                        xorKey[i] = (byte)(enc[i] ^ dec[i]);
                }
            }
        }
        
        if (xorKey != null && keyLen > 0) {
            Console.WriteLine("\nXOR key ({0} bytes):", keyLen);
            for (int i = 0; i < Math.Min(keyLen, 96); i++)
                Console.Write("{0:X2} ", xorKey[i]);
            Console.WriteLine();
            
            // Check if key repeats every N bytes
            for (int period = 1; period <= 32; period++) {
                bool matches = true;
                for (int i = period; i < Math.Min(keyLen, 256); i++)
                    if (xorKey[i] != xorKey[i % period]) { matches = false; break; }
                if (matches && period < keyLen) {
                    Console.WriteLine("Key repeats every {0} bytes", period);
                    break;
                }
            }
            
            // Decrypt ALL methods with the XOR key
            Console.WriteLine("\nDecrypting all methods with XOR key...");
            int recovered = 0;
            foreach (var kv in tokenToEncBytes) {
                int token = kv.Key;
                byte[] enc = kv.Value;
                
                // XOR decrypt
                byte[] dec = new byte[enc.Length];
                for (int i = 0; i < enc.Length; i++)
                    dec[i] = (byte)(enc[i] ^ xorKey[i % keyLen]);
                
                // Verify: first byte should have format bits 2 or 3
                if ((dec[0] & 3) == 2 || (dec[0] & 3) == 3) {
                    string fn = string.Format(@"C:\deobfuscate\methods_dump\{0:X8}.dec_xor", token);
                    File.WriteAllBytes(fn, dec);
                    recovered++;
                }
            }
            Console.WriteLine("Recovered with XOR: {0}", recovered);
            Console.WriteLine("Total encrypted: {0}", tokenToEncBytes.Count);
        } else {
            Console.WriteLine("Failed to derive XOR key (no matching method pairs)");
        }
    }
    
}
