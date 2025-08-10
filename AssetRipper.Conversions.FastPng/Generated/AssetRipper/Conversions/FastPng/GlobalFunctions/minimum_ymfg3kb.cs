using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$minimum@H@fpng@@YAHHH@Z")]
[DemangledName("int __cdecl fpng::minimum<int>(int, int)")]
[CleanName("minimum")]
internal static partial class minimum_ymfg3kb
{
	public static int Invoke(int a, int b)
	{
		if (a >= b)
		{
			return b;
		}
		return a;
	}
}
