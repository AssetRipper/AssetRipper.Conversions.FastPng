using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

internal static partial class memcmp
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static int Invoke(void* p1, void* p2, long count)
	{
		return unchecked(IntrinsicFunctions.memcmp((byte*)p1, (byte*)p2, count));
	}
}
