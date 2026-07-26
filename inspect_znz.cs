using System;
using System.IO;
using dnlib.PE;

class InspectZnz {
    static void Main() {
        byte[] peBytes = File.ReadAllBytes(@"C:\deobfuscate\SpiderBackup.exe");
        
        // Find .zN| section manually from PE headers
        // e_lfanew at offset 0x3C
        int e_lfanew = peBytes[0x3C] | (peBytes[0x3D]<<8) | (peBytes[0x3E]<<16) | (peBytes[0x3F]<<24);
        Console.WriteLine("e_lfanew at 0x{0:X8}", e_lfanew);
        
        int numSections = peBytes[e_lfanew + 6] | (peBytes[e_lfanew + 7]<<8);
        int sectionTableOff = e_lfanew + 0xF8; // SizeOfOptionalHeader = 0xE0, but use 0xF8 to be safe
        // Let's read it properly
        int optHeaderSize = peBytes[e_lfanew + 17] | (peBytes[e_lfanew + 17 + 1]<<8);
        sectionTableOff = e_lfanew + 20 + optHeaderSize;
        Console.WriteLine("NumSections: {0}", numSections);
        Console.WriteLine("Section table offset: 0x{0:X8}", sectionTableOff);
        
        for (int i = 0; i < numSections; i++) {
            int off = sectionTableOff + i * 40;
            string name = "";
            for (int j = 0; j < 8; j++) {
                char c = (char)peBytes[off + j];
                if (c == 0) break;
                name += c;
            }
            uint vSize = (uint)(peBytes[off+8] | (peBytes[off+9]<<8) | (peBytes[off+10]<<16) | (peBytes[off+11]<<24));
            uint vAddr = (uint)(peBytes[off+12] | (peBytes[off+13]<<8) | (peBytes[off+14]<<16) | (peBytes[off+15]<<24));
            uint rSize = (uint)(peBytes[off+16] | (peBytes[off+17]<<8) | (peBytes[off+18]<<16) | (peBytes[off+19]<<24));
            uint rAddr = (uint)(peBytes[off+20] | (peBytes[off+21]<<8) | (peBytes[off+22]<<16) | (peBytes[off+23]<<24));
            
            Console.WriteLine("  {0,-8} V=0x{1:X8}-0x{2:X8} R=0x{3:X8} S={4}",
                name, vAddr, vAddr + vSize, rAddr, rSize);
            
            if (name.StartsWith(".zN") || name.StartsWith("#")) {
                uint rawOff = rAddr;
                Console.WriteLine("\nFirst 256 bytes of {0} at raw=0x{1:X8}:", name, rawOff);
                for (int j = 0; j < 256 && rawOff + j < peBytes.Length; j++) {
                    Console.Write("{0:X2} ", peBytes[rawOff + j]);
                    if ((j + 1) % 32 == 0) Console.WriteLine();
                }
                Console.WriteLine();
                
                // Stats on potential COR_ILMETHOD headers
                int tinyCount = 0, fatCount = 0, otherCount = 0;
                for (int j = 0; j < 200 && rawOff + j < peBytes.Length; j++) {
                    byte b = peBytes[rawOff + j];
                    if ((b & 3) == 2) tinyCount++;
                    else if ((b & 0x0F) == 0x03) fatCount++;
                    else if (b != 0) otherCount++;
                }
                Console.WriteLine("Raw: tiny={0}, fat={1}, other={2}", tinyCount, fatCount, otherCount);
                
                // Also check decrypted version
                if (File.Exists(@"C:\deobfuscate\SpiderBackup_xoronly.exe")) {
                    var decBytes = File.ReadAllBytes(@"C:\deobfuscate\SpiderBackup_xoronly.exe");
                    tinyCount = 0; fatCount = 0; otherCount = 0;
                    for (int j = 0; j < 200 && rawOff + j < decBytes.Length; j++) {
                        byte b = decBytes[rawOff + j];
                        if ((b & 3) == 2) tinyCount++;
                        else if ((b & 0x0F) == 0x03) fatCount++;
                        else if (b != 0) otherCount++;
                    }
                    Console.WriteLine("Decrypted: tiny={0}, fat={1}, other={2}", tinyCount, fatCount, otherCount);
                    Console.WriteLine("\nFirst 256 decrypted bytes:");
                    for (int j = 0; j < 256 && rawOff + j < decBytes.Length; j++) {
                        Console.Write("{0:X2} ", decBytes[rawOff + j]);
                        if ((j + 1) % 32 == 0) Console.WriteLine();
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

