using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Zero_range@PEAI@std@@YAPEAIQEAI0@Z")]
[DemangledName("unsigned int * __cdecl std::_Zero_range<unsigned int *>(unsigned int *const, unsigned int *const)")]
[CleanName("Zero_range")]
internal static partial class Zero_range_dc39dpa
{
	public unsafe static void* Invoke(void* First, void* Last)
	{
		void* result = null;
		void** val = &result;
		void* ptr = null;
		void** val2 = &ptr;
		result = Last;
		ptr = First;
		void* ptr2 = To_address_aoz7nfb.Invoke(val2);
		llvm_memset_p0_i64.Invoke(ptr2, 0, unchecked((long)To_address_aoz7nfb.Invoke(val) - (long)ptr2), isVolatile: false);
		return result;
	}
}
