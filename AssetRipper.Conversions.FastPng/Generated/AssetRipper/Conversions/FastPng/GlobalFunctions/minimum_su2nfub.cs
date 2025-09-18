using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$minimum@I@fpng@@YAIII@Z")]
[DemangledName("unsigned int __cdecl fpng::minimum<unsigned int>(unsigned int, unsigned int)")]
[CleanName("minimum")]
internal static partial class minimum_su2nfub
{
	[return: NativeType("unsigned int")]
	public static int Invoke([NativeType("unsigned int")] int a, [NativeType("unsigned int")] int b)
	{
		return unchecked((uint)a >= (uint)b) ? b : a;
	}
}
