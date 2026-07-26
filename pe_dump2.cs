using System;
using System.IO;
using System.Linq;
using dnlib.DotNet;

class PEDump2 {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        byte[] peBytes = File.ReadAllBytes(path);

        var dnMod = ModuleDefMD.Load(peBytes);

        // Get first .zN| method (by token, same as sequential order)
        var zMethods = dnMod.GetTypes().SelectMany(t => t.Methods)
            .Where(m => (uint)m.RVA >= 0x19E000).OrderBy(m => (int)m.MDToken.Raw).ToList();

        // Find key from first .zN| method
        byte[] xorKey = null;
        foreach (var m in zMethods) {
            int token = (int)m.MDToken.Raw;
            string decPath = dumpDir + token.ToString("X8") + ".dec_xor";
            if (File.Exists(decPath)) {
                byte[] dec = File.ReadAllBytes(decPath);
                uint rva = (uint)m.RVA;
                uint fileOff = 0x400 + (rva - 0x19E000);
                if (fileOff + dec.Length > peBytes.Length) continue;
                xorKey = new byte[dec.Length];
                for (int i = 0; i < dec.Length; i++)
                    xorKey[i] = (byte)(peBytes[fileOff + i] ^ dec[i]);
                Console.WriteLine("Derived key from token 0x{0:X8} RVA=0x{1:X6} off=0x{2:X6}, len={3}",
                    token, rva, fileOff, dec.Length);
                break;
            }
        }
        if (xorKey == null) { Console.WriteLine("No key"); return; }
        Console.WriteLine("xorKey[0] = 0x{0:X2}", xorKey[0]);

        // Check: what would byte 0 at 0x400 decrypt to?
        byte hdr0 = (byte)(peBytes[0x400] ^ xorKey[0]);
        Console.WriteLine("Byte at 0x400 XOR key[0] = 0x{0:X2} (flags={1})", hdr0, hdr0 & 3);

        // Check: what would the CORRECT first early method be?
        // Get .text methods sorted by token
        var textMethods = dnMod.GetTypes().SelectMany(t => t.Methods)
            .Where(m => (uint)m.RVA < 0xBE000 && (uint)m.RVA > 0)
            .OrderBy(m => (int)m.MDToken.Raw).ToList();
        Console.WriteLine("\n=== .text methods ordered by token ===");
        Console.WriteLine("Idx\tToken\t\tRVA\t\texpected_size\tFound .dec_xor?");
        uint currOff = 0x400;
        foreach (var m in textMethods) {
            int token = (int)m.MDToken.Raw;
            string decPath = dumpDir + token.ToString("X8") + ".dec_xor";
            int expectedSize = File.Exists(decPath) ? File.ReadAllBytes(decPath).Length : -1;
            string hasFile = File.Exists(decPath) ? "YES" : "no";
            uint rva = (uint)m.RVA;
            Console.WriteLine("{0}\t0x{1:X8}\t0x{2:X6}\t{3}\t{4}",
                textMethods.IndexOf(m), token, rva, expectedSize, hasFile);
            if (currOff + 1 < peBytes.Length) {
                byte hdr = (byte)(peBytes[currOff] ^ xorKey[0]);
                bool valid = (hdr & 3) == 2 || (hdr & 3) == 3;
                if (!valid) {
                    Console.WriteLine("  -> INVALID header 0x{0:X2} at offset 0x{1:X6}", hdr, currOff);
                    // Try to scan forward for a valid header
                    for (uint d = 0; d < 1000 && currOff + d < peBytes.Length; d++) {
                        byte th = (byte)(peBytes[currOff + d] ^ xorKey[0]);
                        if ((th & 3) == 2 || (th & 3) == 3) {
                            Console.WriteLine("  -> Valid header found at +{0} bytes (0x{1:X6})", d, currOff + d);
                            uint sz = (th & 3) == 2 ? (uint)(1 + (th >> 2)) : 12 + 100; // approx
                            Console.WriteLine("  -> Would skip {0} bytes, next offset 0x{1:X6}", d, currOff + d);
                            break;
                        }
                    }
                } else if ((hdr & 3) == 2) {
                    int sz = 1 + (hdr >> 2);
                    Console.WriteLine("  -> tiny: size={0}, next off=0x{1:X6}", sz, currOff + (uint)sz);
                } else {
                    // fat: decrypt header to get size
                    int hdrBytes = Math.Min(12, (int)(peBytes.Length - currOff));
                    byte[] hdrBuf = new byte[hdrBytes];
                    for (int i = 0; i < hdrBytes; i++)
                        hdrBuf[i] = (byte)(peBytes[currOff + i] ^ xorKey[i]);
                    int codeSize = hdrBuf[4] | (hdrBuf[5] << 8) | (hdrBuf[6] << 16) | (hdrBuf[7] << 24);
                    int sz = 12 + codeSize;
                    Console.WriteLine("  -> fat: hdrFlags=0x{0:X4} codeSize={1}, total={2}, next=0x{3:X6}",
                        hdrBuf[0] | (hdrBuf[1] << 8), codeSize, sz, currOff + (uint)sz);
                    if (expectedSize > 0 && sz != expectedSize)
                        Console.WriteLine("  *** SIZE MISMATCH: header says {0}, .dec_xor says {1}", sz, expectedSize);
                }
                // Advance to next method using header-derived size
                byte curHdr = (byte)(peBytes[currOff] ^ xorKey[0]);
                if ((curHdr & 3) == 2) {
                    currOff += (uint)(1 + (curHdr >> 2));
                } else if ((curHdr & 3) == 3) {
                    int hdrB = Math.Min(12, (int)(peBytes.Length - currOff));
                    byte[] hB = new byte[hdrB];
                    for (int i = 0; i < hdrB; i++)
                        hB[i] = (byte)(peBytes[currOff + i] ^ xorKey[i]);
                    int cSz = hB[4] | (hB[5] << 8) | (hB[6] << 16) | (hB[7] << 24);
                    currOff += (uint)(12 + cSz);
                } else {
                    currOff += 1; // skip one byte
                }
            }
        }
    }
}
