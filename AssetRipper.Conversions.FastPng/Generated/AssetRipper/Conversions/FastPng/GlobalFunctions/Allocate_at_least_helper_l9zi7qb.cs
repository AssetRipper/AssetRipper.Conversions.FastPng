using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Allocate_at_least_helper@V?$allocator@_K@std@@@std@@YAPEA_KAEAV?$allocator@_K@0@AEA_K@Z")]
[DemangledName("unsigned __int64 * __cdecl std::_Allocate_at_least_helper<class std::allocator<unsigned __int64>>(class std::allocator<unsigned __int64> &, unsigned __int64 &)")]
[CleanName("Allocate_at_least_helper")]
internal static partial class Allocate_at_least_helper_l9zi7qb
{
	private partial struct LocalVariables
	{
		public unsafe void* Instruction_0;

		public unsafe void* Instruction_1;
	}

	public unsafe static void* Invoke(void* Al, void* Count)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = Count;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = Al;
		void* result = allocate_4vpkydd.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_1, *unchecked((long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_0));
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
