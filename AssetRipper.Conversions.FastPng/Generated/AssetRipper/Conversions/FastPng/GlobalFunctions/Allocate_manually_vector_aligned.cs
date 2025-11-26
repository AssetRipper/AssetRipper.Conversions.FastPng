using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Allocate_manually_vector_aligned@U_Default_allocate_traits@std@@@std@@YAPEAX_K@Z")]
[DemangledName("void * __cdecl std::_Allocate_manually_vector_aligned<struct std::_Default_allocate_traits>(unsigned __int64)")]
internal static partial class Allocate_manually_vector_aligned
{
	[return: NativeType("void *")]
	public unsafe static void* Invoke([MangledName("_Bytes")][NativeType("unsigned __int64")] long Bytes)
	{
		unchecked
		{
			long num = 39L + Bytes;
			if ((ulong)num <= (ulong)Bytes)
			{
				Throw_bad_array_new_length.Invoke();
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				throw null;
			}
			long num2 = (long)Allocate_q5w6zu.Invoke(num);
			if (num2 == 0L)
			{
				llvm_trap.Invoke();
			}
			void* ptr = (void*)((num2 + 39L) & -32L);
			*(long*)((byte*)ptr + -8) = num2;
			return ptr;
		}
	}
}
