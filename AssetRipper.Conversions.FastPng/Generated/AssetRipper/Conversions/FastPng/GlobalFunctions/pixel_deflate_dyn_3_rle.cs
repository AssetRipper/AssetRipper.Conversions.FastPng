using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?pixel_deflate_dyn_3_rle@fpng@@YAIPEBEIIPEAEI@Z")]
[DemangledName("unsigned int __cdecl fpng::pixel_deflate_dyn_3_rle(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int)")]
internal static partial class pixel_deflate_dyn_3_rle
{
	private partial struct LocalVariables
	{
		public long field_0;

		public int field_1;

		public int field_2;

		public std_vector_drook9b field_3;

		public std_allocator field_4;

		public InlineArray288_Int32 field_5;

		public fpng_defl_huff field_6;
	}

	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("unsigned char const *")] void* pImg, [NativeType("unsigned int")] int w, [NativeType("unsigned int")] int h, [NativeType("unsigned char *")] void* pDst, [NativeType("unsigned int")] int dst_buf_size)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = 0L;
		localsPointer->field_1 = 0;
		localsPointer->field_2 = 0;
		localsPointer->field_3 = default(std_vector_drook9b);
		localsPointer->field_4 = default(std_allocator);
		localsPointer->field_5 = default(InlineArray288_Int32);
		localsPointer->field_6 = default(fpng_defl_huff);
		unchecked
		{
			int num = 1 + w * 3;
			localsPointer->field_0 = 0L;
			localsPointer->field_1 = 0;
			localsPointer->field_2 = 0;
			int num2 = 120;
			int num3 = 8;
			if ((uint)num3 < 0u || (uint)num3 > 16u)
			{
				wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1002);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			if ((ulong)(uint)num2 >= (ulong)(1L << (int)(uint)num3))
			{
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1002);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			localsPointer->field_0 |= (long)((ulong)(uint)num2 << (int)(uint)localsPointer->field_1);
			localsPointer->field_1 += num3;
			if (localsPointer->field_1 > 64)
			{
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1002);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			int num4 = 1;
			int num5 = 8;
			if ((uint)num5 < 0u || (uint)num5 > 16u)
			{
				wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1003);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			if ((ulong)(uint)num4 >= (ulong)(1L << (int)(uint)num5))
			{
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1003);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			localsPointer->field_0 |= (long)((ulong)(uint)num4 << (int)(uint)localsPointer->field_1);
			localsPointer->field_1 += num5;
			if (localsPointer->field_1 > 64)
			{
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1003);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			int num6 = 1;
			int num7 = 1;
			if ((uint)num7 < 0u || (uint)num7 > 16u)
			{
				wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1006);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			if ((ulong)(uint)num6 >= (ulong)(1L << (int)(uint)num7))
			{
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1006);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			localsPointer->field_0 |= (long)((ulong)(uint)num6 << (int)(uint)localsPointer->field_1);
			localsPointer->field_1 += num7;
			if (localsPointer->field_1 > 64)
			{
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1006);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			allocator_unsigned_int_Constructor.Invoke(&localsPointer->field_4);
			vector_unsigned_int_class_std_allocator_unsigned_int_Constructor.Invoke(&localsPointer->field_3, (uint)((w + 1) * h), &localsPointer->field_4);
			if (ExceptionInfo.Current != null)
			{
				return 0;
			}
			void* ptr = data_uf9yj3b.Invoke(&localsPointer->field_3);
			llvm_memset_p0_i64.Invoke(&localsPointer->field_5, 0, 1152L, isVolatile: false);
			int num8 = 0;
			int num9 = fpng_adler32.Invoke(pImg, (uint)(num * h), 1);
			if (ExceptionInfo.Current == null)
			{
				int num10 = num9;
				int num11 = 0;
				while (true)
				{
					if ((uint)num11 < (uint)h)
					{
						int num12 = num8 + num;
						int num13 = (byte)((sbyte*)pImg)[(uint)num8++];
						int num14 = 1 | (num13 << 8);
						void* ptr2 = ptr;
						ptr = (byte*)ptr2 + 4;
						*(int*)ptr2 = num14;
						((int*)(&localsPointer->field_5))[(uint)num13]++;
						int num15 = READ_RGB_PIXEL.Invoke((byte*)pImg + (uint)num8);
						if (ExceptionInfo.Current != null)
						{
							break;
						}
						int num16 = num15;
						int num17 = num16 << 8;
						void* ptr3 = ptr;
						ptr = (byte*)ptr3 + 4;
						*(int*)ptr3 = num17;
						((int*)(&localsPointer->field_5))[(uint)(num16 & 0xFF)]++;
						((int*)(&localsPointer->field_5))[(uint)((num16 >>> 8) & 0xFF)]++;
						((int*)(&localsPointer->field_5))[(uint)(num16 >>> 16)]++;
						num8 += 3;
						int num18 = num16;
						while ((uint)num8 < (uint)num12)
						{
							int num19 = READ_RGB_PIXEL.Invoke((byte*)pImg + (uint)num8);
							if (ExceptionInfo.Current != null)
							{
								goto end_IL_0484;
							}
							int num20 = num19;
							if (num20 == num18)
							{
								int i = 3;
								int num21 = minimum_ymfg3kb.Invoke(255, num12 - num8);
								if (ExceptionInfo.Current != null)
								{
									goto end_IL_0484;
								}
								for (int num22 = num21; (uint)i < (uint)num22; i += 3)
								{
									int num23 = READ_RGB_PIXEL.Invoke((byte*)pImg + (uint)num8 + (uint)i);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0484;
									}
									if (num23 != num20)
									{
										break;
									}
								}
								int num24 = i - 1;
								void* ptr4 = ptr;
								ptr = (byte*)ptr4 + 4;
								*(int*)ptr4 = num24;
								long num25 = (ushort)((short*)g_defl_len_sym.__pointer)[(uint)(i - 3)];
								((int*)(&localsPointer->field_5))[num25]++;
								num8 += i;
							}
							else
							{
								int num26 = num20 << 8;
								void* ptr5 = ptr;
								ptr = (byte*)ptr5 + 4;
								*(int*)ptr5 = num26;
								((int*)(&localsPointer->field_5))[(uint)(num20 & 0xFF)]++;
								((int*)(&localsPointer->field_5))[(uint)((num20 >>> 8) & 0xFF)]++;
								((int*)(&localsPointer->field_5))[(uint)(num20 >>> 16)]++;
								num18 = num20;
								num8 += 3;
							}
						}
						num11++;
						continue;
					}
					if (num8 != h * num)
					{
						wassert.Invoke(String_bjvsuxc.__pointer, String_uxbkrtb.__pointer, 1086);
						if (ExceptionInfo.Current != null)
						{
							break;
						}
					}
					int num27 = (int)(((long)ptr - (long)data_uf9yj3b.Invoke(&localsPointer->field_3)) / 4L);
					if ((ulong)(uint)num27 > (ulong)size_wtrvsgc.Invoke(&localsPointer->field_3))
					{
						wassert.Invoke(String_hsgehfc.__pointer, String_uxbkrtb.__pointer, 1088);
						if (ExceptionInfo.Current != null)
						{
							break;
						}
					}
					((int*)(&localsPointer->field_5))[256] = 1;
					adjust_freq32.Invoke(pFreq16: &localsPointer->field_6.m_huff_count, num_freq: 288, pFreq: &localsPointer->field_5);
					if (ExceptionInfo.Current != null)
					{
						break;
					}
					llvm_memset_p0_i64.Invoke((byte*)(&localsPointer->field_6.m_huff_count) + sizeof(InlineArray288_Int16), 0, 64L, isVolatile: false);
					((short*)((byte*)(&localsPointer->field_6.m_huff_count) + sizeof(InlineArray288_Int16)))[2] = 1;
					((short*)((byte*)(&localsPointer->field_6.m_huff_count) + sizeof(InlineArray288_Int16)))[3] = 1;
					bool flag = defl_start_dynamic_block.Invoke(&localsPointer->field_6, pDst, &localsPointer->field_2, dst_buf_size, &localsPointer->field_0, &localsPointer->field_1);
					if (ExceptionInfo.Current != null)
					{
						break;
					}
					int num28;
					if (!flag)
					{
						num28 = 0;
					}
					else
					{
						if (localsPointer->field_1 > 7)
						{
							wassert.Invoke(String_vpte4cc.__pointer, String_uxbkrtb.__pointer, 1103);
							if (ExceptionInfo.Current != null)
							{
								break;
							}
						}
						if ((ushort)((short*)((byte*)(&localsPointer->field_6.m_huff_codes) + sizeof(InlineArray288_Int16)))[2] != 0 || ((byte*)(&localsPointer->field_6.m_huff_code_sizes) + sizeof(InlineArray288_SByte))[2] != 1)
						{
							wassert.Invoke(String_df5ko9b.__pointer, String_uxbkrtb.__pointer, 1104);
							if (ExceptionInfo.Current != null)
							{
								break;
							}
						}
						int num29 = 0;
						while ((uint)num29 < (uint)num27)
						{
							int num30 = *(int*)vector_unsigned_int_class_std_allocator_unsigned_int_Index.Invoke(&localsPointer->field_3, (uint)num29);
							int num31 = num30 & 0xFF;
							if (num31 == 0)
							{
								int num32 = num30 >>> 8;
								int num33 = (ushort)((short*)(&localsPointer->field_6.m_huff_codes))[(uint)(num32 & 0xFF)];
								int num34 = (byte)((sbyte*)(&localsPointer->field_6.m_huff_code_sizes))[(uint)(num32 & 0xFF)];
								if ((uint)num34 < 1u || (uint)num34 > 16u)
								{
									wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1115);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0484;
									}
								}
								if ((ulong)(uint)num33 >= (ulong)(1L << (int)(uint)num34))
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1115);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0484;
									}
								}
								localsPointer->field_0 |= (long)((ulong)(uint)num33 << (int)(uint)localsPointer->field_1);
								localsPointer->field_1 += num34;
								if (localsPointer->field_1 > 64)
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1115);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0484;
									}
								}
								num32 >>>= 8;
								int num35 = (ushort)((short*)(&localsPointer->field_6.m_huff_codes))[(uint)(num32 & 0xFF)];
								int num36 = (byte)((sbyte*)(&localsPointer->field_6.m_huff_code_sizes))[(uint)(num32 & 0xFF)];
								if ((uint)num36 < 1u || (uint)num36 > 16u)
								{
									wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1118);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0484;
									}
								}
								if ((ulong)(uint)num35 >= (ulong)(1L << (int)(uint)num36))
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1118);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0484;
									}
								}
								localsPointer->field_0 |= (long)((ulong)(uint)num35 << (int)(uint)localsPointer->field_1);
								localsPointer->field_1 += num36;
								if (localsPointer->field_1 > 64)
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1118);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0484;
									}
								}
								num32 >>>= 8;
								int num37 = (ushort)((short*)(&localsPointer->field_6.m_huff_codes))[(uint)num32];
								int num38 = (byte)((sbyte*)(&localsPointer->field_6.m_huff_code_sizes))[(uint)num32];
								if ((uint)num38 < 1u || (uint)num38 > 16u)
								{
									wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1121);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0484;
									}
								}
								if ((ulong)(uint)num37 >= (ulong)(1L << (int)(uint)num38))
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1121);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0484;
									}
								}
								localsPointer->field_0 |= (long)((ulong)(uint)num37 << (int)(uint)localsPointer->field_1);
								localsPointer->field_1 += num38;
								if (localsPointer->field_1 > 64)
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1121);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0484;
									}
								}
							}
							else if (num31 == 1)
							{
								int num39 = num30 >>> 8;
								int num40 = (ushort)((short*)(&localsPointer->field_6.m_huff_codes))[(uint)num39];
								int num41 = (byte)((sbyte*)(&localsPointer->field_6.m_huff_code_sizes))[(uint)num39];
								if ((uint)num41 < 1u || (uint)num41 > 16u)
								{
									wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1126);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0484;
									}
								}
								if ((ulong)(uint)num40 >= (ulong)(1L << (int)(uint)num41))
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1126);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0484;
									}
								}
								localsPointer->field_0 |= (long)((ulong)(uint)num40 << (int)(uint)localsPointer->field_1);
								localsPointer->field_1 += num41;
								if (localsPointer->field_1 > 64)
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1126);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0484;
									}
								}
							}
							else
							{
								int num42 = num31 + 1 - 3;
								int num43 = (ushort)((short*)(&localsPointer->field_6.m_huff_codes))[(ushort)((short*)g_defl_len_sym.__pointer)[(uint)num42]];
								int num44 = (byte)((sbyte*)(&localsPointer->field_6.m_huff_code_sizes))[(ushort)((short*)g_defl_len_sym.__pointer)[(uint)num42]];
								if ((uint)num44 < 1u || (uint)num44 > 16u)
								{
									wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1134);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0484;
									}
								}
								if ((ulong)(uint)num43 >= (ulong)(1L << (int)(uint)num44))
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1134);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0484;
									}
								}
								localsPointer->field_0 |= (long)((ulong)(uint)num43 << (int)(uint)localsPointer->field_1);
								localsPointer->field_1 += num44;
								if (localsPointer->field_1 > 64)
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1134);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0484;
									}
								}
								long num45 = (byte)((sbyte*)g_defl_len_extra.__pointer)[(uint)num42];
								int num46 = num42 & ((int*)g_bitmasks.__pointer)[num45];
								int num47;
								checked
								{
									num47 = unchecked((byte)((sbyte*)g_defl_len_extra.__pointer)[(uint)num42]) + 1;
								}
								if ((uint)num47 < 0u || (uint)num47 > 16u)
								{
									wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1135);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0484;
									}
								}
								if ((ulong)(uint)num46 >= (ulong)(1L << (int)(uint)num47))
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1135);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0484;
									}
								}
								localsPointer->field_0 |= (long)((ulong)(uint)num46 << (int)(uint)localsPointer->field_1);
								localsPointer->field_1 += num47;
								if (localsPointer->field_1 > 64)
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1135);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0484;
									}
								}
							}
							if ((uint)(localsPointer->field_2 + 8) <= (uint)dst_buf_size)
							{
								long field_ = localsPointer->field_0;
								*(long*)((byte*)pDst + (uint)localsPointer->field_2) = field_;
								int num48 = localsPointer->field_1 & -8;
								localsPointer->field_2 += num48 >>> 3;
								if ((uint)num48 >= 64u)
								{
									wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1142);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0484;
									}
								}
								localsPointer->field_0 >>>= (int)(uint)num48;
								localsPointer->field_1 -= num48;
								num29++;
								continue;
							}
							goto IL_1101;
						}
						int num49 = (ushort)((short*)(&localsPointer->field_6.m_huff_codes))[256];
						int num50 = (byte)((sbyte*)(&localsPointer->field_6.m_huff_code_sizes))[256];
						if ((uint)num50 < 1u || (uint)num50 > 16u)
						{
							wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1145);
							if (ExceptionInfo.Current != null)
							{
								break;
							}
						}
						if ((ulong)(uint)num49 >= (ulong)(1L << (int)(uint)num50))
						{
							wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1145);
							if (ExceptionInfo.Current != null)
							{
								break;
							}
						}
						localsPointer->field_0 |= (long)((ulong)(uint)num49 << (int)(uint)localsPointer->field_1);
						localsPointer->field_1 += num50;
						if (localsPointer->field_1 > 64)
						{
							wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1145);
							if (ExceptionInfo.Current != null)
							{
								break;
							}
						}
						while (true)
						{
							if (localsPointer->field_1 > 0)
							{
								if ((uint)(localsPointer->field_2 + 1) > (uint)dst_buf_size)
								{
									num28 = 0;
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
							int num51 = 0;
							while (true)
							{
								if ((uint)num51 < 4u)
								{
									if ((uint)(localsPointer->field_2 + 1) > (uint)dst_buf_size)
									{
										num28 = 0;
										break;
									}
									((sbyte*)pDst)[(uint)localsPointer->field_2] = (sbyte)(num10 >>> 24);
									localsPointer->field_2++;
									num10 <<= 8;
									num51++;
									continue;
								}
								num28 = localsPointer->field_2;
								break;
							}
							break;
						}
					}
					goto IL_13bb;
					IL_13bb:
					vector_unsigned_int_class_std_allocator_unsigned_int_Destructor.Invoke(&localsPointer->field_3);
					int result = num28;
					StackFrameList.Current.Clear(startFrame);
					return result;
					IL_1101:
					num28 = 0;
					goto IL_13bb;
					continue;
					end_IL_0484:
					break;
				}
			}
			ExceptionInfo? current = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			vector_unsigned_int_class_std_allocator_unsigned_int_Destructor.Invoke(&localsPointer->field_3);
			ExceptionInfo.Current = current;
			return 0;
		}
	}
}
