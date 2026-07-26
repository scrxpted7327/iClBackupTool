using System;
using System.Runtime.InteropServices;

class Test
{
    [DllImport("kernel32.dll", SetLastError = true)]
    static extern IntPtr LoadLibraryEx(string lpFileName, IntPtr hFile, uint dwFlags);

    const uint LOAD_LIBRARY_AS_IMAGE_RESOURCE = 0x20;

    static void Main()
    {
        string path = @"C:\deobfuscate\SpiderBackup.exe";
        IntPtr hMod = LoadLibraryEx(path, IntPtr.Zero, LOAD_LIBRARY_AS_IMAGE_RESOURCE);
        Console.WriteLine("hMod: 0x" + hMod.ToInt64().ToString("X16"));
        
        long aligned = hMod.ToInt64() & ~3;
        Console.WriteLine("Aligned: 0x" + aligned.ToString("X16"));
        
        // Check MZ at hMod
        byte[] buf = new byte[4];
        Marshal.Copy(hMod, buf, 0, 4);
        Console.WriteLine("hMod+0: " + buf[0].ToString("X2") + " " + buf[1].ToString("X2") + " " + buf[2].ToString("X2") + " " + buf[3].ToString("X2"));
        
        // Check MZ at aligned
        Marshal.Copy(new IntPtr(aligned), buf, 0, 4);
        Console.WriteLine("aligned+0: " + buf[0].ToString("X2") + " " + buf[1].ToString("X2") + " " + buf[2].ToString("X2") + " " + buf[3].ToString("X2"));
        
        // Check MZ at hMod-2
        Marshal.Copy(new IntPtr(hMod.ToInt64() - 2), buf, 0, 4);
        Console.WriteLine("hMod-2: " + buf[0].ToString("X2") + " " + buf[1].ToString("X2") + " " + buf[2].ToString("X2") + " " + buf[3].ToString("X2"));
        
        // Try other offsets
        for (int delta = -16; delta <= 16; delta++)
        {
            try
            {
                Marshal.Copy(new IntPtr(hMod.ToInt64() + delta), buf, 0, 2);
                if (buf[0] == 0x4D && buf[1] == 0x5A)
                {
                    Console.WriteLine("MZ found at hMod " + (delta >= 0 ? "+" : "") + delta);
                }
            }
            catch { }
        }
    }
}
