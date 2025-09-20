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
		public std_vector_7uge3hb field_0;

		public InlineArray58_SByte field_1;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("void const *")] void* pImage, [NativeType("unsigned int")] int w, [NativeType("unsigned int")] int h, [NativeType("unsigned int")] int num_chans, [NativeType("class std::vector<unsigned char, class std::allocator<unsigned char>> &")] void* out_buf, [NativeType("unsigned int")] int flags)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		bool flag = false;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = default(std_vector_7uge3hb);
		int num4 = 0;
		void* ptr = null;
		void* ptr2 = null;
		void* ptr3 = null;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		void* ptr4 = null;
		void* ptr5 = null;
		int num9 = 0;
		int num10 = 0;
		int num11 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = default(InlineArray58_SByte);
		int num12 = 0;
		int num13 = 0;
		unchecked
		{
			if (!endian_check.Invoke())
			{
				wassert.Invoke(String_kdrammb.__pointer, String_uxbkrtb.__pointer, 1666);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				flag = false;
			}
			else if ((uint)w < 1u || (uint)h < 1u || (ulong)((long)(uint)w * (long)(uint)h) > 4294967295uL || (uint)w > 16777216u || (uint)h > 16777216u)
			{
				wassert.Invoke(String_kdrammb.__pointer, String_uxbkrtb.__pointer, 1672);
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
					num2 = w * num_chans;
					vector_unsigned_char_class_std_allocator_unsigned_char_Constructor.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_0);
					resize_wwmwtsa.Invoke(Newsize: (uint)(checked(num2 + 1) * h + 7), @this: &startFrame.GetLocalsPointer<LocalVariables>()->field_0);
					if (ExceptionInfo.Current == null)
					{
						num4 = 0;
						num3 = 0;
						while ((uint)num3 < (uint)h)
						{
							ptr = (byte*)pImage + (uint)(num3 * num2);
							ptr2 = ((num3 == 0) ? null : ((byte*)pImage + (uint)((num3 - 1) * num2)));
							void* pDst = vector_unsigned_char_class_std_allocator_unsigned_char_Index.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_0, (uint)num4);
							void* pPrev_src = ptr2;
							void* pSrc = ptr;
							int bpl = num2;
							int num_chans2 = num_chans;
							int h2 = h;
							int w2 = w;
							bool flag2 = num3 != 0;
							_ = flag2;
							apply_filter.Invoke(InstructionHelper.Select(flag2, 2, 0), w2, h2, num_chans2, bpl, pSrc, pPrev_src, pDst);
							if (ExceptionInfo.Current == null)
							{
								num4 += checked(1 + num2);
								num3++;
								continue;
							}
							goto IL_0be3;
						}
						num5 = 58;
						num6 = 58;
						resize_wwmwtsa.Invoke(out_buf, (uint)((num6 + checked(num2 + 1) * h + 7) & -8));
						if (ExceptionInfo.Current == null)
						{
							num7 = 0;
							if ((flags & 2) != 0)
							{
								goto IL_0423;
							}
							if (num_chans == 3)
							{
								if ((flags & 1) != 0)
								{
									int num14 = pixel_deflate_dyn_3_rle.Invoke(dst_buf_size: (int)size_4io4p4d.Invoke(out_buf) - num6, pDst: vector_unsigned_char_class_std_allocator_unsigned_char_Index.Invoke(out_buf, (uint)num6), pImg: data_efhnzgd.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_0), w: w, h: h);
									if (ExceptionInfo.Current == null)
									{
										num7 = num14;
										goto IL_0423;
									}
								}
								else
								{
									int num15 = pixel_deflate_dyn_3_rle_one_pass.Invoke(dst_buf_size: (int)size_4io4p4d.Invoke(out_buf) - num6, pDst: vector_unsigned_char_class_std_allocator_unsigned_char_Index.Invoke(out_buf, (uint)num6), pImg: data_efhnzgd.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_0), w: w, h: h);
									if (ExceptionInfo.Current == null)
									{
										num7 = num15;
										goto IL_0423;
									}
								}
							}
							else if ((flags & 1) != 0)
							{
								int num16 = pixel_deflate_dyn_4_rle.Invoke(dst_buf_size: (int)size_4io4p4d.Invoke(out_buf) - num6, pDst: vector_unsigned_char_class_std_allocator_unsigned_char_Index.Invoke(out_buf, (uint)num6), pImg: data_efhnzgd.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_0), w: w, h: h);
								if (ExceptionInfo.Current == null)
								{
									num7 = num16;
									goto IL_0423;
								}
							}
							else
							{
								int num17 = pixel_deflate_dyn_4_rle_one_pass.Invoke(dst_buf_size: (int)size_4io4p4d.Invoke(out_buf) - num6, pDst: vector_unsigned_char_class_std_allocator_unsigned_char_Index.Invoke(out_buf, (uint)num6), pImg: data_efhnzgd.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_0), w: w, h: h);
								if (ExceptionInfo.Current == null)
								{
									num7 = num17;
									goto IL_0423;
								}
							}
						}
					}
					goto IL_0be3;
				}
				wassert.Invoke(String_kdrammb.__pointer, String_uxbkrtb.__pointer, 1678);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				flag = false;
			}
			goto IL_0c07;
		}
		IL_0c07:
		bool result = flag;
		StackFrameList.Current.Clear(startFrame);
		return result;
		IL_0be3:
		ExceptionInfo? current = ExceptionInfo.Current;
		ExceptionInfo.Current = null;
		vector_unsigned_char_class_std_allocator_unsigned_char_Destructor.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_0);
		ExceptionInfo.Current = current;
		return false;
		IL_05c0:
		unchecked
		{
			int num18;
			if ((ulong)(uint)(num6 + num8) <= (ulong)size_4io4p4d.Invoke(out_buf))
			{
				num18 = -1;
			}
			else
			{
				wassert.Invoke(String_dqvhqxc.__pointer, String_uxbkrtb.__pointer, 1760);
				if (ExceptionInfo.Current != null)
				{
					goto IL_0be3;
				}
				num18 = 0;
			}
			resize_wwmwtsa.Invoke(out_buf, (uint)(num6 + num8));
			if (ExceptionInfo.Current == null)
			{
				num11 = (int)size_4io4p4d.Invoke(out_buf) - 58;
				*(sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1) = -119;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[1] = 80;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[2] = 78;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[3] = 71;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[4] = 13;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[5] = 10;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[6] = 26;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[7] = 10;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[8] = 0;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[9] = 0;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[10] = 0;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[11] = 13;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[12] = 73;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[13] = 72;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[14] = 68;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[15] = 82;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[16] = 0;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[17] = 0;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[18] = (sbyte)(w >>> 8);
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[19] = (sbyte)w;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[20] = 0;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[21] = 0;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[22] = (sbyte)(h >>> 8);
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[23] = (sbyte)h;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[24] = 8;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[25] = ((sbyte*)s_color_type.__pointer)[(uint)num_chans];
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[26] = 0;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[27] = 0;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[28] = 0;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[29] = 0;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[30] = 0;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[31] = 0;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[32] = 0;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[33] = 0;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[34] = 0;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[35] = 0;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[36] = 5;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[37] = 102;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[38] = 100;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[39] = 69;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[40] = 67;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[41] = 82;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[42] = 36;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[43] = -109;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[44] = -29;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[45] = 0;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[46] = -27;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[47] = -85;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[48] = 98;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[49] = -103;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[50] = (sbyte)(num11 >>> 24);
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[51] = (sbyte)(num11 >>> 16);
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[52] = (sbyte)(num11 >>> 8);
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[53] = (sbyte)num11;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[54] = 73;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[55] = 68;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[56] = 65;
				((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[57] = 84;
				int num19 = fpng_crc32.Invoke((byte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1) + 12, 17L, 0);
				if (ExceptionInfo.Current == null)
				{
					num12 = num19;
					num = 0;
					while (num < 4)
					{
						((byte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1) + 29)[num] = (byte)(sbyte)((uint)num12 >> 24);
						num = checked(num + 1);
						num12 <<= 8;
					}
					llvm_memcpy_p0_p0_i64.Invoke(data_efhnzgd.Invoke(out_buf), &startFrame.GetLocalsPointer<LocalVariables>()->field_1, 58L, isVolatile: false);
					vector_append.Invoke(out_buf, String_nz3h57a.__pointer, 16L);
					if (ExceptionInfo.Current == null)
					{
						int num20 = fpng_crc32.Invoke((byte*)data_efhnzgd.Invoke(out_buf) + 58 + -4, (uint)(num11 + 4), 0);
						if (ExceptionInfo.Current == null)
						{
							num13 = num20;
							num = 0;
							while (num < 4)
							{
								((byte*)data_efhnzgd.Invoke(out_buf) + size_4io4p4d.Invoke(out_buf) + -16)[num] = (byte)(sbyte)((uint)num13 >> 24);
								num = checked(num + 1);
								num13 <<= 8;
							}
							flag = true;
							num10 = 1;
							goto IL_0bcf;
						}
					}
				}
			}
			goto IL_0be3;
		}
		IL_0bcf:
		vector_unsigned_char_class_std_allocator_unsigned_char_Destructor.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_0);
		goto IL_0c07;
		IL_0423:
		num8 = num7;
		if (num7 != 0)
		{
			goto IL_05c0;
		}
		num4 = 0;
		num3 = 0;
		unchecked
		{
			while ((uint)num3 < (uint)h)
			{
				apply_filter.Invoke(0, w, h, num_chans, num2, (byte*)pImage + (uint)(num3 * num2), null, vector_unsigned_char_class_std_allocator_unsigned_char_Index.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_0, (uint)num4));
				if (ExceptionInfo.Current == null)
				{
					num4 += checked(1 + num2);
					num3++;
					continue;
				}
				goto IL_0be3;
			}
			int num21;
			if ((ulong)(uint)num4 <= (ulong)size_4io4p4d.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_0))
			{
				num21 = -1;
			}
			else
			{
				wassert.Invoke(String_bik4erc.__pointer, String_uxbkrtb.__pointer, 1745);
				if (ExceptionInfo.Current != null)
				{
					goto IL_0be3;
				}
				num21 = 0;
			}
			resize_wwmwtsa.Invoke(out_buf, (uint)(num6 + 6 + num4 + (int)((uint)(num4 + 65534) / 65535u * 5)));
			if (ExceptionInfo.Current == null)
			{
				int num22 = write_raw_block.Invoke(dst_buf_size: (int)size_4io4p4d.Invoke(out_buf) - num6, pDst: (byte*)data_efhnzgd.Invoke(out_buf) + (uint)num6, pSrc: data_efhnzgd.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_0), src_len: num4);
				if (ExceptionInfo.Current == null)
				{
					num9 = num22;
					if (num9 != 0)
					{
						num8 = num9;
						goto IL_05c0;
					}
					wassert.Invoke(String_kdrammb.__pointer, String_uxbkrtb.__pointer, 1753);
					if (ExceptionInfo.Current == null)
					{
						flag = false;
						num10 = 1;
						goto IL_0bcf;
					}
				}
			}
			goto IL_0be3;
		}
	}
}
