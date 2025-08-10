using System;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Tidy@?$vector@EV?$allocator@E@std@@@std@@AEAAXXZ")]
[DemangledName("private: void __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Tidy(void)")]
[CleanName("Tidy")]
internal static partial class Tidy_iono57d
{
	public unsafe static void Invoke(void* @this)
	{
		void* ptr = Getal_jms5hzb.Invoke(@this);
		unchecked
		{
			void* field_ = &((std_vector*)@this)->field_0.field_0;
			void* field_2 = &((std_Vector_val*)field_)->field_0;
			void* field_3 = &((std_Vector_val*)field_)->field_1;
			void* field_4 = &((std_Vector_val*)field_)->field_2;
			Orphan_all.Invoke(field_);
			if (*(IntPtr*)field_2 != (IntPtr)(nint)0)
			{
				Destroy_range_jjcob5a.Invoke(Al: ptr, Last: *(void**)field_3, First: *(void**)field_2);
				deallocate_mc9rbjc.Invoke(ptr, Count: (long)(nuint)(*(nint*)field_4) - (long)(nuint)(*(nint*)field_2), Ptr: *(void**)field_2);
				*(IntPtr*)field_2 = (nint)0;
				*(IntPtr*)field_3 = (nint)0;
				*(IntPtr*)field_4 = (nint)0;
			}
		}
	}
}
