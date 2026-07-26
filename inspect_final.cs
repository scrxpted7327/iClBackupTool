using System;
using dnlib.DotNet;

class InspectFinal {
    static void Main() {
        var mod = ModuleDefMD.Load(@"C:\deobfuscate\SpiderBackup_final.exe");
        
        var ep = mod.EntryPoint;
        Console.WriteLine("EP: {0}.{1} (Token: 0x{2:X8})", ep.DeclaringType.Name, ep.Name, (int)ep.MDToken.Raw);
        Console.WriteLine("  RVA: 0x{0:X8}", (uint)ep.RVA);
        if (ep.Body != null) {
            Console.WriteLine("  Instructions: {0}", ep.Body.Instructions.Count);
            foreach (var instr in ep.Body.Instructions) {
                Console.WriteLine("    {0} {1}", instr.OpCode, instr.Operand);
            }
        }
        
        int multiInstr = 0, singleRet = 0, noBody = 0;
        foreach (var t in mod.GetTypes()) {
            foreach (var m in t.Methods) {
                if (m.Body == null) {
                    noBody++;
                } else if (m.Body.Instructions.Count == 1 && m.Body.Instructions[0].OpCode == dnlib.DotNet.Emit.OpCodes.Ret) {
                    singleRet++;
                } else {
                    multiInstr++;
                }
            }
        }
        Console.WriteLine("\nStats:");
        Console.WriteLine("  Multi-instruction bodies: {0}", multiInstr);
        Console.WriteLine("  Single 'ret' stubs: {0}", singleRet);
        Console.WriteLine("  Null bodies (abstract/runtime/RVA=0): {0}", noBody);
    }
}
