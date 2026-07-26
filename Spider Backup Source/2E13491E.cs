public class _2E13491E
{
	private static uint[] _0967129D;

	public unsafe uint _518D5B93(long _15316A0A, uint _75A6184A)
	{
		uint num = 0u;
		for (int i = 0; i < _75A6184A; i++)
		{
			num = _0967129D[(*(byte*)(_15316A0A + i) ^ num) & 0xFF] ^ (num >> 8);
		}
		return ~num;
	}

	public _2E13491E()
	{
		if (_0967129D != null)
		{
			return;
		}
		_0967129D = new uint[256];
		for (int i = 0; i < _0967129D.Length; i++)
		{
			uint num = (uint)i;
			for (int j = 0; j < 8; j++)
			{
				num = (((num & 1) != 1) ? (num >> 1) : ((num >> 1) ^ 0xEDB88320u));
			}
			_0967129D[i] = num;
		}
	}
}
