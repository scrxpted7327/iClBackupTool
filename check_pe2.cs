using System;
using System.IO;
using System.Text;
class CheckPe2 {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        byte[] pe = File.ReadAllBytes(path);
        Console.WriteLine("File size: {0} bytes (0x{0:X})", pe.Length);
        
        uint e_lfanew = (uint)(pe[0x3C] | (pe[0x3D]<<8) | (pe[0x3E]<<16) | (pe[0x3F]<<24));
        Console.WriteLine("e_lfanew at 0x3C: 0x{0:X8}", e_lfanew);
        
        // Check PE signature
        string sig = "" + (char)pe[e_lfanew] + (char)pe[e_lfanew+1] + (char)pe[e_lfanew+2] + (char)pe[e_lfanew+3];
        Console.WriteLine("PE signature: {0}", sig.Replace("\0", "\\0"));
        
        ushort machine = (ushort)(pe[e_lfanew+4] | (pe[e_lfanew+5]<<8));
        ushort numSections = (ushort)(pe[e_lfanew+6] | (pe[e_lfanew+7]<<8));
        Console.WriteLine("Machine: 0x{0:X4}", machine);
        Console.WriteLine("Sections: {0}", numSections);
        
        ushort optHdrSize = (ushort)(pe[e_lfanew+16] | (pe[e_lfanew+17]<<8));
        ushort magic = (ushort)(pe[e_lfanew+24] | (pe[e_lfanew+25]<<8));
        Console.WriteLine("OptHdrSize: {0} (0x{0:X})", optHdrSize);
        Console.WriteLine("Magic: 0x{0:X4} (0x10B=PE32, 0x20B=PE32+)", magic);
        
        uint secOff = e_lfanew + 24 + optHdrSize;
        Console.WriteLine("Section offset: 0x{0:X8}", secOff);
        
        for (int i = 0; i < numSections; i++) {
            uint s = secOff + (uint)(i * 40);
            byte[] nameBytes = new byte[8];
            Array.Copy(pe, s, nameBytes, 0, 8);
            string name = Encoding.ASCII.GetString(nameBytes).TrimEnd('\0');
            
            uint vsize = (uint)(pe[s+8] | (pe[s+9]<<8) | (pe[s+10]<<16) | (pe[s+11]<<24));
            uint vaddr = (uint)(pe[s+12] | (pe[s+13]<<8) | (pe[s+14]<<16) | (pe[s+15]<<24));
            uint rawSize = (uint)(pe[s+16] | (pe[s+17]<<8) | (pe[s+18]<<16) | (pe[s+19]<<24));
            uint rawOff = (uint)(pe[s+20] | (pe[s+21]<<8) | (pe[s+22]<<16) | (pe[s+23]<<24));
            uint characteristics = (uint)(pe[s+36] | (pe[s+37]<<8) | (pe[s+38]<<16) | (pe[s+39]<<24));
            
            Console.WriteLine("  [{0}] name='{1}' V={2:X8}-{3:X8}({4}) R={5:X8}+{6:X8} chars=0x{7:X8}",
                i, name.Replace("\0","."), vaddr, vaddr+vsize, vsize, rawOff, rawSize, characteristics);
        }
        
        // Also peek at offset 0x2000 (typical .text section)
        Console.WriteLine("\nBytes at 0x2000:");
        for (int i = 0; i < 32; i++)
            Console.Write("{0:X2} ", pe[0x2000+i]);
        Console.WriteLine();
        
        // Check IMAGE_DIRECTORY_ENTRY_IMPORT
        uint importRVA = (magic == 0x20B) ? 
            (uint)(pe[e_lfanew+24+112] | (pe[e_lfanew+24+113]<<8) | (pe[e_lfanew+24+114]<<16) | (pe[e_lfanew+24+115]<<24)) :
            (uint)(pe[e_lfanew+24+104] | (pe[e_lfanew+24+105]<<8) | (pe[e_lfanew+24+106]<<16) | (pe[e_lfanew+24+107]<<24));
        Console.WriteLine("Import table RVA: 0x{0:X8}", importRVA);
    }
}
