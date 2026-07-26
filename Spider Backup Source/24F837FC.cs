using System;
using System.IO;

public class _24F837FC
{
	private class _2A191C87
	{
		private uint _19BD479C;

		private readonly _17534D20[] _788E24FB = new _17534D20[16];

		private readonly _17534D20[] _551A0AF7 = new _17534D20[16];

		private _7B865EEE _235F461E;

		private _17534D20 _0C2E188B = new _17534D20(8);

		private _7B865EEE _5B7C0F7F;

		public uint _7B420A4F(_0798143F _587468B1, uint _0F7E3BFC)
		{
			if (_5B7C0F7F._43F30FBA(_587468B1) == 0)
			{
				return _551A0AF7[_0F7E3BFC]._64EA22D4(_587468B1);
			}
			uint num = 8u;
			if (_235F461E._43F30FBA(_587468B1) == 0)
			{
				return num + _788E24FB[_0F7E3BFC]._64EA22D4(_587468B1);
			}
			num += 8;
			return num + _0C2E188B._64EA22D4(_587468B1);
		}

		public void _3C2E726F()
		{
			_5B7C0F7F._4E940FE9();
			for (uint num = 0u; num < _19BD479C; num++)
			{
				_551A0AF7[num]._5A8226A7();
				_788E24FB[num]._5A8226A7();
			}
			_235F461E._4E940FE9();
			_0C2E188B._5A8226A7();
		}

		public void _713D408F(uint _1D8026EF)
		{
			for (uint num = _19BD479C; num < _1D8026EF; num++)
			{
				_551A0AF7[num] = new _17534D20(3);
				_788E24FB[num] = new _17534D20(3);
			}
			_19BD479C = _1D8026EF;
		}
	}

	private class _1C263601
	{
		private struct _4994375D
		{
			private _7B865EEE[] _38F051D1;

			public byte _5CC873A1(_0798143F _45FD1273)
			{
				uint num = 1u;
				do
				{
					num = (num << 1) | _38F051D1[num]._43F30FBA(_45FD1273);
				}
				while (num < 256);
				return (byte)num;
			}

			public byte _5C286DCE(_0798143F _3D8128FA, byte _06D419E7)
			{
				uint num = 1u;
				do
				{
					uint num2 = (uint)((_06D419E7 >> 7) & 1);
					_06D419E7 <<= 1;
					uint num3 = _38F051D1[(1 + num2 << 8) + num]._43F30FBA(_3D8128FA);
					num = (num << 1) | num3;
					if (num2 != num3)
					{
						while (num < 256)
						{
							num = (num << 1) | _38F051D1[num]._43F30FBA(_3D8128FA);
						}
						break;
					}
				}
				while (num < 256);
				return (byte)num;
			}

			public void _1FDD3A9E()
			{
				for (int i = 0; i < 768; i++)
				{
					_38F051D1[i]._4E940FE9();
				}
			}

			public void _65C10793()
			{
				_38F051D1 = new _7B865EEE[768];
			}
		}

		private int _1E234EA1;

		private int _52974657;

		private uint _6C6035DA;

		private _4994375D[] _285C1EF1;

		private uint _60154074 = 1u;

		public byte _1E1656FD(_0798143F _17DE17CE, uint _70782AF8, byte _04291BF4, byte _72293FBB)
		{
			return _285C1EF1[_5C051122(_70782AF8, _04291BF4)]._5C286DCE(_17DE17CE, _72293FBB);
		}

		private uint _5C051122(uint _2BA55A74, byte _65127404)
		{
			return ((_2BA55A74 & _6C6035DA) << _1E234EA1) + (uint)(_65127404 >> 8 - _1E234EA1);
		}

		public byte _6ADB6173(_0798143F _1EFC2A1A, uint _6A6033A0, byte _6CD828BC)
		{
			return _285C1EF1[_5C051122(_6A6033A0, _6CD828BC)]._5CC873A1(_1EFC2A1A);
		}

		public void _659307EF()
		{
			uint num = (uint)(1 << _1E234EA1 + _52974657);
			for (uint num2 = 0u; num2 < num; num2++)
			{
				_285C1EF1[num2]._1FDD3A9E();
			}
		}

		public void _21586D93(int _0B1D7BC1, int _14AF32C1)
		{
			if (_285C1EF1 == null || _1E234EA1 != _14AF32C1 || _52974657 != _0B1D7BC1)
			{
				_52974657 = _0B1D7BC1;
				_6C6035DA = (uint)((1 << _0B1D7BC1) - 1);
				_1E234EA1 = _14AF32C1;
				uint num = (uint)(1 << _1E234EA1 + _52974657);
				_285C1EF1 = new _4994375D[num];
				for (uint num2 = 0u; num2 < num; num2++)
				{
					_285C1EF1[num2]._65C10793();
				}
			}
		}
	}

	private readonly _17534D20[] _45C51F3B = new _17534D20[4];

	private _17534D20 _75685EA7 = new _17534D20(4);

	private readonly _7B865EEE[] _65493934 = new _7B865EEE[12];

	private readonly _0798143F _392B6C90 = new _0798143F();

	private readonly _2A191C87 _05307CD6 = new _2A191C87();

	private readonly _7B865EEE[] _03805021 = new _7B865EEE[12];

	private readonly _7B865EEE[] _0C16679E = new _7B865EEE[192];

	private readonly _49467A9D _08012A53 = new _49467A9D();

	private readonly _7B865EEE[] _239C16F4 = new _7B865EEE[114];

	private readonly _1C263601 _5F841D78 = new _1C263601();

	private readonly _7B865EEE[] _5E602653 = new _7B865EEE[192];

	private uint _7DAB3C7C;

	private readonly _2A191C87 _7A2C38A9 = new _2A191C87();

	private uint _24B77F6A;

	private uint _126D3101;

	private readonly _7B865EEE[] _4B9D6131 = new _7B865EEE[12];

	private readonly _7B865EEE[] _56E75E5F = new _7B865EEE[12];

	private uint _2A5C0AA9 = 1u;

	public void _26E11B35(Stream _4C635EC5, Stream _2D4001E0, long _10F9152D)
	{
		_3C311046(_4C635EC5, _2D4001E0);
		_595E4390._4D3877F4 _4D3877F = default(_595E4390._4D3877F4);
		_4D3877F._2F29666C();
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 0u;
		ulong num5 = 0uL;
		if (num5 < (ulong)_10F9152D)
		{
			if (_5E602653[_4D3877F._615C27CB << 4]._43F30FBA(_392B6C90) != 0)
			{
				throw new InvalidDataException("IsMatchDecoders");
			}
			_4D3877F._70B42F98();
			byte _129D = _5F841D78._6ADB6173(_392B6C90, 0u, 0);
			_08012A53._21F30FE0(_129D);
			num5++;
		}
		while (num5 < (ulong)_10F9152D)
		{
			uint num6 = (uint)(int)num5 & _126D3101;
			if (_5E602653[(_4D3877F._615C27CB << 4) + num6]._43F30FBA(_392B6C90) == 0)
			{
				byte b = _08012A53._53CD72D9(0u);
				byte _129D2 = (_4D3877F._07187E84() ? _5F841D78._6ADB6173(_392B6C90, (uint)num5, b) : _5F841D78._1E1656FD(_392B6C90, (uint)num5, b, _08012A53._53CD72D9(num)));
				_08012A53._21F30FE0(_129D2);
				_4D3877F._70B42F98();
				num5++;
				continue;
			}
			uint num8;
			if (_65493934[_4D3877F._615C27CB]._43F30FBA(_392B6C90) == 1)
			{
				if (_03805021[_4D3877F._615C27CB]._43F30FBA(_392B6C90) == 0)
				{
					if (_0C16679E[(_4D3877F._615C27CB << 4) + num6]._43F30FBA(_392B6C90) == 0)
					{
						_4D3877F._7D356B73();
						_08012A53._21F30FE0(_08012A53._53CD72D9(num));
						num5++;
						continue;
					}
				}
				else
				{
					uint num7;
					if (_56E75E5F[_4D3877F._615C27CB]._43F30FBA(_392B6C90) == 0)
					{
						num7 = num2;
					}
					else
					{
						if (_4B9D6131[_4D3877F._615C27CB]._43F30FBA(_392B6C90) == 0)
						{
							num7 = num3;
						}
						else
						{
							num7 = num4;
							num4 = num3;
						}
						num3 = num2;
					}
					num2 = num;
					num = num7;
				}
				num8 = _7A2C38A9._7B420A4F(_392B6C90, num6) + 2;
				_4D3877F._69FB56C3();
			}
			else
			{
				num4 = num3;
				num3 = num2;
				num2 = num;
				num8 = 2 + _05307CD6._7B420A4F(_392B6C90, num6);
				_4D3877F._442A371C();
				uint num9 = _45C51F3B[_595E4390._0A230105(num8)]._64EA22D4(_392B6C90);
				if (num9 >= 4)
				{
					int num10 = (int)((num9 >> 1) - 1);
					num = (2 | (num9 & 1)) << num10;
					if (num9 < 14)
					{
						num += _17534D20._732E5A73(_239C16F4, num - num9 - 1, _392B6C90, num10);
					}
					else
					{
						num += _392B6C90._6B02792A(num10 - 4) << 4;
						num += _75685EA7._525B21C4(_392B6C90);
					}
				}
				else
				{
					num = num9;
				}
			}
			if (num >= _08012A53._47232CE2 + num5 || num >= _24B77F6A)
			{
				if (num == uint.MaxValue)
				{
					break;
				}
				throw new InvalidDataException("rep0");
			}
			_08012A53._49407027(num, num8);
			num5 += num8;
		}
		_08012A53._02C65D56();
		_08012A53._632E1BD1();
		_392B6C90._5702067C();
	}

	private void _3C311046(Stream _2AC71F48, Stream _0E0D5854)
	{
		_392B6C90._373D58E0(_2AC71F48);
		_08012A53._596B0E02(_0E0D5854, _0BD16A07: false);
		for (uint num = 0u; num < 12; num++)
		{
			for (uint num2 = 0u; num2 <= _126D3101; num2++)
			{
				uint num3 = (num << 4) + num2;
				_5E602653[num3]._4E940FE9();
				_0C16679E[num3]._4E940FE9();
			}
			_65493934[num]._4E940FE9();
			_03805021[num]._4E940FE9();
			_56E75E5F[num]._4E940FE9();
			_4B9D6131[num]._4E940FE9();
		}
		_5F841D78._659307EF();
		for (uint num = 0u; num < 4; num++)
		{
			_45C51F3B[num]._5A8226A7();
		}
		for (uint num = 0u; num < 114; num++)
		{
			_239C16F4[num]._4E940FE9();
		}
		_05307CD6._3C2E726F();
		_7A2C38A9._3C2E726F();
		_75685EA7._5A8226A7();
	}

	private void _1C1B18D2(int _03683B62)
	{
		if (_03683B62 > 4)
		{
			throw new ArgumentException("pb > Base.KNumPosStatesBitsMax");
		}
		uint num = (uint)(1 << _03683B62);
		_05307CD6._713D408F(num);
		_7A2C38A9._713D408F(num);
		_126D3101 = num - 1;
	}

	public void _58BA72C7(byte[] _23064BD7)
	{
		if (_23064BD7.Length < 5)
		{
			throw new ArgumentException("properties.Length < 5");
		}
		int _3B797FC = _23064BD7[0] % 9;
		int num = _23064BD7[0] / 9;
		int _46DB = num % 5;
		int num2 = num / 5;
		if (num2 > 4)
		{
			throw new ArgumentException("pb > Base.kNumPosStatesBitsMax");
		}
		uint num3 = 0u;
		for (int i = 0; i < 4; i++)
		{
			num3 += (uint)(_23064BD7[1 + i] << i * 8);
		}
		_1B801C93(num3);
		_63813022(_46DB, _3B797FC);
		_1C1B18D2(num2);
	}

	private void _63813022(int _46DB7757, int _3B797FC2)
	{
		if (_46DB7757 > 8)
		{
			throw new ArgumentException("lp > 8");
		}
		if (_3B797FC2 > 8)
		{
			throw new ArgumentException("lc > 8");
		}
		_5F841D78._21586D93(_46DB7757, _3B797FC2);
	}

	private void _1B801C93(uint _0C8A7639)
	{
		if (_7DAB3C7C != _0C8A7639)
		{
			_7DAB3C7C = _0C8A7639;
			_24B77F6A = Math.Max(_7DAB3C7C, 1u);
			uint _6BF26CFB = Math.Max(_24B77F6A, 4096u);
			_08012A53._5D067894(_6BF26CFB);
		}
	}

	public _24F837FC()
	{
		_7DAB3C7C = uint.MaxValue;
		for (int i = 0; (long)i < 4L; i++)
		{
			_45C51F3B[i] = new _17534D20(6);
		}
	}
}
