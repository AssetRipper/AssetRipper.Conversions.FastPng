using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?defl_start_dynamic_block@fpng@@YA_NPEAUdefl_huff@1@PEAEAEAIIAEA_KAEAH@Z")]
[DemangledName("bool __cdecl fpng::defl_start_dynamic_block(struct fpng::defl_huff *, unsigned char *, unsigned int &, unsigned int, unsigned __int64 &, int &)")]
internal static partial class defl_start_dynamic_block
{
	private partial struct LocalVariables
	{
		public InlineArray320_SByte field_0;

		public InlineArray320_SByte field_1;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("struct fpng::defl_huff *")] void* d, [NativeType("unsigned char *")] void* pDst, [NativeType("unsigned int &")] void* dst_ofs, [NativeType("unsigned int")] int dst_buf_size, [NativeType("unsigned __int64 &")] void* bit_buf, [NativeType("int &")] void* bit_buf_size)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(InlineArray320_SByte);
		localsPointer->field_1 = default(InlineArray320_SByte);
		sbyte b = -1;
		unchecked((short*)(&((fpng_defl_huff*)d)->m_huff_count))[256] = 1;
		defl_optimize_huffman_table.Invoke(d, 0, 288, 12, 0);
		defl_optimize_huffman_table.Invoke(d, 1, 32, 12, 0);
		int i;
		for (i = 286; i > 257 && unchecked((sbyte*)(&((fpng_defl_huff*)d)->m_huff_code_sizes))[i - 1] == 0; i += -1)
		{
		}
		int j;
		for (j = 30; j > 1 && (unchecked((byte*)(&((fpng_defl_huff*)d)->m_huff_code_sizes)) + sizeof(InlineArray288_SByte))[j - 1] == 0; j += -1)
		{
		}
		unchecked
		{
			llvm_memcpy_p0_p0_i64.Invoke(&localsPointer->field_0, &((fpng_defl_huff*)d)->m_huff_code_sizes, i, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke((byte*)(&localsPointer->field_0) + i, (byte*)(&((fpng_defl_huff*)d)->m_huff_code_sizes) + sizeof(InlineArray288_SByte), j, isVolatile: false);
			int num = checked(i + j);
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			llvm_memset_p0_i64.Invoke((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16), 0, 38L, isVolatile: false);
			for (int k = 0; (uint)k < (uint)num; k++)
			{
				sbyte b2 = ((sbyte*)(&localsPointer->field_0))[(uint)k];
				if (b2 == 0)
				{
					if (num4 != 0)
					{
						if ((uint)num4 < 3u)
						{
							short num5 = (short)((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[(byte)b] + num4);
							((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[(byte)b] = num5;
							while (true)
							{
								int num6 = num4;
								num4 = num6 + -1;
								if (num6 == 0)
								{
									break;
								}
								sbyte b3 = b;
								int num7 = num2++;
								((sbyte*)(&localsPointer->field_1))[(uint)num7] = b3;
							}
						}
						else
						{
							short num8 = (short)checked(unchecked((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[16]) + 1);
							((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[16] = num8;
							int num9 = num2++;
							((sbyte*)(&localsPointer->field_1))[(uint)num9] = 16;
							sbyte b4 = (sbyte)(num4 - 3);
							int num10 = num2++;
							((sbyte*)(&localsPointer->field_1))[(uint)num10] = b4;
						}
						num4 = 0;
					}
					int num11 = num3 + 1;
					num3 = num11;
					if (num11 == 138 && num3 != 0)
					{
						switch (num3)
						{
						case 0:
						case 1:
						case 2:
						{
							short num18 = (short)((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16))) + num3);
							*(short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)) = num18;
							while (true)
							{
								int num19 = num3;
								num3 = num19 + -1;
								if (num19 == 0)
								{
									break;
								}
								int num20 = num2++;
								((sbyte*)(&localsPointer->field_1))[(uint)num20] = 0;
							}
							break;
						}
						case 3:
						case 4:
						case 5:
						case 6:
						case 7:
						case 8:
						case 9:
						case 10:
						{
							short num15 = (short)checked(unchecked((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[17]) + 1);
							((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[17] = num15;
							int num16 = num2++;
							((sbyte*)(&localsPointer->field_1))[(uint)num16] = 17;
							sbyte b6 = (sbyte)(num3 - 3);
							int num17 = num2++;
							((sbyte*)(&localsPointer->field_1))[(uint)num17] = b6;
							break;
						}
						default:
						{
							short num12 = (short)checked(unchecked((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[18]) + 1);
							((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[18] = num12;
							int num13 = num2++;
							((sbyte*)(&localsPointer->field_1))[(uint)num13] = 18;
							sbyte b5 = (sbyte)(num3 - 11);
							int num14 = num2++;
							((sbyte*)(&localsPointer->field_1))[(uint)num14] = b5;
							break;
						}
						}
						num3 = 0;
					}
				}
				else
				{
					if (num3 != 0)
					{
						switch (num3)
						{
						case 0:
						case 1:
						case 2:
						{
							short num27 = (short)((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16))) + num3);
							*(short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)) = num27;
							while (true)
							{
								int num28 = num3;
								num3 = num28 + -1;
								if (num28 == 0)
								{
									break;
								}
								int num29 = num2++;
								((sbyte*)(&localsPointer->field_1))[(uint)num29] = 0;
							}
							break;
						}
						case 3:
						case 4:
						case 5:
						case 6:
						case 7:
						case 8:
						case 9:
						case 10:
						{
							short num24 = (short)checked(unchecked((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[17]) + 1);
							((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[17] = num24;
							int num25 = num2++;
							((sbyte*)(&localsPointer->field_1))[(uint)num25] = 17;
							sbyte b8 = (sbyte)(num3 - 3);
							int num26 = num2++;
							((sbyte*)(&localsPointer->field_1))[(uint)num26] = b8;
							break;
						}
						default:
						{
							short num21 = (short)checked(unchecked((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[18]) + 1);
							((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[18] = num21;
							int num22 = num2++;
							((sbyte*)(&localsPointer->field_1))[(uint)num22] = 18;
							sbyte b7 = (sbyte)(num3 - 11);
							int num23 = num2++;
							((sbyte*)(&localsPointer->field_1))[(uint)num23] = b7;
							break;
						}
						}
						num3 = 0;
					}
					if ((byte)b2 != (byte)b)
					{
						if (num4 != 0)
						{
							if ((uint)num4 < 3u)
							{
								short num30 = (short)((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[(byte)b] + num4);
								((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[(byte)b] = num30;
								while (true)
								{
									int num31 = num4;
									num4 = num31 + -1;
									if (num31 == 0)
									{
										break;
									}
									sbyte b9 = b;
									int num32 = num2++;
									((sbyte*)(&localsPointer->field_1))[(uint)num32] = b9;
								}
							}
							else
							{
								short num33 = (short)checked(unchecked((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[16]) + 1);
								((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[16] = num33;
								int num34 = num2++;
								((sbyte*)(&localsPointer->field_1))[(uint)num34] = 16;
								sbyte b10 = (sbyte)(num4 - 3);
								int num35 = num2++;
								((sbyte*)(&localsPointer->field_1))[(uint)num35] = b10;
							}
							num4 = 0;
						}
						short num36 = (short)checked(unchecked((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[(byte)b2]) + 1);
						((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[(byte)b2] = num36;
						sbyte b11 = b2;
						int num37 = num2++;
						((sbyte*)(&localsPointer->field_1))[(uint)num37] = b11;
					}
					else
					{
						int num38 = num4 + 1;
						num4 = num38;
						if (num38 == 6 && num4 != 0)
						{
							if ((uint)num4 < 3u)
							{
								short num39 = (short)((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[(byte)b] + num4);
								((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[(byte)b] = num39;
								while (true)
								{
									int num40 = num4;
									num4 = num40 + -1;
									if (num40 == 0)
									{
										break;
									}
									sbyte b12 = b;
									int num41 = num2++;
									((sbyte*)(&localsPointer->field_1))[(uint)num41] = b12;
								}
							}
							else
							{
								short num42 = (short)checked(unchecked((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[16]) + 1);
								((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[16] = num42;
								int num43 = num2++;
								((sbyte*)(&localsPointer->field_1))[(uint)num43] = 16;
								sbyte b13 = (sbyte)(num4 - 3);
								int num44 = num2++;
								((sbyte*)(&localsPointer->field_1))[(uint)num44] = b13;
							}
							num4 = 0;
						}
					}
				}
				b = b2;
			}
			if (num4 != 0)
			{
				switch (num4)
				{
				case 1:
				case 2:
				{
					short num48 = (short)((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[(byte)b] + num4);
					((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[(byte)b] = num48;
					while (true)
					{
						int num49 = num4;
						num4 = num49 + -1;
						if (num49 == 0)
						{
							break;
						}
						sbyte b15 = b;
						int num50 = num2++;
						((sbyte*)(&localsPointer->field_1))[(uint)num50] = b15;
					}
					break;
				}
				default:
				{
					short num45 = (short)checked(unchecked((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[16]) + 1);
					((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[16] = num45;
					int num46 = num2++;
					((sbyte*)(&localsPointer->field_1))[(uint)num46] = 16;
					sbyte b14 = (sbyte)(num4 - 3);
					int num47 = num2++;
					((sbyte*)(&localsPointer->field_1))[(uint)num47] = b14;
					break;
				}
				case 0:
					break;
				}
			}
			else
			{
				switch (num3)
				{
				case 1:
				case 2:
				{
					short num57 = (short)((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16))) + num3);
					*(short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)) = num57;
					while (true)
					{
						int num58 = num3;
						num3 = num58 + -1;
						if (num58 == 0)
						{
							break;
						}
						int num59 = num2++;
						((sbyte*)(&localsPointer->field_1))[(uint)num59] = 0;
					}
					break;
				}
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
				{
					short num54 = (short)checked(unchecked((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[17]) + 1);
					((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[17] = num54;
					int num55 = num2++;
					((sbyte*)(&localsPointer->field_1))[(uint)num55] = 17;
					sbyte b17 = (sbyte)(num3 - 3);
					int num56 = num2++;
					((sbyte*)(&localsPointer->field_1))[(uint)num56] = b17;
					break;
				}
				default:
				{
					short num51 = (short)checked(unchecked((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[18]) + 1);
					((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)2 * sizeof(InlineArray288_Int16)))[18] = num51;
					int num52 = num2++;
					((sbyte*)(&localsPointer->field_1))[(uint)num52] = 18;
					sbyte b16 = (sbyte)(num3 - 11);
					int num53 = num2++;
					((sbyte*)(&localsPointer->field_1))[(uint)num53] = b16;
					break;
				}
				case 0:
					break;
				}
			}
			defl_optimize_huffman_table.Invoke(d, 2, 19, 7, 0);
			int num60 = 2;
			int num61 = 2;
			if ((uint)num61 < 1u || (uint)num61 > 16u)
			{
				wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 799);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
			}
			if ((ulong)(uint)num60 >= (ulong)(1L << (int)(uint)num61))
			{
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 799);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
			}
			*(long*)bit_buf |= (long)((ulong)(uint)num60 << (int)(uint)(*(int*)bit_buf_size));
			*(int*)bit_buf_size += num61;
			if (*(int*)bit_buf_size > 64)
			{
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 799);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
			}
			bool flag;
			while (true)
			{
				if (*(int*)bit_buf_size >= 8)
				{
					if ((uint)(*(int*)dst_ofs + 1) > (uint)dst_buf_size)
					{
						flag = false;
						break;
					}
					sbyte b18 = (sbyte)(*(long*)bit_buf);
					((sbyte*)pDst)[(uint)(*(int*)dst_ofs)] = b18;
					(*(int*)dst_ofs)++;
					*(long*)bit_buf >>>= 8;
					checked
					{
						*unchecked((int*)bit_buf_size) -= 8;
						continue;
					}
				}
				int num62 = checked(i - 257);
				int num63 = 5;
				if ((uint)num63 < 1u || (uint)num63 > 16u)
				{
					wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 801);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
				}
				if ((ulong)(uint)num62 >= (ulong)(1L << (int)(uint)num63))
				{
					wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 801);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
				}
				*(long*)bit_buf |= (long)((ulong)(uint)num62 << (int)(uint)(*(int*)bit_buf_size));
				*(int*)bit_buf_size += num63;
				if (*(int*)bit_buf_size > 64)
				{
					wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 801);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
				}
				while (true)
				{
					if (*(int*)bit_buf_size >= 8)
					{
						if ((uint)(*(int*)dst_ofs + 1) > (uint)dst_buf_size)
						{
							flag = false;
							break;
						}
						sbyte b19 = (sbyte)(*(long*)bit_buf);
						((sbyte*)pDst)[(uint)(*(int*)dst_ofs)] = b19;
						(*(int*)dst_ofs)++;
						*(long*)bit_buf >>>= 8;
						checked
						{
							*unchecked((int*)bit_buf_size) -= 8;
							continue;
						}
					}
					int num64 = checked(j - 1);
					int num65 = 5;
					if ((uint)num65 < 1u || (uint)num65 > 16u)
					{
						wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 802);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
					}
					if ((ulong)(uint)num64 >= (ulong)(1L << (int)(uint)num65))
					{
						wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 802);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
					}
					*(long*)bit_buf |= (long)((ulong)(uint)num64 << (int)(uint)(*(int*)bit_buf_size));
					*(int*)bit_buf_size += num65;
					if (*(int*)bit_buf_size > 64)
					{
						wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 802);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
					}
					while (true)
					{
						if (*(int*)bit_buf_size >= 8)
						{
							if ((uint)(*(int*)dst_ofs + 1) > (uint)dst_buf_size)
							{
								flag = false;
								break;
							}
							sbyte b20 = (sbyte)(*(long*)bit_buf);
							((sbyte*)pDst)[(uint)(*(int*)dst_ofs)] = b20;
							(*(int*)dst_ofs)++;
							*(long*)bit_buf >>>= 8;
							checked
							{
								*unchecked((int*)bit_buf_size) -= 8;
								continue;
							}
						}
						int l;
						for (l = 18; l >= 0 && ((byte*)(&((fpng_defl_huff*)d)->m_huff_code_sizes) + (nint)2 * sizeof(InlineArray288_SByte))[(byte)((sbyte*)g_defl_packed_code_size_syms_swizzle.__pointer)[l]] == 0; l = checked(l + -1))
						{
						}
						int num66;
						int num67;
						checked
						{
							l = maximum_sfjssib.Invoke(4, l + 1);
							num66 = l - 4;
							num67 = 4;
						}
						if ((uint)num67 < 1u || (uint)num67 > 16u)
						{
							wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 805);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
						}
						if ((ulong)(uint)num66 >= (ulong)(1L << (int)(uint)num67))
						{
							wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 805);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
						}
						*(long*)bit_buf |= (long)((ulong)(uint)num66 << (int)(uint)(*(int*)bit_buf_size));
						*(int*)bit_buf_size += num67;
						if (*(int*)bit_buf_size > 64)
						{
							wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 805);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
						}
						while (true)
						{
							if (*(int*)bit_buf_size >= 8)
							{
								if ((uint)(*(int*)dst_ofs + 1) > (uint)dst_buf_size)
								{
									flag = false;
									break;
								}
								sbyte b21 = (sbyte)(*(long*)bit_buf);
								((sbyte*)pDst)[(uint)(*(int*)dst_ofs)] = b21;
								(*(int*)dst_ofs)++;
								*(long*)bit_buf >>>= 8;
								checked
								{
									*unchecked((int*)bit_buf_size) -= 8;
									continue;
								}
							}
							int k = 0;
							while (true)
							{
								if (k < l)
								{
									int num68 = ((byte*)(&((fpng_defl_huff*)d)->m_huff_code_sizes) + (nint)2 * sizeof(InlineArray288_SByte))[(byte)((sbyte*)g_defl_packed_code_size_syms_swizzle.__pointer)[(uint)k]];
									int num69 = 3;
									if ((uint)num69 < 1u || (uint)num69 > 16u)
									{
										wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 806);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
									}
									if ((ulong)(uint)num68 >= (ulong)(1L << (int)(uint)num69))
									{
										wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 806);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
									}
									*(long*)bit_buf |= (long)((ulong)(uint)num68 << (int)(uint)(*(int*)bit_buf_size));
									*(int*)bit_buf_size += num69;
									if (*(int*)bit_buf_size > 64)
									{
										wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 806);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
									}
									while (*(int*)bit_buf_size >= 8)
									{
										if ((uint)(*(int*)dst_ofs + 1) <= (uint)dst_buf_size)
										{
											sbyte b22 = (sbyte)(*(long*)bit_buf);
											((sbyte*)pDst)[(uint)(*(int*)dst_ofs)] = b22;
											(*(int*)dst_ofs)++;
											*(long*)bit_buf >>>= 8;
											checked
											{
												*unchecked((int*)bit_buf_size) -= 8;
												continue;
											}
										}
										goto IL_13fe;
									}
									k++;
									continue;
								}
								int num70 = 0;
								while (true)
								{
									if ((uint)num70 < (uint)num2)
									{
										int num71 = num70++;
										int num72 = (byte)((sbyte*)(&localsPointer->field_1))[(uint)num71];
										if ((uint)num72 >= 19u)
										{
											wassert.Invoke(String_erkdsbd.__pointer, String_uxbkrtb.__pointer, 810);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
										}
										int num73 = (ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_codes) + (nint)2 * sizeof(InlineArray288_Int16)))[(uint)num72];
										int num74 = ((byte*)(&((fpng_defl_huff*)d)->m_huff_code_sizes) + (nint)2 * sizeof(InlineArray288_SByte))[(uint)num72];
										if ((uint)num74 < 1u || (uint)num74 > 16u)
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 811);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
										}
										if ((ulong)(uint)num73 >= (ulong)(1L << (int)(uint)num74))
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 811);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
										}
										*(long*)bit_buf |= (long)((ulong)(uint)num73 << (int)(uint)(*(int*)bit_buf_size));
										*(int*)bit_buf_size += num74;
										if (*(int*)bit_buf_size > 64)
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 811);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
										}
										while (*(int*)bit_buf_size >= 8)
										{
											if ((uint)(*(int*)dst_ofs + 1) <= (uint)dst_buf_size)
											{
												sbyte b23 = (sbyte)(*(long*)bit_buf);
												((sbyte*)pDst)[(uint)(*(int*)dst_ofs)] = b23;
												(*(int*)dst_ofs)++;
												*(long*)bit_buf >>>= 8;
												checked
												{
													*unchecked((int*)bit_buf_size) -= 8;
													continue;
												}
											}
											goto IL_1605;
										}
										if ((uint)num72 < 16u)
										{
											continue;
										}
										int num75 = num70++;
										int num76 = (byte)((sbyte*)(&localsPointer->field_1))[(uint)num75];
										int num77 = ((sbyte*)String_o9ulvgb.__pointer)[(uint)(num72 - 16)];
										if ((uint)num77 < 1u || (uint)num77 > 16u)
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 812);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
										}
										if ((ulong)(uint)num76 >= (ulong)(1L << (int)(uint)num77))
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 812);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
										}
										*(long*)bit_buf |= (long)((ulong)(uint)num76 << (int)(uint)(*(int*)bit_buf_size));
										*(int*)bit_buf_size += num77;
										if (*(int*)bit_buf_size > 64)
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 812);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
										}
										while (*(int*)bit_buf_size >= 8)
										{
											if ((uint)(*(int*)dst_ofs + 1) <= (uint)dst_buf_size)
											{
												sbyte b24 = (sbyte)(*(long*)bit_buf);
												((sbyte*)pDst)[(uint)(*(int*)dst_ofs)] = b24;
												(*(int*)dst_ofs)++;
												*(long*)bit_buf >>>= 8;
												checked
												{
													*unchecked((int*)bit_buf_size) -= 8;
													continue;
												}
											}
											goto IL_179c;
										}
										continue;
									}
									flag = true;
									break;
									IL_179c:
									flag = false;
									break;
									IL_1605:
									flag = false;
									break;
								}
								break;
								IL_13fe:
								flag = false;
								break;
							}
							break;
						}
						break;
					}
					break;
				}
				break;
			}
			bool result = flag;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
