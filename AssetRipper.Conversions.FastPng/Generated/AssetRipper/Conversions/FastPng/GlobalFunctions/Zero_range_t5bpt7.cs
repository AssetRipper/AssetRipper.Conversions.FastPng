using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Zero_range@PEAE@std@@YAPEAEQEAE0@Z")]
[DemangledName("unsigned char * __cdecl std::_Zero_range<unsigned char *>(unsigned char *const, unsigned char *const)")]
[CleanName("Zero_range")]
internal static partial class Zero_range_t5bpt7
{
	[return: NativeType("unsigned char *")]
	public unsafe static void* Invoke([MangledName("_First")][NativeType("unsigned char *const")] void* First, [MangledName("_Last")][NativeType("unsigned char *const")] void* Last)
	{
		void* result = Last;
		void* ptr = First;
		void* ptr2 = To_address_e887gk.Invoke(&ptr);
		llvm_memset_p0_i64.Invoke(ptr2, 0, unchecked((long)To_address_e887gk.Invoke(&result) - (long)ptr2), isVolatile: false);
		return result;
	}
}
