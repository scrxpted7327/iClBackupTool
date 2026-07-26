using System;
using System.Reflection;
using System.IO;

class FindMeta {
    static void Main() {
        var asm = Assembly.LoadFrom(@"C:\deobfuscate\dnlib.dll");
        foreach (var t in asm.GetExportedTypes()) {
            if (t.Name.Contains("MetadataOption") || t.Name.Contains("MetadataFlag") || t.Name.Contains("Metadata")) {
                Console.WriteLine("=== {0} ===", t.FullName);
                bool hasFlags = false;
                foreach (var f in t.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)) {
                    if ((f.Attributes & FieldAttributes.Literal) != 0) {
                        Console.WriteLine("  {0} = {1}", f.Name, f.GetRawConstantValue());
                        hasFlags = true;
                    }
                }
                if (!hasFlags) {
                    foreach (var m in t.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly)) {
                        var parms = m.GetParameters();
                        Console.WriteLine("  {0} {1}({2})", m.ReturnType.Name, m.Name,
                            string.Join(", ", Array.ConvertAll(parms, p => p.ParameterType.Name + " " + p.Name)));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
