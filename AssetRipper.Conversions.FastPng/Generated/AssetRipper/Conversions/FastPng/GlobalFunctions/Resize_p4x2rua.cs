using System;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Resize@U_Value_init_tag@std@@@?$vector@EV?$allocator@E@std@@@std@@AEAAX_KAEBU_Value_init_tag@1@@Z")]
[DemangledName("private: void __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Resize<struct std::_Value_init_tag>(unsigned __int64, struct std::_Value_init_tag const &)")]
[CleanName("Resize")]
internal static partial class Resize_p4x2rua
{
	public unsafe static void Invoke(void* @this, long Newsize, void* Val)
	{
		void* ptr = null;
		long num = 0L;
		void* ptr2 = null;
		void* al = Getal_jms5hzb.Invoke(@this);
		unchecked
		{
			void* field_ = &((std_vector*)@this)->field_0.field_0;
			void* field_2 = &((std_Vector_val*)field_)->field_0;
			void* field_3 = &((std_Vector_val*)field_)->field_1;
			long num2 = (long)(nuint)(*(nint*)field_3) - (long)(nuint)(*(nint*)field_2);
			if ((ulong)Newsize < (ulong)num2)
			{
				ptr = (void*)((nint)(*(IntPtr*)field_2) + (nint)Newsize);
				Orphan_range_334quvb.Invoke(@this, ptr, *(void**)field_3);
				Destroy_range_jjcob5a.Invoke(ptr, *(void**)field_3, al);
				*(void**)field_3 = ptr;
			}
			else
			{
				if ((ulong)Newsize <= (ulong)num2)
				{
					return;
				}
				if ((ulong)Newsize > (ulong)((long)((std_Vector_val*)field_)->field_2 - (long)(nuint)(*(nint*)field_2)))
				{
					Resize_reallocate_dt5hjdb.Invoke(@this, Newsize, Val);
					if (ExceptionInfo.Current == null)
					{
					}
				}
				else
				{
					ptr2 = *(void**)field_3;
					*(void**)field_3 = Uninitialized_value_construct_n_cxm3ryd.Invoke(ptr2, Newsize - num2, al);
					Orphan_range_334quvb.Invoke(@this, ptr2, ptr2);
				}
			}
		}
	}
}
