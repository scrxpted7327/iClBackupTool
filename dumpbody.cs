using System;
using System.IO;

class DumpBody {
    static void Main() {
        byte[] data = File.ReadAllBytes(@"C:\deobfuscate\Patched_SpiderBackup.exe");
        int off = 0x116D3C;
        Console.WriteLine("Patched body at 0x{0:X}:", off);
        for (int i = 0; i < 32; i += 16) {
            string h = "";
            for (int j = 0; j < 16 && i+j < 32; j++)
                h += data[off+i+j].ToString("X2") + " ";
            Console.WriteLine("  +{0:X4}: {1}", i, h);
        }
        int word = data[off] | (data[off+1] << 8);
        Console.WriteLine("First word: 0x{0:X4}", word);
        Console.WriteLine("Format: {0}", word & 3);
        Console.WriteLine("Size: {0} (header={1} bytes)", (word>>12)&0xF, ((word>>12)&0xF)*4);
        Console.WriteLine("MaxStack: {0}", data[off+2] | (data[off+3] << 8));
        int codeSize = data[off+4] | (data[off+5] << 8) | (data[off+6] << 16) | (data[off+7] << 24);
        Console.WriteLine("CodeSize: {0}", codeSize);
        Console.WriteLine("SigToken: 0x{0:X8}", data[off+8] | (data[off+9] << 8) | (data[off+10] << 16) | (data[off+11] << 24));
        Console.WriteLine("Code bytes:");
        for (int i = 0; i < codeSize; i++)
            Console.WriteLine("  +{0}: 0x{1:X2}", 12+i, data[off+12+i]);
    }
}
