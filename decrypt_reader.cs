using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class DecryptReader {
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
    static void Main(string[] args) {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        byte[] peBytes = File.ReadAllBytes(path);
        
        Console.WriteLine("Loading assembly from bytes...");
        Assembly asm = Assembly.Load(peBytes);
        Console.WriteLine("Assembly: " + asm.FullName);
        
        Console.WriteLine("Triggering cctor...");
        try {
            RuntimeHelpers.RunModuleConstructor(asm.ManifestModule.ModuleHandle);
            Console.WriteLine("cctor succeeded!");
        } catch (Exception ex) {
            Exception e = ex;
            int depth = 0;
            while (e != null && depth < 10) {
                Console.WriteLine("[{0}] {1}: {2}", depth, e.GetType().Name, e.Message);
                depth++;
                e = e.InnerException;
            }
        }
        
        Type[] types;
        try {
            types = asm.GetTypes();
        } catch (ReflectionTypeLoadException rtle) {
            types = rtle.Types;
            Console.WriteLine("\nPartial type load: {0} types, {1} load errors", 
                types.Length, rtle.LoaderExceptions.Length);
            for (int i = 0; i < Math.Min(rtle.LoaderExceptions.Length, 5); i++)
                Console.WriteLine("  Error: {0}", rtle.LoaderExceptions[i].Message);
        }
        
        int totalMethods = 0;
        int dumped = 0;
        int failed = 0;
        
        foreach (var type in types) {
            if (type == null) continue;
            foreach (var method in type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)) {
                totalMethods++;
                try {
                    MethodBody mb = method.GetMethodBody();
                    if (mb != null) {
                        byte[] il = mb.GetILAsByteArray();
                        if (il != null && il.Length > 0) {
                            string path2 = string.Format(@"C:\deobfuscate\methods_dump\{0:X8}_{1:X8}_{2:X8}.il", 
                                type.MetadataToken, method.MetadataToken, totalMethods);
                            File.WriteAllBytes(path2, il);
                            dumped++;
                            if (totalMethods <= 3) {
                                Console.WriteLine("  [{0}] {1}.{2}: {3} bytes", totalMethods, type.Name, method.Name, il.Length);
                                if (il.Length <= 32) {
                                    for (int i = 0; i < il.Length; i++)
                                        Console.Write("{0:X2} ", il[i]);
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                } catch (Exception ex2) {
                    failed++;
                    if (totalMethods <= 5)
                        Console.WriteLine("  [{0}] {1}.{2}: FAILED - {3}", totalMethods, type.Name, method.Name, ex2.Message);
                }
            }
        }
        
        Console.WriteLine("\nTotal: {0} methods, {1} dumped, {2} failed", totalMethods, dumped, failed);
    }
}
