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
			void* myval = &((std_vector_drook9b*)@this)->Mypair.Myval2;
			void* myfirst = &((std_Vector_val_edx9ebc*)myval)->Myfirst;
			void* mylast = &((std_Vector_val_edx9ebc*)myval)->Mylast;
			void* myend = &((std_Vector_val_edx9ebc*)myval)->Myend;
			Orphan_all.Invoke(myval);
			if (*(IntPtr*)myfirst != (IntPtr)(nint)0)
			{
				Destroy_range_9rluabc.Invoke(Al: ptr, Last: *(void**)mylast, First: *(void**)myfirst);
				deallocate_gfl4ncc.Invoke(ptr, Count: ((long)(nuint)(*(nint*)myend) - (long)(nuint)(*(nint*)myfirst)) / 4L, Ptr: *(void**)myfirst);
				*(IntPtr*)myfirst = (nint)0;
				*(IntPtr*)mylast = (nint)0;
				*(IntPtr*)myend = (nint)0;
			}
		}
	}
}
