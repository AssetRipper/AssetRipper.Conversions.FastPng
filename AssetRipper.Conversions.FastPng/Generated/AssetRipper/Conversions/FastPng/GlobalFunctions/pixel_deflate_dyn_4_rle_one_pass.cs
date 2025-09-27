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
		unchecked
		{
			int num = 1 + w * 4;
			if ((ulong)(uint)dst_buf_size < 61uL)
			{
				return 0;
			}
			llvm_memcpy_p0_p0_i64.Invoke(pDst, g_dyn_huff_4.__pointer, 61L, isVolatile: false);
			int num2 = 61;
			long num3 = 1L;
			int num4 = 2;
			int num5 = 0;
			int num6 = fpng_adler32.Invoke(pImg, (uint)(num * h), 1);
			for (int i = 0; (uint)i < (uint)h; i++)
			{
				int num7 = num5 + num;
				int num8 = (byte)((sbyte*)pImg)[(uint)num5++];
				int num9 = (ushort)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)num8].m_code;
				int num10 = (byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)num8].m_code_size;
				if ((uint)num10 < 1u || (uint)num10 > 16u)
				{
					wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1473);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				if ((ulong)(uint)num9 >= (ulong)(1L << (int)(uint)num10))
				{
					wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1473);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				num3 |= (long)((ulong)(uint)num9 << (int)(uint)num4);
				num4 += num10;
				if (num4 > 64)
				{
					wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1473);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				if ((uint)(num2 + 8) > (uint)dst_buf_size)
				{
					return 0;
				}
				*(long*)((byte*)pDst + (uint)num2) = num3;
				int num11 = num4 & -8;
				num2 += num11 >>> 3;
				if ((uint)num11 >= 64u)
				{
					wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1475);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				num3 >>>= (int)(uint)num11;
				num4 -= num11;
				int num12 = *(int*)((byte*)pImg + (uint)num5);
				int num13 = (ushort)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)(num12 & 0xFF)].m_code;
				int num14 = (byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)(num12 & 0xFF)].m_code_size;
				if ((uint)num14 < 1u || (uint)num14 > 16u)
				{
					wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1481);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				if ((ulong)(uint)num13 >= (ulong)(1L << (int)(uint)num14))
				{
					wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1481);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				num3 |= (long)((ulong)(uint)num13 << (int)(uint)num4);
				num4 += num14;
				if (num4 > 64)
				{
					wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1481);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				int num15 = (ushort)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)((num12 >>> 8) & 0xFF)].m_code;
				int num16 = (byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)((num12 >>> 8) & 0xFF)].m_code_size;
				if ((uint)num16 < 1u || (uint)num16 > 16u)
				{
					wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1482);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				if ((ulong)(uint)num15 >= (ulong)(1L << (int)(uint)num16))
				{
					wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1482);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				num3 |= (long)((ulong)(uint)num15 << (int)(uint)num4);
				num4 += num16;
				if (num4 > 64)
				{
					wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1482);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				int num17 = (ushort)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)((num12 >>> 16) & 0xFF)].m_code;
				int num18 = (byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)((num12 >>> 16) & 0xFF)].m_code_size;
				if ((uint)num18 < 1u || (uint)num18 > 16u)
				{
					wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1483);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				if ((ulong)(uint)num17 >= (ulong)(1L << (int)(uint)num18))
				{
					wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1483);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				num3 |= (long)((ulong)(uint)num17 << (int)(uint)num4);
				num4 += num18;
				if (num4 > 64)
				{
					wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1483);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				if (num4 >= 49)
				{
					if ((uint)(num2 + 8) > (uint)dst_buf_size)
					{
						return 0;
					}
					*(long*)((byte*)pDst + (uint)num2) = num3;
					int num19 = num4 & -8;
					num2 += num19 >>> 3;
					if ((uint)num19 >= 64u)
					{
						wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1487);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
					}
					num3 >>>= (int)(uint)num19;
					num4 -= num19;
				}
				int num20 = (ushort)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)(num12 >>> 24)].m_code;
				int num21 = (byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)(num12 >>> 24)].m_code_size;
				if ((uint)num21 < 1u || (uint)num21 > 16u)
				{
					wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1490);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				if ((ulong)(uint)num20 >= (ulong)(1L << (int)(uint)num21))
				{
					wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1490);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				num3 |= (long)((ulong)(uint)num20 << (int)(uint)num4);
				num4 += num21;
				if (num4 > 64)
				{
					wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1490);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				num5 += 4;
				int num22 = num12;
				if ((uint)(num2 + 8) > (uint)dst_buf_size)
				{
					return 0;
				}
				*(long*)((byte*)pDst + (uint)num2) = num3;
				int num23 = num4 & -8;
				num2 += num23 >>> 3;
				if ((uint)num23 >= 64u)
				{
					wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1497);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				num3 >>>= (int)(uint)num23;
				num4 -= num23;
				while ((uint)num5 < (uint)num7)
				{
					int num24 = *(int*)((byte*)pImg + (uint)num5);
					if (num24 == num22)
					{
						int j = 4;
						for (int num25 = minimum_ymfg3kb.Invoke(252, num7 - num5); (uint)j < (uint)num25 && *(int*)((byte*)pImg + (uint)num5 + (uint)j) == num24; j += 4)
						{
						}
						int num26 = j - 3;
						long num27 = (ushort)((short*)g_defl_len_sym.__pointer)[(uint)num26];
						int num28 = (byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[num27].m_code_size;
						int num29 = (byte)((sbyte*)g_defl_len_extra.__pointer)[(uint)num26];
						if (j != 4 || (uint)(num28 + num29 + 1) <= (uint)checked(unchecked((byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)(num24 & 0xFF)].m_code_size) + unchecked((byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)((num24 >>> 8) & 0xFF)].m_code_size) + unchecked((byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)((num24 >>> 16) & 0xFF)].m_code_size) + unchecked((byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)(num24 >>> 24)].m_code_size)))
						{
							long num30 = (ushort)((short*)g_defl_len_sym.__pointer)[(uint)num26];
							int num31 = (ushort)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[num30].m_code;
							int num32 = num28;
							if ((uint)num32 < 1u || (uint)num32 > 16u)
							{
								wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1530);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
							}
							if ((ulong)(uint)num31 >= (ulong)(1L << (int)(uint)num32))
							{
								wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1530);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
							}
							num3 |= (long)((ulong)(uint)num31 << (int)(uint)num4);
							num4 += num32;
							if (num4 > 64)
							{
								wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1530);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
							}
							long num33 = (byte)((sbyte*)g_defl_len_extra.__pointer)[(uint)num26];
							int num34 = num26 & ((int*)g_bitmasks.__pointer)[num33];
							int num35 = num29 + 1;
							if ((uint)num35 < 0u || (uint)num35 > 16u)
							{
								wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1531);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
							}
							if ((ulong)(uint)num34 >= (ulong)(1L << (int)(uint)num35))
							{
								wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1531);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
							}
							num3 |= (long)((ulong)(uint)num34 << (int)(uint)num4);
							num4 += num35;
							if (num4 > 64)
							{
								wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1531);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
							}
							num5 += j;
							goto IL_102c;
						}
					}
					int num36 = (ushort)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)(num24 & 0xFF)].m_code;
					int num37 = (byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)(num24 & 0xFF)].m_code_size;
					if ((uint)num37 < 1u || (uint)num37 > 16u)
					{
						wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1538);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
					}
					if ((ulong)(uint)num36 >= (ulong)(1L << (int)(uint)num37))
					{
						wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1538);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
					}
					num3 |= (long)((ulong)(uint)num36 << (int)(uint)num4);
					num4 += num37;
					if (num4 > 64)
					{
						wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1538);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
					}
					int num38 = (ushort)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)((num24 >>> 8) & 0xFF)].m_code;
					int num39 = (byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)((num24 >>> 8) & 0xFF)].m_code_size;
					if ((uint)num39 < 1u || (uint)num39 > 16u)
					{
						wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1539);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
					}
					if ((ulong)(uint)num38 >= (ulong)(1L << (int)(uint)num39))
					{
						wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1539);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
					}
					num3 |= (long)((ulong)(uint)num38 << (int)(uint)num4);
					num4 += num39;
					if (num4 > 64)
					{
						wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1539);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
					}
					int num40 = (ushort)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)((num24 >>> 16) & 0xFF)].m_code;
					int num41 = (byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)((num24 >>> 16) & 0xFF)].m_code_size;
					if ((uint)num41 < 1u || (uint)num41 > 16u)
					{
						wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1540);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
					}
					if ((ulong)(uint)num40 >= (ulong)(1L << (int)(uint)num41))
					{
						wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1540);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
					}
					num3 |= (long)((ulong)(uint)num40 << (int)(uint)num4);
					num4 += num41;
					if (num4 > 64)
					{
						wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1540);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
					}
					if (num4 >= 49)
					{
						if ((uint)(num2 + 8) > (uint)dst_buf_size)
						{
							return 0;
						}
						*(long*)((byte*)pDst + (uint)num2) = num3;
						int num42 = num4 & -8;
						num2 += num42 >>> 3;
						if ((uint)num42 >= 64u)
						{
							wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1544);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
						}
						num3 >>>= (int)(uint)num42;
						num4 -= num42;
					}
					int num43 = (ushort)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)(num24 >>> 24)].m_code;
					int num44 = (byte)((anon_atvx4gd*)g_dyn_huff_4_codes.__pointer)[(uint)(num24 >>> 24)].m_code_size;
					if ((uint)num44 < 1u || (uint)num44 > 16u)
					{
						wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1547);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
					}
					if ((ulong)(uint)num43 >= (ulong)(1L << (int)(uint)num44))
					{
						wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1547);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
					}
					num3 |= (long)((ulong)(uint)num43 << (int)(uint)num4);
					num4 += num44;
					if (num4 > 64)
					{
						wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1547);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
					}
					num5 += 4;
					num22 = num24;
					goto IL_102c;
					IL_102c:
					if ((uint)(num2 + 8) > (uint)dst_buf_size)
					{
						return 0;
					}
					*(long*)((byte*)pDst + (uint)num2) = num3;
					int num45 = num4 & -8;
					num2 += num45 >>> 3;
					if ((uint)num45 >= 64u)
					{
						wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1554);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
					}
					num3 >>>= (int)(uint)num45;
					num4 -= num45;
				}
			}
			if (num5 != h * num)
			{
				wassert.Invoke(String_bjvsuxc.__pointer, String_uxbkrtb.__pointer, 1560);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			if (num4 > 7)
			{
				wassert.Invoke(String_vpte4cc.__pointer, String_uxbkrtb.__pointer, 1562);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			int num46 = 2047;
			int num47 = 12;
			if ((uint)num47 < 1u || (uint)num47 > 16u)
			{
				wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1564);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			if ((ulong)(uint)num46 >= (ulong)(1L << (int)(uint)num47))
			{
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1564);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			num3 |= (long)((ulong)(uint)num46 << (int)(uint)num4);
			num4 += num47;
			if (num4 > 64)
			{
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1564);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
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
			for (int k = 0; (uint)k < 4u; k++)
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
