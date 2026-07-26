using System;
using dnlib.DotNet;

class Vrfy2 {
    static void Main() {
        var mod = ModuleDefMD.Load(@"C:\deobfuscate\SpiderBackup_resolved.exe");
        var ep = mod.EntryPoint;
        if (ep != null) {
            Console.WriteLine("EntryPoint: {0}.{1}", ep.DeclaringType.Name, ep.Name);
            Console.WriteLine("  RVA=0x{0:X8}", (uint)ep.RVA);
            Console.WriteLine("  Body={(0)}", ep.Body != null ? "present" : "null");
            if (ep.Body != null && ep.Body.HasInstructions) {
                Console.WriteLine("  Instructions: {0}", ep.Body.Instructions.Count);
                foreach (var instr in ep.Body.Instructions)
                    Console.WriteLine("    {0} {1}", instr.OpCode.Name, 
                        instr.Operand != null ? instr.Operand.ToString() : "");
            }
        }
        // Also check Settings.Main or similar
        foreach (var t in mod.GetTypes()) {
            foreach (var m in t.Methods) {
                if (m.Name == "Main" && m.IsStatic) {
                    Console.WriteLine("\nFound Main: {0}.{1}", t.Name, m.Name);
                    Console.WriteLine("  RVA=0x{0:X8}", (uint)m.RVA);
                    Console.WriteLine("  Body={0}", m.Body != null ? "present" : "null");
                    if (m.Body != null && m.Body.HasInstructions) {
                        foreach (var instr in m.Body.Instructions)
                            Console.WriteLine("    {0} {1}", instr.OpCode.Name, 
                                instr.Operand != null ? instr.Operand.ToString() : "");
                    }
                }
            }
        }
    }
}
