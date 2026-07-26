using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using dnlib.DotNet;

class PEDump {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        byte[] peBytes = File.ReadAllBytes(path);
        Console.WriteLine("=== Raw bytes at 0x400 ===");
        for (int i = 0; i < 64; i++) {
            Console.Write("{0:X2} ", peBytes[0x400 + i]);
            if ((i + 1) % 16 == 0) Console.WriteLine();
        }
        Console.WriteLine();

        var dnMod = ModuleDefMD.Load(peBytes);
        var methods = dnMod.GetTypes().SelectMany(t => t.Methods)
            .Where(m => (uint)m.RVA >= 0x19E000).OrderBy(m => (uint)m.RVA).ToList();
        if (methods.Count > 0) {
            uint firstRva = (uint)methods[0].RVA;
            uint firstOff = 0x400 + (firstRva - 0x19E000);
            Console.WriteLine("=== First .zN|: token=0x{0:X8} RVA=0x{1:X6} off=0x{2:X6} ===",
                methods[0].MDToken.Raw, firstRva, firstOff);
            for (int i = 0; i < 64; i++) {
                Console.Write("{0:X2} ", peBytes[firstOff + i]);
                if ((i + 1) % 16 == 0) Console.WriteLine();
            }
            Console.WriteLine();

            var asm = Assembly.Load(peBytes);
            try { RuntimeHelpers.RunModuleConstructor(asm.ManifestModule.ModuleHandle); } catch { }
            Type[] types;
            try { types = asm.GetTypes(); } catch (ReflectionTypeLoadException rtle) { types = rtle.Types; }
            foreach (var t in types) {
                if (t == null) continue;
                foreach (var m in t.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)) {
                    if (m.MetadataToken == (int)methods[0].MDToken.Raw) {
                        byte[] dec = null;
                        try { var mb = m.GetMethodBody(); if (mb != null) dec = mb.GetILAsByteArray(); } catch { }
                        if (dec != null && dec.Length > 0) {
                            Console.WriteLine("=== Decrypted body (first 64) ===");
                            for (int i = 0; i < Math.Min(64, dec.Length); i++) {
                                Console.Write("{0:X2} ", dec[i]);
                                if ((i + 1) % 16 == 0) Console.WriteLine();
                            }
                            Console.WriteLine("\n=== Derived key ===");
                            for (int i = 0; i < Math.Min(64, dec.Length); i++) {
                                Console.Write("{0:X2} ", (byte)(peBytes[firstOff + i] ^ dec[i]));
                                if ((i + 1) % 16 == 0) Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine("Key byte 0: 0x{0:X2}", (byte)(peBytes[firstOff] ^ dec[0]));
                        }
                        break;
                    }
                }
            }
        }

        // Also show first .text methods by token
        var textMethods = dnMod.GetTypes().SelectMany(t => t.Methods)
            .Where(m => (uint)m.RVA < 0xBE000 && (uint)m.RVA > 0)
            .OrderBy(m => (int)m.MDToken.Raw).ToList();
        Console.WriteLine("=== .text methods (first 5 by token) ===");
        for (int i = 0; i < Math.Min(5, textMethods.Count); i++) {
            var m = textMethods[i];
            Console.WriteLine("  token=0x{0:X8} RVA=0x{1:X6}", m.MDToken.Raw, (uint)m.RVA);
        }
    }
}
