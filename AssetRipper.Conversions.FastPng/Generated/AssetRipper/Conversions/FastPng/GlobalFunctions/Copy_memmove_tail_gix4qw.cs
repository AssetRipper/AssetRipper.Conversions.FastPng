using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Copy_memmove_tail@PEA_K@std@@YAPEA_KQEBDQEA_K_K2@Z")]
[DemangledName("unsigned __int64 * __cdecl std::_Copy_memmove_tail<unsigned __int64 *>(char const *const, unsigned __int64 *const, unsigned __int64, unsigned __int64)")]
[CleanName("Copy_memmove_tail")]
internal static partial class Copy_memmove_tail_gix4qw
{
	[return: NativeType("unsigned __int64 *")]
	public unsafe static void* Invoke([MangledName("_First_ch")][NativeType("char const *const")] void* First_ch, [MangledName("_Dest")][NativeType("unsigned __int64 *const")] void* Dest, [MangledName("_Byte_count")][NativeType("unsigned __int64")] long Byte_count, [MangledName("_Object_count")][NativeType("unsigned __int64")] long Object_count)
	{
		void* ptr = Dest;
		void* ptr2 = To_address_uy47kg.Invoke(&ptr);
		llvm_memmove_p0_p0_i64.Invoke(ptr2, First_ch, Byte_count, isVolatile: false);
		return unchecked((byte*)ptr2) + Byte_count;
	}
}
