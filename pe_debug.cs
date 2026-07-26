using System;
using System.IO;
using System.Linq;
using dnlib.DotNet;

class PEDebug {
    static void Main() {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        string dumpDir = @"C:\deobfuscate\methods_dump\";
        byte[] pe = File.ReadAllBytes(path);
        var dn = ModuleDefMD.Load(pe);

        // Derive key from .zN| method using existing .dec_xor file (skip padded bytes)
        byte[] key = null;
        int keyLen = 0;
        foreach (var pair in DeriveKeyFromFiles(dn, pe, dumpDir)) {
            int len = pair.Item3;
            if (len > keyLen) {
                key = new byte[len];
                keyLen = len;
                Array.Copy(pair.Item1, key, len);
            }
        }
        Console.WriteLine("Derived key length: {0}", keyLen);
        if (key == null) return;

        // Now decrypt the entire early block (0x400 to 0x69AD4) with continuous key
        uint earlyStart = 0x400;
        uint earlyEnd = 0x69AD4; // first .zN| method start
        uint blockLen = earlyEnd - earlyStart;
        byte[] decBlock = new byte[blockLen];
        for (uint i = 0; i < blockLen; i++)
            decBlock[i] = (byte)(pe[earlyStart + i] ^ key[i % keyLen]);

        // Scan for valid method headers
        Console.WriteLine("\nScanning for valid headers in early block...");
        int validHeaders = 0;
        for (uint p = 0; p < blockLen - 1; p++) {
            byte h = decBlock[p];
            if ((h & 3) == 2) {
                int sz = 1 + (h >> 2);
                if (sz > 0 && p + sz <= blockLen) {
                    validHeaders++;
                    if (validHeaders <= 1 || (p < 500))
                        Console.WriteLine("  tiny at +0x{0:X6}: size={1}", p, sz);
                    p += (uint)sz - 1;
                }
            } else if ((h & 3) == 3 && p + 12 <= blockLen) {
                int cs = decBlock[p+4] | (decBlock[p+5]<<8) | (decBlock[p+6]<<16) | (decBlock[p+7]<<24);
                int sz = 12 + cs;
                if (cs > 0 && cs < 20000 && sz > 0 && p + sz <= blockLen) {
                    validHeaders++;
                    if (validHeaders <= 1 || p < 500)
                        Console.WriteLine("  fat at +0x{0:X6}: codeSz={1}, total={2}", p, cs, sz);
                    p += (uint)sz - 1;
                }
            }
        }
        Console.WriteLine("Total valid headers: {0} (expected 154)", validHeaders);
    }

    static System.Tuple<byte[], int, int>[] DeriveKeyFromFiles(ModuleDefMD dn, byte[] pe, string dumpDir) {
        var result = new System.Collections.Generic.List<System.Tuple<byte[], int, int>>();
        foreach (var t in dn.GetTypes())
            foreach (var m in t.Methods) {
                int token = (int)m.MDToken.Raw;
                uint rva = (uint)m.RVA;
                if (rva < 0x19E000) continue; // only .zN| methods
                string fp = dumpDir + token.ToString("X8") + ".dec_xor";
                if (!File.Exists(fp)) continue;
                byte[] dec = File.ReadAllBytes(fp);
                uint fileOff = 0x400 + (rva - 0x19E000);
                if (fileOff + dec.Length > pe.Length) continue;
                byte[] enc = new byte[dec.Length];
                Array.Copy(pe, fileOff, enc, 0, dec.Length);

                // Find the TRUE method body size by checking the header
                int trueSz = 0;
                byte h = (byte)(enc[0] ^ dec[0]);
                if ((h & 3) == 2) {
                    trueSz = 1 + (h >> 2);
                } else if ((h & 3) == 3) {
                    int cs = dec[4] | (dec[5]<<8) | (dec[6]<<16) | (dec[7]<<24);
                    if (cs > 0 && cs < 50000) trueSz = 12 + cs;
                }
                if (trueSz <= 0 || trueSz > dec.Length) continue;

                byte[] key = new byte[trueSz];
                for (int i = 0; i < trueSz; i++)
                    key[i] = (byte)(enc[i] ^ dec[i]);
                result.Add(System.Tuple.Create(key, token, trueSz));
            }
        return result.ToArray();
    }
}
