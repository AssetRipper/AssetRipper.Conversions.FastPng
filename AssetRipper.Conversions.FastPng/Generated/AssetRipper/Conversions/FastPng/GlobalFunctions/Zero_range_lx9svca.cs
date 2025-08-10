using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Zero_range@PEA_K@std@@YAPEA_KQEA_K0@Z")]
[DemangledName("unsigned __int64 * __cdecl std::_Zero_range<unsigned __int64 *>(unsigned __int64 *const, unsigned __int64 *const)")]
[CleanName("Zero_range")]
internal static partial class Zero_range_lx9svca
{
	public unsafe static void* Invoke(void* First, void* Last)
	{
		void* result = null;
		void** val = &result;
		void* ptr = null;
		void** val2 = &ptr;
		result = Last;
		ptr = First;
		void* ptr2 = To_address_l9253rd.Invoke(val2);
		llvm_memset_p0_i64.Invoke(ptr2, 0, unchecked((long)To_address_l9253rd.Invoke(val) - (long)ptr2), isVolatile: false);
		return result;
	}
}
