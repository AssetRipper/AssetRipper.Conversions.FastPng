using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?pixel_deflate_dyn_4_rle_one_pass@fpng@@YAIPEBEIIPEAEI@Z")]
[DemangledName("unsigned int __cdecl fpng::pixel_deflate_dyn_4_rle_one_pass(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int)")]
internal static partial class pixel_deflate_dyn_4_rle_one_pass
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("unsigned char const *")] void* pImg, [NativeType("unsigned int")] int w, [NativeType("unsigned int")] int h, [NativeType("unsigned char *")] void* pDst, [NativeType("unsigned int")] int dst_buf_size)
	{
		int num = 0;
		int num2 = 0;
		long num3 = 0L;
		int num4 = 0;
		void* ptr = null;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		int num11 = 0;
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
		int num37 = 0;
		int num38 = 0;
		int num39 = 0;
		int num40 = 0;
		int num41 = 0;
		int num42 = 0;
		int num43 = 0;
		int num44 = 0;
		int num45 = 0;
		int num46 = 0;
		int num47 = 0;
		int num48 = 0;
		unchecked
		{
			int num49 = 1 + w * 4;
			if ((ulong)(uint)dst_buf_size < 61uL)
			{
				return 0;
			}
			llvm_memcpy_p0_p0_i64.Invoke(pDst, g_dyn_huff_4.__pointer, 61L, isVolatile: false);
			num2 = 61;
			num3 = 1L;
			num4 = 2;
			ptr = pImg;
			num5 = 0;
			num6 = fpng_adler32.Invoke(pImg, (uint)(num49 * h), 1);
			for (num7 = 0; (uint)num7 < (uint)h; num7++)
			{
				num8 = num5 + num49;
				num9 = (byte)((sbyte*)ptr)[(uint)num5++];
				num10 = (ushort)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)num9].field_1;
				num11 = (byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)num9].field_0;
				int num50;
				if ((uint)num11 >= 1u && (uint)num11 <= 16u)
				{
					num50 = -1;
				}
				else
				{
					wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1473);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num50 = 0;
				}
				int num51;
				if ((ulong)(uint)num10 < (ulong)(1L << (int)(uint)num11))
				{
					num51 = -1;
				}
				else
				{
					wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1473);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num51 = 0;
				}
				num3 |= (long)((ulong)(uint)num10 << (int)(uint)num4);
				num4 += num11;
				int num52;
				if (num4 <= 64)
				{
					num52 = -1;
				}
				else
				{
					wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1473);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num52 = 0;
				}
				if ((uint)(num2 + 8) > (uint)dst_buf_size)
				{
					return 0;
				}
				*(long*)((byte*)pDst + (uint)num2) = num3;
				num12 = num4 & -8;
				num2 += num12 >>> 3;
				int num53;
				if ((uint)num12 < 64u)
				{
					num53 = -1;
				}
				else
				{
					wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1475);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num53 = 0;
				}
				num3 >>>= (int)(uint)num12;
				num4 -= num12;
				num14 = *(int*)((byte*)ptr + (uint)num5);
				num15 = (ushort)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)(num14 & 0xFF)].field_1;
				num16 = (byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)(num14 & 0xFF)].field_0;
				int num54;
				if ((uint)num16 >= 1u && (uint)num16 <= 16u)
				{
					num54 = -1;
				}
				else
				{
					wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1481);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num54 = 0;
				}
				int num55;
				if ((ulong)(uint)num15 < (ulong)(1L << (int)(uint)num16))
				{
					num55 = -1;
				}
				else
				{
					wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1481);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num55 = 0;
				}
				num3 |= (long)((ulong)(uint)num15 << (int)(uint)num4);
				num4 += num16;
				int num56;
				if (num4 <= 64)
				{
					num56 = -1;
				}
				else
				{
					wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1481);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num56 = 0;
				}
				num17 = (ushort)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)((num14 >>> 8) & 0xFF)].field_1;
				num18 = (byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)((num14 >>> 8) & 0xFF)].field_0;
				int num57;
				if ((uint)num18 >= 1u && (uint)num18 <= 16u)
				{
					num57 = -1;
				}
				else
				{
					wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1482);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num57 = 0;
				}
				int num58;
				if ((ulong)(uint)num17 < (ulong)(1L << (int)(uint)num18))
				{
					num58 = -1;
				}
				else
				{
					wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1482);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num58 = 0;
				}
				num3 |= (long)((ulong)(uint)num17 << (int)(uint)num4);
				num4 += num18;
				int num59;
				if (num4 <= 64)
				{
					num59 = -1;
				}
				else
				{
					wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1482);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num59 = 0;
				}
				num19 = (ushort)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)((num14 >>> 16) & 0xFF)].field_1;
				num20 = (byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)((num14 >>> 16) & 0xFF)].field_0;
				int num60;
				if ((uint)num20 >= 1u && (uint)num20 <= 16u)
				{
					num60 = -1;
				}
				else
				{
					wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1483);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num60 = 0;
				}
				int num61;
				if ((ulong)(uint)num19 < (ulong)(1L << (int)(uint)num20))
				{
					num61 = -1;
				}
				else
				{
					wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1483);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num61 = 0;
				}
				num3 |= (long)((ulong)(uint)num19 << (int)(uint)num4);
				num4 += num20;
				int num62;
				if (num4 <= 64)
				{
					num62 = -1;
				}
				else
				{
					wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1483);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num62 = 0;
				}
				if (num4 >= 49)
				{
					if ((uint)(num2 + 8) > (uint)dst_buf_size)
					{
						return 0;
					}
					*(long*)((byte*)pDst + (uint)num2) = num3;
					num21 = num4 & -8;
					num2 += num21 >>> 3;
					int num63;
					if ((uint)num21 < 64u)
					{
						num63 = -1;
					}
					else
					{
						wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1487);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						num63 = 0;
					}
					num3 >>>= (int)(uint)num21;
					num4 -= num21;
				}
				num22 = (ushort)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)(num14 >>> 24)].field_1;
				num23 = (byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)(num14 >>> 24)].field_0;
				int num64;
				if ((uint)num23 >= 1u && (uint)num23 <= 16u)
				{
					num64 = -1;
				}
				else
				{
					wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1490);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num64 = 0;
				}
				int num65;
				if ((ulong)(uint)num22 < (ulong)(1L << (int)(uint)num23))
				{
					num65 = -1;
				}
				else
				{
					wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1490);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num65 = 0;
				}
				num3 |= (long)((ulong)(uint)num22 << (int)(uint)num4);
				num4 += num23;
				int num66;
				if (num4 <= 64)
				{
					num66 = -1;
				}
				else
				{
					wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1490);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num66 = 0;
				}
				num5 += 4;
				num13 = num14;
				if ((uint)(num2 + 8) > (uint)dst_buf_size)
				{
					return 0;
				}
				*(long*)((byte*)pDst + (uint)num2) = num3;
				num24 = num4 & -8;
				num2 += num24 >>> 3;
				int num67;
				if ((uint)num24 < 64u)
				{
					num67 = -1;
				}
				else
				{
					wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1497);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num67 = 0;
				}
				num3 >>>= (int)(uint)num24;
				num4 -= num24;
				while ((uint)num5 < (uint)num8)
				{
					num25 = *(int*)((byte*)ptr + (uint)num5);
					if (num25 == num13)
					{
						num26 = 4;
						for (num27 = minimum_ymfg3kb.Invoke(252, num8 - num5); (uint)num26 < (uint)num27 && *(int*)((byte*)ptr + (uint)num5 + (uint)num26) == num25; num26 += 4)
						{
						}
						num28 = num26 - 3;
						long num68 = (ushort)((short*)g_defl_len_sym.__pointer)[(uint)num28];
						num29 = (byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[num68].field_0;
						num30 = (byte)((sbyte*)g_defl_len_extra.__pointer)[(uint)num28];
						if (num26 != 4 || (uint)(num29 + num30 + 1) <= (uint)checked(unchecked((byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)(num25 & 0xFF)].field_0) + unchecked((byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)((num25 >>> 8) & 0xFF)].field_0) + unchecked((byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)((num25 >>> 16) & 0xFF)].field_0) + unchecked((byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)(num25 >>> 24)].field_0)))
						{
							long num69 = (ushort)((short*)g_defl_len_sym.__pointer)[(uint)num28];
							num32 = (ushort)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[num69].field_1;
							num33 = num29;
							int num70;
							if ((uint)num33 >= 1u && (uint)num33 <= 16u)
							{
								num70 = -1;
							}
							else
							{
								wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1530);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								num70 = 0;
							}
							int num71;
							if ((ulong)(uint)num32 < (ulong)(1L << (int)(uint)num33))
							{
								num71 = -1;
							}
							else
							{
								wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1530);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								num71 = 0;
							}
							num3 |= (long)((ulong)(uint)num32 << (int)(uint)num4);
							num4 += num33;
							int num72;
							if (num4 <= 64)
							{
								num72 = -1;
							}
							else
							{
								wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1530);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								num72 = 0;
							}
							int num73 = num28;
							long num74 = (byte)((sbyte*)g_defl_len_extra.__pointer)[(uint)num28];
							num34 = num73 & ((int*)g_bitmasks.__pointer)[num74];
							num35 = num30 + 1;
							int num75;
							if ((uint)num35 >= 0u && (uint)num35 <= 16u)
							{
								num75 = -1;
							}
							else
							{
								wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1531);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								num75 = 0;
							}
							int num76;
							if ((ulong)(uint)num34 < (ulong)(1L << (int)(uint)num35))
							{
								num76 = -1;
							}
							else
							{
								wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1531);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								num76 = 0;
							}
							num3 |= (long)((ulong)(uint)num34 << (int)(uint)num4);
							num4 += num35;
							int num77;
							if (num4 <= 64)
							{
								num77 = -1;
							}
							else
							{
								wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1531);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								num77 = 0;
							}
							num5 += num26;
							goto IL_102c;
						}
					}
					num36 = (ushort)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)(num25 & 0xFF)].field_1;
					num37 = (byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)(num25 & 0xFF)].field_0;
					int num78;
					if ((uint)num37 >= 1u && (uint)num37 <= 16u)
					{
						num78 = -1;
					}
					else
					{
						wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1538);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						num78 = 0;
					}
					int num79;
					if ((ulong)(uint)num36 < (ulong)(1L << (int)(uint)num37))
					{
						num79 = -1;
					}
					else
					{
						wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1538);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						num79 = 0;
					}
					num3 |= (long)((ulong)(uint)num36 << (int)(uint)num4);
					num4 += num37;
					int num80;
					if (num4 <= 64)
					{
						num80 = -1;
					}
					else
					{
						wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1538);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						num80 = 0;
					}
					num38 = (ushort)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)((num25 >>> 8) & 0xFF)].field_1;
					num39 = (byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)((num25 >>> 8) & 0xFF)].field_0;
					int num81;
					if ((uint)num39 >= 1u && (uint)num39 <= 16u)
					{
						num81 = -1;
					}
					else
					{
						wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1539);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						num81 = 0;
					}
					int num82;
					if ((ulong)(uint)num38 < (ulong)(1L << (int)(uint)num39))
					{
						num82 = -1;
					}
					else
					{
						wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1539);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						num82 = 0;
					}
					num3 |= (long)((ulong)(uint)num38 << (int)(uint)num4);
					num4 += num39;
					int num83;
					if (num4 <= 64)
					{
						num83 = -1;
					}
					else
					{
						wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1539);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						num83 = 0;
					}
					num40 = (ushort)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)((num25 >>> 16) & 0xFF)].field_1;
					num41 = (byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)((num25 >>> 16) & 0xFF)].field_0;
					int num84;
					if ((uint)num41 >= 1u && (uint)num41 <= 16u)
					{
						num84 = -1;
					}
					else
					{
						wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1540);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						num84 = 0;
					}
					int num85;
					if ((ulong)(uint)num40 < (ulong)(1L << (int)(uint)num41))
					{
						num85 = -1;
					}
					else
					{
						wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1540);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						num85 = 0;
					}
					num3 |= (long)((ulong)(uint)num40 << (int)(uint)num4);
					num4 += num41;
					int num86;
					if (num4 <= 64)
					{
						num86 = -1;
					}
					else
					{
						wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1540);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						num86 = 0;
					}
					if (num4 >= 49)
					{
						if ((uint)(num2 + 8) > (uint)dst_buf_size)
						{
							return 0;
						}
						*(long*)((byte*)pDst + (uint)num2) = num3;
						num42 = num4 & -8;
						num2 += num42 >>> 3;
						int num87;
						if ((uint)num42 < 64u)
						{
							num87 = -1;
						}
						else
						{
							wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1544);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							num87 = 0;
						}
						num3 >>>= (int)(uint)num42;
						num4 -= num42;
					}
					num43 = (ushort)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)(num25 >>> 24)].field_1;
					num44 = (byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)(num25 >>> 24)].field_0;
					int num88;
					if ((uint)num44 >= 1u && (uint)num44 <= 16u)
					{
						num88 = -1;
					}
					else
					{
						wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1547);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						num88 = 0;
					}
					int num89;
					if ((ulong)(uint)num43 < (ulong)(1L << (int)(uint)num44))
					{
						num89 = -1;
					}
					else
					{
						wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1547);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						num89 = 0;
					}
					num3 |= (long)((ulong)(uint)num43 << (int)(uint)num4);
					num4 += num44;
					int num90;
					if (num4 <= 64)
					{
						num90 = -1;
					}
					else
					{
						wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1547);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						num90 = 0;
					}
					num5 += 4;
					num13 = num25;
					goto IL_102c;
					IL_102c:
					if ((uint)(num2 + 8) > (uint)dst_buf_size)
					{
						return 0;
					}
					*(long*)((byte*)pDst + (uint)num2) = num3;
					num45 = num4 & -8;
					num2 += num45 >>> 3;
					int num91;
					if ((uint)num45 < 64u)
					{
						num91 = -1;
					}
					else
					{
						wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1554);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						num91 = 0;
					}
					num3 >>>= (int)(uint)num45;
					num4 -= num45;
				}
			}
			int num92;
			if (num5 == h * num49)
			{
				num92 = -1;
			}
			else
			{
				wassert.Invoke(String_bjvsuxc.__pointer, String_uxbkrtb.__pointer, 1560);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num92 = 0;
			}
			int num93;
			if (num4 <= 7)
			{
				num93 = -1;
			}
			else
			{
				wassert.Invoke(String_vpte4cc.__pointer, String_uxbkrtb.__pointer, 1562);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num93 = 0;
			}
			num46 = 2047;
			num47 = 12;
			int num94;
			if ((uint)num47 >= 1u && (uint)num47 <= 16u)
			{
				num94 = -1;
			}
			else
			{
				wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1564);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num94 = 0;
			}
			int num95;
			if ((ulong)(uint)num46 < (ulong)(1L << (int)(uint)num47))
			{
				num95 = -1;
			}
			else
			{
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1564);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num95 = 0;
			}
			num3 |= (long)((ulong)(uint)num46 << (int)(uint)num4);
			num4 += num47;
			int num96;
			if (num4 <= 64)
			{
				num96 = -1;
			}
			else
			{
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1564);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num96 = 0;
			}
			while (num4 > 0)
			{
				if ((uint)(num2 + 1) > (uint)dst_buf_size)
				{
					return 0;
				}
				((sbyte*)pDst)[(uint)num2] = (sbyte)num3;
				num2++;
				num3 >>>= 8;
				num4 = checked(num4 - 8);
			}
			for (num48 = 0; (uint)num48 < 4u; num48++)
			{
				if ((uint)(num2 + 1) > (uint)dst_buf_size)
				{
					return 0;
				}
				((sbyte*)pDst)[(uint)num2] = (sbyte)(num6 >>> 24);
				num2++;
				num6 <<= 8;
			}
			return num2;
		}
	}
}
