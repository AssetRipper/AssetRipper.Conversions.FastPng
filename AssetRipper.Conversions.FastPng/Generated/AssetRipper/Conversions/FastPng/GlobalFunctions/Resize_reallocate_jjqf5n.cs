using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Resize_reallocate@U_Value_init_tag@std@@@?$vector@_KV?$allocator@_K@std@@@std@@AEAAX_KAEBU_Value_init_tag@1@@Z")]
[DemangledName("private: void __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Resize_reallocate<struct std::_Value_init_tag>(unsigned __int64, struct std::_Value_init_tag const &)")]
[CleanName("Resize_reallocate")]
internal static partial class Resize_reallocate_jjqf5n
{
	private partial struct LocalVariables
	{
		public long field_0;

		public std_vector_unsigned_long_long_Reallocation_guard field_1;
	}

	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [MangledName("_Newsize")][NativeType("unsigned __int64")] long Newsize, [MangledName("_Val")][NativeType("struct std::_Value_init_tag const &")] void* Val)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = 0L;
		localsPointer->field_1 = default(std_vector_unsigned_long_long_Reallocation_guard);
		unchecked
		{
			if ((ulong)Newsize > (ulong)max_size_t88hhi.Invoke(@this))
			{
				Xlength_4tkvw9.Invoke();
				throw null;
			}
			void* ptr = Getal_ie7hg9.Invoke(@this);
			void* myval = &((std_vector_ucmdxb*)@this)->Mypair.Myval2;
			void* myfirst = &((std_Vector_val_i7igbu*)myval)->Myfirst;
			void* mylast = &((std_Vector_val_i7igbu*)myval)->Mylast;
			long num = ((long)(nuint)(*(nint*)mylast) - (long)(nuint)(*(nint*)myfirst)) / 8L;
			localsPointer->field_0 = Calculate_growth_2ntm6t.Invoke(@this, Newsize);
			void* ptr2 = Allocate_at_least_helper_2ny77t.Invoke(ptr, &localsPointer->field_0);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			void* ptr3 = ptr2;
			void* ptr4 = (byte*)ptr3 + (nint)num * 8;
			localsPointer->field_1.field_0 = ptr;
			localsPointer->field_1.field_1 = ptr3;
			localsPointer->field_1.field_2 = localsPointer->field_0;
			localsPointer->field_1.field_3 = ptr4;
			localsPointer->field_1.field_4 = ptr4;
			void* field_ = &localsPointer->field_1.field_4;
			void* ptr5 = Uninitialized_value_construct_n_e2x86x.Invoke(ptr4, Newsize - num, ptr);
			if (ExceptionInfo.Current == null)
			{
				*(void**)field_ = ptr5;
				Uninitialized_move_5rztdf.Invoke(Al: ptr, Dest: ptr3, Last: *(void**)mylast, First: *(void**)myfirst);
				if (ExceptionInfo.Current == null)
				{
					localsPointer->field_1.field_1 = null;
					Change_array_nieg7e.Invoke(@this, ptr3, Newsize, localsPointer->field_0);
					Reallocation_guard_Destructor_fq2gtv.Invoke(&localsPointer->field_1);
					StackFrameList.Current.Clear(startFrame);
					return;
				}
			}
			ExceptionInfo? current = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			Reallocation_guard_Destructor_fq2gtv.Invoke(&localsPointer->field_1);
			ExceptionInfo.Current = current;
		}
	}
}
