using System;
using System.IO;

class CheckRaw {
    static void Main() {
        byte[] orig = File.ReadAllBytes(@"C:\deobfuscate\SpiderBackup.exe");
        byte[] outb = File.ReadAllBytes(@"C:\deobfuscate\SpiderBackup_final2.exe");
        
        int e_lfanew = (int)BitConverter.ToUInt32(orig, 0x3C);
        ushort machine = BitConverter.ToUInt16(orig, e_lfanew + 4);
        ushort numSects = BitConverter.ToUInt16(orig, e_lfanew + 6);
        ushort optSize = BitConverter.ToUInt16(orig, e_lfanew + 20);
        ushort magic = BitConverter.ToUInt16(orig, e_lfanew + 24);
        bool isPE32Plus = (magic == 0x20B);
        
        int ddStart = isPE32Plus ? e_lfanew + 24 + 112 : e_lfanew + 24 + 96;
        
        // Data directory [14] = CLR Runtime Header
        uint clrRva = BitConverter.ToUInt32(orig, ddStart + 14*8);
        uint clrSize = BitConverter.ToUInt32(orig, ddStart + 14*8 + 4);
        uint clrRva2 = BitConverter.ToUInt32(outb, ddStart + 14*8);
        uint clrSize2 = BitConverter.ToUInt32(outb, ddStart + 14*8 + 4);
        
        Console.WriteLine("CLR DD orig: RVA=0x{0:X8} Size=0x{1:X8}", clrRva, clrSize);
        Console.WriteLine("CLR DD out:  RVA=0x{0:X8} Size=0x{1:X8}", clrRva2, clrSize2);
        
        // Read section headers
        int secStart = e_lfanew + 24 + optSize;
        Console.WriteLine("\nSection headers:");
        for (int i = 0; i < numSects; i++) {
            int s = secStart + i * 40;
            string nm = "";
            for (int j = 0; j < 8 && orig[s+j] != 0; j++) nm += (char)orig[s+j];
            uint vSize = BitConverter.ToUInt32(orig, s + 8);
            uint vAddr = BitConverter.ToUInt32(orig, s + 12);
            uint rSize = BitConverter.ToUInt32(orig, s + 16);
            uint rAddr = BitConverter.ToUInt32(orig, s + 20);
            Console.WriteLine("  {0}: V=0x{1:X8} VS=0x{2:X8} R=0x{3:X8}+0x{4:X8}", nm, vAddr, vSize, rAddr, rSize);
        }
        
        // Convert CLR RVA to file offset
        uint clrRaw = 0;
        for (int i = 0; i < numSects; i++) {
            int s = secStart + i * 40;
            uint vAddr = BitConverter.ToUInt32(orig, s + 12);
            uint rAddr = BitConverter.ToUInt32(orig, s + 20);
            if (clrRva >= vAddr && rAddr != 0) {
                clrRaw = rAddr + (clrRva - vAddr);
                break;
            }
        }
        Console.WriteLine("\nCLR header orig file off: 0x{0:X8}", clrRaw);
        
        // Read CLR header
        int clrOff = (int)clrRaw;
        uint metaRva = BitConverter.ToUInt32(orig, clrOff + 8);
        uint metaSize = BitConverter.ToUInt32(orig, clrOff + 12);
        uint metaRva2 = BitConverter.ToUInt32(outb, clrOff + 8);
        uint metaSize2 = BitConverter.ToUInt32(outb, clrOff + 12);
        
        Console.WriteLine("Meta RVA orig: 0x{0:X8} Size: 0x{1:X8}", metaRva, metaSize);
        Console.WriteLine("Meta RVA out:  0x{0:X8} Size: 0x{1:X8}", metaRva2, metaSize2);
        
        // Convert meta RVA to file offset
        uint metaRaw = 0;
        for (int i = 0; i < numSects; i++) {
            int s = secStart + i * 40;
            uint vAddr = BitConverter.ToUInt32(orig, s + 12);
            uint rAddr = BitConverter.ToUInt32(orig, s + 20);
            if (metaRva >= vAddr && rAddr != 0) {
                metaRaw = rAddr + (metaRva - vAddr);
                break;
            }
        }
        Console.WriteLine("Meta file off: 0x{0:X8}", metaRaw);
        Console.Write("Orig meta: ");
        for (int i = 0; i < 16; i++) Console.Write("{0:X2} ", orig[metaRaw + i]);
        Console.WriteLine();
        Console.Write("Out meta:  ");
        for (int i = 0; i < 16; i++) Console.Write("{0:X2} ", outb[metaRaw + i]);
        Console.WriteLine();
        
        // CHECK: Are data directory bytes corrupted?
        Console.WriteLine("\nData dir [14] bytes orig: ");
        for (int i = 0; i < 8; i++) Console.Write("{0:X2} ", orig[ddStart + 14*8 + i]);
        Console.WriteLine("\nData dir [14] bytes out:  ");
        for (int i = 0; i < 8; i++) Console.Write("{0:X2} ", outb[ddStart + 14*8 + i]);
        Console.WriteLine();
        
        // Check CLR header bytes
        Console.WriteLine("\nCLR header orig bytes (fileOff=0x{0:X8}):", clrRaw);
        for (int i = 0; i < 24; i++) Console.Write("{0:X2} ", orig[clrOff + i]);
        Console.WriteLine("\nCLR header out bytes:");
        for (int i = 0; i < 24; i++) Console.Write("{0:X2} ", outb[clrOff + i]);
        Console.WriteLine();
    }
}
