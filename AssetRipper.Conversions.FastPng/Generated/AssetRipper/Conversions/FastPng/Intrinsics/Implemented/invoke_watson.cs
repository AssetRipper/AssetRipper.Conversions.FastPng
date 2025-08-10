using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

[MangledName("_invoke_watson")]
[DemangledName("_invoke_watson")]
internal static partial class invoke_watson
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void Invoke(void* expression, void* function, void* file, int line, long reserved)
	{
		unchecked
		{
			IntrinsicFunctions.InvokeWatson((char*)expression, (char*)function, (char*)file, line, reserved);
		}
	}
}
