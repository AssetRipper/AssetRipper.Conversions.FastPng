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

	public unsafe static void Invoke(void* @this, long Newsize, void* Val)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		void* ptr = null;
		void* ptr2 = null;
		void* ptr3 = null;
		void* ptr4 = null;
		long num = 0L;
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = 0L;
		void* ptr5 = null;
		void* ptr6 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = default(std_vector_unsigned_char_Reallocation_guard);
		void* ptr7 = null;
		unchecked
		{
			if ((ulong)Newsize > (ulong)max_size_2yjes5b.Invoke(@this))
			{
				Xlength_zpuxaia.Invoke();
				throw null;
			}
			ptr = Getal_jms5hzb.Invoke(@this);
			ptr2 = &((std_vector*)@this)->field_0.field_0;
			ptr3 = &((std_Vector_val*)ptr2)->field_0;
			ptr4 = &((std_Vector_val*)ptr2)->field_1;
			num = (long)(nuint)(*(nint*)ptr4) - (long)(nuint)(*(nint*)ptr3);
			long field_ = Calculate_growth_scmxisc.Invoke(@this, Newsize);
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_;
			void* ptr8 = Allocate_at_least_helper_wikabbc.Invoke(ptr, &startFrame.GetLocalsPointer<LocalVariables>()->field_0);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			ptr5 = ptr8;
			ptr6 = (byte*)ptr5 + num;
			startFrame.GetLocalsPointer<LocalVariables>()->field_1.field_0 = ptr;
			startFrame.GetLocalsPointer<LocalVariables>()->field_1.field_1 = ptr5;
			startFrame.GetLocalsPointer<LocalVariables>()->field_1.field_2 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
			startFrame.GetLocalsPointer<LocalVariables>()->field_1.field_3 = ptr6;
			startFrame.GetLocalsPointer<LocalVariables>()->field_1.field_4 = ptr6;
			ptr7 = &startFrame.GetLocalsPointer<LocalVariables>()->field_1.field_4;
			void* ptr9 = Uninitialized_value_construct_n_cxm3ryd.Invoke(ptr6, Newsize - num, ptr);
			if (ExceptionInfo.Current == null)
			{
				*(void**)ptr7 = ptr9;
				Uninitialized_move_vysyj4a.Invoke(Al: ptr, Dest: ptr5, Last: *(void**)ptr4, First: *(void**)ptr3);
				if (ExceptionInfo.Current == null)
				{
					startFrame.GetLocalsPointer<LocalVariables>()->field_1.field_1 = null;
					Change_array_k9lpzqa.Invoke(@this, ptr5, Newsize, startFrame.GetLocalsPointer<LocalVariables>()->field_0);
					Reallocation_guard_Destructor_9xb7gra.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_1);
					StackFrameList.Current.Clear(startFrame);
					return;
				}
			}
			ExceptionInfo? current = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			Reallocation_guard_Destructor_9xb7gra.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_1);
			ExceptionInfo.Current = current;
		}
	}
}
