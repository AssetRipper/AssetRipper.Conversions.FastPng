using System.Runtime.CompilerServices;
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
		public bool Instruction_0;

		public int Instruction_1;

		public unsafe void* Instruction_2;

		public int Instruction_3;

		public int Instruction_4;

		public int Instruction_5;

		public unsafe void* Instruction_6;

		public int Instruction_7;

		public int Instruction_8;

		public int Instruction_9;

		public std_vector Instruction_10;

		public int Instruction_11;

		public unsafe void* Instruction_12;

		public unsafe void* Instruction_13;

		public unsafe void* Instruction_14;

		public int Instruction_15;

		public int Instruction_16;

		public int Instruction_17;

		public int Instruction_18;

		public unsafe void* Instruction_19;

		public unsafe void* Instruction_20;

		public int Instruction_21;

		public int Instruction_22;

		public int Instruction_23;

		public InlineArray_58_w3otm9c Instruction_24;

		public int Instruction_25;

		public int Instruction_26;
	}

	public unsafe static bool Invoke(void* pImage, int w, int h, int num_chans, void* out_buf, int flags)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		std_vector* ptr = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_10;
		InlineArray_58_w3otm9c* ptr2 = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_24;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = flags;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = out_buf;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = num_chans;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_4 = h;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_5 = w;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_6 = pImage;
		unchecked
		{
			if (!endian_check.Invoke())
			{
				wassert.Invoke(String_kdrammb.__pointer, String_uxbkrtb.__pointer, 1666);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
			}
			else if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 < 1u || (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 < 1u || (ulong)((long)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 * (long)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_4) > 4294967295uL || (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 > 16777216u || (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 > 16777216u)
			{
				wassert.Invoke(String_kdrammb.__pointer, String_uxbkrtb.__pointer, 1672);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
			}
			else
			{
				if (startFrame.GetLocalsRef<LocalVariables>().Instruction_3 == 3 || startFrame.GetLocalsRef<LocalVariables>().Instruction_3 == 4)
				{
					int instruction_ = startFrame.GetLocalsRef<LocalVariables>().Instruction_5;
					int instruction_2 = startFrame.GetLocalsRef<LocalVariables>().Instruction_3;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_ * instruction_2;
					vector_unsigned_char_class_std_allocator_unsigned_char_Constructor.Invoke(ptr);
					resize_wwmwtsa.Invoke(ptr, (uint)(checked(startFrame.GetLocalsRef<LocalVariables>().Instruction_8 + 1) * startFrame.GetLocalsRef<LocalVariables>().Instruction_4 + 7));
					if (ExceptionInfo.Current == null)
					{
						startFrame.GetLocalsRef<LocalVariables>().Instruction_11 = 0;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = 0;
						while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_4)
						{
							void* instruction_3 = startFrame.GetLocalsRef<LocalVariables>().Instruction_6;
							int instruction_4 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
							int instruction_5 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = (byte*)instruction_3 + (uint)(instruction_4 * instruction_5);
							void* instruction_6 = ((startFrame.GetLocalsRef<LocalVariables>().Instruction_9 == 0) ? null : ((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6 + (uint)((startFrame.GetLocalsRef<LocalVariables>().Instruction_9 - 1) * startFrame.GetLocalsRef<LocalVariables>().Instruction_8)));
							startFrame.GetLocalsRef<LocalVariables>().Instruction_13 = instruction_6;
							void* instruction_7 = Index_zukzlzc.Invoke(ptr, (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_11);
							startFrame.GetLocalsRef<LocalVariables>().Instruction_14 = instruction_7;
							void* instruction_8 = startFrame.GetLocalsRef<LocalVariables>().Instruction_14;
							void* instruction_9 = startFrame.GetLocalsRef<LocalVariables>().Instruction_13;
							void* instruction_10 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
							int instruction_11 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
							int instruction_12 = startFrame.GetLocalsRef<LocalVariables>().Instruction_3;
							int instruction_13 = startFrame.GetLocalsRef<LocalVariables>().Instruction_4;
							int instruction_14 = startFrame.GetLocalsRef<LocalVariables>().Instruction_5;
							bool flag = startFrame.GetLocalsRef<LocalVariables>().Instruction_9 != 0;
							_ = flag;
							apply_filter.Invoke(flag ? 2 : 0, instruction_14, instruction_13, instruction_12, instruction_11, instruction_10, instruction_9, instruction_8);
							if (ExceptionInfo.Current == null)
							{
								int num = checked(1 + startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
								int instruction_15 = startFrame.GetLocalsRef<LocalVariables>().Instruction_11;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_11 = instruction_15 + num;
								int instruction_16 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_16 + 1;
								continue;
							}
							goto IL_1756;
						}
						startFrame.GetLocalsRef<LocalVariables>().Instruction_15 = 58;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_16 = 58;
						resize_wwmwtsa.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2, (uint)((startFrame.GetLocalsRef<LocalVariables>().Instruction_16 + checked(startFrame.GetLocalsRef<LocalVariables>().Instruction_8 + 1) * startFrame.GetLocalsRef<LocalVariables>().Instruction_4 + 7) & -8));
						if (ExceptionInfo.Current == null)
						{
							startFrame.GetLocalsRef<LocalVariables>().Instruction_17 = 0;
							if ((startFrame.GetLocalsRef<LocalVariables>().Instruction_1 & 2) != 0)
							{
								goto IL_08e5;
							}
							if (startFrame.GetLocalsRef<LocalVariables>().Instruction_3 == 3)
							{
								if ((startFrame.GetLocalsRef<LocalVariables>().Instruction_1 & 1) != 0)
								{
									int instruction_17 = pixel_deflate_dyn_3_rle.Invoke(dst_buf_size: (int)size_4io4p4d.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2) - startFrame.GetLocalsRef<LocalVariables>().Instruction_16, pDst: Index_zukzlzc.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2, (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_16), h: startFrame.GetLocalsRef<LocalVariables>().Instruction_4, w: startFrame.GetLocalsRef<LocalVariables>().Instruction_5, pImg: data_efhnzgd.Invoke(ptr));
									if (ExceptionInfo.Current == null)
									{
										startFrame.GetLocalsRef<LocalVariables>().Instruction_17 = instruction_17;
										goto IL_08e5;
									}
								}
								else
								{
									int instruction_18 = pixel_deflate_dyn_3_rle_one_pass.Invoke(dst_buf_size: (int)size_4io4p4d.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2) - startFrame.GetLocalsRef<LocalVariables>().Instruction_16, pDst: Index_zukzlzc.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2, (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_16), h: startFrame.GetLocalsRef<LocalVariables>().Instruction_4, w: startFrame.GetLocalsRef<LocalVariables>().Instruction_5, pImg: data_efhnzgd.Invoke(ptr));
									if (ExceptionInfo.Current == null)
									{
										startFrame.GetLocalsRef<LocalVariables>().Instruction_17 = instruction_18;
										goto IL_08e5;
									}
								}
							}
							else if ((startFrame.GetLocalsRef<LocalVariables>().Instruction_1 & 1) != 0)
							{
								int instruction_19 = pixel_deflate_dyn_4_rle.Invoke(dst_buf_size: (int)size_4io4p4d.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2) - startFrame.GetLocalsRef<LocalVariables>().Instruction_16, pDst: Index_zukzlzc.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2, (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_16), h: startFrame.GetLocalsRef<LocalVariables>().Instruction_4, w: startFrame.GetLocalsRef<LocalVariables>().Instruction_5, pImg: data_efhnzgd.Invoke(ptr));
								if (ExceptionInfo.Current == null)
								{
									startFrame.GetLocalsRef<LocalVariables>().Instruction_17 = instruction_19;
									goto IL_08e5;
								}
							}
							else
							{
								int instruction_20 = pixel_deflate_dyn_4_rle_one_pass.Invoke(dst_buf_size: (int)size_4io4p4d.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2) - startFrame.GetLocalsRef<LocalVariables>().Instruction_16, pDst: Index_zukzlzc.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2, (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_16), h: startFrame.GetLocalsRef<LocalVariables>().Instruction_4, w: startFrame.GetLocalsRef<LocalVariables>().Instruction_5, pImg: data_efhnzgd.Invoke(ptr));
								if (ExceptionInfo.Current == null)
								{
									startFrame.GetLocalsRef<LocalVariables>().Instruction_17 = instruction_20;
									goto IL_08e5;
								}
							}
						}
					}
					goto IL_1756;
				}
				wassert.Invoke(String_kdrammb.__pointer, String_uxbkrtb.__pointer, 1678);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
			}
			goto IL_1776;
		}
		IL_0cb5:
		unchecked
		{
			if ((ulong)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_16 + startFrame.GetLocalsRef<LocalVariables>().Instruction_18) <= (ulong)size_4io4p4d.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2))
			{
				_ = -1;
			}
			else
			{
				wassert.Invoke(String_dqvhqxc.__pointer, String_uxbkrtb.__pointer, 1760);
				if (ExceptionInfo.Current != null)
				{
					goto IL_1756;
				}
				_ = 0;
			}
			resize_wwmwtsa.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2, (uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_16 + startFrame.GetLocalsRef<LocalVariables>().Instruction_18));
			if (ExceptionInfo.Current == null)
			{
				long num2 = size_4io4p4d.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2);
				startFrame.GetLocalsRef<LocalVariables>().Instruction_23 = (int)num2 - 58;
				Unsafe.As<InlineArray_58_w3otm9c, sbyte>(ref startFrame.GetLocalsRef<LocalVariables>().Instruction_24) = -119;
				((sbyte*)ptr2)[1L] = 80;
				((sbyte*)ptr2)[2L] = 78;
				((sbyte*)ptr2)[3L] = 71;
				((sbyte*)ptr2)[4L] = 13;
				((sbyte*)ptr2)[5L] = 10;
				((sbyte*)ptr2)[6L] = 26;
				((sbyte*)ptr2)[7L] = 10;
				((sbyte*)ptr2)[8L] = 0;
				((sbyte*)ptr2)[9L] = 0;
				((sbyte*)ptr2)[10L] = 0;
				((sbyte*)ptr2)[11L] = 13;
				((sbyte*)ptr2)[12L] = 73;
				((sbyte*)ptr2)[13L] = 72;
				((sbyte*)ptr2)[14L] = 68;
				((sbyte*)ptr2)[15L] = 82;
				((sbyte*)ptr2)[16L] = 0;
				((sbyte*)ptr2)[17L] = 0;
				((sbyte*)ptr2)[18L] = (sbyte)(startFrame.GetLocalsRef<LocalVariables>().Instruction_5 >>> 8);
				((sbyte*)ptr2)[19L] = (sbyte)startFrame.GetLocalsRef<LocalVariables>().Instruction_5;
				((sbyte*)ptr2)[20L] = 0;
				((sbyte*)ptr2)[21L] = 0;
				((sbyte*)ptr2)[22L] = (sbyte)(startFrame.GetLocalsRef<LocalVariables>().Instruction_4 >>> 8);
				((sbyte*)ptr2)[23L] = (sbyte)startFrame.GetLocalsRef<LocalVariables>().Instruction_4;
				((sbyte*)ptr2)[24L] = 8;
				sbyte* ptr3 = (sbyte*)ptr2 + 25L;
				int instruction_21 = startFrame.GetLocalsRef<LocalVariables>().Instruction_3;
				*ptr3 = ((sbyte*)s_color_type.__pointer)[sizeof(sbyte) * (int)(uint)instruction_21];
				((sbyte*)ptr2)[26L] = 0;
				((sbyte*)ptr2)[27L] = 0;
				((sbyte*)ptr2)[28L] = 0;
				((sbyte*)ptr2)[29L] = 0;
				((sbyte*)ptr2)[30L] = 0;
				((sbyte*)ptr2)[31L] = 0;
				((sbyte*)ptr2)[32L] = 0;
				((sbyte*)ptr2)[33L] = 0;
				((sbyte*)ptr2)[34L] = 0;
				((sbyte*)ptr2)[35L] = 0;
				((sbyte*)ptr2)[36L] = 5;
				((sbyte*)ptr2)[37L] = 102;
				((sbyte*)ptr2)[38L] = 100;
				((sbyte*)ptr2)[39L] = 69;
				((sbyte*)ptr2)[40L] = 67;
				((sbyte*)ptr2)[41L] = 82;
				((sbyte*)ptr2)[42L] = 36;
				((sbyte*)ptr2)[43L] = -109;
				((sbyte*)ptr2)[44L] = -29;
				((sbyte*)ptr2)[45L] = 0;
				((sbyte*)ptr2)[46L] = -27;
				((sbyte*)ptr2)[47L] = -85;
				((sbyte*)ptr2)[48L] = 98;
				((sbyte*)ptr2)[49L] = -103;
				((sbyte*)ptr2)[50L] = (sbyte)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 >>> 24);
				((sbyte*)ptr2)[51L] = (sbyte)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 >>> 16);
				((sbyte*)ptr2)[52L] = (sbyte)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 >>> 8);
				((sbyte*)ptr2)[53L] = (sbyte)startFrame.GetLocalsRef<LocalVariables>().Instruction_23;
				((sbyte*)ptr2)[54L] = 73;
				((sbyte*)ptr2)[55L] = 68;
				((sbyte*)ptr2)[56L] = 65;
				((sbyte*)ptr2)[57L] = 84;
				int instruction_22 = fpng_crc32.Invoke((byte*)ptr2 + sizeof(sbyte) * 0 + 12L, 17L, 0);
				if (ExceptionInfo.Current == null)
				{
					startFrame.GetLocalsRef<LocalVariables>().Instruction_25 = instruction_22;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = 0;
					while (startFrame.GetLocalsRef<LocalVariables>().Instruction_7 < 4)
					{
						int instruction_23 = startFrame.GetLocalsRef<LocalVariables>().Instruction_25;
						((byte*)ptr2 + sizeof(sbyte) * 0 + 29L)[startFrame.GetLocalsRef<LocalVariables>().Instruction_7] = (byte)(sbyte)((uint)instruction_23 >> 24);
						int instruction_24 = checked(startFrame.GetLocalsRef<LocalVariables>().Instruction_7 + 1);
						startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_24;
						int instruction_25 = startFrame.GetLocalsRef<LocalVariables>().Instruction_25;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_25 = instruction_25 << 8;
					}
					llvm_memcpy_p0_p0_i64.Invoke(data_efhnzgd.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2), (byte*)ptr2 + sizeof(sbyte) * 0, 58L, isVolatile: false);
					vector_append.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2, String_nz3h57a.__pointer, 16L);
					if (ExceptionInfo.Current == null)
					{
						int instruction_26 = fpng_crc32.Invoke(size: (uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_23 + 4), pData: (byte*)data_efhnzgd.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2) + 58L + -4L, prev_crc32: 0);
						if (ExceptionInfo.Current == null)
						{
							startFrame.GetLocalsRef<LocalVariables>().Instruction_26 = instruction_26;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = 0;
							while (startFrame.GetLocalsRef<LocalVariables>().Instruction_7 < 4)
							{
								int instruction_27 = startFrame.GetLocalsRef<LocalVariables>().Instruction_26;
								((byte*)data_efhnzgd.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2) + size_4io4p4d.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2) + -16L)[startFrame.GetLocalsRef<LocalVariables>().Instruction_7] = (byte)(sbyte)((uint)instruction_27 >> 24);
								int instruction_28 = checked(startFrame.GetLocalsRef<LocalVariables>().Instruction_7 + 1);
								startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_28;
								int instruction_29 = startFrame.GetLocalsRef<LocalVariables>().Instruction_26;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_26 = instruction_29 << 8;
							}
							startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = true;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_22 = 1;
							goto IL_174e;
						}
					}
				}
			}
			goto IL_1756;
		}
		IL_1756:
		ExceptionInfo current = ExceptionInfo.Current;
		ExceptionInfo.Current = null;
		vector_unsigned_char_class_std_allocator_unsigned_char_Destructor.Invoke(ptr);
		ExceptionInfo.Current = current;
		return false;
		IL_174e:
		vector_unsigned_char_class_std_allocator_unsigned_char_Destructor.Invoke(ptr);
		goto IL_1776;
		IL_08e5:
		int instruction_30 = startFrame.GetLocalsRef<LocalVariables>().Instruction_17;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_18 = instruction_30;
		if (startFrame.GetLocalsRef<LocalVariables>().Instruction_17 != 0)
		{
			goto IL_0cb5;
		}
		startFrame.GetLocalsRef<LocalVariables>().Instruction_11 = 0;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = 0;
		unchecked
		{
			while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_4)
			{
				void* instruction_31 = startFrame.GetLocalsRef<LocalVariables>().Instruction_6;
				int instruction_32 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
				int instruction_33 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_19 = (byte*)instruction_31 + (uint)(instruction_32 * instruction_33);
				void* instruction_34 = Index_zukzlzc.Invoke(ptr, (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_11);
				startFrame.GetLocalsRef<LocalVariables>().Instruction_20 = instruction_34;
				apply_filter.Invoke(pDst: startFrame.GetLocalsRef<LocalVariables>().Instruction_20, pSrc: startFrame.GetLocalsRef<LocalVariables>().Instruction_19, bpl: startFrame.GetLocalsRef<LocalVariables>().Instruction_8, num_chans: startFrame.GetLocalsRef<LocalVariables>().Instruction_3, h: startFrame.GetLocalsRef<LocalVariables>().Instruction_4, filter: 0, w: startFrame.GetLocalsRef<LocalVariables>().Instruction_5, pPrev_src: null);
				if (ExceptionInfo.Current == null)
				{
					int num3 = checked(1 + startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
					int instruction_35 = startFrame.GetLocalsRef<LocalVariables>().Instruction_11;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_11 = instruction_35 + num3;
					int instruction_36 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_36 + 1;
					continue;
				}
				goto IL_1756;
			}
			if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_11 <= (ulong)size_4io4p4d.Invoke(ptr))
			{
				_ = -1;
			}
			else
			{
				wassert.Invoke(String_bik4erc.__pointer, String_uxbkrtb.__pointer, 1745);
				if (ExceptionInfo.Current != null)
				{
					goto IL_1756;
				}
				_ = 0;
			}
			resize_wwmwtsa.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2, (uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_16 + 6 + startFrame.GetLocalsRef<LocalVariables>().Instruction_11 + (int)((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_11 + 65534) / 65535u * 5)));
			if (ExceptionInfo.Current == null)
			{
				int instruction_37 = write_raw_block.Invoke(dst_buf_size: (int)size_4io4p4d.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2) - startFrame.GetLocalsRef<LocalVariables>().Instruction_16, pDst: (byte*)data_efhnzgd.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_2) + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_16, src_len: startFrame.GetLocalsRef<LocalVariables>().Instruction_11, pSrc: data_efhnzgd.Invoke(ptr));
				if (ExceptionInfo.Current == null)
				{
					startFrame.GetLocalsRef<LocalVariables>().Instruction_21 = instruction_37;
					if (startFrame.GetLocalsRef<LocalVariables>().Instruction_21 != 0)
					{
						int instruction_38 = startFrame.GetLocalsRef<LocalVariables>().Instruction_21;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_18 = instruction_38;
						goto IL_0cb5;
					}
					wassert.Invoke(String_kdrammb.__pointer, String_uxbkrtb.__pointer, 1753);
					if (ExceptionInfo.Current == null)
					{
						startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_22 = 1;
						goto IL_174e;
					}
				}
			}
			goto IL_1756;
		}
		IL_1776:
		bool instruction_39 = startFrame.GetLocalsRef<LocalVariables>().Instruction_0;
		StackFrameList.Current.Clear(startFrame);
		return instruction_39;
	}
}
