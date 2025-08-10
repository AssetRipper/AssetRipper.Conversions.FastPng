using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?allocate@?$allocator@E@std@@QEAAPEAE_K@Z")]
[DemangledName("public: unsigned char * __cdecl std::allocator<unsigned char>::allocate(unsigned __int64)")]
[CleanName("allocate")]
internal static partial class allocate_qfop4bd
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
		void* result = Allocate_i4jzs2a.Invoke(Get_size_of_n_iqtw9sb.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_0));
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
