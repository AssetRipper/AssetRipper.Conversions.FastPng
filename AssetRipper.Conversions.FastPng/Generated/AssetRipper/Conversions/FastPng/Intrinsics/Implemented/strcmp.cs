using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

internal static partial class strcmp
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static int Invoke(void* p1, void* p2)
	{
		return unchecked(IntrinsicFunctions.strcmp((byte*)p1, (byte*)p2));
	}
}
