using System;
using System.IO;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.IO;

class CheckRef {
    static void Main() {
        var mod = ModuleDefMD.Load(@"C:\deobfuscate\SpiderBackup.exe");
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        int refToken = 0x06000497;
        
        byte[] bodyBytes = File.ReadAllBytes(dumpDir + refToken.ToString("X8") + ".dec_xor");
        Console.WriteLine("dec_xor size: {0}", bodyBytes.Length);
        Console.WriteLine("First 16 bytes:");
        for (int i = 0; i < 16; i++) Console.Write("{0:X2} ", bodyBytes[i]);
        Console.WriteLine();
        
        // Find the method
        MethodDef refMethod = null;
        foreach (var t in mod.GetTypes())
            foreach (var m in t.Methods)
                if ((int)m.MDToken.Raw == refToken) refMethod = m;
        
        if (refMethod != null) {
            Console.WriteLine("\nRef method: {0}.{1}", refMethod.DeclaringType.Name, refMethod.Name);
            Console.WriteLine("RVA: 0x{0:X8}", (uint)refMethod.RVA);
            
            // Try to parse
            var dataReader = ByteArrayDataReaderFactory.CreateReader(bodyBytes);
            var reader = new MethodBodyReader(mod, dataReader, refMethod);
            if (reader.Read()) {
                var body = reader.CreateCilBody();
                Console.WriteLine("Parsed: {0} instructions", body.Instructions.Count);
                for (int i = 0; i < Math.Min(10, body.Instructions.Count); i++) {
                    var instr = body.Instructions[i];
                    Console.WriteLine("  {0:X4}: {1} {2}", instr.Offset, instr.OpCode.Name, 
                        instr.Operand != null ? instr.Operand.ToString() : "(null)");
                }
            } else {
                Console.WriteLine("FAILED to parse");
            }
        }
    }
}
