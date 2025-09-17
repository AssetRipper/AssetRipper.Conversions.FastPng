using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?prepare_dynamic_block@fpng@@YA_NPEBEIAEAI1AEA_KPEAII@Z")]
[DemangledName("bool __cdecl fpng::prepare_dynamic_block(unsigned char const *, unsigned int, unsigned int &, unsigned int &, unsigned __int64 &, unsigned int *, unsigned int)")]
internal static partial class prepare_dynamic_block
{
	private partial struct LocalVariables
	{
		public InlineArray_320_w3otm9c field_0;

		public InlineArray_19_w3otm9c field_1;

		public InlineArray_4096_vqkfj7a field_2;

		public InlineArray_288_w3otm9c field_3;
	}

	public unsafe static bool Invoke(void* pSrc, int src_len, void* src_ofs, void* bit_buf_size, void* bit_buf, void* pLit_table, int num_chans)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		bool flag = false;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = default(InlineArray_320_w3otm9c);
		int num7 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = default(InlineArray_19_w3otm9c);
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = default(InlineArray_4096_vqkfj7a);
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
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = default(InlineArray_288_w3otm9c);
		int num21 = 0;
		int num22 = 0;
		int num23 = 0;
		int num24 = 0;
		int num25 = 0;
		int num26 = 0;
		int num27 = 0;
		int num28 = 0;
		int num29 = 0;
		num4 = 5;
		unchecked
		{
			int num30;
			if (num4 != 0 && (uint)num4 <= 32u)
			{
				num30 = -1;
			}
			else
			{
				wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 1963);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				num30 = 0;
			}
			num = (int)(*(long*)bit_buf & (uint)((int*)g_bitmasks.__pointer)[(uint)num4]);
			*(long*)bit_buf >>>= (int)(uint)num4;
			*(int*)bit_buf_size -= num4;
			if ((uint)(*(int*)bit_buf_size) < 32u)
			{
				if ((uint)(*(int*)src_ofs + 4) > (uint)src_len)
				{
					flag = false;
					goto IL_0d62;
				}
				*(long*)bit_buf |= (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)(*(int*)src_ofs))) << (int)(uint)(*(int*)bit_buf_size));
				*(int*)src_ofs += 4;
				*(int*)bit_buf_size += 32;
			}
			num += 257;
			num5 = 5;
			int num31;
			if (num5 != 0 && (uint)num5 <= 32u)
			{
				num31 = -1;
			}
			else
			{
				wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 1966);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				num31 = 0;
			}
			num2 = (int)(*(long*)bit_buf & (uint)((int*)g_bitmasks.__pointer)[(uint)num5]);
			*(long*)bit_buf >>>= (int)(uint)num5;
			*(int*)bit_buf_size -= num5;
			if ((uint)(*(int*)bit_buf_size) < 32u)
			{
				if ((uint)(*(int*)src_ofs + 4) > (uint)src_len)
				{
					flag = false;
					goto IL_0d62;
				}
				*(long*)bit_buf |= (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)(*(int*)src_ofs))) << (int)(uint)(*(int*)bit_buf_size));
				*(int*)src_ofs += 4;
				*(int*)bit_buf_size += 32;
			}
			num2++;
			num6 = num + num2;
			if ((uint)num6 > 320u)
			{
				flag = false;
			}
			else
			{
				llvm_memset_p0_i64.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_0, 0, 320L, isVolatile: false);
				num7 = 4;
				int num32;
				if (num7 != 0 && (uint)num7 <= 32u)
				{
					num32 = -1;
				}
				else
				{
					wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 1976);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					num32 = 0;
				}
				num3 = (int)(*(long*)bit_buf & (uint)((int*)g_bitmasks.__pointer)[(uint)num7]);
				*(long*)bit_buf >>>= (int)(uint)num7;
				*(int*)bit_buf_size -= num7;
				if ((uint)(*(int*)bit_buf_size) < 32u)
				{
					if ((uint)(*(int*)src_ofs + 4) > (uint)src_len)
					{
						flag = false;
						goto IL_0d62;
					}
					*(long*)bit_buf |= (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)(*(int*)src_ofs))) << (int)(uint)(*(int*)bit_buf_size));
					*(int*)src_ofs += 4;
					*(int*)bit_buf_size += 32;
				}
				num3 += 4;
				llvm_memset_p0_i64.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_1, 0, 19L, isVolatile: false);
				num8 = 0;
				while (true)
				{
					if ((uint)num8 < (uint)num3)
					{
						num9 = 0;
						num10 = 3;
						int num33;
						if (num10 != 0 && (uint)num10 <= 32u)
						{
							num33 = -1;
						}
						else
						{
							wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 1985);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							num33 = 0;
						}
						num9 = (int)(*(long*)bit_buf & (uint)((int*)g_bitmasks.__pointer)[(uint)num10]);
						*(long*)bit_buf >>>= (int)(uint)num10;
						*(int*)bit_buf_size -= num10;
						if ((uint)(*(int*)bit_buf_size) < 32u)
						{
							if ((uint)(*(int*)src_ofs + 4) > (uint)src_len)
							{
								flag = false;
								break;
							}
							*(long*)bit_buf |= (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)(*(int*)src_ofs))) << (int)(uint)(*(int*)bit_buf_size));
							*(int*)src_ofs += 4;
							*(int*)bit_buf_size += 32;
						}
						sbyte b = (sbyte)num9;
						long num34 = (byte)((sbyte*)s_bit_length_order.__pointer)[(uint)num8];
						((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[num34] = b;
						num8++;
						continue;
					}
					bool flag2 = build_decoder_table.Invoke(pTable: &startFrame.GetLocalsPointer<LocalVariables>()->field_2, num_syms: 19, pCode_sizes: &startFrame.GetLocalsPointer<LocalVariables>()->field_1);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (!flag2)
					{
						flag = false;
						break;
					}
					num11 = 15;
					num12 = 0;
					while (true)
					{
						if ((uint)num12 < (uint)num6)
						{
							long num35 = *(long*)bit_buf & 0xFFFL;
							num13 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_2))[num35];
							num14 = num13 >>> 9;
							if (num14 == 0)
							{
								flag = false;
								break;
							}
							num15 = num14;
							int num36;
							if ((uint)num15 <= 32u)
							{
								num36 = -1;
							}
							else
							{
								wassert.Invoke(String_mf9hyza.__pointer, String_uxbkrtb.__pointer, 2001);
								if (ExceptionInfo.Current != null)
								{
									return false;
								}
								num36 = 0;
							}
							*(long*)bit_buf >>>= (int)(uint)num15;
							*(int*)bit_buf_size -= num15;
							if ((uint)(*(int*)bit_buf_size) < 32u)
							{
								if ((uint)(*(int*)src_ofs + 4) > (uint)src_len)
								{
									flag = false;
									break;
								}
								*(long*)bit_buf |= (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)(*(int*)src_ofs))) << (int)(uint)(*(int*)bit_buf_size));
								*(int*)src_ofs += 4;
								*(int*)bit_buf_size += 32;
							}
							num13 &= 0x1FF;
							if ((uint)num13 <= 15u)
							{
								if ((uint)num13 > 12u)
								{
									flag = false;
									break;
								}
								if (num13 != 0)
								{
									num11 = minimum_su2nfub.Invoke(num11, num13);
								}
								sbyte b2 = (sbyte)num13;
								int num37 = num12++;
								((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_0))[(uint)num37] = b2;
								continue;
							}
							num16 = 0;
							num17 = 0;
							int num38 = num13;
							if (num38 != 16)
							{
								if (num38 != 17)
								{
									if (num38 == 18)
									{
										num20 = 7;
										int num39;
										if (num20 != 0 && (uint)num20 <= 32u)
										{
											num39 = -1;
										}
										else
										{
											wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 2039);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											num39 = 0;
										}
										num16 = (int)(*(long*)bit_buf & (uint)((int*)g_bitmasks.__pointer)[(uint)num20]);
										*(long*)bit_buf >>>= (int)(uint)num20;
										*(int*)bit_buf_size -= num20;
										if ((uint)(*(int*)bit_buf_size) < 32u)
										{
											if ((uint)(*(int*)src_ofs + 4) > (uint)src_len)
											{
												flag = false;
												break;
											}
											*(long*)bit_buf |= (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)(*(int*)src_ofs))) << (int)(uint)(*(int*)bit_buf_size));
											*(int*)src_ofs += 4;
											*(int*)bit_buf_size += 32;
										}
										num16 += 11;
										num17 = 0;
									}
								}
								else
								{
									num19 = 3;
									int num40;
									if (num19 != 0 && (uint)num19 <= 32u)
									{
										num40 = -1;
									}
									else
									{
										wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 2032);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										num40 = 0;
									}
									num16 = (int)(*(long*)bit_buf & (uint)((int*)g_bitmasks.__pointer)[(uint)num19]);
									*(long*)bit_buf >>>= (int)(uint)num19;
									*(int*)bit_buf_size -= num19;
									if ((uint)(*(int*)bit_buf_size) < 32u)
									{
										if ((uint)(*(int*)src_ofs + 4) > (uint)src_len)
										{
											flag = false;
											break;
										}
										*(long*)bit_buf |= (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)(*(int*)src_ofs))) << (int)(uint)(*(int*)bit_buf_size));
										*(int*)src_ofs += 4;
										*(int*)bit_buf_size += 32;
									}
									num16 += 3;
									num17 = 0;
								}
							}
							else
							{
								num18 = 2;
								int num41;
								if (num18 != 0 && (uint)num18 <= 32u)
								{
									num41 = -1;
								}
								else
								{
									wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 2023);
									if (ExceptionInfo.Current != null)
									{
										return false;
									}
									num41 = 0;
								}
								num16 = (int)(*(long*)bit_buf & (uint)((int*)g_bitmasks.__pointer)[(uint)num18]);
								*(long*)bit_buf >>>= (int)(uint)num18;
								*(int*)bit_buf_size -= num18;
								if ((uint)(*(int*)bit_buf_size) < 32u)
								{
									if ((uint)(*(int*)src_ofs + 4) > (uint)src_len)
									{
										flag = false;
										break;
									}
									*(long*)bit_buf |= (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)(*(int*)src_ofs))) << (int)(uint)(*(int*)bit_buf_size));
									*(int*)src_ofs += 4;
									*(int*)bit_buf_size += 32;
								}
								num16 += 3;
								if (num12 == 0)
								{
									flag = false;
									break;
								}
								long num42 = (uint)(num12 - 1);
								num17 = (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_0))[num42];
							}
							if ((uint)(num12 + num16) > (uint)num6)
							{
								flag = false;
								break;
							}
							for (; num16 != 0; num16 += -1)
							{
								sbyte b3 = (sbyte)num17;
								int num43 = num12++;
								((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_0))[(uint)num43] = b3;
							}
							continue;
						}
						llvm_memcpy_p0_p0_i64.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_3, &startFrame.GetLocalsPointer<LocalVariables>()->field_0, (uint)num, isVolatile: false);
						llvm_memset_p0_i64.Invoke((byte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_3) + (uint)num, 0, (uint)(288 - num), isVolatile: false);
						num21 = 0;
						for (num22 = 0; (uint)num22 < (uint)num2; num22++)
						{
							num21 += (((byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_0))[(uint)(num + num22)] == 1) ? 1 : 0);
						}
						if ((uint)num21 < 1u || (uint)num21 > 2u)
						{
							flag = false;
							break;
						}
						if ((byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_0))[(uint)(num + (num_chans - 1))] != 1)
						{
							flag = false;
							break;
						}
						if (num21 == 2 && (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_0))[(uint)(num + num_chans)] != 1)
						{
							flag = false;
							break;
						}
						bool flag3 = build_decoder_table.Invoke(num, &startFrame.GetLocalsPointer<LocalVariables>()->field_3, pLit_table);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag3)
						{
							flag = false;
							break;
						}
						for (num23 = 0; (uint)num23 < 4096u; num23++)
						{
							if ((uint)(((int*)pLit_table)[(uint)num23] & 0x1FF) >= 256u)
							{
								continue;
							}
							num25 = (((int*)pLit_table)[(uint)num23] >>> 9) & 0xF;
							if (num25 == 0)
							{
								continue;
							}
							int num44;
							if ((uint)num25 <= 12u)
							{
								num44 = -1;
							}
							else
							{
								wassert.Invoke(String_nlshwsc.__pointer, String_uxbkrtb.__pointer, 2089);
								if (ExceptionInfo.Current != null)
								{
									return false;
								}
								num44 = 0;
							}
							num26 = 12 - num25;
							if ((uint)num26 >= (uint)num11)
							{
								num27 = num23 >>> num25;
								num28 = ((int*)pLit_table)[(uint)num27] & 0x1FF;
								num29 = (((int*)pLit_table)[(uint)num27] >>> 9) & 0xF;
								if (num29 != 0 && (uint)num26 >= (uint)num29)
								{
									((int*)pLit_table)[(uint)num23] |= (num28 << 16) | (num29 << 25);
								}
							}
						}
						flag = true;
						break;
					}
					break;
				}
			}
			goto IL_0d62;
		}
		IL_0d62:
		bool result = flag;
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
