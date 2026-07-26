using System;
using System.IO;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.IO;
using dnlib.PE;

class Rebuild4 {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        string xordPath = @"C:\deobfuscate\SpiderBackup_xord.exe";
        string outPath = @"C:\deobfuscate\SpiderBackup_final.exe";
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        
        Console.WriteLine("Step 1: Find sections using dnlib...");
        byte[] pe = File.ReadAllBytes(path);
        
        var mod = ModuleDefMD.Load(path);
        IPEImage peImage = mod.Metadata.PEImage;
        
        // Find .zN| section by scanning sections
        var znzSection = default(ImageSectionHeader);
        bool foundZnz = false;
        uint znzRawOff = 0, znzRawSize = 0;
        foreach (var sec in peImage.ImageSectionHeaders) {
            uint vaddr = (uint)sec.VirtualAddress;
            uint vsize = (uint)sec.VirtualSize;
            uint rawOff = (uint)sec.PointerToRawData;
            uint rawSize = (uint)sec.SizeOfRawData;
            Console.WriteLine("  Section V=0x{0:X8} VS=0x{1:X8} R=0x{2:X8}+0x{3:X8}",
                vaddr, vsize, rawOff, rawSize);
            // The .zN| section is typically the largest data section
            // After the .text section, look for a large section
            // Use characteristics to identify: 0xE00000C0 = contains initialized data + readable
            if (rawSize > 0x100000 && rawOff > 0) {
                znzRawOff = rawOff;
                znzRawSize = rawSize;
                foundZnz = true;
            }
        }
        
        if (!foundZnz) {
            Console.WriteLine("  Could not find .zN| section, trying hardcoded values...");
            znzRawOff = 0x400;
            znzRawSize = 0x306000;
        }
        Console.WriteLine("  Using .zN|: R=0x{0:X8}+0x{1:X8}", znzRawOff, znzRawSize);
        
        // Load the XOR key
        int refToken = 0x06000497;
        string refFile = dumpDir + refToken.ToString("X8") + ".dec_xor";
        byte[] xorKey = File.ReadAllBytes(refFile);
        
        // Derive reference file offset and section offset
        uint refRva = 0;
        foreach (var t in mod.GetTypes())
            foreach (var m in t.Methods)
                if ((int)m.MDToken.Raw == refToken) refRva = (uint)m.RVA;
        uint refRawOff = (uint)peImage.ToFileOffset((RVA)refRva);
        int refSecOff = (int)(refRawOff - znzRawOff);
        Console.WriteLine("  Reference: RVA=0x{0:X8} fileOff=0x{1:X8} secOff=0x{2:X8}",
            refRva, refRawOff, refSecOff);
        
        // XOR-decrypt the entire .zN| section
        int secLen = (int)Math.Min(znzRawSize, pe.Length - znzRawOff);
        if (secLen <= 0 || secLen > 0x400000) {
            Console.WriteLine("  Invalid section size {0}, aborting", secLen);
            return;
        }
        Console.WriteLine("  XOR-decrypting {0} bytes at file offset 0x{1:X8}...", secLen, znzRawOff);
        for (int i = 0; i < secLen; i++) {
            int keyIdx = (i - refSecOff) % xorKey.Length;
            if (keyIdx < 0) keyIdx += xorKey.Length;
            pe[znzRawOff + i] ^= xorKey[keyIdx];
        }
        
        File.WriteAllBytes(xordPath, pe);
        Console.WriteLine("  Written to {0}", xordPath);
        
        Console.WriteLine("\nStep 2: Load XOR-decrypted PE and stub anti-tamper cctors...");
        var mod2 = ModuleDefMD.Load(xordPath);
        
        int stubbed = 0;
        foreach (var type in mod2.GetTypes()) {
            foreach (var method in type.Methods) {
                if (method.RVA == 0) continue;
                // Stub all .cctors in .zN| section (they're anti-tamper infrastructure)
                if (method.Name == ".cctor" && (uint)method.RVA >= 0x19E000) {
                    var stub = new CilBody();
                    stub.Instructions.Add(Instruction.Create(OpCodes.Ret));
                    stub.KeepOldMaxStack = true;
                    method.Body = stub;
                    stubbed++;
                    Console.WriteLine("  Stubbed {0}.{1}.{2}{3}", 
                        method.DeclaringType.Name, type.Name, method.Name, method is MethodDef ? "" : "");
                }
            }
        }
        Console.WriteLine("  Stubbed {0} cctors", stubbed);
        
        Console.WriteLine("Saving to {0}...", outPath);
        mod2.Write(outPath);
        Console.WriteLine("Done!");
    }
}
