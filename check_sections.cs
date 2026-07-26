using System;
using System.IO;
using dnlib.DotNet;
using dnlib.PE;

class CheckSections {
    static void Main() {
        var pe = new PEImage(@"C:\deobfuscate\SpiderBackup.exe");
        Console.WriteLine("Sections:");
        foreach (var s in pe.ImageSectionHeaders) {
            Console.WriteLine("  {0}: RVA=0x{1:X8}-0x{2:X8} raw=0x{3:X8}-0x{4:X8} size=0x{5:X8}",
                s.DisplayName,
                (uint)s.VirtualAddress,
                (uint)s.VirtualAddress + s.VirtualSize,
                (uint)s.PointerToRawData,
                (uint)s.PointerToRawData + s.SizeOfRawData,
                s.VirtualSize);
        }
        
        // Check which section covers RVA 0x9145
        Console.WriteLine("\nRVA 0x9145 mapping:");
        foreach (var s in pe.ImageSectionHeaders) {
            uint start = (uint)s.VirtualAddress;
            uint end = start + Math.Max(s.VirtualSize, s.SizeOfRawData);
            if (0x9145 >= start && 0x9145 < end) {
                uint rawOff = (uint)s.PointerToRawData + (0x9145 - start);
                Console.WriteLine("  In section {0} at file offset 0x{1:X8}", s.DisplayName, rawOff);
            }
        }
        
        // Check ALL method entries from metadata for those with RVA around 0x9145
        var mod = ModuleDefMD.Load(@"C:\deobfuscate\SpiderBackup.exe");
        Console.WriteLine("\nMethods with RVA in 0x9000-0xA000:");
        foreach (var t in mod.GetTypes())
            foreach (var m in t.Methods) {
                uint rva = (uint)m.RVA;
                if (rva >= 0x9000 && rva < 0xA000) {
                    uint rawOff;
                    try { rawOff = (uint)mod.Metadata.PEImage.ToFileOffset((RVA)rva); } catch { rawOff = 0xFFFFFFFF; }
                    Console.WriteLine("  {0}.{1} RVA=0x{2:X8} raw=0x{3:X8} Body={4}",
                        m.DeclaringType.Name, m.Name, rva, rawOff, m.Body != null ? "Y" : "N");
                }
            }
    }
}
