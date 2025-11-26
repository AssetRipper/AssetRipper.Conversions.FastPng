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
		public InlineArray320_SByte field_0;

		public InlineArray19_SByte field_1;

		public InlineArray4096_Int32 field_2;

		public InlineArray288_SByte field_3;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("unsigned char const *")] void* pSrc, [NativeType("unsigned int")] int src_len, [NativeType("unsigned int &")] void* src_ofs, [NativeType("unsigned int &")] void* bit_buf_size, [NativeType("unsigned __int64 &")] void* bit_buf, [NativeType("unsigned int *")] void* pLit_table, [NativeType("unsigned int")] int num_chans)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(InlineArray320_SByte);
		localsPointer->field_1 = default(InlineArray19_SByte);
		localsPointer->field_2 = default(InlineArray4096_Int32);
		localsPointer->field_3 = default(InlineArray288_SByte);
		int num = 5;
		bool flag;
		unchecked
		{
			if (num == 0 || (uint)num > 32u)
			{
				wassert.Invoke(String_f74ax6.__pointer, String_ksmiy6.__pointer, 1963);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
			}
			int num2 = (int)(*(long*)bit_buf & (uint)((int*)g_bitmasks.__pointer)[(uint)num]);
			*(long*)bit_buf >>>= (int)(uint)num;
			*(int*)bit_buf_size -= num;
			if ((uint)(*(int*)bit_buf_size) < 32u)
			{
				if ((uint)(*(int*)src_ofs + 4) > (uint)src_len)
				{
					flag = false;
					goto IL_0cf8;
				}
				*(long*)bit_buf |= (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)(*(int*)src_ofs))) << (int)(uint)(*(int*)bit_buf_size));
				*(int*)src_ofs += 4;
				*(int*)bit_buf_size += 32;
			}
			num2 += 257;
			int num3 = 5;
			if (num3 == 0 || (uint)num3 > 32u)
			{
				wassert.Invoke(String_f74ax6.__pointer, String_ksmiy6.__pointer, 1966);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
			}
			int num4 = (int)(*(long*)bit_buf & (uint)((int*)g_bitmasks.__pointer)[(uint)num3]);
			*(long*)bit_buf >>>= (int)(uint)num3;
			*(int*)bit_buf_size -= num3;
			if ((uint)(*(int*)bit_buf_size) < 32u)
			{
				if ((uint)(*(int*)src_ofs + 4) > (uint)src_len)
				{
					flag = false;
					goto IL_0cf8;
				}
				*(long*)bit_buf |= (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)(*(int*)src_ofs))) << (int)(uint)(*(int*)bit_buf_size));
				*(int*)src_ofs += 4;
				*(int*)bit_buf_size += 32;
			}
			num4++;
			int num5 = num2 + num4;
			if ((uint)num5 > 320u)
			{
				flag = false;
			}
			else
			{
				llvm_memset_p0_i64.Invoke(&localsPointer->field_0, 0, 320L, isVolatile: false);
				int num6 = 4;
				if (num6 == 0 || (uint)num6 > 32u)
				{
					wassert.Invoke(String_f74ax6.__pointer, String_ksmiy6.__pointer, 1976);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
				}
				int num7 = (int)(*(long*)bit_buf & (uint)((int*)g_bitmasks.__pointer)[(uint)num6]);
				*(long*)bit_buf >>>= (int)(uint)num6;
				*(int*)bit_buf_size -= num6;
				if ((uint)(*(int*)bit_buf_size) < 32u)
				{
					if ((uint)(*(int*)src_ofs + 4) > (uint)src_len)
					{
						flag = false;
						goto IL_0cf8;
					}
					*(long*)bit_buf |= (long)((ulong)(uint)(*(int*)((byte*)pSrc + (uint)(*(int*)src_ofs))) << (int)(uint)(*(int*)bit_buf_size));
					*(int*)src_ofs += 4;
					*(int*)bit_buf_size += 32;
				}
				num7 += 4;
				llvm_memset_p0_i64.Invoke(&localsPointer->field_1, 0, 19L, isVolatile: false);
				int num8 = 0;
				while (true)
				{
					if ((uint)num8 < (uint)num7)
					{
						int num9 = 3;
						if (num9 == 0 || (uint)num9 > 32u)
						{
							wassert.Invoke(String_f74ax6.__pointer, String_ksmiy6.__pointer, 1985);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
						}
						int num10 = (int)(*(long*)bit_buf & (uint)((int*)g_bitmasks.__pointer)[(uint)num9]);
						*(long*)bit_buf >>>= (int)(uint)num9;
						*(int*)bit_buf_size -= num9;
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
						sbyte b = (sbyte)num10;
						long num11 = (byte)((sbyte*)s_bit_length_order.__pointer)[(uint)num8];
						((sbyte*)(&localsPointer->field_1))[num11] = b;
						num8++;
						continue;
					}
					bool flag2 = build_decoder_table.Invoke(pTable: &localsPointer->field_2, num_syms: 19, pCode_sizes: &localsPointer->field_1);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (!flag2)
					{
						flag = false;
						break;
					}
					int num12 = 15;
					int num13 = 0;
					while (true)
					{
						if ((uint)num13 < (uint)num5)
						{
							long num14 = *(long*)bit_buf & 0xFFFL;
							int num15 = ((int*)(&localsPointer->field_2))[num14];
							int num16 = num15 >>> 9;
							if (num16 == 0)
							{
								flag = false;
								break;
							}
							int num17 = num16;
							if ((uint)num17 > 32u)
							{
								wassert.Invoke(String_j9965d.__pointer, String_ksmiy6.__pointer, 2001);
								if (ExceptionInfo.Current != null)
								{
									return false;
								}
							}
							*(long*)bit_buf >>>= (int)(uint)num17;
							*(int*)bit_buf_size -= num17;
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
							num15 &= 0x1FF;
							if ((uint)num15 <= 15u)
							{
								if ((uint)num15 > 12u)
								{
									flag = false;
									break;
								}
								if (num15 != 0)
								{
									num12 = minimum_sh5ug2.Invoke(num12, num15);
								}
								sbyte b2 = (sbyte)num15;
								int num18 = num13++;
								((sbyte*)(&localsPointer->field_0))[(uint)num18] = b2;
								continue;
							}
							int i = 0;
							int num19 = 0;
							int num20 = num15;
							if (num20 != 16)
							{
								if (num20 != 17)
								{
									if (num20 == 18)
									{
										int num21 = 7;
										if (num21 == 0 || (uint)num21 > 32u)
										{
											wassert.Invoke(String_f74ax6.__pointer, String_ksmiy6.__pointer, 2039);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
										}
										i = (int)(*(long*)bit_buf & (uint)((int*)g_bitmasks.__pointer)[(uint)num21]);
										*(long*)bit_buf >>>= (int)(uint)num21;
										*(int*)bit_buf_size -= num21;
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
										i += 11;
										num19 = 0;
									}
								}
								else
								{
									int num22 = 3;
									if (num22 == 0 || (uint)num22 > 32u)
									{
										wassert.Invoke(String_f74ax6.__pointer, String_ksmiy6.__pointer, 2032);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
									}
									i = (int)(*(long*)bit_buf & (uint)((int*)g_bitmasks.__pointer)[(uint)num22]);
									*(long*)bit_buf >>>= (int)(uint)num22;
									*(int*)bit_buf_size -= num22;
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
									i += 3;
									num19 = 0;
								}
							}
							else
							{
								int num23 = 2;
								if (num23 == 0 || (uint)num23 > 32u)
								{
									wassert.Invoke(String_f74ax6.__pointer, String_ksmiy6.__pointer, 2023);
									if (ExceptionInfo.Current != null)
									{
										return false;
									}
								}
								i = (int)(*(long*)bit_buf & (uint)((int*)g_bitmasks.__pointer)[(uint)num23]);
								*(long*)bit_buf >>>= (int)(uint)num23;
								*(int*)bit_buf_size -= num23;
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
								i += 3;
								if (num13 == 0)
								{
									flag = false;
									break;
								}
								num19 = (byte)((sbyte*)(&localsPointer->field_0))[(uint)(num13 - 1)];
							}
							if ((uint)(num13 + i) > (uint)num5)
							{
								flag = false;
								break;
							}
							for (; i != 0; i += -1)
							{
								sbyte b3 = (sbyte)num19;
								int num24 = num13++;
								((sbyte*)(&localsPointer->field_0))[(uint)num24] = b3;
							}
							continue;
						}
						llvm_memcpy_p0_p0_i64.Invoke(&localsPointer->field_3, &localsPointer->field_0, (uint)num2, isVolatile: false);
						llvm_memset_p0_i64.Invoke((byte*)(&localsPointer->field_3) + (uint)num2, 0, (uint)(288 - num2), isVolatile: false);
						int num25 = 0;
						for (int j = 0; (uint)j < (uint)num4; j++)
						{
							num25 += (((byte)((sbyte*)(&localsPointer->field_0))[(uint)(num2 + j)] == 1) ? 1 : 0);
						}
						if ((uint)num25 < 1u || (uint)num25 > 2u)
						{
							flag = false;
							break;
						}
						if ((byte)((sbyte*)(&localsPointer->field_0))[(uint)(num2 + (num_chans - 1))] != 1)
						{
							flag = false;
							break;
						}
						if (num25 == 2 && (byte)((sbyte*)(&localsPointer->field_0))[(uint)(num2 + num_chans)] != 1)
						{
							flag = false;
							break;
						}
						bool flag3 = build_decoder_table.Invoke(num2, &localsPointer->field_3, pLit_table);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag3)
						{
							flag = false;
							break;
						}
						for (int k = 0; (uint)k < 4096u; k++)
						{
							if ((uint)(((int*)pLit_table)[(uint)k] & 0x1FF) >= 256u)
							{
								continue;
							}
							int num26 = (((int*)pLit_table)[(uint)k] >>> 9) & 0xF;
							if (num26 == 0)
							{
								continue;
							}
							if ((uint)num26 > 12u)
							{
								wassert.Invoke(String_dvv5b3.__pointer, String_ksmiy6.__pointer, 2089);
								if (ExceptionInfo.Current != null)
								{
									return false;
								}
							}
							int num27 = 12 - num26;
							if ((uint)num27 >= (uint)num12)
							{
								int num28 = k >>> num26;
								int num29 = ((int*)pLit_table)[(uint)num28] & 0x1FF;
								int num30 = (((int*)pLit_table)[(uint)num28] >>> 9) & 0xF;
								if (num30 != 0 && (uint)num27 >= (uint)num30)
								{
									((int*)pLit_table)[(uint)k] |= (num29 << 16) | (num30 << 25);
								}
							}
						}
						flag = true;
						break;
					}
					break;
				}
			}
			goto IL_0cf8;
		}
		IL_0cf8:
		bool result = flag;
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
