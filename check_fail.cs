using System;
using System.IO;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.IO;

class CheckFail {
    static void Main() {
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        int[] tokens = {0x06000013, 0x06000018, 0x0600001C, 0x06000027, 0x06000029};
        
        foreach (int token in tokens) {
            string fn = dumpDir + token.ToString("X8") + ".dec_xor";
            if (!File.Exists(fn)) {
                Console.WriteLine("{0:X8}: NOT FOUND", token);
                continue;
            }
            byte[] data = File.ReadAllBytes(fn);
            int header = data[0];
            int flags = header & 3;
            Console.WriteLine("{0:X8}: {1} bytes, byte0=0x{2:X2}, flags={3}", 
                token, data.Length, header, flags);
            
            if (flags == 2) {
                int codeSize = header >> 2;
                Console.WriteLine("  Tiny, codeSize={0}", codeSize);
            } else if (flags == 3) {
                int fatFlags = data[0] | (data[1] << 8);
                int hdrSize = (fatFlags >> 12) & 0xF;
                int maxStack = data[2] | (data[3] << 8);
                int codeSize = data[4] | (data[5] << 8) | (data[6] << 16) | (data[7] << 24);
                int localSig = data[8] | (data[9] << 8) | (data[10] << 16) | (data[11] << 24);
                Console.WriteLine("  Fat, hdrSize={0}*4={1}, maxStack={2}, codeSize={3}, localSig=0x{4:X8}",
                    hdrSize, hdrSize * 4, maxStack, codeSize, localSig);
                int hdrBytes = hdrSize * 4;
                int totalBody = hdrBytes + codeSize;
                Console.WriteLine("  Header={0}, codeSize={1}, expected total={2}, file size={3}",
                    hdrBytes, codeSize, totalBody, data.Length);
                
                if (data.Length > hdrBytes + codeSize) {
                    Console.WriteLine("  Extra padding: {0} bytes", data.Length - hdrBytes - codeSize);
                }
            }
        }
    }
}
