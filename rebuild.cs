using System;
using System.IO;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.IO;

class Rebuild {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        string outPath = @"C:\deobfuscate\SpiderBackup_deobfuscated.exe";
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        
        Console.WriteLine("Loading module...");
        var mod = ModuleDefMD.Load(path);
        
        int replaced = 0;
        int skipped = 0;
        int errors = 0;
        int stubbed = 0;
        
        foreach (var type in mod.GetTypes()) {
            foreach (var method in type.Methods) {
                if (method.RVA == 0) continue;
                
                int token = (int)method.MDToken.Raw;
                string xorFile = dumpDir + token.ToString("X8") + ".dec_xor";
                
                // Skip .text methods - they were never encrypted
                if ((uint)method.RVA < 0x19E000) {
                    skipped++;
                    continue;
                }
                
                if (!File.Exists(xorFile)) {
                    skipped++;
                    continue;
                }
                
                byte[] bodyBytes = File.ReadAllBytes(xorFile);
                try {
                    var dataReader = ByteArrayDataReaderFactory.CreateReader(bodyBytes);
                    var reader = new MethodBodyReader(mod, dataReader, method);
                    if (reader.Read()) {
                        var body = reader.CreateCilBody();
                        body.KeepOldMaxStack = true;
                        
                        // Check for null operands that would crash the writer
                        bool hasNullOperands = false;
                        foreach (var instr in body.Instructions) {
                            if (instr.Operand == null && instr.OpCode.OperandType != dnlib.DotNet.Emit.OperandType.InlineNone) {
                                hasNullOperands = true;
                                break;
                            }
                        }
                        
                        if (hasNullOperands) {
                            Console.WriteLine("  STUBBED 0x{0:X8}: {1}.{2} (null operands)",
                                token, method.DeclaringType.Name, method.Name);
                            body.Instructions.Clear();
                            body.Instructions.Add(Instruction.Create(OpCodes.Ret));
                            stubbed++;
                        }
                        
                        method.Body = body;
                        replaced++;
                        if (replaced <= 3) {
                            Console.WriteLine("  Replaced 0x{0:X8}: {1}.{2} ({3} bytes raw -> {4} instrs)",
                                token, method.DeclaringType.Name, method.Name,
                                bodyBytes.Length, body.Instructions.Count);
                        }
                    } else {
                        Console.WriteLine("  STUBBED 0x{0:X8}: {1}.{2} (failed to parse body)",
                            token, method.DeclaringType.Name, method.Name);
                        var stub = new CilBody();
                        stub.Instructions.Add(Instruction.Create(OpCodes.Ret));
                        stub.KeepOldMaxStack = true;
                        method.Body = stub;
                        errors++;
                    }
                } catch (Exception ex) {
                    Console.WriteLine("  STUBBED 0x{0:X8}: {1}.{2} - {3}", token, 
                        method.DeclaringType.Name, method.Name, ex.Message);
                    var stub = new CilBody();
                    stub.Instructions.Add(Instruction.Create(OpCodes.Ret));
                    stub.KeepOldMaxStack = true;
                    method.Body = stub;
                    errors++;
                }
            }
        }
        
        Console.WriteLine("\nReplaced: {0}, Stubbed: {1}, Skipped: {2}", replaced, stubbed, skipped);
        Console.WriteLine("Saving to {0}...", outPath);
        mod.Write(outPath);
        Console.WriteLine("Done!");
    }
}
