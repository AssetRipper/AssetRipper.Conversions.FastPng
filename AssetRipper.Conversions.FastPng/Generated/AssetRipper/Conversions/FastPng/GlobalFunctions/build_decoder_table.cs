using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?build_decoder_table@fpng@@YA_NIPEAEPEAI@Z")]
[DemangledName("bool __cdecl fpng::build_decoder_table(unsigned int, unsigned char *, unsigned int *)")]
internal static partial class build_decoder_table
{
	private partial struct LocalVariables
	{
		public bool Instruction_0;

		public unsafe void* Instruction_1;

		public unsafe void* Instruction_2;

		public int Instruction_3;

		public InlineArray_16_vqkfj7a Instruction_4;

		public int Instruction_5;

		public InlineArray_17_vqkfj7a Instruction_6;

		public int Instruction_7;

		public int Instruction_8;

		public int Instruction_9;

		public int Instruction_10;

		public InlineArray_288_vqkfj7a Instruction_11;

		public int Instruction_12;

		public int Instruction_13;

		public int Instruction_14;

		public int Instruction_15;

		public int Instruction_16;

		public int Instruction_17;

		public int Instruction_18;
	}

	public unsafe static bool Invoke(int num_syms, void* pCode_sizes, void* pTable)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		InlineArray_16_vqkfj7a* ptr = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_4;
		InlineArray_17_vqkfj7a* ptr2 = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_6;
		InlineArray_288_vqkfj7a* ptr3 = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_11;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = pTable;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = pCode_sizes;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = num_syms;
		unchecked
		{
			llvm_memset_p0_i64.Invoke((byte*)ptr + sizeof(int) * 0, 0, 64L, isVolatile: false);
			startFrame.GetLocalsRef<LocalVariables>().Instruction_5 = 0;
			while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_3)
			{
				if ((uint)(byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_5] <= 4096u)
				{
					_ = -1;
				}
				else
				{
					wassert.Invoke(String_32otbnd.__pointer, String_uxbkrtb.__pointer, 1843);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					_ = 0;
				}
				(*(int*)((byte*)ptr + sizeof(int) * (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_5]))++;
				int instruction_ = startFrame.GetLocalsRef<LocalVariables>().Instruction_5;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_5 = instruction_ + 1;
			}
			*(int*)((byte*)ptr2 + sizeof(int) * 1) = 0;
			*(int*)((byte*)ptr2 + sizeof(int) * 0) = 0;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = 0;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = 1;
			while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8 <= 15u)
			{
				int num = startFrame.GetLocalsRef<LocalVariables>().Instruction_7 + *(int*)((byte*)ptr + sizeof(int) * (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8) << 1;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = num;
				*(int*)((byte*)ptr2 + sizeof(int) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_8 + 1)) = num;
				int instruction_2 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_2 + 1;
			}
			if (startFrame.GetLocalsRef<LocalVariables>().Instruction_7 != 65536)
			{
				startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = 0;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = 15;
				while (startFrame.GetLocalsRef<LocalVariables>().Instruction_10 != 0)
				{
					int num2 = *(int*)((byte*)ptr + sizeof(int) * (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10);
					int num3 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9 + num2;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = num3;
					if ((uint)num3 <= 1u)
					{
						int instruction_3 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_3 + -1;
						continue;
					}
					goto IL_0384;
				}
				if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 != 1)
				{
					startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
					goto IL_07bb;
				}
			}
			startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = 0;
			while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_12 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_3)
			{
				int num4 = (*(int*)((byte*)ptr2 + sizeof(int) * (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_12]))++;
				*(int*)((byte*)ptr3 + sizeof(int) * (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_12) = num4;
				int instruction_4 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_4 + 1;
			}
			llvm_memset_p0_i64.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_1, 0, 16384L, isVolatile: false);
			startFrame.GetLocalsRef<LocalVariables>().Instruction_13 = 0;
			while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_13 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_3)
			{
				sbyte b = ((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_13];
				startFrame.GetLocalsRef<LocalVariables>().Instruction_14 = (byte)b;
				if (startFrame.GetLocalsRef<LocalVariables>().Instruction_14 != 0)
				{
					int instruction_5 = *(int*)((byte*)ptr3 + sizeof(int) * (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_13);
					startFrame.GetLocalsRef<LocalVariables>().Instruction_15 = instruction_5;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_16 = 0;
					int instruction_6 = startFrame.GetLocalsRef<LocalVariables>().Instruction_14;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_17 = instruction_6;
					while (startFrame.GetLocalsRef<LocalVariables>().Instruction_17 != 0)
					{
						int num5 = startFrame.GetLocalsRef<LocalVariables>().Instruction_16 << 1;
						int instruction_7 = startFrame.GetLocalsRef<LocalVariables>().Instruction_15;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_16 = num5 | (instruction_7 & 1);
						int instruction_8 = startFrame.GetLocalsRef<LocalVariables>().Instruction_15;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_15 = instruction_8 >>> 1;
						int instruction_9 = startFrame.GetLocalsRef<LocalVariables>().Instruction_17;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_17 = instruction_9 + -1;
					}
					int instruction_10 = startFrame.GetLocalsRef<LocalVariables>().Instruction_14;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_18 = 1 << instruction_10;
					while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_16 < 4096u)
					{
						int instruction_11 = startFrame.GetLocalsRef<LocalVariables>().Instruction_13;
						int instruction_12 = startFrame.GetLocalsRef<LocalVariables>().Instruction_14;
						((int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_16] = instruction_11 | (instruction_12 << 9);
						int instruction_13 = startFrame.GetLocalsRef<LocalVariables>().Instruction_18;
						int instruction_14 = startFrame.GetLocalsRef<LocalVariables>().Instruction_16;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_16 = instruction_14 + instruction_13;
					}
				}
				int instruction_15 = startFrame.GetLocalsRef<LocalVariables>().Instruction_13;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_13 = instruction_15 + 1;
			}
			startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = true;
			goto IL_07bb;
		}
		IL_0384:
		startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
		goto IL_07bb;
		IL_07bb:
		bool instruction_16 = startFrame.GetLocalsRef<LocalVariables>().Instruction_0;
		StackFrameList.Current.Clear(startFrame);
		return instruction_16;
	}
}
