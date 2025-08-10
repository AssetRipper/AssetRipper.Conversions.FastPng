using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$minimum@I@fpng@@YAIII@Z")]
[DemangledName("unsigned int __cdecl fpng::minimum<unsigned int>(unsigned int, unsigned int)")]
[CleanName("minimum")]
internal static partial class minimum_su2nfub
{
	public static int Invoke(int a, int b)
	{
		if (unchecked((uint)a >= (uint)b))
		{
			return b;
		}
		return a;
	}
}
