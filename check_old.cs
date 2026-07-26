using System;
using dnlib.DotNet;

class CheckOld {
    static void Main() {
        var mod = ModuleDefMD.Load(@"C:\deobfuscate\SpiderBackup_deobfuscated.exe");
        int withBody = 0, noBody = 0;
        foreach (var t in mod.GetTypes())
            foreach (var m in t.Methods) {
                if (m.Body != null) withBody++;
                else noBody++;
            }
        Console.WriteLine("Old output: With body: {0}, No body: {1}", withBody, noBody);
    }
}
