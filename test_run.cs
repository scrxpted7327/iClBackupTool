using System;
using System.Reflection;

class TestRun {
    static void Main() {
        try {
            var asm = Assembly.LoadFrom(@"C:\deobfuscate\SpiderBackup_final.exe");
            Console.WriteLine("Loaded: {0}", asm.FullName);
            int typeCount = 0;
            int methodCount = 0;
            foreach (var t in asm.GetTypes()) {
                typeCount++;
                foreach (var m in t.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly)) {
                    methodCount++;
                }
            }
            Console.WriteLine("Types: {0}, Methods: {1}", typeCount, methodCount);
            
            // Try to get the entry point and check module constructor
            var module = asm.ManifestModule;
            Console.WriteLine("Module: {0}", module.Name);
            Console.WriteLine("Module type: {0}", module.GetType().FullName);
        } catch (Exception ex) {
            Console.WriteLine("Error: {0}", ex.Message);
            Exception inner = ex.InnerException;
            while (inner != null) {
                Console.WriteLine("  Inner: {0}", inner.Message);
                inner = inner.InnerException;
            }
        }
    }
}
