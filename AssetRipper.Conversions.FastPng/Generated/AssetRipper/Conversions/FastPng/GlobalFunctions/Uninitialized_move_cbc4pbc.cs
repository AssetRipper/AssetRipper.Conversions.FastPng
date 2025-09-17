using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Uninitialized_move@PEA_KV?$allocator@_K@std@@@std@@YAPEA_KQEA_K0PEA_KAEAV?$allocator@_K@0@@Z")]
[DemangledName("unsigned __int64 * __cdecl std::_Uninitialized_move<unsigned __int64 *, class std::allocator<unsigned __int64>>(unsigned __int64 *const, unsigned __int64 *const, unsigned __int64 *, class std::allocator<unsigned __int64> &)")]
[CleanName("Uninitialized_move")]
internal static partial class Uninitialized_move_cbc4pbc
{
	public unsafe static void* Invoke(void* First, void* Last, void* Dest, void* Al)
	{
		void* ptr = Last;
		void* ptr2 = First;
		void* ptr3 = Get_unwrapped_3jsimya.Invoke(&ptr2);
		void* ptr4 = Get_unwrapped_3jsimya.Invoke(&ptr);
		Copy_memmove_uofrjzc.Invoke(ptr3, ptr4, Unfancy_z2hkbxa.Invoke(Dest));
		return unchecked((byte*)Dest + (nint)(((long)ptr4 - (long)ptr3) / 8L) * 8);
	}
}
