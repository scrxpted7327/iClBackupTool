internal struct _7B865EEE
{
	private uint _4CFF3E67;

	public uint _43F30FBA(_0798143F _6AD44D08)
	{
		uint num = (_6AD44D08._6A3C7C5B >> 11) * _4CFF3E67;
		if (_6AD44D08._608D2ED1 < num)
		{
			_6AD44D08._6A3C7C5B = num;
			_4CFF3E67 += 2048 - _4CFF3E67 >> 5;
			if (_6AD44D08._6A3C7C5B < 16777216)
			{
				_6AD44D08._608D2ED1 = (_6AD44D08._608D2ED1 << 8) | (byte)_6AD44D08._1AA81EEB.ReadByte();
				_6AD44D08._6A3C7C5B <<= 8;
			}
			return 0u;
		}
		_6AD44D08._6A3C7C5B -= num;
		_6AD44D08._608D2ED1 -= num;
		_4CFF3E67 -= _4CFF3E67 >> 5;
		if (_6AD44D08._6A3C7C5B < 16777216)
		{
			_6AD44D08._608D2ED1 = (_6AD44D08._608D2ED1 << 8) | (byte)_6AD44D08._1AA81EEB.ReadByte();
			_6AD44D08._6A3C7C5B <<= 8;
		}
		return 1u;
	}

	public void _4E940FE9()
	{
		_4CFF3E67 = 1024u;
	}
}
