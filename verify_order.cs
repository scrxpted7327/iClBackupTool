using System;
using System.IO;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.PE;

class VerifyOrder {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        
        var mod = ModuleDefMD.Load(path);
        byte[] pe = File.ReadAllBytes(path);
        var peImg = new PEImage(path);
        
        // True RVA to file offset using dnlib
        Func<uint, uint> toFileOff = rva => (uint)peImg.ToFileOffset((RVA)rva);
        
        // Manual RVA to file offset (ignores SizeOfRawData=0)
        uint e_lfanew = (uint)(pe[0x3C] | (pe[0x3D] << 8) | (pe[0x3E] << 16) | (pe[0x3F] << 24));
        ushort numSections = (ushort)(pe[e_lfanew + 6] | (pe[e_lfanew + 7] << 8));
        ushort optHdrSize = (ushort)(pe[e_lfanew + 16] | (pe[e_lfanew + 17] << 8));
        uint secOffset = e_lfanew + 24 + optHdrSize;
        
        var sections = new List<Tuple<uint, uint, uint, uint>>();
        for (int i = 0; i < numSections; i++) {
            uint s = secOffset + (uint)(i * 40);
            uint vaddr = (uint)(pe[s+12] | (pe[s+13] << 8) | (pe[s+14] << 16) | (pe[s+15] << 24));
            uint vsize = (uint)(pe[s+8] | (pe[s+9] << 8) | (pe[s+10] << 16) | (pe[s+11] << 24));
            uint raw = (uint)(pe[s+20] | (pe[s+21] << 8) | (pe[s+22] << 16) | (pe[s+23] << 24));
            uint rawSize = (uint)(pe[s+16] | (pe[s+17] << 8) | (pe[s+18] << 16) | (pe[s+19] << 24));
            sections.Add(Tuple.Create(vaddr, vsize, raw, rawSize));
        }
        
        Func<uint, uint> manualFileOff = rva => {
            foreach (var sec in sections)
                if (rva >= sec.Item1 && rva < sec.Item1 + sec.Item2)
                    return sec.Item3 + (rva - sec.Item1);
            return 0;
        };
        
        Console.WriteLine("Sections:");
        foreach (var s in sections)
            Console.WriteLine("  V=0x{0:X8} VS=0x{1:X8} R=0x{2:X8} RS=0x{3:X8}", 
                s.Item1, s.Item2, s.Item3, s.Item4);
        
        // Collect all methods with RVA != 0, sorted by token
        var methods = new List<MethodDef>();
        int rvaZeroCount = 0;
        foreach (var t in mod.GetTypes())
            foreach (var m in t.Methods) {
                if (m.RVA == 0) { rvaZeroCount++; continue; }
                methods.Add(m);
            }
        
        methods.Sort((a, b) => a.MDToken.Raw.CompareTo(b.MDToken.Raw));
        Console.WriteLine("\nTotal non-zero RVA methods: {0}", methods.Count);
        
        // Compute body sizes from RVA gaps (for .zN| methods)
        var bodySizes = new Dictionary<int, int>();
        for (int i = 0; i < methods.Count; i++) {
            var m = methods[i];
            int token = (int)m.MDToken.Raw;
            uint rva = (uint)m.RVA;
            uint nextRva = rva + 256;
            for (int j = 0; j < methods.Count; j++) {
                uint mrva = (uint)methods[j].RVA;
                if (mrva > rva && mrva < nextRva) nextRva = mrva;
            }
            
            uint fileOff = (uint)peImg.ToFileOffset((RVA)rva);
            uint nextFileOff = (uint)peImg.ToFileOffset((RVA)nextRva);
            int bodySize = (int)(nextFileOff - fileOff);
            
            // For .text methods, fileOff and nextFileOff are 0, so bodySize = 0
            // Need manual offset for those
            if (bodySize <= 0 || bodySize > 0x100000) {
                // Use manual RVA-to-file-offset
                uint manOff = manualFileOff(rva);
                uint manNextOff = manualFileOff(nextRva);
                bodySize = (int)(manNextOff - manOff);
                if (bodySize <= 0 || bodySize > 0x100000) bodySize = 64; // guess
            }
            
            // Check if it's .zN| or .text
            bool isZnz = rva >= 0x19E000;
            
            // For .zN| methods, body size from RVA gap works (both file offsets are based on .zN| section)
            // For .text methods, we need the TRUE body size - compare with next .text method RVA
            
            bodySizes[token] = bodySize;
        }
        
        // Now compute cumulative body sizes by token order
        long cumulative = 0;
        uint znzSectionBase = 0x400; // raw offset of .zN| section
        uint znzRvaBase = 0x19E000;
        
        Console.WriteLine("\nCumulative body sizes (first 20 methods):");
        for (int i = 0; i < Math.Min(20, methods.Count); i++) {
            var m = methods[i];
            int token = (int)m.MDToken.Raw;
            uint rva = (uint)m.RVA;
            bool isZnz = rva >= 0x19E000;
            
            uint dnlibOff = toFileOff(rva);
            uint manOff = manualFileOff(rva);
            
            int bs = bodySizes[token];
            
            Console.WriteLine("  [{0}] token=0x{1:X8} RVA=0x{2:X8} dnlibOff=0x{3:X8} manOff=0x{4:X8} size={5} cum={6} {7}",
                i, token, rva, dnlibOff, manOff, bs, cumulative, isZnz ? ".zN|" : ".text");
            
            // If this is a .zN| method, its expected offset = znzSectionBase + (rva - znzRvaBase)
            if (isZnz) {
                uint expectedOff = znzSectionBase + (rva - znzRvaBase);
                Console.WriteLine("    Expected (from RVA): 0x{0:X8} diff={1}", 
                    expectedOff, cumulative - (long)expectedOff + znzSectionBase);
                // Actually just compare cumulative with expected
                long expectedCumulative = (long)(znzSectionBase + (rva - znzRvaBase));
                Console.WriteLine("    Expected cumulative: 0x{0:X8} actual cum: 0x{1:X8} diff={2}",
                    expectedCumulative, (long)znzSectionBase + cumulative, 
                    (long)znzSectionBase + cumulative - expectedCumulative);
            }
            
            // Get body size more accurately for this method
            // Try reading the actual body from .dec_xor if available
            string xorFile = dumpDir + token.ToString("X8") + ".dec_xor";
            if (File.Exists(xorFile)) {
                byte[] xorBody = File.ReadAllBytes(xorFile);
                // XOR-decrypt at the expected offset in the PE
                // First find the key offset
                // ...
            }
            
            cumulative += bs;
        }
        
        Console.WriteLine("\n\nLast 20 methods:");
        for (int i = Math.Max(0, methods.Count - 20); i < methods.Count; i++) {
            var m = methods[i];
            int token = (int)m.MDToken.Raw;
            uint rva = (uint)m.RVA;
            bool isZnz = rva >= 0x19E000;
            int bs = bodySizes[token];
            Console.WriteLine("  [{0}] token=0x{1:X8} RVA=0x{2:X8} size={3} {4}",
                i, token, rva, bs, isZnz ? ".zN|" : ".text");
        }
    }
}
