using System;
using System.IO;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.PE;
using dnlib.DotNet.Emit;
using dnlib.IO;

class RawPatch2 {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        string outPath = @"C:\deobfuscate\SpiderBackup_rawpatched2.exe";
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        
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
        cor20Raw -= cor20Raw % 8; // align
        // Read CLR header to find metadata
        uint metaRva = (uint)(pe[cor20Raw+8] | (pe[cor20Raw+9]<<8) | (pe[cor20Raw+10]<<16) | (pe[cor20Raw+11]<<24));
        uint metaSize = (uint)(pe[cor20Raw+12] | (pe[cor20Raw+13]<<8) | (pe[cor20Raw+14]<<16) | (pe[cor20Raw+15]<<24));
        uint metaRaw = (uint)peImage.ToFileOffset((RVA)metaRva);
        uint metaEnd = metaRaw + metaSize;
        
        // Step 1: XOR-decrypt .zN| section in-place (header and IL)
        int decrypted = 0;
        foreach (var type in mod.GetTypes()) {
            foreach (var method in type.Methods) {
                if (method.RVA == 0) continue;
                uint rva = (uint)method.RVA;
                if (rva < 0x19E000) continue;
                
                uint fileOff = (uint)peImage.ToFileOffset((RVA)rva);
                
                // Compute body size from RVA gap
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
                if (bodySize <= 2) continue;
                
                for (int i = 0; i < bodySize; i++) {
                    uint off = fileOff + (uint)i;
                    // Protect CLR header and metadata from XOR corruption
                    if (off >= metaRaw && off < metaEnd) continue;
                    if (off >= cor20Raw && off < cor20Raw + 72) continue;
                    pe[off] ^= xorKey[i % keyLen];
                }
                decrypted++;
            }
        }
        Console.WriteLine("XOR-decrypted {0} methods", decrypted);
        
        // Step 2: Replace method bodies with .dec data
        int patched = 0;
        foreach (var type in mod.GetTypes()) {
            foreach (var method in type.Methods) {
                if (method.RVA == 0) continue;
                uint rva = (uint)method.RVA;
                if (rva < 0x19E000) continue;
                
                int token = (int)method.MDToken.Raw;
                string decFile;
                if (!decFiles.TryGetValue(token, out decFile)) continue;
                
                byte[] resolvedIl = File.ReadAllBytes(decFile);
                uint fileOff = (uint)peImage.ToFileOffset((RVA)rva);
                
                // Compute space available
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
                
                // Also check: read existing header to know code size
                int codeSizeFromHeader = 0;
                byte flags = pe[fileOff];
                if ((flags & 3) == 2) {
                    // Tiny: flags >> 2 is code size
                    codeSizeFromHeader = flags >> 2;
                } else {
                    // Fat
                    codeSizeFromHeader = pe[(int)fileOff+4] | (pe[(int)fileOff+5]<<8) | (pe[(int)fileOff+6]<<16) | (pe[(int)fileOff+7]<<24);
                }
                
                // Build new body
                byte[] newBody;
                if (resolvedIl.Length < 64) {
                    newBody = new byte[1 + resolvedIl.Length];
                    newBody[0] = (byte)((resolvedIl.Length << 2) | 0x02);
                    Buffer.BlockCopy(resolvedIl, 0, newBody, 1, resolvedIl.Length);
                } else {
                    newBody = new byte[12 + resolvedIl.Length];
                    newBody[0] = 0x03; newBody[1] = 0x30;
                    newBody[2] = 0x08; newBody[3] = 0x00;
                    newBody[4] = (byte)resolvedIl.Length;
                    newBody[5] = (byte)(resolvedIl.Length >> 8);
                    newBody[6] = (byte)(resolvedIl.Length >> 16);
                    newBody[7] = (byte)(resolvedIl.Length >> 24);
                    Buffer.BlockCopy(resolvedIl, 0, newBody, 12, resolvedIl.Length);
                }
                
                int writeSize = Math.Min(newBody.Length, availSize);
                Array.Copy(newBody, 0, pe, fileOff, writeSize);
                if (writeSize < availSize) {
                    Array.Clear(pe, (int)(fileOff + writeSize), availSize - writeSize);
                }
                patched++;
            }
        }
        Console.WriteLine("Patched {0} method bodies with .dec data", patched);
        
        // Step 3: For methods without .dec file in .zN|, just zero them out
        int stubbed = 0;
        foreach (var type in mod.GetTypes()) {
            foreach (var method in type.Methods) {
                if (method.RVA == 0) continue;
                uint rva = (uint)method.RVA;
                if (rva < 0x19E000) continue;
                int token = (int)method.MDToken.Raw;
                if (decFiles.ContainsKey(token)) continue;
                
                uint fileOff = (uint)peImage.ToFileOffset((RVA)rva);
                // Write a ret body
                pe[fileOff] = 0x06;  // tiny header, code size = 1
                pe[fileOff + 1] = 0x2A;  // ret
                stubbed++;
            }
        }
        Console.WriteLine("Stubbed {0} .zN| methods without .dec file", stubbed);
        
        File.WriteAllBytes(outPath, pe);
        Console.WriteLine("Saved {0} bytes to {1}", pe.Length, outPath);
    }
}
