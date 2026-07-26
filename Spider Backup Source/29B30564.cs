using System.Runtime.InteropServices;

public static class _29B30564
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _1C745BBB();

	public static object[] _32016194;

	internal static bool _4C5162B8(byte[] _45D6172F)
	{
		for (int i = 0; i < _45D6172F.Length; i++)
		{
			if (i + 3 < _45D6172F.Length && _45D6172F[i] == 81 && _45D6172F[i + 1] == 69 && _45D6172F[i + 2] == 77 && _45D6172F[i + 3] == 85)
			{
				return true;
			}
			if (i + 8 < _45D6172F.Length && _45D6172F[i] == 77 && _45D6172F[i + 1] == 105 && _45D6172F[i + 2] == 99 && _45D6172F[i + 3] == 114 && _45D6172F[i + 4] == 111 && _45D6172F[i + 5] == 115 && _45D6172F[i + 6] == 111 && _45D6172F[i + 7] == 102 && _45D6172F[i + 8] == 116)
			{
				return true;
			}
			if (i + 6 < _45D6172F.Length && _45D6172F[i] == 105 && _45D6172F[i + 1] == 110 && _45D6172F[i + 2] == 110 && _45D6172F[i + 3] == 111 && _45D6172F[i + 4] == 116 && _45D6172F[i + 5] == 101 && _45D6172F[i + 6] == 107)
			{
				return true;
			}
			if (i + 9 < _45D6172F.Length && _45D6172F[i] == 86 && _45D6172F[i + 1] == 105 && _45D6172F[i + 2] == 114 && _45D6172F[i + 3] == 116 && _45D6172F[i + 4] == 117 && _45D6172F[i + 5] == 97 && _45D6172F[i + 6] == 108 && _45D6172F[i + 7] == 66 && _45D6172F[i + 8] == 111 && _45D6172F[i + 9] == 120)
			{
				return true;
			}
			if (i + 5 < _45D6172F.Length && _45D6172F[i] == 86 && _45D6172F[i + 1] == 77 && _45D6172F[i + 2] == 119 && _45D6172F[i + 3] == 97 && _45D6172F[i + 4] == 114 && _45D6172F[i + 5] == 101)
			{
				return true;
			}
			if (i + 8 < _45D6172F.Length && _45D6172F[i] == 80 && _45D6172F[i + 1] == 97 && _45D6172F[i + 2] == 114 && _45D6172F[i + 3] == 97 && _45D6172F[i + 4] == 108 && _45D6172F[i + 5] == 108 && _45D6172F[i + 6] == 101 && _45D6172F[i + 7] == 108 && _45D6172F[i + 8] == 115)
			{
				return true;
			}
		}
		return false;
	}
}
