using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?resize@?$vector@EV?$allocator@E@std@@@std@@QEAAX_K@Z")]
[DemangledName("public: void __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::resize(unsigned __int64)")]
[CleanName("resize")]
internal static partial class resize_wwmwtsa
{
	private partial struct LocalVariables
	{
		public long Instruction_0;

		public unsafe void* Instruction_1;

		public std_Value_init_tag Instruction_2;
	}

	public unsafe static void Invoke(void* @this, long Newsize)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		std_Value_init_tag* val = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_2;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = Newsize;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = @this;
		Resize_p4x2rua.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_1, startFrame.GetLocalsRef<LocalVariables>().Instruction_0, val);
		if (ExceptionInfo.Current == null)
		{
			StackFrameList.Current.Clear(startFrame);
		}
	}
}
