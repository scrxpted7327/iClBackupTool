using System.IO;

internal class _0798143F
{
	public Stream _1AA81EEB;

	public uint _608D2ED1;

	public uint _6A3C7C5B;

	private uint _401D136A = 1u;

	public uint _6B02792A(int _72425755)
	{
		uint num = _6A3C7C5B;
		uint num2 = _608D2ED1;
		uint num3 = 0u;
		for (int num4 = _72425755; num4 > 0; num4--)
		{
			num >>= 1;
			uint num5 = num2 - num >> 31;
			num2 -= num & (num5 - 1);
			num3 = (num3 << 1) | (1 - num5);
			if (num < 16777216)
			{
				num2 = (num2 << 8) | (byte)_1AA81EEB.ReadByte();
				num <<= 8;
			}
		}
		_6A3C7C5B = num;
		_608D2ED1 = num2;
		return num3;
	}

	public void _5702067C()
	{
		_1AA81EEB = null;
	}

	public void _373D58E0(Stream _4F4619E8)
	{
		_1AA81EEB = _4F4619E8;
		_608D2ED1 = 0u;
		_6A3C7C5B = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			_608D2ED1 = (_608D2ED1 << 8) | (byte)_1AA81EEB.ReadByte();
		}
	}
}
