using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?resize@?$vector@_KV?$allocator@_K@std@@@std@@QEAAX_K@Z")]
[DemangledName("public: void __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::resize(unsigned __int64)")]
[CleanName("resize")]
internal static partial class resize_d4pmvud
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
		Resize_2s9rs9d.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_1, startFrame.GetLocalsRef<LocalVariables>().Instruction_0, val);
		if (ExceptionInfo.Current == null)
		{
			StackFrameList.Current.Clear(startFrame);
		}
	}
}
