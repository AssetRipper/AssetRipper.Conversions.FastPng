using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

[MangledName("llvm.bswap.i32")]
[DemangledName("llvm.bswap.i32")]
internal static partial class llvm_bswap_i32
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Invoke(int parameter_0)
	{
		return NumericHelper.BSwap(parameter_0);
	}
}
