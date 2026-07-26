using System;
using System.Reflection;
using System.IO;

class FindApi {
    static void Main() {
        var asm = Assembly.LoadFrom(@"C:\deobfuscate\dnlib.dll");
        foreach (var t in asm.GetExportedTypes()) {
            if (t.Name.Contains("MethodBodyReader") || t.Name.Contains("CilBody") || t.Name.Contains("DataReader")) {
                Console.WriteLine("=== {0} ===", t.FullName);
                foreach (var m in t.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly)) {
                    var parms = m.GetParameters();
                    Console.WriteLine("  {0} {1}({2})", m.ReturnType.Name, m.Name,
                        string.Join(", ", Array.ConvertAll(parms, p => p.ParameterType.Name + " " + p.Name)));
                }
                foreach (var c in t.GetConstructors()) {
                    var parms = c.GetParameters();
                    Console.WriteLine("  ctor({0})", 
                        string.Join(", ", Array.ConvertAll(parms, p => p.ParameterType.Name + " " + p.Name)));
                }
                Console.WriteLine();
            }
        }
    }
}
