public class _487A07DA
{
	private uint _39CC29B8;

	public uint _0B110056(uint _742618A5)
	{
		uint num = _742618A5 ^ _39CC29B8;
		_39CC29B8 = _44924456._5B04709F(_39CC29B8, 7) ^ num;
		return num;
	}

	public _487A07DA()
	{
		_39CC29B8 = 1388657149u;
	}
}
