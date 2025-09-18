using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?swap32@fpng@@YAII@Z")]
[DemangledName("unsigned int __cdecl fpng::swap32(unsigned int)")]
internal static partial class swap32
{
	[return: NativeType("unsigned int")]
	public static int Invoke([NativeType("unsigned int")] int x)
	{
		return llvm_bswap_i32.Invoke(x);
	}
}
