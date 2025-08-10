using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$fpng_pixel_zlib_decompress_3@$03@fpng@@YA_NPEBEIIPEAEII@Z")]
[DemangledName("bool __cdecl fpng::fpng_pixel_zlib_decompress_3<4>(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int, unsigned int)")]
[CleanName("fpng_pixel_zlib_decompress_3")]
internal static partial class fpng_pixel_zlib_decompress_3_yffw42c
{
	private partial struct LocalVariables
	{
		public bool Instruction_0;

		public int Instruction_1;

		public int Instruction_2;

		public unsafe void* Instruction_3;

		public int Instruction_4;

		public int Instruction_5;

		public unsafe void* Instruction_6;

		public int Instruction_7;

		public int Instruction_8;

		public long Instruction_9;

		public int Instruction_10;

		public int Instruction_11;

		public int Instruction_12;

		public int Instruction_13;

		public int Instruction_14;

		public InlineArray_4096_vqkfj7a Instruction_15;

		public unsafe void* Instruction_16;

		public unsafe void* Instruction_17;

		public int Instruction_18;

		public int Instruction_19;

		public int Instruction_20;

		public int Instruction_21;

		public int Instruction_22;

		public int Instruction_23;

		public sbyte Instruction_24;

		public sbyte Instruction_25;

		public sbyte Instruction_26;

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
	}

	public unsafe static bool Invoke(void* pSrc, int src_len, int zlib_len, void* pDst, int w, int h)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		int* src_ofs = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_8;
		long* bit_buf = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_9;
		int* bit_buf_size = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_10;
		InlineArray_4096_vqkfj7a* ptr = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_15;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = h;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = w;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = pDst;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_4 = zlib_len;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_5 = src_len;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_6 = pSrc;
		unchecked
		{
			if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 >= (uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_4 + 4))
			{
				_ = -1;
			}
			else
			{
				wassert.Invoke(String_497patd.__pointer, String_uxbkrtb.__pointer, 2214);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				_ = 0;
			}
			int instruction_ = startFrame.GetLocalsRef<LocalVariables>().Instruction_2;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_ * 4;
			if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 < 7u)
			{
				startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
			}
			else if ((byte)(*(sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6) != 120 || (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)[1L] != 1)
			{
				startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
			}
			else
			{
				startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = 2;
				if (((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8] & 6) == 0)
				{
					bool instruction_2 = fpng_pixel_zlib_raw_decompress.Invoke(h: startFrame.GetLocalsRef<LocalVariables>().Instruction_1, w: startFrame.GetLocalsRef<LocalVariables>().Instruction_2, pDst: startFrame.GetLocalsRef<LocalVariables>().Instruction_3, zlib_len: startFrame.GetLocalsRef<LocalVariables>().Instruction_4, src_len: startFrame.GetLocalsRef<LocalVariables>().Instruction_5, pSrc: startFrame.GetLocalsRef<LocalVariables>().Instruction_6, src_chans: 3, dst_chans: 4);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = instruction_2;
				}
				else if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)
				{
					startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
				}
				else
				{
					int num = *(int*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
					startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = (uint)num;
					int instruction_3 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_3 + 4;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = 32;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_13 = 1;
					if (startFrame.GetLocalsRef<LocalVariables>().Instruction_13 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_13 <= 32u)
					{
						_ = -1;
					}
					else
					{
						wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 2239);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						_ = 0;
					}
					long instruction_4 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
					int instruction_5 = startFrame.GetLocalsRef<LocalVariables>().Instruction_13;
					int num2 = *(int*)((byte*)g_bitmasks.__pointer + sizeof(int) * (int)(uint)instruction_5);
					startFrame.GetLocalsRef<LocalVariables>().Instruction_11 = (int)(instruction_4 & (uint)num2);
					int instruction_6 = startFrame.GetLocalsRef<LocalVariables>().Instruction_13;
					long instruction_7 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_7 >>> (int)(uint)instruction_6;
					int instruction_8 = startFrame.GetLocalsRef<LocalVariables>().Instruction_13;
					int instruction_9 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_9 - instruction_8;
					if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 < 32u)
					{
						if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)
						{
							startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
							goto IL_3bd4;
						}
						long num3 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10);
						long instruction_10 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_10 | num3;
						int instruction_11 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_11 + 4;
						int instruction_12 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_12 + 32;
					}
					startFrame.GetLocalsRef<LocalVariables>().Instruction_14 = 2;
					if (startFrame.GetLocalsRef<LocalVariables>().Instruction_14 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_14 <= 32u)
					{
						_ = -1;
					}
					else
					{
						wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 2240);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						_ = 0;
					}
					long instruction_13 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
					int instruction_14 = startFrame.GetLocalsRef<LocalVariables>().Instruction_14;
					int num4 = *(int*)((byte*)g_bitmasks.__pointer + sizeof(int) * (int)(uint)instruction_14);
					startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = (int)(instruction_13 & (uint)num4);
					int instruction_15 = startFrame.GetLocalsRef<LocalVariables>().Instruction_14;
					long instruction_16 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_16 >>> (int)(uint)instruction_15;
					int instruction_17 = startFrame.GetLocalsRef<LocalVariables>().Instruction_14;
					int instruction_18 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_18 - instruction_17;
					if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 < 32u)
					{
						if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)
						{
							startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
							goto IL_3bd4;
						}
						long num5 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10);
						long instruction_19 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_19 | num5;
						int instruction_20 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_20 + 4;
						int instruction_21 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_21 + 32;
					}
					if (startFrame.GetLocalsRef<LocalVariables>().Instruction_11 != 1 || startFrame.GetLocalsRef<LocalVariables>().Instruction_12 != 2)
					{
						startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
					}
					else
					{
						bool flag = prepare_dynamic_block.Invoke(pLit_table: (byte*)ptr + sizeof(int) * 0, src_len: startFrame.GetLocalsRef<LocalVariables>().Instruction_5, pSrc: startFrame.GetLocalsRef<LocalVariables>().Instruction_6, src_ofs: src_ofs, bit_buf_size: bit_buf_size, bit_buf: bit_buf, num_chans: 3);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag)
						{
							startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
						}
						else
						{
							startFrame.GetLocalsRef<LocalVariables>().Instruction_16 = null;
							void* instruction_22 = startFrame.GetLocalsRef<LocalVariables>().Instruction_3;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_17 = instruction_22;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_18 = 0;
							while (true)
							{
								if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_18 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)
								{
									if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 >= 12u)
									{
										_ = -1;
									}
									else
									{
										wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2256);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										_ = 0;
									}
									int instruction_23 = *(int*)((byte*)ptr + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables>().Instruction_9 & 0xFFFL));
									startFrame.GetLocalsRef<LocalVariables>().Instruction_19 = instruction_23;
									int instruction_24 = startFrame.GetLocalsRef<LocalVariables>().Instruction_19;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_20 = (instruction_24 >>> 9) & 0xF;
									if (startFrame.GetLocalsRef<LocalVariables>().Instruction_20 == 0)
									{
										startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
										break;
									}
									int instruction_25 = startFrame.GetLocalsRef<LocalVariables>().Instruction_20;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_21 = instruction_25;
									if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_21 <= 32u)
									{
										_ = -1;
									}
									else
									{
										wassert.Invoke(String_mf9hyza.__pointer, String_uxbkrtb.__pointer, 2261);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										_ = 0;
									}
									int instruction_26 = startFrame.GetLocalsRef<LocalVariables>().Instruction_21;
									long instruction_27 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_27 >>> (int)(uint)instruction_26;
									int instruction_28 = startFrame.GetLocalsRef<LocalVariables>().Instruction_21;
									int instruction_29 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_29 - instruction_28;
									if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 < 32u)
									{
										if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)
										{
											startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
											break;
										}
										long num6 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10);
										long instruction_30 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_30 | num6;
										int instruction_31 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_31 + 4;
										int instruction_32 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_32 + 32;
									}
									int instruction_33 = startFrame.GetLocalsRef<LocalVariables>().Instruction_19;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_19 = instruction_33 & 0x1FF;
									bool flag2 = startFrame.GetLocalsRef<LocalVariables>().Instruction_18 != 0;
									_ = flag2;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_22 = (flag2 ? 2 : 0);
									if (startFrame.GetLocalsRef<LocalVariables>().Instruction_19 != startFrame.GetLocalsRef<LocalVariables>().Instruction_22)
									{
										startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
										break;
									}
									startFrame.GetLocalsRef<LocalVariables>().Instruction_23 = 0;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_24 = 0;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_25 = 0;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_26 = 0;
									while (true)
									{
										if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 >= 12u)
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2272);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											_ = 0;
										}
										int instruction_34 = *(int*)((byte*)ptr + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables>().Instruction_9 & 0xFFFL));
										startFrame.GetLocalsRef<LocalVariables>().Instruction_27 = instruction_34;
										int instruction_35 = startFrame.GetLocalsRef<LocalVariables>().Instruction_27;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_28 = instruction_35;
										int instruction_36 = startFrame.GetLocalsRef<LocalVariables>().Instruction_27;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_29 = (instruction_36 >>> 9) & 0xF;
										if (startFrame.GetLocalsRef<LocalVariables>().Instruction_29 == 0)
										{
											break;
										}
										int instruction_37 = startFrame.GetLocalsRef<LocalVariables>().Instruction_29;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_30 = instruction_37;
										if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_30 <= 32u)
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_mf9hyza.__pointer, String_uxbkrtb.__pointer, 2279);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											_ = 0;
										}
										int instruction_38 = startFrame.GetLocalsRef<LocalVariables>().Instruction_30;
										long instruction_39 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_39 >>> (int)(uint)instruction_38;
										int instruction_40 = startFrame.GetLocalsRef<LocalVariables>().Instruction_30;
										int instruction_41 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_41 - instruction_40;
										if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 < 32u)
										{
											if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)
											{
												goto IL_0ee3;
											}
											long num7 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10);
											long instruction_42 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_42 | num7;
											int instruction_43 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_43 + 4;
											int instruction_44 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_44 + 32;
										}
										if ((startFrame.GetLocalsRef<LocalVariables>().Instruction_28 & 0x100) != 0)
										{
											int instruction_45 = startFrame.GetLocalsRef<LocalVariables>().Instruction_28;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_28 = instruction_45 & 0x1FF;
											if (startFrame.GetLocalsRef<LocalVariables>().Instruction_28 == 256)
											{
												goto IL_1028;
											}
											int instruction_46 = startFrame.GetLocalsRef<LocalVariables>().Instruction_28;
											int instruction_47 = *(int*)((byte*)s_length_range.__pointer + sizeof(int) * (int)(uint)(instruction_46 - 257));
											startFrame.GetLocalsRef<LocalVariables>().Instruction_31 = instruction_47;
											if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_28 >= 265u)
											{
												int instruction_48 = startFrame.GetLocalsRef<LocalVariables>().Instruction_28;
												int instruction_49 = *(int*)((byte*)s_length_extra.__pointer + sizeof(int) * (int)(uint)(instruction_48 - 257));
												startFrame.GetLocalsRef<LocalVariables>().Instruction_33 = instruction_49;
												if (startFrame.GetLocalsRef<LocalVariables>().Instruction_33 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_33 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_33)
												{
													_ = -1;
												}
												else
												{
													wassert.Invoke(String_ftb25bb.__pointer, String_uxbkrtb.__pointer, 2294);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													_ = 0;
												}
												long instruction_50 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
												int instruction_51 = startFrame.GetLocalsRef<LocalVariables>().Instruction_33;
												int num8 = *(int*)((byte*)g_bitmasks.__pointer + sizeof(int) * (int)(uint)instruction_51);
												startFrame.GetLocalsRef<LocalVariables>().Instruction_32 = (int)(instruction_50 & (uint)num8);
												int instruction_52 = startFrame.GetLocalsRef<LocalVariables>().Instruction_33;
												long instruction_53 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_53 >>> (int)(uint)instruction_52;
												int instruction_54 = startFrame.GetLocalsRef<LocalVariables>().Instruction_33;
												int instruction_55 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_55 - instruction_54;
												int instruction_56 = startFrame.GetLocalsRef<LocalVariables>().Instruction_32;
												int instruction_57 = startFrame.GetLocalsRef<LocalVariables>().Instruction_31;
												startFrame.GetLocalsRef<LocalVariables>().Instruction_31 = instruction_57 + instruction_56;
											}
											startFrame.GetLocalsRef<LocalVariables>().Instruction_34 = 1;
											if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_34 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_34)
											{
												_ = -1;
											}
											else
											{
												wassert.Invoke(String_bahgbqd.__pointer, String_uxbkrtb.__pointer, 2300);
												if (ExceptionInfo.Current != null)
												{
													return false;
												}
												_ = 0;
											}
											int instruction_58 = startFrame.GetLocalsRef<LocalVariables>().Instruction_34;
											long instruction_59 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_59 >>> (int)(uint)instruction_58;
											int instruction_60 = startFrame.GetLocalsRef<LocalVariables>().Instruction_34;
											int instruction_61 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_61 - instruction_60;
											if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_31 % 3u == 0)
											{
												_ = -1;
											}
											else
											{
												wassert.Invoke(String_a5rp7bb.__pointer, String_uxbkrtb.__pointer, 2303);
												if (ExceptionInfo.Current != null)
												{
													return false;
												}
												_ = 0;
											}
											int instruction_62 = startFrame.GetLocalsRef<LocalVariables>().Instruction_23;
											int instruction_63 = startFrame.GetLocalsRef<LocalVariables>().Instruction_31;
											short num9 = *(short*)((byte*)g_run_len3_to_4.__pointer + sizeof(short) * (int)(uint)instruction_63);
											startFrame.GetLocalsRef<LocalVariables>().Instruction_35 = instruction_62 + (ushort)num9;
											if (startFrame.GetLocalsRef<LocalVariables>().Instruction_23 == startFrame.GetLocalsRef<LocalVariables>().Instruction_35)
											{
												goto IL_14e2;
											}
											if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_35 > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_7)
											{
												goto IL_152b;
											}
											if (startFrame.GetLocalsRef<LocalVariables>().Instruction_16 != null)
											{
												if (((byte)startFrame.GetLocalsRef<LocalVariables>().Instruction_24 | (byte)startFrame.GetLocalsRef<LocalVariables>().Instruction_25 | (byte)startFrame.GetLocalsRef<LocalVariables>().Instruction_26) == 0)
												{
													llvm_memcpy_p0_p0_i64.Invoke((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23, (byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_16 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23, (uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_35 - startFrame.GetLocalsRef<LocalVariables>().Instruction_23), isVolatile: false);
													int instruction_64 = startFrame.GetLocalsRef<LocalVariables>().Instruction_35;
													startFrame.GetLocalsRef<LocalVariables>().Instruction_23 = instruction_64;
												}
												else
												{
													do
													{
														int num10;
														checked
														{
															num10 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_16)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23]) + unchecked((byte)startFrame.GetLocalsRef<LocalVariables>().Instruction_24);
														}
														((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23] = (sbyte)num10;
														int num11;
														checked
														{
															num11 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 1)]) + unchecked((byte)startFrame.GetLocalsRef<LocalVariables>().Instruction_25);
														}
														((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 1)] = (sbyte)num11;
														int num12;
														checked
														{
															num12 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 2)]) + unchecked((byte)startFrame.GetLocalsRef<LocalVariables>().Instruction_26);
														}
														((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 2)] = (sbyte)num12;
														((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 3)] = -1;
														int instruction_65 = startFrame.GetLocalsRef<LocalVariables>().Instruction_23;
														startFrame.GetLocalsRef<LocalVariables>().Instruction_23 = instruction_65 + 4;
													}
													while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_35);
												}
											}
											else
											{
												do
												{
													sbyte instruction_66 = startFrame.GetLocalsRef<LocalVariables>().Instruction_24;
													((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23] = instruction_66;
													sbyte instruction_67 = startFrame.GetLocalsRef<LocalVariables>().Instruction_25;
													((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 1)] = instruction_67;
													sbyte instruction_68 = startFrame.GetLocalsRef<LocalVariables>().Instruction_26;
													((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 2)] = instruction_68;
													((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 3)] = -1;
													int instruction_69 = startFrame.GetLocalsRef<LocalVariables>().Instruction_23;
													startFrame.GetLocalsRef<LocalVariables>().Instruction_23 = instruction_69 + 4;
												}
												while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_35);
											}
										}
										else
										{
											int instruction_70 = startFrame.GetLocalsRef<LocalVariables>().Instruction_27;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_38 = instruction_70 >>> 25;
											if (startFrame.GetLocalsRef<LocalVariables>().Instruction_38 != 0)
											{
												int instruction_71 = startFrame.GetLocalsRef<LocalVariables>().Instruction_27;
												startFrame.GetLocalsRef<LocalVariables>().Instruction_36 = (instruction_71 >>> 16) & 0x1FF;
												int instruction_72 = startFrame.GetLocalsRef<LocalVariables>().Instruction_38;
												startFrame.GetLocalsRef<LocalVariables>().Instruction_40 = instruction_72;
												if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_40 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_40)
												{
													_ = -1;
												}
												else
												{
													wassert.Invoke(String_bahgbqd.__pointer, String_uxbkrtb.__pointer, 2399);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													_ = 0;
												}
												int instruction_73 = startFrame.GetLocalsRef<LocalVariables>().Instruction_40;
												long instruction_74 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_74 >>> (int)(uint)instruction_73;
												int instruction_75 = startFrame.GetLocalsRef<LocalVariables>().Instruction_40;
												int instruction_76 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_76 - instruction_75;
												if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 >= 12u)
												{
													_ = -1;
												}
												else
												{
													wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2401);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													_ = 0;
												}
												int instruction_77 = *(int*)((byte*)ptr + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables>().Instruction_9 & 0xFFFL));
												startFrame.GetLocalsRef<LocalVariables>().Instruction_37 = instruction_77;
												int instruction_78 = startFrame.GetLocalsRef<LocalVariables>().Instruction_37;
												startFrame.GetLocalsRef<LocalVariables>().Instruction_39 = (instruction_78 >>> 9) & 0xF;
												if (startFrame.GetLocalsRef<LocalVariables>().Instruction_39 == 0)
												{
													goto IL_1e4b;
												}
											}
											else
											{
												if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 >= 12u)
												{
													_ = -1;
												}
												else
												{
													wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2409);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													_ = 0;
												}
												int instruction_79 = *(int*)((byte*)ptr + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables>().Instruction_9 & 0xFFFL));
												startFrame.GetLocalsRef<LocalVariables>().Instruction_36 = instruction_79;
												int instruction_80 = startFrame.GetLocalsRef<LocalVariables>().Instruction_36;
												startFrame.GetLocalsRef<LocalVariables>().Instruction_41 = (instruction_80 >>> 9) & 0xF;
												if (startFrame.GetLocalsRef<LocalVariables>().Instruction_41 == 0)
												{
													goto IL_1f5a;
												}
												int instruction_81 = startFrame.GetLocalsRef<LocalVariables>().Instruction_41;
												startFrame.GetLocalsRef<LocalVariables>().Instruction_42 = instruction_81;
												if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_42 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_42)
												{
													_ = -1;
												}
												else
												{
													wassert.Invoke(String_bahgbqd.__pointer, String_uxbkrtb.__pointer, 2414);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													_ = 0;
												}
												int instruction_82 = startFrame.GetLocalsRef<LocalVariables>().Instruction_42;
												long instruction_83 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_83 >>> (int)(uint)instruction_82;
												int instruction_84 = startFrame.GetLocalsRef<LocalVariables>().Instruction_42;
												int instruction_85 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_85 - instruction_84;
												int instruction_86 = startFrame.GetLocalsRef<LocalVariables>().Instruction_36;
												startFrame.GetLocalsRef<LocalVariables>().Instruction_39 = instruction_86 >>> 25;
												if (startFrame.GetLocalsRef<LocalVariables>().Instruction_39 != 0)
												{
													int instruction_87 = startFrame.GetLocalsRef<LocalVariables>().Instruction_36;
													startFrame.GetLocalsRef<LocalVariables>().Instruction_37 = instruction_87 >>> 16;
												}
												else
												{
													if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 >= 12u)
													{
														_ = -1;
													}
													else
													{
														wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2421);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														_ = 0;
													}
													int instruction_88 = *(int*)((byte*)ptr + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables>().Instruction_9 & 0xFFFL));
													startFrame.GetLocalsRef<LocalVariables>().Instruction_37 = instruction_88;
													int instruction_89 = startFrame.GetLocalsRef<LocalVariables>().Instruction_37;
													startFrame.GetLocalsRef<LocalVariables>().Instruction_39 = (instruction_89 >>> 9) & 0xF;
													if (startFrame.GetLocalsRef<LocalVariables>().Instruction_39 == 0)
													{
														goto IL_2216;
													}
												}
											}
											int instruction_90 = startFrame.GetLocalsRef<LocalVariables>().Instruction_39;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_43 = instruction_90;
											if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_43 <= 32u)
											{
												_ = -1;
											}
											else
											{
												wassert.Invoke(String_mf9hyza.__pointer, String_uxbkrtb.__pointer, 2429);
												if (ExceptionInfo.Current != null)
												{
													return false;
												}
												_ = 0;
											}
											int instruction_91 = startFrame.GetLocalsRef<LocalVariables>().Instruction_43;
											long instruction_92 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_92 >>> (int)(uint)instruction_91;
											int instruction_93 = startFrame.GetLocalsRef<LocalVariables>().Instruction_43;
											int instruction_94 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_94 - instruction_93;
											if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 < 32u)
											{
												if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)
												{
													goto IL_238a;
												}
												long num13 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10);
												long instruction_95 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_95 | num13;
												int instruction_96 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
												startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_96 + 4;
												int instruction_97 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_97 + 32;
											}
											if (((startFrame.GetLocalsRef<LocalVariables>().Instruction_36 | startFrame.GetLocalsRef<LocalVariables>().Instruction_37) & 0x100) != 0)
											{
												goto IL_24eb;
											}
											if (startFrame.GetLocalsRef<LocalVariables>().Instruction_16 != null)
											{
												int num14 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_16)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23];
												int instruction_98 = startFrame.GetLocalsRef<LocalVariables>().Instruction_28;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23] = (sbyte)(num14 + instruction_98);
												int num15 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 1)];
												int instruction_99 = startFrame.GetLocalsRef<LocalVariables>().Instruction_36;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 1)] = (sbyte)(num15 + instruction_99);
												int num16 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 2)];
												int instruction_100 = startFrame.GetLocalsRef<LocalVariables>().Instruction_37;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 2)] = (sbyte)(num16 + instruction_100);
												((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 3)] = -1;
											}
											else
											{
												int instruction_101 = startFrame.GetLocalsRef<LocalVariables>().Instruction_28;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23] = (sbyte)instruction_101;
												int instruction_102 = startFrame.GetLocalsRef<LocalVariables>().Instruction_36;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 1)] = (sbyte)instruction_102;
												int instruction_103 = startFrame.GetLocalsRef<LocalVariables>().Instruction_37;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 2)] = (sbyte)instruction_103;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 3)] = -1;
											}
											int instruction_104 = startFrame.GetLocalsRef<LocalVariables>().Instruction_23;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_23 = instruction_104 + 4;
											int instruction_105 = startFrame.GetLocalsRef<LocalVariables>().Instruction_28;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_24 = (sbyte)instruction_105;
											int instruction_106 = startFrame.GetLocalsRef<LocalVariables>().Instruction_36;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_25 = (sbyte)instruction_106;
											int instruction_107 = startFrame.GetLocalsRef<LocalVariables>().Instruction_37;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_26 = (sbyte)instruction_107;
											int instruction_108 = startFrame.GetLocalsRef<LocalVariables>().Instruction_37;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_44 = instruction_108 >>> 25;
											if (startFrame.GetLocalsRef<LocalVariables>().Instruction_44 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_7)
											{
												int instruction_109 = startFrame.GetLocalsRef<LocalVariables>().Instruction_37;
												startFrame.GetLocalsRef<LocalVariables>().Instruction_28 = (instruction_109 >>> 16) & 0x1FF;
												if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_28 < 256u)
												{
													int instruction_110 = startFrame.GetLocalsRef<LocalVariables>().Instruction_44;
													startFrame.GetLocalsRef<LocalVariables>().Instruction_45 = instruction_110;
													if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_45 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_45)
													{
														_ = -1;
													}
													else
													{
														wassert.Invoke(String_bahgbqd.__pointer, String_uxbkrtb.__pointer, 2481);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														_ = 0;
													}
													int instruction_111 = startFrame.GetLocalsRef<LocalVariables>().Instruction_45;
													long instruction_112 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
													startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_112 >>> (int)(uint)instruction_111;
													int instruction_113 = startFrame.GetLocalsRef<LocalVariables>().Instruction_45;
													int instruction_114 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
													startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_114 - instruction_113;
													if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 >= 12u)
													{
														_ = -1;
													}
													else
													{
														wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2483);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														_ = 0;
													}
													int instruction_115 = *(int*)((byte*)ptr + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables>().Instruction_9 & 0xFFFL));
													startFrame.GetLocalsRef<LocalVariables>().Instruction_36 = instruction_115;
													int instruction_116 = startFrame.GetLocalsRef<LocalVariables>().Instruction_36;
													startFrame.GetLocalsRef<LocalVariables>().Instruction_46 = (instruction_116 >>> 9) & 0xF;
													if (startFrame.GetLocalsRef<LocalVariables>().Instruction_46 == 0)
													{
														goto IL_2ce0;
													}
													int instruction_117 = startFrame.GetLocalsRef<LocalVariables>().Instruction_46;
													startFrame.GetLocalsRef<LocalVariables>().Instruction_47 = instruction_117;
													if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_47 <= 32u)
													{
														_ = -1;
													}
													else
													{
														wassert.Invoke(String_mf9hyza.__pointer, String_uxbkrtb.__pointer, 2488);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														_ = 0;
													}
													int instruction_118 = startFrame.GetLocalsRef<LocalVariables>().Instruction_47;
													long instruction_119 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
													startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_119 >>> (int)(uint)instruction_118;
													int instruction_120 = startFrame.GetLocalsRef<LocalVariables>().Instruction_47;
													int instruction_121 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
													startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_121 - instruction_120;
													if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 < 32u)
													{
														if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)
														{
															goto IL_2e50;
														}
														long num17 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10);
														long instruction_122 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
														startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_122 | num17;
														int instruction_123 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
														startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_123 + 4;
														int instruction_124 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
														startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_124 + 32;
													}
													int instruction_125 = startFrame.GetLocalsRef<LocalVariables>().Instruction_36;
													startFrame.GetLocalsRef<LocalVariables>().Instruction_39 = instruction_125 >>> 25;
													if (startFrame.GetLocalsRef<LocalVariables>().Instruction_39 != 0)
													{
														int instruction_126 = startFrame.GetLocalsRef<LocalVariables>().Instruction_36;
														startFrame.GetLocalsRef<LocalVariables>().Instruction_37 = instruction_126 >>> 16;
													}
													else
													{
														if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 >= 12u)
														{
															_ = -1;
														}
														else
														{
															wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2495);
															if (ExceptionInfo.Current != null)
															{
																return false;
															}
															_ = 0;
														}
														int instruction_127 = *(int*)((byte*)ptr + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables>().Instruction_9 & 0xFFFL));
														startFrame.GetLocalsRef<LocalVariables>().Instruction_37 = instruction_127;
														int instruction_128 = startFrame.GetLocalsRef<LocalVariables>().Instruction_37;
														startFrame.GetLocalsRef<LocalVariables>().Instruction_39 = (instruction_128 >>> 9) & 0xF;
														if (startFrame.GetLocalsRef<LocalVariables>().Instruction_39 == 0)
														{
															goto IL_30da;
														}
													}
													int instruction_129 = startFrame.GetLocalsRef<LocalVariables>().Instruction_39;
													startFrame.GetLocalsRef<LocalVariables>().Instruction_48 = instruction_129;
													if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_48 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_48)
													{
														_ = -1;
													}
													else
													{
														wassert.Invoke(String_bahgbqd.__pointer, String_uxbkrtb.__pointer, 2502);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														_ = 0;
													}
													int instruction_130 = startFrame.GetLocalsRef<LocalVariables>().Instruction_48;
													long instruction_131 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
													startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_131 >>> (int)(uint)instruction_130;
													int instruction_132 = startFrame.GetLocalsRef<LocalVariables>().Instruction_48;
													int instruction_133 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
													startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_133 - instruction_132;
													if (((startFrame.GetLocalsRef<LocalVariables>().Instruction_36 | startFrame.GetLocalsRef<LocalVariables>().Instruction_37) & 0x100) != 0)
													{
														goto IL_326f;
													}
													if (startFrame.GetLocalsRef<LocalVariables>().Instruction_16 != null)
													{
														int num18 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_16)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23];
														int instruction_134 = startFrame.GetLocalsRef<LocalVariables>().Instruction_28;
														((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23] = (sbyte)(num18 + instruction_134);
														int num19 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 1)];
														int instruction_135 = startFrame.GetLocalsRef<LocalVariables>().Instruction_36;
														((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 1)] = (sbyte)(num19 + instruction_135);
														int num20 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 2)];
														int instruction_136 = startFrame.GetLocalsRef<LocalVariables>().Instruction_37;
														((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 2)] = (sbyte)(num20 + instruction_136);
														((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 3)] = -1;
													}
													else
													{
														int instruction_137 = startFrame.GetLocalsRef<LocalVariables>().Instruction_28;
														((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23] = (sbyte)instruction_137;
														int instruction_138 = startFrame.GetLocalsRef<LocalVariables>().Instruction_36;
														((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 1)] = (sbyte)instruction_138;
														int instruction_139 = startFrame.GetLocalsRef<LocalVariables>().Instruction_37;
														((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 2)] = (sbyte)instruction_139;
														((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 3)] = -1;
													}
													int instruction_140 = startFrame.GetLocalsRef<LocalVariables>().Instruction_23;
													startFrame.GetLocalsRef<LocalVariables>().Instruction_23 = instruction_140 + 4;
													int instruction_141 = startFrame.GetLocalsRef<LocalVariables>().Instruction_28;
													startFrame.GetLocalsRef<LocalVariables>().Instruction_24 = (sbyte)instruction_141;
													int instruction_142 = startFrame.GetLocalsRef<LocalVariables>().Instruction_36;
													startFrame.GetLocalsRef<LocalVariables>().Instruction_25 = (sbyte)instruction_142;
													int instruction_143 = startFrame.GetLocalsRef<LocalVariables>().Instruction_37;
													startFrame.GetLocalsRef<LocalVariables>().Instruction_26 = (sbyte)instruction_143;
												}
											}
										}
										if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_7)
										{
											continue;
										}
										goto IL_378d;
									}
									startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
									break;
								}
								if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 >= 12u)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2560);
									if (ExceptionInfo.Current != null)
									{
										return false;
									}
									_ = 0;
								}
								int instruction_144 = *(int*)((byte*)ptr + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables>().Instruction_9 & 0xFFFL));
								startFrame.GetLocalsRef<LocalVariables>().Instruction_49 = instruction_144;
								int instruction_145 = startFrame.GetLocalsRef<LocalVariables>().Instruction_49;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_50 = (instruction_145 >>> 9) & 0xF;
								if (startFrame.GetLocalsRef<LocalVariables>().Instruction_50 == 0)
								{
									startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
									break;
								}
								int instruction_146 = startFrame.GetLocalsRef<LocalVariables>().Instruction_49;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_49 = instruction_146 & 0x1FF;
								if (startFrame.GetLocalsRef<LocalVariables>().Instruction_49 != 256)
								{
									startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
									break;
								}
								int instruction_147 = startFrame.GetLocalsRef<LocalVariables>().Instruction_50;
								int instruction_148 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_148 - instruction_147;
								int instruction_149 = startFrame.GetLocalsRef<LocalVariables>().Instruction_50;
								long instruction_150 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_150 >>> (int)(uint)instruction_149;
								int instruction_151 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_51 = instruction_151 & 7;
								int instruction_152 = startFrame.GetLocalsRef<LocalVariables>().Instruction_51;
								int instruction_153 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_153 - instruction_152;
								int instruction_154 = startFrame.GetLocalsRef<LocalVariables>().Instruction_51;
								long instruction_155 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_155 >>> (int)(uint)instruction_154;
								if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8 < (uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_10 >>> 3))
								{
									startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
									break;
								}
								int num21 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10 >>> 3;
								int instruction_156 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_156 - num21;
								if (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 + 4 != startFrame.GetLocalsRef<LocalVariables>().Instruction_4)
								{
									startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
								}
								else
								{
									startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = true;
								}
								break;
								IL_152b:
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
								break;
								IL_378d:
								void* instruction_157 = startFrame.GetLocalsRef<LocalVariables>().Instruction_17;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_16 = instruction_157;
								int instruction_158 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
								void* instruction_159 = startFrame.GetLocalsRef<LocalVariables>().Instruction_17;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_17 = (byte*)instruction_159 + (uint)instruction_158;
								int instruction_160 = startFrame.GetLocalsRef<LocalVariables>().Instruction_18;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_18 = instruction_160 + 1;
								continue;
								IL_1028:
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
								break;
								IL_326f:
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
								break;
								IL_0ee3:
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
								break;
								IL_14e2:
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
								break;
								IL_238a:
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
								break;
								IL_2216:
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
								break;
								IL_1e4b:
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
								break;
								IL_30da:
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
								break;
								IL_2e50:
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
								break;
								IL_24eb:
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
								break;
								IL_1f5a:
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
								break;
								IL_2ce0:
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
								break;
							}
						}
					}
				}
			}
			goto IL_3bd4;
		}
		IL_3bd4:
		bool instruction_161 = startFrame.GetLocalsRef<LocalVariables>().Instruction_0;
		StackFrameList.Current.Clear(startFrame);
		return instruction_161;
	}
}
