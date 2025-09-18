using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$maximum@I@fpng@@YAIII@Z")]
[DemangledName("unsigned int __cdecl fpng::maximum<unsigned int>(unsigned int, unsigned int)")]
[CleanName("maximum")]
internal static partial class maximum_y5wzmwb
{
	[return: NativeType("unsigned int")]
	public static int Invoke([NativeType("unsigned int")] int a, [NativeType("unsigned int")] int b)
	{
		return unchecked((uint)a <= (uint)b) ? b : a;
	}
}
