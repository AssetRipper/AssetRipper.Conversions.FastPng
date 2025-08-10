using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Allocate_manually_vector_aligned@U_Default_allocate_traits@std@@@std@@YAPEAX_K@Z")]
[DemangledName("void * __cdecl std::_Allocate_manually_vector_aligned<struct std::_Default_allocate_traits>(unsigned __int64)")]
internal static partial class Allocate_manually_vector_aligned
{
	private partial struct LocalVariables
	{
		public long Instruction_0;

		public long Instruction_1;

		public long Instruction_2;

		public unsafe void* Instruction_3;
	}

	public unsafe static void* Invoke(long Bytes)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = Bytes;
		long instruction_ = startFrame.GetLocalsRef<LocalVariables>().Instruction_0;
		unchecked
		{
			startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = 39L + instruction_;
			if ((ulong)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 <= (ulong)startFrame.GetLocalsRef<LocalVariables>().Instruction_0)
			{
				Throw_bad_array_new_length.Invoke();
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				throw null;
			}
			void* ptr = Allocate_ifu7fia.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_1);
			startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = (long)ptr;
			if (startFrame.GetLocalsRef<LocalVariables>().Instruction_2 == 0L)
			{
				invoke_watson.Invoke(null, null, null, 0, 0L);
				throw null;
			}
			long instruction_2 = startFrame.GetLocalsRef<LocalVariables>().Instruction_2;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = (void*)((instruction_2 + 39L) & -32L);
			long instruction_3 = startFrame.GetLocalsRef<LocalVariables>().Instruction_2;
			*(long*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 + -8) = instruction_3;
			void* instruction_4 = startFrame.GetLocalsRef<LocalVariables>().Instruction_3;
			StackFrameList.Current.Clear(startFrame);
			return instruction_4;
		}
	}
}
