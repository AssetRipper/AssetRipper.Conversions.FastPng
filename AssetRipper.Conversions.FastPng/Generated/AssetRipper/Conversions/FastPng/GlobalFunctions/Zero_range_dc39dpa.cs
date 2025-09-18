using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Zero_range@PEAI@std@@YAPEAIQEAI0@Z")]
[DemangledName("unsigned int * __cdecl std::_Zero_range<unsigned int *>(unsigned int *const, unsigned int *const)")]
[CleanName("Zero_range")]
internal static partial class Zero_range_dc39dpa
{
	[return: NativeType("unsigned int *")]
	public unsafe static void* Invoke([MangledName("_First")][NativeType("unsigned int *const")] void* First, [MangledName("_Last")][NativeType("unsigned int *const")] void* Last)
	{
		void* result = Last;
		void* ptr = First;
		void* ptr2 = To_address_aoz7nfb.Invoke(&ptr);
		llvm_memset_p0_i64.Invoke(ptr2, 0, unchecked((long)To_address_aoz7nfb.Invoke(&result) - (long)ptr2), isVolatile: false);
		return result;
	}
}
