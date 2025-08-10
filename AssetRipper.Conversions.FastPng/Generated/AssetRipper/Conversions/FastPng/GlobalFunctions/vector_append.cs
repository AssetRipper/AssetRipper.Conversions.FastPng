using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?vector_append@fpng@@YAXAEAV?$vector@EV?$allocator@E@std@@@std@@PEBX_K@Z")]
[DemangledName("void __cdecl fpng::vector_append(class std::vector<unsigned char, class std::allocator<unsigned char>> &, void const *, unsigned __int64)")]
internal static partial class vector_append
{
	private partial struct LocalVariables
	{
		public long Instruction_0;

		public unsafe void* Instruction_1;

		public unsafe void* Instruction_2;

		public long Instruction_3;
	}

	public unsafe static void Invoke(void* buf, void* pData, long len)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = len;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = pData;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = buf;
		unchecked
		{
			if (startFrame.GetLocalsRef<LocalVariables>().Instruction_0 != 0L)
			{
				long instruction_ = size_4io4p4d.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2);
				startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = instruction_;
				resize_wwmwtsa.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2, startFrame.GetLocalsRef<LocalVariables>().Instruction_3 + startFrame.GetLocalsRef<LocalVariables>().Instruction_0);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				llvm_memcpy_p0_p0_i64.Invoke((byte*)data_efhnzgd.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2) + startFrame.GetLocalsRef<LocalVariables>().Instruction_3, startFrame.GetLocalsRef<LocalVariables>().Instruction_1, startFrame.GetLocalsRef<LocalVariables>().Instruction_0, isVolatile: false);
			}
			StackFrameList.Current.Clear(startFrame);
		}
	}
}
