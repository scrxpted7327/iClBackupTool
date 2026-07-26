using System;
using System.Linq;
using dnlib.DotNet;

class DebugRva {
    static void Main() {
        var mod = ModuleDefMD.Load(@"C:\deobfuscate\SpiderBackup_final.exe");
        
        // Check methods with body == null or RVA == 0
        int noRva = 0;
        int noRvaNonAbstract = 0;
        int noBody = 0;
        foreach (var t in mod.GetTypes()) {
            foreach (var m in t.Methods) {
                if (m.RVA == 0 || m.Body == null) {
                    noRva++;
                    if (!m.IsAbstract && !m.IsRuntime && !m.IsNative) {
                        noRvaNonAbstract++;
                    }
                }
                if (m.Body == null) noBody++;
            }
        }
        Console.WriteLine("Methods: RVA=0 or null body: {0}, non-abstract: {1}, null body: {2}", noRva, noRvaNonAbstract, noBody);
        
        // Check specific failing method
        Console.WriteLine("\nChecking 494717EF.351529E9:");
        foreach (var t in mod.GetTypes()) {
            if (t.Name.Contains("494717EF")) {
                foreach (var m in t.Methods) {
                    if (m.Name == "351529E9") {
                        Console.WriteLine("  RVA=0x{0:X8}, Body={1}, IsAbstract={2}, IsRuntime={3}", 
                            (uint)m.RVA, m.Body != null ? "present" : "null", m.IsAbstract, m.IsRuntime);
                        if (m.Body != null)
                            Console.WriteLine("  Instructions: {0}", m.Body.Instructions.Count);
                    }
                }
            }
        }
    }
}
