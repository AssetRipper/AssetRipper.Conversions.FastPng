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
		public InlineArray_16_vqkfj7a field_0;

		public InlineArray_17_vqkfj7a field_1;

		public InlineArray_288_vqkfj7a field_2;
	}

	public unsafe static bool Invoke(int num_syms, void* pCode_sizes, void* pTable)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		bool flag = false;
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = default(InlineArray_16_vqkfj7a);
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = default(InlineArray_17_vqkfj7a);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = default(InlineArray_288_vqkfj7a);
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		int num11 = 0;
		llvm_memset_p0_i64.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_0, 0, 64L, isVolatile: false);
		unchecked
		{
			for (int i = 0; (uint)i < (uint)num_syms; i++)
			{
				int num12;
				if ((uint)(byte)((sbyte*)pCode_sizes)[(uint)i] <= 4096u)
				{
					num12 = -1;
				}
				else
				{
					wassert.Invoke(String_32otbnd.__pointer, String_uxbkrtb.__pointer, 1843);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					num12 = 0;
				}
				long num13 = (byte)((sbyte*)pCode_sizes)[(uint)i];
				((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_0))[num13]++;
			}
			((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[1] = 0;
			*(int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1) = 0;
			num = 0;
			for (num2 = 1; (uint)num2 <= 15u; num2++)
			{
				int num14 = num + ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_0))[(uint)num2] << 1;
				num = num14;
				((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)(num2 + 1)] = num14;
			}
			if (num != 65536)
			{
				num3 = 0;
				num4 = 15;
				while (num4 != 0)
				{
					int num15 = num3 + ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_0))[(uint)num4];
					num3 = num15;
					if ((uint)num15 <= 1u)
					{
						num4 += -1;
						continue;
					}
					goto IL_01dc;
				}
				if (num3 != 1)
				{
					flag = false;
					goto IL_0345;
				}
			}
			for (num5 = 0; (uint)num5 < (uint)num_syms; num5++)
			{
				long num16 = (byte)((sbyte*)pCode_sizes)[(uint)num5];
				int num17 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[num16]++;
				((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_2))[(uint)num5] = num17;
			}
			llvm_memset_p0_i64.Invoke(pTable, 0, 16384L, isVolatile: false);
			for (num6 = 0; (uint)num6 < (uint)num_syms; num6++)
			{
				num7 = (byte)((sbyte*)pCode_sizes)[(uint)num6];
				if (num7 != 0)
				{
					num8 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_2))[(uint)num6];
					num9 = 0;
					for (num10 = num7; num10 != 0; num10 += -1)
					{
						num9 = (num9 << 1) | (num8 & 1);
						num8 >>>= 1;
					}
					for (num11 = 1 << num7; (uint)num9 < 4096u; num9 += num11)
					{
						((int*)pTable)[(uint)num9] = num6 | (num7 << 9);
					}
				}
			}
			flag = true;
			goto IL_0345;
		}
		IL_01dc:
		flag = false;
		goto IL_0345;
		IL_0345:
		bool result = flag;
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
