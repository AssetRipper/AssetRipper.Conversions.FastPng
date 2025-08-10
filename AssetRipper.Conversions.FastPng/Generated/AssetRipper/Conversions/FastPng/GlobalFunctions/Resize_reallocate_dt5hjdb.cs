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
		public unsafe void* Instruction_0;

		public long Instruction_1;

		public unsafe void* Instruction_2;

		public unsafe void* Instruction_3;

		public unsafe void* Instruction_4;

		public unsafe void* Instruction_5;

		public unsafe void* Instruction_6;

		public long Instruction_7;

		public long Instruction_8;

		public unsafe void* Instruction_9;

		public unsafe void* Instruction_10;

		public std_vector_unsigned_char_Reallocation_guard Instruction_11;

		public unsafe void* Instruction_12;
	}

	public unsafe static void Invoke(void* @this, long Newsize, void* Val)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		long* count = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_8;
		std_vector_unsigned_char_Reallocation_guard* ptr = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_11;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = Val;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = Newsize;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = @this;
		void* instruction_ = startFrame.GetLocalsRef<LocalVariables>().Instruction_2;
		unchecked
		{
			if ((ulong)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 > (ulong)max_size_2yjes5b.Invoke(instruction_))
			{
				Xlength_zpuxaia.Invoke();
				throw null;
			}
			void* instruction_2 = Getal_jms5hzb.Invoke(instruction_);
			startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = instruction_2;
			std_Vector_val* field_ = &((std_vector*)instruction_)->field_0.field_0;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_4 = field_;
			void** field_2 = &((std_Vector_val*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4)->field_0;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_5 = field_2;
			void** field_3 = &((std_Vector_val*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4)->field_1;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_6 = field_3;
			void* instruction_3 = *(void**)startFrame.GetLocalsRef<LocalVariables>().Instruction_6;
			void* instruction_4 = *(void**)startFrame.GetLocalsRef<LocalVariables>().Instruction_5;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = (long)instruction_3 - (long)instruction_4;
			long instruction_5 = Calculate_growth_scmxisc.Invoke(instruction_, startFrame.GetLocalsRef<LocalVariables>().Instruction_1);
			startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_5;
			void* instruction_6 = Allocate_at_least_helper_wikabbc.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_3, count);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_6;
			void* instruction_7 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
			long instruction_8 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = (byte*)instruction_7 + instruction_8;
			void** field_4 = &ptr->field_0;
			*field_4 = startFrame.GetLocalsRef<LocalVariables>().Instruction_3;
			void** field_5 = &ptr->field_1;
			*field_5 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
			long* field_6 = &ptr->field_2;
			*field_6 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
			void** field_7 = &ptr->field_3;
			*field_7 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
			void** field_8 = &ptr->field_4;
			*field_8 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
			void** field_9 = &ptr->field_4;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = field_9;
			void* ptr2 = Uninitialized_value_construct_n_cxm3ryd.Invoke(Al: startFrame.GetLocalsRef<LocalVariables>().Instruction_3, Count: startFrame.GetLocalsRef<LocalVariables>().Instruction_1 - startFrame.GetLocalsRef<LocalVariables>().Instruction_7, First: startFrame.GetLocalsRef<LocalVariables>().Instruction_10);
			if (ExceptionInfo.Current == null)
			{
				*(void**)startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = ptr2;
				Uninitialized_move_vysyj4a.Invoke(Al: startFrame.GetLocalsRef<LocalVariables>().Instruction_3, Dest: startFrame.GetLocalsRef<LocalVariables>().Instruction_9, Last: *(void**)startFrame.GetLocalsRef<LocalVariables>().Instruction_6, First: *(void**)startFrame.GetLocalsRef<LocalVariables>().Instruction_5);
				if (ExceptionInfo.Current == null)
				{
					ptr->field_1 = null;
					Change_array_k9lpzqa.Invoke(Newcapacity: startFrame.GetLocalsRef<LocalVariables>().Instruction_8, Newsize: startFrame.GetLocalsRef<LocalVariables>().Instruction_1, @this: instruction_, Newvec: startFrame.GetLocalsRef<LocalVariables>().Instruction_9);
					Reallocation_guard_Destructor_9xb7gra.Invoke(ptr);
					StackFrameList.Current.Clear(startFrame);
					return;
				}
			}
			ExceptionInfo current = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			Reallocation_guard_Destructor_9xb7gra.Invoke(ptr);
			ExceptionInfo.Current = current;
		}
	}
}
