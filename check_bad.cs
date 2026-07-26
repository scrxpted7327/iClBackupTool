using System;
using System.IO;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.IO;

class CheckBad {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        
        var mod = ModuleDefMD.Load(path);
        
        foreach (var type in mod.GetTypes()) {
            foreach (var method in type.Methods) {
                if (method.RVA == 0) continue;
                
                int token = (int)method.MDToken.Raw;
                string xorFile = dumpDir + token.ToString("X8") + ".dec_xor";
                if (!File.Exists(xorFile)) continue;
                
                byte[] bodyBytes = File.ReadAllBytes(xorFile);
                var dataReader = ByteArrayDataReaderFactory.CreateReader(bodyBytes);
                var reader = new MethodBodyReader(mod, dataReader, method);
                if (!reader.Read()) {
                    string section = (uint)method.RVA < 0x19E000u ? ".text" : ".zN|";
                    uint rva = (uint)method.RVA;
                    Console.WriteLine("FAILED 0x{0:X8} RVA=0x{1:X8} [{2}] {3}.{4} ({5} bytes)",
                        token, rva, section, 
                        method.DeclaringType.Name, method.Name, bodyBytes.Length);
                    Console.WriteLine("  Header byte: 0x{0:X2} ({1})", bodyBytes[0], (bodyBytes[0] & 3) == 2 ? "tiny" : (bodyBytes[0] & 3) == 3 ? "fat" : "other");
                }
            }
        }
    }
}
