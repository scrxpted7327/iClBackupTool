using System;
using System.Runtime.InteropServices;

internal sealed class _2ABF5C56
{
	private enum _4ADB03C8
	{
		_6446604E = 3,
		_1F990E43 = 2,
		_289622D8 = 1,
		_23CF2F67 = 5,
		_081956C7 = 4,
		_3EDF2EE3 = 6,
		_37E35BED = 8,
		_14201A3E = 9,
		_68B15422 = 7
	}

	private struct _7D2634C9
	{
		[MarshalAs(UnmanagedType.I4)]
		public _4ADB03C8 _61E00B24;

		public int _0FD05894;

		public int _3161275C;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
		public byte[] _373A195F;
	}

	[DllImport("kernel32.dll", EntryPoint = "CheckRemoteDebuggerPresent", ExactSpelling = true, SetLastError = true)]
	private static extern bool _636C5E00(IntPtr _4E4F00C8, ref bool _2E746CDD);

	[DllImport("kernel32.dll", EntryPoint = "GetModuleHandle", SetLastError = true)]
	private static extern IntPtr _1B200BDB(string _5746734D);

	[DllImport("kernel32.dll", EntryPoint = "GetProcAddress", SetLastError = true)]
	private static extern IntPtr _75462A63(IntPtr _68E658BB, string _4E4A39A8);

	[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory", SetLastError = true)]
	private static extern bool _0A623212(IntPtr _01E37EE0, IntPtr _68CC2295, byte[] _7FFF331C, uint _34A52899, int _47820D2A);

	[DllImport("kernel32.dll", EntryPoint = "IsProcessCritical", SetLastError = true)]
	private static extern bool _52E61BF1(IntPtr _5CFD334E, ref bool _266A549B);

	public static string _24AC6B97()
	{
	//Invalid MethodBodyBlock: Invalid relative virtual address (RVA): 0x000020F4
	}

	public static string _0D6F3652()
	{
	//Invalid MethodBodyBlock: Invalid relative virtual address (RVA): 0x000021A4
	}

	public static string _79D57875()
	{
	//Invalid MethodBodyBlock: Invalid relative virtual address (RVA): 0x00002254
	}

	public static void _560C5214(string _366C02FB)
	{
	//Invalid MethodBodyBlock: Invalid relative virtual address (RVA): 0x000022F4
	}

	internal void _7C064EBF()
	{
	//Invalid MethodBodyBlock: Invalid relative virtual address (RVA): 0x0000235C
	}

	private void _24D637FB(string _61B36910)
	{
	//Invalid MethodBodyBlock: Invalid relative virtual address (RVA): 0x00002810
	}

	public void _7DC03082()
	{
	//Invalid MethodBodyBlock: Invalid relative virtual address (RVA): 0x00002884
	}

	private static void _46F80698()
	{
	//Invalid MethodBodyBlock: Invalid relative virtual address (RVA): 0x000028C4
	}

	private static void _51215DF8()
	{
	//Invalid MethodBodyBlock: Invalid relative virtual address (RVA): 0x00002918
	}

	private static void _1810161D()
	{
	//Invalid MethodBodyBlock: Invalid relative virtual address (RVA): 0x00002C94
	}

	private static void _6C6337FE()
	{
	//Invalid MethodBodyBlock: Invalid relative virtual address (RVA): 0x00002DB0
	}

	public static void _6AD94E70()
	{
	//Invalid MethodBodyBlock: Invalid relative virtual address (RVA): 0x00002EB4
	}

	private static void _37A566C8(object _56607A68)
	{
	//Invalid MethodBodyBlock: Invalid relative virtual address (RVA): 0x00002F88
	}

	public static void _6508237E(int _27D57AAC)
	{
	//Invalid MethodBodyBlock: Invalid relative virtual address (RVA): 0x00003030
	}

	private static void _67EE58D4()
	{
	//Invalid MethodBodyBlock: Invalid relative virtual address (RVA): 0x00003198
	}

	private static void _52732BD2(object _39BF3AF1)
	{
	//Invalid MethodBodyBlock: Invalid relative virtual address (RVA): 0x000031F9
	}

	[DllImport("Kernel32.dll", EntryPoint = "DebugActiveProcess", SetLastError = true)]
	private static extern bool _0B6F2E1C(int _0C8F26C9);

	[DllImport("Kernel32.dll", EntryPoint = "WaitForDebugEvent", SetLastError = true)]
	private static extern bool _33780566(out _7D2634C9 _3ECD46D8, int _71E34CEA);

	[DllImport("Kernel32.dll", EntryPoint = "ContinueDebugEvent", SetLastError = true)]
	private static extern bool _2B086390(int _764F1DE0, int _02622FF1, int _0FF10817);

	[DllImport("Kernel32.dll", EntryPoint = "IsDebuggerPresent", SetLastError = true)]
	public static extern bool _0A9D7CB9();
}
