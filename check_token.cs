using System;
using System.IO;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.IO;

class CheckToken {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        
        var mod = ModuleDefMD.Load(path);
        
        int token = 0x06000077;
        MethodDef target = null;
        foreach (var t in mod.GetTypes())
            foreach (var m in t.Methods)
                if ((int)m.MDToken.Raw == token) target = m;
                
        Console.WriteLine("Target: {0}.{1}", target.DeclaringType.Name, target.Name);
        
        string xorFile = dumpDir + token.ToString("X8") + ".dec_xor";
        Console.WriteLine("xfile exists: {0}", File.Exists(xorFile));
        if (File.Exists(xorFile)) {
            byte[] bytes = File.ReadAllBytes(xorFile);
            Console.WriteLine("File size: {0}", bytes.Length);
            for (int i = 0; i < bytes.Length; i++)
                Console.Write("{0:X2} ", bytes[i]);
            Console.WriteLine();
            
            var dr = ByteArrayDataReaderFactory.CreateReader(bytes);
            var reader = new MethodBodyReader(mod, dr, target);
            if (reader.Read()) {
                var body = reader.CreateCilBody();
                Console.WriteLine("Parsed CilBody OK! Instr count: {0}", body.Instructions.Count);
                foreach (var instr in body.Instructions) {
                    Console.WriteLine("  {0} {1} ({2})", 
                        instr.OpCode, 
                        instr.Operand, 
                        instr.Operand != null ? instr.Operand.GetType().Name : "NULL");
                }
            } else {
                Console.WriteLine("MethodBodyReader.Read() returned FALSE!");
            }
        }
    }
}
