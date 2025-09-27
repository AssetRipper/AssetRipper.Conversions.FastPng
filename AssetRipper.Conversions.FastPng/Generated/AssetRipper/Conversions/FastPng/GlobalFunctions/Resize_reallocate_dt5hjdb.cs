using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Resize_reallocate@U_Value_init_tag@std@@@?$vector@EV?$allocator@E@std@@@std@@AEAAX_KAEBU_Value_init_tag@1@@Z")]
[DemangledName("private: void __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Resize_reallocate<struct std::_Value_init_tag>(unsigned __int64, struct std::_Value_init_tag const &)")]
[CleanName("Resize_reallocate")]
internal static partial class Resize_reallocate_dt5hjdb
{
	private partial struct LocalVariables
	{
		public long field_0;

		public std_vector_unsigned_char_Reallocation_guard field_1;
	}

	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [MangledName("_Newsize")][NativeType("unsigned __int64")] long Newsize, [MangledName("_Val")][NativeType("struct std::_Value_init_tag const &")] void* Val)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = 0L;
		localsPointer->field_1 = default(std_vector_unsigned_char_Reallocation_guard);
		unchecked
		{
			if ((ulong)Newsize > (ulong)max_size_2yjes5b.Invoke(@this))
			{
				Xlength_zpuxaia.Invoke();
				throw null;
			}
			void* ptr = Getal_jms5hzb.Invoke(@this);
			void* myval = &((std_vector_7uge3hb*)@this)->Mypair.Myval2;
			void* myfirst = &((std_Vector_val_p59sy9d*)myval)->Myfirst;
			void* mylast = &((std_Vector_val_p59sy9d*)myval)->Mylast;
			long num = (long)(nuint)(*(nint*)mylast) - (long)(nuint)(*(nint*)myfirst);
			localsPointer->field_0 = Calculate_growth_scmxisc.Invoke(@this, Newsize);
			void* ptr2 = Allocate_at_least_helper_wikabbc.Invoke(ptr, &localsPointer->field_0);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			void* ptr3 = ptr2;
			void* ptr4 = (byte*)ptr3 + num;
			localsPointer->field_1.field_0 = ptr;
			localsPointer->field_1.field_1 = ptr3;
			localsPointer->field_1.field_2 = localsPointer->field_0;
			localsPointer->field_1.field_3 = ptr4;
			localsPointer->field_1.field_4 = ptr4;
			void* field_ = &localsPointer->field_1.field_4;
			void* ptr5 = Uninitialized_value_construct_n_cxm3ryd.Invoke(ptr4, Newsize - num, ptr);
			if (ExceptionInfo.Current == null)
			{
				*(void**)field_ = ptr5;
				Uninitialized_move_vysyj4a.Invoke(Al: ptr, Dest: ptr3, Last: *(void**)mylast, First: *(void**)myfirst);
				if (ExceptionInfo.Current == null)
				{
					localsPointer->field_1.field_1 = null;
					Change_array_k9lpzqa.Invoke(@this, ptr3, Newsize, localsPointer->field_0);
					Reallocation_guard_Destructor_9xb7gra.Invoke(&localsPointer->field_1);
					StackFrameList.Current.Clear(startFrame);
					return;
				}
			}
			ExceptionInfo? current = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			Reallocation_guard_Destructor_9xb7gra.Invoke(&localsPointer->field_1);
			ExceptionInfo.Current = current;
		}
	}
}
