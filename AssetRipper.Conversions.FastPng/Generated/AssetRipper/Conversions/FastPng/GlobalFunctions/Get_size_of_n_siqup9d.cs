using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Get_size_of_n@$07@std@@YA_K_K@Z")]
[DemangledName("unsigned __int64 __cdecl std::_Get_size_of_n<8>(unsigned __int64)")]
[CleanName("Get_size_of_n")]
internal static partial class Get_size_of_n_siqup9d
{
	private partial struct LocalVariables
	{
		public long Instruction_0;

		public sbyte Instruction_1;

		public long Instruction_2;
	}

	public static long Invoke(long Count)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = Count;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = 1;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = 2305843009213693951L;
		unchecked
		{
			if ((ulong)startFrame.GetLocalsRef<LocalVariables>().Instruction_0 > 2305843009213693951uL)
			{
				Throw_bad_array_new_length.Invoke();
				if (ExceptionInfo.Current != null)
				{
					return 0L;
				}
				throw null;
			}
			long result = startFrame.GetLocalsRef<LocalVariables>().Instruction_0 * 8L;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
