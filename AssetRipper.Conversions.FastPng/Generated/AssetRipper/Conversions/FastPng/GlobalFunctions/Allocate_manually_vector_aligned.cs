using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Allocate_manually_vector_aligned@U_Default_allocate_traits@std@@@std@@YAPEAX_K@Z")]
[DemangledName("void * __cdecl std::_Allocate_manually_vector_aligned<struct std::_Default_allocate_traits>(unsigned __int64)")]
internal static partial class Allocate_manually_vector_aligned
{
	public unsafe static void* Invoke(long Bytes)
	{
		long num = 0L;
		void* ptr = null;
		unchecked
		{
			long num2 = 39L + Bytes;
			if ((ulong)num2 <= (ulong)Bytes)
			{
				Throw_bad_array_new_length.Invoke();
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				throw null;
			}
			num = (long)Allocate_ifu7fia.Invoke(num2);
			if (num == 0L)
			{
				llvm_trap.Invoke();
			}
			ptr = (void*)((num + 39L) & -32L);
			*(long*)((byte*)ptr + -8) = num;
			return ptr;
		}
	}
}
