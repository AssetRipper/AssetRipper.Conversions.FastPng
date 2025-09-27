using System;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Resize@U_Value_init_tag@std@@@?$vector@_KV?$allocator@_K@std@@@std@@AEAAX_KAEBU_Value_init_tag@1@@Z")]
[DemangledName("private: void __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Resize<struct std::_Value_init_tag>(unsigned __int64, struct std::_Value_init_tag const &)")]
[CleanName("Resize")]
internal static partial class Resize_2s9rs9d
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [MangledName("_Newsize")][NativeType("unsigned __int64")] long Newsize, [MangledName("_Val")][NativeType("struct std::_Value_init_tag const &")] void* Val)
	{
		void* al = Getal_kuj7nva.Invoke(@this);
		unchecked
		{
			void* myval = &((std_vector_mvt3mha*)@this)->Mypair.Myval2;
			void* myfirst = &((std_Vector_val_zgi5p7d*)myval)->Myfirst;
			void* mylast = &((std_Vector_val_zgi5p7d*)myval)->Mylast;
			long num = ((long)(nuint)(*(nint*)mylast) - (long)(nuint)(*(nint*)myfirst)) / 8L;
			if ((ulong)Newsize < (ulong)num)
			{
				void* ptr = (void*)((nint)(*(IntPtr*)myfirst) + (nint)Newsize * 8);
				Orphan_range_qciws4b.Invoke(@this, ptr, *(void**)mylast);
				Destroy_range_qbzp7xb.Invoke(ptr, *(void**)mylast, al);
				*(void**)mylast = ptr;
			}
			else
			{
				if ((ulong)Newsize <= (ulong)num)
				{
					return;
				}
				if ((ulong)Newsize > (ulong)(((long)((std_Vector_val_zgi5p7d*)myval)->Myend - (long)(nuint)(*(nint*)myfirst)) / 8L))
				{
					Resize_reallocate_ytnsorc.Invoke(@this, Newsize, Val);
					if (ExceptionInfo.Current == null)
					{
					}
				}
				else
				{
					void* ptr2 = *(void**)mylast;
					*(void**)mylast = Uninitialized_value_construct_n_hqowyoc.Invoke(ptr2, Newsize - num, al);
					Orphan_range_qciws4b.Invoke(@this, ptr2, ptr2);
				}
			}
		}
	}
}
