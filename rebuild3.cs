using System;
using System.IO;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.IO;
using dnlib.PE;

class Rebuild3 {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        string outPath = @"C:\deobfuscate\SpiderBackup_deobfuscated3.exe";
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        
        Console.WriteLine("Loading module...");
        var mod = ModuleDefMD.Load(path);
        IPEImage peImage = mod.Metadata.PEImage;
        byte[] peBytes = File.ReadAllBytes(path);
        
        // Load the XOR key from the longest method's .dec_xor file
        int refToken = 0x06000497;
        string refFile = dumpDir + refToken.ToString("X8") + ".dec_xor";
        if (!File.Exists(refFile)) {
            Console.WriteLine("Reference file not found!");
            return;
        }
        byte[] xorKey = File.ReadAllBytes(refFile);
        
        // Find the reference method's RVA and file offset
        uint refRva = 0, refFileOff = 0;
        foreach (var type in mod.GetTypes())
            foreach (var m in type.Methods)
                if ((int)m.MDToken.Raw == refToken) {
                    refRva = (uint)m.RVA;
                    refFileOff = (uint)peImage.ToFileOffset((RVA)refRva);
                    break;
                }
        
        Console.WriteLine("Reference: token 0x{0:X8}, RVA=0x{1:X8}, fileOff=0x{2:X8}, rawLen={3}",
            refToken, refRva, refFileOff, xorKey.Length);
        
        int replaced = 0;
        int stubbed = 0;
        int skipped = 0;
        int errors = 0;
        
        foreach (var type in mod.GetTypes()) {
            foreach (var method in type.Methods) {
                if (method.RVA == 0) continue;
                
                int token = (int)method.MDToken.Raw;
                uint rva = (uint)method.RVA;
                
                if (rva < 0x19E000) { skipped++; continue; }
                
                uint fileOff = (uint)peImage.ToFileOffset((RVA)rva);
                
                // Encrypted body exists in the file
                // Apply key with offset = (method_fileOff - ref_fileOff)
                int keyOff = (int)(fileOff - refFileOff);
                
                // Find body size from RVA interval
                int bodySize = 0;
                uint nextRva = 0;
                bool found = false;
                foreach (var type2 in mod.GetTypes())
                    foreach (var m2 in type2.Methods)
                        if ((uint)m2.RVA > rva && ((int)m2.MDToken.Raw) != token) {
                            if (!found || (uint)m2.RVA < nextRva) {
                                nextRva = (uint)m2.RVA;
                                found = true;
                            }
                        }
                if (found) bodySize = (int)Math.Min(nextRva - rva, 0x10000);
                else bodySize = 256;
                
                if (fileOff + bodySize > peBytes.Length)
                    bodySize = (int)(peBytes.Length - fileOff);
                if (bodySize <= 0) { skipped++; continue; }
                
                byte[] dec = new byte[bodySize];
                for (int i = 0; i < bodySize; i++)
                    dec[i] = (byte)(peBytes[fileOff + i] ^ xorKey[(keyOff + i) % xorKey.Length]);
                
                // Try to parse as CIL - if it works with valid operands, use the parsed body
                // Otherwise, write the raw XOR-decrypted bytes directly
                bool parsed = false;
                try {
                    var dataReader = ByteArrayDataReaderFactory.CreateReader(dec);
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
                        
                        if (!hasNullOperands) {
                            // Only use parsed body if all operands resolved and code is reasonable
                            if (body.Instructions.Count > 0 && body.Instructions.Count < 10000) {
                                method.Body = body;
                                replaced++;
                                parsed = true;
                                if (replaced <= 3) {
                                    Console.WriteLine("  OK 0x{0:X8}: {1}.{2} ({3} instrs)", 
                                        token, method.DeclaringType.Name, method.Name, body.Instructions.Count);
                                }
                            }
                        }
                    }
                } catch { }
                
                if (!parsed) {
                    // Write raw decrypted bytes directly to the PE section
                    // We need to patch the section data, not modify method.Body
                    int rawOff = (int)fileOff;
                    for (int i = 0; i < bodySize && rawOff + i < peBytes.Length; i++)
                        peBytes[rawOff + i] = dec[i];
                    stubbed++;
            }
        }
        
        Console.WriteLine("\nReplaced: {0}, NativeBody: {1}, Skipped: {2}", replaced, stubbed, skipped);
        Console.WriteLine("Saving...");
        mod.Write(outPath);
        Console.WriteLine("Done!");
    }
}
