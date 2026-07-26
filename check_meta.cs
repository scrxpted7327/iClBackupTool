using System;
using System.IO;
using dnlib.DotNet;
using dnlib.PE;

class CheckMeta {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup_final2.exe";
        byte[] pe = File.ReadAllBytes(path);
        
        // Parse metadata location (same as in rebuild5)
        var mod = ModuleDefMD.Load(path);
        IPEImage peImage = mod.Metadata.PEImage;
        uint cor20Rva = (uint)peImage.ImageNTHeaders.OptionalHeader.DataDirectories[14].VirtualAddress;
        uint cor20Raw = (uint)peImage.ToFileOffset((RVA)cor20Rva);
        uint metaRva = (uint)(pe[cor20Raw+8] | (pe[cor20Raw+9]<<8) | (pe[cor20Raw+10]<<16) | (pe[cor20Raw+11]<<24));
        uint metaSize = (uint)(pe[cor20Raw+12] | (pe[cor20Raw+13]<<8) | (pe[cor20Raw+14]<<16) | (pe[cor20Raw+15]<<24));
        uint metaRaw = (uint)peImage.ToFileOffset((RVA)metaRva);
        
        Console.WriteLine("Metadata at fileOff=0x{0:X8}", metaRaw);
        Console.Write("Signature: ");
        for (int i = 0; i < 16; i++) Console.Write("{0:X2} ", pe[metaRaw + i]);
        Console.WriteLine();
        
        // Also check original
        byte[] orig = File.ReadAllBytes(@"C:\deobfuscate\SpiderBackup.exe");
        Console.WriteLine("\nOriginal signature:");
        Console.Write("Signature: ");
        for (int i = 0; i < 16; i++) Console.Write("{0:X2} ", orig[metaRaw + i]);
        Console.WriteLine();
    }
}
