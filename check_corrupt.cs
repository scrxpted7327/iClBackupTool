using System;
using System.IO;
using dnlib.DotNet;
using dnlib.PE;

class CheckCorrupt {
    static void Main() {
        // Load both files via dnlib's low-level PE parser (NO metadata loading)
        var peOrig = new NativePEImage(@"C:\deobfuscate\SpiderBackup.exe", true);
        var peOut = new NativePEImage(@"C:\deobfuscate\SpiderBackup_final2.exe", true);
        
        // Check data directories
        Console.WriteLine("=== Original ===");
        PrintDataDir(peOrig, 14, "CLR Runtime");
        
        Console.WriteLine("=== Output ===");
        PrintDataDir(peOut, 14, "CLR Runtime");
        
        // Get .zN| section bounds
        Console.WriteLine("\n=== Sections ===");
        foreach (var sec in peOrig.ImageSectionHeaders)
            Console.WriteLine("  {0}: V=0x{1:X8} VS=0x{2:X8} R=0x{3:X8}+0x{4:X8}", 
                sec.Name, sec.VirtualAddress, sec.VirtualSize, 
                sec.PointerToRawData, sec.SizeOfRawData);
        
        // Check CLR header content
        uint clrRva = (uint)peOrig.ImageNTHeaders.OptionalHeader.DataDirectories[14].VirtualAddress;
        uint clrRaw = (uint)peOrig.ToFileOffset((RVA)clrRva);
        byte[] orig = File.ReadAllBytes(@"C:\deobfuscate\SpiderBackup.exe");
        byte[] outb = File.ReadAllBytes(@"C:\deobfuscate\SpiderBackup_final2.exe");
        
        Console.WriteLine("\nCLR header at fileOff=0x{0:X8}", clrRaw);
        Console.Write("Original: ");
        for (int i = 0; i < 24; i++) Console.Write("{0:X2} ", orig[clrRaw + i]);
        Console.WriteLine();
        Console.Write("Output:   ");
        for (int i = 0; i < 24; i++) Console.Write("{0:X2} ", outb[clrRaw + i]);
        Console.WriteLine();
        
        // Check what the metadata RVA in the CLR header says
        uint metaRva = (uint)(orig[clrRaw+8] | (orig[clrRaw+9]<<8) | (orig[clrRaw+10]<<16) | (orig[clrRaw+11]<<24));
        uint metaRaw = (uint)peOrig.ToFileOffset((RVA)metaRva);
        Console.WriteLine("\nMetadata: RVA=0x{0:X8} fileOff=0x{1:X8}", metaRva, metaRaw);
    }
    
    static void PrintDataDir(IPEImage pe, int idx, string name) {
        var dd = pe.ImageNTHeaders.OptionalHeader.DataDirectories[idx];
        Console.WriteLine("  {0}: RVA=0x{1:X8} Size=0x{2:X8}", name, dd.VirtualAddress, dd.Size);
    }
}
