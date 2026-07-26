using System;
using System.IO;
using dnlib.DotNet;
using dnlib.PE;
using dnlib.IO;

class FindMeta {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        var mod = ModuleDefMD.Load(path);
        IPEImage pe = mod.Metadata.PEImage;
        uint cor20Rva = (uint)pe.ImageNTHeaders.OptionalHeader.DataDirectories[14].VirtualAddress;
        Console.WriteLine("COR20 header RVA: 0x{0:X8}", cor20Rva);
        uint metaRva = 0;
        
        // Read COR20 header to find metadata RVA
        byte[] peBytes = File.ReadAllBytes(path);
        // COR20 is at cor20Rva
        // At COR20 + 8: metadata directory (RVA at +8, size at +12)
        uint cor20Raw = (uint)pe.ToFileOffset((RVA)cor20Rva);
        Console.WriteLine("COR20 raw offset: 0x{0:X8}", cor20Raw);
        if (cor20Raw == 0 || cor20Raw >= peBytes.Length) {
            Console.WriteLine("COR20 not found");
            return;
        }
        metaRva = (uint)(peBytes[cor20Raw+8] | (peBytes[cor20Raw+9]<<8) | (peBytes[cor20Raw+10]<<16) | (peBytes[cor20Raw+11]<<24));
        uint metaSize = (uint)(peBytes[cor20Raw+12] | (peBytes[cor20Raw+13]<<8) | (peBytes[cor20Raw+14]<<16) | (peBytes[cor20Raw+15]<<24));
        Console.WriteLine("Metadata RVA: 0x{0:X8}, Size: 0x{1:X8}", metaRva, metaSize);
        
        // Convert to file offset
        uint metaRaw = (uint)pe.ToFileOffset((RVA)metaRva);
        Console.WriteLine("Metadata raw offset: 0x{0:X8}", metaRaw);
        
        // Check first few bytes
        Console.WriteLine("Metadata signature:");
        for (int i = 0; i < 16 && metaRaw+i < peBytes.Length; i++)
            Console.Write("{0:X2} ", peBytes[metaRaw+i]);
        Console.WriteLine();
        
        // List sections and their file ranges
        Console.WriteLine("\nSections:");
        foreach (var sec in pe.ImageSectionHeaders) {
            uint vaddr = (uint)sec.VirtualAddress;
            uint vsize = Math.Max((uint)sec.VirtualSize, (uint)sec.SizeOfRawData);
            uint rawOff = (uint)sec.PointerToRawData;
            uint rawSize = (uint)sec.SizeOfRawData;
            uint rawEnd = rawOff + (rawSize > 0 ? rawSize : vsize);
            Console.WriteLine("  V=0x{0:X8}-0x{1:X8} R=0x{2:X8}-0x{3:X8}", 
                vaddr, vaddr+vsize, rawOff, rawEnd);
            Console.WriteLine("    Metadata in section: {0}", 
                (metaRva >= vaddr && metaRva < vaddr+vsize) ? "YES" : "NO");
            Console.WriteLine("    zN| section: {0}",
                (vaddr == 0x19E000) ? "YES" : "NO");
        }
    }
}
