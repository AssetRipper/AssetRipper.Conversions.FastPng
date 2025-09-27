using System;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Resize@U_Value_init_tag@std@@@?$vector@EV?$allocator@E@std@@@std@@AEAAX_KAEBU_Value_init_tag@1@@Z")]
[DemangledName("private: void __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Resize<struct std::_Value_init_tag>(unsigned __int64, struct std::_Value_init_tag const &)")]
[CleanName("Resize")]
internal static partial class Resize_p4x2rua
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [MangledName("_Newsize")][NativeType("unsigned __int64")] long Newsize, [MangledName("_Val")][NativeType("struct std::_Value_init_tag const &")] void* Val)
	{
		void* al = Getal_jms5hzb.Invoke(@this);
		unchecked
		{
			void* myval = &((std_vector_7uge3hb*)@this)->Mypair.Myval2;
			void* myfirst = &((std_Vector_val_p59sy9d*)myval)->Myfirst;
			void* mylast = &((std_Vector_val_p59sy9d*)myval)->Mylast;
			long num = (long)(nuint)(*(nint*)mylast) - (long)(nuint)(*(nint*)myfirst);
			if ((ulong)Newsize < (ulong)num)
			{
				void* ptr = (void*)((nint)(*(IntPtr*)myfirst) + (nint)Newsize);
				Orphan_range_334quvb.Invoke(@this, ptr, *(void**)mylast);
				Destroy_range_jjcob5a.Invoke(ptr, *(void**)mylast, al);
				*(void**)mylast = ptr;
			}
			else
			{
				if ((ulong)Newsize <= (ulong)num)
				{
					return;
				}
				if ((ulong)Newsize > (ulong)((long)((std_Vector_val_p59sy9d*)myval)->Myend - (long)(nuint)(*(nint*)myfirst)))
				{
					Resize_reallocate_dt5hjdb.Invoke(@this, Newsize, Val);
					if (ExceptionInfo.Current == null)
					{
					}
				}
				else
				{
					void* ptr2 = *(void**)mylast;
					*(void**)mylast = Uninitialized_value_construct_n_cxm3ryd.Invoke(ptr2, Newsize - num, al);
					Orphan_range_334quvb.Invoke(@this, ptr2, ptr2);
				}
			}
		}
	}
}
