using System;
using System.Linq;
using dnlib.DotNet;

class Verify {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup_final3.exe";
        var mod = ModuleDefMD.Load(path);
        Console.WriteLine("Loaded: {0}", mod.Name);
        Console.WriteLine("Types: {0}", mod.GetTypes().Count());
        
        int methods = 0;
        int bodies = 0;
        foreach (var t in mod.GetTypes())
            foreach (var m in t.Methods) {
                methods++;
                if (m.Body != null) bodies++;
            }
        Console.WriteLine("Methods: {0}, With bodies: {1}", methods, bodies);
        
        // Try to decompile one of the replaced methods
        foreach (var t in mod.GetTypes())
            foreach (var m in t.Methods) {
                if (m.Body != null && m.Body.HasInstructions && m.Body.Instructions.Count > 1) {
                    Console.WriteLine("\nFirst method with body: {0}.{1}", t.Name, m.Name);
                    for (int i = 0; i < Math.Min(5, m.Body.Instructions.Count); i++)
                        Console.WriteLine("  {0}", m.Body.Instructions[i]);
                    break;
                }
            }
    }
}
