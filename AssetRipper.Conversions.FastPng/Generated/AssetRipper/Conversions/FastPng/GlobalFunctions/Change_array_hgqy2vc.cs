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
			void* field_ = &((std_vector_5*)@this)->field_0.field_0;
			void* field_2 = &((std_Vector_val_9*)field_)->field_0;
			void* field_3 = &((std_Vector_val_9*)field_)->field_1;
			void* field_4 = &((std_Vector_val_9*)field_)->field_2;
			Orphan_all.Invoke(field_);
			if (*(IntPtr*)field_2 != (IntPtr)(nint)0)
			{
				Destroy_range_qbzp7xb.Invoke(Al: ptr, Last: *(void**)field_3, First: *(void**)field_2);
				deallocate_yb2gvqa.Invoke(ptr, Count: ((long)(nuint)(*(nint*)field_4) - (long)(nuint)(*(nint*)field_2)) / 8L, Ptr: *(void**)field_2);
			}
			*(void**)field_2 = Newvec;
			*(byte**)field_3 = (byte*)Newvec + (nint)Newsize * 8;
			*(byte**)field_4 = (byte*)Newvec + (nint)Newcapacity * 8;
		}
	}
}
