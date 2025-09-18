using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$maximum@H@fpng@@YAHHH@Z")]
[DemangledName("int __cdecl fpng::maximum<int>(int, int)")]
[CleanName("maximum")]
internal static partial class maximum_sfjssib
{
	[return: NativeType("int")]
	public static int Invoke([NativeType("int")] int a, [NativeType("int")] int b)
	{
		return (a <= b) ? b : a;
	}
}
