using System;
using System.IO;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.PE;
using dnlib.DotNet.Emit;
using dnlib.IO;

class RawPatch4 {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        string outPath = @"C:\deobfuscate\SpiderBackup_rawpatched4.exe";
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        
        var mod = ModuleDefMD.Load(path);
        IPEImage peImage = mod.Metadata.PEImage;
        byte[] pe = File.ReadAllBytes(path);
        
        // Load .dec file lookup
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
        
        // XOR key from reference method
        int refToken = 0x06000497;
        byte[] refDec = File.ReadAllBytes(dumpDir + refToken.ToString("X8") + ".dec_xor");
        uint refFileOff = 0;
        foreach (var t in mod.GetTypes())
            foreach (var m in t.Methods)
                if ((int)m.MDToken.Raw == refToken)
                    refFileOff = (uint)peImage.ToFileOffset((RVA)(uint)m.RVA);
        int keyLen = Math.Min(refDec.Length, (int)(pe.Length - refFileOff));
        byte[] xorKey = new byte[keyLen];
        for (int i = 0; i < keyLen; i++)
            xorKey[i] = (byte)(pe[refFileOff + i] ^ refDec[i]);
        Console.WriteLine("XOR key: {0} bytes", keyLen);
        
        // Locate CLR header & metadata for protection
        uint cor20Rva = (uint)peImage.ImageNTHeaders.OptionalHeader.DataDirectories[14].VirtualAddress;
        uint cor20Raw = (uint)peImage.ToFileOffset((RVA)cor20Rva);
        cor20Raw -= cor20Raw % 8;
        uint metaRva = (uint)(pe[cor20Raw+8] | (pe[cor20Raw+9]<<8) | (pe[cor20Raw+10]<<16) | (pe[cor20Raw+11]<<24));
        uint metaSize = (uint)(pe[cor20Raw+12] | (pe[cor20Raw+13]<<8) | (pe[cor20Raw+14]<<16) | (pe[cor20Raw+15]<<24));
        uint metaRaw = (uint)peImage.ToFileOffset((RVA)metaRva);
        uint metaEnd = metaRaw + metaSize;
        
        // XOR-decrypt .zN| method bodies with correct key alignment
        int decrypted = 0;
        foreach (var type in mod.GetTypes()) {
            foreach (var method in type.Methods) {
                if (method.RVA == 0) continue;
                if ((uint)method.RVA < 0x19E000) continue;
                
                uint rva = (uint)method.RVA;
                uint fileOff = (uint)peImage.ToFileOffset((RVA)rva);
                int bodySize = GetBodySize(mod, peImage, pe, fileOff, rva, method);
                if (bodySize <= 2) continue;
                
                long offFromRef = (long)fileOff - (long)refFileOff;
                for (int i = 0; i < bodySize; i++) {
                    uint off = fileOff + (uint)i;
                    if (off >= metaRaw && off < metaEnd) continue;
                    if (off >= cor20Raw && off < cor20Raw + 72) continue;
                    int ki = (int)((offFromRef + i) % keyLen);
                    if (ki < 0) ki += keyLen;
                    pe[off] ^= xorKey[ki];
                }
                decrypted++;
            }
        }
        Console.WriteLine("XOR-decrypted {0} methods", decrypted);
        
        // Replace method bodies with .dec data (protect CLR header and metadata)
        int patched = 0, truncated = 0;
        foreach (var type in mod.GetTypes()) {
            foreach (var method in type.Methods) {
                if (method.RVA == 0) continue;
                uint rva = (uint)method.RVA;
                int token = (int)method.MDToken.Raw;
                string decFile;
                if (!decFiles.TryGetValue(token, out decFile)) continue;
                
                uint fileOff = (uint)peImage.ToFileOffset((RVA)rva);
                int availSize = GetBodySize(mod, peImage, pe, fileOff, rva, method);
                
                // Skip if this method body overlaps with CLR header or metadata
                uint bodyEnd = fileOff + (uint)availSize;
                if ((fileOff < metaEnd && bodyEnd > metaRaw) ||
                    (fileOff < cor20Raw + 72 && bodyEnd > cor20Raw)) {
                    Console.WriteLine("  SKIP (overlaps CLR/meta): token=0x{0:X8} body=0x{1:X8}-0x{2:X8}", 
                        token, fileOff, bodyEnd);
                    continue;
                }
                
                byte[] resolvedIl = File.ReadAllBytes(decFile);
                byte[] newBody = BuildCorIlMethod(resolvedIl);
                
                int writeSize = Math.Min(newBody.Length, availSize);
                Array.Copy(newBody, 0, pe, fileOff, writeSize);
                if (writeSize < availSize)
                    Array.Clear(pe, (int)(fileOff + writeSize), availSize - writeSize);
                if (writeSize < newBody.Length) truncated++;
                patched++;
            }
        }
        Console.WriteLine("Patched: {0}, Truncated: {1}", patched, truncated);
        
        // For .zN| methods without .dec, stub with ret (protect CLR/meta)
        int stubbed = 0;
        foreach (var type in mod.GetTypes()) {
            foreach (var method in type.Methods) {
                if (method.RVA == 0) continue;
                if ((uint)method.RVA < 0x19E000) continue;
                int token = (int)method.MDToken.Raw;
                if (decFiles.ContainsKey(token)) continue;
                
                uint fileOff = (uint)peImage.ToFileOffset((RVA)(uint)method.RVA);
                uint bodyEnd = fileOff + 2;
                if ((fileOff < metaEnd && bodyEnd > metaRaw) ||
                    (fileOff < cor20Raw + 72 && bodyEnd > cor20Raw))
                    continue;
                pe[fileOff] = 0x06; pe[fileOff + 1] = 0x2A;
                stubbed++;
            }
        }
        Console.WriteLine("Stubbed: {0}", stubbed);
        
        // Restore CLR header and metadata from original PE
        byte[] origPe = File.ReadAllBytes(path);
        Array.Copy(origPe, cor20Raw, pe, cor20Raw, 72);
        Array.Copy(origPe, metaRaw, pe, metaRaw, metaSize);
        
        File.WriteAllBytes(outPath, pe);
        Console.WriteLine("Saved {0} bytes to {1}", pe.Length, outPath);
        
        // Verify
        try {
            var vMod = ModuleDefMD.Load(outPath);
            int bodies=0, noBodies=0, rvaZero=0;
            foreach (var t in vMod.GetTypes())
                foreach (var m in t.Methods)
                    if (m.RVA == 0) rvaZero++;
                    else if (m.Body != null) bodies++;
                    else noBodies++;
            Console.WriteLine("Verify: bodies={0}, nullBodyWithRVA={1}, RVA=0={2}", bodies, noBodies, rvaZero);
            var ep = vMod.EntryPoint;
            Console.WriteLine("EP: {0}.{1} RVA=0x{2:X8} Body={3}",
                ep.DeclaringType.Name, ep.Name, (uint)ep.RVA, ep.Body != null ? "Y" : "N");
            
            // Check for RVA=0 methods that are not abstract/runtime
            int problems = 0;
            foreach (var t in vMod.GetTypes()) {
                foreach (var m in t.Methods) {
                    if (m.RVA == 0 && !m.IsAbstract && !m.IsRuntime && !m.IsInternalCall && !m.IsPinvokeImpl) {
                        if (problems < 10) {
                            Console.WriteLine("  Problem: {0}.{1} RVA=0 not abst/runtime/pinvoke", 
                                m.DeclaringType.Name, m.Name);
                        }
                        problems++;
                    }
                }
            }
            Console.WriteLine("Problem methods (RVA=0 non-abstract): {0}", problems);
        } catch (Exception ex) {
            Console.WriteLine("Verify ERROR: {0}", ex.Message);
        }
    }
    
    static uint GetNextMethodRva(ModuleDefMD mod, MethodDef method, uint rva) {
        uint nextRva = rva + 256;
        foreach (var t in mod.GetTypes())
            foreach (var m in t.Methods) {
                uint mrva = (uint)m.RVA;
                if (mrva > rva && m.MDToken.Raw != method.MDToken.Raw && mrva < nextRva)
                    nextRva = mrva;
            }
        return nextRva;
    }
    
    static int GetBodySize(ModuleDefMD mod, IPEImage peImage, byte[] pe, uint fileOff, uint rva, MethodDef method) {
        uint nextRva = GetNextMethodRva(mod, method, rva);
        uint nextRaw = (uint)peImage.ToFileOffset((RVA)nextRva);
        int bodySize = (int)(nextRaw - fileOff);
        if (bodySize <= 0 || bodySize > 0x10000) bodySize = 256;
        if (fileOff + bodySize > pe.Length) bodySize = (int)(pe.Length - fileOff);
        return bodySize;
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
