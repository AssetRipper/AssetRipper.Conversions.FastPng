using System;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Change_array@?$vector@EV?$allocator@E@std@@@std@@AEAAXQEAE_K1@Z")]
[DemangledName("private: void __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Change_array(unsigned char *const, unsigned __int64, unsigned __int64)")]
[CleanName("Change_array")]
internal static partial class Change_array_2dpfnj
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [MangledName("_Newvec")][NativeType("unsigned char *const")] void* Newvec, [MangledName("_Newsize")][NativeType("unsigned __int64")] long Newsize, [MangledName("_Newcapacity")][NativeType("unsigned __int64")] long Newcapacity)
	{
		void* ptr = Getal_vpqbcr.Invoke(@this);
		unchecked
		{
			void* myval = &((std_vector_4tqn2f*)@this)->Mypair.Myval2;
			void* myfirst = &((std_Vector_val_ghsspe*)myval)->Myfirst;
			void* mylast = &((std_Vector_val_ghsspe*)myval)->Mylast;
			void* myend = &((std_Vector_val_ghsspe*)myval)->Myend;
			Orphan_all.Invoke(myval);
			if (*(IntPtr*)myfirst != (IntPtr)(nint)0)
			{
				Destroy_range_6evibt.Invoke(Al: ptr, Last: *(void**)mylast, First: *(void**)myfirst);
				deallocate_572ymf.Invoke(ptr, Count: (long)(nuint)(*(nint*)myend) - (long)(nuint)(*(nint*)myfirst), Ptr: *(void**)myfirst);
			}
			*(void**)myfirst = Newvec;
			*(byte**)mylast = (byte*)Newvec + Newsize;
			*(byte**)myend = (byte*)Newvec + Newcapacity;
		}
	}
}
