using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?allocate@?$allocator@_K@std@@QEAAPEA_K_K@Z")]
[DemangledName("public: unsigned __int64 * __cdecl std::allocator<unsigned __int64>::allocate(unsigned __int64)")]
[CleanName("allocate")]
internal static partial class allocate_4vpkydd
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
		long bytes = Get_size_of_n_siqup9d.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_0);
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
