using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Buy_raw@?$vector@IV?$allocator@I@std@@@std@@AEAAX_K@Z")]
[DemangledName("private: void __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::_Buy_raw(unsigned __int64)")]
internal static partial class Buy_raw
{
	private partial struct LocalVariables
	{
		public long Instruction_0;

		public unsafe void* Instruction_1;

		public unsafe void* Instruction_2;

		public unsafe void* Instruction_3;

		public unsafe void* Instruction_4;

		public unsafe void* Instruction_5;

		public unsafe void* Instruction_6;
	}

	public unsafe static void Invoke(void* @this, long Newcapacity)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		long* count = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_0;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = Newcapacity;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = @this;
		void* instruction_ = startFrame.GetLocalsRef<LocalVariables>().Instruction_1;
		unchecked
		{
			std_Vector_val_4* field_ = &((std_vector_0*)instruction_)->field_0.field_0;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = field_;
			void** field_2 = &((std_Vector_val_4*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)->field_0;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = field_2;
			void** field_3 = &((std_Vector_val_4*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)->field_1;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_4 = field_3;
			void** field_4 = &((std_Vector_val_4*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)->field_2;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_5 = field_4;
			void* instruction_2 = Allocate_at_least_helper_22hwyxd.Invoke(Getal_t2pmqoc.Invoke(instruction_), count);
			if (ExceptionInfo.Current == null)
			{
				startFrame.GetLocalsRef<LocalVariables>().Instruction_6 = instruction_2;
				void* instruction_3 = startFrame.GetLocalsRef<LocalVariables>().Instruction_6;
				*(void**)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = instruction_3;
				void* instruction_4 = startFrame.GetLocalsRef<LocalVariables>().Instruction_6;
				*(void**)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 = instruction_4;
				void* instruction_5 = startFrame.GetLocalsRef<LocalVariables>().Instruction_6;
				long instruction_6 = startFrame.GetLocalsRef<LocalVariables>().Instruction_0;
				*(byte**)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 = (byte*)instruction_5 + (nint)instruction_6 * 4;
				StackFrameList.Current.Clear(startFrame);
			}
		}
	}
}
