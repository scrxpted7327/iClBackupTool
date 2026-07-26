using System;
using System.IO;
using dnlib.DotNet;
using dnlib.PE;

class CheckPe {
    static void Main() {
        var mod = ModuleDefMD.Load(@"C:\deobfuscate\SpiderBackup.exe");
        
        int textBodyOk=0, textBodyEmpty=0, textBodyErr=0, textBodyInstr=0;
        int znzBodyOk=0, znzBodyEmpty=0, znzBodyErr=0;
        
        foreach (var t in mod.GetTypes()) {
            foreach (var m in t.Methods) {
                if (m.RVA == 0) continue;
                bool isText = (uint)m.RVA < 0x19E000;
                try {
                    var body = m.Body;
                    if (body == null) {
                        if (isText) textBodyEmpty++; else znzBodyEmpty++;
                    } else {
                        int instrCount = 0;
                        try { instrCount = body.Instructions.Count; } catch {}
                        if (instrCount == 0 && isText) {
                            textBodyEmpty++;
                        } else {
                            if (isText) { textBodyOk++; textBodyInstr += instrCount; }
                            else znzBodyOk++;
                        }
                    }
                } catch {
                    if (isText) textBodyErr++; else znzBodyErr++;
                }
            }
        }
        
        Console.WriteLine(".text: ok={0}, empty=0{1}, err={2}, totalInstr={3}", 
            textBodyOk, textBodyEmpty, textBodyErr, textBodyInstr);
        Console.WriteLine(".zN|: ok={0}, empty=1{1}, err={2}", 
            znzBodyOk, znzBodyEmpty, znzBodyErr);
        
        // Check EP specifically
        var ep = mod.EntryPoint;
        Console.WriteLine("\nEP: {0}.{1}", ep.DeclaringType.Name, ep.Name);
        Console.WriteLine("  RVA=0x{0:X8}", (uint)ep.RVA);
        Console.WriteLine("  Body=null? {0}", ep.Body == null);
        if (ep.Body != null) {
            Console.WriteLine("  Instr count: {0}", ep.Body.Instructions.Count);
            Console.WriteLine("  First: {0}", ep.Body.Instructions.Count > 0 ? ep.Body.Instructions[0].ToString() : "(none)");
        }
        
        // Check a few text method bodies
        Console.WriteLine("\nSampling .text methods:");
        int sampled = 0;
        foreach (var t in mod.GetTypes()) {
            foreach (var m in t.Methods) {
                if (m.RVA == 0) continue;
                if ((uint)m.RVA >= 0x19E000) continue;
                if (sampled >= 5) break;
                try {
                    var b = m.Body;
                    if (b != null) {
                        int instrs = b.Instructions.Count;
                        string firstOp = instrs > 0 ? b.Instructions[0].OpCode.Name : "(no instr)";
                        Console.WriteLine("  {0}.{1}: RVA=0x{2:X8}, instrs={3}, first={4}", 
                            m.DeclaringType.Name, m.Name, (uint)m.RVA, instrs, firstOp);
                        sampled++;
                    }
                } catch {}
            }
            if (sampled >= 5) break;
        }
        
        // Now test what happens when writing: check if the writer accesses body property
        Console.WriteLine("\n--- Write test ---");
        var mod2 = ModuleDefMD.Load(@"C:\deobfuscate\SpiderBackup.exe");
        
        // Write to a stream to test
        var memStream = new MemoryStream();
        mod2.Write(memStream);
        Console.WriteLine("Wrote {0} bytes to stream", memStream.Length);
        
        // Load from stream
        memStream.Position = 0;
        var mod3 = ModuleDefMD.Load(memStream);
        int bodies=0, noBodies=0;
        foreach (var t in mod3.GetTypes())
            foreach (var m in t.Methods)
                if (m.Body != null && m.RVA != 0) bodies++;
                else if (m.RVA != 0) noBodies++;
        
        Console.WriteLine("Result: bodies={0}, rva!=0 but null body={1}", bodies, noBodies);
        var ep3 = mod3.EntryPoint;
        Console.WriteLine("EP after: RVA=0x{0:X8}, Body=null? {1}", (uint)ep3.RVA, ep3.Body == null);
    }
}
