using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Construct_n@$$V@?$vector@IV?$allocator@I@std@@@std@@AEAAX_K@Z")]
[DemangledName("private: void __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::_Construct_n<>(unsigned __int64)")]
internal static partial class Construct_n
{
	private partial struct LocalVariables
	{
		public long Instruction_0;

		public unsafe void* Instruction_1;

		public unsafe void* Instruction_2;

		public unsafe void* Instruction_3;

		public std_Fake_allocator Instruction_4;

		public unsafe void* Instruction_5;

		public std_Fake_proxy_ptr_impl Instruction_6;

		public std_Tidy_guard Instruction_7;
	}

	public unsafe static void Invoke(void* @this, long Count)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		std_Fake_allocator* instruction_ = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_4;
		std_Fake_proxy_ptr_impl* ptr = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_6;
		std_Tidy_guard* ptr2 = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_7;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = Count;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = @this;
		void* instruction_2 = startFrame.GetLocalsRef<LocalVariables>().Instruction_1;
		void* instruction_3 = Getal_t2pmqoc.Invoke(instruction_2);
		startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = instruction_3;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = instruction_;
		unchecked
		{
			std_Vector_val_4* field_ = &((std_vector_0*)instruction_2)->field_0.field_0;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_5 = field_;
			Fake_proxy_ptr_impl_Constructor.Invoke(parameter_2: startFrame.GetLocalsRef<LocalVariables>().Instruction_5, @this: ptr, parameter_1: startFrame.GetLocalsRef<LocalVariables>().Instruction_3);
			if (startFrame.GetLocalsRef<LocalVariables>().Instruction_0 != 0L)
			{
				Buy_nonzero.Invoke(instruction_2, startFrame.GetLocalsRef<LocalVariables>().Instruction_0);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				ptr2->field_0 = instruction_2;
				void* field_2 = Uninitialized_value_construct_n_zg4iwva.Invoke(Al: startFrame.GetLocalsRef<LocalVariables>().Instruction_2, Count: startFrame.GetLocalsRef<LocalVariables>().Instruction_0, First: ((std_Vector_val_4*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)->field_0);
				if (ExceptionInfo.Current != null)
				{
					ExceptionInfo current = ExceptionInfo.Current;
					ExceptionInfo.Current = null;
					Tidy_guard_class_std_vector_unsigned_int_class_std_allocator_unsigned_int_Destructor.Invoke(ptr2);
					ExceptionInfo.Current = current;
					return;
				}
				((std_Vector_val_4*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)->field_1 = field_2;
				ptr2->field_0 = null;
				Tidy_guard_class_std_vector_unsigned_int_class_std_allocator_unsigned_int_Destructor.Invoke(ptr2);
			}
			Release.Invoke(ptr);
			StackFrameList.Current.Clear(startFrame);
		}
	}
}
