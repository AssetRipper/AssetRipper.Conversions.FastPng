using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$fpng_pixel_zlib_decompress_4@$03@fpng@@YA_NPEBEIIPEAEII@Z")]
[DemangledName("bool __cdecl fpng::fpng_pixel_zlib_decompress_4<4>(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int, unsigned int)")]
[CleanName("fpng_pixel_zlib_decompress_4")]
internal static partial class fpng_pixel_zlib_decompress_4_amptoaa
{
	private partial struct LocalVariables
	{
		public int field_0;

		public long field_1;

		public int field_2;

		public InlineArray_4096_vqkfj7a field_3;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("unsigned char const *")] void* pSrc, [NativeType("unsigned int")] int src_len, [NativeType("unsigned int")] int zlib_len, [NativeType("unsigned char *")] void* pDst, [NativeType("unsigned int")] int w, [NativeType("unsigned int")] int h)
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
		unchecked
		{
			int num36;
			if ((uint)src_len >= (uint)(zlib_len + 4))
			{
				num36 = -1;
			}
			else
			{
				wassert.Invoke(String_497patd.__pointer, String_uxbkrtb.__pointer, 2592);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				num36 = 0;
			}
			num = w * 4;
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
					bool flag2 = fpng_pixel_zlib_raw_decompress.Invoke(pSrc, src_len, zlib_len, pDst, w, h, 4, 4);
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
					int num37;
					if (num4 != 0 && (uint)num4 <= 32u)
					{
						num37 = -1;
					}
					else
					{
						wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 2617);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						num37 = 0;
					}
					num2 = (int)(startFrame.GetLocalsPointer<LocalVariables>()->field_1 & (uint)((int*)g_bitmasks.__pointer)[(uint)num4]);
					int num38 = num4;
					long field_3 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
					startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_3 >>> (int)(uint)num38;
					int field_4 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num4;
					startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_4;
					if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 < 32u)
					{
						if ((uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4) > (uint)src_len)
						{
							flag = false;
							goto IL_16a0;
						}
						long num39 = (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0)) << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2);
						long field_5 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 | num39;
						startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_5;
						int field_6 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4;
						startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_6;
						int field_7 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 32;
						startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_7;
					}
					num5 = 2;
					int num40;
					if (num5 != 0 && (uint)num5 <= 32u)
					{
						num40 = -1;
					}
					else
					{
						wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 2618);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						num40 = 0;
					}
					num3 = (int)(startFrame.GetLocalsPointer<LocalVariables>()->field_1 & (uint)((int*)g_bitmasks.__pointer)[(uint)num5]);
					int num41 = num5;
					long field_8 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
					startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_8 >>> (int)(uint)num41;
					int field_9 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num5;
					startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_9;
					if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 < 32u)
					{
						if ((uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4) > (uint)src_len)
						{
							flag = false;
							goto IL_16a0;
						}
						long num42 = (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0)) << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2);
						long field_10 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 | num42;
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
									int num43;
									if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= 12u)
									{
										num43 = -1;
									}
									else
									{
										wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2634);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										num43 = 0;
									}
									long num44 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 0xFFFL;
									num7 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_3))[num44];
									num8 = (num7 >>> 9) & 0xF;
									if (num8 == 0)
									{
										flag = false;
										break;
									}
									num9 = num8;
									int num45;
									if ((uint)num9 <= 32u)
									{
										num45 = -1;
									}
									else
									{
										wassert.Invoke(String_mf9hyza.__pointer, String_uxbkrtb.__pointer, 2639);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										num45 = 0;
									}
									int num46 = num9;
									long field_13 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
									startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_13 >>> (int)(uint)num46;
									int field_14 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num9;
									startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_14;
									if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 < 32u)
									{
										if ((uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4) > (uint)src_len)
										{
											flag = false;
											break;
										}
										long num47 = (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0)) << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2);
										long field_15 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 | num47;
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
										int num48;
										if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= 12u)
										{
											num48 = -1;
										}
										else
										{
											wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2650);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											num48 = 0;
										}
										long num49 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 0xFFFL;
										num12 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_3))[num49];
										num13 = num12;
										num14 = (num12 >>> 9) & 0xF;
										if (num14 == 0)
										{
											break;
										}
										num15 = num14;
										int num50;
										if ((uint)num15 <= 32u)
										{
											num50 = -1;
										}
										else
										{
											wassert.Invoke(String_mf9hyza.__pointer, String_uxbkrtb.__pointer, 2657);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											num50 = 0;
										}
										int num51 = num15;
										long field_18 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
										startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_18 >>> (int)(uint)num51;
										int field_19 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num15;
										startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_19;
										if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 < 32u)
										{
											if ((uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4) > (uint)src_len)
											{
												goto IL_08dd;
											}
											long num52 = (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0)) << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2);
											long field_20 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 | num52;
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
												goto IL_0998;
											}
											num16 = ((int*)s_length_range.__pointer)[(uint)(num13 - 257)];
											if ((uint)num13 >= 265u)
											{
												num18 = ((int*)s_length_extra.__pointer)[(uint)(num13 - 257)];
												int num53;
												if (num18 != 0 && (uint)num18 <= 32u && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= (uint)num18)
												{
													num53 = -1;
												}
												else
												{
													wassert.Invoke(String_ftb25bb.__pointer, String_uxbkrtb.__pointer, 2672);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													num53 = 0;
												}
												num17 = (int)(startFrame.GetLocalsPointer<LocalVariables>()->field_1 & (uint)((int*)g_bitmasks.__pointer)[(uint)num18]);
												int num54 = num18;
												long field_23 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
												startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_23 >>> (int)(uint)num54;
												int field_24 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num18;
												startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_24;
												num16 += num17;
											}
											num19 = 1;
											int num55;
											if ((uint)num19 <= 32u && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= (uint)num19)
											{
												num55 = -1;
											}
											else
											{
												wassert.Invoke(String_bahgbqd.__pointer, String_uxbkrtb.__pointer, 2678);
												if (ExceptionInfo.Current != null)
												{
													return false;
												}
												num55 = 0;
											}
											int num56 = num19;
											long field_25 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
											startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_25 >>> (int)(uint)num56;
											int field_26 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num19;
											startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_26;
											if ((num16 & 3) != 0)
											{
												goto IL_0b62;
											}
											num20 = num11 + num16;
											if ((uint)num20 > (uint)num)
											{
												goto IL_0b79;
											}
											if (ptr != null)
											{
												if (((byte)b | (byte)b2 | (byte)b3 | (byte)b4) == 0)
												{
													llvm_memcpy_p0_p0_i64.Invoke((byte*)ptr2 + (uint)num11, (byte*)ptr + (uint)num11, (uint)num16, isVolatile: false);
													num11 = num20;
												}
												else
												{
													do
													{
														((sbyte*)ptr2)[(uint)num11] = (sbyte)checked(unchecked((byte)((sbyte*)ptr)[(uint)num11]) + unchecked((byte)b));
														((sbyte*)ptr2)[(uint)(num11 + 1)] = (sbyte)checked(unchecked((byte)((sbyte*)ptr)[(uint)(num11 + 1)]) + unchecked((byte)b2));
														((sbyte*)ptr2)[(uint)(num11 + 2)] = (sbyte)checked(unchecked((byte)((sbyte*)ptr)[(uint)(num11 + 2)]) + unchecked((byte)b3));
														((sbyte*)ptr2)[(uint)(num11 + 3)] = (sbyte)checked(unchecked((byte)((sbyte*)ptr)[(uint)(num11 + 3)]) + unchecked((byte)b4));
														num11 += 4;
													}
													while ((uint)num11 < (uint)num20);
												}
											}
											else
											{
												do
												{
													((sbyte*)ptr2)[(uint)num11] = b;
													((sbyte*)ptr2)[(uint)(num11 + 1)] = b2;
													((sbyte*)ptr2)[(uint)(num11 + 2)] = b3;
													((sbyte*)ptr2)[(uint)(num11 + 3)] = b4;
													num11 += 4;
												}
												while ((uint)num11 < (uint)num20);
											}
										}
										else
										{
											num23 = num12 >>> 25;
											if (num23 != 0)
											{
												num21 = (num12 >>> 16) & 0x1FF;
												num25 = num23;
												int num57;
												if ((uint)num25 <= 32u && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= (uint)num25)
												{
													num57 = -1;
												}
												else
												{
													wassert.Invoke(String_bahgbqd.__pointer, String_uxbkrtb.__pointer, 2771);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													num57 = 0;
												}
												int num58 = num25;
												long field_27 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
												startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_27 >>> (int)(uint)num58;
												int field_28 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num25;
												startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_28;
												int num59;
												if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= 12u)
												{
													num59 = -1;
												}
												else
												{
													wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2773);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													num59 = 0;
												}
												long num60 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 0xFFFL;
												num22 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_3))[num60];
												num24 = (num22 >>> 9) & 0xF;
												if (num24 == 0)
												{
													goto IL_0e05;
												}
											}
											else
											{
												int num61;
												if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= 12u)
												{
													num61 = -1;
												}
												else
												{
													wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2781);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													num61 = 0;
												}
												long num62 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 0xFFFL;
												num21 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_3))[num62];
												num26 = (num21 >>> 9) & 0xF;
												if (num26 == 0)
												{
													goto IL_0e8f;
												}
												num27 = num26;
												int num63;
												if ((uint)num27 <= 32u && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= (uint)num27)
												{
													num63 = -1;
												}
												else
												{
													wassert.Invoke(String_bahgbqd.__pointer, String_uxbkrtb.__pointer, 2786);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													num63 = 0;
												}
												int num64 = num27;
												long field_29 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
												startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_29 >>> (int)(uint)num64;
												int field_30 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num27;
												startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_30;
												num24 = num21 >>> 25;
												if (num24 != 0)
												{
													num22 = num21 >>> 16;
												}
												else
												{
													int num65;
													if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= 12u)
													{
														num65 = -1;
													}
													else
													{
														wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2793);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														num65 = 0;
													}
													long num66 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 0xFFFL;
													num22 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_3))[num66];
													num24 = (num22 >>> 9) & 0xF;
													if (num24 == 0)
													{
														goto IL_0fce;
													}
												}
											}
											num29 = num22 >>> 25;
											if (num29 != 0)
											{
												num28 = num22 >>> 16;
												num30 = num24 + num29;
												int num67;
												if ((uint)num30 <= 32u)
												{
													num67 = -1;
												}
												else
												{
													wassert.Invoke(String_mf9hyza.__pointer, String_uxbkrtb.__pointer, 2807);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													num67 = 0;
												}
												int num68 = num30;
												long field_31 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
												startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_31 >>> (int)(uint)num68;
												int field_32 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num30;
												startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_32;
												if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 < 32u)
												{
													if ((uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4) > (uint)src_len)
													{
														goto IL_10aa;
													}
													long num69 = (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0)) << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2);
													long field_33 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 | num69;
													startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_33;
													int field_34 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4;
													startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_34;
													int field_35 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 32;
													startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_35;
												}
											}
											else
											{
												num31 = num24;
												int num70;
												if ((uint)num31 <= 32u)
												{
													num70 = -1;
												}
												else
												{
													wassert.Invoke(String_mf9hyza.__pointer, String_uxbkrtb.__pointer, 2811);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													num70 = 0;
												}
												int num71 = num31;
												long field_36 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
												startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_36 >>> (int)(uint)num71;
												int field_37 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num31;
												startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_37;
												if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 < 32u)
												{
													if ((uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4) > (uint)src_len)
													{
														goto IL_11ef;
													}
													long num72 = (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0)) << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2);
													long field_38 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 | num72;
													startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_38;
													int field_39 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4;
													startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_39;
													int field_40 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 32;
													startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_40;
												}
												int num73;
												if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= 12u)
												{
													num73 = -1;
												}
												else
												{
													wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2813);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													num73 = 0;
												}
												long num74 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 0xFFFL;
												num28 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_3))[num74];
												num29 = (num28 >>> 9) & 0xF;
												if (num29 == 0)
												{
													goto IL_12fc;
												}
												num32 = num29;
												int num75;
												if ((uint)num32 <= 32u && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= (uint)num32)
												{
													num75 = -1;
												}
												else
												{
													wassert.Invoke(String_bahgbqd.__pointer, String_uxbkrtb.__pointer, 2819);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													num75 = 0;
												}
												int num76 = num32;
												long field_41 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
												startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_41 >>> (int)(uint)num76;
												int field_42 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num32;
												startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_42;
											}
											if (((num21 | num22 | num28) & 0x100) != 0)
											{
												goto IL_13b8;
											}
											if (ptr != null)
											{
												((sbyte*)ptr2)[(uint)num11] = (sbyte)((byte)((sbyte*)ptr)[(uint)num11] + num13);
												((sbyte*)ptr2)[(uint)(num11 + 1)] = (sbyte)((byte)((sbyte*)ptr)[(uint)(num11 + 1)] + num21);
												((sbyte*)ptr2)[(uint)(num11 + 2)] = (sbyte)((byte)((sbyte*)ptr)[(uint)(num11 + 2)] + num22);
												((sbyte*)ptr2)[(uint)(num11 + 3)] = (sbyte)((byte)((sbyte*)ptr)[(uint)(num11 + 3)] + num28);
											}
											else
											{
												((sbyte*)ptr2)[(uint)num11] = (sbyte)num13;
												((sbyte*)ptr2)[(uint)(num11 + 1)] = (sbyte)num21;
												((sbyte*)ptr2)[(uint)(num11 + 2)] = (sbyte)num22;
												((sbyte*)ptr2)[(uint)(num11 + 3)] = (sbyte)num28;
											}
											num11 += 4;
											b = (sbyte)num13;
											b2 = (sbyte)num21;
											b3 = (sbyte)num22;
											b4 = (sbyte)num28;
										}
										if ((uint)num11 < (uint)num)
										{
											continue;
										}
										goto IL_14bc;
									}
									flag = false;
									break;
								}
								int num77;
								if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= 12u)
								{
									num77 = -1;
								}
								else
								{
									wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2876);
									if (ExceptionInfo.Current != null)
									{
										return false;
									}
									num77 = 0;
								}
								long num78 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 0xFFFL;
								num33 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_3))[num78];
								num34 = (num33 >>> 9) & 0xF;
								if (num34 == 0)
								{
									flag = false;
									break;
								}
								if ((num33 & 0x1FF) != 256)
								{
									flag = false;
									break;
								}
								int field_43 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num34;
								startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_43;
								int num79 = num34;
								long field_44 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
								startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_44 >>> (int)(uint)num79;
								num35 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 & 7;
								int field_45 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num35;
								startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_45;
								int num80 = num35;
								long field_46 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
								startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_46 >>> (int)(uint)num80;
								if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0 < (uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_2 >>> 3))
								{
									flag = false;
									break;
								}
								int num81 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 >>> 3;
								int field_47 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 - num81;
								startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_47;
								flag = ((startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4 == zlib_len) ? true : false);
								break;
								IL_11ef:
								flag = false;
								break;
								IL_0b79:
								flag = false;
								break;
								IL_10aa:
								flag = false;
								break;
								IL_0998:
								flag = false;
								break;
								IL_08dd:
								flag = false;
								break;
								IL_0e05:
								flag = false;
								break;
								IL_14bc:
								ptr = ptr2;
								ptr2 = (byte*)ptr2 + (uint)num;
								num6++;
								continue;
								IL_0b62:
								flag = false;
								break;
								IL_0e8f:
								flag = false;
								break;
								IL_12fc:
								flag = false;
								break;
								IL_13b8:
								flag = false;
								break;
								IL_0fce:
								flag = false;
								break;
							}
						}
					}
				}
			}
			goto IL_16a0;
		}
		IL_16a0:
		bool result = flag;
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
