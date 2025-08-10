using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

[MangledName("llvm.memmove.p0.p0.i64")]
[DemangledName("llvm.memmove.p0.p0.i64")]
internal static partial class llvm_memmove_p0_p0_i64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void Invoke(void* destination, void* source, long length, bool isVolatile)
	{
		IntrinsicFunctions.llvm_memmove_p0_p0_i64(destination, source, length, isVolatile);
	}
}
