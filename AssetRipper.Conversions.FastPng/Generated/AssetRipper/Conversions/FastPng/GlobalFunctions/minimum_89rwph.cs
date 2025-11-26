using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$minimum@H@fpng@@YAHHH@Z")]
[DemangledName("int __cdecl fpng::minimum<int>(int, int)")]
[CleanName("minimum")]
internal static partial class minimum_89rwph
{
	[return: NativeType("int")]
	public static int Invoke([NativeType("int")] int a, [NativeType("int")] int b)
	{
		return (a >= b) ? b : a;
	}
}
