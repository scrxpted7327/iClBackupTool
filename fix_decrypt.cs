using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using dnlib.DotNet;

class FixDecrypt {
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        byte[] peBytes = File.ReadAllBytes(path);

        uint e_lfanew = (uint)(peBytes[0x3C] | (peBytes[0x3D] << 8) | (peBytes[0x3E] << 16) | (peBytes[0x3F] << 24));
        ushort numSections = (ushort)(peBytes[e_lfanew + 6] | (peBytes[e_lfanew + 7] << 8));
        ushort optHdrSize = (ushort)(peBytes[e_lfanew + 20] | (peBytes[e_lfanew + 21] << 8));
        uint secOff = e_lfanew + 24 + optHdrSize;

        var sections = new List<Tuple<uint, uint, uint, uint>>();
        for (int i = 0; i < numSections; i++) {
            uint s = secOff + (uint)(i * 40);
            string name = System.Text.Encoding.ASCII.GetString(peBytes, (int)s, 8).TrimEnd('\0');
            uint vaddr = (uint)(peBytes[s+12] | (peBytes[s+13] << 8) | (peBytes[s+14] << 16) | (peBytes[s+15] << 24));
            uint vsize = (uint)(peBytes[s+8] | (peBytes[s+9] << 8) | (peBytes[s+10] << 16) | (peBytes[s+11] << 24));
            uint raw = (uint)(peBytes[s+20] | (peBytes[s+21] << 8) | (peBytes[s+22] << 16) | (peBytes[s+23] << 24));
            uint rawSize = (uint)(peBytes[s+16] | (peBytes[s+17] << 8) | (peBytes[s+18] << 16) | (peBytes[s+19] << 24));
            Console.WriteLine("Section {0}: VA=0x{1:X8}+0x{2:X8} Raw=0x{3:X8}+0x{4:X8}", name, vaddr, vsize, raw, rawSize);
            sections.Add(Tuple.Create(vaddr, vsize, raw, rawSize));
        }

        uint zN_Raw = 0x400, zN_VA = 0x19E000;
        Console.WriteLine("Using .zN| raw data at file offset 0x{0:X8}", zN_Raw);

        Func<uint, uint> rvaToFileOff = rva => {
            foreach (var sec in sections)
                if (rva >= sec.Item1 && rva < sec.Item1 + sec.Item2)
                    return (sec.Item4 > 0) ? sec.Item3 + (rva - sec.Item1) : 0;
            return 0;
        };

        Console.WriteLine("Loading assembly...");
        Assembly asm = Assembly.Load(peBytes);
        Console.WriteLine("Triggering cctor...");
        try { RuntimeHelpers.RunModuleConstructor(asm.ManifestModule.ModuleHandle); } catch { }

        Type[] types;
        try { types = asm.GetTypes(); } catch (ReflectionTypeLoadException rtle) { types = rtle.Types; }

        var tokenToDec = new Dictionary<int, byte[]>();
        for (int ti = 0; ti < types.Length; ti++) {
            Type type = types[ti];
            if (type == null) continue;
            foreach (var method in type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)) {
                int token = method.MetadataToken;
                byte[] dec = null;
                try { MethodBody mb = method.GetMethodBody(); if (mb != null) dec = mb.GetILAsByteArray(); } catch { }
                if (dec != null && dec.Length > 0) tokenToDec[token] = dec;
            }
        }
        // Also try to get entry point
        try {
            MethodInfo ep = asm.EntryPoint;
            if (ep != null) {
                int epToken = ep.MetadataToken;
                if (!tokenToDec.ContainsKey(epToken)) {
                    byte[] epBody;
                    try { MethodBody mb = ep.GetMethodBody(); if (mb != null) epBody = mb.GetILAsByteArray(); else epBody = null; } catch { epBody = null; }
                    if (epBody != null && epBody.Length > 0) tokenToDec[epToken] = epBody;
                }
            }
        } catch { }
        Console.WriteLine("Methods from reflection: {0}", tokenToDec.Count);

        ModuleDefMD dnMod = ModuleDefMD.Load(peBytes);
        var allMethods = new List<Tuple<uint, int>>();
        foreach (var t in dnMod.GetTypes())
            foreach (var m in t.Methods) {
                uint rva = (uint)m.RVA;
                if (rva != 0) allMethods.Add(Tuple.Create(rva, (int)m.MDToken.Raw));
            }
        Console.WriteLine("Methods with RVAs: {0}", allMethods.Count);

        var earlyMethods = allMethods.Where(m => m.Item1 < zN_VA).OrderBy(m => m.Item1).ToList();
        var lateMethods = allMethods.Where(m => m.Item1 >= zN_VA).OrderBy(m => m.Item1).ToList();
        Console.WriteLine("Early methods: {0}, Late (.zN|) methods: {1}", earlyMethods.Count, lateMethods.Count);
        if (lateMethods.Count == 0) { Console.WriteLine("ERROR: No .zN| methods"); return; }

        var tokenToEnc = new Dictionary<int, byte[]>();
        var tokenToBlockPos = new Dictionary<int, uint>();

        // Phase 1: Read .zN| (late) methods
        foreach (var m in lateMethods.OrderBy(m => m.Item2)) {
            int token = m.Item2; uint rva = m.Item1;
            uint fileOff = rvaToFileOff(rva);
            if (fileOff == 0 || fileOff >= peBytes.Length) continue;
            uint nextRva = 0;
            for (int i = 0; i < lateMethods.Count - 1; i++)
                if (lateMethods[i].Item2 == token) { nextRva = lateMethods[i + 1].Item1; break; }
            if (nextRva == 0) nextRva = rva + 0x10000;
            int size = (int)Math.Min(nextRva - rva, 0x10000);
            if (size <= 0) size = 0x100;
            if (fileOff + size > peBytes.Length) size = (int)(peBytes.Length - fileOff);
            if (size <= 0) continue;
            byte[] enc = new byte[size];
            Array.Copy(peBytes, fileOff, enc, 0, size);
            tokenToEnc[token] = enc;
            tokenToBlockPos[token] = fileOff - zN_Raw;
        }
        Console.WriteLine("  .zN| read: {0}", tokenToEnc.Count);

        // Derive XOR key from longest matching pair
        byte[] xorKey = null; int keyLen = 0;
        foreach (var kv in tokenToDec) {
            byte[] enc;
            if (tokenToEnc.TryGetValue(kv.Key, out enc)) {
                byte[] dec = kv.Value;
                int len = Math.Min(enc.Length, dec.Length);
                if (len > keyLen) {
                    xorKey = new byte[len]; keyLen = len;
                    for (int i = 0; i < len; i++) xorKey[i] = (byte)(enc[i] ^ dec[i]);
                }
            }
        }
        Console.WriteLine("XOR key derived: len={0}", keyLen);
        if (xorKey == null) { Console.WriteLine("ERROR: No matching pairs"); return; }

        // Phase 2: Read early methods (.text + .5+.) via sequential scan
        var earlyByToken = earlyMethods.OrderBy(m => m.Item2).ToList();
        uint earlyEnd = zN_Raw + (lateMethods.Min(m => m.Item1) - zN_VA);
        Console.WriteLine("Early block: {0} to 0x{1:X6} ({2} bytes)", zN_Raw, earlyEnd, earlyEnd - zN_Raw);

        int[] rvaGaps = new int[earlyByToken.Count];
        for (int i = 0; i < earlyByToken.Count; i++) {
            int sz = 0x100;
            for (int j = 0; j < earlyMethods.Count - 1; j++)
                if (earlyMethods[j].Item2 == earlyByToken[i].Item2) {
                    sz = (int)(earlyMethods[j + 1].Item1 - earlyMethods[j].Item1);
                    if (sz <= 0) sz = 0x100; break;
                }
            rvaGaps[i] = sz;
        }

        int earlyRead = 0;
        uint curPos = zN_Raw;
        for (int i = 0; i < earlyByToken.Count && curPos < earlyEnd; i++) {
            int token = earlyByToken[i].Item2;
            uint foundPos = 0xFFFFFFFF;
            uint exp = curPos;
            if (exp < earlyEnd) {
                for (int delta = -200; delta <= 200; delta++) {
                    uint pos = (uint)((int)exp + delta);
                    if (pos < curPos || pos >= earlyEnd) continue;
                    if (((byte)(peBytes[pos] ^ xorKey[0]) & 3) == 2 || ((byte)(peBytes[pos] ^ xorKey[0]) & 3) == 3) {
                        foundPos = pos; break;
                    }
                }
            }
            if (foundPos == 0xFFFFFFFF) {
                for (uint pos = curPos; pos < earlyEnd; pos++) {
                    if (((byte)(peBytes[pos] ^ xorKey[0]) & 3) == 2 || ((byte)(peBytes[pos] ^ xorKey[0]) & 3) == 3) {
                        foundPos = pos; break;
                    }
                }
            }
            if (foundPos >= earlyEnd) break;
            curPos = foundPos;
            uint endPos = earlyEnd;
            uint searchEnd = Math.Min(foundPos + (uint)(rvaGaps[i] * 3), earlyEnd);
            for (uint pos = foundPos + 1; pos < searchEnd; pos++) {
                if (((byte)(peBytes[pos] ^ xorKey[0]) & 3) == 2 || ((byte)(peBytes[pos] ^ xorKey[0]) & 3) == 3) {
                    endPos = pos; break;
                }
            }
            int size = (int)(endPos - foundPos);
            if (foundPos + (uint)size > peBytes.Length) break;
            byte[] enc = new byte[size];
            Array.Copy(peBytes, foundPos, enc, 0, size);
            tokenToEnc[token] = enc;
            tokenToBlockPos[token] = foundPos - zN_Raw;
            curPos = foundPos + (uint)size;
            earlyRead++;
        }
        Console.WriteLine("Early read: {0} (total encrypted: {1})", earlyRead, tokenToEnc.Count);

        // Phase 3: Write decrypted bodies  
        int written = 0, fromRefl = 0, fromXor = 0;
        foreach (var kv in tokenToEnc) {
            int token = kv.Key; byte[] enc = kv.Value;
            byte[] dec;
            byte[] reflBody;
            if (tokenToDec.TryGetValue(token, out reflBody)) {
                dec = reflBody;
                fromRefl++;
            } else {
                dec = new byte[enc.Length];
                for (int i = 0; i < enc.Length; i++)
                    dec[i] = (byte)(enc[i] ^ xorKey[i % keyLen]);
                fromXor++;
            }
            string fn = string.Format(@"{0}\{1:X8}.dec_xor", dumpDir, token);
            File.WriteAllBytes(fn, dec);
            written++;
        }
        Console.WriteLine("Written: {0} (reflection={1}, xor={2})", written, fromRefl, fromXor);
    }
}
