internal struct _17534D20
{
	private readonly _7B865EEE[] _73976241;

	private readonly int _2C490A0B;

	public uint _64EA22D4(_0798143F _31380733)
	{
		uint num = 1u;
		for (int num2 = _2C490A0B; num2 > 0; num2--)
		{
			num = (num << 1) + _73976241[num]._43F30FBA(_31380733);
		}
		return num - (uint)(1 << _2C490A0B);
	}

	public void _5A8226A7()
	{
		for (uint num = 1u; num < 1 << _2C490A0B; num++)
		{
			_73976241[num]._4E940FE9();
		}
	}

	public uint _525B21C4(_0798143F _54CD37CC)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < _2C490A0B; i++)
		{
			uint num3 = _73976241[num]._43F30FBA(_54CD37CC);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	public static uint _732E5A73(_7B865EEE[] _3C1A3540, uint _4DCE7594, _0798143F _71A70C2E, int _15891F14)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < _15891F14; i++)
		{
			uint num3 = _3C1A3540[_4DCE7594 + num]._43F30FBA(_71A70C2E);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	public _17534D20(int _404F56F8)
	{
		_2C490A0B = _404F56F8;
		_73976241 = new _7B865EEE[1 << _404F56F8];
	}
}
