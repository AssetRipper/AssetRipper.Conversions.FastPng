using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?apply_filter@fpng@@YAXIHHIIPEBE0PEAE@Z")]
[DemangledName("void __cdecl fpng::apply_filter(unsigned int, int, int, unsigned int, unsigned int, unsigned char const *, unsigned char const *, unsigned char *)")]
internal static partial class apply_filter
{
	private partial struct LocalVariables
	{
		public unsafe void* Instruction_0;

		public unsafe void* Instruction_1;

		public unsafe void* Instruction_2;

		public int Instruction_3;

		public int Instruction_4;

		public int Instruction_5;

		public int Instruction_6;

		public int Instruction_7;

		public int Instruction_8;

		public int Instruction_9;
	}

	public unsafe static void Invoke(int filter, int w, int h, int num_chans, int bpl, void* pSrc, void* pPrev_src, void* pDst)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = pDst;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = pPrev_src;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = pSrc;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = bpl;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_4 = num_chans;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_5 = h;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_6 = w;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = filter;
		unchecked
		{
			switch (startFrame.GetLocalsRef<LocalVariables>().Instruction_7)
			{
			case 0:
			{
				void* instruction_10 = startFrame.GetLocalsRef<LocalVariables>().Instruction_0;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = (byte*)instruction_10 + 1;
				*(sbyte*)instruction_10 = 0;
				llvm_memcpy_p0_p0_i64.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_0, startFrame.GetLocalsRef<LocalVariables>().Instruction_2, (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_3, isVolatile: false);
				break;
			}
			case 2:
			{
				if (startFrame.GetLocalsRef<LocalVariables>().Instruction_1 != null)
				{
					_ = -1;
				}
				else
				{
					wassert.Invoke(String_uc52kza.__pointer, String_uxbkrtb.__pointer, 1607);
					if (ExceptionInfo.Current != null)
					{
						return;
					}
					_ = 0;
				}
				void* instruction_ = startFrame.GetLocalsRef<LocalVariables>().Instruction_0;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = (byte*)instruction_ + 1;
				*(sbyte*)instruction_ = 2;
				if (startFrame.GetLocalsRef<LocalVariables>().Instruction_4 == 3)
				{
					startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = 0;
					while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)
					{
						int num;
						checked
						{
							num = unchecked((byte)(*(sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)) - unchecked((byte)(*(sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1));
						}
						*(sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = (sbyte)num;
						int num2;
						checked
						{
							num2 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)[1L]) - unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)[1L]);
						}
						((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_0)[1L] = (sbyte)num2;
						int num3;
						checked
						{
							num3 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)[2L]) - unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)[2L]);
						}
						((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_0)[2L] = (sbyte)num3;
						void* instruction_2 = startFrame.GetLocalsRef<LocalVariables>().Instruction_2;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = (byte*)instruction_2 + 3L;
						void* instruction_3 = startFrame.GetLocalsRef<LocalVariables>().Instruction_1;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = (byte*)instruction_3 + 3L;
						void* instruction_4 = startFrame.GetLocalsRef<LocalVariables>().Instruction_0;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = (byte*)instruction_4 + 3L;
						int instruction_5 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_5 + 1;
					}
					break;
				}
				startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = 0;
				while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)
				{
					int num4;
					checked
					{
						num4 = unchecked((byte)(*(sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)) - unchecked((byte)(*(sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1));
					}
					*(sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = (sbyte)num4;
					int num5;
					checked
					{
						num5 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)[1L]) - unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)[1L]);
					}
					((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_0)[1L] = (sbyte)num5;
					int num6;
					checked
					{
						num6 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)[2L]) - unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)[2L]);
					}
					((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_0)[2L] = (sbyte)num6;
					int num7;
					checked
					{
						num7 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)[3L]) - unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)[3L]);
					}
					((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_0)[3L] = (sbyte)num7;
					void* instruction_6 = startFrame.GetLocalsRef<LocalVariables>().Instruction_2;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = (byte*)instruction_6 + 4L;
					void* instruction_7 = startFrame.GetLocalsRef<LocalVariables>().Instruction_1;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = (byte*)instruction_7 + 4L;
					void* instruction_8 = startFrame.GetLocalsRef<LocalVariables>().Instruction_0;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = (byte*)instruction_8 + 4L;
					int instruction_9 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_9 + 1;
				}
				break;
			}
			default:
				wassert.Invoke(String_kdrammb.__pointer, String_uxbkrtb.__pointer, 1657);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				break;
			}
			StackFrameList.Current.Clear(startFrame);
		}
	}
}
