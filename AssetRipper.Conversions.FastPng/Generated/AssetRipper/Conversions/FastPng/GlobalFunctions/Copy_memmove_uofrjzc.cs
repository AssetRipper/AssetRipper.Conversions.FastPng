using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Copy_memmove@PEA_KPEA_K@std@@YAPEA_KPEA_K00@Z")]
[DemangledName("unsigned __int64 * __cdecl std::_Copy_memmove<unsigned __int64 *, unsigned __int64 *>(unsigned __int64 *, unsigned __int64 *, unsigned __int64 *)")]
[CleanName("Copy_memmove")]
internal static partial class Copy_memmove_uofrjzc
{
	[return: NativeType("unsigned __int64 *")]
	public unsafe static void* Invoke([MangledName("_First")][NativeType("unsigned __int64 *")] void* First, [MangledName("_Last")][NativeType("unsigned __int64 *")] void* Last, [MangledName("_Dest")][NativeType("unsigned __int64 *")] void* Dest)
	{
		void* ptr = Last;
		void* ptr2 = First;
		void* ptr3 = To_address_l9253rd.Invoke(&ptr2);
		void* ptr4 = To_address_l9253rd.Invoke(&ptr);
		unchecked
		{
			long object_count = ((long)ptr4 - (long)ptr3) / 8L;
			void* ptr5 = ptr3;
			return Copy_memmove_tail_oluaukc.Invoke(ptr5, Dest, (long)ptr4 - (long)ptr5, object_count);
		}
	}
}
