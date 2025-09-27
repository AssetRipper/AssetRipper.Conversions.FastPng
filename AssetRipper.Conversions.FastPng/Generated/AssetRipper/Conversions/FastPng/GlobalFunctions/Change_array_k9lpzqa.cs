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
			void* myval = &((std_vector_7uge3hb*)@this)->Mypair.Myval2;
			void* myfirst = &((std_Vector_val_p59sy9d*)myval)->Myfirst;
			void* mylast = &((std_Vector_val_p59sy9d*)myval)->Mylast;
			void* myend = &((std_Vector_val_p59sy9d*)myval)->Myend;
			Orphan_all.Invoke(myval);
			if (*(IntPtr*)myfirst != (IntPtr)(nint)0)
			{
				Destroy_range_jjcob5a.Invoke(Al: ptr, Last: *(void**)mylast, First: *(void**)myfirst);
				deallocate_mc9rbjc.Invoke(ptr, Count: (long)(nuint)(*(nint*)myend) - (long)(nuint)(*(nint*)myfirst), Ptr: *(void**)myfirst);
			}
			*(void**)myfirst = Newvec;
			*(byte**)mylast = (byte*)Newvec + Newsize;
			*(byte**)myend = (byte*)Newvec + Newcapacity;
		}
	}
}
