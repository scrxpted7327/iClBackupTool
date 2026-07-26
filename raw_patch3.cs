using System;
using System.IO;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.PE;
using dnlib.DotNet.Emit;
using dnlib.IO;

class RawPatch3 {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        string outPath = @"C:\deobfuscate\SpiderBackup_rawpatched3.exe";
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        
        var mod = ModuleDefMD.Load(path);
        IPEImage peImage = mod.Metadata.PEImage;
        byte[] pe = File.ReadAllBytes(path);
        
        // Build .dec file lookup by method token
        var decFiles = new Dictionary<int, string>();
        foreach (var f in Directory.GetFiles(dumpDir, "*.dec")) {
            string name = Path.GetFileNameWithoutExtension(f);
            string ext = Path.GetExtension(f);
            if (ext == ".dec") {
                string[] parts = name.Split('_');
                if (parts.Length == 2) {
                    int methodToken = Convert.ToInt32(parts[1], 16);
                    decFiles[methodToken] = f;
                }
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
        
        // Debug: check .text method tokens vs .dec files
        Console.WriteLine("\n--- Debug: .text method .dec files ---");
        int textDecFound = 0, textDecMissing = 0, sampleCount = 0;
        foreach (var type in mod.GetTypes()) {
            foreach (var method in type.Methods) {
                if (method.RVA == 0) continue;
                if ((uint)method.RVA >= 0x19E000) continue;
                int token = (int)method.MDToken.Raw;
                bool hasDec = decFiles.ContainsKey(token);
                if (hasDec) textDecFound++;
                else textDecMissing++;
                if (sampleCount < 3) {
                    Console.WriteLine("  {0}.{1} token=0x{2:X8} hasDec={3}", 
                        method.DeclaringType.Name, method.Name, token, hasDec);
                    sampleCount++;
                }
            }
        }
        Console.WriteLine(".text: {0} with .dec, {1} without .dec", textDecFound, textDecMissing);
        
        // Check the first few .dec filenames
        Console.WriteLine("\nFirst 5 .dec filenames:");
        int n = 0;
        foreach (var kv in decFiles) {
            Console.WriteLine("  token=0x{0:X8} -> {1}", kv.Key, kv.Value);
            if (++n >= 5) break;
        }
        Console.WriteLine("Total .dec files loaded: {0}", decFiles.Count);
        
        // Step 1: XOR-decrypt .zN| section
        uint cor20Rva = (uint)peImage.ImageNTHeaders.OptionalHeader.DataDirectories[14].VirtualAddress;
        uint cor20Raw = (uint)peImage.ToFileOffset((RVA)cor20Rva);
        cor20Raw -= cor20Raw % 8;
        uint metaRva = (uint)(pe[cor20Raw+8] | (pe[cor20Raw+9]<<8) | (pe[cor20Raw+10]<<16) | (pe[cor20Raw+11]<<24));
        uint metaSize = (uint)(pe[cor20Raw+12] | (pe[cor20Raw+13]<<8) | (pe[cor20Raw+14]<<16) | (pe[cor20Raw+15]<<24));
        uint metaRaw = (uint)peImage.ToFileOffset((RVA)metaRva);
        uint metaEnd = metaRaw + metaSize;
        
        int decrypted = 0;
        foreach (var type in mod.GetTypes()) {
            foreach (var method in type.Methods) {
                if (method.RVA == 0) continue;
                uint rva = (uint)method.RVA;
                if (rva < 0x19E000) continue;
                
                uint fileOff = (uint)peImage.ToFileOffset((RVA)rva);
                uint nextRva = GetNextMethodRva(mod, method, rva);
                uint nextRaw = (uint)peImage.ToFileOffset((RVA)nextRva);
                int bodySize = (int)(nextRaw - fileOff);
                if (bodySize <= 0 || bodySize > 0x10000) bodySize = 256;
                if (fileOff + bodySize > pe.Length) bodySize = (int)(pe.Length - fileOff);
                if (bodySize <= 2) continue;
                
                for (int i = 0; i < bodySize; i++) {
                    uint off = fileOff + (uint)i;
                    if (off >= metaRaw && off < metaEnd) continue;
                    if (off >= cor20Raw && off < cor20Raw + 72) continue;
                    pe[off] ^= xorKey[i % keyLen];
                }
                decrypted++;
            }
        }
        Console.WriteLine("XOR-decrypted {0} methods", decrypted);
        
        // Step 2: Replace method bodies with .dec file data (for ALL methods, both .text and .zN|)
        int patched = 0, skipped = 0, truncated = 0;
        foreach (var type in mod.GetTypes()) {
            foreach (var method in type.Methods) {
                if (method.RVA == 0) continue;
                uint rva = (uint)method.RVA;
                
                int token = (int)method.MDToken.Raw;
                string decFile;
                if (!decFiles.TryGetValue(token, out decFile)) {
                    skipped++;
                    continue;
                }
                
                byte[] resolvedIl = File.ReadAllBytes(decFile);
                uint fileOff = (uint)peImage.ToFileOffset((RVA)rva);
                
                // Compute available body space
                uint nextRva = GetNextMethodRva(mod, method, rva);
                uint nextRaw = (uint)peImage.ToFileOffset((RVA)nextRva);
                int availSize = (int)(nextRaw - fileOff);
                if (availSize <= 0 || availSize > 0x10000) availSize = 256;
                if (fileOff + availSize > pe.Length) availSize = (int)(pe.Length - fileOff);
                
                // Build new COR_ILMETHOD body
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
                    newBody[8] = 0; newBody[9] = 0;
                    newBody[10] = 0; newBody[11] = 0;
                    Buffer.BlockCopy(resolvedIl, 0, newBody, 12, resolvedIl.Length);
                }
                
                int writeSize = Math.Min(newBody.Length, availSize);
                Array.Copy(newBody, 0, pe, fileOff, writeSize);
                if (writeSize < availSize) {
                    Array.Clear(pe, (int)(fileOff + writeSize), availSize - writeSize);
                }
                if (writeSize < newBody.Length) truncated++;
                patched++;
            }
        }
        Console.WriteLine("Patched: {0}, Skipped (no .dec): {1}, Truncated: {2}", 
            patched, skipped, truncated);
        
        // Step 3: Fix entry point - write a ret body if EP still has obfuscated body
        var ep = mod.EntryPoint;
        if (ep != null) {
            uint epRva = (uint)ep.RVA;
            Console.WriteLine("EP: {0}.{1} RVA=0x{2:X8}", 
                ep.DeclaringType.Name, ep.Name, epRva);
            if (epRva != 0) {
                // Find if EP has .dec file
                int epToken = (int)ep.MDToken.Raw;
                string epDecFile;
                if (!decFiles.TryGetValue(epToken, out epDecFile)) {
                    // No .dec file - stub it with a ret body
                    Console.WriteLine("  No .dec file for EP, stubbing with ret");
                    uint epFileOff = (uint)peImage.ToFileOffset((RVA)epRva);
                    // Write tiny ret body
                    pe[epFileOff] = 0x06;  // tiny header, codeSize=1
                    pe[epFileOff + 1] = 0x2A; // ret
                } else {
                    Console.WriteLine("  EP has .dec file, already patched");
                }
            }
        }
        
        File.WriteAllBytes(outPath, pe);
        Console.WriteLine("Saved to {0} ({1} bytes)", outPath, pe.Length);
    }
    
    static uint GetNextMethodRva(ModuleDefMD mod, MethodDef method, uint rva) {
        uint nextRva = rva + 256;
        foreach (var t in mod.GetTypes())
            foreach (var m in t.Methods) {
                uint mrva = (uint)m.RVA;
                if (mrva > rva && m.MDToken.Raw != method.MDToken.Raw) {
                    if (mrva < nextRva) nextRva = mrva;
                }
            }
        return nextRva;
    }
}
