using System;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Adjust_manually_vector_aligned@std@@YAXAEAPEAXAEA_K@Z")]
[DemangledName("void __cdecl std::_Adjust_manually_vector_aligned(void *&, unsigned __int64 &)")]
internal static partial class Adjust_manually_vector_aligned
{
	public unsafe static void Invoke(void* Ptr, void* Bytes)
	{
		unchecked
		{
			*(long*)Bytes += 39L;
			long num = *(long*)((nint)(*(IntPtr*)Ptr) + -8);
			long num2 = 8L;
			long num3 = (long)(nuint)(*(nint*)Ptr) - num;
			if ((ulong)num3 < 8uL || (ulong)num3 > 39uL)
			{
				invoke_watson.Invoke(null, null, null, 0, 0L);
				throw null;
			}
			*(IntPtr*)Ptr = (nint)num;
		}
	}
}
