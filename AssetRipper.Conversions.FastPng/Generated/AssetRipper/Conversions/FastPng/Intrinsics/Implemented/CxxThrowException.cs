using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

[MangledName("_CxxThrowException")]
[DemangledName("_CxxThrowException")]
internal static partial class CxxThrowException
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void Invoke(void* exceptionPointer, void* throwInfo)
	{
		IntrinsicFunctions.CxxThrowException(exceptionPointer, throwInfo);
	}
}
