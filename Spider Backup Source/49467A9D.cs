using System.IO;

public class _49467A9D
{
	private uint _03634CF4;

	public uint _47232CE2;

	private uint _33F1164D;

	private uint _67502FEE = 1u;

	private Stream _775000EC;

	private uint _3A82696F;

	private byte[] _6CCC08BC;

	public void _02C65D56()
	{
		uint num = _3A82696F - _33F1164D;
		if (num != 0)
		{
			_775000EC.Write(_6CCC08BC, (int)_33F1164D, (int)num);
			if (_3A82696F >= _03634CF4)
			{
				_3A82696F = 0u;
			}
			_33F1164D = _3A82696F;
		}
	}

	public void _49407027(uint _481B28C8, uint _30300C9D)
	{
		uint num = _3A82696F - _481B28C8 - 1;
		if (num >= _03634CF4)
		{
			num += _03634CF4;
		}
		while (_30300C9D != 0)
		{
			if (num >= _03634CF4)
			{
				num = 0u;
			}
			_6CCC08BC[_3A82696F++] = _6CCC08BC[num++];
			if (_3A82696F >= _03634CF4)
			{
				_02C65D56();
			}
			_30300C9D--;
		}
	}

	public void _632E1BD1()
	{
		_02C65D56();
		_775000EC = null;
	}

	public void _21F30FE0(byte _129D1539)
	{
		_6CCC08BC[_3A82696F++] = _129D1539;
		if (_3A82696F >= _03634CF4)
		{
			_02C65D56();
		}
	}

	public byte _53CD72D9(uint _5C42347E)
	{
		uint num = _3A82696F - _5C42347E - 1;
		if (num >= _03634CF4)
		{
			num += _03634CF4;
		}
		return _6CCC08BC[num];
	}

	public void _596B0E02(Stream _15F51C7C, bool _0BD16A07)
	{
		_632E1BD1();
		_775000EC = _15F51C7C;
		if (!_0BD16A07)
		{
			_33F1164D = 0u;
			_3A82696F = 0u;
			_47232CE2 = 0u;
		}
	}

	public void _5D067894(uint _6BF26CFB)
	{
		if (_03634CF4 != _6BF26CFB)
		{
			_6CCC08BC = new byte[_6BF26CFB];
		}
		_03634CF4 = _6BF26CFB;
		_3A82696F = 0u;
		_33F1164D = 0u;
	}
}
