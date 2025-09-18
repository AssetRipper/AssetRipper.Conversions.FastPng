using System;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Adjust_manually_vector_aligned@std@@YAXAEAPEAXAEA_K@Z")]
[DemangledName("void __cdecl std::_Adjust_manually_vector_aligned(void *&, unsigned __int64 &)")]
internal static partial class Adjust_manually_vector_aligned
{
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("_Ptr")][NativeType("void *&")] void* Ptr, [MangledName("_Bytes")][NativeType("unsigned __int64 &")] void* Bytes)
	{
		unchecked
		{
			*(long*)Bytes += 39L;
			long num = *(long*)((nint)(*(IntPtr*)Ptr) + -8);
			long num2 = (long)(nuint)(*(nint*)Ptr) - num;
			if ((ulong)num2 < 8uL || (ulong)num2 > 39uL)
			{
				llvm_trap.Invoke();
			}
			*(IntPtr*)Ptr = (nint)num;
		}
	}
}
