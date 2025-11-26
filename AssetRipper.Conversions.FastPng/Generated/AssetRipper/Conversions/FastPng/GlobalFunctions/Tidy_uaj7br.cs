using System;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Tidy@?$vector@EV?$allocator@E@std@@@std@@AEAAXXZ")]
[DemangledName("private: void __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Tidy(void)")]
[CleanName("Tidy")]
internal static partial class Tidy_uaj7br
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
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
				*(IntPtr*)myfirst = (nint)0;
				*(IntPtr*)mylast = (nint)0;
				*(IntPtr*)myend = (nint)0;
			}
		}
	}
}
