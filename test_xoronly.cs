using System;
using System.IO;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.PE;

class TestXorOnly {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        string outPath = @"C:\deobfuscate\SpiderBackup_xoronly.exe";
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        
        var mod = ModuleDefMD.Load(path);
        IPEImage peImage = mod.Metadata.PEImage;
        byte[] pe = File.ReadAllBytes(path);
        
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
        
        // Find CLR header and metadata to protect them
        uint cor20Rva = (uint)peImage.ImageNTHeaders.OptionalHeader.DataDirectories[14].VirtualAddress;
        uint cor20Raw = (uint)peImage.ToFileOffset((RVA)cor20Rva);
        cor20Raw -= cor20Raw % 8;
        Console.WriteLine("CLR header: RVA=0x{0:X8} raw=0x{1:X8}", cor20Rva, cor20Raw);
        
        // Read metadata RVA from CLR header
        uint metaRva = (uint)(pe[cor20Raw+8] | (pe[cor20Raw+9]<<8) | (pe[cor20Raw+10]<<16) | (pe[cor20Raw+11]<<24));
        uint metaSize = (uint)(pe[cor20Raw+12] | (pe[cor20Raw+13]<<8) | (pe[cor20Raw+14]<<16) | (pe[cor20Raw+15]<<24));
        uint metaRaw = (uint)peImage.ToFileOffset((RVA)metaRva);
        uint metaEnd = metaRaw + metaSize;
        Console.WriteLine("Metadata: RVA=0x{0:X8} raw=0x{1:X8}-0x{2:X8} size={3}", 
            metaRva, metaRaw, metaEnd, metaSize);
        Console.WriteLine("Metadata in .zN|? {0}", metaRva >= 0x19E000 ? "YES" : "NO");
        
        // XOR-decrypt body ranges of .zN| methods, protecting metadata/CLR
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
                
                // Key aligned to refFileOff
                long off = (long)fileOff - (long)refFileOff;
                for (int i = 0; i < bodySize; i++) {
                    uint testOff = fileOff + (uint)i;
                    // Protect CLR header and metadata
                    if (testOff >= cor20Raw && testOff < cor20Raw + 72) continue;
                    if (metaRva >= 0x19E000 && testOff >= metaRaw && testOff < metaEnd) continue;
                    int ki = (int)((off + i) % keyLen);
                    if (ki < 0) ki += keyLen;
                    pe[testOff] ^= xorKey[ki];
                }
            }
        }
        
        File.WriteAllBytes(outPath, pe);
        Console.WriteLine("Saved XOR-only to " + outPath);
        Console.WriteLine("File size: {0} bytes", pe.Length);
        
        // Verify - try loading as PE
        try {
            var pe2 = new PEImage(outPath);
            Console.WriteLine("PEImage OK, sections={0}", pe2.ImageSectionHeaders.Count);
        } catch (Exception ex) {
            Console.WriteLine("PEImage ERROR: {0}", ex.Message);
        }
        try {
            var mod2 = ModuleDefMD.Load(outPath);
            int bodies=0, noBodies=0;
            foreach (var t in mod2.GetTypes())
                foreach (var m in t.Methods)
                    if (m.Body != null && m.RVA != 0) bodies++;
                    else if (m.RVA != 0) noBodies++;
            Console.WriteLine("Module OK: bodies={0}, nullBodyWithRVA={1}", bodies, noBodies);
        } catch (Exception ex) {
            Console.WriteLine("Module ERROR: {0}", ex.Message);
        }
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
