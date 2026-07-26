using System;
using System.IO;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

class DumpBody {
    static void Main() {
        var mod = ModuleDefMD.Load(@"C:\deobfuscate\Patched_SpiderBackup.exe");
        foreach (var t in mod.Types) {
            if (!t.Name.Contains("78492021")) continue;
            foreach (var nt in t.NestedTypes) {
                if (!nt.Name.Contains("6D2115ED")) continue;
                foreach (var m in nt.Methods) {
                    if (!m.IsStatic || !m.IsConstructor || m.IsInstanceConstructor) continue;
                    Console.WriteLine("cctor RVA=0x{0:X} instrs={1}", m.RVA, m.Body.Instructions.Count);
                    
                    // Read raw bytes from the saved file
                    byte[] pe = File.ReadAllBytes(@"C:\deobfuscate\Patched_SpiderBackup.exe");
                    
                    // Find the correct file offset based on .zN| section
                    // We know .zN| is at RVA 0x19E000, file offset 0x400
                    uint rva = (uint)m.RVA;
                    uint fileOff = (rva >= 0x19E000) ? (0x400 + (rva - 0x19E000)) : rva;
                    
                    Console.WriteLine("File offset: 0x{0:X}", fileOff);
                    for (int i = 0; i < 28; i += 16) {
                        string h = "";
                        for (int j = 0; j < 16 && (int)fileOff+i+j < pe.Length; j++)
                            h += pe[fileOff+i+j].ToString("X2") + " ";
                        Console.WriteLine("  +{0:X4}: {1}", i, h);
                    }
                    
                    // Print IL
                    Console.WriteLine("Instructions:");
                    foreach (var inst in m.Body.Instructions)
                        Console.WriteLine("  IL_{0:X4}: {1} {2}", inst.Offset, inst.OpCode.Name, inst.Operand);
                }
            }
        }
    }
}
