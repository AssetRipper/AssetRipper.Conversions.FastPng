using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?pixel_deflate_dyn_4_rle_one_pass@fpng@@YAIPEBEIIPEAEI@Z")]
[DemangledName("unsigned int __cdecl fpng::pixel_deflate_dyn_4_rle_one_pass(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int)")]
internal static partial class pixel_deflate_dyn_4_rle_one_pass
{
	private partial struct LocalVariables
	{
		public int Instruction_0;

		public int Instruction_1;

		public unsafe void* Instruction_2;

		public int Instruction_3;

		public int Instruction_4;

		public unsafe void* Instruction_5;

		public int Instruction_6;

		public int Instruction_7;

		public long Instruction_8;

		public int Instruction_9;

		public unsafe void* Instruction_10;

		public int Instruction_11;

		public int Instruction_12;

		public int Instruction_13;

		public int Instruction_14;

		public int Instruction_15;

		public int Instruction_16;

		public int Instruction_17;

		public int Instruction_18;

		public int Instruction_19;

		public int Instruction_20;

		public int Instruction_21;

		public int Instruction_22;

		public int Instruction_23;

		public int Instruction_24;

		public int Instruction_25;

		public int Instruction_26;

		public int Instruction_27;

		public int Instruction_28;

		public int Instruction_29;

		public int Instruction_30;

		public int Instruction_31;

		public int Instruction_32;

		public int Instruction_33;

		public int Instruction_34;

		public int Instruction_35;

		public int Instruction_36;

		public int Instruction_37;

		public int Instruction_38;

		public int Instruction_39;

		public int Instruction_40;

		public int Instruction_41;

		public int Instruction_42;

		public int Instruction_43;

		public int Instruction_44;

		public int Instruction_45;

		public int Instruction_46;

		public int Instruction_47;

		public int Instruction_48;

		public int Instruction_49;

		public int Instruction_50;

		public int Instruction_51;

		public int Instruction_52;

		public int Instruction_53;

		public int Instruction_54;
	}

	public unsafe static int Invoke(void* pImg, int w, int h, void* pDst, int dst_buf_size)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = dst_buf_size;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = pDst;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = h;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_4 = w;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_5 = pImg;
		int instruction_ = startFrame.GetLocalsRef<LocalVariables>().Instruction_4;
		unchecked
		{
			startFrame.GetLocalsRef<LocalVariables>().Instruction_6 = 1 + instruction_ * 4;
			if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 < 61uL)
			{
				startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 0;
			}
			else
			{
				llvm_memcpy_p0_p0_i64.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2, g_dyn_huff_4.__pointer, 61L, isVolatile: false);
				startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = 61;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = 1L;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = 2;
				void* instruction_2 = startFrame.GetLocalsRef<LocalVariables>().Instruction_5;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_2;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_11 = 0;
				int instruction_3 = fpng_adler32.Invoke(size: (uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_6 * startFrame.GetLocalsRef<LocalVariables>().Instruction_3), pData: startFrame.GetLocalsRef<LocalVariables>().Instruction_5, adler: 1);
				startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_3;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_13 = 0;
				while (true)
				{
					if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_13 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_3)
					{
						int instruction_4 = startFrame.GetLocalsRef<LocalVariables>().Instruction_11;
						int instruction_5 = startFrame.GetLocalsRef<LocalVariables>().Instruction_6;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_14 = instruction_4 + instruction_5;
						void* instruction_6 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
						int instruction_7 = startFrame.GetLocalsRef<LocalVariables>().Instruction_11;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_11 = instruction_7 + 1;
						sbyte b = ((sbyte*)instruction_6)[(uint)instruction_7];
						startFrame.GetLocalsRef<LocalVariables>().Instruction_15 = (byte)b;
						int instruction_8 = startFrame.GetLocalsRef<LocalVariables>().Instruction_15;
						short field_ = ((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (int)(uint)instruction_8))->field_1;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_16 = (ushort)field_;
						int instruction_9 = startFrame.GetLocalsRef<LocalVariables>().Instruction_15;
						sbyte field_2 = ((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (int)(uint)instruction_9))->field_0;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_17 = (byte)field_2;
						if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_17 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_17 <= 16u)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1473);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_16 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_17))
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1473);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						long num = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_16 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9);
						long instruction_10 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_10 | num;
						int instruction_11 = startFrame.GetLocalsRef<LocalVariables>().Instruction_17;
						int instruction_12 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_12 + instruction_11;
						if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 <= 64)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1473);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_7 + 8) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)
						{
							startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 0;
							break;
						}
						long instruction_13 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
						*(long*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_7) = instruction_13;
						int instruction_14 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_18 = instruction_14 & -8;
						int num2 = startFrame.GetLocalsRef<LocalVariables>().Instruction_18 >>> 3;
						int instruction_15 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_15 + num2;
						if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_18 < 64u)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1475);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						long instruction_16 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
						int instruction_17 = startFrame.GetLocalsRef<LocalVariables>().Instruction_18;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_16 >>> (int)(uint)instruction_17;
						int instruction_18 = startFrame.GetLocalsRef<LocalVariables>().Instruction_18;
						int instruction_19 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_19 - instruction_18;
						int instruction_20 = *(int*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_11);
						startFrame.GetLocalsRef<LocalVariables>().Instruction_20 = instruction_20;
						int instruction_21 = startFrame.GetLocalsRef<LocalVariables>().Instruction_20;
						short field_3 = ((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (int)(uint)(instruction_21 & 0xFF)))->field_1;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_21 = (ushort)field_3;
						int instruction_22 = startFrame.GetLocalsRef<LocalVariables>().Instruction_20;
						sbyte field_4 = ((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (int)(uint)(instruction_22 & 0xFF)))->field_0;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_22 = (byte)field_4;
						if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_22 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_22 <= 16u)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1481);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_21 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_22))
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1481);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						long num3 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_21 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9);
						long instruction_23 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_23 | num3;
						int instruction_24 = startFrame.GetLocalsRef<LocalVariables>().Instruction_22;
						int instruction_25 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_25 + instruction_24;
						if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 <= 64)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1481);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						int instruction_26 = startFrame.GetLocalsRef<LocalVariables>().Instruction_20;
						short field_5 = ((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (int)(uint)((instruction_26 >>> 8) & 0xFF)))->field_1;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_23 = (ushort)field_5;
						int instruction_27 = startFrame.GetLocalsRef<LocalVariables>().Instruction_20;
						sbyte field_6 = ((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (int)(uint)((instruction_27 >>> 8) & 0xFF)))->field_0;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_24 = (byte)field_6;
						if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_24 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_24 <= 16u)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1482);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_24))
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1482);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						long num4 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9);
						long instruction_28 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_28 | num4;
						int instruction_29 = startFrame.GetLocalsRef<LocalVariables>().Instruction_24;
						int instruction_30 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_30 + instruction_29;
						if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 <= 64)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1482);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						int instruction_31 = startFrame.GetLocalsRef<LocalVariables>().Instruction_20;
						short field_7 = ((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (int)(uint)((instruction_31 >>> 16) & 0xFF)))->field_1;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_25 = (ushort)field_7;
						int instruction_32 = startFrame.GetLocalsRef<LocalVariables>().Instruction_20;
						sbyte field_8 = ((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (int)(uint)((instruction_32 >>> 16) & 0xFF)))->field_0;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_26 = (byte)field_8;
						if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_26 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_26 <= 16u)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1483);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_25 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_26))
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1483);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						long num5 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_25 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9);
						long instruction_33 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_33 | num5;
						int instruction_34 = startFrame.GetLocalsRef<LocalVariables>().Instruction_26;
						int instruction_35 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_35 + instruction_34;
						if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 <= 64)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1483);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 >= 49)
						{
							if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_7 + 8) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)
							{
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 0;
								break;
							}
							long instruction_36 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
							*(long*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_7) = instruction_36;
							int instruction_37 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_27 = instruction_37 & -8;
							int num6 = startFrame.GetLocalsRef<LocalVariables>().Instruction_27 >>> 3;
							int instruction_38 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_38 + num6;
							if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_27 < 64u)
							{
								_ = -1;
							}
							else
							{
								wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1487);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								_ = 0;
							}
							long instruction_39 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
							int instruction_40 = startFrame.GetLocalsRef<LocalVariables>().Instruction_27;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_39 >>> (int)(uint)instruction_40;
							int instruction_41 = startFrame.GetLocalsRef<LocalVariables>().Instruction_27;
							int instruction_42 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_42 - instruction_41;
						}
						int instruction_43 = startFrame.GetLocalsRef<LocalVariables>().Instruction_20;
						short field_9 = ((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (int)(uint)(instruction_43 >>> 24)))->field_1;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_28 = (ushort)field_9;
						int instruction_44 = startFrame.GetLocalsRef<LocalVariables>().Instruction_20;
						sbyte field_10 = ((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (int)(uint)(instruction_44 >>> 24)))->field_0;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_29 = (byte)field_10;
						if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_29 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_29 <= 16u)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1490);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_28 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_29))
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1490);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						long num7 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_28 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9);
						long instruction_45 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_45 | num7;
						int instruction_46 = startFrame.GetLocalsRef<LocalVariables>().Instruction_29;
						int instruction_47 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_47 + instruction_46;
						if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 <= 64)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1490);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						int instruction_48 = startFrame.GetLocalsRef<LocalVariables>().Instruction_11;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_11 = instruction_48 + 4;
						int instruction_49 = startFrame.GetLocalsRef<LocalVariables>().Instruction_20;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_19 = instruction_49;
						if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_7 + 8) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)
						{
							startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 0;
							break;
						}
						long instruction_50 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
						*(long*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_7) = instruction_50;
						int instruction_51 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_30 = instruction_51 & -8;
						int num8 = startFrame.GetLocalsRef<LocalVariables>().Instruction_30 >>> 3;
						int instruction_52 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_52 + num8;
						if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_30 < 64u)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1497);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						long instruction_53 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
						int instruction_54 = startFrame.GetLocalsRef<LocalVariables>().Instruction_30;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_53 >>> (int)(uint)instruction_54;
						int instruction_55 = startFrame.GetLocalsRef<LocalVariables>().Instruction_30;
						int instruction_56 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_56 - instruction_55;
						while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_11 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_14)
						{
							int instruction_57 = *(int*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_11);
							startFrame.GetLocalsRef<LocalVariables>().Instruction_31 = instruction_57;
							if (startFrame.GetLocalsRef<LocalVariables>().Instruction_31 != startFrame.GetLocalsRef<LocalVariables>().Instruction_19)
							{
								goto IL_1e43;
							}
							startFrame.GetLocalsRef<LocalVariables>().Instruction_32 = 4;
							int instruction_58 = minimum_ymfg3kb.Invoke(252, startFrame.GetLocalsRef<LocalVariables>().Instruction_14 - startFrame.GetLocalsRef<LocalVariables>().Instruction_11);
							startFrame.GetLocalsRef<LocalVariables>().Instruction_33 = instruction_58;
							while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_32 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_33 && *(int*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_11 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_32) == startFrame.GetLocalsRef<LocalVariables>().Instruction_31)
							{
								int instruction_59 = startFrame.GetLocalsRef<LocalVariables>().Instruction_32;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_32 = instruction_59 + 4;
							}
							int instruction_60 = startFrame.GetLocalsRef<LocalVariables>().Instruction_32;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_34 = instruction_60 - 3;
							int instruction_61 = startFrame.GetLocalsRef<LocalVariables>().Instruction_34;
							short num9 = *(short*)((byte*)g_defl_len_sym.__pointer + sizeof(short) * (int)(uint)instruction_61);
							sbyte field_11 = ((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (ushort)num9))->field_0;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_35 = (byte)field_11;
							int instruction_62 = startFrame.GetLocalsRef<LocalVariables>().Instruction_34;
							sbyte b2 = ((sbyte*)g_defl_len_extra.__pointer)[sizeof(sbyte) * (int)(uint)instruction_62];
							startFrame.GetLocalsRef<LocalVariables>().Instruction_36 = (byte)b2;
							if (startFrame.GetLocalsRef<LocalVariables>().Instruction_32 == 4)
							{
								int instruction_63 = startFrame.GetLocalsRef<LocalVariables>().Instruction_31;
								int num10 = (byte)((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (int)(uint)(instruction_63 & 0xFF)))->field_0;
								int instruction_64 = startFrame.GetLocalsRef<LocalVariables>().Instruction_31;
								checked
								{
									int num11 = num10 + unchecked((byte)((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (int)(uint)((instruction_64 >>> 8) & 0xFF)))->field_0);
									int instruction_65 = startFrame.GetLocalsRef<LocalVariables>().Instruction_31;
									int num12 = num11 + unchecked((byte)((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (int)(uint)((instruction_65 >>> 16) & 0xFF)))->field_0);
									int instruction_66 = startFrame.GetLocalsRef<LocalVariables>().Instruction_31;
									int instruction_67 = num12 + unchecked((byte)((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (int)(uint)(instruction_66 >>> 24)))->field_0);
									startFrame.GetLocalsRef<LocalVariables>().Instruction_37 = instruction_67;
								}
								if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_35 + startFrame.GetLocalsRef<LocalVariables>().Instruction_36 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_37)
								{
									goto IL_1e43;
								}
							}
							int instruction_68 = startFrame.GetLocalsRef<LocalVariables>().Instruction_34;
							short num13 = *(short*)((byte*)g_defl_len_sym.__pointer + sizeof(short) * (int)(uint)instruction_68);
							short field_12 = ((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (ushort)num13))->field_1;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_38 = (ushort)field_12;
							int instruction_69 = startFrame.GetLocalsRef<LocalVariables>().Instruction_35;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_39 = instruction_69;
							if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_39 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_39 <= 16u)
							{
								_ = -1;
							}
							else
							{
								wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1530);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								_ = 0;
							}
							if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_38 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_39))
							{
								_ = -1;
							}
							else
							{
								wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1530);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								_ = 0;
							}
							long num14 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_38 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9);
							long instruction_70 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_70 | num14;
							int instruction_71 = startFrame.GetLocalsRef<LocalVariables>().Instruction_39;
							int instruction_72 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_72 + instruction_71;
							if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 <= 64)
							{
								_ = -1;
							}
							else
							{
								wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1530);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								_ = 0;
							}
							int instruction_73 = startFrame.GetLocalsRef<LocalVariables>().Instruction_34;
							int instruction_74 = startFrame.GetLocalsRef<LocalVariables>().Instruction_34;
							sbyte b3 = ((sbyte*)g_defl_len_extra.__pointer)[sizeof(sbyte) * (int)(uint)instruction_74];
							int num15 = *(int*)((byte*)g_bitmasks.__pointer + sizeof(int) * (byte)b3);
							startFrame.GetLocalsRef<LocalVariables>().Instruction_40 = instruction_73 & num15;
							int instruction_75 = startFrame.GetLocalsRef<LocalVariables>().Instruction_36;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_41 = instruction_75 + 1;
							if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_41 >= 0u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_41 <= 16u)
							{
								_ = -1;
							}
							else
							{
								wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1531);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								_ = 0;
							}
							if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_40 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_41))
							{
								_ = -1;
							}
							else
							{
								wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1531);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								_ = 0;
							}
							long num16 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_40 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9);
							long instruction_76 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_76 | num16;
							int instruction_77 = startFrame.GetLocalsRef<LocalVariables>().Instruction_41;
							int instruction_78 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_78 + instruction_77;
							if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 <= 64)
							{
								_ = -1;
							}
							else
							{
								wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1531);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								_ = 0;
							}
							int instruction_79 = startFrame.GetLocalsRef<LocalVariables>().Instruction_32;
							int instruction_80 = startFrame.GetLocalsRef<LocalVariables>().Instruction_11;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_11 = instruction_80 + instruction_79;
							goto IL_2bf7;
							IL_2bf7:
							if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_7 + 8) <= (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)
							{
								long instruction_81 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
								*(long*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_7) = instruction_81;
								int instruction_82 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_51 = instruction_82 & -8;
								int num17 = startFrame.GetLocalsRef<LocalVariables>().Instruction_51 >>> 3;
								int instruction_83 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_83 + num17;
								if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_51 < 64u)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1554);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									_ = 0;
								}
								long instruction_84 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
								int instruction_85 = startFrame.GetLocalsRef<LocalVariables>().Instruction_51;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_84 >>> (int)(uint)instruction_85;
								int instruction_86 = startFrame.GetLocalsRef<LocalVariables>().Instruction_51;
								int instruction_87 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_87 - instruction_86;
								continue;
							}
							goto IL_2c37;
							IL_1e43:
							int instruction_88 = startFrame.GetLocalsRef<LocalVariables>().Instruction_31;
							short field_13 = ((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (int)(uint)(instruction_88 & 0xFF)))->field_1;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_42 = (ushort)field_13;
							int instruction_89 = startFrame.GetLocalsRef<LocalVariables>().Instruction_31;
							sbyte field_14 = ((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (int)(uint)(instruction_89 & 0xFF)))->field_0;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_43 = (byte)field_14;
							if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_43 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_43 <= 16u)
							{
								_ = -1;
							}
							else
							{
								wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1538);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								_ = 0;
							}
							if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_42 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_43))
							{
								_ = -1;
							}
							else
							{
								wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1538);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								_ = 0;
							}
							long num18 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_42 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9);
							long instruction_90 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_90 | num18;
							int instruction_91 = startFrame.GetLocalsRef<LocalVariables>().Instruction_43;
							int instruction_92 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_92 + instruction_91;
							if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 <= 64)
							{
								_ = -1;
							}
							else
							{
								wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1538);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								_ = 0;
							}
							int instruction_93 = startFrame.GetLocalsRef<LocalVariables>().Instruction_31;
							short field_15 = ((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (int)(uint)((instruction_93 >>> 8) & 0xFF)))->field_1;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_44 = (ushort)field_15;
							int instruction_94 = startFrame.GetLocalsRef<LocalVariables>().Instruction_31;
							sbyte field_16 = ((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (int)(uint)((instruction_94 >>> 8) & 0xFF)))->field_0;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_45 = (byte)field_16;
							if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_45 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_45 <= 16u)
							{
								_ = -1;
							}
							else
							{
								wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1539);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								_ = 0;
							}
							if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_44 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_45))
							{
								_ = -1;
							}
							else
							{
								wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1539);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								_ = 0;
							}
							long num19 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_44 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9);
							long instruction_95 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_95 | num19;
							int instruction_96 = startFrame.GetLocalsRef<LocalVariables>().Instruction_45;
							int instruction_97 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_97 + instruction_96;
							if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 <= 64)
							{
								_ = -1;
							}
							else
							{
								wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1539);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								_ = 0;
							}
							int instruction_98 = startFrame.GetLocalsRef<LocalVariables>().Instruction_31;
							short field_17 = ((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (int)(uint)((instruction_98 >>> 16) & 0xFF)))->field_1;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_46 = (ushort)field_17;
							int instruction_99 = startFrame.GetLocalsRef<LocalVariables>().Instruction_31;
							sbyte field_18 = ((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (int)(uint)((instruction_99 >>> 16) & 0xFF)))->field_0;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_47 = (byte)field_18;
							if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_47 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_47 <= 16u)
							{
								_ = -1;
							}
							else
							{
								wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1540);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								_ = 0;
							}
							if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_46 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_47))
							{
								_ = -1;
							}
							else
							{
								wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1540);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								_ = 0;
							}
							long num20 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_46 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9);
							long instruction_100 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_100 | num20;
							int instruction_101 = startFrame.GetLocalsRef<LocalVariables>().Instruction_47;
							int instruction_102 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_102 + instruction_101;
							if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 <= 64)
							{
								_ = -1;
							}
							else
							{
								wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1540);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								_ = 0;
							}
							if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 >= 49)
							{
								if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_7 + 8) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)
								{
									goto IL_2738;
								}
								long instruction_103 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
								*(long*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_7) = instruction_103;
								int instruction_104 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_48 = instruction_104 & -8;
								int num21 = startFrame.GetLocalsRef<LocalVariables>().Instruction_48 >>> 3;
								int instruction_105 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_105 + num21;
								if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_48 < 64u)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1544);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									_ = 0;
								}
								long instruction_106 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
								int instruction_107 = startFrame.GetLocalsRef<LocalVariables>().Instruction_48;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_106 >>> (int)(uint)instruction_107;
								int instruction_108 = startFrame.GetLocalsRef<LocalVariables>().Instruction_48;
								int instruction_109 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_109 - instruction_108;
							}
							int instruction_110 = startFrame.GetLocalsRef<LocalVariables>().Instruction_31;
							short field_19 = ((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (int)(uint)(instruction_110 >>> 24)))->field_1;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_49 = (ushort)field_19;
							int instruction_111 = startFrame.GetLocalsRef<LocalVariables>().Instruction_31;
							sbyte field_20 = ((anon_11*)((byte*)g_dyn_huff_4_codes.__pointer + sizeof(anon_11) * (int)(uint)(instruction_111 >>> 24)))->field_0;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_50 = (byte)field_20;
							if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_50 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_50 <= 16u)
							{
								_ = -1;
							}
							else
							{
								wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1547);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								_ = 0;
							}
							if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_49 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_50))
							{
								_ = -1;
							}
							else
							{
								wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1547);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								_ = 0;
							}
							long num22 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_49 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9);
							long instruction_112 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_112 | num22;
							int instruction_113 = startFrame.GetLocalsRef<LocalVariables>().Instruction_50;
							int instruction_114 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_114 + instruction_113;
							if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 <= 64)
							{
								_ = -1;
							}
							else
							{
								wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1547);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								_ = 0;
							}
							int instruction_115 = startFrame.GetLocalsRef<LocalVariables>().Instruction_11;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_11 = instruction_115 + 4;
							int instruction_116 = startFrame.GetLocalsRef<LocalVariables>().Instruction_31;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_19 = instruction_116;
							goto IL_2bf7;
						}
						int instruction_117 = startFrame.GetLocalsRef<LocalVariables>().Instruction_13;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_13 = instruction_117 + 1;
						continue;
					}
					if (startFrame.GetLocalsRef<LocalVariables>().Instruction_11 == startFrame.GetLocalsRef<LocalVariables>().Instruction_3 * startFrame.GetLocalsRef<LocalVariables>().Instruction_6)
					{
						_ = -1;
					}
					else
					{
						wassert.Invoke(String_bjvsuxc.__pointer, String_uxbkrtb.__pointer, 1560);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						_ = 0;
					}
					if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 <= 7)
					{
						_ = -1;
					}
					else
					{
						wassert.Invoke(String_vpte4cc.__pointer, String_uxbkrtb.__pointer, 1562);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						_ = 0;
					}
					startFrame.GetLocalsRef<LocalVariables>().Instruction_52 = 2047;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_53 = 12;
					if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_53 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_53 <= 16u)
					{
						_ = -1;
					}
					else
					{
						wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1564);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						_ = 0;
					}
					if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_52 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_53))
					{
						_ = -1;
					}
					else
					{
						wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1564);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						_ = 0;
					}
					long num23 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_52 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9);
					long instruction_118 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_118 | num23;
					int instruction_119 = startFrame.GetLocalsRef<LocalVariables>().Instruction_53;
					int instruction_120 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_120 + instruction_119;
					if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 <= 64)
					{
						_ = -1;
					}
					else
					{
						wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1564);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						_ = 0;
					}
					while (true)
					{
						if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 > 0)
						{
							if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_7 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)
							{
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 0;
								break;
							}
							long instruction_121 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
							((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_7] = (sbyte)instruction_121;
							int instruction_122 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_122 + 1;
							long instruction_123 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_123 >>> 8;
							int instruction_124 = checked(startFrame.GetLocalsRef<LocalVariables>().Instruction_9 - 8);
							startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_124;
							continue;
						}
						startFrame.GetLocalsRef<LocalVariables>().Instruction_54 = 0;
						while (true)
						{
							if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_54 < 4u)
							{
								if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_7 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)
								{
									startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 0;
									break;
								}
								int instruction_125 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
								((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_7] = (sbyte)(instruction_125 >>> 24);
								int instruction_126 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_126 + 1;
								int instruction_127 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_127 << 8;
								int instruction_128 = startFrame.GetLocalsRef<LocalVariables>().Instruction_54;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_54 = instruction_128 + 1;
								continue;
							}
							int instruction_129 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = instruction_129;
							break;
						}
						break;
					}
					break;
					IL_2c37:
					startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 0;
					break;
					IL_2738:
					startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 0;
					break;
				}
			}
			int instruction_130 = startFrame.GetLocalsRef<LocalVariables>().Instruction_0;
			StackFrameList.Current.Clear(startFrame);
			return instruction_130;
		}
	}
}
