using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?allocate@?$allocator@I@std@@QEAAPEAI_K@Z")]
[DemangledName("public: unsigned int * __cdecl std::allocator<unsigned int>::allocate(unsigned __int64)")]
[CleanName("allocate")]
internal static partial class allocate_wor4ptd
{
	private partial struct LocalVariables
	{
		public long Instruction_0;

		public unsafe void* Instruction_1;
	}

	public unsafe static void* Invoke(void* @this, long Count)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = Count;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = @this;
		_ = startFrame.GetLocalsRef<LocalVariables>().Instruction_1;
		long bytes = Get_size_of_n_rdjmi2b.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_0);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		void* result = Allocate_i4jzs2a.Invoke(bytes);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
