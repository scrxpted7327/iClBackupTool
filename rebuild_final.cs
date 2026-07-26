using System;
using System.IO;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.DotNet.Writer;
using dnlib.IO;

class RebuildFinal {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        string finalPath = @"C:\deobfuscate\SpiderBackup_final.exe";
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        
        Console.WriteLine("Loading module...");
        var mod = ModuleDefMD.Load(path);
        
        int replaced = 0;
        int stubbedNullOp = 0;
        int skipped = 0;
        int errors = 0;
        int rvaZeroStubbed = 0;
        
        // First pass: stub all methods with RVA==0
        foreach (var type in mod.GetTypes())
            foreach (var method in type.Methods)
                if (method.RVA == 0 && !method.IsAbstract && !method.IsRuntime) {
                    var stub = new CilBody();
                    stub.Instructions.Add(Instruction.Create(OpCodes.Ret));
                    stub.KeepOldMaxStack = true;
                    method.Body = stub;
                    rvaZeroStubbed++;
                }
        
        // Second pass: replace .zN| method bodies from .dec_xor files
        foreach (var type in mod.GetTypes()) {
            foreach (var method in type.Methods) {
                if (method.RVA == 0) continue;
                
                int token = (int)method.MDToken.Raw;
                string xorFile = dumpDir + token.ToString("X8") + ".dec_xor";
                
                // Skip .text methods - they were never anti-tampered
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
                        
                        bool hasNullOperands = false;
                        foreach (var instr in body.Instructions) {
                            if (instr.Operand == null && instr.OpCode.OperandType != OperandType.InlineNone) {
                                hasNullOperands = true;
                                break;
                            }
                        }
                        
                        if (hasNullOperands) {
                            body.Instructions.Clear();
                            body.Instructions.Add(Instruction.Create(OpCodes.Ret));
                            stubbedNullOp++;
                        }
                        
                        method.Body = body;
                        replaced++;
                    } else {
                        var stub = new CilBody();
                        stub.Instructions.Add(Instruction.Create(OpCodes.Ret));
                        stub.KeepOldMaxStack = true;
                        method.Body = stub;
                        errors++;
                    }
                } catch {
                    var stub = new CilBody();
                    stub.Instructions.Add(Instruction.Create(OpCodes.Ret));
                    stub.KeepOldMaxStack = true;
                    method.Body = stub;
                    errors++;
                }
            }
        }
        
        Console.WriteLine("Replaced: {0}, Stubbed (null operands): {1}, Skipped: {2}, Errors: {3}, RVA=0 stubbed: {4}", 
            replaced, stubbedNullOp, skipped, errors, rvaZeroStubbed);
        
        // Stub anti-tamper cctors
        Console.WriteLine("Stubbing anti-tamper cctors...");
        int stubbedCctor = 0;
        foreach (var t in mod.GetTypes()) {
            foreach (var m in t.Methods) {
                if ((uint)m.RVA == 0) continue;
                if (m.Name == ".cctor" && (uint)m.RVA >= 0x19E000) {
                    var stub = new CilBody();
                    stub.Instructions.Add(Instruction.Create(OpCodes.Ret));
                    stub.KeepOldMaxStack = true;
                    m.Body = stub;
                    stubbedCctor++;
                }
            }
        }
        Console.WriteLine("Stubbed {0} cctors", stubbedCctor);
        
        Console.WriteLine("Saving...");
        var opts = new ModuleWriterOptions(mod);
        opts.MetadataOptions.Flags = MetadataFlags.PreserveAll;
        mod.Write(finalPath, opts);
        Console.WriteLine("Saved to {0}", finalPath);
    }
}
