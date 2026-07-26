public class _44924456
{
	public static uint _0FFC62A0(uint _38A34F27)
	{
		uint num = _38A34F27 & 0xFF00FF;
		uint num2 = _38A34F27 & 0xFF00FF00u;
		return ((num >> 8) | (num << 24)) + ((num2 << 8) | (num2 >> 24));
	}

	public static uint _362028C9(uint _0B506E2C, int _7C4277F2)
	{
		return (_0B506E2C >> _7C4277F2) | (_0B506E2C << 32 - _7C4277F2);
	}

	public static uint _5B04709F(uint _753A45C9, int _6E9209CB)
	{
		return (_753A45C9 << _6E9209CB) | (_753A45C9 >> 32 - _6E9209CB);
	}
}
