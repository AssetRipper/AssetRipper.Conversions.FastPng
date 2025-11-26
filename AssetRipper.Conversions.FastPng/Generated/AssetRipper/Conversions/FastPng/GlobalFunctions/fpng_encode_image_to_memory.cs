using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?fpng_encode_image_to_memory@fpng@@YA_NPEBXIIIAEAV?$vector@EV?$allocator@E@std@@@std@@I@Z")]
[DemangledName("bool __cdecl fpng::fpng_encode_image_to_memory(void const *, unsigned int, unsigned int, unsigned int, class std::vector<unsigned char, class std::allocator<unsigned char>> &, unsigned int)")]
internal static partial class fpng_encode_image_to_memory
{
	private partial struct LocalVariables
	{
		public std_vector_4tqn2f field_0;

		public InlineArray58_SByte field_1;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("void const *")] void* pImage, [NativeType("unsigned int")] int w, [NativeType("unsigned int")] int h, [NativeType("unsigned int")] int num_chans, [NativeType("class std::vector<unsigned char, class std::allocator<unsigned char>> &")] void* out_buf, [NativeType("unsigned int")] int flags)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(std_vector_4tqn2f);
		localsPointer->field_1 = default(InlineArray58_SByte);
		bool flag;
		int num;
		int num4;
		int num5;
		int num2;
		int num3;
		unchecked
		{
			if (!endian_check.Invoke())
			{
				wassert.Invoke(String_v852r7.__pointer, String_ksmiy6.__pointer, 1666);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				flag = false;
			}
			else if ((uint)w < 1u || (uint)h < 1u || (ulong)((long)(uint)w * (long)(uint)h) > 4294967295uL || (uint)w > 16777216u || (uint)h > 16777216u)
			{
				wassert.Invoke(String_v852r7.__pointer, String_ksmiy6.__pointer, 1672);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				flag = false;
			}
			else
			{
				if (num_chans == 3 || num_chans == 4)
				{
					num = w * num_chans;
					vector_unsigned_char_class_std_allocator_unsigned_char_Constructor.Invoke(&localsPointer->field_0);
					resize_irjm7f.Invoke(Newsize: (uint)(checked(num + 1) * h + 7), @this: &localsPointer->field_0);
					if (ExceptionInfo.Current == null)
					{
						num2 = 0;
						num3 = 0;
						while ((uint)num3 < (uint)h)
						{
							apply_filter.Invoke(pSrc: (byte*)pImage + (uint)(num3 * num), pPrev_src: (num3 == 0) ? null : ((byte*)pImage + (uint)((num3 - 1) * num)), pDst: vector_unsigned_char_class_std_allocator_unsigned_char_Operator.Invoke(&localsPointer->field_0, (uint)num2), filter: InstructionHelper.Select(num3 != 0, 2, 0), w: w, h: h, num_chans: num_chans, bpl: num);
							if (ExceptionInfo.Current == null)
							{
								num2 += checked(1 + num);
								num3++;
								continue;
							}
							goto IL_0a27;
						}
						num4 = 58;
						resize_irjm7f.Invoke(out_buf, (uint)((num4 + checked(num + 1) * h + 7) & -8));
						if (ExceptionInfo.Current == null)
						{
							num5 = 0;
							if ((flags & 2) != 0)
							{
								goto IL_03f3;
							}
							if (num_chans == 3)
							{
								if ((flags & 1) != 0)
								{
									int num6 = pixel_deflate_dyn_3_rle.Invoke(dst_buf_size: (int)size_78pg66.Invoke(out_buf) - num4, pDst: vector_unsigned_char_class_std_allocator_unsigned_char_Operator.Invoke(out_buf, (uint)num4), pImg: data_2v5v72.Invoke(&localsPointer->field_0), w: w, h: h);
									if (ExceptionInfo.Current == null)
									{
										num5 = num6;
										goto IL_03f3;
									}
								}
								else
								{
									int num7 = pixel_deflate_dyn_3_rle_one_pass.Invoke(dst_buf_size: (int)size_78pg66.Invoke(out_buf) - num4, pDst: vector_unsigned_char_class_std_allocator_unsigned_char_Operator.Invoke(out_buf, (uint)num4), pImg: data_2v5v72.Invoke(&localsPointer->field_0), w: w, h: h);
									if (ExceptionInfo.Current == null)
									{
										num5 = num7;
										goto IL_03f3;
									}
								}
							}
							else if ((flags & 1) != 0)
							{
								int num8 = pixel_deflate_dyn_4_rle.Invoke(dst_buf_size: (int)size_78pg66.Invoke(out_buf) - num4, pDst: vector_unsigned_char_class_std_allocator_unsigned_char_Operator.Invoke(out_buf, (uint)num4), pImg: data_2v5v72.Invoke(&localsPointer->field_0), w: w, h: h);
								if (ExceptionInfo.Current == null)
								{
									num5 = num8;
									goto IL_03f3;
								}
							}
							else
							{
								int num9 = pixel_deflate_dyn_4_rle_one_pass.Invoke(dst_buf_size: (int)size_78pg66.Invoke(out_buf) - num4, pDst: vector_unsigned_char_class_std_allocator_unsigned_char_Operator.Invoke(out_buf, (uint)num4), pImg: data_2v5v72.Invoke(&localsPointer->field_0), w: w, h: h);
								if (ExceptionInfo.Current == null)
								{
									num5 = num9;
									goto IL_03f3;
								}
							}
						}
					}
					goto IL_0a27;
				}
				wassert.Invoke(String_v852r7.__pointer, String_ksmiy6.__pointer, 1678);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				flag = false;
			}
			goto IL_0a45;
		}
		IL_0a45:
		bool result = flag;
		StackFrameList.Current.Clear(startFrame);
		return result;
		IL_0a27:
		ExceptionInfo? current = ExceptionInfo.Current;
		ExceptionInfo.Current = null;
		vector_unsigned_char_class_std_allocator_unsigned_char_Destructor.Invoke(&localsPointer->field_0);
		ExceptionInfo.Current = current;
		return false;
		IL_057e:
		int num10;
		unchecked
		{
			if ((ulong)(uint)(num4 + num10) > (ulong)size_78pg66.Invoke(out_buf))
			{
				wassert.Invoke(String_bjniyv.__pointer, String_ksmiy6.__pointer, 1760);
				if (ExceptionInfo.Current != null)
				{
					goto IL_0a27;
				}
			}
			resize_irjm7f.Invoke(out_buf, (uint)(num4 + num10));
			if (ExceptionInfo.Current == null)
			{
				int num11 = (int)size_78pg66.Invoke(out_buf) - 58;
				*(sbyte*)(&localsPointer->field_1) = -119;
				((sbyte*)(&localsPointer->field_1))[1] = 80;
				((sbyte*)(&localsPointer->field_1))[2] = 78;
				((sbyte*)(&localsPointer->field_1))[3] = 71;
				((sbyte*)(&localsPointer->field_1))[4] = 13;
				((sbyte*)(&localsPointer->field_1))[5] = 10;
				((sbyte*)(&localsPointer->field_1))[6] = 26;
				((sbyte*)(&localsPointer->field_1))[7] = 10;
				((sbyte*)(&localsPointer->field_1))[8] = 0;
				((sbyte*)(&localsPointer->field_1))[9] = 0;
				((sbyte*)(&localsPointer->field_1))[10] = 0;
				((sbyte*)(&localsPointer->field_1))[11] = 13;
				((sbyte*)(&localsPointer->field_1))[12] = 73;
				((sbyte*)(&localsPointer->field_1))[13] = 72;
				((sbyte*)(&localsPointer->field_1))[14] = 68;
				((sbyte*)(&localsPointer->field_1))[15] = 82;
				((sbyte*)(&localsPointer->field_1))[16] = 0;
				((sbyte*)(&localsPointer->field_1))[17] = 0;
				((sbyte*)(&localsPointer->field_1))[18] = (sbyte)(w >>> 8);
				((sbyte*)(&localsPointer->field_1))[19] = (sbyte)w;
				((sbyte*)(&localsPointer->field_1))[20] = 0;
				((sbyte*)(&localsPointer->field_1))[21] = 0;
				((sbyte*)(&localsPointer->field_1))[22] = (sbyte)(h >>> 8);
				((sbyte*)(&localsPointer->field_1))[23] = (sbyte)h;
				((sbyte*)(&localsPointer->field_1))[24] = 8;
				((sbyte*)(&localsPointer->field_1))[25] = ((sbyte*)s_color_type.__pointer)[(uint)num_chans];
				((sbyte*)(&localsPointer->field_1))[26] = 0;
				((sbyte*)(&localsPointer->field_1))[27] = 0;
				((sbyte*)(&localsPointer->field_1))[28] = 0;
				((sbyte*)(&localsPointer->field_1))[29] = 0;
				((sbyte*)(&localsPointer->field_1))[30] = 0;
				((sbyte*)(&localsPointer->field_1))[31] = 0;
				((sbyte*)(&localsPointer->field_1))[32] = 0;
				((sbyte*)(&localsPointer->field_1))[33] = 0;
				((sbyte*)(&localsPointer->field_1))[34] = 0;
				((sbyte*)(&localsPointer->field_1))[35] = 0;
				((sbyte*)(&localsPointer->field_1))[36] = 5;
				((sbyte*)(&localsPointer->field_1))[37] = 102;
				((sbyte*)(&localsPointer->field_1))[38] = 100;
				((sbyte*)(&localsPointer->field_1))[39] = 69;
				((sbyte*)(&localsPointer->field_1))[40] = 67;
				((sbyte*)(&localsPointer->field_1))[41] = 82;
				((sbyte*)(&localsPointer->field_1))[42] = 36;
				((sbyte*)(&localsPointer->field_1))[43] = -109;
				((sbyte*)(&localsPointer->field_1))[44] = -29;
				((sbyte*)(&localsPointer->field_1))[45] = 0;
				((sbyte*)(&localsPointer->field_1))[46] = -27;
				((sbyte*)(&localsPointer->field_1))[47] = -85;
				((sbyte*)(&localsPointer->field_1))[48] = 98;
				((sbyte*)(&localsPointer->field_1))[49] = -103;
				((sbyte*)(&localsPointer->field_1))[50] = (sbyte)(num11 >>> 24);
				((sbyte*)(&localsPointer->field_1))[51] = (sbyte)(num11 >>> 16);
				((sbyte*)(&localsPointer->field_1))[52] = (sbyte)(num11 >>> 8);
				((sbyte*)(&localsPointer->field_1))[53] = (sbyte)num11;
				((sbyte*)(&localsPointer->field_1))[54] = 73;
				((sbyte*)(&localsPointer->field_1))[55] = 68;
				((sbyte*)(&localsPointer->field_1))[56] = 65;
				((sbyte*)(&localsPointer->field_1))[57] = 84;
				int num12 = fpng_crc32.Invoke((byte*)(&localsPointer->field_1) + 12, 17L, 0);
				if (ExceptionInfo.Current == null)
				{
					int num13 = num12;
					int num14 = 0;
					while (num14 < 4)
					{
						((byte*)(&localsPointer->field_1) + 29)[num14] = (byte)(sbyte)((uint)num13 >> 24);
						num14 = checked(num14 + 1);
						num13 <<= 8;
					}
					llvm_memcpy_p0_p0_i64.Invoke(data_2v5v72.Invoke(out_buf), &localsPointer->field_1, 58L, isVolatile: false);
					vector_append.Invoke(out_buf, String_p5jh5t.__pointer, 16L);
					if (ExceptionInfo.Current == null)
					{
						int num15 = fpng_crc32.Invoke((byte*)data_2v5v72.Invoke(out_buf) + 58 + -4, (uint)(num11 + 4), 0);
						if (ExceptionInfo.Current == null)
						{
							int num16 = num15;
							num14 = 0;
							while (num14 < 4)
							{
								((byte*)data_2v5v72.Invoke(out_buf) + size_78pg66.Invoke(out_buf) + -16)[num14] = (byte)(sbyte)((uint)num16 >> 24);
								num14 = checked(num14 + 1);
								num16 <<= 8;
							}
							flag = true;
							goto IL_0a19;
						}
					}
				}
			}
			goto IL_0a27;
		}
		IL_0a19:
		vector_unsigned_char_class_std_allocator_unsigned_char_Destructor.Invoke(&localsPointer->field_0);
		goto IL_0a45;
		IL_03f3:
		num10 = num5;
		if (num5 != 0)
		{
			goto IL_057e;
		}
		num2 = 0;
		num3 = 0;
		unchecked
		{
			while ((uint)num3 < (uint)h)
			{
				apply_filter.Invoke(0, w, h, num_chans, num, (byte*)pImage + (uint)(num3 * num), null, vector_unsigned_char_class_std_allocator_unsigned_char_Operator.Invoke(&localsPointer->field_0, (uint)num2));
				if (ExceptionInfo.Current == null)
				{
					num2 += checked(1 + num);
					num3++;
					continue;
				}
				goto IL_0a27;
			}
			if ((ulong)(uint)num2 > (ulong)size_78pg66.Invoke(&localsPointer->field_0))
			{
				wassert.Invoke(String_85rv99.__pointer, String_ksmiy6.__pointer, 1745);
				if (ExceptionInfo.Current != null)
				{
					goto IL_0a27;
				}
			}
			resize_irjm7f.Invoke(out_buf, (uint)(num4 + 6 + num2 + (int)((uint)(num2 + 65534) / 65535u * 5)));
			if (ExceptionInfo.Current == null)
			{
				int num17 = write_raw_block.Invoke(dst_buf_size: (int)size_78pg66.Invoke(out_buf) - num4, pDst: (byte*)data_2v5v72.Invoke(out_buf) + (uint)num4, pSrc: data_2v5v72.Invoke(&localsPointer->field_0), src_len: num2);
				if (ExceptionInfo.Current == null)
				{
					int num18 = num17;
					if (num18 != 0)
					{
						num10 = num18;
						goto IL_057e;
					}
					wassert.Invoke(String_v852r7.__pointer, String_ksmiy6.__pointer, 1753);
					if (ExceptionInfo.Current == null)
					{
						flag = false;
						goto IL_0a19;
					}
				}
			}
			goto IL_0a27;
		}
	}
}
