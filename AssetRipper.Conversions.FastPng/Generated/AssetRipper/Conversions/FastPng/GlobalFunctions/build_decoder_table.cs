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
		public InlineArray16_Int32 field_0;

		public InlineArray17_Int32 field_1;

		public InlineArray288_Int32 field_2;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("unsigned int")] int num_syms, [NativeType("unsigned char *")] void* pCode_sizes, [NativeType("unsigned int *")] void* pTable)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(InlineArray16_Int32);
		localsPointer->field_1 = default(InlineArray17_Int32);
		localsPointer->field_2 = default(InlineArray288_Int32);
		llvm_memset_p0_i64.Invoke(&localsPointer->field_0, 0, 64L, isVolatile: false);
		bool flag;
		unchecked
		{
			for (int i = 0; (uint)i < (uint)num_syms; i++)
			{
				if ((uint)(byte)((sbyte*)pCode_sizes)[(uint)i] > 4096u)
				{
					wassert.Invoke(String_askaw7.__pointer, String_ksmiy6.__pointer, 1843);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
				}
				long num = (byte)((sbyte*)pCode_sizes)[(uint)i];
				((int*)(&localsPointer->field_0))[num]++;
			}
			((int*)(&localsPointer->field_1))[1] = 0;
			*(int*)(&localsPointer->field_1) = 0;
			int num2 = 0;
			for (int j = 1; (uint)j <= 15u; j++)
			{
				int num3 = num2 + ((int*)(&localsPointer->field_0))[(uint)j] << 1;
				num2 = num3;
				((int*)(&localsPointer->field_1))[(uint)(j + 1)] = num3;
			}
			if (num2 != 65536)
			{
				int num4 = 0;
				int num5 = 15;
				while (num5 != 0)
				{
					int num6 = num4 + ((int*)(&localsPointer->field_0))[(uint)num5];
					num4 = num6;
					if ((uint)num6 <= 1u)
					{
						num5 += -1;
						continue;
					}
					goto IL_01ac;
				}
				if (num4 != 1)
				{
					flag = false;
					goto IL_0303;
				}
			}
			for (int k = 0; (uint)k < (uint)num_syms; k++)
			{
				long num7 = (byte)((sbyte*)pCode_sizes)[(uint)k];
				int num8 = ((int*)(&localsPointer->field_1))[num7]++;
				((int*)(&localsPointer->field_2))[(uint)k] = num8;
			}
			llvm_memset_p0_i64.Invoke(pTable, 0, 16384L, isVolatile: false);
			for (int l = 0; (uint)l < (uint)num_syms; l++)
			{
				int num9 = (byte)((sbyte*)pCode_sizes)[(uint)l];
				if (num9 != 0)
				{
					int num10 = ((int*)(&localsPointer->field_2))[(uint)l];
					int m = 0;
					for (int n = num9; n != 0; n += -1)
					{
						m = (m << 1) | (num10 & 1);
						num10 >>>= 1;
					}
					for (int num11 = 1 << num9; (uint)m < 4096u; m += num11)
					{
						((int*)pTable)[(uint)m] = l | (num9 << 9);
					}
				}
			}
			flag = true;
			goto IL_0303;
		}
		IL_01ac:
		flag = false;
		goto IL_0303;
		IL_0303:
		bool result = flag;
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
