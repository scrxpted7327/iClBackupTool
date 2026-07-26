using System;
using dnlib.DotNet;

class VerifyDec2 {
    static void Main() {
        var mod = ModuleDefMD.Load(@"C:\deobfuscate\SpiderBackup_final.exe");
        
        int totalBody = 0, singleRet = 0, multiInstr = 0;
        foreach (var t in mod.GetTypes()) {
            foreach (var m in t.Methods) {
                if (m.Body == null) continue;
                totalBody++;
                if (m.Body.HasInstructions) {
                    if (m.Body.Instructions.Count <= 1 || m.Body.Instructions[0].OpCode == dnlib.DotNet.Emit.OpCodes.Ret)
                        singleRet++;
                    else
                        multiInstr++;
                }
            }
        }
        Console.WriteLine("Total with body: {0}, single/ret: {1}, multi-instr: {2}", totalBody, singleRet, multiInstr);
        
        if (multiInstr > 0) {
            Console.WriteLine("\nSample multi-instr methods:");
            int shown = 0;
            foreach (var t in mod.GetTypes()) {
                foreach (var m in t.Methods) {
                    if (m.Body == null || !m.Body.HasInstructions) continue;
                    if (m.Body.Instructions.Count <= 1 || m.Body.Instructions[0].OpCode == dnlib.DotNet.Emit.OpCodes.Ret) continue;
                    shown++;
                    if (shown > 3) break;
                    Console.WriteLine("  {0}.{1}: {2} instructions", t.Name, m.Name, m.Body.Instructions.Count);
                    for (int i = 0; i < Math.Min(5, m.Body.Instructions.Count); i++)
                        Console.WriteLine("    {0}: {1}", m.Body.Instructions[i].Offset, m.Body.Instructions[i].OpCode.Name);
                }
                if (shown > 3) break;
            }
        } else {
            Console.WriteLine("\nChecking last method that had body:");
            foreach (var t in mod.GetTypes()) {
                foreach (var m in t.Methods) {
                    if (m.Body != null && m.Body.HasInstructions) {
                        Console.WriteLine("  First with body: {0}.{1} count={2} first_op={3}", 
                            t.Name, m.Name, m.Body.Instructions.Count, 
                            m.Body.Instructions.Count > 0 ? m.Body.Instructions[0].OpCode.Name : "none");
                        return;
                    }
                }
            }
        }
    }
}
