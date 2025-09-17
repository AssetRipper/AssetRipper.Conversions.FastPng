using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

[MangledName("llvm.trap")]
[DemangledName("llvm.trap")]
internal static partial class llvm_trap
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Invoke()
	{
		IntrinsicFunctions.Terminate();
	}
}
