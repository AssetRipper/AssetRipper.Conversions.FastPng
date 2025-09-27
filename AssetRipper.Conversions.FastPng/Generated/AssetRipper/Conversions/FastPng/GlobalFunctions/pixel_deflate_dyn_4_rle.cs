using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?pixel_deflate_dyn_4_rle@fpng@@YAIPEBEIIPEAEI@Z")]
[DemangledName("unsigned int __cdecl fpng::pixel_deflate_dyn_4_rle(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int)")]
internal static partial class pixel_deflate_dyn_4_rle
{
	private partial struct LocalVariables
	{
		public long field_0;

		public int field_1;

		public int field_2;

		public std_vector_mvt3mha field_3;

		public InlineArray288_Int32 field_4;

		public fpng_defl_huff field_5;
	}

	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("unsigned char const *")] void* pImg, [NativeType("unsigned int")] int w, [NativeType("unsigned int")] int h, [NativeType("unsigned char *")] void* pDst, [NativeType("unsigned int")] int dst_buf_size)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = 0L;
		localsPointer->field_1 = 0;
		localsPointer->field_2 = 0;
		localsPointer->field_3 = default(std_vector_mvt3mha);
		localsPointer->field_4 = default(InlineArray288_Int32);
		localsPointer->field_5 = default(fpng_defl_huff);
		int num23;
		unchecked
		{
			int num = 1 + w * 4;
			localsPointer->field_0 = 0L;
			localsPointer->field_1 = 0;
			localsPointer->field_2 = 0;
			int num2 = 120;
			int num3 = 8;
			if ((uint)num3 < 0u || (uint)num3 > 16u)
			{
				wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1279);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			if ((ulong)(uint)num2 >= (ulong)(1L << (int)(uint)num3))
			{
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1279);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			localsPointer->field_0 |= (long)((ulong)(uint)num2 << (int)(uint)localsPointer->field_1);
			localsPointer->field_1 += num3;
			if (localsPointer->field_1 > 64)
			{
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1279);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			int num4 = 1;
			int num5 = 8;
			if ((uint)num5 < 0u || (uint)num5 > 16u)
			{
				wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1280);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			if ((ulong)(uint)num4 >= (ulong)(1L << (int)(uint)num5))
			{
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1280);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			localsPointer->field_0 |= (long)((ulong)(uint)num4 << (int)(uint)localsPointer->field_1);
			localsPointer->field_1 += num5;
			if (localsPointer->field_1 > 64)
			{
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1280);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			int num6 = 1;
			int num7 = 1;
			if ((uint)num7 < 0u || (uint)num7 > 16u)
			{
				wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1283);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			if ((ulong)(uint)num6 >= (ulong)(1L << (int)(uint)num7))
			{
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1283);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			localsPointer->field_0 |= (long)((ulong)(uint)num6 << (int)(uint)localsPointer->field_1);
			localsPointer->field_1 += num7;
			if (localsPointer->field_1 > 64)
			{
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1283);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			vector_unsigned_int64_class_std_allocator_unsigned_int64_Constructor.Invoke(&localsPointer->field_3);
			resize_d4pmvud.Invoke(&localsPointer->field_3, (uint)((w + 1) * h));
			if (ExceptionInfo.Current == null)
			{
				void* ptr = data_dtgl25a.Invoke(&localsPointer->field_3);
				llvm_memset_p0_i64.Invoke(&localsPointer->field_4, 0, 1152L, isVolatile: false);
				void* ptr2 = pImg;
				int num8 = 0;
				int num9 = fpng_adler32.Invoke(pImg, (uint)(num * h), 1);
				if (ExceptionInfo.Current == null)
				{
					int num10 = num9;
					for (int i = 0; (uint)i < (uint)h; i++)
					{
						int num11 = num8 + num;
						int num12 = (byte)((sbyte*)ptr2)[(uint)num8++];
						long num13 = (uint)(1 | (num12 << 8));
						void* ptr3 = ptr;
						ptr = (byte*)ptr3 + 8;
						*(long*)ptr3 = num13;
						((int*)(&localsPointer->field_4))[(uint)num12]++;
						int num14 = *(int*)((byte*)ptr2 + (uint)num8);
						long num15 = (long)((ulong)(uint)num14 << 8);
						void* ptr4 = ptr;
						ptr = (byte*)ptr4 + 8;
						*(long*)ptr4 = num15;
						((int*)(&localsPointer->field_4))[(uint)(num14 & 0xFF)]++;
						((int*)(&localsPointer->field_4))[(uint)((num14 >>> 8) & 0xFF)]++;
						((int*)(&localsPointer->field_4))[(uint)((num14 >>> 16) & 0xFF)]++;
						((int*)(&localsPointer->field_4))[(uint)(num14 >>> 24)]++;
						num8 += 4;
						int num16 = num14;
						while ((uint)num8 < (uint)num11)
						{
							int num17 = *(int*)((byte*)ptr2 + (uint)num8);
							if (num17 == num16)
							{
								int j = 4;
								for (int num18 = minimum_ymfg3kb.Invoke(252, num11 - num8); (uint)j < (uint)num18 && *(int*)((byte*)ptr2 + (uint)num8 + (uint)j) == num17; j += 4)
								{
								}
								long num19 = (uint)(j - 1);
								void* ptr5 = ptr;
								ptr = (byte*)ptr5 + 8;
								*(long*)ptr5 = num19;
								long num20 = (ushort)((short*)g_defl_len_sym.__pointer)[(uint)(j - 3)];
								((int*)(&localsPointer->field_4))[num20]++;
								num8 += j;
							}
							else
							{
								long num21 = (long)((ulong)(uint)num17 << 8);
								void* ptr6 = ptr;
								ptr = (byte*)ptr6 + 8;
								*(long*)ptr6 = num21;
								((int*)(&localsPointer->field_4))[(uint)(num17 & 0xFF)]++;
								((int*)(&localsPointer->field_4))[(uint)((num17 >>> 8) & 0xFF)]++;
								((int*)(&localsPointer->field_4))[(uint)((num17 >>> 16) & 0xFF)]++;
								((int*)(&localsPointer->field_4))[(uint)(num17 >>> 24)]++;
								num16 = num17;
								num8 += 4;
							}
						}
					}
					if (num8 != h * num)
					{
						wassert.Invoke(String_bjvsuxc.__pointer, String_uxbkrtb.__pointer, 1365);
						if (ExceptionInfo.Current != null)
						{
							goto IL_15fe;
						}
					}
					int num22 = (int)(((long)ptr - (long)data_dtgl25a.Invoke(&localsPointer->field_3)) / 8L);
					if ((ulong)(uint)num22 > (ulong)size_trt5i3d.Invoke(&localsPointer->field_3))
					{
						wassert.Invoke(String_hsgehfc.__pointer, String_uxbkrtb.__pointer, 1367);
						if (ExceptionInfo.Current != null)
						{
							goto IL_15fe;
						}
					}
					((int*)(&localsPointer->field_4))[256] = 1;
					adjust_freq32.Invoke(pFreq16: &localsPointer->field_5.m_huff_count, num_freq: 288, pFreq: &localsPointer->field_4);
					if (ExceptionInfo.Current == null)
					{
						llvm_memset_p0_i64.Invoke((byte*)(&localsPointer->field_5.m_huff_count) + sizeof(InlineArray288_Int16), 0, 64L, isVolatile: false);
						((short*)((byte*)(&localsPointer->field_5.m_huff_count) + sizeof(InlineArray288_Int16)))[3] = 1;
						((short*)((byte*)(&localsPointer->field_5.m_huff_count) + sizeof(InlineArray288_Int16)))[4] = 1;
						bool flag = defl_start_dynamic_block.Invoke(&localsPointer->field_5, pDst, &localsPointer->field_2, dst_buf_size, &localsPointer->field_0, &localsPointer->field_1);
						if (ExceptionInfo.Current == null)
						{
							if (!flag)
							{
								num23 = 0;
							}
							else
							{
								if (localsPointer->field_1 > 7)
								{
									wassert.Invoke(String_vpte4cc.__pointer, String_uxbkrtb.__pointer, 1382);
									if (ExceptionInfo.Current != null)
									{
										goto IL_15fe;
									}
								}
								if ((ushort)((short*)((byte*)(&localsPointer->field_5.m_huff_codes) + sizeof(InlineArray288_Int16)))[3] != 0 || ((byte*)(&localsPointer->field_5.m_huff_code_sizes) + sizeof(InlineArray288_SByte))[3] != 1)
								{
									wassert.Invoke(String_df5ko9b.__pointer, String_uxbkrtb.__pointer, 1383);
									if (ExceptionInfo.Current != null)
									{
										goto IL_15fe;
									}
								}
								int num45;
								for (int k = 0; (uint)k < (uint)num22; localsPointer->field_0 >>>= (int)(uint)num45, localsPointer->field_1 -= num45, k++)
								{
									long num24 = *(long*)vector_unsigned_int64_class_std_allocator_unsigned_int64_Index.Invoke(&localsPointer->field_3, (uint)k);
									int num25 = (int)(num24 & 0xFFL);
									if (num25 == 0)
									{
										int num26 = (int)(num24 >>> 8);
										int num27 = (ushort)((short*)(&localsPointer->field_5.m_huff_codes))[(uint)(num26 & 0xFF)];
										int num28 = (byte)((sbyte*)(&localsPointer->field_5.m_huff_code_sizes))[(uint)(num26 & 0xFF)];
										if ((uint)num28 < 1u || (uint)num28 > 16u)
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1394);
											if (ExceptionInfo.Current != null)
											{
												goto IL_15fe;
											}
										}
										if ((ulong)(uint)num27 >= (ulong)(1L << (int)(uint)num28))
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1394);
											if (ExceptionInfo.Current != null)
											{
												goto IL_15fe;
											}
										}
										localsPointer->field_0 |= (long)((ulong)(uint)num27 << (int)(uint)localsPointer->field_1);
										localsPointer->field_1 += num28;
										if (localsPointer->field_1 > 64)
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1394);
											if (ExceptionInfo.Current != null)
											{
												goto IL_15fe;
											}
										}
										num26 >>>= 8;
										int num29 = (ushort)((short*)(&localsPointer->field_5.m_huff_codes))[(uint)(num26 & 0xFF)];
										int num30 = (byte)((sbyte*)(&localsPointer->field_5.m_huff_code_sizes))[(uint)(num26 & 0xFF)];
										if ((uint)num30 < 1u || (uint)num30 > 16u)
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1397);
											if (ExceptionInfo.Current != null)
											{
												goto IL_15fe;
											}
										}
										if ((ulong)(uint)num29 >= (ulong)(1L << (int)(uint)num30))
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1397);
											if (ExceptionInfo.Current != null)
											{
												goto IL_15fe;
											}
										}
										localsPointer->field_0 |= (long)((ulong)(uint)num29 << (int)(uint)localsPointer->field_1);
										localsPointer->field_1 += num30;
										if (localsPointer->field_1 > 64)
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1397);
											if (ExceptionInfo.Current != null)
											{
												goto IL_15fe;
											}
										}
										num26 >>>= 8;
										int num31 = (ushort)((short*)(&localsPointer->field_5.m_huff_codes))[(uint)(num26 & 0xFF)];
										int num32 = (byte)((sbyte*)(&localsPointer->field_5.m_huff_code_sizes))[(uint)(num26 & 0xFF)];
										if ((uint)num32 < 1u || (uint)num32 > 16u)
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1400);
											if (ExceptionInfo.Current != null)
											{
												goto IL_15fe;
											}
										}
										if ((ulong)(uint)num31 >= (ulong)(1L << (int)(uint)num32))
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1400);
											if (ExceptionInfo.Current != null)
											{
												goto IL_15fe;
											}
										}
										localsPointer->field_0 |= (long)((ulong)(uint)num31 << (int)(uint)localsPointer->field_1);
										localsPointer->field_1 += num32;
										if (localsPointer->field_1 > 64)
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1400);
											if (ExceptionInfo.Current != null)
											{
												goto IL_15fe;
											}
										}
										num26 >>>= 8;
										if (localsPointer->field_1 >= 49)
										{
											if ((uint)(localsPointer->field_2 + 8) > (uint)dst_buf_size)
											{
												goto IL_0d86;
											}
											long field_ = localsPointer->field_0;
											*(long*)((byte*)pDst + (uint)localsPointer->field_2) = field_;
											int num33 = localsPointer->field_1 & -8;
											localsPointer->field_2 += num33 >>> 3;
											if ((uint)num33 >= 64u)
											{
												wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1405);
												if (ExceptionInfo.Current != null)
												{
													goto IL_15fe;
												}
											}
											localsPointer->field_0 >>>= (int)(uint)num33;
											localsPointer->field_1 -= num33;
										}
										int num34 = (ushort)((short*)(&localsPointer->field_5.m_huff_codes))[(uint)num26];
										int num35 = (byte)((sbyte*)(&localsPointer->field_5.m_huff_code_sizes))[(uint)num26];
										if ((uint)num35 < 1u || (uint)num35 > 16u)
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1408);
											if (ExceptionInfo.Current != null)
											{
												goto IL_15fe;
											}
										}
										if ((ulong)(uint)num34 >= (ulong)(1L << (int)(uint)num35))
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1408);
											if (ExceptionInfo.Current != null)
											{
												goto IL_15fe;
											}
										}
										localsPointer->field_0 |= (long)((ulong)(uint)num34 << (int)(uint)localsPointer->field_1);
										localsPointer->field_1 += num35;
										if (localsPointer->field_1 > 64)
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1408);
											if (ExceptionInfo.Current != null)
											{
												goto IL_15fe;
											}
										}
									}
									else if (num25 == 1)
									{
										int num36 = (int)(num24 >>> 8);
										int num37 = (ushort)((short*)(&localsPointer->field_5.m_huff_codes))[(uint)num36];
										int num38 = (byte)((sbyte*)(&localsPointer->field_5.m_huff_code_sizes))[(uint)num36];
										if ((uint)num38 < 1u || (uint)num38 > 16u)
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1413);
											if (ExceptionInfo.Current != null)
											{
												goto IL_15fe;
											}
										}
										if ((ulong)(uint)num37 >= (ulong)(1L << (int)(uint)num38))
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1413);
											if (ExceptionInfo.Current != null)
											{
												goto IL_15fe;
											}
										}
										localsPointer->field_0 |= (long)((ulong)(uint)num37 << (int)(uint)localsPointer->field_1);
										localsPointer->field_1 += num38;
										if (localsPointer->field_1 > 64)
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1413);
											if (ExceptionInfo.Current != null)
											{
												goto IL_15fe;
											}
										}
									}
									else
									{
										int num39 = num25 + 1 - 3;
										int num40 = (ushort)((short*)(&localsPointer->field_5.m_huff_codes))[(ushort)((short*)g_defl_len_sym.__pointer)[(uint)num39]];
										int num41 = (byte)((sbyte*)(&localsPointer->field_5.m_huff_code_sizes))[(ushort)((short*)g_defl_len_sym.__pointer)[(uint)num39]];
										if ((uint)num41 < 1u || (uint)num41 > 16u)
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1421);
											if (ExceptionInfo.Current != null)
											{
												goto IL_15fe;
											}
										}
										if ((ulong)(uint)num40 >= (ulong)(1L << (int)(uint)num41))
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1421);
											if (ExceptionInfo.Current != null)
											{
												goto IL_15fe;
											}
										}
										localsPointer->field_0 |= (long)((ulong)(uint)num40 << (int)(uint)localsPointer->field_1);
										localsPointer->field_1 += num41;
										if (localsPointer->field_1 > 64)
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1421);
											if (ExceptionInfo.Current != null)
											{
												goto IL_15fe;
											}
										}
										long num42 = (byte)((sbyte*)g_defl_len_extra.__pointer)[(uint)num39];
										int num43 = num39 & ((int*)g_bitmasks.__pointer)[num42];
										int num44;
										checked
										{
											num44 = unchecked((byte)((sbyte*)g_defl_len_extra.__pointer)[(uint)num39]) + 1;
										}
										if ((uint)num44 < 0u || (uint)num44 > 16u)
										{
											wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1422);
											if (ExceptionInfo.Current != null)
											{
												goto IL_15fe;
											}
										}
										if ((ulong)(uint)num43 >= (ulong)(1L << (int)(uint)num44))
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1422);
											if (ExceptionInfo.Current != null)
											{
												goto IL_15fe;
											}
										}
										localsPointer->field_0 |= (long)((ulong)(uint)num43 << (int)(uint)localsPointer->field_1);
										localsPointer->field_1 += num44;
										if (localsPointer->field_1 > 64)
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1422);
											if (ExceptionInfo.Current != null)
											{
												goto IL_15fe;
											}
										}
									}
									if ((uint)(localsPointer->field_2 + 8) > (uint)dst_buf_size)
									{
										goto IL_132b;
									}
									long field_2 = localsPointer->field_0;
									*(long*)((byte*)pDst + (uint)localsPointer->field_2) = field_2;
									num45 = localsPointer->field_1 & -8;
									localsPointer->field_2 += num45 >>> 3;
									if ((uint)num45 < 64u)
									{
										continue;
									}
									wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1428);
									if (ExceptionInfo.Current == null)
									{
										continue;
									}
									goto IL_15fe;
								}
								int num46 = (ushort)((short*)(&localsPointer->field_5.m_huff_codes))[256];
								int num47 = (byte)((sbyte*)(&localsPointer->field_5.m_huff_code_sizes))[256];
								if ((uint)num47 < 1u || (uint)num47 > 16u)
								{
									wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1431);
									if (ExceptionInfo.Current != null)
									{
										goto IL_15fe;
									}
								}
								if ((ulong)(uint)num46 >= (ulong)(1L << (int)(uint)num47))
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1431);
									if (ExceptionInfo.Current != null)
									{
										goto IL_15fe;
									}
								}
								localsPointer->field_0 |= (long)((ulong)(uint)num46 << (int)(uint)localsPointer->field_1);
								localsPointer->field_1 += num47;
								if (localsPointer->field_1 > 64)
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1431);
									if (ExceptionInfo.Current != null)
									{
										goto IL_15fe;
									}
								}
								while (true)
								{
									if (localsPointer->field_1 > 0)
									{
										if ((uint)(localsPointer->field_2 + 1) > (uint)dst_buf_size)
										{
											num23 = 0;
											break;
										}
										sbyte b = (sbyte)localsPointer->field_0;
										((sbyte*)pDst)[(uint)localsPointer->field_2] = b;
										localsPointer->field_2++;
										localsPointer->field_0 >>>= 8;
										checked
										{
											localsPointer->field_1 -= 8;
											continue;
										}
									}
									int num48 = 0;
									while (true)
									{
										if ((uint)num48 < 4u)
										{
											if ((uint)(localsPointer->field_2 + 1) > (uint)dst_buf_size)
											{
												num23 = 0;
												break;
											}
											((sbyte*)pDst)[(uint)localsPointer->field_2] = (sbyte)(num10 >>> 24);
											localsPointer->field_2++;
											num10 <<= 8;
											num48++;
											continue;
										}
										num23 = localsPointer->field_2;
										break;
									}
									break;
								}
							}
							goto IL_15e5;
						}
					}
				}
			}
			goto IL_15fe;
		}
		IL_15fe:
		ExceptionInfo? current = ExceptionInfo.Current;
		ExceptionInfo.Current = null;
		vector_unsigned_int64_class_std_allocator_unsigned_int64_Destructor.Invoke(&localsPointer->field_3);
		ExceptionInfo.Current = current;
		return 0;
		IL_0d86:
		num23 = 0;
		goto IL_15e5;
		IL_132b:
		num23 = 0;
		goto IL_15e5;
		IL_15e5:
		vector_unsigned_int64_class_std_allocator_unsigned_int64_Destructor.Invoke(&localsPointer->field_3);
		int result = num23;
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
