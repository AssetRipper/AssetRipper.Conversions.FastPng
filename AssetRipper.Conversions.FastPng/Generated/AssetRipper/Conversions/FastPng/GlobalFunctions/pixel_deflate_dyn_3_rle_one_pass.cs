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
		unchecked
		{
			int num39 = 1 + w * 3;
			if ((ulong)(uint)dst_buf_size < 62uL)
			{
				return 0;
			}
			llvm_memcpy_p0_p0_i64.Invoke(pDst, g_dyn_huff_3.__pointer, 62L, isVolatile: false);
			num2 = 62;
			num3 = 30L;
			num4 = 7;
			ptr = pImg;
			num5 = 0;
			num6 = fpng_adler32.Invoke(pImg, (uint)(num39 * h), 1);
			for (num7 = 0; (uint)num7 < (uint)h; num7++)
			{
				num8 = num5 + num39;
				num9 = (byte)((sbyte*)ptr)[(uint)num5++];
				num10 = (ushort)((anon*)g_dyn_huff_3_codes.__pointer)[(uint)num9].field_1;
				num11 = (byte)((anon*)g_dyn_huff_3_codes.__pointer)[(uint)num9].field_0;
				int num40;
				if ((uint)num11 >= 1u && (uint)num11 <= 16u)
				{
					num40 = -1;
				}
				else
				{
					wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1187);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num40 = 0;
				}
				int num41;
				if ((ulong)(uint)num10 < (ulong)(1L << (int)(uint)num11))
				{
					num41 = -1;
				}
				else
				{
					wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1187);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num41 = 0;
				}
				num3 |= (long)((ulong)(uint)num10 << (int)(uint)num4);
				num4 += num11;
				int num42;
				if (num4 <= 64)
				{
					num42 = -1;
				}
				else
				{
					wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1187);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num42 = 0;
				}
				num13 = READ_RGB_PIXEL.Invoke((byte*)ptr + (uint)num5);
				num14 = (ushort)((anon*)g_dyn_huff_3_codes.__pointer)[(uint)(num13 & 0xFF)].field_1;
				num15 = (byte)((anon*)g_dyn_huff_3_codes.__pointer)[(uint)(num13 & 0xFF)].field_0;
				int num43;
				if ((uint)num15 >= 1u && (uint)num15 <= 16u)
				{
					num43 = -1;
				}
				else
				{
					wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1194);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num43 = 0;
				}
				int num44;
				if ((ulong)(uint)num14 < (ulong)(1L << (int)(uint)num15))
				{
					num44 = -1;
				}
				else
				{
					wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1194);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num44 = 0;
				}
				num3 |= (long)((ulong)(uint)num14 << (int)(uint)num4);
				num4 += num15;
				int num45;
				if (num4 <= 64)
				{
					num45 = -1;
				}
				else
				{
					wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1194);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num45 = 0;
				}
				num16 = (ushort)((anon*)g_dyn_huff_3_codes.__pointer)[(uint)((num13 >>> 8) & 0xFF)].field_1;
				num17 = (byte)((anon*)g_dyn_huff_3_codes.__pointer)[(uint)((num13 >>> 8) & 0xFF)].field_0;
				int num46;
				if ((uint)num17 >= 1u && (uint)num17 <= 16u)
				{
					num46 = -1;
				}
				else
				{
					wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1195);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num46 = 0;
				}
				int num47;
				if ((ulong)(uint)num16 < (ulong)(1L << (int)(uint)num17))
				{
					num47 = -1;
				}
				else
				{
					wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1195);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num47 = 0;
				}
				num3 |= (long)((ulong)(uint)num16 << (int)(uint)num4);
				num4 += num17;
				int num48;
				if (num4 <= 64)
				{
					num48 = -1;
				}
				else
				{
					wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1195);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num48 = 0;
				}
				num18 = (ushort)((anon*)g_dyn_huff_3_codes.__pointer)[(uint)(num13 >>> 16)].field_1;
				num19 = (byte)((anon*)g_dyn_huff_3_codes.__pointer)[(uint)(num13 >>> 16)].field_0;
				int num49;
				if ((uint)num19 >= 1u && (uint)num19 <= 16u)
				{
					num49 = -1;
				}
				else
				{
					wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1196);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num49 = 0;
				}
				int num50;
				if ((ulong)(uint)num18 < (ulong)(1L << (int)(uint)num19))
				{
					num50 = -1;
				}
				else
				{
					wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1196);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num50 = 0;
				}
				num3 |= (long)((ulong)(uint)num18 << (int)(uint)num4);
				num4 += num19;
				int num51;
				if (num4 <= 64)
				{
					num51 = -1;
				}
				else
				{
					wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1196);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num51 = 0;
				}
				num5 += 3;
				num12 = num13;
				if ((uint)(num2 + 8) > (uint)dst_buf_size)
				{
					return 0;
				}
				*(long*)((byte*)pDst + (uint)num2) = num3;
				num20 = num4 & -8;
				num2 += num20 >>> 3;
				int num52;
				if ((uint)num20 < 64u)
				{
					num52 = -1;
				}
				else
				{
					wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1203);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num52 = 0;
				}
				num3 >>>= (int)(uint)num20;
				num4 -= num20;
				while ((uint)num5 < (uint)num8)
				{
					num21 = READ_RGB_PIXEL.Invoke((byte*)ptr + (uint)num5);
					if (num21 == num12)
					{
						num22 = 3;
						for (num23 = minimum_ymfg3kb.Invoke(255, num8 - num5); (uint)num22 < (uint)num23 && READ_RGB_PIXEL.Invoke((byte*)ptr + (uint)num5 + (uint)num22) == num21; num22 += 3)
						{
						}
						num24 = num22 - 3;
						long num53 = (ushort)((short*)g_defl_len_sym.__pointer)[(uint)num24];
						num25 = (ushort)((anon*)g_dyn_huff_3_codes.__pointer)[num53].field_1;
						long num54 = (ushort)((short*)g_defl_len_sym.__pointer)[(uint)num24];
						num26 = (byte)((anon*)g_dyn_huff_3_codes.__pointer)[num54].field_0;
						int num55;
						if ((uint)num26 >= 1u && (uint)num26 <= 16u)
						{
							num55 = -1;
						}
						else
						{
							wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1223);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							num55 = 0;
						}
						int num56;
						if ((ulong)(uint)num25 < (ulong)(1L << (int)(uint)num26))
						{
							num56 = -1;
						}
						else
						{
							wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1223);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							num56 = 0;
						}
						num3 |= (long)((ulong)(uint)num25 << (int)(uint)num4);
						num4 += num26;
						int num57;
						if (num4 <= 64)
						{
							num57 = -1;
						}
						else
						{
							wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1223);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							num57 = 0;
						}
						int num58 = num24;
						long num59 = (byte)((sbyte*)g_defl_len_extra.__pointer)[(uint)num24];
						num27 = num58 & ((int*)g_bitmasks.__pointer)[num59];
						checked
						{
							num28 = unchecked((byte)((sbyte*)g_defl_len_extra.__pointer)[(uint)num24]) + 1;
						}
						int num60;
						if ((uint)num28 >= 0u && (uint)num28 <= 16u)
						{
							num60 = -1;
						}
						else
						{
							wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1224);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							num60 = 0;
						}
						int num61;
						if ((ulong)(uint)num27 < (ulong)(1L << (int)(uint)num28))
						{
							num61 = -1;
						}
						else
						{
							wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1224);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							num61 = 0;
						}
						num3 |= (long)((ulong)(uint)num27 << (int)(uint)num4);
						num4 += num28;
						int num62;
						if (num4 <= 64)
						{
							num62 = -1;
						}
						else
						{
							wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1224);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							num62 = 0;
						}
						num5 += num22;
					}
					else
					{
						num29 = (ushort)((anon*)g_dyn_huff_3_codes.__pointer)[(uint)(num21 & 0xFF)].field_1;
						num30 = (byte)((anon*)g_dyn_huff_3_codes.__pointer)[(uint)(num21 & 0xFF)].field_0;
						int num63;
						if ((uint)num30 >= 1u && (uint)num30 <= 16u)
						{
							num63 = -1;
						}
						else
						{
							wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1230);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							num63 = 0;
						}
						int num64;
						if ((ulong)(uint)num29 < (ulong)(1L << (int)(uint)num30))
						{
							num64 = -1;
						}
						else
						{
							wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1230);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							num64 = 0;
						}
						num3 |= (long)((ulong)(uint)num29 << (int)(uint)num4);
						num4 += num30;
						int num65;
						if (num4 <= 64)
						{
							num65 = -1;
						}
						else
						{
							wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1230);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							num65 = 0;
						}
						num31 = (ushort)((anon*)g_dyn_huff_3_codes.__pointer)[(uint)((num21 >>> 8) & 0xFF)].field_1;
						num32 = (byte)((anon*)g_dyn_huff_3_codes.__pointer)[(uint)((num21 >>> 8) & 0xFF)].field_0;
						int num66;
						if ((uint)num32 >= 1u && (uint)num32 <= 16u)
						{
							num66 = -1;
						}
						else
						{
							wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1231);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							num66 = 0;
						}
						int num67;
						if ((ulong)(uint)num31 < (ulong)(1L << (int)(uint)num32))
						{
							num67 = -1;
						}
						else
						{
							wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1231);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							num67 = 0;
						}
						num3 |= (long)((ulong)(uint)num31 << (int)(uint)num4);
						num4 += num32;
						int num68;
						if (num4 <= 64)
						{
							num68 = -1;
						}
						else
						{
							wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1231);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							num68 = 0;
						}
						num33 = (ushort)((anon*)g_dyn_huff_3_codes.__pointer)[(uint)(num21 >>> 16)].field_1;
						num34 = (byte)((anon*)g_dyn_huff_3_codes.__pointer)[(uint)(num21 >>> 16)].field_0;
						int num69;
						if ((uint)num34 >= 1u && (uint)num34 <= 16u)
						{
							num69 = -1;
						}
						else
						{
							wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1232);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							num69 = 0;
						}
						int num70;
						if ((ulong)(uint)num33 < (ulong)(1L << (int)(uint)num34))
						{
							num70 = -1;
						}
						else
						{
							wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1232);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							num70 = 0;
						}
						num3 |= (long)((ulong)(uint)num33 << (int)(uint)num4);
						num4 += num34;
						int num71;
						if (num4 <= 64)
						{
							num71 = -1;
						}
						else
						{
							wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1232);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							num71 = 0;
						}
						num12 = num21;
						num5 += 3;
					}
					if ((uint)(num2 + 8) > (uint)dst_buf_size)
					{
						return 0;
					}
					*(long*)((byte*)pDst + (uint)num2) = num3;
					num35 = num4 & -8;
					num2 += num35 >>> 3;
					int num72;
					if ((uint)num35 < 64u)
					{
						num72 = -1;
					}
					else
					{
						wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1239);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						num72 = 0;
					}
					num3 >>>= (int)(uint)num35;
					num4 -= num35;
				}
			}
			int num73;
			if (num5 == h * num39)
			{
				num73 = -1;
			}
			else
			{
				wassert.Invoke(String_bjvsuxc.__pointer, String_uxbkrtb.__pointer, 1245);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num73 = 0;
			}
			int num74;
			if (num4 <= 7)
			{
				num74 = -1;
			}
			else
			{
				wassert.Invoke(String_vpte4cc.__pointer, String_uxbkrtb.__pointer, 1247);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num74 = 0;
			}
			num36 = 2303;
			num37 = 12;
			int num75;
			if ((uint)num37 >= 1u && (uint)num37 <= 16u)
			{
				num75 = -1;
			}
			else
			{
				wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1249);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num75 = 0;
			}
			int num76;
			if ((ulong)(uint)num36 < (ulong)(1L << (int)(uint)num37))
			{
				num76 = -1;
			}
			else
			{
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1249);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num76 = 0;
			}
			num3 |= (long)((ulong)(uint)num36 << (int)(uint)num4);
			num4 += num37;
			int num77;
			if (num4 <= 64)
			{
				num77 = -1;
			}
			else
			{
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1249);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num77 = 0;
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
			for (num38 = 0; (uint)num38 < 4u; num38++)
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
