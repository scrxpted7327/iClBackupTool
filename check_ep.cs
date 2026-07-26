using System;
using dnlib.DotNet;

class CheckEp {
    static void Main() {
        var mod = ModuleDefMD.Load(@"C:\deobfuscate\SpiderBackup_final.exe");
        var ep = mod.EntryPoint;
        if (ep != null) {
            Console.WriteLine("EntryPoint: {0}.{1}", ep.DeclaringType.Name, ep.Name);
            Console.WriteLine("  RVA=0x{0:X8}", (uint)ep.RVA);
            Console.WriteLine("  IsAbstract={0}", ep.IsAbstract);
            Console.WriteLine("  IsRuntime={0}", ep.IsRuntime);
            Console.WriteLine("  IsInternalCall={0}", ep.IsInternalCall);
            Console.WriteLine("  IsPinvokeImpl={0}", ep.IsPinvokeImpl);
            Console.WriteLine("  IsStatic={0}", ep.IsStatic);
            Console.WriteLine("  Body={0}", ep.Body != null ? "present" : "null");
            Console.WriteLine("  MDToken=0x{0:X8}", ep.MDToken.Raw);
        }
    }
}
