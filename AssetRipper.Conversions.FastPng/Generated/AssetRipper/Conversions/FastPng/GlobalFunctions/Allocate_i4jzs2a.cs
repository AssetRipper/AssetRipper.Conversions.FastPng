using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Allocate@$0BA@U_Default_allocate_traits@std@@@std@@YAPEAX_K@Z")]
[DemangledName("void * __cdecl std::_Allocate<16, struct std::_Default_allocate_traits>(unsigned __int64)")]
[CleanName("Allocate")]
internal static partial class Allocate_i4jzs2a
{
	private partial struct LocalVariables
	{
		public unsafe void* Instruction_0;

		public long Instruction_1;
	}

	public unsafe static void* Invoke(long Bytes)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = Bytes;
		if (startFrame.GetLocalsRef<LocalVariables>().Instruction_1 == 0L)
		{
			startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = null;
		}
		else if (unchecked((ulong)startFrame.GetLocalsRef<LocalVariables>().Instruction_1) >= 4096uL)
		{
			void* instruction_ = Allocate_manually_vector_aligned.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_1);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = instruction_;
		}
		else
		{
			void* instruction_2 = Allocate_ifu7fia.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_1);
			startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = instruction_2;
		}
		void* instruction_3 = startFrame.GetLocalsRef<LocalVariables>().Instruction_0;
		StackFrameList.Current.Clear(startFrame);
		return instruction_3;
	}
}
