using System;
using System.IO;
using dnlib.DotNet;
using dnlib.PE;

class CheckMeta2 {
    static void Main() {
        byte[] pe = File.ReadAllBytes(@"C:\deobfuscate\SpiderBackup.exe");
        
        // Parse PE headers manually
        uint e_lfanew = (uint)(pe[0x3C] | (pe[0x3D]<<8) | (pe[0x3E]<<16) | (pe[0x3F]<<24));
        uint ntHeader = e_lfanew + 4; // skip PE\0\0
        ushort numSections = (ushort)(pe[e_lfanew+6] | (pe[e_lfanew+7]<<8));
        ushort optHdrSize = (ushort)(pe[e_lfanew+20] | (pe[e_lfanew+21]<<8));
        uint sectionsStart = ntHeader + 20 + optHdrSize;
        
        // Data directory 14 (CLR Runtime Header)
        uint dataDirBase = ntHeader + 20 + 112; // +96 for 32-bit, +112 for 64-bit
        uint clrRva = (uint)(pe[dataDirBase+0] | (pe[dataDirBase+1]<<8) | (pe[dataDirBase+2]<<16) | (pe[dataDirBase+3]<<24));
        Console.WriteLine("CLR Header RVA: 0x{0:X8}", clrRva);
        
        // Read sections to convert RVA to file offset
        Console.WriteLine("\nSection headers:");
        for (int i = 0; i < numSections; i++) {
            uint sStart = sectionsStart + (uint)(i * 40);
            string name = "";
            for (int j = 0; j < 8; j++) {
                char c = (char)pe[sStart + j];
                if (c == 0) break;
                name += c;
            }
            uint vAddr = (uint)(pe[sStart+12] | (pe[sStart+13]<<8) | (pe[sStart+14]<<16) | (pe[sStart+15]<<24));
            uint vSize = (uint)(pe[sStart+16] | (pe[sStart+17]<<8) | (pe[sStart+18]<<16) | (pe[sStart+19]<<24));
            uint rawAddr = (uint)(pe[sStart+20] | (pe[sStart+21]<<8) | (pe[sStart+22]<<16) | (pe[sStart+23]<<24));
            uint rawSize = (uint)(pe[sStart+24] | (pe[sStart+25]<<8) | (pe[sStart+26]<<16) | (pe[sStart+27]<<24));
            Console.WriteLine("  {0}: V=0x{1:X8} VS=0x{2:X8} R=0x{3:X8}+0x{4:X8}", name, vAddr, vSize, rawAddr, rawSize);
        }
        
        // Convert CLR RVA to file offset
        uint clrRaw = 0;
        for (int i = 0; i < numSections; i++) {
            uint sStart = sectionsStart + (uint)(i * 40);
            uint vAddr = (uint)(pe[sStart+12] | (pe[sStart+13]<<8) | (pe[sStart+14]<<16) | (pe[sStart+15]<<24));
            uint vSize = (uint)(pe[sStart+16] | (pe[sStart+17]<<8) | (pe[sStart+18]<<16) | (pe[sStart+19]<<24));
            uint rawAddr = (uint)(pe[sStart+20] | (pe[sStart+21]<<8) | (pe[sStart+22]<<16) | (pe[sStart+23]<<24));
            if (clrRva >= vAddr && clrRva < vAddr + vSize && rawAddr != 0) {
                clrRaw = rawAddr + (clrRva - vAddr);
                break;
            }
        }
        Console.WriteLine("CLR Header file off: 0x{0:X8}", clrRaw);
        
        // Read metadata RVA and size from CLR header
        uint metaRva = (uint)(pe[clrRaw+8] | (pe[clrRaw+9]<<8) | (pe[clrRaw+10]<<16) | (pe[clrRaw+11]<<24));
        uint metaSize = (uint)(pe[clrRaw+12] | (pe[clrRaw+13]<<8) | (pe[clrRaw+14]<<16) | (pe[clrRaw+15]<<24));
        Console.WriteLine("Meta RVA: 0x{0:X8} Size: 0x{1:X8}", metaRva, metaSize);
        
        // Convert meta RVA to file offset
        uint metaRaw = 0;
        for (int i = 0; i < numSections; i++) {
            uint sStart = sectionsStart + (uint)(i * 40);
            uint vAddr = (uint)(pe[sStart+12] | (pe[sStart+13]<<8) | (pe[sStart+14]<<16) | (pe[sStart+15]<<24));
            uint vSize = (uint)(pe[sStart+16] | (pe[sStart+17]<<8) | (pe[sStart+18]<<16) | (pe[sStart+19]<<24));
            uint rawAddr = (uint)(pe[sStart+20] | (pe[sStart+21]<<8) | (pe[sStart+22]<<16) | (pe[sStart+23]<<24));
            if (metaRva >= vAddr && metaRva < vAddr + vSize && rawAddr != 0) {
                metaRaw = rawAddr + (metaRva - vAddr);
                break;
            }
        }
        Console.WriteLine("Meta file off: 0x{0:X8}", metaRaw);
        
        // Read metadata signature from original
        Console.Write("\nOriginal meta signature: ");
        for (int i = 0; i < 16; i++) Console.Write("{0:X2} ", pe[metaRaw + i]);
        Console.WriteLine();
        
        // Check the saved output file
        byte[] pe2 = File.ReadAllBytes(@"C:\deobfuscate\SpiderBackup_final2.exe");
        Console.Write("Output meta signature: ");
        for (int i = 0; i < 16; i++) Console.Write("{0:X2} ", pe2[metaRaw + i]);
        Console.WriteLine();
        
        // Check what's around the method at 0x116EF8-0x116FF8
        Console.WriteLine("\nBytes at 0x116EF8-0x117008 (original):");
        for (uint i = 0x116EF8; i < 0x117008; i++) {
            Console.Write("{0:X2} ", pe[i]);
            if ((i - 0x116EF8 + 1) % 16 == 0) Console.WriteLine();
        }
        Console.WriteLine("\nBytes at 0x116EF8-0x117008 (output):");
        for (uint i = 0x116EF8; i < 0x117008; i++) {
            Console.Write("{0:X2} ", pe2[i]);
            if ((i - 0x116EF8 + 1) % 16 == 0) Console.WriteLine();
        }
    }
}
