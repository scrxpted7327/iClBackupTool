using System;
using System.IO;
class CheckXor {
    static void Main() {
        string[] tokens = {"0600043A", "06000497", "0600073E"};
        foreach (var t in tokens) {
            string p = @"C:\deobfuscate\methods_dump\" + t + ".dec_xor";
            byte[] b = File.ReadAllBytes(p);
            Console.WriteLine("{0}: {1} bytes, first bytes: {2:X2} {3:X2} {4:X2}", t, b.Length, b[0], b[1], b[2]);
        }
    }
}
