using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?pixel_deflate_dyn_3_rle_one_pass@fpng@@YAIPEBEIIPEAEI@Z")]
[DemangledName("unsigned int __cdecl fpng::pixel_deflate_dyn_3_rle_one_pass(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int)")]
internal static partial class pixel_deflate_dyn_3_rle_one_pass
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
			startFrame.GetLocalsRef<LocalVariables>().Instruction_6 = 1 + instruction_ * 3;
			if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 < 62uL)
			{
				startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 0;
			}
			else
			{
				llvm_memcpy_p0_p0_i64.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2, g_dyn_huff_3.__pointer, 62L, isVolatile: false);
				startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = 62;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = 30L;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = 7;
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
						short field_ = ((anon*)((byte*)g_dyn_huff_3_codes.__pointer + sizeof(anon) * (int)(uint)instruction_8))->field_1;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_16 = (ushort)field_;
						int instruction_9 = startFrame.GetLocalsRef<LocalVariables>().Instruction_15;
						sbyte field_2 = ((anon*)((byte*)g_dyn_huff_3_codes.__pointer + sizeof(anon) * (int)(uint)instruction_9))->field_0;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_17 = (byte)field_2;
						if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_17 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_17 <= 16u)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1187);
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
							wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1187);
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
							wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1187);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						int instruction_13 = READ_RGB_PIXEL.Invoke((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_11);
						startFrame.GetLocalsRef<LocalVariables>().Instruction_19 = instruction_13;
						int instruction_14 = startFrame.GetLocalsRef<LocalVariables>().Instruction_19;
						short field_3 = ((anon*)((byte*)g_dyn_huff_3_codes.__pointer + sizeof(anon) * (int)(uint)(instruction_14 & 0xFF)))->field_1;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_20 = (ushort)field_3;
						int instruction_15 = startFrame.GetLocalsRef<LocalVariables>().Instruction_19;
						sbyte field_4 = ((anon*)((byte*)g_dyn_huff_3_codes.__pointer + sizeof(anon) * (int)(uint)(instruction_15 & 0xFF)))->field_0;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_21 = (byte)field_4;
						if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_21 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_21 <= 16u)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1194);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_20 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_21))
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1194);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						long num2 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_20 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9);
						long instruction_16 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_16 | num2;
						int instruction_17 = startFrame.GetLocalsRef<LocalVariables>().Instruction_21;
						int instruction_18 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_18 + instruction_17;
						if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 <= 64)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1194);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						int instruction_19 = startFrame.GetLocalsRef<LocalVariables>().Instruction_19;
						short field_5 = ((anon*)((byte*)g_dyn_huff_3_codes.__pointer + sizeof(anon) * (int)(uint)((instruction_19 >>> 8) & 0xFF)))->field_1;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_22 = (ushort)field_5;
						int instruction_20 = startFrame.GetLocalsRef<LocalVariables>().Instruction_19;
						sbyte field_6 = ((anon*)((byte*)g_dyn_huff_3_codes.__pointer + sizeof(anon) * (int)(uint)((instruction_20 >>> 8) & 0xFF)))->field_0;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_23 = (byte)field_6;
						if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23 <= 16u)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1195);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_22 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23))
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1195);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						long num3 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_22 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9);
						long instruction_21 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_21 | num3;
						int instruction_22 = startFrame.GetLocalsRef<LocalVariables>().Instruction_23;
						int instruction_23 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_23 + instruction_22;
						if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 <= 64)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1195);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						int instruction_24 = startFrame.GetLocalsRef<LocalVariables>().Instruction_19;
						short field_7 = ((anon*)((byte*)g_dyn_huff_3_codes.__pointer + sizeof(anon) * (int)(uint)(instruction_24 >>> 16)))->field_1;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_24 = (ushort)field_7;
						int instruction_25 = startFrame.GetLocalsRef<LocalVariables>().Instruction_19;
						sbyte field_8 = ((anon*)((byte*)g_dyn_huff_3_codes.__pointer + sizeof(anon) * (int)(uint)(instruction_25 >>> 16)))->field_0;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_25 = (byte)field_8;
						if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_25 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_25 <= 16u)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1196);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_24 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_25))
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1196);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						long num4 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_24 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9);
						long instruction_26 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_26 | num4;
						int instruction_27 = startFrame.GetLocalsRef<LocalVariables>().Instruction_25;
						int instruction_28 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_28 + instruction_27;
						if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 <= 64)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1196);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						int instruction_29 = startFrame.GetLocalsRef<LocalVariables>().Instruction_11;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_11 = instruction_29 + 3;
						int instruction_30 = startFrame.GetLocalsRef<LocalVariables>().Instruction_19;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_18 = instruction_30;
						if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_7 + 8) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)
						{
							startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 0;
							break;
						}
						long instruction_31 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
						*(long*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_7) = instruction_31;
						int instruction_32 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_26 = instruction_32 & -8;
						int num5 = startFrame.GetLocalsRef<LocalVariables>().Instruction_26 >>> 3;
						int instruction_33 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_33 + num5;
						if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_26 < 64u)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1203);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							_ = 0;
						}
						long instruction_34 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
						int instruction_35 = startFrame.GetLocalsRef<LocalVariables>().Instruction_26;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_34 >>> (int)(uint)instruction_35;
						int instruction_36 = startFrame.GetLocalsRef<LocalVariables>().Instruction_26;
						int instruction_37 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_37 - instruction_36;
						while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_11 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_14)
						{
							int instruction_38 = READ_RGB_PIXEL.Invoke((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_11);
							startFrame.GetLocalsRef<LocalVariables>().Instruction_27 = instruction_38;
							if (startFrame.GetLocalsRef<LocalVariables>().Instruction_27 == startFrame.GetLocalsRef<LocalVariables>().Instruction_18)
							{
								startFrame.GetLocalsRef<LocalVariables>().Instruction_28 = 3;
								int instruction_39 = minimum_ymfg3kb.Invoke(255, startFrame.GetLocalsRef<LocalVariables>().Instruction_14 - startFrame.GetLocalsRef<LocalVariables>().Instruction_11);
								startFrame.GetLocalsRef<LocalVariables>().Instruction_29 = instruction_39;
								while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_28 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_29 && READ_RGB_PIXEL.Invoke((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_11 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_28) == startFrame.GetLocalsRef<LocalVariables>().Instruction_27)
								{
									int instruction_40 = startFrame.GetLocalsRef<LocalVariables>().Instruction_28;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_28 = instruction_40 + 3;
								}
								int instruction_41 = startFrame.GetLocalsRef<LocalVariables>().Instruction_28;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_30 = instruction_41 - 3;
								int instruction_42 = startFrame.GetLocalsRef<LocalVariables>().Instruction_30;
								short num6 = *(short*)((byte*)g_defl_len_sym.__pointer + sizeof(short) * (int)(uint)instruction_42);
								short field_9 = ((anon*)((byte*)g_dyn_huff_3_codes.__pointer + sizeof(anon) * (ushort)num6))->field_1;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_31 = (ushort)field_9;
								int instruction_43 = startFrame.GetLocalsRef<LocalVariables>().Instruction_30;
								short num7 = *(short*)((byte*)g_defl_len_sym.__pointer + sizeof(short) * (int)(uint)instruction_43);
								sbyte field_10 = ((anon*)((byte*)g_dyn_huff_3_codes.__pointer + sizeof(anon) * (ushort)num7))->field_0;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_32 = (byte)field_10;
								if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_32 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_32 <= 16u)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1223);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									_ = 0;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_31 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_32))
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1223);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									_ = 0;
								}
								long num8 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_31 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9);
								long instruction_44 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_44 | num8;
								int instruction_45 = startFrame.GetLocalsRef<LocalVariables>().Instruction_32;
								int instruction_46 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_46 + instruction_45;
								if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 <= 64)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1223);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									_ = 0;
								}
								int instruction_47 = startFrame.GetLocalsRef<LocalVariables>().Instruction_30;
								int instruction_48 = startFrame.GetLocalsRef<LocalVariables>().Instruction_30;
								sbyte b2 = ((sbyte*)g_defl_len_extra.__pointer)[sizeof(sbyte) * (int)(uint)instruction_48];
								int num9 = *(int*)((byte*)g_bitmasks.__pointer + sizeof(int) * (byte)b2);
								startFrame.GetLocalsRef<LocalVariables>().Instruction_33 = instruction_47 & num9;
								int instruction_49 = startFrame.GetLocalsRef<LocalVariables>().Instruction_30;
								checked
								{
									int instruction_50 = unchecked((byte)((sbyte*)g_defl_len_extra.__pointer)[sizeof(sbyte) * (int)(uint)instruction_49]) + 1;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_34 = instruction_50;
								}
								if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_34 >= 0u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_34 <= 16u)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1224);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									_ = 0;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_33 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_34))
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1224);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									_ = 0;
								}
								long num10 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_33 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9);
								long instruction_51 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_51 | num10;
								int instruction_52 = startFrame.GetLocalsRef<LocalVariables>().Instruction_34;
								int instruction_53 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_53 + instruction_52;
								if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 <= 64)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1224);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									_ = 0;
								}
								int instruction_54 = startFrame.GetLocalsRef<LocalVariables>().Instruction_28;
								int instruction_55 = startFrame.GetLocalsRef<LocalVariables>().Instruction_11;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_11 = instruction_55 + instruction_54;
							}
							else
							{
								int instruction_56 = startFrame.GetLocalsRef<LocalVariables>().Instruction_27;
								short field_11 = ((anon*)((byte*)g_dyn_huff_3_codes.__pointer + sizeof(anon) * (int)(uint)(instruction_56 & 0xFF)))->field_1;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_35 = (ushort)field_11;
								int instruction_57 = startFrame.GetLocalsRef<LocalVariables>().Instruction_27;
								sbyte field_12 = ((anon*)((byte*)g_dyn_huff_3_codes.__pointer + sizeof(anon) * (int)(uint)(instruction_57 & 0xFF)))->field_0;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_36 = (byte)field_12;
								if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_36 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_36 <= 16u)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1230);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									_ = 0;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_35 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_36))
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1230);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									_ = 0;
								}
								long num11 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_35 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9);
								long instruction_58 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_58 | num11;
								int instruction_59 = startFrame.GetLocalsRef<LocalVariables>().Instruction_36;
								int instruction_60 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_60 + instruction_59;
								if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 <= 64)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1230);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									_ = 0;
								}
								int instruction_61 = startFrame.GetLocalsRef<LocalVariables>().Instruction_27;
								short field_13 = ((anon*)((byte*)g_dyn_huff_3_codes.__pointer + sizeof(anon) * (int)(uint)((instruction_61 >>> 8) & 0xFF)))->field_1;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_37 = (ushort)field_13;
								int instruction_62 = startFrame.GetLocalsRef<LocalVariables>().Instruction_27;
								sbyte field_14 = ((anon*)((byte*)g_dyn_huff_3_codes.__pointer + sizeof(anon) * (int)(uint)((instruction_62 >>> 8) & 0xFF)))->field_0;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_38 = (byte)field_14;
								if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_38 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_38 <= 16u)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1231);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									_ = 0;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_37 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_38))
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1231);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									_ = 0;
								}
								long num12 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_37 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9);
								long instruction_63 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_63 | num12;
								int instruction_64 = startFrame.GetLocalsRef<LocalVariables>().Instruction_38;
								int instruction_65 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_65 + instruction_64;
								if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 <= 64)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1231);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									_ = 0;
								}
								int instruction_66 = startFrame.GetLocalsRef<LocalVariables>().Instruction_27;
								short field_15 = ((anon*)((byte*)g_dyn_huff_3_codes.__pointer + sizeof(anon) * (int)(uint)(instruction_66 >>> 16)))->field_1;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_39 = (ushort)field_15;
								int instruction_67 = startFrame.GetLocalsRef<LocalVariables>().Instruction_27;
								sbyte field_16 = ((anon*)((byte*)g_dyn_huff_3_codes.__pointer + sizeof(anon) * (int)(uint)(instruction_67 >>> 16)))->field_0;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_40 = (byte)field_16;
								if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_40 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_40 <= 16u)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1232);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									_ = 0;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_39 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_40))
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1232);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									_ = 0;
								}
								long num13 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_39 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9);
								long instruction_68 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_68 | num13;
								int instruction_69 = startFrame.GetLocalsRef<LocalVariables>().Instruction_40;
								int instruction_70 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_70 + instruction_69;
								if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 <= 64)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1232);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									_ = 0;
								}
								int instruction_71 = startFrame.GetLocalsRef<LocalVariables>().Instruction_27;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_18 = instruction_71;
								int instruction_72 = startFrame.GetLocalsRef<LocalVariables>().Instruction_11;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_11 = instruction_72 + 3;
							}
							if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_7 + 8) <= (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)
							{
								long instruction_73 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
								*(long*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_7) = instruction_73;
								int instruction_74 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_41 = instruction_74 & -8;
								int num14 = startFrame.GetLocalsRef<LocalVariables>().Instruction_41 >>> 3;
								int instruction_75 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_75 + num14;
								if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_41 < 64u)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1239);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									_ = 0;
								}
								long instruction_76 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
								int instruction_77 = startFrame.GetLocalsRef<LocalVariables>().Instruction_41;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_76 >>> (int)(uint)instruction_77;
								int instruction_78 = startFrame.GetLocalsRef<LocalVariables>().Instruction_41;
								int instruction_79 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_79 - instruction_78;
								continue;
							}
							goto IL_1ddb;
						}
						int instruction_80 = startFrame.GetLocalsRef<LocalVariables>().Instruction_13;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_13 = instruction_80 + 1;
						continue;
					}
					if (startFrame.GetLocalsRef<LocalVariables>().Instruction_11 == startFrame.GetLocalsRef<LocalVariables>().Instruction_3 * startFrame.GetLocalsRef<LocalVariables>().Instruction_6)
					{
						_ = -1;
					}
					else
					{
						wassert.Invoke(String_bjvsuxc.__pointer, String_uxbkrtb.__pointer, 1245);
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
						wassert.Invoke(String_vpte4cc.__pointer, String_uxbkrtb.__pointer, 1247);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						_ = 0;
					}
					startFrame.GetLocalsRef<LocalVariables>().Instruction_42 = 2303;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_43 = 12;
					if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_43 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_43 <= 16u)
					{
						_ = -1;
					}
					else
					{
						wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1249);
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
						wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1249);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						_ = 0;
					}
					long num15 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_42 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9);
					long instruction_81 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_81 | num15;
					int instruction_82 = startFrame.GetLocalsRef<LocalVariables>().Instruction_43;
					int instruction_83 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_83 + instruction_82;
					if (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 <= 64)
					{
						_ = -1;
					}
					else
					{
						wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1249);
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
							long instruction_84 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
							((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_7] = (sbyte)instruction_84;
							int instruction_85 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_85 + 1;
							long instruction_86 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_86 >>> 8;
							int instruction_87 = checked(startFrame.GetLocalsRef<LocalVariables>().Instruction_9 - 8);
							startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_87;
							continue;
						}
						startFrame.GetLocalsRef<LocalVariables>().Instruction_44 = 0;
						while (true)
						{
							if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_44 < 4u)
							{
								if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_7 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)
								{
									startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 0;
									break;
								}
								int instruction_88 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
								((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_7] = (sbyte)(instruction_88 >>> 24);
								int instruction_89 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_89 + 1;
								int instruction_90 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_90 << 8;
								int instruction_91 = startFrame.GetLocalsRef<LocalVariables>().Instruction_44;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_44 = instruction_91 + 1;
								continue;
							}
							int instruction_92 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = instruction_92;
							break;
						}
						break;
					}
					break;
					IL_1ddb:
					startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 0;
					break;
				}
			}
			int instruction_93 = startFrame.GetLocalsRef<LocalVariables>().Instruction_0;
			StackFrameList.Current.Clear(startFrame);
			return instruction_93;
		}
	}
}
