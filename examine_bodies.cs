using System;
using System.IO;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.IO;

class ExamineBodies {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        
        var mod = ModuleDefMD.Load(path);
        int[] samples = {0x06000497, 0x06000496, 0x060005E7, 0x060006F4};
        
        foreach (int token in samples) {
            string xorFile = dumpDir + token.ToString("X8") + ".dec_xor";
            if (!File.Exists(xorFile)) continue;
            
            byte[] data = File.ReadAllBytes(xorFile);
            Console.WriteLine("=== 0x{0:X8}: {1} bytes ===", token, data.Length);
            
            // Print first 48 bytes as hex
            for (int i = 0; i < Math.Min(48, data.Length); i += 16) {
                string h = "";
                for (int j = 0; j < 16 && i+j < data.Length; j++)
                    h += data[i+j].ToString("X2") + " ";
                Console.WriteLine("  +{0:X4}: {1}", i, h);
            }
            
            // Try to parse and show instructions
            var dataReader = ByteArrayDataReaderFactory.CreateReader(data);
            var reader = new MethodBodyReader(mod, dataReader, mod.ResolveToken(token) as MethodDef);
            if (reader.Read()) {
                var body = reader.CreateCilBody();
                Console.WriteLine("  Instructions ({0}):", body.Instructions.Count);
                int count = 0;
                foreach (var instr in body.Instructions) {
                    if (count++ > 15) break;
                    string opStr = instr.Operand == null ? "null" : instr.Operand.ToString();
                    Console.WriteLine("    {0:X4}: {1} {2}", instr.Offset, instr.OpCode.Name, opStr);
                }
            } else {
                Console.WriteLine("  FAILED to parse");
            }
            Console.WriteLine();
        }
    }
}
