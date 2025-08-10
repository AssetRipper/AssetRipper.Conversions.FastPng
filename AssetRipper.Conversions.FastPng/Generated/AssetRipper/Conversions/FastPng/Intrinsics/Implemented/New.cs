using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

[MangledName("??2@YAPEAX_K@Z")]
[DemangledName("void * __cdecl operator new(unsigned __int64)")]
internal static partial class New
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void* Invoke(long size)
	{
		return IntrinsicFunctions.Alloc(size);
	}
}
