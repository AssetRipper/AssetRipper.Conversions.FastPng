using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$maximum@H@fpng@@YAHHH@Z")]
[DemangledName("int __cdecl fpng::maximum<int>(int, int)")]
[CleanName("maximum")]
internal static partial class maximum_sfjssib
{
	public static int Invoke(int a, int b)
	{
		if (a <= b)
		{
			return b;
		}
		return a;
	}
}
