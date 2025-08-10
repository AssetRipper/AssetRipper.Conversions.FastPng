using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Uninitialized_value_construct_n@V?$allocator@I@std@@@std@@YAPEAIPEAI_KAEAV?$allocator@I@0@@Z")]
[DemangledName("unsigned int * __cdecl std::_Uninitialized_value_construct_n<class std::allocator<unsigned int>>(unsigned int *, unsigned __int64, class std::allocator<unsigned int> &)")]
[CleanName("Uninitialized_value_construct_n")]
internal static partial class Uninitialized_value_construct_n_zg4iwva
{
	public unsafe static void* Invoke(void* First, long Count, void* Al)
	{
		void* ptr = Unfancy_xjzn42c.Invoke(First);
		unchecked
		{
			Zero_range_dc39dpa.Invoke(ptr, (byte*)ptr + (nint)Count * 4);
			return (byte*)First + (nint)Count * 4;
		}
	}
}
