using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

[MangledName("??3@YAXPEAX_K@Z")]
[DemangledName("void __cdecl operator delete(void *, unsigned __int64)")]
internal static partial class Delete
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void Invoke(void* ptr, long size)
	{
		IntrinsicFunctions.Delete(ptr, size);
	}
}
