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
		public InlineArray_320_w3otm9c field_0;

		public InlineArray_320_w3otm9c field_1;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("struct fpng::defl_huff *")] void* d, [NativeType("unsigned char *")] void* pDst, [NativeType("unsigned int &")] void* dst_ofs, [NativeType("unsigned int")] int dst_buf_size, [NativeType("unsigned __int64 &")] void* bit_buf, [NativeType("int &")] void* bit_buf_size)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		bool flag = false;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = default(InlineArray_320_w3otm9c);
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = default(InlineArray_320_w3otm9c);
		sbyte b = 0;
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
		sbyte b2 = -1;
		unchecked((short*)(&((fpng_defl_huff*)d)->field_0))[256] = 1;
		defl_optimize_huffman_table.Invoke(d, 0, 288, 12, 0);
		defl_optimize_huffman_table.Invoke(d, 1, 32, 12, 0);
		int i;
		for (i = 286; i > 257 && unchecked((sbyte*)(&((fpng_defl_huff*)d)->field_2))[i - 1] == 0; i += -1)
		{
		}
		for (num = 30; num > 1 && (unchecked((byte*)(&((fpng_defl_huff*)d)->field_2)) + sizeof(InlineArray_288_w3otm9c))[num - 1] == 0; num += -1)
		{
		}
		unchecked
		{
			llvm_memcpy_p0_p0_i64.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_0, &((fpng_defl_huff*)d)->field_2, i, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke((byte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_0) + i, (byte*)(&((fpng_defl_huff*)d)->field_2) + sizeof(InlineArray_288_w3otm9c), num, isVolatile: false);
			num4 = checked(i + num);
			num5 = 0;
			num6 = 0;
			num7 = 0;
			llvm_memset_p0_i64.Invoke((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea), 0, 38L, isVolatile: false);
			for (num3 = 0; (uint)num3 < (uint)num4; num3++)
			{
				b = ((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_0))[(uint)num3];
				if (b == 0)
				{
					if (num7 != 0)
					{
						if ((uint)num7 < 3u)
						{
							short num24 = (short)((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[(byte)b2] + num7);
							((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[(byte)b2] = num24;
							while (true)
							{
								int num25 = num7;
								num7 = num25 + -1;
								if (num25 == 0)
								{
									break;
								}
								sbyte b3 = b2;
								int num26 = num5++;
								((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num26] = b3;
							}
						}
						else
						{
							short num27 = (short)checked(unchecked((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[16]) + 1);
							((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[16] = num27;
							int num28 = num5++;
							((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num28] = 16;
							sbyte b4 = (sbyte)(num7 - 3);
							int num29 = num5++;
							((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num29] = b4;
						}
						num7 = 0;
					}
					int num30 = num6 + 1;
					num6 = num30;
					if (num30 == 138 && num6 != 0)
					{
						switch (num6)
						{
						case 0:
						case 1:
						case 2:
						{
							short num37 = (short)((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea))) + num6);
							*(short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)) = num37;
							while (true)
							{
								int num38 = num6;
								num6 = num38 + -1;
								if (num38 == 0)
								{
									break;
								}
								int num39 = num5++;
								((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num39] = 0;
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
							short num34 = (short)checked(unchecked((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[17]) + 1);
							((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[17] = num34;
							int num35 = num5++;
							((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num35] = 17;
							sbyte b6 = (sbyte)(num6 - 3);
							int num36 = num5++;
							((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num36] = b6;
							break;
						}
						default:
						{
							short num31 = (short)checked(unchecked((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[18]) + 1);
							((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[18] = num31;
							int num32 = num5++;
							((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num32] = 18;
							sbyte b5 = (sbyte)(num6 - 11);
							int num33 = num5++;
							((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num33] = b5;
							break;
						}
						}
						num6 = 0;
					}
				}
				else
				{
					if (num6 != 0)
					{
						switch (num6)
						{
						case 0:
						case 1:
						case 2:
						{
							short num46 = (short)((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea))) + num6);
							*(short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)) = num46;
							while (true)
							{
								int num47 = num6;
								num6 = num47 + -1;
								if (num47 == 0)
								{
									break;
								}
								int num48 = num5++;
								((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num48] = 0;
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
							short num43 = (short)checked(unchecked((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[17]) + 1);
							((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[17] = num43;
							int num44 = num5++;
							((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num44] = 17;
							sbyte b8 = (sbyte)(num6 - 3);
							int num45 = num5++;
							((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num45] = b8;
							break;
						}
						default:
						{
							short num40 = (short)checked(unchecked((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[18]) + 1);
							((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[18] = num40;
							int num41 = num5++;
							((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num41] = 18;
							sbyte b7 = (sbyte)(num6 - 11);
							int num42 = num5++;
							((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num42] = b7;
							break;
						}
						}
						num6 = 0;
					}
					if ((byte)b != (byte)b2)
					{
						if (num7 != 0)
						{
							if ((uint)num7 < 3u)
							{
								short num49 = (short)((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[(byte)b2] + num7);
								((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[(byte)b2] = num49;
								while (true)
								{
									int num50 = num7;
									num7 = num50 + -1;
									if (num50 == 0)
									{
										break;
									}
									sbyte b9 = b2;
									int num51 = num5++;
									((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num51] = b9;
								}
							}
							else
							{
								short num52 = (short)checked(unchecked((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[16]) + 1);
								((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[16] = num52;
								int num53 = num5++;
								((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num53] = 16;
								sbyte b10 = (sbyte)(num7 - 3);
								int num54 = num5++;
								((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num54] = b10;
							}
							num7 = 0;
						}
						short num55 = (short)checked(unchecked((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[(byte)b]) + 1);
						((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[(byte)b] = num55;
						sbyte b11 = b;
						int num56 = num5++;
						((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num56] = b11;
					}
					else
					{
						int num57 = num7 + 1;
						num7 = num57;
						if (num57 == 6 && num7 != 0)
						{
							if ((uint)num7 < 3u)
							{
								short num58 = (short)((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[(byte)b2] + num7);
								((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[(byte)b2] = num58;
								while (true)
								{
									int num59 = num7;
									num7 = num59 + -1;
									if (num59 == 0)
									{
										break;
									}
									sbyte b12 = b2;
									int num60 = num5++;
									((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num60] = b12;
								}
							}
							else
							{
								short num61 = (short)checked(unchecked((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[16]) + 1);
								((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[16] = num61;
								int num62 = num5++;
								((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num62] = 16;
								sbyte b13 = (sbyte)(num7 - 3);
								int num63 = num5++;
								((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num63] = b13;
							}
							num7 = 0;
						}
					}
				}
				b2 = b;
			}
			if (num7 != 0)
			{
				if (num7 != 0)
				{
					if ((uint)num7 < 3u)
					{
						short num64 = (short)((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[(byte)b2] + num7);
						((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[(byte)b2] = num64;
						while (true)
						{
							int num65 = num7;
							num7 = num65 + -1;
							if (num65 == 0)
							{
								break;
							}
							sbyte b14 = b2;
							int num66 = num5++;
							((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num66] = b14;
						}
					}
					else
					{
						short num67 = (short)checked(unchecked((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[16]) + 1);
						((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[16] = num67;
						int num68 = num5++;
						((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num68] = 16;
						sbyte b15 = (sbyte)(num7 - 3);
						int num69 = num5++;
						((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num69] = b15;
					}
					num7 = 0;
				}
			}
			else if (num6 != 0)
			{
				switch (num6)
				{
				case 0:
				case 1:
				case 2:
				{
					short num76 = (short)((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea))) + num6);
					*(short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)) = num76;
					while (true)
					{
						int num77 = num6;
						num6 = num77 + -1;
						if (num77 == 0)
						{
							break;
						}
						int num78 = num5++;
						((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num78] = 0;
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
					short num73 = (short)checked(unchecked((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[17]) + 1);
					((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[17] = num73;
					int num74 = num5++;
					((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num74] = 17;
					sbyte b17 = (sbyte)(num6 - 3);
					int num75 = num5++;
					((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num75] = b17;
					break;
				}
				default:
				{
					short num70 = (short)checked(unchecked((ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[18]) + 1);
					((short*)((byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[18] = num70;
					int num71 = num5++;
					((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num71] = 18;
					sbyte b16 = (sbyte)(num6 - 11);
					int num72 = num5++;
					((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num72] = b16;
					break;
				}
				}
				num6 = 0;
			}
			defl_optimize_huffman_table.Invoke(d, 2, 19, 7, 0);
			num9 = 2;
			num10 = 2;
			int num79;
			if ((uint)num10 >= 1u && (uint)num10 <= 16u)
			{
				num79 = -1;
			}
			else
			{
				wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 799);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				num79 = 0;
			}
			int num80;
			if ((ulong)(uint)num9 < (ulong)(1L << (int)(uint)num10))
			{
				num80 = -1;
			}
			else
			{
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 799);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				num80 = 0;
			}
			*(long*)bit_buf |= (long)((ulong)(uint)num9 << (int)(uint)(*(int*)bit_buf_size));
			*(int*)bit_buf_size += num10;
			int num81;
			if (*(int*)bit_buf_size <= 64)
			{
				num81 = -1;
			}
			else
			{
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 799);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				num81 = 0;
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
				num11 = checked(i - 257);
				num12 = 5;
				int num82;
				if ((uint)num12 >= 1u && (uint)num12 <= 16u)
				{
					num82 = -1;
				}
				else
				{
					wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 801);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					num82 = 0;
				}
				int num83;
				if ((ulong)(uint)num11 < (ulong)(1L << (int)(uint)num12))
				{
					num83 = -1;
				}
				else
				{
					wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 801);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					num83 = 0;
				}
				*(long*)bit_buf |= (long)((ulong)(uint)num11 << (int)(uint)(*(int*)bit_buf_size));
				*(int*)bit_buf_size += num12;
				int num84;
				if (*(int*)bit_buf_size <= 64)
				{
					num84 = -1;
				}
				else
				{
					wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 801);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					num84 = 0;
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
					num13 = checked(num - 1);
					num14 = 5;
					int num85;
					if ((uint)num14 >= 1u && (uint)num14 <= 16u)
					{
						num85 = -1;
					}
					else
					{
						wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 802);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						num85 = 0;
					}
					int num86;
					if ((ulong)(uint)num13 < (ulong)(1L << (int)(uint)num14))
					{
						num86 = -1;
					}
					else
					{
						wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 802);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						num86 = 0;
					}
					*(long*)bit_buf |= (long)((ulong)(uint)num13 << (int)(uint)(*(int*)bit_buf_size));
					*(int*)bit_buf_size += num14;
					int num87;
					if (*(int*)bit_buf_size <= 64)
					{
						num87 = -1;
					}
					else
					{
						wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 802);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						num87 = 0;
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
						for (num2 = 18; num2 >= 0 && ((byte*)(&((fpng_defl_huff*)d)->field_2) + (nint)2 * sizeof(InlineArray_288_w3otm9c))[(byte)((sbyte*)g_defl_packed_code_size_syms_swizzle.__pointer)[num2]] == 0; num2 = checked(num2 + -1))
						{
						}
						checked
						{
							num2 = maximum_sfjssib.Invoke(4, num2 + 1);
							num15 = num2 - 4;
							num16 = 4;
						}
						int num88;
						if ((uint)num16 >= 1u && (uint)num16 <= 16u)
						{
							num88 = -1;
						}
						else
						{
							wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 805);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							num88 = 0;
						}
						int num89;
						if ((ulong)(uint)num15 < (ulong)(1L << (int)(uint)num16))
						{
							num89 = -1;
						}
						else
						{
							wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 805);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							num89 = 0;
						}
						*(long*)bit_buf |= (long)((ulong)(uint)num15 << (int)(uint)(*(int*)bit_buf_size));
						*(int*)bit_buf_size += num16;
						int num90;
						if (*(int*)bit_buf_size <= 64)
						{
							num90 = -1;
						}
						else
						{
							wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 805);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							num90 = 0;
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
							num3 = 0;
							while (true)
							{
								if (num3 < num2)
								{
									num17 = ((byte*)(&((fpng_defl_huff*)d)->field_2) + (nint)2 * sizeof(InlineArray_288_w3otm9c))[(byte)((sbyte*)g_defl_packed_code_size_syms_swizzle.__pointer)[(uint)num3]];
									num18 = 3;
									int num91;
									if ((uint)num18 >= 1u && (uint)num18 <= 16u)
									{
										num91 = -1;
									}
									else
									{
										wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 806);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										num91 = 0;
									}
									int num92;
									if ((ulong)(uint)num17 < (ulong)(1L << (int)(uint)num18))
									{
										num92 = -1;
									}
									else
									{
										wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 806);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										num92 = 0;
									}
									*(long*)bit_buf |= (long)((ulong)(uint)num17 << (int)(uint)(*(int*)bit_buf_size));
									*(int*)bit_buf_size += num18;
									int num93;
									if (*(int*)bit_buf_size <= 64)
									{
										num93 = -1;
									}
									else
									{
										wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 806);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										num93 = 0;
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
										goto IL_14bb;
									}
									num3++;
									continue;
								}
								num8 = 0;
								while (true)
								{
									if ((uint)num8 < (uint)num5)
									{
										int num94 = num8++;
										num19 = (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num94];
										int num95;
										if ((uint)num19 < 19u)
										{
											num95 = -1;
										}
										else
										{
											wassert.Invoke(String_erkdsbd.__pointer, String_uxbkrtb.__pointer, 810);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											num95 = 0;
										}
										num20 = (ushort)((short*)((byte*)(&((fpng_defl_huff*)d)->field_1) + (nint)2 * sizeof(InlineArray_288_oeds4ea)))[(uint)num19];
										num21 = ((byte*)(&((fpng_defl_huff*)d)->field_2) + (nint)2 * sizeof(InlineArray_288_w3otm9c))[(uint)num19];
										int num96;
										if ((uint)num21 >= 1u && (uint)num21 <= 16u)
										{
											num96 = -1;
										}
										else
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 811);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											num96 = 0;
										}
										int num97;
										if ((ulong)(uint)num20 < (ulong)(1L << (int)(uint)num21))
										{
											num97 = -1;
										}
										else
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 811);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											num97 = 0;
										}
										*(long*)bit_buf |= (long)((ulong)(uint)num20 << (int)(uint)(*(int*)bit_buf_size));
										*(int*)bit_buf_size += num21;
										int num98;
										if (*(int*)bit_buf_size <= 64)
										{
											num98 = -1;
										}
										else
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 811);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											num98 = 0;
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
											goto IL_16c8;
										}
										if ((uint)num19 < 16u)
										{
											continue;
										}
										int num99 = num8++;
										num22 = (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[(uint)num99];
										num23 = ((sbyte*)String_o9ulvgb.__pointer)[(uint)(num19 - 16)];
										int num100;
										if ((uint)num23 >= 1u && (uint)num23 <= 16u)
										{
											num100 = -1;
										}
										else
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 812);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											num100 = 0;
										}
										int num101;
										if ((ulong)(uint)num22 < (ulong)(1L << (int)(uint)num23))
										{
											num101 = -1;
										}
										else
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 812);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											num101 = 0;
										}
										*(long*)bit_buf |= (long)((ulong)(uint)num22 << (int)(uint)(*(int*)bit_buf_size));
										*(int*)bit_buf_size += num23;
										int num102;
										if (*(int*)bit_buf_size <= 64)
										{
											num102 = -1;
										}
										else
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 812);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											num102 = 0;
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
											goto IL_1865;
										}
										continue;
									}
									flag = true;
									break;
									IL_16c8:
									flag = false;
									break;
									IL_1865:
									flag = false;
									break;
								}
								break;
								IL_14bb:
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
