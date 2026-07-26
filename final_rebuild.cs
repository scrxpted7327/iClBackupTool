using System;
using System.IO;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.IO;

class FinalRebuild {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        string finalPath = @"C:\deobfuscate\SpiderBackup_final.exe";
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        
        Console.WriteLine("Loading module...");
        var mod = ModuleDefMD.Load(path);
        
        // Load .dec file lookup (proxy-resolved bodies, raw IL without header)
        var decFiles = new Dictionary<int, string>();
        foreach (var f in Directory.GetFiles(dumpDir, "*.dec")) {
            string name = Path.GetFileNameWithoutExtension(f);
            if (name.Contains("_")) {
                string[] parts = name.Split('_');
                if (parts.Length == 2) {
                    int methodToken = Convert.ToInt32(parts[1], 16);
                    decFiles[methodToken] = f;
                }
            }
        }
        Console.WriteLine("Found {0} .dec files", decFiles.Count);
        
        // Load .dec_xor file lookup (anti-tamper decrypted, has COR_ILMETHOD header)
        var decXorFiles = new Dictionary<int, string>();
        foreach (var f in Directory.GetFiles(dumpDir, "*.dec_xor")) {
            string name = Path.GetFileNameWithoutExtension(f);
            int methodToken = Convert.ToInt32(name, 16);
            decXorFiles[methodToken] = f;
        }
        Console.WriteLine("Found {0} .dec_xor files", decXorFiles.Count);
        
        int replaced = 0, stubbed = 0, usedDec = 0, usedDecXor = 0;
        
        foreach (var type in mod.GetTypes()) {
            foreach (var method in type.Methods) {
                int token = (int)method.MDToken.Raw;
                bool inZnz = (uint)method.RVA >= 0x19E000;
                
                // Already has a body set (RVA=0 abstract/runtime/etc.)
                if (method.RVA == 0) continue;
                
                // Priority 1: Use .dec file if available (proxy-resolved, .zN| only)
                string decFile;
                if (decFiles.TryGetValue(token, out decFile)) {
                    byte[] rawIl = File.ReadAllBytes(decFile);
                    byte[] bodyBytes = BuildCorIlMethod(rawIl);
                    if (SetBody(mod, method, bodyBytes)) {
                        replaced++;
                        usedDec++;
                        continue;
                    }
                }
                
                // Priority 2: Use .dec_xor file (has COR_ILMETHOD header already)
                string decXorFile;
                if (decXorFiles.TryGetValue(token, out decXorFile)) {
                    byte[] bodyBytes = File.ReadAllBytes(decXorFile);
                    if (SetBody(mod, method, bodyBytes)) {
                        replaced++;
                        usedDecXor++;
                        continue;
                    }
                }
                
                // Priority 3: Stub with ret
                var stub = new CilBody();
                stub.Instructions.Add(Instruction.Create(OpCodes.Ret));
                stub.KeepOldMaxStack = true;
                method.Body = stub;
                stubbed++;
            }
        }
        
        Console.WriteLine("Results: replaced={0} (dec={1}, dec_xor={2}), stubbed={3}",
            replaced, usedDec, usedDecXor, stubbed);
        
        // Verify body state before writing
        int bodiesOk = 0, bodiesNull = 0;
        foreach (var t in mod.GetTypes())
            foreach (var m in t.Methods)
                if (m.Body != null) bodiesOk++; else bodiesNull++;
        Console.WriteLine("Body state before write: ok={0}, null={1}", bodiesOk, bodiesNull);
        
        Console.WriteLine("Saving...");
        var opts = new dnlib.DotNet.Writer.ModuleWriterOptions(mod);
        opts.MetadataOptions.Flags = dnlib.DotNet.Writer.MetadataFlags.PreserveAll;
        mod.Write(finalPath, opts);
        Console.WriteLine("Saved to {0}", finalPath);
        
        // Verify
        try {
            var vMod = ModuleDefMD.Load(finalPath);
            int vBodies=0, vNoBodies=0, vRvaZero=0;
            foreach (var t in vMod.GetTypes())
                foreach (var m in t.Methods)
                    if (m.RVA == 0) vRvaZero++;
                    else if (m.Body != null) vBodies++;
                    else vNoBodies++;
            Console.WriteLine("Verify: bodies={0}, nullBodyWithRVA={1}, RVA=0={2}", 
                vBodies, vNoBodies, vRvaZero);
            if (vMod.EntryPoint != null) {
                var ep = vMod.EntryPoint;
                Console.WriteLine("EP: {0}.{1} RVA=0x{2:X8} Body={3}",
                    ep.DeclaringType.Name, ep.Name, (uint)ep.RVA, ep.Body != null ? "Y" : "N");
                if (ep.Body != null)
                    Console.WriteLine("  EP instr count: {0}", ep.Body.Instructions.Count);
            }
        } catch (Exception ex) {
            Console.WriteLine("Verify ERROR: {0}", ex.Message);
        }
    }
    
    static bool SetBody(ModuleDefMD mod, MethodDef method, byte[] bodyBytes) {
        try {
            var dr = ByteArrayDataReaderFactory.CreateReader(bodyBytes);
            var reader = new MethodBodyReader(mod, dr, method);
            if (reader.Read()) {
                var body = reader.CreateCilBody();
                body.KeepOldMaxStack = true;
                
                // Check for null operands
                bool hasNullOperand = false;
                foreach (var instr in body.Instructions) {
                    if (instr.Operand == null && instr.OpCode.OperandType != OperandType.InlineNone) {
                        hasNullOperand = true;
                        break;
                    }
                }
                
                if (hasNullOperand) {
                    body.Instructions.Clear();
                    body.Instructions.Add(Instruction.Create(OpCodes.Ret));
                }
                
                method.Body = body;
                return true;
            }
        } catch {}
        return false;
    }
    
    static byte[] BuildCorIlMethod(byte[] il) {
        if (il.Length < 64) {
            byte[] body = new byte[1 + il.Length];
            body[0] = (byte)((il.Length << 2) | 0x02);
            Buffer.BlockCopy(il, 0, body, 1, il.Length);
            return body;
        } else {
            byte[] body = new byte[12 + il.Length];
            body[0] = 0x03; body[1] = 0x30;
            body[2] = 0x08; body[3] = 0x00;
            body[4] = (byte)il.Length;
            body[5] = (byte)(il.Length >> 8);
            body[6] = (byte)(il.Length >> 16);
            body[7] = (byte)(il.Length >> 24);
            body[8] = 0; body[9] = 0;
            body[10] = 0; body[11] = 0;
            Buffer.BlockCopy(il, 0, body, 12, il.Length);
            return body;
        }
    }
}
