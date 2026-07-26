using System;
using System.IO;
using System.Linq;
using dnlib.DotNet;

class Patcher
{
    static void Main(string[] args)
    {
        string path = args.Length > 0 ? args[0] : @"C:\deobfuscate\SpiderBackup.exe";
        
        byte[] peBytes = File.ReadAllBytes(path);
        ModuleDefMD module = ModuleDefMD.Load(peBytes);
        
        // Find the bytecode reader cctor and get its RVA
        MethodDef bcCctor = null;
        
        foreach (var t in module.Types)
        {
            if (!t.Name.Contains("78492021")) continue;
            foreach (var nt in t.NestedTypes)
            {
                if (!nt.Name.Contains("6D2115ED")) continue;
                foreach (var m in nt.Methods)
                {
                    if (m.IsStatic && m.IsConstructor && !m.IsInstanceConstructor)
                    {
                        bcCctor = m;
                        break;
                    }
                }
                if (bcCctor != null) break;
            }
            if (bcCctor != null) break;
        }
        
        if (bcCctor == null) { Console.WriteLine("cctor not found"); return; }
        
        uint rva = (uint)bcCctor.RVA;
        Console.WriteLine("cctor RVA: 0x" + rva.ToString("X"));
        
        // Compute file offset: .zN| at vaddr=0x19E000, raw=0x400
        uint fileOffset = (rva >= 0x19E000) ? (0x400 + (rva - 0x19E000)) : rva;
        Console.WriteLine("File offset: 0x" + fileOffset.ToString("X"));
        
        // Read the method body header
        byte hdr = peBytes[fileOffset];
        int codeSize;
        int headerSize;
        
        if ((hdr & 3) == 2) // Tiny
        {
            codeSize = hdr >> 2;
            headerSize = 1;
            Console.WriteLine("Tiny header, code size: " + codeSize);
        }
        else if ((hdr & 3) == 3) // Fat
        {
            // First 4 bytes: flags (low 12 bits) + size in 4-byte units (high 4 bits)
            uint fatHeader = (uint)(peBytes[fileOffset] | (peBytes[fileOffset+1] << 8) | (peBytes[fileOffset+2] << 16) | (peBytes[fileOffset+3] << 24));
            int fatSize = (int)(fatHeader >> 12) * 4; // size in bytes
            codeSize = (int)(peBytes[fileOffset+4] | (peBytes[fileOffset+5] << 8) | (peBytes[fileOffset+6] << 16) | (peBytes[fileOffset+7] << 24));
            headerSize = fatSize;
            Console.WriteLine("Fat header, header size: " + headerSize + ", code size: " + codeSize);
        }
        else
        {
            Console.WriteLine("Unknown header type: " + (hdr & 3));
            return;
        }
        
        int totalBodySize = headerSize + codeSize;
        Console.WriteLine("Total body size: " + totalBodySize + " bytes");
        Console.WriteLine("Original first 16 bytes: " + BitConverter.ToString(peBytes, (int)fileOffset, Math.Min(16, totalBodySize)));
        
        // Patch: replace with tiny ret (0x06 = header, 0x2A = ret)
        // Note: we only need to change the first 2 bytes. The rest can be zeros
        // The CLR reads the header, determines code_size=1, reads 1 byte (ret), done
        peBytes[fileOffset] = 0x06; // tiny header, size=1
        peBytes[fileOffset + 1] = 0x2A; // ret
        
        // Zero out remaining body (optional, for cleanliness)
        for (int i = 2; i < totalBodySize && fileOffset + i < peBytes.Length; i++)
            peBytes[fileOffset + i] = 0;
        
        Console.WriteLine("Patched body at file offset 0x" + fileOffset.ToString("X") + " with tiny ret");
        
        // Save patched PE
        string outPath = path.Replace(".exe", "_patched.exe");
        File.WriteAllBytes(outPath, peBytes);
        Console.WriteLine("Written to: " + outPath);
        Console.WriteLine("File size: " + peBytes.Length + " bytes");
    }
}
