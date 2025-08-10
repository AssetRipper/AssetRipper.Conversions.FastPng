using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Zero_range@PEAE@std@@YAPEAEQEAE0@Z")]
[DemangledName("unsigned char * __cdecl std::_Zero_range<unsigned char *>(unsigned char *const, unsigned char *const)")]
[CleanName("Zero_range")]
internal static partial class Zero_range_927ahid
{
	public unsafe static void* Invoke(void* First, void* Last)
	{
		void* result = null;
		void** val = &result;
		void* ptr = null;
		void** val2 = &ptr;
		result = Last;
		ptr = First;
		void* ptr2 = To_address_enkoctc.Invoke(val2);
		llvm_memset_p0_i64.Invoke(ptr2, 0, unchecked((long)To_address_enkoctc.Invoke(val) - (long)ptr2), isVolatile: false);
		return result;
	}
}
