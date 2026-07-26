using System;
using System.IO;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.IO;

class RebuildResolved {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        string finalPath = @"C:\deobfuscate\SpiderBackup_resolved.exe";
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        
        Console.WriteLine("Loading module...");
        var mod = ModuleDefMD.Load(path);
        
        // Build lookup of .dec files by method token
        var decFiles = new Dictionary<int, string>();
        foreach (var f in Directory.GetFiles(dumpDir, "*.dec")) {
            // Format: {typeToken}_{methodToken}.dec or {methodToken}.dec_xor
            string name = Path.GetFileNameWithoutExtension(f);
            string ext = Path.GetExtension(f);
            if (ext == ".dec") {
                // Try to extract method token from filename
                // Format: TTTTTTTT_MMMMMMMM.dec
                string[] parts = name.Split('_');
                if (parts.Length == 2) {
                    int methodToken = Convert.ToInt32(parts[1], 16);
                    decFiles[methodToken] = f;
                }
            }
        }
        Console.WriteLine("Found {0} .dec files", decFiles.Count);
        
        int replaced = 0;
        int stubbedNullOp = 0;
        int skipped = 0;
        int errors = 0;
        int rvaZeroStubbed = 0;
        int noDecFile = 0;
        
        // First pass: stub all methods with RVA==0
        foreach (var type in mod.GetTypes())
            foreach (var method in type.Methods)
                if (method.RVA == 0 && !method.IsAbstract && !method.IsRuntime) {
                    var stub = new CilBody();
                    stub.Instructions.Add(Instruction.Create(OpCodes.Ret));
                    stub.KeepOldMaxStack = true;
                    method.Body = stub;
                    rvaZeroStubbed++;
                }
        
        // Second pass: replace .zN| method bodies from .dec files
        foreach (var type in mod.GetTypes()) {
            foreach (var method in type.Methods) {
                if (method.RVA == 0) continue;
                
                int token = (int)method.MDToken.Raw;
                
                // Skip .text methods - they were never anti-tampered
                if ((uint)method.RVA < 0x19E000) {
                    skipped++;
                    continue;
                }
                
                // Try .dec file first (proxy-resolved)
                string decFile;
                string bodySource;
                byte[] bodyBytes;
                
                if (decFiles.TryGetValue(token, out decFile)) {
                    byte[] rawIl = File.ReadAllBytes(decFile);
                    bodySource = ".dec";
                    // Prepend COR_ILMETHOD header (GetILAsByteArray returns raw IL only)
                    if (rawIl.Length < 64) {
                        // Tiny header: (codeSize << 2) | 0x02
                        bodyBytes = new byte[1 + rawIl.Length];
                        bodyBytes[0] = (byte)((rawIl.Length << 2) | 0x02);
                        Buffer.BlockCopy(rawIl, 0, bodyBytes, 1, rawIl.Length);
                    } else {
                        // Fat header: 3 DWORDs
                        bodyBytes = new byte[12 + rawIl.Length];
                        bodyBytes[0] = 0x03; // flags: fat, init locals
                        bodyBytes[1] = 0x30; // size = 3 DWORDs
                        bodyBytes[2] = 0x08; bodyBytes[3] = 0x00; // maxStack = 8
                        bodyBytes[4] = (byte)(rawIl.Length);
                        bodyBytes[5] = (byte)(rawIl.Length >> 8);
                        bodyBytes[6] = (byte)(rawIl.Length >> 16);
                        bodyBytes[7] = (byte)(rawIl.Length >> 24);
                        bodyBytes[8] = 0; bodyBytes[9] = 0; // no local vars
                        bodyBytes[10] = 0; bodyBytes[11] = 0;
                        Buffer.BlockCopy(rawIl, 0, bodyBytes, 12, rawIl.Length);
                    }
                } else {
                    noDecFile++;
                    // Fall back to .dec_xor (already has COR_ILMETHOD header)
                    string xorFile = dumpDir + token.ToString("X8") + ".dec_xor";
                    if (!File.Exists(xorFile)) { skipped++; continue; }
                    bodyBytes = File.ReadAllBytes(xorFile);
                    bodySource = ".dec_xor";
                }
                
                try {
                    var dataReader = ByteArrayDataReaderFactory.CreateReader(bodyBytes);
                    var reader = new MethodBodyReader(mod, dataReader, method);
                    if (reader.Read()) {
                        var body = reader.CreateCilBody();
                        body.KeepOldMaxStack = true;
                        
                        bool hasNullOperands = false;
                        foreach (var instr in body.Instructions) {
                            if (instr.Operand == null && instr.OpCode.OperandType != OperandType.InlineNone) {
                                hasNullOperands = true;
                                break;
                            }
                        }
                        
                        if (hasNullOperands) {
                            body.Instructions.Clear();
                            body.Instructions.Add(Instruction.Create(OpCodes.Ret));
                            stubbedNullOp++;
                        }
                        
                        method.Body = body;
                        replaced++;
                    } else {
                        var stub = new CilBody();
                        stub.Instructions.Add(Instruction.Create(OpCodes.Ret));
                        stub.KeepOldMaxStack = true;
                        method.Body = stub;
                        errors++;
                    }
                } catch {
                    var stub = new CilBody();
                    stub.Instructions.Add(Instruction.Create(OpCodes.Ret));
                    stub.KeepOldMaxStack = true;
                    method.Body = stub;
                    errors++;
                }
            }
        }
        
        // Force-load bodies for all remaining methods (.text, etc.) so writer can re-serialize them
        int textBodyLoaded = 0;
        foreach (var type in mod.GetTypes()) {
            foreach (var method in type.Methods) {
                if (method.Body == null && method.RVA != 0) {
                    try {
                        // Force dnlib to load body from PE data
                        var _ = method.Body;
                        // If still null, need to read from original PE directly
                        if (method.Body == null) {
                            // Read bytes from original PE at this method's RVA
                            uint rva2 = (uint)method.RVA;
                            uint fileOff2 = (uint)mod.Metadata.PEImage.ToFileOffset((dnlib.PE.RVA)rva2);
                            int bodySize2 = 256;
                            byte[] rawBody2 = new byte[bodySize2];
                            System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                            fs.Seek(fileOff2, System.IO.SeekOrigin.Begin);
                            fs.Read(rawBody2, 0, bodySize2);
                            fs.Close();
                            
                            var dr2 = ByteArrayDataReaderFactory.CreateReader(rawBody2);
                            var rdr2 = new MethodBodyReader(mod, dr2, method);
                            if (rdr2.Read()) {
                                method.Body = rdr2.CreateCilBody();
                                method.Body.KeepOldMaxStack = true;
                                textBodyLoaded++;
                            } else {
                                var stub = new CilBody();
                                stub.Instructions.Add(Instruction.Create(OpCodes.Ret));
                                stub.KeepOldMaxStack = true;
                                method.Body = stub;
                                textBodyLoaded++;
                            }
                        }
                    } catch {
                        var stub = new CilBody();
                        stub.Instructions.Add(Instruction.Create(OpCodes.Ret));
                        stub.KeepOldMaxStack = true;
                        method.Body = stub;
                        textBodyLoaded++;
                    }
                }
            }
        }
        
        Console.WriteLine("Replaced: {0}, Stubbed (null op): {1}, Skipped: {2}, Errors: {3}, RVA=0: {4}, No .dec: {5}, Text bodies loaded: {6}", 
            replaced, stubbedNullOp, skipped, errors, rvaZeroStubbed, noDecFile, textBodyLoaded);
        
        // Stub anti-tamper cctors
        Console.WriteLine("Stubbing anti-tamper cctors...");
        int stubbedCctor = 0;
        foreach (var t in mod.GetTypes()) {
            foreach (var m in t.Methods) {
                if ((uint)m.RVA == 0) continue;
                if (m.Name == ".cctor" && (uint)m.RVA >= 0x19E000) {
                    var stub = new CilBody();
                    stub.Instructions.Add(Instruction.Create(OpCodes.Ret));
                    stub.KeepOldMaxStack = true;
                    m.Body = stub;
                    stubbedCctor++;
                }
            }
        }
        Console.WriteLine("Stubbed {0} cctors", stubbedCctor);
        
        Console.WriteLine("Saving...");
        var opts = new dnlib.DotNet.Writer.ModuleWriterOptions(mod);
        opts.MetadataOptions.Flags = dnlib.DotNet.Writer.MetadataFlags.PreserveAll;
        mod.Write(finalPath, opts);
        Console.WriteLine("Saved to {0}", finalPath);
    }
}
