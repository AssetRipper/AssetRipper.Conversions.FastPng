using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$maximum@I@fpng@@YAIII@Z")]
[DemangledName("unsigned int __cdecl fpng::maximum<unsigned int>(unsigned int, unsigned int)")]
[CleanName("maximum")]
internal static partial class maximum_y5wzmwb
{
	public static int Invoke(int a, int b)
	{
		if (unchecked((uint)a <= (uint)b))
		{
			return b;
		}
		return a;
	}
}
