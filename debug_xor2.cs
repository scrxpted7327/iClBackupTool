using System;
using System.IO;
using dnlib.DotNet;
using dnlib.PE;

class DebugXor {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        
        byte[] pe = File.ReadAllBytes(path);
        var mod = ModuleDefMD.Load(path);
        IPEImage peImage = mod.Metadata.PEImage;
        
        int refToken = 0x06000497;
        byte[] xorKey = File.ReadAllBytes(dumpDir + refToken.ToString("X8") + ".dec_xor");
        
        uint refRva = 0, refFileOff = 0;
        foreach (var t in mod.GetTypes())
            foreach (var m in t.Methods)
                if ((int)m.MDToken.Raw == refToken) {
                    refRva = (uint)m.RVA;
                    refFileOff = (uint)peImage.ToFileOffset((RVA)refRva);
                    break;
                }
        
        Console.WriteLine("Ref body from PE: {0} bytes at fileOff=0x{1:X8}", xorKey.Length, refFileOff);
        
        // Compare dec_xor with raw PE bytes
        Console.WriteLine("\nFirst 16 bytes of .dec_xor:");
        for (int i = 0; i < 16; i++) Console.Write("{0:X2} ", xorKey[i]);
        Console.WriteLine();
        
        Console.WriteLine("First 16 bytes of PE at ref offset:");
        for (int i = 0; i < 16; i++) Console.Write("{0:X2} ", pe[refFileOff + i]);
        Console.WriteLine();
        
        byte[] xored = new byte[Math.Min(32, xorKey.Length)];
        for (int i = 0; i < xored.Length; i++)
            xored[i] = (byte)(xorKey[i] ^ pe[refFileOff + i]);
        Console.WriteLine("XOR of above two:");
        for (int i = 0; i < xored.Length; i++) Console.Write("{0:X2} ", xored[i]);
        Console.WriteLine();
        
        // Check if xored looks like a valid tiny IL header
        // Tiny header: bits [1:0] = 10, bits [7:2] = codeSize
        Console.WriteLine("\nFirst byte XORed = 0x{0:X2}", xored[0]);
        Console.WriteLine("  Low 2 bits: {0} (should be 2 for tiny header)", xored[0] & 3);
        
        // Similarly check another method
        int testToken = 0x0600043A;
        byte[] testDec = File.ReadAllBytes(dumpDir + testToken.ToString("X8") + ".dec_xor");
        uint testFileOff = 0;
        foreach (var t in mod.GetTypes())
            foreach (var m in t.Methods)
                if ((int)m.MDToken.Raw == testToken) {
                    testFileOff = (uint)peImage.ToFileOffset((RVA)(uint)m.RVA);
                    break;
                }
        
        Console.WriteLine("\n\nTest method 0x{0:X8}: fileOff=0x{1:X8}, .dec_xor len={2}", 
            testToken, testFileOff, testDec.Length);
        
        byte[] decBody = new byte[testDec.Length];
        for (int i = 0; i < testDec.Length; i++) {
            int keyOff = (int)(testFileOff - refFileOff);
            int keyIdx = (keyOff + i) % xorKey.Length;
            if (keyIdx < 0) keyIdx += xorKey.Length;
            decBody[i] = (byte)(pe[testFileOff + i] ^ xorKey[keyIdx]);
        }
        
        Console.WriteLine("First 16 bytes of manually decrypted:");
        for (int i = 0; i < 16; i++) Console.Write("{0:X2} ", decBody[i]);
        Console.WriteLine();
        Console.WriteLine("First 16 bytes of .dec_xor:");
        for (int i = 0; i < 16; i++) Console.Write("{0:X2} ", testDec[i]);
        Console.WriteLine();
        
        bool match = true;
        for (int i = 0; i < testDec.Length; i++)
            if (decBody[i] != testDec[i]) { match = false; break; }
        Console.WriteLine("Match: {0}", match);
    }
}
