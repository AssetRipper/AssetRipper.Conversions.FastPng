using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$fpng_pixel_zlib_decompress_3@$02@fpng@@YA_NPEBEIIPEAEII@Z")]
[DemangledName("bool __cdecl fpng::fpng_pixel_zlib_decompress_3<3>(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int, unsigned int)")]
[CleanName("fpng_pixel_zlib_decompress_3")]
internal static partial class fpng_pixel_zlib_decompress_3_prmnnjb
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
				wassert.Invoke(String_497patd.__pointer, String_uxbkrtb.__pointer, 2214);
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
					bool flag2 = fpng_pixel_zlib_raw_decompress.Invoke(pSrc, src_len, zlib_len, pDst, w, h, 3, 3);
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
						wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 2239);
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
							goto IL_1890;
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
						wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 2240);
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
							goto IL_1890;
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
						bool flag3 = prepare_dynamic_block.Invoke(pLit_table: &startFrame.GetLocalsPointer<LocalVariables>()->field_3, pSrc: pSrc, src_len: src_len, src_ofs: &startFrame.GetLocalsPointer<LocalVariables>()->field_0, bit_buf_size: &startFrame.GetLocalsPointer<LocalVariables>()->field_2, bit_buf: &startFrame.GetLocalsPointer<LocalVariables>()->field_1, num_chans: 3);
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
										wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2256);
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
										wassert.Invoke(String_mf9hyza.__pointer, String_uxbkrtb.__pointer, 2261);
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
									while (true)
									{
										int num49;
										if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= 12u)
										{
											num49 = -1;
										}
										else
										{
											wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2272);
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
											wassert.Invoke(String_mf9hyza.__pointer, String_uxbkrtb.__pointer, 2279);
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
												goto IL_08da;
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
												goto IL_0995;
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
													wassert.Invoke(String_ftb25bb.__pointer, String_uxbkrtb.__pointer, 2294);
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
												wassert.Invoke(String_bahgbqd.__pointer, String_uxbkrtb.__pointer, 2300);
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
											int num58;
											if ((uint)num16 % 3u == 0)
											{
												num58 = -1;
											}
											else
											{
												wassert.Invoke(String_a5rp7bb.__pointer, String_uxbkrtb.__pointer, 2303);
												if (ExceptionInfo.Current != null)
												{
													return false;
												}
												num58 = 0;
											}
											if (((short*)g_run_len3_to_4.__pointer)[(uint)num16] == 0)
											{
												goto IL_0b9b;
											}
											num20 = num11 + num16;
											if ((uint)num20 > (uint)num)
											{
												goto IL_0bb2;
											}
											if (ptr != null)
											{
												if (((byte)b | (byte)b2 | (byte)b3) == 0)
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
														num11 += 3;
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
													num11 += 3;
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
												int num59;
												if ((uint)num25 <= 32u && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= (uint)num25)
												{
													num59 = -1;
												}
												else
												{
													wassert.Invoke(String_bahgbqd.__pointer, String_uxbkrtb.__pointer, 2399);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													num59 = 0;
												}
												int num60 = num25;
												long field_27 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
												startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_27 >>> (int)(uint)num60;
												int field_28 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num25;
												startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_28;
												int num61;
												if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= 12u)
												{
													num61 = -1;
												}
												else
												{
													wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2401);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													num61 = 0;
												}
												long num62 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 0xFFFL;
												num22 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_3))[num62];
												num24 = (num22 >>> 9) & 0xF;
												if (num24 == 0)
												{
													goto IL_0e00;
												}
											}
											else
											{
												int num63;
												if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= 12u)
												{
													num63 = -1;
												}
												else
												{
													wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2409);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													num63 = 0;
												}
												long num64 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 0xFFFL;
												num21 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_3))[num64];
												num26 = (num21 >>> 9) & 0xF;
												if (num26 == 0)
												{
													goto IL_0e8a;
												}
												num27 = num26;
												int num65;
												if ((uint)num27 <= 32u && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= (uint)num27)
												{
													num65 = -1;
												}
												else
												{
													wassert.Invoke(String_bahgbqd.__pointer, String_uxbkrtb.__pointer, 2414);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													num65 = 0;
												}
												int num66 = num27;
												long field_29 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
												startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_29 >>> (int)(uint)num66;
												int field_30 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num27;
												startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_30;
												num24 = num21 >>> 25;
												if (num24 != 0)
												{
													num22 = num21 >>> 16;
												}
												else
												{
													int num67;
													if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= 12u)
													{
														num67 = -1;
													}
													else
													{
														wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2421);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														num67 = 0;
													}
													long num68 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 0xFFFL;
													num22 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_3))[num68];
													num24 = (num22 >>> 9) & 0xF;
													if (num24 == 0)
													{
														goto IL_0fc9;
													}
												}
											}
											num28 = num24;
											int num69;
											if ((uint)num28 <= 32u)
											{
												num69 = -1;
											}
											else
											{
												wassert.Invoke(String_mf9hyza.__pointer, String_uxbkrtb.__pointer, 2429);
												if (ExceptionInfo.Current != null)
												{
													return false;
												}
												num69 = 0;
											}
											int num70 = num28;
											long field_31 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
											startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_31 >>> (int)(uint)num70;
											int field_32 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num28;
											startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_32;
											if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 < 32u)
											{
												if ((uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4) > (uint)src_len)
												{
													goto IL_1085;
												}
												long num71 = (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0)) << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2);
												long field_33 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 | num71;
												startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_33;
												int field_34 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4;
												startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_34;
												int field_35 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 32;
												startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_35;
											}
											if (((num21 | num22) & 0x100) != 0)
											{
												goto IL_1129;
											}
											if (ptr != null)
											{
												((sbyte*)ptr2)[(uint)num11] = (sbyte)((byte)((sbyte*)ptr)[(uint)num11] + num13);
												((sbyte*)ptr2)[(uint)(num11 + 1)] = (sbyte)((byte)((sbyte*)ptr)[(uint)(num11 + 1)] + num21);
												((sbyte*)ptr2)[(uint)(num11 + 2)] = (sbyte)((byte)((sbyte*)ptr)[(uint)(num11 + 2)] + num22);
											}
											else
											{
												((sbyte*)ptr2)[(uint)num11] = (sbyte)num13;
												((sbyte*)ptr2)[(uint)(num11 + 1)] = (sbyte)num21;
												((sbyte*)ptr2)[(uint)(num11 + 2)] = (sbyte)num22;
											}
											num11 += 3;
											b = (sbyte)num13;
											b2 = (sbyte)num21;
											b3 = (sbyte)num22;
											num29 = num22 >>> 25;
											if (num29 != 0 && (uint)num11 < (uint)num)
											{
												num13 = (num22 >>> 16) & 0x1FF;
												if ((uint)num13 < 256u)
												{
													num30 = num29;
													int num72;
													if ((uint)num30 <= 32u && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= (uint)num30)
													{
														num72 = -1;
													}
													else
													{
														wassert.Invoke(String_bahgbqd.__pointer, String_uxbkrtb.__pointer, 2481);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														num72 = 0;
													}
													int num73 = num30;
													long field_36 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
													startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_36 >>> (int)(uint)num73;
													int field_37 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num30;
													startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_37;
													int num74;
													if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= 12u)
													{
														num74 = -1;
													}
													else
													{
														wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2483);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														num74 = 0;
													}
													long num75 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 0xFFFL;
													num21 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_3))[num75];
													num31 = (num21 >>> 9) & 0xF;
													if (num31 == 0)
													{
														goto IL_133e;
													}
													num32 = num31;
													int num76;
													if ((uint)num32 <= 32u)
													{
														num76 = -1;
													}
													else
													{
														wassert.Invoke(String_mf9hyza.__pointer, String_uxbkrtb.__pointer, 2488);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														num76 = 0;
													}
													int num77 = num32;
													long field_38 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
													startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_38 >>> (int)(uint)num77;
													int field_39 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num32;
													startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_39;
													if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 < 32u)
													{
														if ((uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4) > (uint)src_len)
														{
															goto IL_13f6;
														}
														long num78 = (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0)) << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2);
														long field_40 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 | num78;
														startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_40;
														int field_41 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4;
														startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_41;
														int field_42 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 32;
														startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_42;
													}
													num24 = num21 >>> 25;
													if (num24 != 0)
													{
														num22 = num21 >>> 16;
													}
													else
													{
														int num79;
														if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= 12u)
														{
															num79 = -1;
														}
														else
														{
															wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2495);
															if (ExceptionInfo.Current != null)
															{
																return false;
															}
															num79 = 0;
														}
														long num80 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 0xFFFL;
														num22 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_3))[num80];
														num24 = (num22 >>> 9) & 0xF;
														if (num24 == 0)
														{
															goto IL_1522;
														}
													}
													num33 = num24;
													int num81;
													if ((uint)num33 <= 32u && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= (uint)num33)
													{
														num81 = -1;
													}
													else
													{
														wassert.Invoke(String_bahgbqd.__pointer, String_uxbkrtb.__pointer, 2502);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														num81 = 0;
													}
													int num82 = num33;
													long field_43 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
													startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_43 >>> (int)(uint)num82;
													int field_44 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num33;
													startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_44;
													if (((num21 | num22) & 0x100) != 0)
													{
														goto IL_15db;
													}
													if (ptr != null)
													{
														((sbyte*)ptr2)[(uint)num11] = (sbyte)((byte)((sbyte*)ptr)[(uint)num11] + num13);
														((sbyte*)ptr2)[(uint)(num11 + 1)] = (sbyte)((byte)((sbyte*)ptr)[(uint)(num11 + 1)] + num21);
														((sbyte*)ptr2)[(uint)(num11 + 2)] = (sbyte)((byte)((sbyte*)ptr)[(uint)(num11 + 2)] + num22);
													}
													else
													{
														((sbyte*)ptr2)[(uint)num11] = (sbyte)num13;
														((sbyte*)ptr2)[(uint)(num11 + 1)] = (sbyte)num21;
														((sbyte*)ptr2)[(uint)(num11 + 2)] = (sbyte)num22;
													}
													num11 += 3;
													b = (sbyte)num13;
													b2 = (sbyte)num21;
													b3 = (sbyte)num22;
												}
											}
										}
										if ((uint)num11 < (uint)num)
										{
											continue;
										}
										goto IL_16ac;
									}
									flag = false;
									break;
								}
								int num83;
								if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 >= 12u)
								{
									num83 = -1;
								}
								else
								{
									wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2560);
									if (ExceptionInfo.Current != null)
									{
										return false;
									}
									num83 = 0;
								}
								long num84 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 0xFFFL;
								num34 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_3))[num84];
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
								int field_45 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num35;
								startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_45;
								int num85 = num35;
								long field_46 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
								startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_46 >>> (int)(uint)num85;
								num36 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 & 7;
								int field_47 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - num36;
								startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_47;
								int num86 = num36;
								long field_48 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
								startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_48 >>> (int)(uint)num86;
								if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0 < (uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_2 >>> 3))
								{
									flag = false;
									break;
								}
								int num87 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 >>> 3;
								int field_49 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 - num87;
								startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_49;
								flag = ((startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 4 == zlib_len) ? true : false);
								break;
								IL_0995:
								flag = false;
								break;
								IL_0bb2:
								flag = false;
								break;
								IL_0e8a:
								flag = false;
								break;
								IL_1085:
								flag = false;
								break;
								IL_0fc9:
								flag = false;
								break;
								IL_08da:
								flag = false;
								break;
								IL_0e00:
								flag = false;
								break;
								IL_1522:
								flag = false;
								break;
								IL_15db:
								flag = false;
								break;
								IL_1129:
								flag = false;
								break;
								IL_0b9b:
								flag = false;
								break;
								IL_16ac:
								ptr = ptr2;
								ptr2 = (byte*)ptr2 + (uint)num;
								num6++;
								continue;
								IL_133e:
								flag = false;
								break;
								IL_13f6:
								flag = false;
								break;
							}
						}
					}
				}
			}
			goto IL_1890;
		}
		IL_1890:
		bool result = flag;
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
