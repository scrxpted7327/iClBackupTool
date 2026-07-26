using System;
using System.IO;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.PE;

class DebugDecrypt {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        var mod = ModuleDefMD.Load(path);
        IPEImage peImage = mod.Metadata.PEImage;
        byte[] pe = File.ReadAllBytes(path);
        
        // Find metadata bounds
        uint cor20Rva = (uint)peImage.ImageNTHeaders.OptionalHeader.DataDirectories[14].VirtualAddress;
        uint cor20Raw = (uint)peImage.ToFileOffset((RVA)cor20Rva);
        uint metaRva = (uint)(pe[cor20Raw+8] | (pe[cor20Raw+9]<<8) | (pe[cor20Raw+10]<<16) | (pe[cor20Raw+11]<<24));
        uint metaSize = (uint)(pe[cor20Raw+12] | (pe[cor20Raw+13]<<8) | (pe[cor20Raw+14]<<16) | (pe[cor20Raw+15]<<24));
        uint metaRaw = (uint)peImage.ToFileOffset((RVA)metaRva);
        uint metaEnd = metaRaw + metaSize;
        
        Console.WriteLine("Metadata: RVA=0x{0:X8} fileOff=0x{1:X8}-0x{2:X8}", metaRva, metaRaw, metaEnd);
        Console.WriteLine("Signature at fileOff 0x{0:X8}:", metaRaw);
        for (int i = 0; i < 16; i++) 
            Console.Write("{0:X2} ", pe[metaRaw + i]);
        Console.WriteLine();
        
        // Find the ranges of all method bodies in .zN| section
        var ranges = new List<Tuple<uint, uint, string>>();
        foreach (var type in mod.GetTypes()) {
            foreach (var method in type.Methods) {
                if (method.RVA == 0) continue;
                uint rva = (uint)method.RVA;
                if (rva < 0x19E000) continue;
                uint fileOff = (uint)peImage.ToFileOffset((RVA)rva);
                
                // Find next method's file offset
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
                ranges.Add(Tuple.Create(fileOff, nextRaw, string.Format("{0:X8}", method.MDToken.Raw)));
            }
        }
        
        ranges.Sort((a, b) => a.Item1.CompareTo(b.Item1));
        
        // Check which ranges overlap metadata
        Console.WriteLine("\nBody ranges near metadata:");
        for (int i = 0; i < ranges.Count; i++) {
            var r = ranges[i];
            bool overlaps = r.Item1 < metaEnd && r.Item2 > metaRaw;
            if (r.Item2 >= metaRaw - 256 && r.Item1 <= metaEnd + 256) {
                Console.WriteLine("  {0:X6}-{1:X6} [{2}] {3}", 
                    r.Item1, r.Item2, overlaps ? "OVERLAP" : "OK", r.Item3);
            }
        }
    }
}
