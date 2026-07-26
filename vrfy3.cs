using System;
using dnlib.DotNet;

class Vrfy3 {
    static void Main() {
        // Compare original and resolved
        var mod1 = ModuleDefMD.Load(@"C:\deobfuscate\SpiderBackup.exe");
        var mod2 = ModuleDefMD.Load(@"C:\deobfuscate\SpiderBackup_resolved.exe");
        
        int origBody=0, origNoBody=0, resolvedBody=0, resolvedNoBody=0;
        foreach (var t in mod1.GetTypes())
            foreach (var m in t.Methods)
                if (m.Body != null) origBody++; else origNoBody++;
        foreach (var t in mod2.GetTypes())
            foreach (var m in t.Methods)
                if (m.Body != null) resolvedBody++; else resolvedNoBody++;
        
        Console.WriteLine("Original: {0} bodies, {1} null", origBody, origNoBody);
        Console.WriteLine("Resolved: {0} bodies, {1} null", resolvedBody, resolvedNoBody);
        
        // Check entry point in both
        var ep1 = mod1.EntryPoint;
        var ep2 = mod2.EntryPoint;
        if (ep1 != null) Console.WriteLine("\nOrig EP: {0}.{1} RVA=0x{2:X8} Body={3}", 
            ep1.DeclaringType.Name, ep1.Name, (uint)ep1.RVA, ep1.Body != null ? "Y" : "N");
        if (ep2 != null) Console.WriteLine("Res EP: {0}.{1} RVA=0x{2:X8} Body={3}", 
            ep2.DeclaringType.Name, ep2.Name, (uint)ep2.RVA, ep2.Body != null ? "Y" : "N");
        
        // Check body count for methods in .zN| section
        int znzOrig=0, znzRes=0;
        foreach (var t in mod1.GetTypes())
            foreach (var m in t.Methods)
                if ((uint)m.RVA >= 0x19E000 && m.Body != null) znzOrig++;
        foreach (var t in mod2.GetTypes())
            foreach (var m in t.Methods)
                if ((uint)m.RVA >= 0x19E000 && m.Body != null) znzRes++;
        Console.WriteLine("\n.zN| with body: orig={0}, resolved={1}", znzOrig, znzRes);
    }
}
