using System;
using dnlib.DotNet;

class ValidCheck {
    static void Main() {
        try {
            var mod = ModuleDefMD.Load(@"C:\deobfuscate\SpiderBackup_final.exe");
            Console.WriteLine("Loaded OK: {0}", mod.Name);
            
            int types = 0, methods = 0, withBody = 0, noBody = 0;
            foreach (var t in mod.GetTypes()) { types++;
                foreach (var m in t.Methods) { methods++;
                    if (m.Body != null) withBody++;
                    else noBody++;
                }
            }
            Console.WriteLine("Types: {0}, Methods: {1}, With body: {2}, No body: {3}", 
                types, methods, withBody, noBody);
            
            // Check if entry point exists
            var ep = mod.EntryPoint;
            if (ep != null)
                Console.WriteLine("EntryPoint: {0}.{1} (RVA=0x{2:X8})", 
                    ep.DeclaringType.Name, ep.Name, (uint)ep.RVA);
            else
                Console.WriteLine("No entry point");
        } catch (Exception ex) {
            Console.WriteLine("Error: {0}", ex.Message);
        }
    }
}
