using System;
using System.IO;

class Program {
    static void Main() {
        byte[] pe = File.ReadAllBytes("SpiderBackup.exe");
        uint e_lfanew = (uint)(pe[0x3C] | (pe[0x3D] << 8) | (pe[0x3E] << 16) | (pe[0x3F] << 24));
        ushort ns = (ushort)(pe[e_lfanew + 6] | (pe[e_lfanew + 7] << 8));
        ushort opt = (ushort)(pe[e_lfanew + 20] | (pe[e_lfanew + 21] << 8));
        uint so = e_lfanew + 24 + opt;
        Console.WriteLine("e_lfanew=0x{0:X} sections={1} optSize={2}", e_lfanew, ns, opt);
        for (int i = 0; i < ns; i++) {
            uint s = so + (uint)i * 40;
            string n = System.Text.Encoding.ASCII.GetString(pe, (int)s, 8).TrimEnd((char)0);
            uint va = BitConverter.ToUInt32(pe, (int)s + 12);
            uint vs = BitConverter.ToUInt32(pe, (int)s + 8);
            uint ra = BitConverter.ToUInt32(pe, (int)s + 20);
            uint rs = BitConverter.ToUInt32(pe, (int)s + 16);
            Console.WriteLine("  {0}: VA=0x{1:X} VSize=0x{2:X} Raw=0x{3:X} RawSize=0x{4:X}", n, va, vs, ra, rs);
        }
    }
}
