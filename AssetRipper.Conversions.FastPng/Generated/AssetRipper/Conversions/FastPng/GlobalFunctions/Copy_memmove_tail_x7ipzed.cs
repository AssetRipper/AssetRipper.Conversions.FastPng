using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Copy_memmove_tail@PEAE@std@@YAPEAEQEBDQEAE_K2@Z")]
[DemangledName("unsigned char * __cdecl std::_Copy_memmove_tail<unsigned char *>(char const *const, unsigned char *const, unsigned __int64, unsigned __int64)")]
[CleanName("Copy_memmove_tail")]
internal static partial class Copy_memmove_tail_x7ipzed
{
	public unsafe static void* Invoke(void* First_ch, void* Dest, long Byte_count, long Object_count)
	{
		void* ptr = null;
		void** val = &ptr;
		ptr = Dest;
		void* ptr2 = To_address_enkoctc.Invoke(val);
		llvm_memmove_p0_p0_i64.Invoke(ptr2, First_ch, Byte_count, isVolatile: false);
		return unchecked((byte*)ptr2) + Byte_count;
	}
}
