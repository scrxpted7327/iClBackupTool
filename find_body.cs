using System;
using System.IO;

class FindBody {
    static void Main() {
        // Load the SAVED file (which works correctly)
        byte[] saved = File.ReadAllBytes(@"C:\deobfuscate\Patched_SpiderBackup.exe");
        
        // The cctor in the saved file has RVA 0x23F1
        uint rva = 0x23F1;
        
        // Find which section this RVA belongs to
        // Read PE headers
        uint e_lfanew = (uint)(saved[0x3C] | (saved[0x3D] << 8) | (saved[0x3E] << 16) | (saved[0x3F] << 24));
        ushort numSections = (ushort)(saved[e_lfanew + 6] | (saved[e_lfanew + 7] << 8));
        ushort optHdrSize = (ushort)(saved[e_lfanew + 16] | (saved[e_lfanew + 17] << 8));
        uint secOffset = e_lfanew + 24 + optHdrSize;
        
        Console.WriteLine("e_lfanew=0x{0:X}, sections={1}, optSize={2}", e_lfanew, numSections, optHdrSize);
        
        for (int i = 0; i < numSections; i++) {
            uint secStart = secOffset + (uint)(i * 40);
            string name = "";
            for (int j = 0; j < 8 && saved[secStart+j] != 0; j++)
                name += (char)saved[secStart+j];
            uint vaddr = (uint)(saved[secStart+12] | (saved[secStart+13] << 8) | (saved[secStart+14] << 16) | (saved[secStart+15] << 24));
            uint vsize = (uint)(saved[secStart+8] | (saved[secStart+9] << 8) | (saved[secStart+10] << 16) | (saved[secStart+11] << 24));
            uint rawAddr = (uint)(saved[secStart+20] | (saved[secStart+21] << 8) | (saved[secStart+22] << 16) | (saved[secStart+23] << 24));
            uint rawSize = (uint)(saved[secStart+16] | (saved[secStart+17] << 8) | (saved[secStart+18] << 16) | (saved[secStart+19] << 24));
            Console.WriteLine("  {0}: VAddr=0x{1:X} VSize=0x{2:X} Raw=0x{3:X} RawSize=0x{4:X}", name, vaddr, vsize, rawAddr, rawSize);
            
            if (rva >= vaddr && rva < vaddr + vsize) {
                uint fileOff = rawAddr + (rva - vaddr);
                Console.WriteLine("\nBody at RVA 0x{0:X} -> file offset 0x{1:X}", rva, fileOff);
                
                // Read the header
                int word = saved[fileOff] | (saved[fileOff+1] << 8);
                int format = word & 3;
                Console.WriteLine("Format: {0}", format);
                
                if (format == 3) {
                    int hdrSize = ((word >> 12) & 0xF) * 4;
                    int codeSize = saved[fileOff+4] | (saved[fileOff+5] << 8) | (saved[fileOff+6] << 16) | (saved[fileOff+7] << 24);
                    int sigToken = saved[fileOff+8] | (saved[fileOff+9] << 8) | (saved[fileOff+10] << 16) | (saved[fileOff+11] << 24);
                    Console.WriteLine("Header: {0} bytes, Code: {1} bytes", hdrSize, codeSize);
                    Console.WriteLine("SigToken: 0x{0:X8}", sigToken);
                    
                    Console.WriteLine("Full body bytes:");
                    int total = hdrSize + codeSize;
                    for (int j = 0; j < total; j += 16) {
                        string h = "";
                        for (int k = 0; k < 16 && j+k < total; k++)
                            h += saved[fileOff+j+k].ToString("X2") + " ";
                        Console.WriteLine("  +{0:X4}: {1}", j, h);
                    }
                    
                    Console.WriteLine("\nCode bytes (from offset +{0}):", hdrSize);
                    for (int j = 0; j < codeSize; j++)
                        Console.WriteLine("  +{0:X4}: 0x{1:X2}", hdrSize+j, saved[fileOff+hdrSize+j]);
                }
                break;
            }
        }
    }
}
