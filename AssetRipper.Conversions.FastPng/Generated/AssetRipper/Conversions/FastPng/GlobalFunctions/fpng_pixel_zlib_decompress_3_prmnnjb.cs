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

		public InlineArray4096_Int32 field_3;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("unsigned char const *")] void* pSrc, [NativeType("unsigned int")] int src_len, [NativeType("unsigned int")] int zlib_len, [NativeType("unsigned char *")] void* pDst, [NativeType("unsigned int")] int w, [NativeType("unsigned int")] int h)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = 0;
		localsPointer->field_1 = 0L;
		localsPointer->field_2 = 0;
		localsPointer->field_3 = default(InlineArray4096_Int32);
		bool flag;
		unchecked
		{
			if ((uint)src_len < (uint)(zlib_len + 4))
			{
				wassert.Invoke(String_497patd.__pointer, String_uxbkrtb.__pointer, 2214);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
			}
			int num = w * 3;
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
				localsPointer->field_0 = 2;
				if (((byte)((sbyte*)pSrc)[(uint)localsPointer->field_0] & 6) == 0)
				{
					bool flag2 = fpng_pixel_zlib_raw_decompress.Invoke(pSrc, src_len, zlib_len, pDst, w, h, 3, 3);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					flag = flag2;
				}
				else if ((uint)(localsPointer->field_0 + 4) > (uint)src_len)
				{
					flag = false;
				}
				else
				{
					localsPointer->field_1 = (uint)(*(int*)((byte*)pSrc + (uint)localsPointer->field_0));
					localsPointer->field_0 += 4;
					localsPointer->field_2 = 32;
					int num2 = 1;
					if (num2 == 0 || (uint)num2 > 32u)
					{
						wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 2239);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
					}
					int num3 = (int)(localsPointer->field_1 & (uint)((int*)g_bitmasks.__pointer)[(uint)num2]);
					localsPointer->field_1 >>>= (int)(uint)num2;
					localsPointer->field_2 -= num2;
					if ((uint)localsPointer->field_2 < 32u)
					{
						if ((uint)(localsPointer->field_0 + 4) > (uint)src_len)
						{
							flag = false;
							goto IL_147b;
						}
						localsPointer->field_1 |= (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)localsPointer->field_0)) << (int)(uint)localsPointer->field_2);
						localsPointer->field_0 += 4;
						localsPointer->field_2 += 32;
					}
					int num4 = 2;
					if (num4 == 0 || (uint)num4 > 32u)
					{
						wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 2240);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
					}
					int num5 = (int)(localsPointer->field_1 & (uint)((int*)g_bitmasks.__pointer)[(uint)num4]);
					localsPointer->field_1 >>>= (int)(uint)num4;
					localsPointer->field_2 -= num4;
					if ((uint)localsPointer->field_2 < 32u)
					{
						if ((uint)(localsPointer->field_0 + 4) > (uint)src_len)
						{
							flag = false;
							goto IL_147b;
						}
						localsPointer->field_1 |= (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)localsPointer->field_0)) << (int)(uint)localsPointer->field_2);
						localsPointer->field_0 += 4;
						localsPointer->field_2 += 32;
					}
					if (num3 != 1 || num5 != 2)
					{
						flag = false;
					}
					else
					{
						bool flag3 = prepare_dynamic_block.Invoke(pLit_table: &localsPointer->field_3, pSrc: pSrc, src_len: src_len, src_ofs: &localsPointer->field_0, bit_buf_size: &localsPointer->field_2, bit_buf: &localsPointer->field_1, num_chans: 3);
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
							void* ptr = null;
							void* ptr2 = pDst;
							int num6 = 0;
							while (true)
							{
								if ((uint)num6 < (uint)h)
								{
									if ((uint)localsPointer->field_2 < 12u)
									{
										wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2256);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
									}
									long num7 = localsPointer->field_1 & 0xFFFL;
									int num8 = ((int*)(&localsPointer->field_3))[num7];
									int num9 = (num8 >>> 9) & 0xF;
									if (num9 == 0)
									{
										flag = false;
										break;
									}
									int num10 = num9;
									if ((uint)num10 > 32u)
									{
										wassert.Invoke(String_mf9hyza.__pointer, String_uxbkrtb.__pointer, 2261);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
									}
									localsPointer->field_1 >>>= (int)(uint)num10;
									localsPointer->field_2 -= num10;
									if ((uint)localsPointer->field_2 < 32u)
									{
										if ((uint)(localsPointer->field_0 + 4) > (uint)src_len)
										{
											flag = false;
											break;
										}
										localsPointer->field_1 |= (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)localsPointer->field_0)) << (int)(uint)localsPointer->field_2);
										localsPointer->field_0 += 4;
										localsPointer->field_2 += 32;
									}
									if ((num8 & 0x1FF) != InstructionHelper.Select(num6 != 0, 2, 0))
									{
										flag = false;
										break;
									}
									int num11 = 0;
									sbyte b = 0;
									sbyte b2 = 0;
									sbyte b3 = 0;
									while (true)
									{
										if ((uint)localsPointer->field_2 < 12u)
										{
											wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2272);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
										}
										long num12 = localsPointer->field_1 & 0xFFFL;
										int num13 = ((int*)(&localsPointer->field_3))[num12];
										int num14 = num13;
										int num15 = (num13 >>> 9) & 0xF;
										if (num15 == 0)
										{
											break;
										}
										int num16 = num15;
										if ((uint)num16 > 32u)
										{
											wassert.Invoke(String_mf9hyza.__pointer, String_uxbkrtb.__pointer, 2279);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
										}
										localsPointer->field_1 >>>= (int)(uint)num16;
										localsPointer->field_2 -= num16;
										if ((uint)localsPointer->field_2 < 32u)
										{
											if ((uint)(localsPointer->field_0 + 4) > (uint)src_len)
											{
												goto IL_0729;
											}
											localsPointer->field_1 |= (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)localsPointer->field_0)) << (int)(uint)localsPointer->field_2);
											localsPointer->field_0 += 4;
											localsPointer->field_2 += 32;
										}
										if ((num14 & 0x100) != 0)
										{
											num14 &= 0x1FF;
											if (num14 == 256)
											{
												goto IL_07b4;
											}
											int num17 = ((int*)s_length_range.__pointer)[(uint)(num14 - 257)];
											if ((uint)num14 >= 265u)
											{
												int num18 = ((int*)s_length_extra.__pointer)[(uint)(num14 - 257)];
												if (num18 == 0 || (uint)num18 > 32u || (uint)localsPointer->field_2 < (uint)num18)
												{
													wassert.Invoke(String_ftb25bb.__pointer, String_uxbkrtb.__pointer, 2294);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
												}
												int num19 = (int)(localsPointer->field_1 & (uint)((int*)g_bitmasks.__pointer)[(uint)num18]);
												localsPointer->field_1 >>>= (int)(uint)num18;
												localsPointer->field_2 -= num18;
												num17 += num19;
											}
											int num20 = 1;
											if ((uint)num20 > 32u || (uint)localsPointer->field_2 < (uint)num20)
											{
												wassert.Invoke(String_bahgbqd.__pointer, String_uxbkrtb.__pointer, 2300);
												if (ExceptionInfo.Current != null)
												{
													return false;
												}
											}
											localsPointer->field_1 >>>= (int)(uint)num20;
											localsPointer->field_2 -= num20;
											if ((uint)num17 % 3u != 0)
											{
												wassert.Invoke(String_a5rp7bb.__pointer, String_uxbkrtb.__pointer, 2303);
												if (ExceptionInfo.Current != null)
												{
													return false;
												}
											}
											if (((short*)g_run_len3_to_4.__pointer)[(uint)num17] == 0)
											{
												goto IL_0978;
											}
											int num21 = num11 + num17;
											if ((uint)num21 > (uint)num)
											{
												goto IL_098f;
											}
											if (ptr != null)
											{
												if (((byte)b | (byte)b2 | (byte)b3) == 0)
												{
													llvm_memcpy_p0_p0_i64.Invoke((byte*)ptr2 + (uint)num11, (byte*)ptr + (uint)num11, (uint)num17, isVolatile: false);
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
											int num22 = num13 >>> 25;
											int num23;
											int num27;
											int num26;
											if (num22 != 0)
											{
												num23 = (num13 >>> 16) & 0x1FF;
												int num24 = num22;
												if ((uint)num24 > 32u || (uint)localsPointer->field_2 < (uint)num24)
												{
													wassert.Invoke(String_bahgbqd.__pointer, String_uxbkrtb.__pointer, 2399);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
												}
												localsPointer->field_1 >>>= (int)(uint)num24;
												localsPointer->field_2 -= num24;
												if ((uint)localsPointer->field_2 < 12u)
												{
													wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2401);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
												}
												long num25 = localsPointer->field_1 & 0xFFFL;
												num26 = ((int*)(&localsPointer->field_3))[num25];
												num27 = (num26 >>> 9) & 0xF;
												if (num27 == 0)
												{
													goto IL_0bad;
												}
											}
											else
											{
												if ((uint)localsPointer->field_2 < 12u)
												{
													wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2409);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
												}
												long num28 = localsPointer->field_1 & 0xFFFL;
												num23 = ((int*)(&localsPointer->field_3))[num28];
												int num29 = (num23 >>> 9) & 0xF;
												if (num29 == 0)
												{
													goto IL_0c25;
												}
												int num30 = num29;
												if ((uint)num30 > 32u || (uint)localsPointer->field_2 < (uint)num30)
												{
													wassert.Invoke(String_bahgbqd.__pointer, String_uxbkrtb.__pointer, 2414);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
												}
												localsPointer->field_1 >>>= (int)(uint)num30;
												localsPointer->field_2 -= num30;
												num27 = num23 >>> 25;
												if (num27 != 0)
												{
													num26 = num23 >>> 16;
												}
												else
												{
													if ((uint)localsPointer->field_2 < 12u)
													{
														wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2421);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
													}
													long num31 = localsPointer->field_1 & 0xFFFL;
													num26 = ((int*)(&localsPointer->field_3))[num31];
													num27 = (num26 >>> 9) & 0xF;
													if (num27 == 0)
													{
														goto IL_0d31;
													}
												}
											}
											int num32 = num27;
											if ((uint)num32 > 32u)
											{
												wassert.Invoke(String_mf9hyza.__pointer, String_uxbkrtb.__pointer, 2429);
												if (ExceptionInfo.Current != null)
												{
													return false;
												}
											}
											localsPointer->field_1 >>>= (int)(uint)num32;
											localsPointer->field_2 -= num32;
											if ((uint)localsPointer->field_2 < 32u)
											{
												if ((uint)(localsPointer->field_0 + 4) > (uint)src_len)
												{
													goto IL_0dc6;
												}
												localsPointer->field_1 |= (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)localsPointer->field_0)) << (int)(uint)localsPointer->field_2);
												localsPointer->field_0 += 4;
												localsPointer->field_2 += 32;
											}
											if (((num23 | num26) & 0x100) != 0)
											{
												goto IL_0e3a;
											}
											if (ptr != null)
											{
												((sbyte*)ptr2)[(uint)num11] = (sbyte)((byte)((sbyte*)ptr)[(uint)num11] + num14);
												((sbyte*)ptr2)[(uint)(num11 + 1)] = (sbyte)((byte)((sbyte*)ptr)[(uint)(num11 + 1)] + num23);
												((sbyte*)ptr2)[(uint)(num11 + 2)] = (sbyte)((byte)((sbyte*)ptr)[(uint)(num11 + 2)] + num26);
											}
											else
											{
												((sbyte*)ptr2)[(uint)num11] = (sbyte)num14;
												((sbyte*)ptr2)[(uint)(num11 + 1)] = (sbyte)num23;
												((sbyte*)ptr2)[(uint)(num11 + 2)] = (sbyte)num26;
											}
											num11 += 3;
											b = (sbyte)num14;
											b2 = (sbyte)num23;
											b3 = (sbyte)num26;
											int num33 = num26 >>> 25;
											if (num33 != 0 && (uint)num11 < (uint)num)
											{
												num14 = (num26 >>> 16) & 0x1FF;
												if ((uint)num14 < 256u)
												{
													int num34 = num33;
													if ((uint)num34 > 32u || (uint)localsPointer->field_2 < (uint)num34)
													{
														wassert.Invoke(String_bahgbqd.__pointer, String_uxbkrtb.__pointer, 2481);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
													}
													localsPointer->field_1 >>>= (int)(uint)num34;
													localsPointer->field_2 -= num34;
													if ((uint)localsPointer->field_2 < 12u)
													{
														wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2483);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
													}
													long num35 = localsPointer->field_1 & 0xFFFL;
													num23 = ((int*)(&localsPointer->field_3))[num35];
													int num36 = (num23 >>> 9) & 0xF;
													if (num36 == 0)
													{
														goto IL_101f;
													}
													int num37 = num36;
													if ((uint)num37 > 32u)
													{
														wassert.Invoke(String_mf9hyza.__pointer, String_uxbkrtb.__pointer, 2488);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
													}
													localsPointer->field_1 >>>= (int)(uint)num37;
													localsPointer->field_2 -= num37;
													if ((uint)localsPointer->field_2 < 32u)
													{
														if ((uint)(localsPointer->field_0 + 4) > (uint)src_len)
														{
															goto IL_10b0;
														}
														localsPointer->field_1 |= (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)localsPointer->field_0)) << (int)(uint)localsPointer->field_2);
														localsPointer->field_0 += 4;
														localsPointer->field_2 += 32;
													}
													num27 = num23 >>> 25;
													if (num27 != 0)
													{
														num26 = num23 >>> 16;
													}
													else
													{
														if ((uint)localsPointer->field_2 < 12u)
														{
															wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2495);
															if (ExceptionInfo.Current != null)
															{
																return false;
															}
														}
														long num38 = localsPointer->field_1 & 0xFFFL;
														num26 = ((int*)(&localsPointer->field_3))[num38];
														num27 = (num26 >>> 9) & 0xF;
														if (num27 == 0)
														{
															goto IL_1197;
														}
													}
													int num39 = num27;
													if ((uint)num39 > 32u || (uint)localsPointer->field_2 < (uint)num39)
													{
														wassert.Invoke(String_bahgbqd.__pointer, String_uxbkrtb.__pointer, 2502);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
													}
													localsPointer->field_1 >>>= (int)(uint)num39;
													localsPointer->field_2 -= num39;
													if (((num23 | num26) & 0x100) != 0)
													{
														goto IL_1232;
													}
													if (ptr != null)
													{
														((sbyte*)ptr2)[(uint)num11] = (sbyte)((byte)((sbyte*)ptr)[(uint)num11] + num14);
														((sbyte*)ptr2)[(uint)(num11 + 1)] = (sbyte)((byte)((sbyte*)ptr)[(uint)(num11 + 1)] + num23);
														((sbyte*)ptr2)[(uint)(num11 + 2)] = (sbyte)((byte)((sbyte*)ptr)[(uint)(num11 + 2)] + num26);
													}
													else
													{
														((sbyte*)ptr2)[(uint)num11] = (sbyte)num14;
														((sbyte*)ptr2)[(uint)(num11 + 1)] = (sbyte)num23;
														((sbyte*)ptr2)[(uint)(num11 + 2)] = (sbyte)num26;
													}
													num11 += 3;
													b = (sbyte)num14;
													b2 = (sbyte)num23;
													b3 = (sbyte)num26;
												}
											}
										}
										if ((uint)num11 < (uint)num)
										{
											continue;
										}
										goto IL_1303;
									}
									flag = false;
									break;
								}
								if ((uint)localsPointer->field_2 < 12u)
								{
									wassert.Invoke(String_ktv524d.__pointer, String_uxbkrtb.__pointer, 2560);
									if (ExceptionInfo.Current != null)
									{
										return false;
									}
								}
								long num40 = localsPointer->field_1 & 0xFFFL;
								int num41 = ((int*)(&localsPointer->field_3))[num40];
								int num42 = (num41 >>> 9) & 0xF;
								if (num42 == 0)
								{
									flag = false;
									break;
								}
								if ((num41 & 0x1FF) != 256)
								{
									flag = false;
									break;
								}
								localsPointer->field_2 -= num42;
								localsPointer->field_1 >>>= (int)(uint)num42;
								int num43 = localsPointer->field_2 & 7;
								localsPointer->field_2 -= num43;
								localsPointer->field_1 >>>= (int)(uint)num43;
								if ((uint)localsPointer->field_0 < (uint)(localsPointer->field_2 >>> 3))
								{
									flag = false;
									break;
								}
								localsPointer->field_0 -= localsPointer->field_2 >>> 3;
								flag = ((localsPointer->field_0 + 4 == zlib_len) ? true : false);
								break;
								IL_0bad:
								flag = false;
								break;
								IL_1197:
								flag = false;
								break;
								IL_10b0:
								flag = false;
								break;
								IL_101f:
								flag = false;
								break;
								IL_0e3a:
								flag = false;
								break;
								IL_1232:
								flag = false;
								break;
								IL_0978:
								flag = false;
								break;
								IL_0dc6:
								flag = false;
								break;
								IL_0729:
								flag = false;
								break;
								IL_098f:
								flag = false;
								break;
								IL_07b4:
								flag = false;
								break;
								IL_1303:
								ptr = ptr2;
								ptr2 = (byte*)ptr2 + (uint)num;
								num6++;
								continue;
								IL_0c25:
								flag = false;
								break;
								IL_0d31:
								flag = false;
								break;
							}
						}
					}
				}
			}
			goto IL_147b;
		}
		IL_147b:
		bool result = flag;
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
