using System;
using System.IO;
using dnlib.DotNet;
using dnlib.PE;

class VerifyKey {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        
        byte[] pe = File.ReadAllBytes(path);
        var mod = ModuleDefMD.Load(path);
        IPEImage peImage = mod.Metadata.PEImage;
        
        int refToken = 0x06000497;
        byte[] refDec = File.ReadAllBytes(dumpDir + refToken.ToString("X8") + ".dec_xor");
        
        uint refFileOff = 0;
        foreach (var t in mod.GetTypes())
            foreach (var m in t.Methods)
                if ((int)m.MDToken.Raw == refToken)
                    refFileOff = (uint)peImage.ToFileOffset((RVA)(uint)m.RVA);
        
        // Extract ACTUAL key: key[i] = pe[refFileOff + i] ^ refDec[i]
        byte[] actualKey = new byte[Math.Min(refDec.Length, 6092)]; // 6092 from earlier
        int keyLen = Math.Min(refDec.Length, (int)(pe.Length - refFileOff));
        for (int i = 0; i < keyLen; i++)
            actualKey[i] = (byte)(pe[refFileOff + i] ^ refDec[i]);
        
        Console.WriteLine("Actual key length: {0}", keyLen);
        Console.WriteLine("First 16 key bytes:");
        for (int i = 0; i < 16; i++) Console.Write("{0:X2} ", actualKey[i]);
        Console.WriteLine();
        
        // Test on reference method: dec[i] = pe[refOff + i] ^ key[i % keyLen]
        byte[] testRef = new byte[refDec.Length];
        for (int i = 0; i < refDec.Length; i++)
            testRef[i] = (byte)(pe[refFileOff + i] ^ actualKey[i % keyLen]);
        
        bool match = true;
        for (int i = 0; i < refDec.Length; i++)
            if (testRef[i] != refDec[i]) { match = false; Console.WriteLine("Mismatch at {0}: got 0x{1:X2} expected 0x{2:X2}", i, testRef[i], refDec[i]); break; }
        Console.WriteLine("Reference method match: {0}", match);
        
        // Test on another method
        int testToken = 0x0600043A;
        byte[] testDec = File.ReadAllBytes(dumpDir + testToken.ToString("X8") + ".dec_xor");
        uint testFileOff = 0;
        foreach (var t in mod.GetTypes())
            foreach (var m in t.Methods)
                if ((int)m.MDToken.Raw == testToken)
                    testFileOff = (uint)peImage.ToFileOffset((RVA)(uint)m.RVA);
        
        byte[] testResult = new byte[testDec.Length];
        for (int i = 0; i < testDec.Length; i++)
            testResult[i] = (byte)(pe[testFileOff + i] ^ actualKey[i % keyLen]);
        
        match = true;
        for (int i = 0; i < testDec.Length; i++)
            if (testResult[i] != testDec[i]) { match = false; Console.WriteLine("Mismatch at {0}: got 0x{1:X2} expected 0x{2:X2}", i, testResult[i], testDec[i]); break; }
        Console.WriteLine("Test method 0x{0:X8} match: {1}", testToken, match);
        
        // Now try WITH the offset formula (rebuild3.cs approach)
        byte[] testResult2 = new byte[testDec.Length];
        for (int i = 0; i < testDec.Length; i++) {
            int keyOff2 = (int)(testFileOff - refFileOff);
            int keyIdx = (keyOff2 + i) % actualKey.Length;
            if (keyIdx < 0) keyIdx += actualKey.Length;
            testResult2[i] = (byte)(pe[testFileOff + i] ^ actualKey[keyIdx]);
        }
        match = true;
        for (int i = 0; i < testDec.Length; i++)
            if (testResult2[i] != testDec[i]) { match = false; break; }
        Console.WriteLine("Test method with OFFSET formula match: {0}", match);
    }
}
