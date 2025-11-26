using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?pixel_deflate_dyn_3_rle_one_pass@fpng@@YAIPEBEIIPEAEI@Z")]
[DemangledName("unsigned int __cdecl fpng::pixel_deflate_dyn_3_rle_one_pass(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int)")]
internal static partial class pixel_deflate_dyn_3_rle_one_pass
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("unsigned char const *")] void* pImg, [NativeType("unsigned int")] int w, [NativeType("unsigned int")] int h, [NativeType("unsigned char *")] void* pDst, [NativeType("unsigned int")] int dst_buf_size)
	{
		unchecked
		{
			int num = 1 + w * 3;
			if ((ulong)(uint)dst_buf_size < 62uL)
			{
				return 0;
			}
			llvm_memcpy_p0_p0_i64.Invoke(pDst, g_dyn_huff_3.__pointer, 62L, isVolatile: false);
			int num2 = 62;
			long num3 = 30L;
			int num4 = 7;
			int num5 = 0;
			int num6 = fpng_adler32.Invoke(pImg, (uint)(num * h), 1);
			for (int i = 0; (uint)i < (uint)h; i++)
			{
				int num7 = num5 + num;
				int num8 = (byte)((sbyte*)pImg)[(uint)num5++];
				int num9 = (ushort)((anon_m9uqrv*)g_dyn_huff_3_codes.__pointer)[(uint)num8].m_code;
				int num10 = (byte)((anon_m9uqrv*)g_dyn_huff_3_codes.__pointer)[(uint)num8].m_code_size;
				if ((uint)num10 < 1u || (uint)num10 > 16u)
				{
					wassert.Invoke(String_e8urik.__pointer, String_ksmiy6.__pointer, 1187);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				if ((ulong)(uint)num9 >= (ulong)(1L << (int)(uint)num10))
				{
					wassert.Invoke(String_7a9csr.__pointer, String_ksmiy6.__pointer, 1187);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				num3 |= (long)((ulong)(uint)num9 << (int)(uint)num4);
				num4 += num10;
				if (num4 > 64)
				{
					wassert.Invoke(String_y2p2wj.__pointer, String_ksmiy6.__pointer, 1187);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				int num11 = READ_RGB_PIXEL.Invoke((byte*)pImg + (uint)num5);
				int num12 = (ushort)((anon_m9uqrv*)g_dyn_huff_3_codes.__pointer)[(uint)(num11 & 0xFF)].m_code;
				int num13 = (byte)((anon_m9uqrv*)g_dyn_huff_3_codes.__pointer)[(uint)(num11 & 0xFF)].m_code_size;
				if ((uint)num13 < 1u || (uint)num13 > 16u)
				{
					wassert.Invoke(String_e8urik.__pointer, String_ksmiy6.__pointer, 1194);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				if ((ulong)(uint)num12 >= (ulong)(1L << (int)(uint)num13))
				{
					wassert.Invoke(String_7a9csr.__pointer, String_ksmiy6.__pointer, 1194);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				num3 |= (long)((ulong)(uint)num12 << (int)(uint)num4);
				num4 += num13;
				if (num4 > 64)
				{
					wassert.Invoke(String_y2p2wj.__pointer, String_ksmiy6.__pointer, 1194);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				int num14 = (ushort)((anon_m9uqrv*)g_dyn_huff_3_codes.__pointer)[(uint)((num11 >>> 8) & 0xFF)].m_code;
				int num15 = (byte)((anon_m9uqrv*)g_dyn_huff_3_codes.__pointer)[(uint)((num11 >>> 8) & 0xFF)].m_code_size;
				if ((uint)num15 < 1u || (uint)num15 > 16u)
				{
					wassert.Invoke(String_e8urik.__pointer, String_ksmiy6.__pointer, 1195);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				if ((ulong)(uint)num14 >= (ulong)(1L << (int)(uint)num15))
				{
					wassert.Invoke(String_7a9csr.__pointer, String_ksmiy6.__pointer, 1195);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				num3 |= (long)((ulong)(uint)num14 << (int)(uint)num4);
				num4 += num15;
				if (num4 > 64)
				{
					wassert.Invoke(String_y2p2wj.__pointer, String_ksmiy6.__pointer, 1195);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				int num16 = (ushort)((anon_m9uqrv*)g_dyn_huff_3_codes.__pointer)[(uint)(num11 >>> 16)].m_code;
				int num17 = (byte)((anon_m9uqrv*)g_dyn_huff_3_codes.__pointer)[(uint)(num11 >>> 16)].m_code_size;
				if ((uint)num17 < 1u || (uint)num17 > 16u)
				{
					wassert.Invoke(String_e8urik.__pointer, String_ksmiy6.__pointer, 1196);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				if ((ulong)(uint)num16 >= (ulong)(1L << (int)(uint)num17))
				{
					wassert.Invoke(String_7a9csr.__pointer, String_ksmiy6.__pointer, 1196);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				num3 |= (long)((ulong)(uint)num16 << (int)(uint)num4);
				num4 += num17;
				if (num4 > 64)
				{
					wassert.Invoke(String_y2p2wj.__pointer, String_ksmiy6.__pointer, 1196);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				num5 += 3;
				int num18 = num11;
				if ((uint)(num2 + 8) > (uint)dst_buf_size)
				{
					return 0;
				}
				*(long*)((byte*)pDst + (uint)num2) = num3;
				int num19 = num4 & -8;
				num2 += num19 >>> 3;
				if ((uint)num19 >= 64u)
				{
					wassert.Invoke(String_h6hieb.__pointer, String_ksmiy6.__pointer, 1203);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
				}
				num3 >>>= (int)(uint)num19;
				num4 -= num19;
				while ((uint)num5 < (uint)num7)
				{
					int num20 = READ_RGB_PIXEL.Invoke((byte*)pImg + (uint)num5);
					if (num20 == num18)
					{
						int j = 3;
						for (int num21 = minimum_89rwph.Invoke(255, num7 - num5); (uint)j < (uint)num21 && READ_RGB_PIXEL.Invoke((byte*)pImg + (uint)num5 + (uint)j) == num20; j += 3)
						{
						}
						int num22 = j - 3;
						long num23 = (ushort)((short*)g_defl_len_sym.__pointer)[(uint)num22];
						int num24 = (ushort)((anon_m9uqrv*)g_dyn_huff_3_codes.__pointer)[num23].m_code;
						long num25 = (ushort)((short*)g_defl_len_sym.__pointer)[(uint)num22];
						int num26 = (byte)((anon_m9uqrv*)g_dyn_huff_3_codes.__pointer)[num25].m_code_size;
						if ((uint)num26 < 1u || (uint)num26 > 16u)
						{
							wassert.Invoke(String_e8urik.__pointer, String_ksmiy6.__pointer, 1223);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
						}
						if ((ulong)(uint)num24 >= (ulong)(1L << (int)(uint)num26))
						{
							wassert.Invoke(String_7a9csr.__pointer, String_ksmiy6.__pointer, 1223);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
						}
						num3 |= (long)((ulong)(uint)num24 << (int)(uint)num4);
						num4 += num26;
						if (num4 > 64)
						{
							wassert.Invoke(String_y2p2wj.__pointer, String_ksmiy6.__pointer, 1223);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
						}
						long num27 = (byte)((sbyte*)g_defl_len_extra.__pointer)[(uint)num22];
						int num28 = num22 & ((int*)g_bitmasks.__pointer)[num27];
						int num29;
						checked
						{
							num29 = unchecked((byte)((sbyte*)g_defl_len_extra.__pointer)[(uint)num22]) + 1;
						}
						if ((uint)num29 < 0u || (uint)num29 > 16u)
						{
							wassert.Invoke(String_zvmzrv.__pointer, String_ksmiy6.__pointer, 1224);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
						}
						if ((ulong)(uint)num28 >= (ulong)(1L << (int)(uint)num29))
						{
							wassert.Invoke(String_7a9csr.__pointer, String_ksmiy6.__pointer, 1224);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
						}
						num3 |= (long)((ulong)(uint)num28 << (int)(uint)num4);
						num4 += num29;
						if (num4 > 64)
						{
							wassert.Invoke(String_y2p2wj.__pointer, String_ksmiy6.__pointer, 1224);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
						}
						num5 += j;
					}
					else
					{
						int num30 = (ushort)((anon_m9uqrv*)g_dyn_huff_3_codes.__pointer)[(uint)(num20 & 0xFF)].m_code;
						int num31 = (byte)((anon_m9uqrv*)g_dyn_huff_3_codes.__pointer)[(uint)(num20 & 0xFF)].m_code_size;
						if ((uint)num31 < 1u || (uint)num31 > 16u)
						{
							wassert.Invoke(String_e8urik.__pointer, String_ksmiy6.__pointer, 1230);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
						}
						if ((ulong)(uint)num30 >= (ulong)(1L << (int)(uint)num31))
						{
							wassert.Invoke(String_7a9csr.__pointer, String_ksmiy6.__pointer, 1230);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
						}
						num3 |= (long)((ulong)(uint)num30 << (int)(uint)num4);
						num4 += num31;
						if (num4 > 64)
						{
							wassert.Invoke(String_y2p2wj.__pointer, String_ksmiy6.__pointer, 1230);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
						}
						int num32 = (ushort)((anon_m9uqrv*)g_dyn_huff_3_codes.__pointer)[(uint)((num20 >>> 8) & 0xFF)].m_code;
						int num33 = (byte)((anon_m9uqrv*)g_dyn_huff_3_codes.__pointer)[(uint)((num20 >>> 8) & 0xFF)].m_code_size;
						if ((uint)num33 < 1u || (uint)num33 > 16u)
						{
							wassert.Invoke(String_e8urik.__pointer, String_ksmiy6.__pointer, 1231);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
						}
						if ((ulong)(uint)num32 >= (ulong)(1L << (int)(uint)num33))
						{
							wassert.Invoke(String_7a9csr.__pointer, String_ksmiy6.__pointer, 1231);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
						}
						num3 |= (long)((ulong)(uint)num32 << (int)(uint)num4);
						num4 += num33;
						if (num4 > 64)
						{
							wassert.Invoke(String_y2p2wj.__pointer, String_ksmiy6.__pointer, 1231);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
						}
						int num34 = (ushort)((anon_m9uqrv*)g_dyn_huff_3_codes.__pointer)[(uint)(num20 >>> 16)].m_code;
						int num35 = (byte)((anon_m9uqrv*)g_dyn_huff_3_codes.__pointer)[(uint)(num20 >>> 16)].m_code_size;
						if ((uint)num35 < 1u || (uint)num35 > 16u)
						{
							wassert.Invoke(String_e8urik.__pointer, String_ksmiy6.__pointer, 1232);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
						}
						if ((ulong)(uint)num34 >= (ulong)(1L << (int)(uint)num35))
						{
							wassert.Invoke(String_7a9csr.__pointer, String_ksmiy6.__pointer, 1232);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
						}
						num3 |= (long)((ulong)(uint)num34 << (int)(uint)num4);
						num4 += num35;
						if (num4 > 64)
						{
							wassert.Invoke(String_y2p2wj.__pointer, String_ksmiy6.__pointer, 1232);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
						}
						num18 = num20;
						num5 += 3;
					}
					if ((uint)(num2 + 8) > (uint)dst_buf_size)
					{
						return 0;
					}
					*(long*)((byte*)pDst + (uint)num2) = num3;
					int num36 = num4 & -8;
					num2 += num36 >>> 3;
					if ((uint)num36 >= 64u)
					{
						wassert.Invoke(String_h6hieb.__pointer, String_ksmiy6.__pointer, 1239);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
					}
					num3 >>>= (int)(uint)num36;
					num4 -= num36;
				}
			}
			if (num5 != h * num)
			{
				wassert.Invoke(String_pjig3w.__pointer, String_ksmiy6.__pointer, 1245);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			if (num4 > 7)
			{
				wassert.Invoke(String_prwb6d.__pointer, String_ksmiy6.__pointer, 1247);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			int num37 = 2303;
			int num38 = 12;
			if ((uint)num38 < 1u || (uint)num38 > 16u)
			{
				wassert.Invoke(String_e8urik.__pointer, String_ksmiy6.__pointer, 1249);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			if ((ulong)(uint)num37 >= (ulong)(1L << (int)(uint)num38))
			{
				wassert.Invoke(String_7a9csr.__pointer, String_ksmiy6.__pointer, 1249);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
			}
			num3 |= (long)((ulong)(uint)num37 << (int)(uint)num4);
			num4 += num38;
			if (num4 > 64)
			{
				wassert.Invoke(String_y2p2wj.__pointer, String_ksmiy6.__pointer, 1249);
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
