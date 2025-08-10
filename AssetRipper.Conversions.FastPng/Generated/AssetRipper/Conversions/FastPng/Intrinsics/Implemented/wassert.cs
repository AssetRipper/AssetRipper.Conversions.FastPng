using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

[MangledName("_wassert")]
[DemangledName("_wassert")]
internal static partial class wassert
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void Invoke(void* message, void* file, int line)
	{
		unchecked
		{
			IntrinsicFunctions.Assert((char*)message, (char*)file, (uint)line);
		}
	}
}
