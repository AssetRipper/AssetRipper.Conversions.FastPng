using System;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Tidy@?$vector@_KV?$allocator@_K@std@@@std@@AEAAXXZ")]
[DemangledName("private: void __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Tidy(void)")]
[CleanName("Tidy")]
internal static partial class Tidy_hq3jjxb
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		void* ptr = Getal_kuj7nva.Invoke(@this);
		unchecked
		{
			void* myval = &((std_vector_mvt3mha*)@this)->Mypair.Myval2;
			void* myfirst = &((std_Vector_val_zgi5p7d*)myval)->Myfirst;
			void* mylast = &((std_Vector_val_zgi5p7d*)myval)->Mylast;
			void* myend = &((std_Vector_val_zgi5p7d*)myval)->Myend;
			Orphan_all.Invoke(myval);
			if (*(IntPtr*)myfirst != (IntPtr)(nint)0)
			{
				Destroy_range_qbzp7xb.Invoke(Al: ptr, Last: *(void**)mylast, First: *(void**)myfirst);
				deallocate_yb2gvqa.Invoke(ptr, Count: ((long)(nuint)(*(nint*)myend) - (long)(nuint)(*(nint*)myfirst)) / 8L, Ptr: *(void**)myfirst);
				*(IntPtr*)myfirst = (nint)0;
				*(IntPtr*)mylast = (nint)0;
				*(IntPtr*)myend = (nint)0;
			}
		}
	}
}
