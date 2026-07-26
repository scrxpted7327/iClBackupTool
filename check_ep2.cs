using System;
using System.IO;
using dnlib.DotNet;
using dnlib.PE;

class CheckEp2 {
    static void Main() {
        var mod = ModuleDefMD.Load(@"C:\deobfuscate\SpiderBackup.exe");
        var ep = mod.EntryPoint;
        Console.WriteLine("EP: {0}.{1}", ep.DeclaringType.Name, ep.Name);
        Console.WriteLine("  Token: 0x{0:X8}", (int)ep.MDToken.Raw);
        Console.WriteLine("  RVA: 0x{0:X8}", (uint)ep.RVA);
        
        // Read body bytes from PE at EP's RVA
        var peImage = mod.Metadata.PEImage;
        uint epFileOff = (uint)peImage.ToFileOffset((RVA)(uint)ep.RVA);
        byte[] pe = File.ReadAllBytes(@"C:\deobfuscate\SpiderBackup.exe");
        
        Console.WriteLine("  File offset: 0x{0:X8}", epFileOff);
        Console.WriteLine("  First 64 bytes:");
        for (int i = 0; i < 64 && epFileOff + i < pe.Length; i++)
            Console.Write("{0:X2} ", pe[epFileOff + i]);
        Console.WriteLine();
        
        // Check EP body instructions
        if (ep.Body != null) {
            Console.WriteLine("  Body.Instr count: {0}", ep.Body.Instructions.Count);
            if (ep.Body.Instructions.Count > 0)
                Console.WriteLine("  Body[0]: {0}", ep.Body.Instructions[0].OpCode.Name);
            

        }
        
        // Find EP's .dec file
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        string decFile = dumpDir + ep.DeclaringType.MDToken.Raw.ToString("X8") + "_" + ep.MDToken.Raw.ToString("X8") + ".dec";
        string decXorFile = dumpDir + ep.MDToken.Raw.ToString("X8") + ".dec_xor";
        Console.WriteLine("  .dec exists: {0}", File.Exists(decFile));
        Console.WriteLine("  .dec_xor exists: {0}", File.Exists(decXorFile));
        if (File.Exists(decXorFile)) {
            byte[] xorBody = File.ReadAllBytes(decXorFile);
            Console.WriteLine("  .dec_xor first 32 bytes:");
            for (int i = 0; i < Math.Min(32, xorBody.Length); i++)
                Console.Write("{0:X2} ", xorBody[i]);
            Console.WriteLine();
            Console.WriteLine("  .dec_xor size: {0}", xorBody.Length);
        }
    }
}
