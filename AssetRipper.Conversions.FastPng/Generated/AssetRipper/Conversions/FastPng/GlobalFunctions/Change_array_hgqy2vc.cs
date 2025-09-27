using System;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Change_array@?$vector@_KV?$allocator@_K@std@@@std@@AEAAXQEA_K_K1@Z")]
[DemangledName("private: void __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Change_array(unsigned __int64 *const, unsigned __int64, unsigned __int64)")]
[CleanName("Change_array")]
internal static partial class Change_array_hgqy2vc
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [MangledName("_Newvec")][NativeType("unsigned __int64 *const")] void* Newvec, [MangledName("_Newsize")][NativeType("unsigned __int64")] long Newsize, [MangledName("_Newcapacity")][NativeType("unsigned __int64")] long Newcapacity)
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
			}
			*(void**)myfirst = Newvec;
			*(byte**)mylast = (byte*)Newvec + (nint)Newsize * 8;
			*(byte**)myend = (byte*)Newvec + (nint)Newcapacity * 8;
		}
	}
}
