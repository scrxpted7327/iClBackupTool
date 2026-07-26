using System;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

class VerifyDec {
    static void Main() {
        var mod = ModuleDefMD.Load(@"C:\deobfuscate\SpiderBackup_final.exe");
        
        // Find the 16 replaced methods (non-stub, actual instructions)
        int shown = 0;
        foreach (var t in mod.GetTypes()) {
            foreach (var m in t.Methods) {
                if (m.Body == null || !m.Body.HasInstructions) continue;
                if (m.Body.Instructions.Count <= 1) continue;
                if (m.Body.Instructions[0].OpCode == OpCodes.Ret) continue;
                
                shown++;
                if (shown > 5) break;
                
                Console.WriteLine("=== {0}.{1} ({2} instrs) ===", 
                    t.Name, m.Name, m.Body.Instructions.Count);
                for (int i = 0; i < Math.Min(8, m.Body.Instructions.Count); i++) {
                    var instr = m.Body.Instructions[i];
                    string opStr = instr.Operand == null ? "" : instr.Operand.ToString();
                    if (opStr.Length > 60) opStr = opStr.Substring(0, 60) + "...";
                    Console.WriteLine("  {0:X4}: {1} {2}", instr.Offset, instr.OpCode.Name, opStr);
                }
                Console.WriteLine();
            }
        }
        Console.WriteLine("Total non-trivial bodies: {0}", shown);
        
        // Compare with original encrypted form
        Console.WriteLine("\n=== Original encrypted data for first replaced method ===");
        byte[] peOrig = System.IO.File.ReadAllBytes(@"C:\deobfuscate\SpiderBackup.exe");
        foreach (var t in mod.GetTypes()) {
            foreach (var m in t.Methods) {
                if (m.Body == null || !m.Body.HasInstructions) continue;
                if (m.Body.Instructions.Count <= 1) continue;
                if (m.Body.Instructions[0].OpCode == OpCodes.Ret) continue;
                
                uint rva = (uint)m.RVA;
                uint fileOff = (uint)mod.Metadata.PEImage.ToFileOffset((dnlib.PE.RVA)rva);
                Console.WriteLine("Method at fileOff=0x{0:X8}:", fileOff);
                for (int i = 0; i < 16; i++)
                    Console.Write("{0:X2} ", peOrig[fileOff + i]);
                Console.WriteLine();
                break;
            }
        }
    }
}
