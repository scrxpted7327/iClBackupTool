using System;
using dnlib.DotNet;

class ValidCheck2 {
    static void Main() {
        try {
            var mod = ModuleDefMD.Load(@"C:\deobfuscate\SpiderBackup_final.exe");
            Console.WriteLine("Loaded OK: {0}", mod.Name);
            int withBody = 0, noBody = 0;
            foreach (var t in mod.GetTypes())
                foreach (var m in t.Methods) {
                    if (m.Body != null) withBody++;
                    else noBody++;
                }
            Console.WriteLine("With body: {0}, No body: {1}", withBody, noBody);
            
            var ep = mod.EntryPoint;
            if (ep != null) {
                Console.WriteLine("EntryPoint: {0}.{1} RVA=0x{2:X8} Body={3}", 
                    ep.DeclaringType.Name, ep.Name, (uint)ep.RVA, 
                    ep.Body != null ? "present" : "null");
            }
        } catch (Exception ex) {
            Console.WriteLine("Error: {0}", ex.Message);
        }
    }
}
