using System;
using System.IO;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.DotNet.MD;
using dnlib.IO;
using dnlib.PE;

class Rebuild2 {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        string outPath = @"C:\deobfuscate\SpiderBackup_deobfuscated2.exe";
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        
        Console.WriteLine("Loading module...");
        var mod = ModuleDefMD.Load(path);
        
        // Read the XOR key from the key derivation method's data
        // The key was derived from token 0x06000497
        // First, find the actual file offset for each method
        IPEImage peImage = mod.Metadata.PEImage;
        
        // Get all methods with their tokens, RVAs, and section info
        var methodInfos = new List<Tuple<uint, uint, int>>(); // rva, rawOff, token
        foreach (var type in mod.GetTypes()) {
            foreach (var method in type.Methods) {
                if (method.RVA == 0) continue;
                uint rva = (uint)method.RVA;
                uint rawOff = (uint)peImage.ToFileOffset((RVA)rva);
                int token = (int)method.MDToken.Raw;
                methodInfos.Add(Tuple.Create(rva, rawOff, token));
            }
        }
        methodInfos.Sort((a, b) => a.Item1.CompareTo(b.Item1));
        
        // Read the PE bytes for encrypted data
        byte[] peBytes = File.ReadAllBytes(path);
        
        // Try to find a decrypted method body to use as reference for token fixup
        // Use the .dec files (from reflection) which have correct tokens
        var tokenToDecBytes = new Dictionary<int, byte[]>();
        foreach (var mi in methodInfos) {
            string decFile = dumpDir + mi.Item3.ToString("X8") + ".dec_xor";
            if (File.Exists(decFile)) {
                tokenToDecBytes[mi.Item3] = File.ReadAllBytes(decFile);
            }
        }
        
        int replaced = 0;
        int stubbed = 0;
        int skipped = 0;
        int errors = 0;
        
        foreach (var type in mod.GetTypes()) {
            foreach (var method in type.Methods) {
                if (method.RVA == 0) continue;
                
                int token = (int)method.MDToken.Raw;
                uint rva = (uint)method.RVA;
                
                // Only process .zN| section methods
                if (rva < 0x19E000) {
                    skipped++;
                    continue;
                }
                
                // Get raw file offset for this method
                uint rawOff = (uint)peImage.ToFileOffset((RVA)rva);
                
                // Find the next method's raw offset to determine body size
                int nextIdx = -1;
                for (int i = 0; i < methodInfos.Count; i++) {
                    if (methodInfos[i].Item3 == token) {
                        nextIdx = i + 1;
                        break;
                    }
                }
                uint nextRawOff = 0;
                if (nextIdx >= 0 && nextIdx < methodInfos.Count) {
                    nextRawOff = (uint)peImage.ToFileOffset((RVA)methodInfos[nextIdx].Item1);
                }
                
                byte[] decBytes = null;
                if (tokenToDecBytes.TryGetValue(token, out decBytes)) {
                    // Try to parse the body
                    try {
                        var dataReader = ByteArrayDataReaderFactory.CreateReader(decBytes);
                        var reader = new MethodBodyReader(mod, dataReader, method);
                        if (reader.Read()) {
                            var body = reader.CreateCilBody();
                            body.KeepOldMaxStack = true;
                            
                            // Check if operands are valid
                            bool hasNullOperands = false;
                            foreach (var instr in body.Instructions) {
                                if (instr.Operand == null && instr.OpCode.OperandType != OperandType.InlineNone) {
                                    hasNullOperands = true;
                                    break;
                                }
                            }
                            
                            if (!hasNullOperands) {
                                method.Body = body;
                                replaced++;
                                if (replaced <= 3) {
                                    Console.WriteLine("  OK 0x{0:X8}: {1}.{2} ({3} instrs)", 
                                        token, method.DeclaringType.Name, method.Name, body.Instructions.Count);
                                }
                                continue;
                            } else {
                                // Try to fix null operands by resolving from raw token
                                Console.WriteLine("  FIXING 0x{0:X8}: {1}.{2} - trying raw body", 
                                    token, method.DeclaringType.Name, method.Name);
                            }
                        }
                    } catch { }
                }
                
                // If we can't parse or have null operands, use NativeMethodBody
                if (decBytes != null) {
                    method.Body = new NativeMethodBody(decBytes);
                    stubbed++;
                } else {
                    skipped++;
                }
            }
        }
        
        Console.WriteLine("\nReplaced: {0}, NativeBody: {1}, Skipped: {2}", replaced, stubbed, skipped);
        Console.WriteLine("Saving...");
        mod.Write(outPath);
        Console.WriteLine("Done!");
    }
}
