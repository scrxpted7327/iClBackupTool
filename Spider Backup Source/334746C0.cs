using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

internal static class _334746C0
{
	public enum _139B1BEF : uint
	{
		_77C6138C = 8192u,
		_057A435B = 4096u
	}

	public enum _0F4838B4 : uint
	{
		_646C7010 = 0x8000u
	}

	public enum _76867876 : uint
	{
		_43CD5B05 = 64u,
		_3ABF555D = 32u,
		_1A520675 = 256u,
		_64B726DB = 8u,
		_3AE05BF0 = 4u,
		_5C14019F = 2u,
		_6F4A5AD3 = 16u,
		_4C4C2690 = 1u
	}

	public enum _798253AF : uint
	{
		_6AEB46D7 = 2u,
		_10C84FC8 = 1u,
		_5A824893 = 4u,
		_634F753D = 8u
	}

	public struct _6A0E4BE3
	{
		public readonly ushort _26417743;

		public readonly ushort _4EC344A0;

		private readonly IntPtr _1A202FC7;

		public unsafe void _3DCE2E66()
		{
			//IL_0013: Expected O, but got Ref
			new _78492021()._4927337F(new object[1] { (object)Unsafe.AsPointer(ref this) }, 2122469);
		}

		public unsafe _6A0E4BE3(string _6EAA43BC)
		{
			//IL_0013: Expected O, but got Ref
			new _78492021()._4927337F(new object[2]
			{
				(object)Unsafe.AsPointer(ref this),
				_6EAA43BC
			}, 2122178);
		}
	}

	public struct _19FB54BA
	{
		public readonly uint _3A0B5085;

		public readonly IntPtr _68775CEF;

		public readonly IntPtr _1F503AC5;

		public readonly uint _3ACC14F5;

		public readonly IntPtr _436C5E20;

		public readonly IntPtr _44E9304B;

		public unsafe void _07157D0D()
		{
			//IL_0013: Expected O, but got Ref
			new _78492021()._4927337F(new object[1] { (object)Unsafe.AsPointer(ref this) }, 2122917);
		}

		public unsafe _19FB54BA(_6A0E4BE3 _6F92695A, uint _48D835D3)
		{
			//IL_0013: Expected O, but got Ref
			new _78492021()._4927337F(new object[3]
			{
				(object)Unsafe.AsPointer(ref this),
				_6F92695A,
				_48D835D3
			}, 2122625);
		}
	}

	public struct _23085FDD
	{
		public uint _019F3B27;

		public IntPtr _0E323D97;
	}

	public struct _6AA5531B
	{
		public uint _7F842C5A;

		public uint _653676FD;
	}

	public struct _66B65656
	{
		public uint _5D44258D;

		public uint _31841C9C;

		public uint _360A0290;

		public uint _17C0585B;
	}

	public struct _47A870F9
	{
		public byte _04B7290E;

		public byte _23F60EE5;
	}

	public struct _070D072A
	{
		public uint _40D601B6;

		public uint _6E2D41F2;

		public uint _47D20C99;

		public uint _6D4067C9;

		public uint _666614D3;

		public uint _6BE95C02;

		public IntPtr _1656476E;

		public IntPtr _541F4D91;

		public IntPtr _445D3183;

		public IntPtr _44A24E00;

		public byte _326669A2;
	}

	public enum _2B2D7D92
	{
		_24D465FC = 3,
		_49FF6874 = 1,
		_2ACA5313 = 8,
		_730A549F = 4,
		_07A352BC = 7,
		_42B545EA = 6,
		_2E181E98 = 2,
		_16AD43A2 = 5,
		_67557DF7 = 0
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint _5CA628D0(IntPtr _44405362, _2DA17C01 _46EB29F6, IntPtr _268D6391, uint _686069D4, out uint _2B837343);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint _15E31101(_2A8601C1 _30EE4939, IntPtr _7D9F5988, uint _47B06FFD, out uint _757425E5);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint _071C1981(IntPtr _6CF5096F, _6F036396 _0FFE19C9, IntPtr _4FB37106, uint _4D091D76);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint _2CA8530B(IntPtr _1CA95EAD);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint _6D074DC5(IntPtr _102125E4, ref IntPtr _3D134E11, ref UIntPtr _37A704A2, _76867876 _222C170F, out _76867876 _7F11257D);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint _5DD660BF(IntPtr _576637BA, ref IntPtr _58E26DF2, IntPtr _485B22BF, ref UIntPtr _73654BEE, _139B1BEF _65136AD7, _76867876 _79A771D0);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint _54523F39(IntPtr _17074EE7, ref IntPtr _39AA5F2A, ref UIntPtr _26812D6A, _0F4838B4 _34987342);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint _375C1C91(IntPtr _61F27F5F, IntPtr _66F74405);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint _564B1A24(IntPtr _1D4520C3, IntPtr _03367E8B, out IntPtr _28330D31, UIntPtr _59835F19, UIntPtr _39652945, _6AA5531B _5D8D7469, ref UIntPtr _166737A8, uint _4D663217, uint _1AF4417B, _76867876 _78BF27DF);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint _7BFC36F7(uint _5766451D, uint _1D951A44, uint _1124282A, IntPtr[] _68D46B91, uint _535B5166, out _2B2D7D92 _66BF293D);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint _1B682FDB(out IntPtr _0FD76E47, uint _449C6FA2, ref _19FB54BA _1BB42A82, out _23085FDD _35BB5B16, uint _0C1E732C, uint _7740083C);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint _12311293(out IntPtr _2EDB0E2C, uint _74B91C05, ref _19FB54BA _1BF9667F, ref _6AA5531B _63F95FD8, _76867876 _2D076A04, uint _50A1627B, IntPtr _40887D7F);

	public struct _2FB75F28
	{
		public IntPtr _708F023C;

		public IntPtr _2A07109E;

		public IntPtr _25A0243B;

		public IntPtr _67B736C8;

		public IntPtr _36BD0255;

		public IntPtr _44563A6A;
	}

	public enum _2DA17C01
	{
		_64953ED1 = 30,
		_6C191DBB = 7,
		_54152833 = 0
	}

	public enum _2A8601C1
	{
		_7B8732F4 = 35,
		_57242F1B = 76,
		_2DD06154 = 0
	}

	public enum _6F036396
	{
		_2D91736B = 17
	}

	private static _54523F39 _3B5A1F3E;

	private static _1B682FDB _2E9B74D5;

	private static _7BFC36F7 _14E62D66;

	public static readonly IntPtr _4701294D;

	private static _6D074DC5 _2BC04453;

	private static IntPtr _07041529;

	private static _15E31101 _35C349C9;

	private static _564B1A24 _67690FE6;

	private static _2CA8530B _270631D0;

	public static readonly IntPtr _5B261372;

	private static _071C1981 _5952585A;

	private static _5DD660BF _527802EC;

	private static _12311293 _47D91E27;

	private static _5CA628D0 _74304EAB;

	private static _375C1C91 _33244CE6;

	public static readonly IntPtr _014D1983;

	public static IntPtr _4D3A7772(IntPtr _0F8F430A, IntPtr _39176E66, _76867876 _6D4224C2, uint _70B84968, uint _0DCF08A7, string _65A73500)
	{
		return (IntPtr)new _78492021()._4927337F(new object[6] { _0F8F430A, _39176E66, _6D4224C2, _70B84968, _0DCF08A7, _65A73500 }, 2126472);
	}

	public static bool _18430DCF(IntPtr _671636E8, UIntPtr _01E76B79, _76867876 _214671C4, out _76867876 _0E4A23A7)
	{
		object[] array = new object[4] { _671636E8, _01E76B79, _214671C4, _0E4A23A7 };
		try
		{
			return (bool)new _78492021()._4927337F(array, 2125919);
		}
		finally
		{
			_0E4A23A7 = (_76867876)array[3];
		}
	}

	public static bool _41DE518C(IntPtr _23F51E4D, UIntPtr _482C1FCA, _0F4838B4 _79706A6C)
	{
		return (bool)new _78492021()._4927337F(new object[3] { _23F51E4D, _482C1FCA, _79706A6C }, 2126304);
	}

	public static IntPtr _21206FF6(IntPtr _7F6023B6, _798253AF _7C4F1426, uint _506B1631, uint _034D361D, ref UIntPtr _4EF0519D)
	{
		object[] array = new object[5] { _7F6023B6, _7C4F1426, _506B1631, _034D361D, _4EF0519D };
		try
		{
			return (IntPtr)new _78492021()._4927337F(array, 2123037);
		}
		finally
		{
			_4EF0519D = (UIntPtr)array[4];
		}
	}

	public static uint _5E7206F7(IntPtr _7F573D5A, _6F036396 _346C67D7, IntPtr _3FE36C49, uint _67245D5E)
	{
		return (uint)new _78492021()._4927337F(new object[4] { _7F573D5A, _346C67D7, _3FE36C49, _67245D5E }, 2730608);
	}

	public static IntPtr _62AA7C3E(string _51830F05, uint _6D5B1FB8, uint _2ABA44D6)
	{
		return (IntPtr)new _78492021()._4927337F(new object[3] { _51830F05, _6D5B1FB8, _2ABA44D6 }, 2732239);
	}

	private static uint _64261E76(_2A8601C1 _20C73B11, out object _1B0E02F9, uint _36461326, out uint _305E349F)
	{
		object[] array = new object[4] { _20C73B11, _1B0E02F9, _36461326, _305E349F };
		try
		{
			return (uint)new _78492021()._4927337F(array, 2730106);
		}
		finally
		{
			_1B0E02F9 = array[1];
			_305E349F = (uint)array[3];
		}
	}

	public static bool _29A26936(IntPtr _6DCE2361)
	{
		return (bool)new _78492021()._4927337F(new object[1] { _6DCE2361 }, 2123795);
	}

	internal static IntPtr _18E049A0(IntPtr _06761C37, object _7EA20A45)
	{
		return (IntPtr)new _78492021()._4927337F(new object[2] { _06761C37, _7EA20A45 }, 2725923);
	}

	public static uint _175570C6(IntPtr _34E159F0, _2DA17C01 _13CC640D, out object _4EFE3B7A, uint _6CC73890, out uint _2A57390D)
	{
		object[] array = new object[5] { _34E159F0, _13CC640D, _4EFE3B7A, _6CC73890, _2A57390D };
		try
		{
			return (uint)new _78492021()._4927337F(array, 2729515);
		}
		finally
		{
			_4EFE3B7A = array[2];
			_2A57390D = (uint)array[4];
		}
	}

	[DllImport("kernel32", EntryPoint = "GetVolumeInformation", SetLastError = true)]
	public static extern bool _35786A42(string _767C0068, StringBuilder _5F2D43AD, uint _70700553, ref uint _375848AC, ref uint _723B21D9, ref uint _7F4E0E70, StringBuilder _653C2430, uint _6D814E77);

	internal static IntPtr _217120B4(uint _468B585C)
	{
		return (IntPtr)new _78492021()._4927337F(new object[1] { _468B585C }, 2725354);
	}

	public static byte[] _042806FF(uint _13EE3097)
	{
		return (byte[])(Array)new _78492021()._4927337F(new object[1] { _13EE3097 }, 2730758);
	}

	public static IntPtr _4416146D(IntPtr _452F7D9A, UIntPtr _0FF20B8B, _139B1BEF _10912AFF, _76867876 _6C600EAB)
	{
		return (IntPtr)new _78492021()._4927337F(new object[4] { _452F7D9A, _0FF20B8B, _10912AFF, _6C600EAB }, 2126082);
	}

	public static bool _433E7339()
	{
		return (bool)new _78492021()._4927337F(null, 2124558);
	}

	public static bool _1A307C03()
	{
		return (bool)new _78492021()._4927337F(null, 2123899);
	}

	public static byte[] _20142E35(uint _6B31675D, uint _69D238FB)
	{
		return (byte[])(Array)new _78492021()._4927337F(new object[2] { _6B31675D, _69D238FB }, 2731437);
	}

	public static void _50051472(string _55987866, string _213C4167, _219504AE _658E2D14, _38406A92 _34C7544D)
	{
		new _78492021()._4927337F(new object[4] { _55987866, _213C4167, _658E2D14, _34C7544D }, 2124900);
	}

	public static bool _5E423D79()
	{
		return (bool)new _78492021()._4927337F(null, 2124198);
	}

	public static bool _240A7527(IntPtr _1D8C2748)
	{
		return (bool)new _78492021()._4927337F(new object[1] { _1D8C2748 }, 2732130);
	}

	[DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "GetModuleHandle", SetLastError = true)]
	public static extern IntPtr _7F120679(string _02DC4A3C);

	static _334746C0()
	{
		new _78492021()._4927337F(null, 2724340);
	}
}
