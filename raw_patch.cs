using System;
using System.IO;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.PE;
using dnlib.DotNet.Emit;
using dnlib.IO;

class RawPatch {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        string outPath = @"C:\deobfuscate\SpiderBackup_rawpatched.exe";
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        
        // Load module to get method info
        var mod = ModuleDefMD.Load(path);
        IPEImage peImage = mod.Metadata.PEImage;
        byte[] pe = File.ReadAllBytes(path);
        
        // Build .dec file lookup
        var decFiles = new Dictionary<int, string>();
        foreach (var f in Directory.GetFiles(dumpDir, "*.dec")) {
            string name = Path.GetFileNameWithoutExtension(f);
            string[] parts = name.Split('_');
            if (parts.Length == 2) {
                int methodToken = Convert.ToInt32(parts[1], 16);
                decFiles[methodToken] = f;
            }
        }
        Console.WriteLine("Found {0} .dec files", decFiles.Count);
        
        // Load XOR key
        int refToken = 0x06000497;
        byte[] refDec = File.ReadAllBytes(dumpDir + refToken.ToString("X8") + ".dec_xor");
        uint refFileOff = 0;
        foreach (var t in mod.GetTypes())
            foreach (var m in t.Methods)
                if ((int)m.MDToken.Raw == refToken)
                    refFileOff = (uint)peImage.ToFileOffset((RVA)(uint)m.RVA);
        int keyLen = Math.Min(refDec.Length, (int)(pe.Length - refFileOff));
        byte[] xorKey = new byte[keyLen];
        for (int i = 0; i < keyLen; i++)
            xorKey[i] = (byte)(pe[refFileOff + i] ^ refDec[i]);
        Console.WriteLine("XOR key: {0} bytes", keyLen);
        
        // Find metadata/CLR header bounds
        uint cor20Rva = (uint)peImage.ImageNTHeaders.OptionalHeader.DataDirectories[14].VirtualAddress;
        uint cor20Raw = (uint)peImage.ToFileOffset((RVA)cor20Rva);
        uint cor20Size = (uint)(pe[cor20Raw] | (pe[cor20Raw+1]<<8) | (pe[cor20Raw+2]<<16) | (pe[cor20Raw+3]<<24));
        uint cor20End = cor20Raw + cor20Size;
        uint metaRva = (uint)(pe[cor20Raw+8] | (pe[cor20Raw+9]<<8) | (pe[cor20Raw+10]<<16) | (pe[cor20Raw+11]<<24));
        uint metaSize = (uint)(pe[cor20Raw+12] | (pe[cor20Raw+13]<<8) | (pe[cor20Raw+14]<<16) | (pe[cor20Raw+15]<<24));
        uint metaRaw = (uint)peImage.ToFileOffset((RVA)metaRva);
        uint metaEnd = metaRaw + metaSize;
        
        // Step 1: XOR-decrypt .zN| section in-place
        int decrypted = 0;
        foreach (var type in mod.GetTypes()) {
            foreach (var method in type.Methods) {
                if (method.RVA == 0) continue;
                uint rva = (uint)method.RVA;
                if (rva < 0x19E000) continue;
                
                uint fileOff = (uint)peImage.ToFileOffset((RVA)rva);
                uint nextRva = rva + 256;
                bool found = false;
                foreach (var t2 in mod.GetTypes())
                    foreach (var m2 in t2.Methods) {
                        uint mrva = (uint)m2.RVA;
                        if (mrva > rva && m2.MDToken.Raw != method.MDToken.Raw) {
                            if (!found || mrva < nextRva) { nextRva = mrva; found = true; }
                        }
                    }
                uint nextRaw = (uint)peImage.ToFileOffset((RVA)nextRva);
                int bodySize = (int)(nextRaw - fileOff);
                if (bodySize <= 0 || bodySize > 0x10000) bodySize = 256;
                if (fileOff + bodySize > pe.Length) bodySize = (int)(pe.Length - fileOff);
                if (bodySize <= 0) continue;
                
                for (int i = 0; i < bodySize; i++) {
                    uint off = fileOff + (uint)i;
                    if (off >= metaRaw && off < metaEnd) continue;
                    if (off >= cor20Raw && off < cor20End) continue;
                    pe[off] ^= xorKey[i % keyLen];
                }
                decrypted++;
            }
        }
        Console.WriteLine("XOR-decrypted {0} methods", decrypted);
        
        // Step 2: Replace method bodies with proxy-resolved data from .dec files
        // .dec files contain raw IL (no COR_ILMETHOD header). We need to write the full body.
        int patched = 0;
        int skipped = 0;
        foreach (var type in mod.GetTypes()) {
            foreach (var method in type.Methods) {
                if (method.RVA == 0) continue;
                uint rva = (uint)method.RVA;
                if (rva < 0x19E000) { skipped++; continue; }
                
                int token = (int)method.MDToken.Raw;
                string decFile;
                if (!decFiles.TryGetValue(token, out decFile)) { skipped++; continue; }
                
                byte[] resolvedIl = File.ReadAllBytes(decFile); // raw IL only
                uint fileOff = (uint)peImage.ToFileOffset((RVA)rva);
                
                // Compute space available (RVA gap)
                uint nextRva = rva + 256;
                bool found = false;
                foreach (var t2 in mod.GetTypes())
                    foreach (var m2 in t2.Methods) {
                        uint mrva = (uint)m2.RVA;
                        if (mrva > rva && m2.MDToken.Raw != (uint)method.MDToken.Raw) {
                            if (!found || mrva < nextRva) { nextRva = mrva; found = true; }
                        }
                    }
                uint nextRaw = (uint)peImage.ToFileOffset((RVA)nextRva);
                int availSize = (int)(nextRaw - fileOff);
                if (availSize <= 0 || availSize > 0x10000) availSize = 256;
                if (fileOff + availSize > pe.Length) availSize = (int)(pe.Length - fileOff);
                
                // Build new body: COR_ILMETHOD header + resolved IL
                byte[] newBody;
                if (resolvedIl.Length < 64) {
                    // Tiny header
                    newBody = new byte[1 + resolvedIl.Length];
                    newBody[0] = (byte)((resolvedIl.Length << 2) | 0x02);
                    Buffer.BlockCopy(resolvedIl, 0, newBody, 1, resolvedIl.Length);
                } else {
                    // Fat header
                    newBody = new byte[12 + resolvedIl.Length];
                    newBody[0] = 0x03; newBody[1] = 0x30;
                    newBody[2] = 0x08; newBody[3] = 0x00;
                    newBody[4] = (byte)resolvedIl.Length;
                    newBody[5] = (byte)(resolvedIl.Length >> 8);
                    newBody[6] = (byte)(resolvedIl.Length >> 16);
                    newBody[7] = (byte)(resolvedIl.Length >> 24);
                    Buffer.BlockCopy(resolvedIl, 0, newBody, 12, resolvedIl.Length);
                }
                
                // Replace body data (pad with zeros if needed, truncate if too large)
                int writeSize = Math.Min(newBody.Length, availSize);
                Array.Copy(newBody, 0, pe, fileOff, writeSize);
                if (writeSize < availSize) {
                    // Zero out remaining space
                    Array.Clear(pe, (int)(fileOff + writeSize), availSize - writeSize);
                }
                patched++;
            }
        }
        Console.WriteLine("Patched: {0}, Skipped: {1}", patched, skipped);
        
        // Step 3: Fix entry point - stub it with a proper body
        var ep = mod.EntryPoint;
        if (ep != null && ep.Body == null) {
            Console.WriteLine("Entry point {0}.{1} has no body, fixing...", ep.DeclaringType.Name, ep.Name);
            // Stub entry point with ret body
            // Need to find it in the PE and write a tiny ret body
            uint epRva = (uint)ep.RVA;
            if (epRva != 0 && epRva < 0x19E000) {
                uint epFileOff = (uint)peImage.ToFileOffset((RVA)epRva);
                // Write tiny body: 0x06 (header, codeSize=1) 0x2A (ret)
                pe[epFileOff] = 0x06;
                pe[epFileOff + 1] = 0x2A;
                Console.WriteLine("  Patched entry point body at 0x{0:X8}", epFileOff);
            }
        }
        
        File.WriteAllBytes(outPath, pe);
        Console.WriteLine("Saved to {0} ({1} bytes)", outPath, pe.Length);
    }
}
