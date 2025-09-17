using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$fpng_pixel_zlib_decompress_4@$02@fpng@@YA_NPEBEIIPEAEII@Z")]
[DemangledName("bool __cdecl fpng::fpng_pixel_zlib_decompress_4<3>(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int, unsigned int)")]
[CleanName("fpng_pixel_zlib_decompress_4")]
internal static partial class fpng_pixel_zlib_decompress_4_xygi9td
{
	private partial struct LocalVariables
	{
		public int field_0;

		public long field_1;

		public int field_2;

		public InlineArray_4096_vqkfj7a field_3;
	}

	public unsafe static bool Invoke(void* pSrc, int src_len, int zlib_len, void* pDst, int w, int h)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		bool flag = false;
		int num = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0L;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = default(InlineArray_4096_vqkfj7a);
		void* ptr = null;
		void* ptr2 = null;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		int num11 = 0;
		sbyte b = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		sbyte b4 = 0;
		int num12 = 0;
		int num13 = 0;
		int num14 = 0;
		int num15 = 0;
		int num16 = 0;
		int num17 = 0;
		int num18 = 0;
		int num19 = 0;
		int num20 = 0;
		int num21 = 0;
		int num22 = 0;
		int num23 = 0;
		int num24 = 0;
		int num25 = 0;
		int num26 = 0;
		int num27 = 0;
		int num28 = 0;
		int num29 = 0;
		int num30 = 0;
		int num31 = 0;
		int num32 = 0;
		int num33 = 0;
		int num34 = 0;
		int num35 = 0;
		int num36 = 0;
		unchecked
		{
			int num37;
			if ((uint)src_len >= (uint)(zlib_len + 4))
			{
				num37 = -1;
			}
			else
			{
				wassert.Invoke(String_497patd.__pointer, String_uxbkrtb.__pointer, 2592);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				num37 = 0;
			}
			num = w * 3;
			if ((uint)zlib_len < 7u)
			{
				flag = false;
			}
			else if ((byte)(*(sbyte*)pSrc) != 120 || (byte)((sbyte*)pSrc)[1] != 1)
			{
				flag = false;
			}
			else
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = 2;
				if (((byte)((sbyte*)pSrc)[(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0] & 6) == 0)
				{
					bool flag2 = fpng_pixel_zlib_raw_decompress.Invoke(pSrc, src_len, zlib_len, pDst, w, h, 4, 3);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					flag = flag2;
				}
				else if ((uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4) > (uint)src_len)
				{
					flag = false;
				}
				else
				{
					long field_ = (uint)(*(int*)((byte*)pSrc + (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0));
					startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_;
					int field_2 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4;
					startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_2;
					startFrame.GetLocalsPointer<LocalVariables>()->field_2 = 32;
					num4 = 1;
					int num38;
					if (num4 != 0 && (uint)num4 <= 32u)
					{
						num38 = -1;
					}
					else
					{
						wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 2617);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						num38 = 0;
					}
					num2 = (int)(startFrame.GetLocalsPointer<LocalVariables>()->field_1 & (uint)((int*)g_bitmasks.__pointer)[(uint)num4]);
					int num39 = num4;
					long field_3 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
					startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_3 >>> (int)(uint)num39;
					int field_4 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num4;
					startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_4;
					if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 < 32u)
					{
						if ((uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4) > (uint)src_len)
						{
							flag = false;
							goto IL_1640;
						}
						long num40 = (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0)) << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2);
						long field_5 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 | num40;
						startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_5;
						int field_6 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4;
						startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_6;
						int field_7 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 32;
						startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_7;
					}
					num5 = 2;
					int num41;
					if (num5 != 0 && (uint)num5 <= 32u)
					{
						num41 = -1;
					}
					else
					{
						wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 2618);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						num41 = 0;
					}
					num3 = (int)(startFrame.GetLocalsPointer<LocalVariables>()->field_1 & (uint)((int*)g_bitmasks.__pointer)[(uint)num5]);
					int num42 = num5;
					long field_8 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
					startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_8 >>> (int)(uint)num42;
					int field_9 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num5;
					startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_9;
					if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 < 32u)
					{
						if ((uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4) > (uint)src_len)
						{
							flag = false;
							goto IL_1640;
						}
						long num43 = (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0)) << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2);
						long field_10 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 | num43;
						startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_10;
						int field_11 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4;
						startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_11;
						int field_12 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 32;
						startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_12;
					}
					if (num2 != 1 || num3 != 2)
					{
						flag = false;
					}
					else
					{
						bool flag3 = prepare_dynamic_block.Invoke(pLit_table: &startFrame.GetLocalsPointer<LocalVariables>()->field_3, pSrc: pSrc, src_len: src_len, src_ofs: &startFrame.GetLocalsPointer<LocalVariables>()->field_0, bit_buf_size: &startFrame.GetLocalsPointer<LocalVariables>()->field_2, bit_buf: &startFrame.GetLocalsPointer<LocalVariables>()->field_1, num_chans: 4);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag3)
						{
							flag = false;
						}
						else
						{
							ptr = null;
							ptr2 = pDst;
							num6 = 0;
							while (true)
							{
								if ((uint)num6 < (uint)h)
								{
									int num44;
									if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= 12u)
									{
										num44 = -1;
									}
									else
									{
										wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2634);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										num44 = 0;
									}
									long num45 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 0xFFFL;
									num7 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_3))[num45];
									num8 = (num7 >>> 9) & 0xF;
									if (num8 == 0)
									{
										flag = false;
										break;
									}
									num9 = num8;
									int num46;
									if ((uint)num9 <= 32u)
									{
										num46 = -1;
									}
									else
									{
										wassert.Invoke(String_mf9hyza.__pointer, String_uxbkrtb.__pointer, 2639);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										num46 = 0;
									}
									int num47 = num9;
									long field_13 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
									startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_13 >>> (int)(uint)num47;
									int field_14 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num9;
									startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_14;
									if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 < 32u)
									{
										if ((uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4) > (uint)src_len)
										{
											flag = false;
											break;
										}
										long num48 = (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0)) << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2);
										long field_15 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 | num48;
										startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_15;
										int field_16 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4;
										startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_16;
										int field_17 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 32;
										startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_17;
									}
									num7 &= 0x1FF;
									bool flag4 = num6 != 0;
									_ = flag4;
									if (num7 != InstructionHelper.Select(flag4, 2, 0))
									{
										flag = false;
										break;
									}
									num11 = 0;
									b = 0;
									b2 = 0;
									b3 = 0;
									b4 = 0;
									while (true)
									{
										int num49;
										if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= 12u)
										{
											num49 = -1;
										}
										else
										{
											wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2650);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											num49 = 0;
										}
										long num50 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 0xFFFL;
										num12 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_3))[num50];
										num13 = num12;
										num14 = (num12 >>> 9) & 0xF;
										if (num14 == 0)
										{
											break;
										}
										num15 = num14;
										int num51;
										if ((uint)num15 <= 32u)
										{
											num51 = -1;
										}
										else
										{
											wassert.Invoke(String_mf9hyza.__pointer, String_uxbkrtb.__pointer, 2657);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											num51 = 0;
										}
										int num52 = num15;
										long field_18 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
										startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_18 >>> (int)(uint)num52;
										int field_19 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num15;
										startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_19;
										if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 < 32u)
										{
											if ((uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4) > (uint)src_len)
											{
												goto IL_08e0;
											}
											long num53 = (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0)) << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2);
											long field_20 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 | num53;
											startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_20;
											int field_21 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4;
											startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_21;
											int field_22 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 32;
											startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_22;
										}
										if ((num13 & 0x100) != 0)
										{
											num13 &= 0x1FF;
											if (num13 == 256)
											{
												goto IL_099b;
											}
											num16 = ((int*)s_length_range.__pointer)[(uint)(num13 - 257)];
											if ((uint)num13 >= 265u)
											{
												num18 = ((int*)s_length_extra.__pointer)[(uint)(num13 - 257)];
												int num54;
												if (num18 != 0 && (uint)num18 <= 32u && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= (uint)num18)
												{
													num54 = -1;
												}
												else
												{
													wassert.Invoke(String_ftb25bb.__pointer, String_uxbkrtb.__pointer, 2672);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													num54 = 0;
												}
												num17 = (int)(startFrame.GetLocalsPointer<LocalVariables>()->field_1 & (uint)((int*)g_bitmasks.__pointer)[(uint)num18]);
												int num55 = num18;
												long field_23 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
												startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_23 >>> (int)(uint)num55;
												int field_24 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num18;
												startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_24;
												num16 += num17;
											}
											num19 = 1;
											int num56;
											if ((uint)num19 <= 32u && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= (uint)num19)
											{
												num56 = -1;
											}
											else
											{
												wassert.Invoke(String_bahgbqd.__pointer, String_uxbkrtb.__pointer, 2678);
												if (ExceptionInfo.Current != null)
												{
													return false;
												}
												num56 = 0;
											}
											int num57 = num19;
											long field_25 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
											startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_25 >>> (int)(uint)num57;
											int field_26 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num19;
											startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_26;
											if ((num16 & 3) != 0)
											{
												goto IL_0b65;
											}
											num20 = (num16 >>> 2) * 3;
											num21 = num11 + num20;
											if ((uint)num21 > (uint)num)
											{
												goto IL_0b84;
											}
											if (ptr != null)
											{
												if (((byte)b | (byte)b2 | (byte)b3 | (byte)b4) == 0)
												{
													llvm_memcpy_p0_p0_i64.Invoke((byte*)ptr2 + (uint)num11, (byte*)ptr + (uint)num11, (uint)num20, isVolatile: false);
													num11 = num21;
												}
												else
												{
													do
													{
														((sbyte*)ptr2)[(uint)num11] = (sbyte)checked(unchecked((byte)((sbyte*)ptr)[(uint)num11]) + unchecked((byte)b));
														((sbyte*)ptr2)[(uint)(num11 + 1)] = (sbyte)checked(unchecked((byte)((sbyte*)ptr)[(uint)(num11 + 1)]) + unchecked((byte)b2));
														((sbyte*)ptr2)[(uint)(num11 + 2)] = (sbyte)checked(unchecked((byte)((sbyte*)ptr)[(uint)(num11 + 2)]) + unchecked((byte)b3));
														num11 += 3;
													}
													while ((uint)num11 < (uint)num21);
												}
											}
											else
											{
												do
												{
													((sbyte*)ptr2)[(uint)num11] = b;
													((sbyte*)ptr2)[(uint)(num11 + 1)] = b2;
													((sbyte*)ptr2)[(uint)(num11 + 2)] = b3;
													num11 += 3;
												}
												while ((uint)num11 < (uint)num21);
											}
										}
										else
										{
											num24 = num12 >>> 25;
											if (num24 != 0)
											{
												num22 = (num12 >>> 16) & 0x1FF;
												num26 = num24;
												int num58;
												if ((uint)num26 <= 32u && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= (uint)num26)
												{
													num58 = -1;
												}
												else
												{
													wassert.Invoke(String_bahgbqd.__pointer, String_uxbkrtb.__pointer, 2771);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													num58 = 0;
												}
												int num59 = num26;
												long field_27 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
												startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_27 >>> (int)(uint)num59;
												int field_28 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num26;
												startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_28;
												int num60;
												if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= 12u)
												{
													num60 = -1;
												}
												else
												{
													wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2773);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													num60 = 0;
												}
												long num61 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 0xFFFL;
												num23 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_3))[num61];
												num25 = (num23 >>> 9) & 0xF;
												if (num25 == 0)
												{
													goto IL_0dd7;
												}
											}
											else
											{
												int num62;
												if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= 12u)
												{
													num62 = -1;
												}
												else
												{
													wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2781);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													num62 = 0;
												}
												long num63 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 0xFFFL;
												num22 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_3))[num63];
												num27 = (num22 >>> 9) & 0xF;
												if (num27 == 0)
												{
													goto IL_0e61;
												}
												num28 = num27;
												int num64;
												if ((uint)num28 <= 32u && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= (uint)num28)
												{
													num64 = -1;
												}
												else
												{
													wassert.Invoke(String_bahgbqd.__pointer, String_uxbkrtb.__pointer, 2786);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													num64 = 0;
												}
												int num65 = num28;
												long field_29 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
												startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_29 >>> (int)(uint)num65;
												int field_30 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num28;
												startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_30;
												num25 = num22 >>> 25;
												if (num25 != 0)
												{
													num23 = num22 >>> 16;
												}
												else
												{
													int num66;
													if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= 12u)
													{
														num66 = -1;
													}
													else
													{
														wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2793);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														num66 = 0;
													}
													long num67 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 0xFFFL;
													num23 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_3))[num67];
													num25 = (num23 >>> 9) & 0xF;
													if (num25 == 0)
													{
														goto IL_0fa0;
													}
												}
											}
											num30 = num23 >>> 25;
											if (num30 != 0)
											{
												num29 = num23 >>> 16;
												num31 = num25 + num30;
												int num68;
												if ((uint)num31 <= 32u)
												{
													num68 = -1;
												}
												else
												{
													wassert.Invoke(String_mf9hyza.__pointer, String_uxbkrtb.__pointer, 2807);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													num68 = 0;
												}
												int num69 = num31;
												long field_31 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
												startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_31 >>> (int)(uint)num69;
												int field_32 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num31;
												startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_32;
												if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 < 32u)
												{
													if ((uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4) > (uint)src_len)
													{
														goto IL_107c;
													}
													long num70 = (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0)) << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2);
													long field_33 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 | num70;
													startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_33;
													int field_34 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4;
													startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_34;
													int field_35 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 32;
													startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_35;
												}
											}
											else
											{
												num32 = num25;
												int num71;
												if ((uint)num32 <= 32u)
												{
													num71 = -1;
												}
												else
												{
													wassert.Invoke(String_mf9hyza.__pointer, String_uxbkrtb.__pointer, 2811);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													num71 = 0;
												}
												int num72 = num32;
												long field_36 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
												startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_36 >>> (int)(uint)num72;
												int field_37 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num32;
												startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_37;
												if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 < 32u)
												{
													if ((uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4) > (uint)src_len)
													{
														goto IL_11c1;
													}
													long num73 = (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0)) << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2);
													long field_38 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 | num73;
													startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_38;
													int field_39 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4;
													startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_39;
													int field_40 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 32;
													startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_40;
												}
												int num74;
												if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= 12u)
												{
													num74 = -1;
												}
												else
												{
													wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2813);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													num74 = 0;
												}
												long num75 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 0xFFFL;
												num29 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_3))[num75];
												num30 = (num29 >>> 9) & 0xF;
												if (num30 == 0)
												{
													goto IL_12ce;
												}
												num33 = num30;
												int num76;
												if ((uint)num33 <= 32u && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= (uint)num33)
												{
													num76 = -1;
												}
												else
												{
													wassert.Invoke(String_bahgbqd.__pointer, String_uxbkrtb.__pointer, 2819);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													num76 = 0;
												}
												int num77 = num33;
												long field_41 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
												startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_41 >>> (int)(uint)num77;
												int field_42 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num33;
												startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_42;
											}
											if (((num22 | num23 | num29) & 0x100) != 0)
											{
												goto IL_138a;
											}
											if (ptr != null)
											{
												((sbyte*)ptr2)[(uint)num11] = (sbyte)((byte)((sbyte*)ptr)[(uint)num11] + num13);
												((sbyte*)ptr2)[(uint)(num11 + 1)] = (sbyte)((byte)((sbyte*)ptr)[(uint)(num11 + 1)] + num22);
												((sbyte*)ptr2)[(uint)(num11 + 2)] = (sbyte)((byte)((sbyte*)ptr)[(uint)(num11 + 2)] + num23);
											}
											else
											{
												((sbyte*)ptr2)[(uint)num11] = (sbyte)num13;
												((sbyte*)ptr2)[(uint)(num11 + 1)] = (sbyte)num22;
												((sbyte*)ptr2)[(uint)(num11 + 2)] = (sbyte)num23;
											}
											num11 += 3;
											b = (sbyte)num13;
											b2 = (sbyte)num22;
											b3 = (sbyte)num23;
											b4 = (sbyte)num29;
										}
										if ((uint)num11 < (uint)num)
										{
											continue;
										}
										goto IL_145c;
									}
									flag = false;
									break;
								}
								int num78;
								if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= 12u)
								{
									num78 = -1;
								}
								else
								{
									wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2876);
									if (ExceptionInfo.Current != null)
									{
										return false;
									}
									num78 = 0;
								}
								long num79 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 0xFFFL;
								num34 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_3))[num79];
								num35 = (num34 >>> 9) & 0xF;
								if (num35 == 0)
								{
									flag = false;
									break;
								}
								if ((num34 & 0x1FF) != 256)
								{
									flag = false;
									break;
								}
								int field_43 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num35;
								startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_43;
								int num80 = num35;
								long field_44 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
								startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_44 >>> (int)(uint)num80;
								num36 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 & 7;
								int field_45 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num36;
								startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_45;
								int num81 = num36;
								long field_46 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
								startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_46 >>> (int)(uint)num81;
								if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0 < (uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_2 >>> 3))
								{
									flag = false;
									break;
								}
								int num82 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 >>> 3;
								int field_47 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 - num82;
								startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_47;
								flag = ((startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4 == zlib_len) ? true : false);
								break;
								IL_11c1:
								flag = false;
								break;
								IL_0b84:
								flag = false;
								break;
								IL_107c:
								flag = false;
								break;
								IL_099b:
								flag = false;
								break;
								IL_08e0:
								flag = false;
								break;
								IL_0dd7:
								flag = false;
								break;
								IL_145c:
								ptr = ptr2;
								ptr2 = (byte*)ptr2 + (uint)num;
								num6++;
								continue;
								IL_0b65:
								flag = false;
								break;
								IL_0e61:
								flag = false;
								break;
								IL_12ce:
								flag = false;
								break;
								IL_138a:
								flag = false;
								break;
								IL_0fa0:
								flag = false;
								break;
							}
						}
					}
				}
			}
			goto IL_1640;
		}
		IL_1640:
		bool result = flag;
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
