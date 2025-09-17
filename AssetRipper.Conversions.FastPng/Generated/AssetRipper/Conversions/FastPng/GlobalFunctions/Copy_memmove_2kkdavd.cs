using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Copy_memmove@PEAEPEAE@std@@YAPEAEPEAE00@Z")]
[DemangledName("unsigned char * __cdecl std::_Copy_memmove<unsigned char *, unsigned char *>(unsigned char *, unsigned char *, unsigned char *)")]
[CleanName("Copy_memmove")]
internal static partial class Copy_memmove_2kkdavd
{
	public unsafe static void* Invoke(void* First, void* Last, void* Dest)
	{
		void* ptr = Last;
		void* ptr2 = First;
		void* ptr3 = To_address_enkoctc.Invoke(&ptr2);
		void* ptr4 = To_address_enkoctc.Invoke(&ptr);
		unchecked
		{
			long object_count = (long)ptr4 - (long)ptr3;
			void* ptr5 = ptr3;
			return Copy_memmove_tail_x7ipzed.Invoke(ptr5, Dest, (long)ptr4 - (long)ptr5, object_count);
		}
	}
}
