using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Uninitialized_value_construct_n@V?$allocator@E@std@@@std@@YAPEAEPEAE_KAEAV?$allocator@E@0@@Z")]
[DemangledName("unsigned char * __cdecl std::_Uninitialized_value_construct_n<class std::allocator<unsigned char>>(unsigned char *, unsigned __int64, class std::allocator<unsigned char> &)")]
[CleanName("Uninitialized_value_construct_n")]
internal static partial class Uninitialized_value_construct_n_cxm3ryd
{
	public unsafe static void* Invoke(void* First, long Count, void* Al)
	{
		void* ptr = Unfancy_aszk3nc.Invoke(First);
		unchecked
		{
			Zero_range_927ahid.Invoke(ptr, (byte*)ptr + Count);
			return (byte*)First + Count;
		}
	}
}
