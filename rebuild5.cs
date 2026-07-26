using System;
using System.IO;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.PE;
using dnlib.IO;

class Rebuild5 {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        string outPath = @"C:\deobfuscate\SpiderBackup_decrypted.exe";
        string finalPath = @"C:\deobfuscate\SpiderBackup_final.exe";
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        
        Console.WriteLine("Loading module...");
        var mod = ModuleDefMD.Load(path);
        IPEImage peImage = mod.Metadata.PEImage;
        byte[] pe = File.ReadAllBytes(path);
        
        // Load reference method's decrypted body (.dec_xor)
        int refToken = 0x06000497;
        byte[] refDec = File.ReadAllBytes(dumpDir + refToken.ToString("X8") + ".dec_xor");
        
        // Find reference method's file offset
        uint refFileOff = 0;
        foreach (var t in mod.GetTypes())
            foreach (var m in t.Methods)
                if ((int)m.MDToken.Raw == refToken) {
                    refFileOff = (uint)peImage.ToFileOffset((RVA)(uint)m.RVA);
                    break;
                }
        
        // Derive actual XOR key: key[i] = pe[refFileOff + i] ^ refDec[i]
        int keyLen = Math.Min(refDec.Length, (int)(pe.Length - refFileOff));
        byte[] xorKey = new byte[keyLen];
        for (int i = 0; i < keyLen; i++)
            xorKey[i] = (byte)(pe[refFileOff + i] ^ refDec[i]);
        
        Console.WriteLine("Reference: token=0x{0:X8} fileOff=0x{1:X8}", refToken, refFileOff);
        Console.WriteLine("Key length: {0} bytes", keyLen);
        
        // Find metadata and CLR header bounds so we don't corrupt them
        uint cor20Rva = (uint)peImage.ImageNTHeaders.OptionalHeader.DataDirectories[14].VirtualAddress;
        uint cor20Raw = (uint)peImage.ToFileOffset((RVA)cor20Rva);
        uint cor20Size = (uint)(pe[cor20Raw] | (pe[cor20Raw+1]<<8) | (pe[cor20Raw+2]<<16) | (pe[cor20Raw+3]<<24));
        uint cor20End = cor20Raw + cor20Size;
        uint metaRva = (uint)(pe[cor20Raw+8] | (pe[cor20Raw+9]<<8) | (pe[cor20Raw+10]<<16) | (pe[cor20Raw+11]<<24));
        uint metaSize = (uint)(pe[cor20Raw+12] | (pe[cor20Raw+13]<<8) | (pe[cor20Raw+14]<<16) | (pe[cor20Raw+15]<<24));
        uint metaRaw = (uint)peImage.ToFileOffset((RVA)metaRva);
        uint metaEnd = metaRaw + metaSize;
        Console.WriteLine("CLR header: fileOff=0x{0:X8}-0x{1:X8}", cor20Raw, cor20End);
        Console.WriteLine("Metadata: fileOff=0x{0:X8}-0x{1:X8}", metaRaw, metaEnd);
        
        // XOR-decrypt each method body in-place
        // Formula: pe[fileOff + i] ^= xorKey[i % keyLen]  (no section offset!)
        int decrypted = 0;
        int skipped = 0;
        foreach (var type in mod.GetTypes()) {
            foreach (var method in type.Methods) {
                if (method.RVA == 0) continue;
                uint rva = (uint)method.RVA;
                if (rva < 0x19E000) { skipped++; continue; }
                
                uint fileOff = (uint)peImage.ToFileOffset((RVA)rva);
                
                // Determine body size from next method's RVA
                uint nextRva = rva + 256;
                bool found = false;
                foreach (var t2 in mod.GetTypes())
                    foreach (var m2 in t2.Methods) {
                        uint mrva = (uint)m2.RVA;
                        if (mrva > rva && m2.MDToken.Raw != method.MDToken.Raw) {
                            if (!found || mrva < nextRva) { nextRva = mrva; found = true; }
                        }
                    }
                uint nextRaw = (uint)peImage.ToFileOffset((RVA)nextRva);
                int bodySize = (int)(nextRaw - fileOff);
                if (bodySize <= 0 || bodySize > 0x10000) bodySize = 256;
                if (fileOff + bodySize > pe.Length) bodySize = (int)(pe.Length - fileOff);
                if (bodySize <= 0) { skipped++; continue; }
                
                // XOR-decrypt: key starts from index 0 for each method
                for (int i = 0; i < bodySize; i++) {
                    uint off = fileOff + (uint)i;
                    // DON'T decrypt metadata or CLR header
                    if (off >= metaRaw && off < metaEnd) continue;
                    if (off >= cor20Raw && off < cor20End) continue;
                    pe[off] ^= xorKey[i % keyLen];
                }
                decrypted++;
            }
        }
        
        Console.WriteLine("XOR-decrypted {0} method bodies (skipped {1} .text methods)", decrypted, skipped);
        Console.WriteLine("Saving in-place decrypted PE...");
        File.WriteAllBytes(outPath, pe);
        Console.WriteLine("Written to {0}", outPath);
        
        Console.WriteLine("\nStep 2: Rebuild method bodies from decrypted PE...");
        var mod2 = ModuleDefMD.Load(outPath);
        byte[] pe2 = File.ReadAllBytes(outPath);
        
        int replaced = 0;
        int stubbed = 0;
        int errors = 0;
        int skippedText = 0;
        int rvaZeroStubbed = 0;
        foreach (var type in mod2.GetTypes()) {
            foreach (var method in type.Methods) {
                if (method.RVA == 0) {
                    // Methods with no body (proxy methods) - stub them
                    var stub = new CilBody();
                    stub.Instructions.Add(Instruction.Create(OpCodes.Ret));
                    stub.KeepOldMaxStack = true;
                    method.Body = stub;
                    rvaZeroStubbed++;
                    continue;
                }
                uint rva = (uint)method.RVA;
                if (rva < 0x19E000) { skippedText++; continue; }
                int token = (int)method.MDToken.Raw;
                
                try {
                    uint fileOff = (uint)mod2.Metadata.PEImage.ToFileOffset((RVA)rva);
                    uint nextRva = rva + 256;
                    bool found = false;
                    foreach (var t2 in mod2.GetTypes())
                        foreach (var m2 in t2.Methods) {
                            uint mrva = (uint)m2.RVA;
                            if (mrva > rva && m2.MDToken.Raw != (uint)method.MDToken.Raw) {
                                if (!found || mrva < nextRva) { nextRva = mrva; found = true; }
                            }
                        }
                    uint nextRaw = (uint)mod2.Metadata.PEImage.ToFileOffset((RVA)nextRva);
                    int bodySize = (int)(nextRaw - fileOff);
                    if (bodySize <= 0 || bodySize > 0x10000) bodySize = 256;
                    if (fileOff + bodySize > pe2.Length) bodySize = (int)(pe2.Length - fileOff);
                    if (bodySize <= 0) { stubbed++; continue; }
                    
                    byte[] bodyBytes = new byte[bodySize];
                    Array.Copy(pe2, fileOff, bodyBytes, 0, bodySize);
                    
                    var dataReader = ByteArrayDataReaderFactory.CreateReader(bodyBytes);
                    var reader = new MethodBodyReader(mod2, dataReader, method);
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
                            var stub = new CilBody();
                            stub.Instructions.Add(Instruction.Create(OpCodes.Ret));
                            stub.KeepOldMaxStack = true;
                            method.Body = stub;
                            stubbed++;
                        } else {
                            method.Body = body;
                            replaced++;
                        }
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
        Console.WriteLine("Replaced: {0}, Stubbed (null operands): {1}, Errors: {2}, Skipped (.text): {3}, RVA=0 stubbed: {4}", 
            replaced, stubbed, errors, skippedText, rvaZeroStubbed);
        
        Console.WriteLine("Stubbing anti-tamper cctors...");
        int stubbedCctor = 0;
        foreach (var t in mod2.GetTypes()) {
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
        
        mod2.Write(finalPath);
        Console.WriteLine("Final assembly saved to {0}", finalPath);
    }
}
