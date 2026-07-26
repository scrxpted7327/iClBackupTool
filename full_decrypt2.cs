using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using dnlib.DotNet;

class FullDecrypt2 {
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        byte[] peBytes = File.ReadAllBytes(path);
        
        // Read PE sections
        uint e_lfanew = (uint)(peBytes[0x3C] | (peBytes[0x3D] << 8) | (peBytes[0x3E] << 16) | (peBytes[0x3F] << 24));
        ushort numSections = (ushort)(peBytes[e_lfanew + 6] | (peBytes[e_lfanew + 7] << 8));
        ushort optHdrSize = (ushort)(peBytes[e_lfanew + 16] | (peBytes[e_lfanew + 17] << 8));
        uint secOff = e_lfanew + 24 + optHdrSize;
        
        var sections = new List<Tuple<uint, uint, uint, uint>>();
        for (int i = 0; i < numSections; i++) {
            uint s = secOff + (uint)(i * 40);
            uint vaddr = (uint)(peBytes[s+12] | (peBytes[s+13] << 8) | (peBytes[s+14] << 16) | (peBytes[s+15] << 24));
            uint vsize = (uint)(peBytes[s+8] | (peBytes[s+9] << 8) | (peBytes[s+10] << 16) | (peBytes[s+11] << 24));
            uint raw = (uint)(peBytes[s+20] | (peBytes[s+21] << 8) | (peBytes[s+22] << 16) | (peBytes[s+23] << 24));
            uint rawSize = (uint)(peBytes[s+16] | (peBytes[s+17] << 8) | (peBytes[s+18] << 16) | (peBytes[s+19] << 24));
            sections.Add(Tuple.Create(vaddr, vsize, raw, rawSize));
        }
        // Sort by VAddr for proper mapping
        sections.Sort((a, b) => a.Item1.CompareTo(b.Item1));
        Console.WriteLine("Sections:");
        for (int i = 0; i < sections.Count; i++)
            Console.WriteLine("  [{0}] V={1:X8}-{2:X8} R={3:X8}+{4:X8}", 
                i, sections[i].Item1, sections[i].Item1+sections[i].Item2, sections[i].Item3, sections[i].Item4);
        
        // Load assembly and trigger cctor
        Console.WriteLine("Loading assembly...");
        Assembly asm = Assembly.Load(peBytes);
        Console.WriteLine("Triggering cctor...");
        try {
            RuntimeHelpers.RunModuleConstructor(asm.ManifestModule.ModuleHandle);
        } catch { }
        
        // Get all methods via reflection
        Type[] types;
        try { types = asm.GetTypes(); }
        catch (ReflectionTypeLoadException rtle) { types = rtle.Types; }
        
        // Build token→decrypted bytes from reflection
        var tokenToDec = new Dictionary<int, byte[]>();
        foreach (var type in types) {
            if (type == null) continue;
            foreach (var method in type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)) {
                int token = method.MetadataToken;
                byte[] dec = null;
                try {
                    MethodBody mb = method.GetMethodBody();
                    if (mb != null) dec = mb.GetILAsByteArray();
                } catch { }
                if (dec != null && dec.Length > 0)
                    tokenToDec[token] = dec;
            }
        }
        Console.WriteLine("Methods from reflection: {0}", tokenToDec.Count);
        
        // Get all methods with RVAs from dnlib
        ModuleDefMD dnMod = ModuleDefMD.Load(peBytes);
        var rvaMethods = new List<Tuple<uint, int>>();
        foreach (var t in dnMod.GetTypes())
            foreach (var m in t.Methods) {
                uint rva = (uint)m.RVA;
                if (rva != 0) rvaMethods.Add(Tuple.Create(rva, (int)m.MDToken.Raw));
            }
        rvaMethods.Sort((a, b) => a.Item1.CompareTo(b.Item1));
        Console.WriteLine("Methods with RVAs: {0}", rvaMethods.Count);
        
        // Build token→encrypted body using RVA intervals for size
        var tokenToEnc = new Dictionary<int, byte[]>();
        for (int i = 0; i < rvaMethods.Count; i++) {
            uint rva = rvaMethods[i].Item1;
            int token = rvaMethods[i].Item2;
            
            // Find file offset from RVA
            uint fileOff = 0;
            foreach (var sec in sections)
                if (rva >= sec.Item1 && rva < sec.Item1 + sec.Item2)
                    fileOff = sec.Item3 + (rva - sec.Item1);
            if (fileOff == 0 || fileOff >= peBytes.Length) continue;
            
            // Body size = next RVA - current RVA
            uint nextRva = (i + 1 < rvaMethods.Count) ? rvaMethods[i + 1].Item1 : rva + 108;
            int bodySize = (int)Math.Min(nextRva - rva, 0x10000);
            if (bodySize <= 0 || bodySize > 0x10000) bodySize = 108;
            
            // Limit by available bytes
            int avail = (int)(peBytes.Length - fileOff);
            if (avail <= 0) continue;
            bodySize = Math.Min(bodySize, avail);
            
            byte[] enc = new byte[bodySize];
            Array.Copy(peBytes, fileOff, enc, 0, bodySize);
            tokenToEnc[token] = enc;
        }
        Console.WriteLine("Methods with encrypted bodies: {0}", tokenToEnc.Count);
        
        // Check how many methods are still missing
        int missing = 0;
        foreach (var kv in tokenToDec) {
            if (!tokenToEnc.ContainsKey(kv.Key)) missing++;
        }
        Console.WriteLine("Decrypted methods missing from encrypted set: {0}", missing);
        
        // Show min/max RVA and token range
        uint minRva = uint.MaxValue, maxRva = 0;
        int minToken = int.MaxValue, maxToken = 0;
        foreach (var kv in tokenToEnc) {
            if (kv.Key < minToken) minToken = kv.Key;
            if (kv.Key > maxToken) maxToken = kv.Key;
            // Find RVA for this token
            foreach (var rm in rvaMethods)
                if (rm.Item2 == kv.Key) {
                    if (rm.Item1 < minRva) minRva = rm.Item1;
                    if (rm.Item1 > maxRva) maxRva = rm.Item1;
                    break;
                }
        }
        Console.WriteLine("Encrypted: tokens 0x{0:X8}-0x{1:X8}, RVAs 0x{2:X8}-0x{3:X8}", 
            minToken, maxToken, minRva, maxRva);
        
        // Show same for decrypted
        minRva = uint.MaxValue; maxRva = 0;
        minToken = int.MaxValue; maxToken = 0;
        foreach (var kv in tokenToDec) {
            if (kv.Key < minToken) minToken = kv.Key;
            if (kv.Key > maxToken) maxToken = kv.Key;
            foreach (var rm in rvaMethods)
                if (rm.Item2 == kv.Key) {
                    if (rm.Item1 < minRva) minRva = rm.Item1;
                    if (rm.Item1 > maxRva) maxRva = rm.Item1;
                    break;
                }
        }
        Console.WriteLine("Decrypted: tokens 0x{0:X8}-0x{1:X8}, RVAs 0x{2:X8}-0x{3:X8}", 
            minToken, maxToken, minRva, maxRva);
        
        // Check overlap and derive XOR key
        int overlap = 0;
        byte[] xorKey = null;
        int keyLen = 0;
        
        foreach (var kv in tokenToDec) {
            byte[] enc;
            if (!tokenToEnc.TryGetValue(kv.Key, out enc)) continue;
            overlap++;
            byte[] dec = kv.Value;
            int len = Math.Min(enc.Length, dec.Length);
            if (len > keyLen) {
                xorKey = new byte[len];
                keyLen = len;
                for (int j = 0; j < len; j++)
                    xorKey[j] = (byte)(enc[j] ^ dec[j]);
                Console.WriteLine("  Derived key from token 0x{0:X8} ({1} bytes)", kv.Key, len);
            }
        }
        Console.WriteLine("Overlap: {0}", overlap);
        
        if (xorKey != null && keyLen > 0) {
            Console.WriteLine("\nXOR key ({0} bytes):", keyLen);
            for (int i = 0; i < Math.Min(keyLen, 96); i++)
                Console.Write("{0:X2} ", xorKey[i]);
            Console.WriteLine();
            
            // Check if key is all the same or has period
            for (int period = 1; period <= 32; period++) {
                bool matches = true;
                for (int i = period; i < Math.Min(keyLen, 256); i++)
                    if (xorKey[i] != xorKey[i % period]) { matches = false; break; }
                if (matches && period < keyLen) {
                    Console.WriteLine("Key repeats every {0} bytes", period);
                    break;
                }
            }
            if (keyLen >= 4) {
                uint k0 = (uint)(xorKey[0] | (xorKey[1]<<8) | (xorKey[2]<<16) | (xorKey[3]<<24));
                Console.WriteLine("First DWORD: 0x{0:X8}", k0);
            }
            
            // Decrypt all encrypted bodies
            Console.WriteLine("\nDecrypting...");
            int decrypted = 0;
            foreach (var kv in tokenToEnc) {
                int token = kv.Key;
                byte[] enc = kv.Value;
                
                byte[] dec = new byte[enc.Length];
                for (int i = 0; i < enc.Length; i++)
                    dec[i] = (byte)(enc[i] ^ xorKey[i % keyLen]);
                
                // Validate: check header format
                if ((dec[0] & 3) == 2 || (dec[0] & 3) == 3) {
                    string fn = string.Format(@"C:\deobfuscate\methods_dump\{0:X8}.dec_xor", token);
                    File.WriteAllBytes(fn, dec);
                    decrypted++;
                }
            }
            Console.WriteLine("Decrypted with key: {0}/{1}", decrypted, tokenToEnc.Count);
        } else {
            Console.WriteLine("Failed to derive key (overlap={0})", overlap);
            
            // Try to find ANY matching token by printing samples
            Console.WriteLine("\nSample encrypted tokens with RVAs:");
            int count = 0;
            foreach (var kv in tokenToEnc) {
                if (count++ > 10) break;
                Console.WriteLine("  Enc 0x{0:X8}: {1} bytes, first={2:X2}", 
                    kv.Key, kv.Value.Length, kv.Value[0]);
            }
            Console.WriteLine("\nSample decrypted tokens:");
            count = 0;
            foreach (var kv in tokenToDec) {
                if (count++ > 10) break;
                Console.WriteLine("  Dec 0x{0:X8}: {1} bytes, first={2:X2}", 
                    kv.Key, kv.Value.Length, kv.Value[0]);
            }
        }
    }
}
