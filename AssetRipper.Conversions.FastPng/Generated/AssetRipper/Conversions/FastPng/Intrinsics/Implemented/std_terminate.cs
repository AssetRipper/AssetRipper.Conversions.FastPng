using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

[MangledName("__std_terminate")]
[DemangledName("__std_terminate")]
internal static partial class std_terminate
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Invoke()
	{
		IntrinsicFunctions.Terminate();
	}
}
