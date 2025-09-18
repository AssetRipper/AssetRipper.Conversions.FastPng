using System;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Change_array@?$vector@EV?$allocator@E@std@@@std@@AEAAXQEAE_K1@Z")]
[DemangledName("private: void __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Change_array(unsigned char *const, unsigned __int64, unsigned __int64)")]
[CleanName("Change_array")]
internal static partial class Change_array_k9lpzqa
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [MangledName("_Newvec")][NativeType("unsigned char *const")] void* Newvec, [MangledName("_Newsize")][NativeType("unsigned __int64")] long Newsize, [MangledName("_Newcapacity")][NativeType("unsigned __int64")] long Newcapacity)
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
			}
			*(void**)field_2 = Newvec;
			*(byte**)field_3 = (byte*)Newvec + Newsize;
			*(byte**)field_4 = (byte*)Newvec + Newcapacity;
		}
	}
}
