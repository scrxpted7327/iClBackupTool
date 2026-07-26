internal abstract class _595E4390
{
	public struct _4D3877F4
	{
		public uint _615C27CB;

		public void _69FB56C3()
		{
			_615C27CB = ((_615C27CB < 7) ? 8u : 11u);
		}

		public void _7D356B73()
		{
			_615C27CB = ((_615C27CB < 7) ? 9u : 11u);
		}

		public void _442A371C()
		{
			_615C27CB = ((_615C27CB < 7) ? 7u : 10u);
		}

		public void _70B42F98()
		{
			if (_615C27CB < 4)
			{
				_615C27CB = 0u;
			}
			else if (_615C27CB < 10)
			{
				_615C27CB -= 3u;
			}
			else
			{
				_615C27CB -= 6u;
			}
		}

		public bool _07187E84()
		{
			return _615C27CB < 7;
		}

		public void _2F29666C()
		{
			_615C27CB = 0u;
		}
	}

	public static uint _0A230105(uint _3B594A49)
	{
		_3B594A49 -= 2;
		if (_3B594A49 < 4)
		{
			return _3B594A49;
		}
		return 3u;
	}
}
