using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Uninitialized_value_construct_n@V?$allocator@_K@std@@@std@@YAPEA_KPEA_K_KAEAV?$allocator@_K@0@@Z")]
[DemangledName("unsigned __int64 * __cdecl std::_Uninitialized_value_construct_n<class std::allocator<unsigned __int64>>(unsigned __int64 *, unsigned __int64, class std::allocator<unsigned __int64> &)")]
[CleanName("Uninitialized_value_construct_n")]
internal static partial class Uninitialized_value_construct_n_e2x86x
{
	[return: NativeType("unsigned __int64 *")]
	public unsafe static void* Invoke([MangledName("_First")][NativeType("unsigned __int64 *")] void* First, [MangledName("_Count")][NativeType("unsigned __int64")] long Count, [MangledName("_Al")][NativeType("class std::allocator<unsigned __int64> &")] void* Al)
	{
		void* ptr = Unfancy_2hrtxn.Invoke(First);
		unchecked
		{
			Zero_range_frsqbi.Invoke(ptr, (byte*)ptr + (nint)Count * 8);
			return (byte*)First + (nint)Count * 8;
		}
	}
}
