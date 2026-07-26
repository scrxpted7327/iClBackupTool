using System;
using dnlib.DotNet;

class Vrfy {
    static void Main() {
        var mod = ModuleDefMD.Load(@"C:\deobfuscate\SpiderBackup_resolved.exe");
        Console.WriteLine("Loaded: {0}", mod.Name);
        int withBody = 0, noBody = 0, multiInstr = 0, hasNull = 0;
        foreach (var t in mod.GetTypes())
            foreach (var m in t.Methods) {
                if (m.Body != null) {
                    withBody++;
                    if (m.Body.HasInstructions && m.Body.Instructions.Count > 1)
                        multiInstr++;
                } else noBody++;
            }
        Console.WriteLine("With body: {0}, No body: {1}, Multi-instr: {2}", withBody, noBody, multiInstr);
        
        // Show sample of resolved methods
        int shown = 0;
        foreach (var t in mod.GetTypes()) {
            foreach (var m in t.Methods) {
                if (m.Body == null || !m.Body.HasInstructions) continue;
                if (m.Body.Instructions.Count <= 1) continue;
                shown++;
                if (shown > 3) break;
                Console.WriteLine("\n{0}.{1} ({2} instrs):", t.Name, m.Name, m.Body.Instructions.Count);
                foreach (var instr in m.Body.Instructions) {
                    string opStr = instr.Operand == null ? "" : instr.Operand.ToString();
                    if (opStr.Length > 80) opStr = opStr.Substring(0, 80);
                    Console.WriteLine("  {0} {1}", instr.OpCode.Name, opStr);
                }
            }
            if (shown > 3) break;
        }
    }
}
