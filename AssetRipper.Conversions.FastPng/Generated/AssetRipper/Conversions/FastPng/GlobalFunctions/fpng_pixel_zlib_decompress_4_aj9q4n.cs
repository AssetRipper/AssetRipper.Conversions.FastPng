using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$fpng_pixel_zlib_decompress_4@$02@fpng@@YA_NPEBEIIPEAEII@Z")]
[DemangledName("bool __cdecl fpng::fpng_pixel_zlib_decompress_4<3>(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int, unsigned int)")]
[CleanName("fpng_pixel_zlib_decompress_4")]
internal static partial class fpng_pixel_zlib_decompress_4_aj9q4n
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
				wassert.Invoke(String_wv8pqk.__pointer, String_ksmiy6.__pointer, 2592);
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
					bool flag2 = fpng_pixel_zlib_raw_decompress.Invoke(pSrc, src_len, zlib_len, pDst, w, h, 4, 3);
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
						wassert.Invoke(String_f74ax6.__pointer, String_ksmiy6.__pointer, 2617);
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
							goto IL_125e;
						}
						localsPointer->field_1 |= (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)localsPointer->field_0)) << (int)(uint)localsPointer->field_2);
						localsPointer->field_0 += 4;
						localsPointer->field_2 += 32;
					}
					int num4 = 2;
					if (num4 == 0 || (uint)num4 > 32u)
					{
						wassert.Invoke(String_f74ax6.__pointer, String_ksmiy6.__pointer, 2618);
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
							goto IL_125e;
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
						bool flag3 = prepare_dynamic_block.Invoke(pLit_table: &localsPointer->field_3, pSrc: pSrc, src_len: src_len, src_ofs: &localsPointer->field_0, bit_buf_size: &localsPointer->field_2, bit_buf: &localsPointer->field_1, num_chans: 4);
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
										wassert.Invoke(String_vetfdg.__pointer, String_ksmiy6.__pointer, 2634);
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
										wassert.Invoke(String_j9965d.__pointer, String_ksmiy6.__pointer, 2639);
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
									sbyte b4 = 0;
									while (true)
									{
										if ((uint)localsPointer->field_2 < 12u)
										{
											wassert.Invoke(String_vetfdg.__pointer, String_ksmiy6.__pointer, 2650);
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
											wassert.Invoke(String_j9965d.__pointer, String_ksmiy6.__pointer, 2657);
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
												goto IL_072f;
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
												goto IL_07ba;
											}
											int num17 = ((int*)s_length_range.__pointer)[(uint)(num14 - 257)];
											if ((uint)num14 >= 265u)
											{
												int num18 = ((int*)s_length_extra.__pointer)[(uint)(num14 - 257)];
												if (num18 == 0 || (uint)num18 > 32u || (uint)localsPointer->field_2 < (uint)num18)
												{
													wassert.Invoke(String_t338gg.__pointer, String_ksmiy6.__pointer, 2672);
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
												wassert.Invoke(String_s5c4mv.__pointer, String_ksmiy6.__pointer, 2678);
												if (ExceptionInfo.Current != null)
												{
													return false;
												}
											}
											localsPointer->field_1 >>>= (int)(uint)num20;
											localsPointer->field_2 -= num20;
											if ((num17 & 3) != 0)
											{
												goto IL_0942;
											}
											int num21 = (num17 >>> 2) * 3;
											int num22 = num11 + num21;
											if ((uint)num22 > (uint)num)
											{
												goto IL_0961;
											}
											if (ptr != null)
											{
												if (((byte)b | (byte)b2 | (byte)b3 | (byte)b4) == 0)
												{
													llvm_memcpy_p0_p0_i64.Invoke((byte*)ptr2 + (uint)num11, (byte*)ptr + (uint)num11, (uint)num21, isVolatile: false);
													num11 = num22;
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
													while ((uint)num11 < (uint)num22);
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
												while ((uint)num11 < (uint)num22);
											}
										}
										else
										{
											int num23 = num13 >>> 25;
											int num24;
											int num27;
											int num28;
											if (num23 != 0)
											{
												num24 = (num13 >>> 16) & 0x1FF;
												int num25 = num23;
												if ((uint)num25 > 32u || (uint)localsPointer->field_2 < (uint)num25)
												{
													wassert.Invoke(String_s5c4mv.__pointer, String_ksmiy6.__pointer, 2771);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
												}
												localsPointer->field_1 >>>= (int)(uint)num25;
												localsPointer->field_2 -= num25;
												if ((uint)localsPointer->field_2 < 12u)
												{
													wassert.Invoke(String_vetfdg.__pointer, String_ksmiy6.__pointer, 2773);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
												}
												long num26 = localsPointer->field_1 & 0xFFFL;
												num27 = ((int*)(&localsPointer->field_3))[num26];
												num28 = (num27 >>> 9) & 0xF;
												if (num28 == 0)
												{
													goto IL_0b84;
												}
											}
											else
											{
												if ((uint)localsPointer->field_2 < 12u)
												{
													wassert.Invoke(String_vetfdg.__pointer, String_ksmiy6.__pointer, 2781);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
												}
												long num29 = localsPointer->field_1 & 0xFFFL;
												num24 = ((int*)(&localsPointer->field_3))[num29];
												int num30 = (num24 >>> 9) & 0xF;
												if (num30 == 0)
												{
													goto IL_0bfc;
												}
												int num31 = num30;
												if ((uint)num31 > 32u || (uint)localsPointer->field_2 < (uint)num31)
												{
													wassert.Invoke(String_s5c4mv.__pointer, String_ksmiy6.__pointer, 2786);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
												}
												localsPointer->field_1 >>>= (int)(uint)num31;
												localsPointer->field_2 -= num31;
												num28 = num24 >>> 25;
												if (num28 != 0)
												{
													num27 = num24 >>> 16;
												}
												else
												{
													if ((uint)localsPointer->field_2 < 12u)
													{
														wassert.Invoke(String_vetfdg.__pointer, String_ksmiy6.__pointer, 2793);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
													}
													long num32 = localsPointer->field_1 & 0xFFFL;
													num27 = ((int*)(&localsPointer->field_3))[num32];
													num28 = (num27 >>> 9) & 0xF;
													if (num28 == 0)
													{
														goto IL_0d08;
													}
												}
											}
											int num33 = num27 >>> 25;
											int num34;
											if (num33 != 0)
											{
												num34 = num27 >>> 16;
												int num35 = num28 + num33;
												if ((uint)num35 > 32u)
												{
													wassert.Invoke(String_j9965d.__pointer, String_ksmiy6.__pointer, 2807);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
												}
												localsPointer->field_1 >>>= (int)(uint)num35;
												localsPointer->field_2 -= num35;
												if ((uint)localsPointer->field_2 < 32u)
												{
													if ((uint)(localsPointer->field_0 + 4) > (uint)src_len)
													{
														goto IL_0dbd;
													}
													localsPointer->field_1 |= (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)localsPointer->field_0)) << (int)(uint)localsPointer->field_2);
													localsPointer->field_0 += 4;
													localsPointer->field_2 += 32;
												}
											}
											else
											{
												int num36 = num28;
												if ((uint)num36 > 32u)
												{
													wassert.Invoke(String_j9965d.__pointer, String_ksmiy6.__pointer, 2811);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
												}
												localsPointer->field_1 >>>= (int)(uint)num36;
												localsPointer->field_2 -= num36;
												if ((uint)localsPointer->field_2 < 32u)
												{
													if ((uint)(localsPointer->field_0 + 4) > (uint)src_len)
													{
														goto IL_0eab;
													}
													localsPointer->field_1 |= (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)localsPointer->field_0)) << (int)(uint)localsPointer->field_2);
													localsPointer->field_0 += 4;
													localsPointer->field_2 += 32;
												}
												if ((uint)localsPointer->field_2 < 12u)
												{
													wassert.Invoke(String_vetfdg.__pointer, String_ksmiy6.__pointer, 2813);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
												}
												long num37 = localsPointer->field_1 & 0xFFFL;
												num34 = ((int*)(&localsPointer->field_3))[num37];
												num33 = (num34 >>> 9) & 0xF;
												if (num33 == 0)
												{
													goto IL_0f76;
												}
												int num38 = num33;
												if ((uint)num38 > 32u || (uint)localsPointer->field_2 < (uint)num38)
												{
													wassert.Invoke(String_s5c4mv.__pointer, String_ksmiy6.__pointer, 2819);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
												}
												localsPointer->field_1 >>>= (int)(uint)num38;
												localsPointer->field_2 -= num38;
											}
											if (((num24 | num27 | num34) & 0x100) != 0)
											{
												goto IL_1014;
											}
											if (ptr != null)
											{
												((sbyte*)ptr2)[(uint)num11] = (sbyte)((byte)((sbyte*)ptr)[(uint)num11] + num14);
												((sbyte*)ptr2)[(uint)(num11 + 1)] = (sbyte)((byte)((sbyte*)ptr)[(uint)(num11 + 1)] + num24);
												((sbyte*)ptr2)[(uint)(num11 + 2)] = (sbyte)((byte)((sbyte*)ptr)[(uint)(num11 + 2)] + num27);
											}
											else
											{
												((sbyte*)ptr2)[(uint)num11] = (sbyte)num14;
												((sbyte*)ptr2)[(uint)(num11 + 1)] = (sbyte)num24;
												((sbyte*)ptr2)[(uint)(num11 + 2)] = (sbyte)num27;
											}
											num11 += 3;
											b = (sbyte)num14;
											b2 = (sbyte)num24;
											b3 = (sbyte)num27;
											b4 = (sbyte)num34;
										}
										if ((uint)num11 < (uint)num)
										{
											continue;
										}
										goto IL_10e6;
									}
									flag = false;
									break;
								}
								if ((uint)localsPointer->field_2 < 12u)
								{
									wassert.Invoke(String_vetfdg.__pointer, String_ksmiy6.__pointer, 2876);
									if (ExceptionInfo.Current != null)
									{
										return false;
									}
								}
								long num39 = localsPointer->field_1 & 0xFFFL;
								int num40 = ((int*)(&localsPointer->field_3))[num39];
								int num41 = (num40 >>> 9) & 0xF;
								if (num41 == 0)
								{
									flag = false;
									break;
								}
								if ((num40 & 0x1FF) != 256)
								{
									flag = false;
									break;
								}
								localsPointer->field_2 -= num41;
								localsPointer->field_1 >>>= (int)(uint)num41;
								int num42 = localsPointer->field_2 & 7;
								localsPointer->field_2 -= num42;
								localsPointer->field_1 >>>= (int)(uint)num42;
								if ((uint)localsPointer->field_0 < (uint)(localsPointer->field_2 >>> 3))
								{
									flag = false;
									break;
								}
								localsPointer->field_0 -= localsPointer->field_2 >>> 3;
								flag = ((localsPointer->field_0 + 4 == zlib_len) ? true : false);
								break;
								IL_0942:
								flag = false;
								break;
								IL_072f:
								flag = false;
								break;
								IL_0d08:
								flag = false;
								break;
								IL_0bfc:
								flag = false;
								break;
								IL_0b84:
								flag = false;
								break;
								IL_0eab:
								flag = false;
								break;
								IL_1014:
								flag = false;
								break;
								IL_10e6:
								ptr = ptr2;
								ptr2 = (byte*)ptr2 + (uint)num;
								num6++;
								continue;
								IL_0dbd:
								flag = false;
								break;
								IL_07ba:
								flag = false;
								break;
								IL_0961:
								flag = false;
								break;
								IL_0f76:
								flag = false;
								break;
							}
						}
					}
				}
			}
			goto IL_125e;
		}
		IL_125e:
		bool result = flag;
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
