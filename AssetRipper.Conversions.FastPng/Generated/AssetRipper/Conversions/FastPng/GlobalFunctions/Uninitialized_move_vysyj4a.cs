using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Uninitialized_move@PEAEV?$allocator@E@std@@@std@@YAPEAEQEAE0PEAEAEAV?$allocator@E@0@@Z")]
[DemangledName("unsigned char * __cdecl std::_Uninitialized_move<unsigned char *, class std::allocator<unsigned char>>(unsigned char *const, unsigned char *const, unsigned char *, class std::allocator<unsigned char> &)")]
[CleanName("Uninitialized_move")]
internal static partial class Uninitialized_move_vysyj4a
{
	[return: NativeType("unsigned char *")]
	public unsafe static void* Invoke([MangledName("_First")][NativeType("unsigned char *const")] void* First, [MangledName("_Last")][NativeType("unsigned char *const")] void* Last, [MangledName("_Dest")][NativeType("unsigned char *")] void* Dest, [MangledName("_Al")][NativeType("class std::allocator<unsigned char> &")] void* Al)
	{
		void* ptr = Last;
		void* ptr2 = First;
		void* ptr3 = Get_unwrapped_z99fpma.Invoke(&ptr2);
		void* ptr4 = Get_unwrapped_z99fpma.Invoke(&ptr);
		Copy_memmove_2kkdavd.Invoke(ptr3, ptr4, Unfancy_aszk3nc.Invoke(Dest));
		return unchecked((byte*)Dest + ((long)ptr4 - (long)ptr3));
	}
}
