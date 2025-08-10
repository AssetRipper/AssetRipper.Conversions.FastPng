using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??0?$vector@IV?$allocator@I@std@@@std@@QEAA@_KAEBV?$allocator@I@1@@Z")]
[DemangledName("public: __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::vector<unsigned int, class std::allocator<unsigned int>>(unsigned __int64, class std::allocator<unsigned int> const &)")]
internal static partial class vector_unsigned_int_class_std_allocator_unsigned_int_Constructor
{
	private partial struct LocalVariables
	{
		public unsafe void* Instruction_0;

		public long Instruction_1;

		public unsafe void* Instruction_2;

		public std_One_then_variadic_args_t Instruction_3;
	}

	public unsafe static void* Invoke(void* @this, long Count, void* Al)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		std_One_then_variadic_args_t* ptr = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_3;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = Al;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = Count;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = @this;
		void* instruction_ = startFrame.GetLocalsRef<LocalVariables>().Instruction_2;
		Compressed_pair_class_std_allocator_unsigned_int_class_std_Vector_val_struct_std_Simple_types_unsigned_int_1_Constructor.Invoke(&unchecked((std_vector_0*)instruction_)->field_0, Val1: startFrame.GetLocalsRef<LocalVariables>().Instruction_0, coerce: ptr->field_0);
		Construct_n.Invoke(instruction_, startFrame.GetLocalsRef<LocalVariables>().Instruction_1);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		StackFrameList.Current.Clear(startFrame);
		return instruction_;
	}
}
