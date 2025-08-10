using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Buy_nonzero@?$vector@IV?$allocator@I@std@@@std@@AEAAX_K@Z")]
[DemangledName("private: void __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::_Buy_nonzero(unsigned __int64)")]
internal static partial class Buy_nonzero
{
	private partial struct LocalVariables
	{
		public long Instruction_0;

		public unsafe void* Instruction_1;
	}

	public unsafe static void Invoke(void* @this, long Newcapacity)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = Newcapacity;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = @this;
		void* instruction_ = startFrame.GetLocalsRef<LocalVariables>().Instruction_1;
		if (unchecked((ulong)startFrame.GetLocalsRef<LocalVariables>().Instruction_0 > (ulong)max_size_qdwnpha.Invoke(instruction_)))
		{
			Xlength_nubzgpc.Invoke();
			throw null;
		}
		Buy_raw.Invoke(instruction_, startFrame.GetLocalsRef<LocalVariables>().Instruction_0);
		if (ExceptionInfo.Current == null)
		{
			StackFrameList.Current.Clear(startFrame);
		}
	}
}
