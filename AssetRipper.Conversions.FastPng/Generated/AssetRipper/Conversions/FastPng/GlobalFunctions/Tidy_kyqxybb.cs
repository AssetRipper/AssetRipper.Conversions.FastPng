using System;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Tidy@?$vector@IV?$allocator@I@std@@@std@@AEAAXXZ")]
[DemangledName("private: void __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::_Tidy(void)")]
[CleanName("Tidy")]
internal static partial class Tidy_kyqxybb
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		void* ptr = Getal_t2pmqoc.Invoke(@this);
		unchecked
		{
			void* field_ = &((std_vector_drook9b*)@this)->field_0.field_0;
			void* field_2 = &((std_Vector_val_edx9ebc*)field_)->field_0;
			void* field_3 = &((std_Vector_val_edx9ebc*)field_)->field_1;
			void* field_4 = &((std_Vector_val_edx9ebc*)field_)->field_2;
			Orphan_all.Invoke(field_);
			if (*(IntPtr*)field_2 != (IntPtr)(nint)0)
			{
				Destroy_range_9rluabc.Invoke(Al: ptr, Last: *(void**)field_3, First: *(void**)field_2);
				deallocate_gfl4ncc.Invoke(ptr, Count: ((long)(nuint)(*(nint*)field_4) - (long)(nuint)(*(nint*)field_2)) / 4L, Ptr: *(void**)field_2);
				*(IntPtr*)field_2 = (nint)0;
				*(IntPtr*)field_3 = (nint)0;
				*(IntPtr*)field_4 = (nint)0;
			}
		}
	}
}
