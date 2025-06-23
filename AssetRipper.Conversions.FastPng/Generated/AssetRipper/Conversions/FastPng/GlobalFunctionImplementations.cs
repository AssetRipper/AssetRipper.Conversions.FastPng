using System;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.LocalVariables;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng;

internal static partial class GlobalFunctionImplementations
{
	[MangledName("?fpng_init@fpng@@YAXXZ")]
	[DemangledName("void __cdecl fpng::fpng_init(void)")]
	public static void fpng_init()
	{
	}

	[MangledName("?fpng_cpu_supports_sse41@fpng@@YA_NXZ")]
	[DemangledName("bool __cdecl fpng::fpng_cpu_supports_sse41(void)")]
	public static bool fpng_cpu_supports_sse41()
	{
		return false;
	}

	[MangledName("?fpng_crc32@fpng@@YAIPEBX_KI@Z")]
	[DemangledName("unsigned int __cdecl fpng::fpng_crc32(void const *, unsigned __int64, unsigned int)")]
	public unsafe static int fpng_crc32(void* P_0, long P_1, int P_2)
	{
		return crc32_slice_by_4(P_0, P_1, P_2);
	}

	[MangledName("?crc32_slice_by_4@fpng@@YAIPEBX_KI@Z")]
	[DemangledName("unsigned int __cdecl fpng::crc32_slice_by_4(void const *, unsigned __int64, unsigned int)")]
	public unsafe static int crc32_slice_by_4(void* P_0, long P_1, int P_2)
	{
		long num = P_1;
		int num2 = P_2 ^ -1;
		void* ptr = P_0;
		unchecked
		{
			while ((ulong)num >= 4uL)
			{
				int num3 = *(int*)ptr ^ num2;
				num2 = *(int*)((byte*)GlobalVariablePointers.g_crc32_4 + sizeof(int) * (int)(uint)(num3 >>> 24)) ^ *(int*)((byte*)GlobalVariablePointers.g_crc32_4 + sizeof(InlineArray_256_vqkfj7a) * 1 + sizeof(int) * (int)(uint)((num3 >>> 16) & 0xFF)) ^ *(int*)((byte*)GlobalVariablePointers.g_crc32_4 + sizeof(InlineArray_256_vqkfj7a) * 2 + sizeof(int) * (int)(uint)((num3 >>> 8) & 0xFF)) ^ *(int*)((byte*)GlobalVariablePointers.g_crc32_4 + sizeof(InlineArray_256_vqkfj7a) * 3 + sizeof(int) * (int)(uint)(num3 & 0xFF));
				ptr = (byte*)ptr + 4;
				num -= 4L;
			}
			void* ptr2 = ptr;
			for (; num != 0L; num += -1L)
			{
				int num4 = num2 >>> 8;
				int num5 = num2 & 0xFF;
				void* ptr3 = ptr2;
				ptr2 = (byte*)ptr3 + 1;
				sbyte b = *(sbyte*)ptr3;
				num2 = num4 ^ *(int*)((byte*)GlobalVariablePointers.g_crc32_4 + sizeof(int) * (int)(uint)(num5 ^ (byte)b));
			}
			return num2 ^ -1;
		}
	}

	[MangledName("?fpng_adler32@fpng@@YAIPEBX_KI@Z")]
	[DemangledName("unsigned int __cdecl fpng::fpng_adler32(void const *, unsigned __int64, unsigned int)")]
	public unsafe static int fpng_adler32(void* P_0, long P_1, int P_2)
	{
		return fpng_adler32_scalar(P_0, P_1, P_2);
	}

	[MangledName("?fpng_adler32_scalar@fpng@@YAIPEBE_KI@Z")]
	[DemangledName("unsigned int __cdecl fpng::fpng_adler32_scalar(unsigned char const *, unsigned __int64, unsigned int)")]
	public unsafe static int fpng_adler32_scalar(void* P_0, long P_1, int P_2)
	{
		long num = P_1;
		void* ptr = P_0;
		int num2 = P_2 & 0xFFFF;
		int num3 = P_2 >>> 16;
		unchecked
		{
			int num4 = (int)((ulong)num % 5552uL);
			int result;
			if (ptr == null)
			{
				result = 1;
			}
			else
			{
				while (num != 0L)
				{
					int i = 0;
					while ((uint)(i + 7) < (uint)num4)
					{
						num2 += (byte)(*(sbyte*)ptr);
						num3 += num2;
						num2 += (byte)((sbyte*)ptr)[1L];
						num3 += num2;
						num2 += (byte)((sbyte*)ptr)[2L];
						num3 += num2;
						num2 += (byte)((sbyte*)ptr)[3L];
						num3 += num2;
						num2 += (byte)((sbyte*)ptr)[4L];
						num3 += num2;
						num2 += (byte)((sbyte*)ptr)[5L];
						num3 += num2;
						num2 += (byte)((sbyte*)ptr)[6L];
						num3 += num2;
						num2 += (byte)((sbyte*)ptr)[7L];
						num3 += num2;
						i += 8;
						ptr = (byte*)ptr + 8L;
					}
					for (; (uint)i < (uint)num4; i++)
					{
						void* ptr2 = ptr;
						ptr = (byte*)ptr2 + 1;
						num2 += (byte)(*(sbyte*)ptr2);
						num3 += num2;
					}
					num2 = (int)((uint)num2 % 65521u);
					num3 = (int)((uint)num3 % 65521u);
					num -= (uint)num4;
					num4 = 5552;
				}
				result = (num3 << 16) + num2;
			}
			return result;
		}
	}

	[MangledName("?fpng_encode_image_to_memory@fpng@@YA_NPEBXIIIAEAV?$vector@EV?$allocator@E@std@@@std@@I@Z")]
	[DemangledName("bool __cdecl fpng::fpng_encode_image_to_memory(void const *, unsigned int, unsigned int, unsigned int, class std::vector<unsigned char, class std::allocator<unsigned char>> &, unsigned int)")]
	public unsafe static bool fpng_encode_image_to_memory(void* P_0, int P_1, int P_2, int P_3, void* P_4, int P_5)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_fpng_encode_image_to_memory>();
		std_vector* ptr = &startFrame.GetLocalsPointer<LocalVariables_fpng_encode_image_to_memory>()->Instruction_10;
		InlineArray_58_w3otm9c* ptr2 = &startFrame.GetLocalsPointer<LocalVariables_fpng_encode_image_to_memory>()->Instruction_24;
		startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_1 = P_5;
		startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_2 = P_4;
		startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_3 = P_3;
		startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_4 = P_2;
		startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_5 = P_1;
		startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_6 = P_0;
		unchecked
		{
			if (!endian_check())
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_kdrammb, GlobalVariablePointers.String_uxbkrtb, 1666);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_0 = false;
			}
			else if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_5 < 1u || (uint)startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_4 < 1u || (ulong)((long)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_5 * (long)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_4) > 4294967295uL || (uint)startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_5 > 16777216u || (uint)startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_4 > 16777216u)
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_kdrammb, GlobalVariablePointers.String_uxbkrtb, 1672);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_0 = false;
			}
			else
			{
				if (startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_3 == 3 || startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_3 == 4)
				{
					int instruction_ = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_5;
					int instruction_2 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_3;
					startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_8 = instruction_ * instruction_2;
					void* ptr3 = vector_unsigned_char_class_std_allocator_unsigned_char_Constructor(ptr);
					resize_wwmwtsa(ptr, (uint)(checked(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_8 + 1) * startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_4 + 7));
					if (ExceptionInfo.Current == null)
					{
						startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_11 = 0;
						startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_9 = 0;
						while ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_9 < (uint)startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_4)
						{
							void* instruction_3 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_6;
							int instruction_4 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_9;
							int instruction_5 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_8;
							startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_12 = (byte*)instruction_3 + (uint)(instruction_4 * instruction_5);
							void* instruction_6 = ((startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_9 == 0) ? null : ((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_6 + (uint)((startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_9 - 1) * startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_8)));
							startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_13 = instruction_6;
							void* instruction_7 = operator_zukzlzc(ptr, (uint)startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_11);
							startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_14 = instruction_7;
							void* instruction_8 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_14;
							void* instruction_9 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_13;
							void* instruction_10 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_12;
							int instruction_11 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_8;
							int instruction_12 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_3;
							int instruction_13 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_4;
							int instruction_14 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_5;
							bool flag = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_9 != 0;
							long num = (flag ? 1L : 0L);
							apply_filter(flag ? 2 : 0, instruction_14, instruction_13, instruction_12, instruction_11, instruction_10, instruction_9, instruction_8);
							if (ExceptionInfo.Current != null)
							{
								goto IL_1a33;
							}
							int num2 = checked(1 + startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_8);
							int instruction_15 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_11;
							startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_11 = instruction_15 + num2;
							int instruction_16 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_9;
							startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_9 = instruction_16 + 1;
						}
						startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_15 = 58;
						startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_16 = 58;
						resize_wwmwtsa(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_2, (uint)((startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_16 + checked(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_8 + 1) * startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_4 + 7) & -8));
						if (ExceptionInfo.Current == null)
						{
							startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_17 = 0;
							if ((startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_1 & 2) != 0)
							{
								goto IL_0932;
							}
							if (startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_3 == 3)
							{
								if ((startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_1 & 1) != 0)
								{
									int num3 = (int)size_4io4p4d(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_2) - startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_16;
									void* ptr4 = operator_zukzlzc(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_2, (uint)startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_16);
									int instruction_17 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_4;
									int instruction_18 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_5;
									int instruction_19 = pixel_deflate_dyn_3_rle(data_efhnzgd(ptr), instruction_18, instruction_17, ptr4, num3);
									if (ExceptionInfo.Current == null)
									{
										startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_17 = instruction_19;
										goto IL_0932;
									}
								}
								else
								{
									int num4 = (int)size_4io4p4d(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_2) - startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_16;
									void* ptr5 = operator_zukzlzc(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_2, (uint)startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_16);
									int instruction_20 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_4;
									int instruction_21 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_5;
									int instruction_22 = pixel_deflate_dyn_3_rle_one_pass(data_efhnzgd(ptr), instruction_21, instruction_20, ptr5, num4);
									if (ExceptionInfo.Current == null)
									{
										startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_17 = instruction_22;
										goto IL_0932;
									}
								}
							}
							else if ((startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_1 & 1) != 0)
							{
								int num5 = (int)size_4io4p4d(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_2) - startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_16;
								void* ptr6 = operator_zukzlzc(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_2, (uint)startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_16);
								int instruction_23 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_4;
								int instruction_24 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_5;
								int instruction_25 = pixel_deflate_dyn_4_rle(data_efhnzgd(ptr), instruction_24, instruction_23, ptr6, num5);
								if (ExceptionInfo.Current == null)
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_17 = instruction_25;
									goto IL_0932;
								}
							}
							else
							{
								int num6 = (int)size_4io4p4d(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_2) - startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_16;
								void* ptr7 = operator_zukzlzc(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_2, (uint)startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_16);
								int instruction_26 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_4;
								int instruction_27 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_5;
								int instruction_28 = pixel_deflate_dyn_4_rle_one_pass(data_efhnzgd(ptr), instruction_27, instruction_26, ptr7, num6);
								if (ExceptionInfo.Current == null)
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_17 = instruction_28;
									goto IL_0932;
								}
							}
						}
					}
					goto IL_1a33;
				}
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_kdrammb, GlobalVariablePointers.String_uxbkrtb, 1678);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_0 = false;
			}
			goto IL_1a54;
		}
		IL_0d35:
		unchecked
		{
			if ((ulong)(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_16 + startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_18) <= (ulong)size_4io4p4d(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_2))
			{
				bool flag2 = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_dqvhqxc, GlobalVariablePointers.String_uxbkrtb, 1760);
				if (ExceptionInfo.Current != null)
				{
					goto IL_1a33;
				}
				bool flag2 = false;
			}
			resize_wwmwtsa(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_2, (uint)(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_16 + startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_18));
			if (ExceptionInfo.Current == null)
			{
				long num7 = size_4io4p4d(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_2);
				startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_23 = (int)num7 - 58;
				Unsafe.As<InlineArray_58_w3otm9c, sbyte>(ref startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_24) = -119;
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
				((sbyte*)ptr2)[18L] = (sbyte)(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_5 >>> 8);
				((sbyte*)ptr2)[19L] = (sbyte)startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_5;
				((sbyte*)ptr2)[20L] = 0;
				((sbyte*)ptr2)[21L] = 0;
				((sbyte*)ptr2)[22L] = (sbyte)(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_4 >>> 8);
				((sbyte*)ptr2)[23L] = (sbyte)startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_4;
				((sbyte*)ptr2)[24L] = 8;
				sbyte* ptr8 = (sbyte*)ptr2 + 25L;
				int instruction_29 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_3;
				*ptr8 = ((sbyte*)GlobalVariablePointers.s_color_type)[sizeof(sbyte) * (int)(uint)instruction_29];
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
				((sbyte*)ptr2)[50L] = (sbyte)(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_23 >>> 24);
				((sbyte*)ptr2)[51L] = (sbyte)(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_23 >>> 16);
				((sbyte*)ptr2)[52L] = (sbyte)(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_23 >>> 8);
				((sbyte*)ptr2)[53L] = (sbyte)startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_23;
				((sbyte*)ptr2)[54L] = 73;
				((sbyte*)ptr2)[55L] = 68;
				((sbyte*)ptr2)[56L] = 65;
				((sbyte*)ptr2)[57L] = 84;
				int instruction_30 = fpng_crc32((byte*)ptr2 + sizeof(sbyte) * 0 + 12L, 17L, 0);
				if (ExceptionInfo.Current == null)
				{
					startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_25 = instruction_30;
					startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_7 = 0;
					while (startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_7 < 4)
					{
						int instruction_31 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_25;
						((byte*)ptr2 + sizeof(sbyte) * 0 + 29L)[startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_7] = (byte)(sbyte)((uint)instruction_31 >> 24);
						int instruction_32 = checked(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_7 + 1);
						startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_7 = instruction_32;
						int instruction_33 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_25;
						startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_25 = instruction_33 << 8;
					}
					IntrinsicFunctions.Implemented.llvm_memcpy_p0_p0_i64(data_efhnzgd(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_2), (byte*)ptr2 + sizeof(sbyte) * 0, 58L, false);
					vector_append(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_2, GlobalVariablePointers.String_nz3h57a, 16L);
					if (ExceptionInfo.Current == null)
					{
						int instruction_34 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_23;
						int instruction_35 = fpng_crc32((byte*)data_efhnzgd(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_2) + 58L + -4L, (uint)(instruction_34 + 4), 0);
						if (ExceptionInfo.Current == null)
						{
							startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_26 = instruction_35;
							startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_7 = 0;
							while (startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_7 < 4)
							{
								int instruction_36 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_26;
								((byte*)data_efhnzgd(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_2) + size_4io4p4d(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_2) + -16L)[startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_7] = (byte)(sbyte)((uint)instruction_36 >> 24);
								int instruction_37 = checked(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_7 + 1);
								startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_7 = instruction_37;
								int instruction_38 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_26;
								startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_26 = instruction_38 << 8;
							}
							startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_0 = true;
							startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_22 = 1;
							goto IL_1a2a;
						}
					}
				}
			}
			goto IL_1a33;
		}
		IL_0932:
		int instruction_39 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_17;
		startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_18 = instruction_39;
		if (startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_17 != 0)
		{
			goto IL_0d35;
		}
		startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_11 = 0;
		startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_9 = 0;
		unchecked
		{
			while ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_9 < (uint)startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_4)
			{
				void* instruction_40 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_6;
				int instruction_41 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_9;
				int instruction_42 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_8;
				startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_19 = (byte*)instruction_40 + (uint)(instruction_41 * instruction_42);
				void* instruction_43 = operator_zukzlzc(ptr, (uint)startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_11);
				startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_20 = instruction_43;
				void* instruction_44 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_20;
				void* instruction_45 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_19;
				int instruction_46 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_8;
				int instruction_47 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_3;
				int instruction_48 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_4;
				apply_filter(0, startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_5, instruction_48, instruction_47, instruction_46, instruction_45, null, instruction_44);
				if (ExceptionInfo.Current != null)
				{
					goto IL_1a33;
				}
				int num8 = checked(1 + startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_8);
				int instruction_49 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_11;
				startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_11 = instruction_49 + num8;
				int instruction_50 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_9;
				startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_9 = instruction_50 + 1;
			}
			if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_11 <= (ulong)size_4io4p4d(ptr))
			{
				bool flag3 = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_bik4erc, GlobalVariablePointers.String_uxbkrtb, 1745);
				if (ExceptionInfo.Current != null)
				{
					goto IL_1a33;
				}
				bool flag3 = false;
			}
			resize_wwmwtsa(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_2, (uint)(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_16 + 6 + startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_11 + (int)((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_11 + 65534) / 65535u * 5)));
			if (ExceptionInfo.Current == null)
			{
				int num9 = (int)size_4io4p4d(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_2) - startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_16;
				sbyte* ptr9 = (sbyte*)data_efhnzgd(startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_2) + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_16;
				int instruction_51 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_11;
				int instruction_52 = write_raw_block(data_efhnzgd(ptr), instruction_51, ptr9, num9);
				if (ExceptionInfo.Current == null)
				{
					startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_21 = instruction_52;
					if (startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_21 != 0)
					{
						int instruction_53 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_21;
						startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_18 = instruction_53;
						goto IL_0d35;
					}
					IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_kdrammb, GlobalVariablePointers.String_uxbkrtb, 1753);
					if (ExceptionInfo.Current == null)
					{
						startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_0 = false;
						startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_22 = 1;
						goto IL_1a2a;
					}
				}
			}
			goto IL_1a33;
		}
		IL_1a33:
		ExceptionInfo current = ExceptionInfo.Current;
		ExceptionInfo.Current = null;
		vector_unsigned_char_class_std_allocator_unsigned_char_Destructor(ptr);
		ExceptionInfo.Current = current;
		return false;
		IL_1a2a:
		vector_unsigned_char_class_std_allocator_unsigned_char_Destructor(ptr);
		goto IL_1a54;
		IL_1a54:
		bool instruction_54 = startFrame.GetLocalsRef<LocalVariables_fpng_encode_image_to_memory>().Instruction_0;
		StackFrameList.Current.Clear(startFrame);
		return instruction_54;
	}

	[MangledName("?endian_check@fpng@@YA_NXZ")]
	[DemangledName("bool __cdecl fpng::endian_check(void)")]
	public unsafe static bool endian_check()
	{
		int num = 0;
		int* ptr = &num;
		num = 0;
		num = 305441741;
		return unchecked((byte)(*(sbyte*)ptr)) == 205;
	}

	[MangledName("??0?$vector@EV?$allocator@E@std@@@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::vector<unsigned char, class std::allocator<unsigned char>>(void)")]
	public unsafe static void* vector_unsigned_char_class_std_allocator_unsigned_char_Constructor(void* P_0)
	{
		std_Zero_then_variadic_args_t std_Zero_then_variadic_args_t = default(std_Zero_then_variadic_args_t);
		std_Zero_then_variadic_args_t* ptr = &std_Zero_then_variadic_args_t;
		std_Fake_allocator std_Fake_allocator = default(std_Fake_allocator);
		std_Fake_allocator* ptr2 = &std_Fake_allocator;
		unchecked
		{
			void* ptr3 = Compressed_pair_class_std_allocator_unsigned_char_class_std_Vector_val_struct_std_Simple_types_unsigned_char_1_Constructor(&((std_vector*)P_0)->field_0, ptr->field_0);
			Alloc_proxy(&((std_vector*)P_0)->field_0.field_0, ptr2);
			return P_0;
		}
	}

	[MangledName("?resize@?$vector@EV?$allocator@E@std@@@std@@QEAAX_K@Z")]
	[DemangledName("public: void __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::resize(unsigned __int64)")]
	[CleanName("resize")]
	public unsafe static void resize_wwmwtsa(void* P_0, long P_1)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_resize_wwmwtsa>();
		std_Value_init_tag* ptr = &startFrame.GetLocalsPointer<LocalVariables_resize_wwmwtsa>()->Instruction_2;
		startFrame.GetLocalsRef<LocalVariables_resize_wwmwtsa>().Instruction_0 = P_1;
		startFrame.GetLocalsRef<LocalVariables_resize_wwmwtsa>().Instruction_1 = P_0;
		Resize_p4x2rua(startFrame.GetLocalsRef<LocalVariables_resize_wwmwtsa>().Instruction_1, startFrame.GetLocalsRef<LocalVariables_resize_wwmwtsa>().Instruction_0, ptr);
		if (ExceptionInfo.Current == null)
		{
			StackFrameList.Current.Clear(startFrame);
		}
	}

	[MangledName("??A?$vector@EV?$allocator@E@std@@@std@@QEAAAEAE_K@Z")]
	[DemangledName("public: unsigned char & __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::operator[](unsigned __int64)")]
	[CleanName("operator")]
	public unsafe static void* operator_zukzlzc(void* P_0, long P_1)
	{
		return unchecked((byte*)((std_vector*)P_0)->field_0.field_0.field_0) + P_1;
	}

	[MangledName("?apply_filter@fpng@@YAXIHHIIPEBE0PEAE@Z")]
	[DemangledName("void __cdecl fpng::apply_filter(unsigned int, int, int, unsigned int, unsigned int, unsigned char const *, unsigned char const *, unsigned char *)")]
	public unsafe static void apply_filter(int P_0, int P_1, int P_2, int P_3, int P_4, void* P_5, void* P_6, void* P_7)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_apply_filter>();
		startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_0 = P_7;
		startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_1 = P_6;
		startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_2 = P_5;
		startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_3 = P_4;
		startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_4 = P_3;
		startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_5 = P_2;
		startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_6 = P_1;
		startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_7 = P_0;
		unchecked
		{
			switch (startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_7)
			{
			case 0:
			{
				void* instruction_10 = startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_0;
				startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_0 = (byte*)instruction_10 + 1;
				*(sbyte*)instruction_10 = 0;
				IntrinsicFunctions.Implemented.llvm_memcpy_p0_p0_i64(startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_0, startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_2, (uint)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_3, false);
				break;
			}
			case 2:
			{
				if (startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_1 != null)
				{
					bool flag = true;
				}
				else
				{
					IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_uc52kza, GlobalVariablePointers.String_uxbkrtb, 1607);
					if (ExceptionInfo.Current != null)
					{
						return;
					}
					bool flag = false;
				}
				void* instruction_ = startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_0;
				startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_0 = (byte*)instruction_ + 1;
				*(sbyte*)instruction_ = 2;
				if (startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_4 == 3)
				{
					startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_8 = 0;
					while ((uint)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_8 < (uint)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_6)
					{
						int num;
						checked
						{
							num = unchecked((byte)(*(sbyte*)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_2)) - unchecked((byte)(*(sbyte*)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_1));
						}
						*(sbyte*)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_0 = (sbyte)num;
						int num2;
						checked
						{
							num2 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_2)[1L]) - unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_1)[1L]);
						}
						((sbyte*)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_0)[1L] = (sbyte)num2;
						int num3;
						checked
						{
							num3 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_2)[2L]) - unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_1)[2L]);
						}
						((sbyte*)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_0)[2L] = (sbyte)num3;
						void* instruction_2 = startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_2;
						startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_2 = (byte*)instruction_2 + 3L;
						void* instruction_3 = startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_1;
						startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_1 = (byte*)instruction_3 + 3L;
						void* instruction_4 = startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_0;
						startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_0 = (byte*)instruction_4 + 3L;
						int instruction_5 = startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_8 = instruction_5 + 1;
					}
					break;
				}
				startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_9 = 0;
				while ((uint)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_9 < (uint)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_6)
				{
					int num4;
					checked
					{
						num4 = unchecked((byte)(*(sbyte*)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_2)) - unchecked((byte)(*(sbyte*)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_1));
					}
					*(sbyte*)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_0 = (sbyte)num4;
					int num5;
					checked
					{
						num5 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_2)[1L]) - unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_1)[1L]);
					}
					((sbyte*)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_0)[1L] = (sbyte)num5;
					int num6;
					checked
					{
						num6 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_2)[2L]) - unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_1)[2L]);
					}
					((sbyte*)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_0)[2L] = (sbyte)num6;
					int num7;
					checked
					{
						num7 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_2)[3L]) - unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_1)[3L]);
					}
					((sbyte*)startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_0)[3L] = (sbyte)num7;
					void* instruction_6 = startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_2;
					startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_2 = (byte*)instruction_6 + 4L;
					void* instruction_7 = startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_1;
					startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_1 = (byte*)instruction_7 + 4L;
					void* instruction_8 = startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_0;
					startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_0 = (byte*)instruction_8 + 4L;
					int instruction_9 = startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_9;
					startFrame.GetLocalsRef<LocalVariables_apply_filter>().Instruction_9 = instruction_9 + 1;
				}
				break;
			}
			default:
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_kdrammb, GlobalVariablePointers.String_uxbkrtb, 1657);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				break;
			}
			StackFrameList.Current.Clear(startFrame);
		}
	}

	[MangledName("?pixel_deflate_dyn_3_rle@fpng@@YAIPEBEIIPEAEI@Z")]
	[DemangledName("unsigned int __cdecl fpng::pixel_deflate_dyn_3_rle(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int)")]
	public unsafe static int pixel_deflate_dyn_3_rle(void* P_0, int P_1, int P_2, void* P_3, int P_4)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_pixel_deflate_dyn_3_rle>();
		long* ptr = &startFrame.GetLocalsPointer<LocalVariables_pixel_deflate_dyn_3_rle>()->Instruction_7;
		int* ptr2 = &startFrame.GetLocalsPointer<LocalVariables_pixel_deflate_dyn_3_rle>()->Instruction_8;
		int* ptr3 = &startFrame.GetLocalsPointer<LocalVariables_pixel_deflate_dyn_3_rle>()->Instruction_9;
		std_vector_0* ptr4 = &startFrame.GetLocalsPointer<LocalVariables_pixel_deflate_dyn_3_rle>()->Instruction_16;
		std_allocator_2* ptr5 = &startFrame.GetLocalsPointer<LocalVariables_pixel_deflate_dyn_3_rle>()->Instruction_17;
		InlineArray_288_vqkfj7a* ptr6 = &startFrame.GetLocalsPointer<LocalVariables_pixel_deflate_dyn_3_rle>()->Instruction_19;
		fpng_defl_huff* ptr7 = &startFrame.GetLocalsPointer<LocalVariables_pixel_deflate_dyn_3_rle>()->Instruction_34;
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_1 = P_4;
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_2 = P_3;
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_3 = P_2;
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_4 = P_1;
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_5 = P_0;
		int instruction_ = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_4;
		unchecked
		{
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_6 = 1 + instruction_ * 3;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7 = 0L;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 = 0;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_9 = 0;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_10 = 120;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_11 = 8;
			if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_11 >= 0u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_11 <= 16u)
			{
				bool flag = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_9hewgtd, GlobalVariablePointers.String_uxbkrtb, 1002);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				bool flag = false;
			}
			if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_10 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_11))
			{
				bool flag2 = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1002);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				bool flag2 = false;
			}
			long num = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_10 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8);
			long instruction_2 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7 = instruction_2 | num;
			int instruction_3 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_11;
			int instruction_4 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 = instruction_4 + instruction_3;
			if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 <= 64)
			{
				bool flag3 = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1002);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				bool flag3 = false;
			}
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_12 = 1;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_13 = 8;
			if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_13 >= 0u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_13 <= 16u)
			{
				bool flag4 = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_9hewgtd, GlobalVariablePointers.String_uxbkrtb, 1003);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				bool flag4 = false;
			}
			if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_12 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_13))
			{
				bool flag5 = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1003);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				bool flag5 = false;
			}
			long num2 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_12 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8);
			long instruction_5 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7 = instruction_5 | num2;
			int instruction_6 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_13;
			int instruction_7 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 = instruction_7 + instruction_6;
			if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 <= 64)
			{
				bool flag6 = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1003);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				bool flag6 = false;
			}
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_14 = 1;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_15 = 1;
			if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_15 >= 0u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_15 <= 16u)
			{
				bool flag7 = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_9hewgtd, GlobalVariablePointers.String_uxbkrtb, 1006);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				bool flag7 = false;
			}
			if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_14 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_15))
			{
				bool flag8 = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1006);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				bool flag8 = false;
			}
			long num3 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_14 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8);
			long instruction_8 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7 = instruction_8 | num3;
			int instruction_9 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_15;
			int instruction_10 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 = instruction_10 + instruction_9;
			if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 <= 64)
			{
				bool flag9 = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1006);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				bool flag9 = false;
			}
			void* ptr8 = allocator_unsigned_int_Constructor(ptr5);
			void* ptr9 = vector_unsigned_int_class_std_allocator_unsigned_int_Constructor(ptr4, (uint)((startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_4 + 1) * startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_3), ptr5);
			if (ExceptionInfo.Current != null)
			{
				return 0;
			}
			void* instruction_11 = data_uf9yj3b(ptr4);
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_18 = instruction_11;
			IntrinsicFunctions.Implemented.llvm_memset_p0_i64((byte*)ptr6 + sizeof(int) * 0, 0, 1152L, false);
			void* instruction_12 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_5;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_20 = instruction_12;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_21 = 0;
			int instruction_13 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_6;
			int instruction_14 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_3;
			int instruction_15 = fpng_adler32(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_5, (uint)(instruction_13 * instruction_14), 1);
			if (ExceptionInfo.Current == null)
			{
				startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_22 = instruction_15;
				startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_23 = 2;
				startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_24 = 0;
				while (true)
				{
					if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_24 < (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_3)
					{
						int instruction_16 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_21;
						int instruction_17 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_6;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_25 = instruction_16 + instruction_17;
						void* instruction_18 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_20;
						int instruction_19 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_21;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_21 = instruction_19 + 1;
						sbyte b = ((sbyte*)instruction_18)[(uint)instruction_19];
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_26 = (byte)b;
						int num4 = 1 | (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_26 << 8);
						void* instruction_20 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_18;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_18 = (byte*)instruction_20 + 4;
						*(int*)instruction_20 = num4;
						(*(int*)((byte*)ptr6 + sizeof(int) * (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_26))++;
						int instruction_21 = READ_RGB_PIXEL((byte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_20 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_21);
						if (ExceptionInfo.Current != null)
						{
							break;
						}
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_28 = instruction_21;
						int num5 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_28 << 8;
						void* instruction_22 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_18;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_18 = (byte*)instruction_22 + 4;
						*(int*)instruction_22 = num5;
						(*(int*)((byte*)ptr6 + sizeof(int) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_28 & 0xFF)))++;
						(*(int*)((byte*)ptr6 + sizeof(int) * (int)(uint)((startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_28 >>> 8) & 0xFF)))++;
						(*(int*)((byte*)ptr6 + sizeof(int) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_28 >>> 16)))++;
						int instruction_23 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_21;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_21 = instruction_23 + 3;
						int instruction_24 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_28;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_27 = instruction_24;
						while ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_21 < (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_25)
						{
							int instruction_25 = READ_RGB_PIXEL((byte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_20 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_21);
							if (ExceptionInfo.Current != null)
							{
								goto end_IL_07b2;
							}
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_29 = instruction_25;
							if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_29 == startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_27)
							{
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_30 = 3;
								int instruction_26 = minimum_ymfg3kb(255, startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_25 - startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_21);
								if (ExceptionInfo.Current != null)
								{
									goto end_IL_07b2;
								}
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_31 = instruction_26;
								while ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_30 < (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_31)
								{
									int num6 = READ_RGB_PIXEL((byte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_20 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_21 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_30);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_07b2;
									}
									if (num6 != startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_29)
									{
										break;
									}
									int instruction_27 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_30;
									startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_30 = instruction_27 + 3;
								}
								int num7 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_30 - 1;
								void* instruction_28 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_18;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_18 = (byte*)instruction_28 + 4;
								*(int*)instruction_28 = num7;
								int instruction_29 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_30;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_32 = instruction_29 - 3;
								int instruction_30 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_32;
								(*(int*)((byte*)ptr6 + sizeof(int) * (ushort)(*(short*)((byte*)GlobalVariablePointers.g_defl_len_sym + sizeof(short) * (int)(uint)instruction_30))))++;
								int instruction_31 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_30;
								int instruction_32 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_21;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_21 = instruction_32 + instruction_31;
							}
							else
							{
								int num8 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_29 << 8;
								void* instruction_33 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_18;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_18 = (byte*)instruction_33 + 4;
								*(int*)instruction_33 = num8;
								(*(int*)((byte*)ptr6 + sizeof(int) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_29 & 0xFF)))++;
								(*(int*)((byte*)ptr6 + sizeof(int) * (int)(uint)((startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_29 >>> 8) & 0xFF)))++;
								(*(int*)((byte*)ptr6 + sizeof(int) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_29 >>> 16)))++;
								int instruction_34 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_29;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_27 = instruction_34;
								int instruction_35 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_21;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_21 = instruction_35 + 3;
							}
						}
						int instruction_36 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_24;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_24 = instruction_36 + 1;
						continue;
					}
					if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_21 == startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_3 * startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_6)
					{
						bool flag10 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_bjvsuxc, GlobalVariablePointers.String_uxbkrtb, 1086);
						if (ExceptionInfo.Current != null)
						{
							break;
						}
						bool flag10 = false;
					}
					long num9 = ((long)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_18 - (long)data_uf9yj3b(ptr4)) / 4L;
					startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_33 = (int)num9;
					if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_33 <= (ulong)size_wtrvsgc(ptr4))
					{
						bool flag11 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_hsgehfc, GlobalVariablePointers.String_uxbkrtb, 1088);
						if (ExceptionInfo.Current != null)
						{
							break;
						}
						bool flag11 = false;
					}
					*(int*)((byte*)ptr6 + sizeof(int) * 256) = 1;
					adjust_freq32(288, (byte*)ptr6 + sizeof(int) * 0, (byte*)(&ptr7->field_0) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * 0);
					if (ExceptionInfo.Current != null)
					{
						break;
					}
					IntrinsicFunctions.Implemented.llvm_memset_p0_i64((byte*)(&ptr7->field_0) + sizeof(InlineArray_288_oeds4ea) * 1 + sizeof(short) * 0, 0, 64L, false);
					*(short*)((byte*)(&ptr7->field_0) + sizeof(InlineArray_288_oeds4ea) * 1 + sizeof(short) * 2) = 1;
					*(short*)((byte*)(&ptr7->field_0) + sizeof(InlineArray_288_oeds4ea) * 1 + sizeof(short) * 3) = 1;
					int instruction_37 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_1;
					bool flag12 = defl_start_dynamic_block(ptr7, startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_2, ptr3, instruction_37, ptr, ptr2);
					if (ExceptionInfo.Current != null)
					{
						break;
					}
					if (!flag12)
					{
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_0 = 0;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_35 = 1;
					}
					else
					{
						if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 <= 7)
						{
							bool flag13 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_vpte4cc, GlobalVariablePointers.String_uxbkrtb, 1103);
							if (ExceptionInfo.Current != null)
							{
								break;
							}
							bool flag13 = false;
						}
						if ((ushort)(*(short*)((byte*)(&ptr7->field_1) + sizeof(InlineArray_288_oeds4ea) * 1 + sizeof(short) * 2)) == 0 && ((byte*)(&ptr7->field_2) + sizeof(InlineArray_288_w3otm9c) * 1)[sizeof(sbyte) * 2] == 1)
						{
							bool flag14 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_df5ko9b, GlobalVariablePointers.String_uxbkrtb, 1104);
							if (ExceptionInfo.Current != null)
							{
								break;
							}
							bool flag14 = false;
						}
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_36 = 0;
						while ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_36 < (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_33)
						{
							int instruction_38 = *(int*)operator_2nyjhmb(ptr4, (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_36);
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_37 = instruction_38;
							int instruction_39 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_37;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_38 = instruction_39 & 0xFF;
							if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_38 == 0)
							{
								int instruction_40 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_37;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_39 = instruction_40 >>> 8;
								short num10 = *(short*)((byte*)(&ptr7->field_1) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_39 & 0xFF));
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_40 = (ushort)num10;
								sbyte b2 = (sbyte)((byte*)(&ptr7->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_39 & 0xFF)];
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_41 = (byte)b2;
								if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_41 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_41 <= 16u)
								{
									bool flag15 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1115);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_07b2;
									}
									bool flag15 = false;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_40 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_41))
								{
									bool flag16 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1115);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_07b2;
									}
									bool flag16 = false;
								}
								long num11 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_40 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8);
								long instruction_41 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7 = instruction_41 | num11;
								int instruction_42 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_41;
								int instruction_43 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 = instruction_43 + instruction_42;
								if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 <= 64)
								{
									bool flag17 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1115);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_07b2;
									}
									bool flag17 = false;
								}
								int instruction_44 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_39;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_39 = instruction_44 >>> 8;
								short num12 = *(short*)((byte*)(&ptr7->field_1) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_39 & 0xFF));
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_42 = (ushort)num12;
								sbyte b3 = (sbyte)((byte*)(&ptr7->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_39 & 0xFF)];
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_43 = (byte)b3;
								if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_43 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_43 <= 16u)
								{
									bool flag18 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1118);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_07b2;
									}
									bool flag18 = false;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_42 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_43))
								{
									bool flag19 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1118);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_07b2;
									}
									bool flag19 = false;
								}
								long num13 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_42 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8);
								long instruction_45 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7 = instruction_45 | num13;
								int instruction_46 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_43;
								int instruction_47 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 = instruction_47 + instruction_46;
								if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 <= 64)
								{
									bool flag20 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1118);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_07b2;
									}
									bool flag20 = false;
								}
								int instruction_48 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_39;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_39 = instruction_48 >>> 8;
								short num14 = *(short*)((byte*)(&ptr7->field_1) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_39);
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_44 = (ushort)num14;
								sbyte b4 = (sbyte)((byte*)(&ptr7->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_39];
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_45 = (byte)b4;
								if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_45 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_45 <= 16u)
								{
									bool flag21 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1121);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_07b2;
									}
									bool flag21 = false;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_44 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_45))
								{
									bool flag22 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1121);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_07b2;
									}
									bool flag22 = false;
								}
								long num15 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_44 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8);
								long instruction_49 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7 = instruction_49 | num15;
								int instruction_50 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_45;
								int instruction_51 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 = instruction_51 + instruction_50;
								if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 <= 64)
								{
									bool flag23 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1121);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_07b2;
									}
									bool flag23 = false;
								}
							}
							else if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_38 == 1)
							{
								int instruction_52 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_37;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_46 = instruction_52 >>> 8;
								short num16 = *(short*)((byte*)(&ptr7->field_1) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_46);
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_47 = (ushort)num16;
								sbyte b5 = (sbyte)((byte*)(&ptr7->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_46];
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_48 = (byte)b5;
								if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_48 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_48 <= 16u)
								{
									bool flag24 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1126);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_07b2;
									}
									bool flag24 = false;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_47 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_48))
								{
									bool flag25 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1126);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_07b2;
									}
									bool flag25 = false;
								}
								long num17 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_47 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8);
								long instruction_53 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7 = instruction_53 | num17;
								int instruction_54 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_48;
								int instruction_55 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 = instruction_55 + instruction_54;
								if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 <= 64)
								{
									bool flag26 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1126);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_07b2;
									}
									bool flag26 = false;
								}
							}
							else
							{
								int instruction_56 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_38;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_49 = instruction_56 + 1;
								int instruction_57 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_49;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_50 = instruction_57 - 3;
								InlineArray_288_oeds4ea* ptr10 = (InlineArray_288_oeds4ea*)((byte*)(&ptr7->field_1) + sizeof(InlineArray_288_oeds4ea) * 0);
								int instruction_58 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_50;
								short num18 = *(short*)((byte*)ptr10 + sizeof(short) * (ushort)(*(short*)((byte*)GlobalVariablePointers.g_defl_len_sym + sizeof(short) * (int)(uint)instruction_58)));
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_51 = (ushort)num18;
								InlineArray_288_w3otm9c* ptr11 = (InlineArray_288_w3otm9c*)((byte*)(&ptr7->field_2) + sizeof(InlineArray_288_w3otm9c) * 0);
								int instruction_59 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_50;
								sbyte b6 = ((sbyte*)ptr11)[sizeof(sbyte) * (ushort)(*(short*)((byte*)GlobalVariablePointers.g_defl_len_sym + sizeof(short) * (int)(uint)instruction_59))];
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_52 = (byte)b6;
								if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_52 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_52 <= 16u)
								{
									bool flag27 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1134);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_07b2;
									}
									bool flag27 = false;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_51 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_52))
								{
									bool flag28 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1134);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_07b2;
									}
									bool flag28 = false;
								}
								long num19 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_51 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8);
								long instruction_60 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7 = instruction_60 | num19;
								int instruction_61 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_52;
								int instruction_62 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 = instruction_62 + instruction_61;
								if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 <= 64)
								{
									bool flag29 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1134);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_07b2;
									}
									bool flag29 = false;
								}
								int instruction_63 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_50;
								int instruction_64 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_50;
								sbyte b7 = ((sbyte*)GlobalVariablePointers.g_defl_len_extra)[sizeof(sbyte) * (int)(uint)instruction_64];
								int num20 = *(int*)((byte*)GlobalVariablePointers.g_bitmasks + sizeof(int) * (byte)b7);
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_53 = instruction_63 & num20;
								int instruction_65 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_50;
								checked
								{
									int instruction_66 = unchecked((byte)((sbyte*)GlobalVariablePointers.g_defl_len_extra)[sizeof(sbyte) * (int)(uint)instruction_65]) + 1;
									startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_54 = instruction_66;
								}
								if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_54 >= 0u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_54 <= 16u)
								{
									bool flag30 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_9hewgtd, GlobalVariablePointers.String_uxbkrtb, 1135);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_07b2;
									}
									bool flag30 = false;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_53 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_54))
								{
									bool flag31 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1135);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_07b2;
									}
									bool flag31 = false;
								}
								long num21 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_53 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8);
								long instruction_67 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7 = instruction_67 | num21;
								int instruction_68 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_54;
								int instruction_69 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 = instruction_69 + instruction_68;
								if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 <= 64)
								{
									bool flag32 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1135);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_07b2;
									}
									bool flag32 = false;
								}
							}
							if ((uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_9 + 8) <= (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_1)
							{
								long instruction_70 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7;
								*(long*)((byte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_2 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_9) = instruction_70;
								int instruction_71 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_55 = instruction_71 & -8;
								int num22 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_55 >>> 3;
								int instruction_72 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_9 = instruction_72 + num22;
								if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_55 < 64u)
								{
									bool flag33 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_2ej5tjb, GlobalVariablePointers.String_uxbkrtb, 1142);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_07b2;
									}
									bool flag33 = false;
								}
								long instruction_73 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7;
								int instruction_74 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_55;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7 = instruction_73 >>> (int)(uint)instruction_74;
								int instruction_75 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_55;
								int instruction_76 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 = instruction_76 - instruction_75;
								int instruction_77 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_36;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_36 = instruction_77 + 1;
								continue;
							}
							goto IL_2aa0;
						}
						short num23 = *(short*)((byte*)(&ptr7->field_1) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * 256);
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_56 = (ushort)num23;
						sbyte b8 = (sbyte)((byte*)(&ptr7->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * 256];
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_57 = (byte)b8;
						if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_57 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_57 <= 16u)
						{
							bool flag34 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1145);
							if (ExceptionInfo.Current != null)
							{
								break;
							}
							bool flag34 = false;
						}
						if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_56 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_57))
						{
							bool flag35 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1145);
							if (ExceptionInfo.Current != null)
							{
								break;
							}
							bool flag35 = false;
						}
						long num24 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_56 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8);
						long instruction_78 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7 = instruction_78 | num24;
						int instruction_79 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_57;
						int instruction_80 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 = instruction_80 + instruction_79;
						if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 <= 64)
						{
							bool flag36 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1145);
							if (ExceptionInfo.Current != null)
							{
								break;
							}
							bool flag36 = false;
						}
						while (true)
						{
							if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 > 0)
							{
								if ((uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_9 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_1)
								{
									startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_0 = 0;
									startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_35 = 1;
									break;
								}
								long instruction_81 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7;
								((sbyte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_9] = (sbyte)instruction_81;
								int instruction_82 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_9 = instruction_82 + 1;
								long instruction_83 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_7 = instruction_83 >>> 8;
								int instruction_84 = checked(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 - 8);
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_8 = instruction_84;
								continue;
							}
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_58 = 0;
							while (true)
							{
								if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_58 < 4u)
								{
									if ((uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_9 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_1)
									{
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_0 = 0;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_35 = 1;
										break;
									}
									int instruction_85 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_22;
									((sbyte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_9] = (sbyte)(instruction_85 >>> 24);
									int instruction_86 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_9;
									startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_9 = instruction_86 + 1;
									int instruction_87 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_22;
									startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_22 = instruction_87 << 8;
									int instruction_88 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_58;
									startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_58 = instruction_88 + 1;
									continue;
								}
								int instruction_89 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_0 = instruction_89;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_35 = 1;
								break;
							}
							break;
						}
					}
					goto IL_330f;
					IL_330f:
					vector_unsigned_int_class_std_allocator_unsigned_int_Destructor(ptr4);
					int instruction_90 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_0;
					StackFrameList.Current.Clear(startFrame);
					return instruction_90;
					IL_2aa0:
					startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_0 = 0;
					startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle>().Instruction_35 = 1;
					goto IL_330f;
					continue;
					end_IL_07b2:
					break;
				}
			}
			ExceptionInfo current = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			vector_unsigned_int_class_std_allocator_unsigned_int_Destructor(ptr4);
			ExceptionInfo.Current = current;
			return 0;
		}
	}

	[MangledName("?size@?$vector@EV?$allocator@E@std@@@std@@QEBA_KXZ")]
	[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::size(void) const")]
	[CleanName("size")]
	public unsafe static long size_4io4p4d(void* P_0)
	{
		unchecked
		{
			void* field_ = &((std_vector*)P_0)->field_0.field_0;
			return (long)((std_Vector_val*)field_)->field_1 - (long)((std_Vector_val*)field_)->field_0;
		}
	}

	[MangledName("?data@?$vector@EV?$allocator@E@std@@@std@@QEAAPEAEXZ")]
	[DemangledName("public: unsigned char * __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::data(void)")]
	[CleanName("data")]
	public unsafe static void* data_efhnzgd(void* P_0)
	{
		return Unfancy_maybe_null_pj5f7cb(unchecked((std_vector*)P_0)->field_0.field_0.field_0);
	}

	[MangledName("?pixel_deflate_dyn_3_rle_one_pass@fpng@@YAIPEBEIIPEAEI@Z")]
	[DemangledName("unsigned int __cdecl fpng::pixel_deflate_dyn_3_rle_one_pass(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int)")]
	public unsafe static int pixel_deflate_dyn_3_rle_one_pass(void* P_0, int P_1, int P_2, void* P_3, int P_4)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>();
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_1 = P_4;
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_2 = P_3;
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_3 = P_2;
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_4 = P_1;
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_5 = P_0;
		int instruction_ = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_4;
		unchecked
		{
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_6 = 1 + instruction_ * 3;
			if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_1 < 62uL)
			{
				startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_0 = 0;
			}
			else
			{
				IntrinsicFunctions.Implemented.llvm_memcpy_p0_p0_i64(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_2, GlobalVariablePointers.g_dyn_huff_3, 62L, false);
				startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_7 = 62;
				startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8 = 30L;
				startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 = 7;
				void* instruction_2 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_5;
				startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_10 = instruction_2;
				startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_11 = 0;
				int instruction_3 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_6;
				int instruction_4 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_3;
				int instruction_5 = fpng_adler32(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_5, (uint)(instruction_3 * instruction_4), 1);
				startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_12 = instruction_5;
				startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_13 = 0;
				while (true)
				{
					if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_13 < (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_3)
					{
						int instruction_6 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_11;
						int instruction_7 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_6;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_14 = instruction_6 + instruction_7;
						void* instruction_8 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_10;
						int instruction_9 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_11;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_11 = instruction_9 + 1;
						sbyte b = ((sbyte*)instruction_8)[(uint)instruction_9];
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_15 = (byte)b;
						int instruction_10 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_15;
						short field_ = ((anon*)((byte*)GlobalVariablePointers.g_dyn_huff_3_codes + sizeof(anon) * (int)(uint)instruction_10))->field_1;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_16 = (ushort)field_;
						int instruction_11 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_15;
						sbyte field_2 = ((anon*)((byte*)GlobalVariablePointers.g_dyn_huff_3_codes + sizeof(anon) * (int)(uint)instruction_11))->field_0;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_17 = (byte)field_2;
						if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_17 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_17 <= 16u)
						{
							bool flag = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1187);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag = false;
						}
						if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_16 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_17))
						{
							bool flag2 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1187);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag2 = false;
						}
						long num = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_16 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9);
						long instruction_12 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8 = instruction_12 | num;
						int instruction_13 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_17;
						int instruction_14 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 = instruction_14 + instruction_13;
						if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 <= 64)
						{
							bool flag3 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1187);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag3 = false;
						}
						int instruction_15 = READ_RGB_PIXEL((byte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_10 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_11);
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_19 = instruction_15;
						int instruction_16 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_19;
						short field_3 = ((anon*)((byte*)GlobalVariablePointers.g_dyn_huff_3_codes + sizeof(anon) * (int)(uint)(instruction_16 & 0xFF)))->field_1;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_20 = (ushort)field_3;
						int instruction_17 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_19;
						sbyte field_4 = ((anon*)((byte*)GlobalVariablePointers.g_dyn_huff_3_codes + sizeof(anon) * (int)(uint)(instruction_17 & 0xFF)))->field_0;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_21 = (byte)field_4;
						if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_21 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_21 <= 16u)
						{
							bool flag4 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1194);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag4 = false;
						}
						if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_20 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_21))
						{
							bool flag5 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1194);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag5 = false;
						}
						long num2 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_20 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9);
						long instruction_18 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8 = instruction_18 | num2;
						int instruction_19 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_21;
						int instruction_20 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 = instruction_20 + instruction_19;
						if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 <= 64)
						{
							bool flag6 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1194);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag6 = false;
						}
						int instruction_21 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_19;
						short field_5 = ((anon*)((byte*)GlobalVariablePointers.g_dyn_huff_3_codes + sizeof(anon) * (int)(uint)((instruction_21 >>> 8) & 0xFF)))->field_1;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_22 = (ushort)field_5;
						int instruction_22 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_19;
						sbyte field_6 = ((anon*)((byte*)GlobalVariablePointers.g_dyn_huff_3_codes + sizeof(anon) * (int)(uint)((instruction_22 >>> 8) & 0xFF)))->field_0;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_23 = (byte)field_6;
						if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_23 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_23 <= 16u)
						{
							bool flag7 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1195);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag7 = false;
						}
						if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_22 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_23))
						{
							bool flag8 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1195);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag8 = false;
						}
						long num3 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_22 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9);
						long instruction_23 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8 = instruction_23 | num3;
						int instruction_24 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_23;
						int instruction_25 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 = instruction_25 + instruction_24;
						if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 <= 64)
						{
							bool flag9 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1195);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag9 = false;
						}
						int instruction_26 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_19;
						short field_7 = ((anon*)((byte*)GlobalVariablePointers.g_dyn_huff_3_codes + sizeof(anon) * (int)(uint)(instruction_26 >>> 16)))->field_1;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_24 = (ushort)field_7;
						int instruction_27 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_19;
						sbyte field_8 = ((anon*)((byte*)GlobalVariablePointers.g_dyn_huff_3_codes + sizeof(anon) * (int)(uint)(instruction_27 >>> 16)))->field_0;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_25 = (byte)field_8;
						if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_25 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_25 <= 16u)
						{
							bool flag10 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1196);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag10 = false;
						}
						if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_24 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_25))
						{
							bool flag11 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1196);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag11 = false;
						}
						long num4 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_24 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9);
						long instruction_28 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8 = instruction_28 | num4;
						int instruction_29 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_25;
						int instruction_30 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 = instruction_30 + instruction_29;
						if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 <= 64)
						{
							bool flag12 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1196);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag12 = false;
						}
						int instruction_31 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_11;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_11 = instruction_31 + 3;
						int instruction_32 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_19;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_18 = instruction_32;
						if ((uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_7 + 8) > (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_1)
						{
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_0 = 0;
							break;
						}
						long instruction_33 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8;
						*(long*)((byte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_2 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_7) = instruction_33;
						int instruction_34 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_26 = instruction_34 & -8;
						int num5 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_26 >>> 3;
						int instruction_35 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_7;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_7 = instruction_35 + num5;
						if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_26 < 64u)
						{
							bool flag13 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_2ej5tjb, GlobalVariablePointers.String_uxbkrtb, 1203);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag13 = false;
						}
						long instruction_36 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8;
						int instruction_37 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_26;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8 = instruction_36 >>> (int)(uint)instruction_37;
						int instruction_38 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_26;
						int instruction_39 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 = instruction_39 - instruction_38;
						while ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_11 < (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_14)
						{
							int instruction_40 = READ_RGB_PIXEL((byte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_10 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_11);
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_27 = instruction_40;
							if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_27 == startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_18)
							{
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_28 = 3;
								int instruction_41 = minimum_ymfg3kb(255, startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_14 - startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_11);
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_29 = instruction_41;
								while ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_28 < (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_29 && READ_RGB_PIXEL((byte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_10 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_11 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_28) == startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_27)
								{
									int instruction_42 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_28;
									startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_28 = instruction_42 + 3;
								}
								int instruction_43 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_28;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_30 = instruction_43 - 3;
								int instruction_44 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_30;
								short num6 = *(short*)((byte*)GlobalVariablePointers.g_defl_len_sym + sizeof(short) * (int)(uint)instruction_44);
								short field_9 = ((anon*)((byte*)GlobalVariablePointers.g_dyn_huff_3_codes + sizeof(anon) * (ushort)num6))->field_1;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_31 = (ushort)field_9;
								int instruction_45 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_30;
								short num7 = *(short*)((byte*)GlobalVariablePointers.g_defl_len_sym + sizeof(short) * (int)(uint)instruction_45);
								sbyte field_10 = ((anon*)((byte*)GlobalVariablePointers.g_dyn_huff_3_codes + sizeof(anon) * (ushort)num7))->field_0;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_32 = (byte)field_10;
								if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_32 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_32 <= 16u)
								{
									bool flag14 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1223);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									bool flag14 = false;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_31 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_32))
								{
									bool flag15 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1223);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									bool flag15 = false;
								}
								long num8 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_31 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9);
								long instruction_46 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8 = instruction_46 | num8;
								int instruction_47 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_32;
								int instruction_48 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 = instruction_48 + instruction_47;
								if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 <= 64)
								{
									bool flag16 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1223);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									bool flag16 = false;
								}
								int instruction_49 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_30;
								int instruction_50 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_30;
								sbyte b2 = ((sbyte*)GlobalVariablePointers.g_defl_len_extra)[sizeof(sbyte) * (int)(uint)instruction_50];
								int num9 = *(int*)((byte*)GlobalVariablePointers.g_bitmasks + sizeof(int) * (byte)b2);
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_33 = instruction_49 & num9;
								int instruction_51 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_30;
								checked
								{
									int instruction_52 = unchecked((byte)((sbyte*)GlobalVariablePointers.g_defl_len_extra)[sizeof(sbyte) * (int)(uint)instruction_51]) + 1;
									startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_34 = instruction_52;
								}
								if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_34 >= 0u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_34 <= 16u)
								{
									bool flag17 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_9hewgtd, GlobalVariablePointers.String_uxbkrtb, 1224);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									bool flag17 = false;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_33 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_34))
								{
									bool flag18 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1224);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									bool flag18 = false;
								}
								long num10 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_33 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9);
								long instruction_53 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8 = instruction_53 | num10;
								int instruction_54 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_34;
								int instruction_55 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 = instruction_55 + instruction_54;
								if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 <= 64)
								{
									bool flag19 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1224);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									bool flag19 = false;
								}
								int instruction_56 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_28;
								int instruction_57 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_11;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_11 = instruction_57 + instruction_56;
							}
							else
							{
								int instruction_58 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_27;
								short field_11 = ((anon*)((byte*)GlobalVariablePointers.g_dyn_huff_3_codes + sizeof(anon) * (int)(uint)(instruction_58 & 0xFF)))->field_1;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_35 = (ushort)field_11;
								int instruction_59 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_27;
								sbyte field_12 = ((anon*)((byte*)GlobalVariablePointers.g_dyn_huff_3_codes + sizeof(anon) * (int)(uint)(instruction_59 & 0xFF)))->field_0;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_36 = (byte)field_12;
								if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_36 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_36 <= 16u)
								{
									bool flag20 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1230);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									bool flag20 = false;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_35 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_36))
								{
									bool flag21 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1230);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									bool flag21 = false;
								}
								long num11 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_35 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9);
								long instruction_60 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8 = instruction_60 | num11;
								int instruction_61 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_36;
								int instruction_62 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 = instruction_62 + instruction_61;
								if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 <= 64)
								{
									bool flag22 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1230);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									bool flag22 = false;
								}
								int instruction_63 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_27;
								short field_13 = ((anon*)((byte*)GlobalVariablePointers.g_dyn_huff_3_codes + sizeof(anon) * (int)(uint)((instruction_63 >>> 8) & 0xFF)))->field_1;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_37 = (ushort)field_13;
								int instruction_64 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_27;
								sbyte field_14 = ((anon*)((byte*)GlobalVariablePointers.g_dyn_huff_3_codes + sizeof(anon) * (int)(uint)((instruction_64 >>> 8) & 0xFF)))->field_0;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_38 = (byte)field_14;
								if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_38 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_38 <= 16u)
								{
									bool flag23 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1231);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									bool flag23 = false;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_37 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_38))
								{
									bool flag24 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1231);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									bool flag24 = false;
								}
								long num12 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_37 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9);
								long instruction_65 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8 = instruction_65 | num12;
								int instruction_66 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_38;
								int instruction_67 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 = instruction_67 + instruction_66;
								if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 <= 64)
								{
									bool flag25 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1231);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									bool flag25 = false;
								}
								int instruction_68 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_27;
								short field_15 = ((anon*)((byte*)GlobalVariablePointers.g_dyn_huff_3_codes + sizeof(anon) * (int)(uint)(instruction_68 >>> 16)))->field_1;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_39 = (ushort)field_15;
								int instruction_69 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_27;
								sbyte field_16 = ((anon*)((byte*)GlobalVariablePointers.g_dyn_huff_3_codes + sizeof(anon) * (int)(uint)(instruction_69 >>> 16)))->field_0;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_40 = (byte)field_16;
								if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_40 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_40 <= 16u)
								{
									bool flag26 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1232);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									bool flag26 = false;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_39 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_40))
								{
									bool flag27 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1232);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									bool flag27 = false;
								}
								long num13 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_39 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9);
								long instruction_70 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8 = instruction_70 | num13;
								int instruction_71 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_40;
								int instruction_72 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 = instruction_72 + instruction_71;
								if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 <= 64)
								{
									bool flag28 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1232);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									bool flag28 = false;
								}
								int instruction_73 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_27;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_18 = instruction_73;
								int instruction_74 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_11;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_11 = instruction_74 + 3;
							}
							if ((uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_7 + 8) <= (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_1)
							{
								long instruction_75 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8;
								*(long*)((byte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_2 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_7) = instruction_75;
								int instruction_76 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_41 = instruction_76 & -8;
								int num14 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_41 >>> 3;
								int instruction_77 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_7 = instruction_77 + num14;
								if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_41 < 64u)
								{
									bool flag29 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_2ej5tjb, GlobalVariablePointers.String_uxbkrtb, 1239);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									bool flag29 = false;
								}
								long instruction_78 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8;
								int instruction_79 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_41;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8 = instruction_78 >>> (int)(uint)instruction_79;
								int instruction_80 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_41;
								int instruction_81 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 = instruction_81 - instruction_80;
								continue;
							}
							goto IL_2096;
						}
						int instruction_82 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_13;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_13 = instruction_82 + 1;
						continue;
					}
					if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_11 == startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_3 * startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_6)
					{
						bool flag30 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_bjvsuxc, GlobalVariablePointers.String_uxbkrtb, 1245);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						bool flag30 = false;
					}
					if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 <= 7)
					{
						bool flag31 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_vpte4cc, GlobalVariablePointers.String_uxbkrtb, 1247);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						bool flag31 = false;
					}
					startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_42 = 2303;
					startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_43 = 12;
					if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_43 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_43 <= 16u)
					{
						bool flag32 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1249);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						bool flag32 = false;
					}
					if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_42 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_43))
					{
						bool flag33 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1249);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						bool flag33 = false;
					}
					long num15 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_42 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9);
					long instruction_83 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8;
					startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8 = instruction_83 | num15;
					int instruction_84 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_43;
					int instruction_85 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9;
					startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 = instruction_85 + instruction_84;
					if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 <= 64)
					{
						bool flag34 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1249);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						bool flag34 = false;
					}
					while (true)
					{
						if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 > 0)
						{
							if ((uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_7 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_1)
							{
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_0 = 0;
								break;
							}
							long instruction_86 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8;
							((sbyte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_7] = (sbyte)instruction_86;
							int instruction_87 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_7;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_7 = instruction_87 + 1;
							long instruction_88 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_8 = instruction_88 >>> 8;
							int instruction_89 = checked(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 - 8);
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_9 = instruction_89;
							continue;
						}
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_44 = 0;
						while (true)
						{
							if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_44 < 4u)
							{
								if ((uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_7 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_1)
								{
									startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_0 = 0;
									break;
								}
								int instruction_90 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_12;
								((sbyte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_7] = (sbyte)(instruction_90 >>> 24);
								int instruction_91 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_7 = instruction_91 + 1;
								int instruction_92 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_12;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_12 = instruction_92 << 8;
								int instruction_93 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_44;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_44 = instruction_93 + 1;
								continue;
							}
							int instruction_94 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_7;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_0 = instruction_94;
							break;
						}
						break;
					}
					break;
					IL_2096:
					startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_0 = 0;
					break;
				}
			}
			int instruction_95 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_3_rle_one_pass>().Instruction_0;
			StackFrameList.Current.Clear(startFrame);
			return instruction_95;
		}
	}

	[MangledName("?pixel_deflate_dyn_4_rle@fpng@@YAIPEBEIIPEAEI@Z")]
	[DemangledName("unsigned int __cdecl fpng::pixel_deflate_dyn_4_rle(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int)")]
	public unsafe static int pixel_deflate_dyn_4_rle(void* P_0, int P_1, int P_2, void* P_3, int P_4)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_pixel_deflate_dyn_4_rle>();
		long* ptr = &startFrame.GetLocalsPointer<LocalVariables_pixel_deflate_dyn_4_rle>()->Instruction_7;
		int* ptr2 = &startFrame.GetLocalsPointer<LocalVariables_pixel_deflate_dyn_4_rle>()->Instruction_8;
		int* ptr3 = &startFrame.GetLocalsPointer<LocalVariables_pixel_deflate_dyn_4_rle>()->Instruction_9;
		std_vector_5* ptr4 = &startFrame.GetLocalsPointer<LocalVariables_pixel_deflate_dyn_4_rle>()->Instruction_16;
		InlineArray_288_vqkfj7a* ptr5 = &startFrame.GetLocalsPointer<LocalVariables_pixel_deflate_dyn_4_rle>()->Instruction_18;
		fpng_defl_huff* ptr6 = &startFrame.GetLocalsPointer<LocalVariables_pixel_deflate_dyn_4_rle>()->Instruction_33;
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_1 = P_4;
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_2 = P_3;
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_3 = P_2;
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_4 = P_1;
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_5 = P_0;
		int instruction_ = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_4;
		unchecked
		{
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_6 = 1 + instruction_ * 4;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7 = 0L;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 = 0;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_9 = 0;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_10 = 120;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_11 = 8;
			if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_11 >= 0u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_11 <= 16u)
			{
				bool flag = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_9hewgtd, GlobalVariablePointers.String_uxbkrtb, 1279);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				bool flag = false;
			}
			if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_10 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_11))
			{
				bool flag2 = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1279);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				bool flag2 = false;
			}
			long num = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_10 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8);
			long instruction_2 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7 = instruction_2 | num;
			int instruction_3 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_11;
			int instruction_4 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 = instruction_4 + instruction_3;
			if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 <= 64)
			{
				bool flag3 = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1279);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				bool flag3 = false;
			}
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_12 = 1;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_13 = 8;
			if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_13 >= 0u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_13 <= 16u)
			{
				bool flag4 = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_9hewgtd, GlobalVariablePointers.String_uxbkrtb, 1280);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				bool flag4 = false;
			}
			if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_12 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_13))
			{
				bool flag5 = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1280);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				bool flag5 = false;
			}
			long num2 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_12 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8);
			long instruction_5 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7 = instruction_5 | num2;
			int instruction_6 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_13;
			int instruction_7 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 = instruction_7 + instruction_6;
			if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 <= 64)
			{
				bool flag6 = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1280);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				bool flag6 = false;
			}
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_14 = 1;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_15 = 1;
			if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_15 >= 0u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_15 <= 16u)
			{
				bool flag7 = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_9hewgtd, GlobalVariablePointers.String_uxbkrtb, 1283);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				bool flag7 = false;
			}
			if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_14 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_15))
			{
				bool flag8 = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1283);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				bool flag8 = false;
			}
			long num3 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_14 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8);
			long instruction_8 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7 = instruction_8 | num3;
			int instruction_9 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_15;
			int instruction_10 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8;
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 = instruction_10 + instruction_9;
			if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 <= 64)
			{
				bool flag9 = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1283);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				bool flag9 = false;
			}
			void* ptr7 = vector_unsigned_int64_class_std_allocator_unsigned_int64_Constructor(ptr4);
			resize_d4pmvud(ptr4, (uint)((startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_4 + 1) * startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_3));
			if (ExceptionInfo.Current == null)
			{
				void* instruction_11 = data_dtgl25a(ptr4);
				startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_17 = instruction_11;
				IntrinsicFunctions.Implemented.llvm_memset_p0_i64((byte*)ptr5 + sizeof(int) * 0, 0, 1152L, false);
				void* instruction_12 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_5;
				startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_19 = instruction_12;
				startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_20 = 0;
				int instruction_13 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_6;
				int instruction_14 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_3;
				int instruction_15 = fpng_adler32(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_5, (uint)(instruction_13 * instruction_14), 1);
				if (ExceptionInfo.Current == null)
				{
					startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_21 = instruction_15;
					startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_22 = 3;
					startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_23 = 0;
					while ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_23 < (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_3)
					{
						int instruction_16 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_20;
						int instruction_17 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_6;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_24 = instruction_16 + instruction_17;
						void* instruction_18 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_19;
						int instruction_19 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_20;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_20 = instruction_19 + 1;
						sbyte b = ((sbyte*)instruction_18)[(uint)instruction_19];
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_25 = (byte)b;
						long num4 = (uint)(1 | (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_25 << 8));
						void* instruction_20 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_17;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_17 = (byte*)instruction_20 + 8;
						*(long*)instruction_20 = num4;
						(*(int*)((byte*)ptr5 + sizeof(int) * (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_25))++;
						int instruction_21 = *(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_19 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_20);
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_27 = instruction_21;
						long num5 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_27 << 8);
						void* instruction_22 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_17;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_17 = (byte*)instruction_22 + 8;
						*(long*)instruction_22 = num5;
						(*(int*)((byte*)ptr5 + sizeof(int) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_27 & 0xFF)))++;
						(*(int*)((byte*)ptr5 + sizeof(int) * (int)(uint)((startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_27 >>> 8) & 0xFF)))++;
						(*(int*)((byte*)ptr5 + sizeof(int) * (int)(uint)((startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_27 >>> 16) & 0xFF)))++;
						(*(int*)((byte*)ptr5 + sizeof(int) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_27 >>> 24)))++;
						int instruction_23 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_20;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_20 = instruction_23 + 4;
						int instruction_24 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_27;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_26 = instruction_24;
						while ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_20 < (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_24)
						{
							int instruction_25 = *(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_19 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_20);
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_28 = instruction_25;
							if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_28 == startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_26)
							{
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_29 = 4;
								int instruction_26 = minimum_ymfg3kb(252, startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_24 - startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_20);
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_30 = instruction_26;
								while ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_29 < (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_30 && *(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_19 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_20 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_29) == startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_28)
								{
									int instruction_27 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_29;
									startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_29 = instruction_27 + 4;
								}
								long num6 = (uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_29 - 1);
								void* instruction_28 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_17;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_17 = (byte*)instruction_28 + 8;
								*(long*)instruction_28 = num6;
								int instruction_29 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_29;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_31 = instruction_29 - 3;
								int instruction_30 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_31;
								(*(int*)((byte*)ptr5 + sizeof(int) * (ushort)(*(short*)((byte*)GlobalVariablePointers.g_defl_len_sym + sizeof(short) * (int)(uint)instruction_30))))++;
								int instruction_31 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_29;
								int instruction_32 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_20;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_20 = instruction_32 + instruction_31;
							}
							else
							{
								long num7 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_28 << 8);
								void* instruction_33 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_17;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_17 = (byte*)instruction_33 + 8;
								*(long*)instruction_33 = num7;
								(*(int*)((byte*)ptr5 + sizeof(int) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_28 & 0xFF)))++;
								(*(int*)((byte*)ptr5 + sizeof(int) * (int)(uint)((startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_28 >>> 8) & 0xFF)))++;
								(*(int*)((byte*)ptr5 + sizeof(int) * (int)(uint)((startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_28 >>> 16) & 0xFF)))++;
								(*(int*)((byte*)ptr5 + sizeof(int) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_28 >>> 24)))++;
								int instruction_34 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_28;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_26 = instruction_34;
								int instruction_35 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_20;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_20 = instruction_35 + 4;
							}
						}
						int instruction_36 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_23;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_23 = instruction_36 + 1;
					}
					if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_20 == startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_3 * startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_6)
					{
						bool flag10 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_bjvsuxc, GlobalVariablePointers.String_uxbkrtb, 1365);
						if (ExceptionInfo.Current != null)
						{
							goto IL_39e0;
						}
						bool flag10 = false;
					}
					long num8 = ((long)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_17 - (long)data_dtgl25a(ptr4)) / 8L;
					startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_32 = (int)num8;
					if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_32 <= (ulong)size_trt5i3d(ptr4))
					{
						bool flag11 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_hsgehfc, GlobalVariablePointers.String_uxbkrtb, 1367);
						if (ExceptionInfo.Current != null)
						{
							goto IL_39e0;
						}
						bool flag11 = false;
					}
					*(int*)((byte*)ptr5 + sizeof(int) * 256) = 1;
					adjust_freq32(288, (byte*)ptr5 + sizeof(int) * 0, (byte*)(&ptr6->field_0) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * 0);
					if (ExceptionInfo.Current == null)
					{
						IntrinsicFunctions.Implemented.llvm_memset_p0_i64((byte*)(&ptr6->field_0) + sizeof(InlineArray_288_oeds4ea) * 1 + sizeof(short) * 0, 0, 64L, false);
						*(short*)((byte*)(&ptr6->field_0) + sizeof(InlineArray_288_oeds4ea) * 1 + sizeof(short) * 3) = 1;
						*(short*)((byte*)(&ptr6->field_0) + sizeof(InlineArray_288_oeds4ea) * 1 + sizeof(short) * 4) = 1;
						int instruction_37 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_1;
						bool flag12 = defl_start_dynamic_block(ptr6, startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_2, ptr3, instruction_37, ptr, ptr2);
						if (ExceptionInfo.Current == null)
						{
							if (!flag12)
							{
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_0 = 0;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_34 = 1;
							}
							else
							{
								if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 <= 7)
								{
									bool flag13 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_vpte4cc, GlobalVariablePointers.String_uxbkrtb, 1382);
									if (ExceptionInfo.Current != null)
									{
										goto IL_39e0;
									}
									bool flag13 = false;
								}
								if ((ushort)(*(short*)((byte*)(&ptr6->field_1) + sizeof(InlineArray_288_oeds4ea) * 1 + sizeof(short) * 3)) == 0 && ((byte*)(&ptr6->field_2) + sizeof(InlineArray_288_w3otm9c) * 1)[sizeof(sbyte) * 3] == 1)
								{
									bool flag14 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_df5ko9b, GlobalVariablePointers.String_uxbkrtb, 1383);
									if (ExceptionInfo.Current != null)
									{
										goto IL_39e0;
									}
									bool flag14 = false;
								}
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_35 = 0;
								long instruction_84;
								int instruction_85;
								int instruction_86;
								int instruction_87;
								int instruction_88;
								for (; (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_35 < (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_32; instruction_84 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7, instruction_85 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_57, startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7 = instruction_84 >>> (int)(uint)instruction_85, instruction_86 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_57, instruction_87 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8, startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 = instruction_87 - instruction_86, instruction_88 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_35, startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_35 = instruction_88 + 1)
								{
									long instruction_38 = *(long*)operator_7d577ub(ptr4, (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_35);
									startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_36 = instruction_38;
									long instruction_39 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_36;
									startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_37 = (int)(instruction_39 & 0xFFL);
									if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_37 == 0)
									{
										long instruction_40 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_36;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_38 = (int)(instruction_40 >>> 8);
										short num9 = *(short*)((byte*)(&ptr6->field_1) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_38 & 0xFF));
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_39 = (ushort)num9;
										sbyte b2 = (sbyte)((byte*)(&ptr6->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_38 & 0xFF)];
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_40 = (byte)b2;
										if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_40 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_40 <= 16u)
										{
											bool flag15 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1394);
											if (ExceptionInfo.Current != null)
											{
												goto IL_39e0;
											}
											bool flag15 = false;
										}
										if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_39 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_40))
										{
											bool flag16 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1394);
											if (ExceptionInfo.Current != null)
											{
												goto IL_39e0;
											}
											bool flag16 = false;
										}
										long num10 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_39 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8);
										long instruction_41 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7 = instruction_41 | num10;
										int instruction_42 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_40;
										int instruction_43 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 = instruction_43 + instruction_42;
										if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 <= 64)
										{
											bool flag17 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1394);
											if (ExceptionInfo.Current != null)
											{
												goto IL_39e0;
											}
											bool flag17 = false;
										}
										int instruction_44 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_38;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_38 = instruction_44 >>> 8;
										short num11 = *(short*)((byte*)(&ptr6->field_1) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_38 & 0xFF));
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_41 = (ushort)num11;
										sbyte b3 = (sbyte)((byte*)(&ptr6->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_38 & 0xFF)];
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_42 = (byte)b3;
										if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_42 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_42 <= 16u)
										{
											bool flag18 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1397);
											if (ExceptionInfo.Current != null)
											{
												goto IL_39e0;
											}
											bool flag18 = false;
										}
										if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_41 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_42))
										{
											bool flag19 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1397);
											if (ExceptionInfo.Current != null)
											{
												goto IL_39e0;
											}
											bool flag19 = false;
										}
										long num12 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_41 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8);
										long instruction_45 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7 = instruction_45 | num12;
										int instruction_46 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_42;
										int instruction_47 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 = instruction_47 + instruction_46;
										if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 <= 64)
										{
											bool flag20 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1397);
											if (ExceptionInfo.Current != null)
											{
												goto IL_39e0;
											}
											bool flag20 = false;
										}
										int instruction_48 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_38;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_38 = instruction_48 >>> 8;
										short num13 = *(short*)((byte*)(&ptr6->field_1) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_38 & 0xFF));
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_43 = (ushort)num13;
										sbyte b4 = (sbyte)((byte*)(&ptr6->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_38 & 0xFF)];
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_44 = (byte)b4;
										if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_44 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_44 <= 16u)
										{
											bool flag21 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1400);
											if (ExceptionInfo.Current != null)
											{
												goto IL_39e0;
											}
											bool flag21 = false;
										}
										if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_43 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_44))
										{
											bool flag22 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1400);
											if (ExceptionInfo.Current != null)
											{
												goto IL_39e0;
											}
											bool flag22 = false;
										}
										long num14 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_43 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8);
										long instruction_49 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7 = instruction_49 | num14;
										int instruction_50 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_44;
										int instruction_51 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 = instruction_51 + instruction_50;
										if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 <= 64)
										{
											bool flag23 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1400);
											if (ExceptionInfo.Current != null)
											{
												goto IL_39e0;
											}
											bool flag23 = false;
										}
										int instruction_52 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_38;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_38 = instruction_52 >>> 8;
										if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 >= 49)
										{
											if ((uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_9 + 8) > (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_1)
											{
												goto IL_2103;
											}
											long instruction_53 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7;
											*(long*)((byte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_2 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_9) = instruction_53;
											int instruction_54 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8;
											startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_45 = instruction_54 & -8;
											int num15 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_45 >>> 3;
											int instruction_55 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_9;
											startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_9 = instruction_55 + num15;
											if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_45 < 64u)
											{
												bool flag24 = true;
											}
											else
											{
												IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_2ej5tjb, GlobalVariablePointers.String_uxbkrtb, 1405);
												if (ExceptionInfo.Current != null)
												{
													goto IL_39e0;
												}
												bool flag24 = false;
											}
											long instruction_56 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7;
											int instruction_57 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_45;
											startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7 = instruction_56 >>> (int)(uint)instruction_57;
											int instruction_58 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_45;
											int instruction_59 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8;
											startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 = instruction_59 - instruction_58;
										}
										short num16 = *(short*)((byte*)(&ptr6->field_1) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_38);
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_46 = (ushort)num16;
										sbyte b5 = (sbyte)((byte*)(&ptr6->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_38];
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_47 = (byte)b5;
										if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_47 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_47 <= 16u)
										{
											bool flag25 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1408);
											if (ExceptionInfo.Current != null)
											{
												goto IL_39e0;
											}
											bool flag25 = false;
										}
										if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_46 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_47))
										{
											bool flag26 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1408);
											if (ExceptionInfo.Current != null)
											{
												goto IL_39e0;
											}
											bool flag26 = false;
										}
										long num17 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_46 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8);
										long instruction_60 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7 = instruction_60 | num17;
										int instruction_61 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_47;
										int instruction_62 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 = instruction_62 + instruction_61;
										if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 <= 64)
										{
											bool flag27 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1408);
											if (ExceptionInfo.Current != null)
											{
												goto IL_39e0;
											}
											bool flag27 = false;
										}
									}
									else if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_37 == 1)
									{
										long instruction_63 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_36;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_48 = (int)(instruction_63 >>> 8);
										short num18 = *(short*)((byte*)(&ptr6->field_1) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_48);
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_49 = (ushort)num18;
										sbyte b6 = (sbyte)((byte*)(&ptr6->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_48];
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_50 = (byte)b6;
										if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_50 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_50 <= 16u)
										{
											bool flag28 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1413);
											if (ExceptionInfo.Current != null)
											{
												goto IL_39e0;
											}
											bool flag28 = false;
										}
										if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_49 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_50))
										{
											bool flag29 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1413);
											if (ExceptionInfo.Current != null)
											{
												goto IL_39e0;
											}
											bool flag29 = false;
										}
										long num19 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_49 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8);
										long instruction_64 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7 = instruction_64 | num19;
										int instruction_65 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_50;
										int instruction_66 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 = instruction_66 + instruction_65;
										if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 <= 64)
										{
											bool flag30 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1413);
											if (ExceptionInfo.Current != null)
											{
												goto IL_39e0;
											}
											bool flag30 = false;
										}
									}
									else
									{
										int instruction_67 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_37;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_51 = instruction_67 + 1;
										int instruction_68 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_51;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_52 = instruction_68 - 3;
										InlineArray_288_oeds4ea* ptr8 = (InlineArray_288_oeds4ea*)((byte*)(&ptr6->field_1) + sizeof(InlineArray_288_oeds4ea) * 0);
										int instruction_69 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_52;
										short num20 = *(short*)((byte*)ptr8 + sizeof(short) * (ushort)(*(short*)((byte*)GlobalVariablePointers.g_defl_len_sym + sizeof(short) * (int)(uint)instruction_69)));
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_53 = (ushort)num20;
										InlineArray_288_w3otm9c* ptr9 = (InlineArray_288_w3otm9c*)((byte*)(&ptr6->field_2) + sizeof(InlineArray_288_w3otm9c) * 0);
										int instruction_70 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_52;
										sbyte b7 = ((sbyte*)ptr9)[sizeof(sbyte) * (ushort)(*(short*)((byte*)GlobalVariablePointers.g_defl_len_sym + sizeof(short) * (int)(uint)instruction_70))];
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_54 = (byte)b7;
										if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_54 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_54 <= 16u)
										{
											bool flag31 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1421);
											if (ExceptionInfo.Current != null)
											{
												goto IL_39e0;
											}
											bool flag31 = false;
										}
										if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_53 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_54))
										{
											bool flag32 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1421);
											if (ExceptionInfo.Current != null)
											{
												goto IL_39e0;
											}
											bool flag32 = false;
										}
										long num21 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_53 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8);
										long instruction_71 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7 = instruction_71 | num21;
										int instruction_72 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_54;
										int instruction_73 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 = instruction_73 + instruction_72;
										if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 <= 64)
										{
											bool flag33 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1421);
											if (ExceptionInfo.Current != null)
											{
												goto IL_39e0;
											}
											bool flag33 = false;
										}
										int instruction_74 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_52;
										int instruction_75 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_52;
										sbyte b8 = ((sbyte*)GlobalVariablePointers.g_defl_len_extra)[sizeof(sbyte) * (int)(uint)instruction_75];
										int num22 = *(int*)((byte*)GlobalVariablePointers.g_bitmasks + sizeof(int) * (byte)b8);
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_55 = instruction_74 & num22;
										int instruction_76 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_52;
										checked
										{
											int instruction_77 = unchecked((byte)((sbyte*)GlobalVariablePointers.g_defl_len_extra)[sizeof(sbyte) * (int)(uint)instruction_76]) + 1;
											startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_56 = instruction_77;
										}
										if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_56 >= 0u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_56 <= 16u)
										{
											bool flag34 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_9hewgtd, GlobalVariablePointers.String_uxbkrtb, 1422);
											if (ExceptionInfo.Current != null)
											{
												goto IL_39e0;
											}
											bool flag34 = false;
										}
										if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_55 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_56))
										{
											bool flag35 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1422);
											if (ExceptionInfo.Current != null)
											{
												goto IL_39e0;
											}
											bool flag35 = false;
										}
										long num23 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_55 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8);
										long instruction_78 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7 = instruction_78 | num23;
										int instruction_79 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_56;
										int instruction_80 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 = instruction_80 + instruction_79;
										if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 <= 64)
										{
											bool flag36 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1422);
											if (ExceptionInfo.Current != null)
											{
												goto IL_39e0;
											}
											bool flag36 = false;
										}
									}
									if ((uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_9 + 8) > (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_1)
									{
										goto IL_3149;
									}
									long instruction_81 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7;
									*(long*)((byte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_2 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_9) = instruction_81;
									int instruction_82 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8;
									startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_57 = instruction_82 & -8;
									int num24 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_57 >>> 3;
									int instruction_83 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_9;
									startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_9 = instruction_83 + num24;
									bool flag37;
									if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_57 < 64u)
									{
										flag37 = true;
										continue;
									}
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_2ej5tjb, GlobalVariablePointers.String_uxbkrtb, 1428);
									if (ExceptionInfo.Current != null)
									{
										goto IL_39e0;
									}
									flag37 = false;
								}
								short num25 = *(short*)((byte*)(&ptr6->field_1) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * 256);
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_58 = (ushort)num25;
								sbyte b9 = (sbyte)((byte*)(&ptr6->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * 256];
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_59 = (byte)b9;
								if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_59 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_59 <= 16u)
								{
									bool flag38 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1431);
									if (ExceptionInfo.Current != null)
									{
										goto IL_39e0;
									}
									bool flag38 = false;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_58 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_59))
								{
									bool flag39 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1431);
									if (ExceptionInfo.Current != null)
									{
										goto IL_39e0;
									}
									bool flag39 = false;
								}
								long num26 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_58 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8);
								long instruction_89 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7 = instruction_89 | num26;
								int instruction_90 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_59;
								int instruction_91 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 = instruction_91 + instruction_90;
								if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 <= 64)
								{
									bool flag40 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1431);
									if (ExceptionInfo.Current != null)
									{
										goto IL_39e0;
									}
									bool flag40 = false;
								}
								while (true)
								{
									if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 > 0)
									{
										if ((uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_9 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_1)
										{
											startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_0 = 0;
											startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_34 = 1;
											break;
										}
										long instruction_92 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7;
										((sbyte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_9] = (sbyte)instruction_92;
										int instruction_93 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_9;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_9 = instruction_93 + 1;
										long instruction_94 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_7 = instruction_94 >>> 8;
										int instruction_95 = checked(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 - 8);
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_8 = instruction_95;
										continue;
									}
									startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_60 = 0;
									while (true)
									{
										if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_60 < 4u)
										{
											if ((uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_9 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_1)
											{
												startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_0 = 0;
												startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_34 = 1;
												break;
											}
											int instruction_96 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_21;
											((sbyte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_9] = (sbyte)(instruction_96 >>> 24);
											int instruction_97 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_9;
											startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_9 = instruction_97 + 1;
											int instruction_98 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_21;
											startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_21 = instruction_98 << 8;
											int instruction_99 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_60;
											startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_60 = instruction_99 + 1;
											continue;
										}
										int instruction_100 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_9;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_0 = instruction_100;
										startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_34 = 1;
										break;
									}
									break;
								}
							}
							goto IL_39b8;
						}
					}
				}
			}
			goto IL_39e0;
		}
		IL_39e0:
		ExceptionInfo current = ExceptionInfo.Current;
		ExceptionInfo.Current = null;
		vector_unsigned_int64_class_std_allocator_unsigned_int64_Destructor(ptr4);
		ExceptionInfo.Current = current;
		return 0;
		IL_2103:
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_0 = 0;
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_34 = 1;
		goto IL_39b8;
		IL_39b8:
		vector_unsigned_int64_class_std_allocator_unsigned_int64_Destructor(ptr4);
		int instruction_101 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_0;
		StackFrameList.Current.Clear(startFrame);
		return instruction_101;
		IL_3149:
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_0 = 0;
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle>().Instruction_34 = 1;
		goto IL_39b8;
	}

	[MangledName("?pixel_deflate_dyn_4_rle_one_pass@fpng@@YAIPEBEIIPEAEI@Z")]
	[DemangledName("unsigned int __cdecl fpng::pixel_deflate_dyn_4_rle_one_pass(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int)")]
	public unsafe static int pixel_deflate_dyn_4_rle_one_pass(void* P_0, int P_1, int P_2, void* P_3, int P_4)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>();
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_1 = P_4;
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_2 = P_3;
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_3 = P_2;
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_4 = P_1;
		startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_5 = P_0;
		int instruction_ = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_4;
		unchecked
		{
			startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_6 = 1 + instruction_ * 4;
			if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_1 < 61uL)
			{
				startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_0 = 0;
			}
			else
			{
				IntrinsicFunctions.Implemented.llvm_memcpy_p0_p0_i64(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_2, GlobalVariablePointers.g_dyn_huff_4, 61L, false);
				startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7 = 61;
				startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8 = 1L;
				startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 = 2;
				void* instruction_2 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_5;
				startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_10 = instruction_2;
				startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_11 = 0;
				int instruction_3 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_6;
				int instruction_4 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_3;
				int instruction_5 = fpng_adler32(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_5, (uint)(instruction_3 * instruction_4), 1);
				startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_12 = instruction_5;
				startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_13 = 0;
				while (true)
				{
					if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_13 < (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_3)
					{
						int instruction_6 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_11;
						int instruction_7 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_6;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_14 = instruction_6 + instruction_7;
						void* instruction_8 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_10;
						int instruction_9 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_11;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_11 = instruction_9 + 1;
						sbyte b = ((sbyte*)instruction_8)[(uint)instruction_9];
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_15 = (byte)b;
						int instruction_10 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_15;
						short field_ = ((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (int)(uint)instruction_10))->field_1;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_16 = (ushort)field_;
						int instruction_11 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_15;
						sbyte field_2 = ((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (int)(uint)instruction_11))->field_0;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_17 = (byte)field_2;
						if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_17 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_17 <= 16u)
						{
							bool flag = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1473);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag = false;
						}
						if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_16 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_17))
						{
							bool flag2 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1473);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag2 = false;
						}
						long num = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_16 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9);
						long instruction_12 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8 = instruction_12 | num;
						int instruction_13 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_17;
						int instruction_14 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 = instruction_14 + instruction_13;
						if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 <= 64)
						{
							bool flag3 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1473);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag3 = false;
						}
						if ((uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7 + 8) > (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_1)
						{
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_0 = 0;
							break;
						}
						long instruction_15 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
						*(long*)((byte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_2 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7) = instruction_15;
						int instruction_16 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_18 = instruction_16 & -8;
						int num2 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_18 >>> 3;
						int instruction_17 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7 = instruction_17 + num2;
						if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_18 < 64u)
						{
							bool flag4 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_2ej5tjb, GlobalVariablePointers.String_uxbkrtb, 1475);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag4 = false;
						}
						long instruction_18 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
						int instruction_19 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_18;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8 = instruction_18 >>> (int)(uint)instruction_19;
						int instruction_20 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_18;
						int instruction_21 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 = instruction_21 - instruction_20;
						int instruction_22 = *(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_10 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_11);
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_20 = instruction_22;
						int instruction_23 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_20;
						short field_3 = ((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (int)(uint)(instruction_23 & 0xFF)))->field_1;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_21 = (ushort)field_3;
						int instruction_24 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_20;
						sbyte field_4 = ((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (int)(uint)(instruction_24 & 0xFF)))->field_0;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_22 = (byte)field_4;
						if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_22 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_22 <= 16u)
						{
							bool flag5 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1481);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag5 = false;
						}
						if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_21 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_22))
						{
							bool flag6 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1481);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag6 = false;
						}
						long num3 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_21 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9);
						long instruction_25 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8 = instruction_25 | num3;
						int instruction_26 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_22;
						int instruction_27 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 = instruction_27 + instruction_26;
						if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 <= 64)
						{
							bool flag7 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1481);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag7 = false;
						}
						int instruction_28 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_20;
						short field_5 = ((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (int)(uint)((instruction_28 >>> 8) & 0xFF)))->field_1;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_23 = (ushort)field_5;
						int instruction_29 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_20;
						sbyte field_6 = ((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (int)(uint)((instruction_29 >>> 8) & 0xFF)))->field_0;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_24 = (byte)field_6;
						if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_24 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_24 <= 16u)
						{
							bool flag8 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1482);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag8 = false;
						}
						if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_23 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_24))
						{
							bool flag9 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1482);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag9 = false;
						}
						long num4 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_23 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9);
						long instruction_30 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8 = instruction_30 | num4;
						int instruction_31 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_24;
						int instruction_32 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 = instruction_32 + instruction_31;
						if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 <= 64)
						{
							bool flag10 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1482);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag10 = false;
						}
						int instruction_33 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_20;
						short field_7 = ((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (int)(uint)((instruction_33 >>> 16) & 0xFF)))->field_1;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_25 = (ushort)field_7;
						int instruction_34 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_20;
						sbyte field_8 = ((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (int)(uint)((instruction_34 >>> 16) & 0xFF)))->field_0;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_26 = (byte)field_8;
						if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_26 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_26 <= 16u)
						{
							bool flag11 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1483);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag11 = false;
						}
						if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_25 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_26))
						{
							bool flag12 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1483);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag12 = false;
						}
						long num5 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_25 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9);
						long instruction_35 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8 = instruction_35 | num5;
						int instruction_36 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_26;
						int instruction_37 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 = instruction_37 + instruction_36;
						if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 <= 64)
						{
							bool flag13 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1483);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag13 = false;
						}
						if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 >= 49)
						{
							if ((uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7 + 8) > (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_1)
							{
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_0 = 0;
								break;
							}
							long instruction_38 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
							*(long*)((byte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_2 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7) = instruction_38;
							int instruction_39 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_27 = instruction_39 & -8;
							int num6 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_27 >>> 3;
							int instruction_40 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7 = instruction_40 + num6;
							if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_27 < 64u)
							{
								bool flag14 = true;
							}
							else
							{
								IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_2ej5tjb, GlobalVariablePointers.String_uxbkrtb, 1487);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								bool flag14 = false;
							}
							long instruction_41 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
							int instruction_42 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_27;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8 = instruction_41 >>> (int)(uint)instruction_42;
							int instruction_43 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_27;
							int instruction_44 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 = instruction_44 - instruction_43;
						}
						int instruction_45 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_20;
						short field_9 = ((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (int)(uint)(instruction_45 >>> 24)))->field_1;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_28 = (ushort)field_9;
						int instruction_46 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_20;
						sbyte field_10 = ((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (int)(uint)(instruction_46 >>> 24)))->field_0;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_29 = (byte)field_10;
						if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_29 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_29 <= 16u)
						{
							bool flag15 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1490);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag15 = false;
						}
						if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_28 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_29))
						{
							bool flag16 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1490);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag16 = false;
						}
						long num7 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_28 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9);
						long instruction_47 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8 = instruction_47 | num7;
						int instruction_48 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_29;
						int instruction_49 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 = instruction_49 + instruction_48;
						if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 <= 64)
						{
							bool flag17 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1490);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag17 = false;
						}
						int instruction_50 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_11;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_11 = instruction_50 + 4;
						int instruction_51 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_20;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_19 = instruction_51;
						if ((uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7 + 8) > (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_1)
						{
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_0 = 0;
							break;
						}
						long instruction_52 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
						*(long*)((byte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_2 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7) = instruction_52;
						int instruction_53 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_30 = instruction_53 & -8;
						int num8 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_30 >>> 3;
						int instruction_54 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7 = instruction_54 + num8;
						if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_30 < 64u)
						{
							bool flag18 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_2ej5tjb, GlobalVariablePointers.String_uxbkrtb, 1497);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							bool flag18 = false;
						}
						long instruction_55 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
						int instruction_56 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_30;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8 = instruction_55 >>> (int)(uint)instruction_56;
						int instruction_57 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_30;
						int instruction_58 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 = instruction_58 - instruction_57;
						while ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_11 < (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_14)
						{
							int instruction_59 = *(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_10 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_11);
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_31 = instruction_59;
							if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_31 != startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_19)
							{
								goto IL_20e9;
							}
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_32 = 4;
							int instruction_60 = minimum_ymfg3kb(252, startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_14 - startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_11);
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_33 = instruction_60;
							while ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_32 < (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_33 && *(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_10 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_11 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_32) == startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_31)
							{
								int instruction_61 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_32;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_32 = instruction_61 + 4;
							}
							int instruction_62 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_32;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_34 = instruction_62 - 3;
							int instruction_63 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_34;
							short num9 = *(short*)((byte*)GlobalVariablePointers.g_defl_len_sym + sizeof(short) * (int)(uint)instruction_63);
							sbyte field_11 = ((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (ushort)num9))->field_0;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_35 = (byte)field_11;
							int instruction_64 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_34;
							sbyte b2 = ((sbyte*)GlobalVariablePointers.g_defl_len_extra)[sizeof(sbyte) * (int)(uint)instruction_64];
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_36 = (byte)b2;
							if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_32 == 4)
							{
								int instruction_65 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_31;
								int num10 = (byte)((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (int)(uint)(instruction_65 & 0xFF)))->field_0;
								int instruction_66 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_31;
								checked
								{
									int num11 = num10 + unchecked((byte)((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (int)(uint)((instruction_66 >>> 8) & 0xFF)))->field_0);
									int instruction_67 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_31;
									int num12 = num11 + unchecked((byte)((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (int)(uint)((instruction_67 >>> 16) & 0xFF)))->field_0);
									int instruction_68 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_31;
									int instruction_69 = num12 + unchecked((byte)((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (int)(uint)(instruction_68 >>> 24)))->field_0);
									startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_37 = instruction_69;
								}
								if ((uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_35 + startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_36 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_37)
								{
									goto IL_20e9;
								}
							}
							int instruction_70 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_34;
							short num13 = *(short*)((byte*)GlobalVariablePointers.g_defl_len_sym + sizeof(short) * (int)(uint)instruction_70);
							short field_12 = ((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (ushort)num13))->field_1;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_38 = (ushort)field_12;
							int instruction_71 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_35;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_39 = instruction_71;
							if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_39 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_39 <= 16u)
							{
								bool flag19 = true;
							}
							else
							{
								IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1530);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								bool flag19 = false;
							}
							if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_38 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_39))
							{
								bool flag20 = true;
							}
							else
							{
								IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1530);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								bool flag20 = false;
							}
							long num14 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_38 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9);
							long instruction_72 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8 = instruction_72 | num14;
							int instruction_73 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_39;
							int instruction_74 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 = instruction_74 + instruction_73;
							if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 <= 64)
							{
								bool flag21 = true;
							}
							else
							{
								IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1530);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								bool flag21 = false;
							}
							int instruction_75 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_34;
							int instruction_76 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_34;
							sbyte b3 = ((sbyte*)GlobalVariablePointers.g_defl_len_extra)[sizeof(sbyte) * (int)(uint)instruction_76];
							int num15 = *(int*)((byte*)GlobalVariablePointers.g_bitmasks + sizeof(int) * (byte)b3);
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_40 = instruction_75 & num15;
							int instruction_77 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_36;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_41 = instruction_77 + 1;
							if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_41 >= 0u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_41 <= 16u)
							{
								bool flag22 = true;
							}
							else
							{
								IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_9hewgtd, GlobalVariablePointers.String_uxbkrtb, 1531);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								bool flag22 = false;
							}
							if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_40 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_41))
							{
								bool flag23 = true;
							}
							else
							{
								IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1531);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								bool flag23 = false;
							}
							long num16 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_40 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9);
							long instruction_78 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8 = instruction_78 | num16;
							int instruction_79 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_41;
							int instruction_80 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 = instruction_80 + instruction_79;
							if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 <= 64)
							{
								bool flag24 = true;
							}
							else
							{
								IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1531);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								bool flag24 = false;
							}
							int instruction_81 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_32;
							int instruction_82 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_11;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_11 = instruction_82 + instruction_81;
							goto IL_2fc7;
							IL_2fc7:
							if ((uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7 + 8) <= (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_1)
							{
								long instruction_83 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
								*(long*)((byte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_2 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7) = instruction_83;
								int instruction_84 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_51 = instruction_84 & -8;
								int num17 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_51 >>> 3;
								int instruction_85 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7 = instruction_85 + num17;
								if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_51 < 64u)
								{
									bool flag25 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_2ej5tjb, GlobalVariablePointers.String_uxbkrtb, 1554);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									bool flag25 = false;
								}
								long instruction_86 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
								int instruction_87 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_51;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8 = instruction_86 >>> (int)(uint)instruction_87;
								int instruction_88 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_51;
								int instruction_89 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 = instruction_89 - instruction_88;
								continue;
							}
							goto IL_3008;
							IL_20e9:
							int instruction_90 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_31;
							short field_13 = ((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (int)(uint)(instruction_90 & 0xFF)))->field_1;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_42 = (ushort)field_13;
							int instruction_91 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_31;
							sbyte field_14 = ((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (int)(uint)(instruction_91 & 0xFF)))->field_0;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_43 = (byte)field_14;
							if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_43 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_43 <= 16u)
							{
								bool flag26 = true;
							}
							else
							{
								IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1538);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								bool flag26 = false;
							}
							if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_42 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_43))
							{
								bool flag27 = true;
							}
							else
							{
								IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1538);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								bool flag27 = false;
							}
							long num18 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_42 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9);
							long instruction_92 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8 = instruction_92 | num18;
							int instruction_93 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_43;
							int instruction_94 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 = instruction_94 + instruction_93;
							if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 <= 64)
							{
								bool flag28 = true;
							}
							else
							{
								IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1538);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								bool flag28 = false;
							}
							int instruction_95 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_31;
							short field_15 = ((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (int)(uint)((instruction_95 >>> 8) & 0xFF)))->field_1;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_44 = (ushort)field_15;
							int instruction_96 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_31;
							sbyte field_16 = ((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (int)(uint)((instruction_96 >>> 8) & 0xFF)))->field_0;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_45 = (byte)field_16;
							if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_45 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_45 <= 16u)
							{
								bool flag29 = true;
							}
							else
							{
								IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1539);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								bool flag29 = false;
							}
							if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_44 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_45))
							{
								bool flag30 = true;
							}
							else
							{
								IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1539);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								bool flag30 = false;
							}
							long num19 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_44 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9);
							long instruction_97 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8 = instruction_97 | num19;
							int instruction_98 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_45;
							int instruction_99 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 = instruction_99 + instruction_98;
							if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 <= 64)
							{
								bool flag31 = true;
							}
							else
							{
								IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1539);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								bool flag31 = false;
							}
							int instruction_100 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_31;
							short field_17 = ((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (int)(uint)((instruction_100 >>> 16) & 0xFF)))->field_1;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_46 = (ushort)field_17;
							int instruction_101 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_31;
							sbyte field_18 = ((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (int)(uint)((instruction_101 >>> 16) & 0xFF)))->field_0;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_47 = (byte)field_18;
							if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_47 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_47 <= 16u)
							{
								bool flag32 = true;
							}
							else
							{
								IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1540);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								bool flag32 = false;
							}
							if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_46 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_47))
							{
								bool flag33 = true;
							}
							else
							{
								IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1540);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								bool flag33 = false;
							}
							long num20 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_46 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9);
							long instruction_102 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8 = instruction_102 | num20;
							int instruction_103 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_47;
							int instruction_104 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 = instruction_104 + instruction_103;
							if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 <= 64)
							{
								bool flag34 = true;
							}
							else
							{
								IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1540);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								bool flag34 = false;
							}
							if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 >= 49)
							{
								if ((uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7 + 8) > (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_1)
								{
									goto IL_2aac;
								}
								long instruction_105 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
								*(long*)((byte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_2 + (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7) = instruction_105;
								int instruction_106 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_48 = instruction_106 & -8;
								int num21 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_48 >>> 3;
								int instruction_107 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7 = instruction_107 + num21;
								if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_48 < 64u)
								{
									bool flag35 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_2ej5tjb, GlobalVariablePointers.String_uxbkrtb, 1544);
									if (ExceptionInfo.Current != null)
									{
										return 0;
									}
									bool flag35 = false;
								}
								long instruction_108 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
								int instruction_109 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_48;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8 = instruction_108 >>> (int)(uint)instruction_109;
								int instruction_110 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_48;
								int instruction_111 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 = instruction_111 - instruction_110;
							}
							int instruction_112 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_31;
							short field_19 = ((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (int)(uint)(instruction_112 >>> 24)))->field_1;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_49 = (ushort)field_19;
							int instruction_113 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_31;
							sbyte field_20 = ((anon_11*)((byte*)GlobalVariablePointers.g_dyn_huff_4_codes + sizeof(anon_11) * (int)(uint)(instruction_113 >>> 24)))->field_0;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_50 = (byte)field_20;
							if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_50 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_50 <= 16u)
							{
								bool flag36 = true;
							}
							else
							{
								IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1547);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								bool flag36 = false;
							}
							if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_49 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_50))
							{
								bool flag37 = true;
							}
							else
							{
								IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1547);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								bool flag37 = false;
							}
							long num22 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_49 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9);
							long instruction_114 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8 = instruction_114 | num22;
							int instruction_115 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_50;
							int instruction_116 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 = instruction_116 + instruction_115;
							if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 <= 64)
							{
								bool flag38 = true;
							}
							else
							{
								IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1547);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								bool flag38 = false;
							}
							int instruction_117 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_11;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_11 = instruction_117 + 4;
							int instruction_118 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_31;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_19 = instruction_118;
							goto IL_2fc7;
						}
						int instruction_119 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_13;
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_13 = instruction_119 + 1;
						continue;
					}
					if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_11 == startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_3 * startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_6)
					{
						bool flag39 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_bjvsuxc, GlobalVariablePointers.String_uxbkrtb, 1560);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						bool flag39 = false;
					}
					if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 <= 7)
					{
						bool flag40 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_vpte4cc, GlobalVariablePointers.String_uxbkrtb, 1562);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						bool flag40 = false;
					}
					startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_52 = 2047;
					startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_53 = 12;
					if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_53 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_53 <= 16u)
					{
						bool flag41 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 1564);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						bool flag41 = false;
					}
					if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_52 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_53))
					{
						bool flag42 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 1564);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						bool flag42 = false;
					}
					long num23 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_52 << (int)(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9);
					long instruction_120 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
					startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8 = instruction_120 | num23;
					int instruction_121 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_53;
					int instruction_122 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9;
					startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 = instruction_122 + instruction_121;
					if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 <= 64)
					{
						bool flag43 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 1564);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						bool flag43 = false;
					}
					while (true)
					{
						if (startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 > 0)
						{
							if ((uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_1)
							{
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_0 = 0;
								break;
							}
							long instruction_123 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
							((sbyte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7] = (sbyte)instruction_123;
							int instruction_124 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7 = instruction_124 + 1;
							long instruction_125 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_8 = instruction_125 >>> 8;
							int instruction_126 = checked(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 - 8);
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_9 = instruction_126;
							continue;
						}
						startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_54 = 0;
						while (true)
						{
							if ((uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_54 < 4u)
							{
								if ((uint)(startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_1)
								{
									startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_0 = 0;
									break;
								}
								int instruction_127 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_12;
								((sbyte*)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7] = (sbyte)(instruction_127 >>> 24);
								int instruction_128 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7 = instruction_128 + 1;
								int instruction_129 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_12;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_12 = instruction_129 << 8;
								int instruction_130 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_54;
								startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_54 = instruction_130 + 1;
								continue;
							}
							int instruction_131 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_7;
							startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_0 = instruction_131;
							break;
						}
						break;
					}
					break;
					IL_3008:
					startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_0 = 0;
					break;
					IL_2aac:
					startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_0 = 0;
					break;
				}
			}
			int instruction_132 = startFrame.GetLocalsRef<LocalVariables_pixel_deflate_dyn_4_rle_one_pass>().Instruction_0;
			StackFrameList.Current.Clear(startFrame);
			return instruction_132;
		}
	}

	[MangledName("?write_raw_block@fpng@@YAIPEBEIPEAEI@Z")]
	[DemangledName("unsigned int __cdecl fpng::write_raw_block(unsigned char const *, unsigned int, unsigned char *, unsigned int)")]
	public unsafe static int write_raw_block(void* P_0, int P_1, void* P_2, int P_3)
	{
		unchecked
		{
			int result;
			if ((uint)P_3 < 2u)
			{
				result = 0;
			}
			else
			{
				*(sbyte*)P_2 = 120;
				((sbyte*)P_2)[1L] = 1;
				int num = 2;
				int num2 = 0;
				while (true)
				{
					if ((uint)num2 < (uint)P_1)
					{
						int num3 = P_1 - num2;
						int num4 = minimum_su2nfub(65535, num3);
						sbyte b = ((num4 == num3) ? ((sbyte)1) : ((sbyte)0));
						if ((uint)(num + 5 + num4) > (uint)P_3)
						{
							result = 0;
							break;
						}
						bool flag = b == 0;
						long num5 = (flag ? 1L : 0L);
						((sbyte*)P_2)[(uint)(num + 0)] = (sbyte)(flag ? 1 : 0);
						((sbyte*)P_2)[(uint)(num + 1)] = (sbyte)(num4 & 0xFF);
						((sbyte*)P_2)[(uint)(num + 2)] = (sbyte)((num4 >>> 8) & 0xFF);
						((sbyte*)P_2)[(uint)(num + 3)] = (sbyte)((num4 ^ -1) & 0xFF);
						((sbyte*)P_2)[(uint)(num + 4)] = (sbyte)(((num4 ^ -1) >>> 8) & 0xFF);
						IntrinsicFunctions.Implemented.llvm_memcpy_p0_p0_i64((byte*)P_2 + (uint)num + 5L, (byte*)P_0 + (uint)num2, (uint)num4, false);
						num2 += num4;
						num += 5 + num4;
						continue;
					}
					int num6 = fpng_adler32(P_0, (uint)P_1, 1);
					int num7 = 0;
					while (true)
					{
						if ((uint)num7 < 4u)
						{
							if ((uint)(num + 1) > (uint)P_3)
							{
								result = 0;
								break;
							}
							((sbyte*)P_2)[(uint)num] = (sbyte)(num6 >>> 24);
							num++;
							num6 <<= 8;
							num7++;
							continue;
						}
						result = num;
						break;
					}
					break;
				}
			}
			return result;
		}
	}

	[MangledName("?vector_append@fpng@@YAXAEAV?$vector@EV?$allocator@E@std@@@std@@PEBX_K@Z")]
	[DemangledName("void __cdecl fpng::vector_append(class std::vector<unsigned char, class std::allocator<unsigned char>> &, void const *, unsigned __int64)")]
	public unsafe static void vector_append(void* P_0, void* P_1, long P_2)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_vector_append>();
		startFrame.GetLocalsRef<LocalVariables_vector_append>().Instruction_0 = P_2;
		startFrame.GetLocalsRef<LocalVariables_vector_append>().Instruction_1 = P_1;
		startFrame.GetLocalsRef<LocalVariables_vector_append>().Instruction_2 = P_0;
		unchecked
		{
			if (startFrame.GetLocalsRef<LocalVariables_vector_append>().Instruction_0 != 0L)
			{
				long instruction_ = size_4io4p4d(startFrame.GetLocalsRef<LocalVariables_vector_append>().Instruction_2);
				startFrame.GetLocalsRef<LocalVariables_vector_append>().Instruction_3 = instruction_;
				resize_wwmwtsa(startFrame.GetLocalsRef<LocalVariables_vector_append>().Instruction_2, startFrame.GetLocalsRef<LocalVariables_vector_append>().Instruction_3 + startFrame.GetLocalsRef<LocalVariables_vector_append>().Instruction_0);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				IntrinsicFunctions.Implemented.llvm_memcpy_p0_p0_i64((byte*)data_efhnzgd(startFrame.GetLocalsRef<LocalVariables_vector_append>().Instruction_2) + startFrame.GetLocalsRef<LocalVariables_vector_append>().Instruction_3, startFrame.GetLocalsRef<LocalVariables_vector_append>().Instruction_1, startFrame.GetLocalsRef<LocalVariables_vector_append>().Instruction_0, false);
			}
			StackFrameList.Current.Clear(startFrame);
		}
	}

	[MangledName("??1?$vector@EV?$allocator@E@std@@@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::~vector<unsigned char, class std::allocator<unsigned char>>(void)")]
	public unsafe static void vector_unsigned_char_class_std_allocator_unsigned_char_Destructor(void* P_0)
	{
		Tidy_iono57d(P_0);
	}

	[MangledName("?fpng_get_info@fpng@@YAHPEBXIAEAI11@Z")]
	[DemangledName("int __cdecl fpng::fpng_get_info(void const *, unsigned int, unsigned int &, unsigned int &, unsigned int &)")]
	public unsafe static int fpng_get_info(void* P_0, int P_1, void* P_2, void* P_3, void* P_4)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_fpng_get_info>();
		int* ptr = &startFrame.GetLocalsPointer<LocalVariables_fpng_get_info>()->Instruction_5;
		int* ptr2 = &startFrame.GetLocalsPointer<LocalVariables_fpng_get_info>()->Instruction_6;
		startFrame.GetLocalsRef<LocalVariables_fpng_get_info>().Instruction_0 = P_4;
		startFrame.GetLocalsRef<LocalVariables_fpng_get_info>().Instruction_1 = P_3;
		startFrame.GetLocalsRef<LocalVariables_fpng_get_info>().Instruction_2 = P_2;
		startFrame.GetLocalsRef<LocalVariables_fpng_get_info>().Instruction_3 = P_1;
		startFrame.GetLocalsRef<LocalVariables_fpng_get_info>().Instruction_4 = P_0;
		startFrame.GetLocalsRef<LocalVariables_fpng_get_info>().Instruction_5 = 0;
		startFrame.GetLocalsRef<LocalVariables_fpng_get_info>().Instruction_6 = 0;
		void* instruction_ = startFrame.GetLocalsRef<LocalVariables_fpng_get_info>().Instruction_0;
		void* instruction_2 = startFrame.GetLocalsRef<LocalVariables_fpng_get_info>().Instruction_1;
		void* instruction_3 = startFrame.GetLocalsRef<LocalVariables_fpng_get_info>().Instruction_2;
		int instruction_4 = startFrame.GetLocalsRef<LocalVariables_fpng_get_info>().Instruction_3;
		int result = fpng_get_info_internal(startFrame.GetLocalsRef<LocalVariables_fpng_get_info>().Instruction_4, instruction_4, instruction_3, instruction_2, instruction_, ptr, ptr2);
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		StackFrameList.Current.Clear(startFrame);
		return result;
	}

	[MangledName("?fpng_get_info_internal@fpng@@YAHPEBXIAEAI1111@Z")]
	[DemangledName("int __cdecl fpng::fpng_get_info_internal(void const *, unsigned int, unsigned int &, unsigned int &, unsigned int &, unsigned int &, unsigned int &)")]
	public unsafe static int fpng_get_info_internal(void* P_0, int P_1, void* P_2, void* P_3, void* P_4, void* P_5, void* P_6)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_fpng_get_info_internal>();
		InlineArray_5_w3otm9c* ptr = &startFrame.GetLocalsPointer<LocalVariables_fpng_get_info_internal>()->Instruction_21;
		startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_1 = P_6;
		startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_2 = P_5;
		startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_3 = P_4;
		startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_4 = P_3;
		startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_5 = P_2;
		startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_6 = P_1;
		startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_7 = P_0;
		unchecked
		{
			if (!endian_check())
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_kdrammb, GlobalVariablePointers.String_uxbkrtb, 2936);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0 = 0;
			}
			else
			{
				*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_5 = 0;
				*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_4 = 0;
				*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_3 = 0;
				*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_2 = 0;
				*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_1 = 0;
				if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_6 < 58uL)
				{
					startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0 = 3;
				}
				else if (IntrinsicFunctions.Implemented.memcmp(startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_7, GlobalVariablePointers.s_png_sig, 8L) != 0)
				{
					startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0 = 3;
				}
				else
				{
					void* instruction_ = startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_7;
					startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_8 = (byte*)instruction_ + 8L;
					void* instruction_2 = startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_8;
					startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_9 = instruction_2;
					void* instruction_3 = startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_8;
					startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_8 = (byte*)instruction_3 + 25L;
					if (swap32(((fpng_png_ihdr*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_9)->field_0.field_0) != 13)
					{
						startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0 = 3;
					}
					else if (fpng_crc32((byte*)(&((fpng_png_ihdr*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_9)->field_0.field_1) + sizeof(sbyte) * 0, 17L, 0) != swap32(((fpng_png_ihdr*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_9)->field_8))
					{
						startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0 = 4;
					}
					else
					{
						int num = swap32(((fpng_png_ihdr*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_9)->field_1);
						*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_5 = num;
						int num2 = swap32(((fpng_png_ihdr*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_9)->field_2);
						*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_4 = num2;
						if (*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_5 == 0 || *(int*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_4 == 0 || (uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_5) > 16777216u || (uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_4) > 16777216u)
						{
							startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0 = 5;
						}
						else
						{
							long num3 = (uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_5);
							int instruction_4 = *(int*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_4;
							startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_10 = num3 * (uint)instruction_4;
							if ((ulong)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_10 > 1073741824uL)
							{
								startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0 = 5;
							}
							else if (((fpng_png_ihdr*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_9)->field_5 != 0 || ((fpng_png_ihdr*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_9)->field_6 != 0 || ((fpng_png_ihdr*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_9)->field_7 != 0 || (byte)((fpng_png_ihdr*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_9)->field_3 != 8)
							{
								startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0 = 1;
							}
							else
							{
								if ((byte)((fpng_png_ihdr*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_9)->field_4 == 2)
								{
									*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_3 = 3;
								}
								else if ((byte)((fpng_png_ihdr*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_9)->field_4 == 6)
								{
									*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_3 = 4;
								}
								if (*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_3 == 0)
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0 = 1;
								}
								else
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_11 = 0;
									while (true)
									{
										void* instruction_5 = startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_8;
										void* instruction_6 = startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_7;
										startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_12 = (long)instruction_5 - (long)instruction_6;
										if ((ulong)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_12 >= (ulong)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_6)
										{
											startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0 = 7;
											break;
										}
										int instruction_7 = startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_6;
										long instruction_8 = startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_12;
										startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_13 = instruction_7 - (int)instruction_8;
										if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_13 < 12uL)
										{
											startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0 = 7;
											break;
										}
										void* instruction_9 = startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_8;
										startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_14 = instruction_9;
										int instruction_10 = swap32(((fpng_png_chunk_prefix*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_14)->field_0);
										startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_15 = instruction_10;
										if ((ulong)(startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_12 + 8L + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_15 + 4L) > (ulong)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_6)
										{
											startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0 = 7;
											break;
										}
										startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_16 = 0;
										while ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_16 < 4u)
										{
											sbyte instruction_11 = ((sbyte*)(&((fpng_png_chunk_prefix*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_14)->field_1))[sizeof(sbyte) * (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_16];
											startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_17 = instruction_11;
											bool flag = (byte)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_17 >= 65 && (byte)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_17 <= 90;
											startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_18 = (flag ? ((sbyte)1) : ((sbyte)0));
											bool flag2 = (byte)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_17 >= 97 && (byte)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_17 <= 122;
											startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_19 = (flag2 ? ((sbyte)1) : ((sbyte)0));
											if (startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_18 != 0 && startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_19 != 0)
											{
												goto IL_0a10;
											}
											int instruction_12 = startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_16;
											startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_16 = instruction_12 + 1;
										}
										int instruction_13 = swap32(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_8 + 8L + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_15));
										startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_20 = instruction_13;
										sbyte instruction_14 = ((sbyte*)(&((fpng_png_chunk_prefix*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_14)->field_1))[sizeof(sbyte) * 0];
										Unsafe.As<InlineArray_5_w3otm9c, sbyte>(ref startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_21) = instruction_14;
										((sbyte*)ptr)[1L] = ((sbyte*)(&((fpng_png_chunk_prefix*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_14)->field_1))[sizeof(sbyte) * 1];
										((sbyte*)ptr)[2L] = ((sbyte*)(&((fpng_png_chunk_prefix*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_14)->field_1))[sizeof(sbyte) * 2];
										((sbyte*)ptr)[3L] = ((sbyte*)(&((fpng_png_chunk_prefix*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_14)->field_1))[sizeof(sbyte) * 3];
										((sbyte*)ptr)[4L] = 0;
										int num4 = IntrinsicFunctions.Implemented.strcmp((byte*)ptr + sizeof(sbyte) * 0, GlobalVariablePointers.String_qjc9xdd);
										startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_22 = ((num4 == 0) ? ((sbyte)1) : ((sbyte)0));
										if (startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_22 != 0)
										{
											int instruction_15 = startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_15;
											int instruction_16 = fpng_crc32((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_8 + 4L, 4L + (long)(uint)instruction_15, 0);
											startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_23 = instruction_16;
											if (startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_23 != startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_20)
											{
												startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0 = 4;
												break;
											}
										}
										void* instruction_17 = startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_8;
										startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_24 = (byte*)instruction_17 + 8L;
										if (IntrinsicFunctions.Implemented.strcmp((byte*)ptr + sizeof(sbyte) * 0, GlobalVariablePointers.String_p7olgfc) != 0)
										{
											if (startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_22 == 0)
											{
												if (*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_2 != 0 || startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_11 != 0)
												{
													startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0 = 1;
													break;
												}
												long instruction_18 = startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_12;
												*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_2 = (int)instruction_18;
												int instruction_19 = startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_15;
												*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_1 = instruction_19;
												if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_1) < 7u)
												{
													startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0 = 8;
													break;
												}
											}
											else if (IntrinsicFunctions.Implemented.strcmp((byte*)ptr + sizeof(sbyte) * 0, GlobalVariablePointers.String_22lii4a) == 0)
											{
												if (startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_11 == 0)
												{
													startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0 = 1;
													break;
												}
												if (startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_15 != 5)
												{
													startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0 = 1;
													break;
												}
												if ((byte)(*(sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_24) != 82 || (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_24)[1L] != 36 || (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_24)[2L] != 147 || (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_24)[3L] != 227)
												{
													startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0 = 1;
													break;
												}
												if ((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_24)[4L] != 0)
												{
													startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0 = 1;
													break;
												}
												startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_11 = 1;
											}
											else if ((((sbyte*)ptr)[sizeof(sbyte) * 0] & 0x20) == 0)
											{
												startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0 = 1;
												break;
											}
											long num5 = 8L + (long)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_15 + 4L;
											void* instruction_20 = startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_8;
											startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_8 = (byte*)instruction_20 + num5;
											continue;
										}
										if (startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_11 != 0 || *(int*)startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_2 == 0)
										{
											startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0 = 1;
										}
										else
										{
											startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0 = 0;
										}
										break;
										IL_0a10:
										startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0 = 7;
										break;
									}
								}
							}
						}
					}
				}
			}
			int instruction_21 = startFrame.GetLocalsRef<LocalVariables_fpng_get_info_internal>().Instruction_0;
			StackFrameList.Current.Clear(startFrame);
			return instruction_21;
		}
	}

	[MangledName("?fpng_decode_memory@fpng@@YAHPEBXIAEAV?$vector@EV?$allocator@E@std@@@std@@AEAI22I@Z")]
	[DemangledName("int __cdecl fpng::fpng_decode_memory(void const *, unsigned int, class std::vector<unsigned char, class std::allocator<unsigned char>> &, unsigned int &, unsigned int &, unsigned int &, unsigned int)")]
	public unsafe static int fpng_decode_memory(void* P_0, int P_1, void* P_2, void* P_3, void* P_4, void* P_5, int P_6)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_fpng_decode_memory>();
		int* ptr = &startFrame.GetLocalsPointer<LocalVariables_fpng_decode_memory>()->Instruction_8;
		int* ptr2 = &startFrame.GetLocalsPointer<LocalVariables_fpng_decode_memory>()->Instruction_9;
		startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_1 = P_6;
		startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_2 = P_5;
		startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_3 = P_4;
		startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_4 = P_3;
		startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_5 = P_2;
		startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_6 = P_1;
		startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_7 = P_0;
		resize_wwmwtsa(startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_5, 0L);
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		unchecked
		{
			*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_4 = 0;
			*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_3 = 0;
			*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_2 = 0;
			if (startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_7 == null || startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_6 == 0 || (startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_1 != 3 && startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_1 != 4))
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_kdrammb, GlobalVariablePointers.String_uxbkrtb, 3094);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_0 = 2;
			}
			else
			{
				startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_8 = 0;
				startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_9 = 0;
				void* instruction_ = startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_2;
				void* instruction_2 = startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_3;
				void* instruction_3 = startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_4;
				int instruction_4 = startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_6;
				int instruction_5 = fpng_get_info_internal(startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_7, instruction_4, instruction_3, instruction_2, instruction_, ptr, ptr2);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_10 = instruction_5;
				if (startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_10 != 0)
				{
					int instruction_6 = startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_10;
					startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_0 = instruction_6;
				}
				else
				{
					long num = (long)(uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_4) * (long)(uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_3);
					int instruction_7 = startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_1;
					startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_11 = num * (uint)instruction_7;
					if ((ulong)startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_11 > 4294967295uL)
					{
						startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_0 = 6;
					}
					else
					{
						resize_wwmwtsa(startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_5, startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_11);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						void* instruction_8 = startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_7;
						int instruction_9 = startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_12 = (byte*)instruction_8 + (uint)instruction_9 + 8L;
						long num2 = (uint)startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_6;
						int instruction_10 = startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_13 = (int)(num2 - ((long)(uint)instruction_10 + 8L));
						if (startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_1 == 3)
						{
							if (*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_2 == 3)
							{
								int instruction_11 = *(int*)startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_3;
								int instruction_12 = *(int*)startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_4;
								void* ptr3 = data_efhnzgd(startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_5);
								int instruction_13 = startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_9;
								int instruction_14 = startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_13;
								bool flag = fpng_pixel_zlib_decompress_3_prmnnjb(startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_12, instruction_14, instruction_13, ptr3, instruction_12, instruction_11);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_14 = (flag ? ((sbyte)1) : ((sbyte)0));
							}
							else
							{
								int instruction_15 = *(int*)startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_3;
								int instruction_16 = *(int*)startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_4;
								void* ptr4 = data_efhnzgd(startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_5);
								int instruction_17 = startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_9;
								int instruction_18 = startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_13;
								bool flag2 = fpng_pixel_zlib_decompress_4_xygi9td(startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_12, instruction_18, instruction_17, ptr4, instruction_16, instruction_15);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_14 = (flag2 ? ((sbyte)1) : ((sbyte)0));
							}
						}
						else if (*(int*)startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_2 == 3)
						{
							int instruction_19 = *(int*)startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_3;
							int instruction_20 = *(int*)startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_4;
							void* ptr5 = data_efhnzgd(startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_5);
							int instruction_21 = startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_9;
							int instruction_22 = startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_13;
							bool flag3 = fpng_pixel_zlib_decompress_3_yffw42c(startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_12, instruction_22, instruction_21, ptr5, instruction_20, instruction_19);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_14 = (flag3 ? ((sbyte)1) : ((sbyte)0));
						}
						else
						{
							int instruction_23 = *(int*)startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_3;
							int instruction_24 = *(int*)startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_4;
							void* ptr6 = data_efhnzgd(startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_5);
							int instruction_25 = startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_9;
							int instruction_26 = startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_13;
							bool flag4 = fpng_pixel_zlib_decompress_4_amptoaa(startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_12, instruction_26, instruction_25, ptr6, instruction_24, instruction_23);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_14 = (flag4 ? ((sbyte)1) : ((sbyte)0));
						}
						if (startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_14 != 0)
						{
							startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_0 = 1;
						}
						else
						{
							startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_0 = 0;
						}
					}
				}
			}
			int instruction_27 = startFrame.GetLocalsRef<LocalVariables_fpng_decode_memory>().Instruction_0;
			StackFrameList.Current.Clear(startFrame);
			return instruction_27;
		}
	}

	[MangledName("??$fpng_pixel_zlib_decompress_3@$02@fpng@@YA_NPEBEIIPEAEII@Z")]
	[DemangledName("bool __cdecl fpng::fpng_pixel_zlib_decompress_3<3>(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int, unsigned int)")]
	[CleanName("fpng_pixel_zlib_decompress_3")]
	public unsafe static bool fpng_pixel_zlib_decompress_3_prmnnjb(void* P_0, int P_1, int P_2, void* P_3, int P_4, int P_5)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>();
		int* ptr = &startFrame.GetLocalsPointer<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>()->Instruction_8;
		long* ptr2 = &startFrame.GetLocalsPointer<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>()->Instruction_9;
		int* ptr3 = &startFrame.GetLocalsPointer<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>()->Instruction_10;
		InlineArray_4096_vqkfj7a* ptr4 = &startFrame.GetLocalsPointer<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>()->Instruction_15;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_1 = P_5;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_2 = P_4;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_3 = P_3;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_4 = P_2;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_5 = P_1;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_6 = P_0;
		unchecked
		{
			if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_5 >= (uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_4 + 4))
			{
				bool flag = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_497patd, GlobalVariablePointers.String_uxbkrtb, 2214);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				bool flag = false;
			}
			int instruction_ = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_2;
			startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_7 = instruction_ * 3;
			if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_4 < 7u)
			{
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
			}
			else if ((byte)(*(sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_6) != 120 || (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_6)[1L] != 1)
			{
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
			}
			else
			{
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8 = 2;
				if (((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_6)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8] & 6) == 0)
				{
					int instruction_2 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_1;
					int instruction_3 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_2;
					void* instruction_4 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_3;
					int instruction_5 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_4;
					int instruction_6 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_5;
					bool instruction_7 = fpng_pixel_zlib_raw_decompress(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_6, instruction_6, instruction_5, instruction_4, instruction_3, instruction_2, 3, 3);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = instruction_7;
				}
				else if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_5)
				{
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
				}
				else
				{
					int num = *(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8);
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 = (uint)num;
					int instruction_8 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8 = instruction_8 + 4;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 = 32;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_13 = 1;
					if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_13 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_13 <= 32u)
					{
						bool flag2 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_aa3exrc, GlobalVariablePointers.String_uxbkrtb, 2239);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						bool flag2 = false;
					}
					long instruction_9 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9;
					int instruction_10 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_13;
					int num2 = *(int*)((byte*)GlobalVariablePointers.g_bitmasks + sizeof(int) * (int)(uint)instruction_10);
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_11 = (int)(instruction_9 & (uint)num2);
					int instruction_11 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_13;
					long instruction_12 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 = instruction_12 >>> (int)(uint)instruction_11;
					int instruction_13 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_13;
					int instruction_14 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 = instruction_14 - instruction_13;
					if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 < 32u)
					{
						if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_5)
						{
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
							goto IL_3d40;
						}
						long num3 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10);
						long instruction_15 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 = instruction_15 | num3;
						int instruction_16 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8 = instruction_16 + 4;
						int instruction_17 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 = instruction_17 + 32;
					}
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_14 = 2;
					if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_14 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_14 <= 32u)
					{
						bool flag3 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_aa3exrc, GlobalVariablePointers.String_uxbkrtb, 2240);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						bool flag3 = false;
					}
					long instruction_18 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9;
					int instruction_19 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_14;
					int num4 = *(int*)((byte*)GlobalVariablePointers.g_bitmasks + sizeof(int) * (int)(uint)instruction_19);
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_12 = (int)(instruction_18 & (uint)num4);
					int instruction_20 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_14;
					long instruction_21 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 = instruction_21 >>> (int)(uint)instruction_20;
					int instruction_22 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_14;
					int instruction_23 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 = instruction_23 - instruction_22;
					if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 < 32u)
					{
						if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_5)
						{
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
							goto IL_3d40;
						}
						long num5 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10);
						long instruction_24 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 = instruction_24 | num5;
						int instruction_25 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8 = instruction_25 + 4;
						int instruction_26 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 = instruction_26 + 32;
					}
					if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_11 != 1 || startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_12 != 2)
					{
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
					}
					else
					{
						int* ptr5 = (int*)((byte*)ptr4 + sizeof(int) * 0);
						int instruction_27 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_5;
						bool flag4 = prepare_dynamic_block(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_6, instruction_27, ptr, ptr3, ptr2, ptr5, 3);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag4)
						{
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
						}
						else
						{
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_16 = null;
							void* instruction_28 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_3;
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_17 = instruction_28;
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_18 = 0;
							while (true)
							{
								if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_18 < (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_1)
								{
									if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 >= 12u)
									{
										bool flag5 = true;
									}
									else
									{
										IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2256);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										bool flag5 = false;
									}
									int instruction_29 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 & 0xFFFL));
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_19 = instruction_29;
									int instruction_30 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_19;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_20 = (instruction_30 >>> 9) & 0xF;
									if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_20 == 0)
									{
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
										break;
									}
									int instruction_31 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_20;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_21 = instruction_31;
									if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_21 <= 32u)
									{
										bool flag6 = true;
									}
									else
									{
										IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mf9hyza, GlobalVariablePointers.String_uxbkrtb, 2261);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										bool flag6 = false;
									}
									int instruction_32 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_21;
									long instruction_33 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 = instruction_33 >>> (int)(uint)instruction_32;
									int instruction_34 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_21;
									int instruction_35 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 = instruction_35 - instruction_34;
									if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 < 32u)
									{
										if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_5)
										{
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
											break;
										}
										long num6 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10);
										long instruction_36 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 = instruction_36 | num6;
										int instruction_37 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8 = instruction_37 + 4;
										int instruction_38 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 = instruction_38 + 32;
									}
									int instruction_39 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_19;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_19 = instruction_39 & 0x1FF;
									bool flag7 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_18 != 0;
									long num7 = (flag7 ? 1L : 0L);
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_22 = (flag7 ? 2 : 0);
									if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_19 != startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_22)
									{
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
										break;
									}
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 = 0;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_24 = 0;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_25 = 0;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_26 = 0;
									while (true)
									{
										if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 >= 12u)
										{
											bool flag8 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2272);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											bool flag8 = false;
										}
										int instruction_40 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 & 0xFFFL));
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_27 = instruction_40;
										int instruction_41 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_27;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_28 = instruction_41;
										int instruction_42 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_27;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_29 = (instruction_42 >>> 9) & 0xF;
										if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_29 == 0)
										{
											break;
										}
										int instruction_43 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_29;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_30 = instruction_43;
										if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_30 <= 32u)
										{
											bool flag9 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mf9hyza, GlobalVariablePointers.String_uxbkrtb, 2279);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											bool flag9 = false;
										}
										int instruction_44 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_30;
										long instruction_45 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 = instruction_45 >>> (int)(uint)instruction_44;
										int instruction_46 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_30;
										int instruction_47 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 = instruction_47 - instruction_46;
										if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 < 32u)
										{
											if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_5)
											{
												goto IL_0fac;
											}
											long num8 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10);
											long instruction_48 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 = instruction_48 | num8;
											int instruction_49 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8 = instruction_49 + 4;
											int instruction_50 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 = instruction_50 + 32;
										}
										if ((startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_28 & 0x100) != 0)
										{
											int instruction_51 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_28;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_28 = instruction_51 & 0x1FF;
											if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_28 == 256)
											{
												goto IL_10ff;
											}
											int instruction_52 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_28;
											int instruction_53 = *(int*)((byte*)GlobalVariablePointers.s_length_range + sizeof(int) * (int)(uint)(instruction_52 - 257));
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_31 = instruction_53;
											if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_28 >= 265u)
											{
												int instruction_54 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_28;
												int instruction_55 = *(int*)((byte*)GlobalVariablePointers.s_length_extra + sizeof(int) * (int)(uint)(instruction_54 - 257));
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_33 = instruction_55;
												if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_33 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_33 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_33)
												{
													bool flag10 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ftb25bb, GlobalVariablePointers.String_uxbkrtb, 2294);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag10 = false;
												}
												long instruction_56 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9;
												int instruction_57 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_33;
												int num9 = *(int*)((byte*)GlobalVariablePointers.g_bitmasks + sizeof(int) * (int)(uint)instruction_57);
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_32 = (int)(instruction_56 & (uint)num9);
												int instruction_58 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_33;
												long instruction_59 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 = instruction_59 >>> (int)(uint)instruction_58;
												int instruction_60 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_33;
												int instruction_61 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 = instruction_61 - instruction_60;
												int instruction_62 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_32;
												int instruction_63 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_31;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_31 = instruction_63 + instruction_62;
											}
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_34 = 1;
											if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_34 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_34)
											{
												bool flag11 = true;
											}
											else
											{
												IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_bahgbqd, GlobalVariablePointers.String_uxbkrtb, 2300);
												if (ExceptionInfo.Current != null)
												{
													return false;
												}
												bool flag11 = false;
											}
											int instruction_64 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_34;
											long instruction_65 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 = instruction_65 >>> (int)(uint)instruction_64;
											int instruction_66 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_34;
											int instruction_67 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 = instruction_67 - instruction_66;
											if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_31 % 3u == 0)
											{
												bool flag12 = true;
											}
											else
											{
												IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_a5rp7bb, GlobalVariablePointers.String_uxbkrtb, 2303);
												if (ExceptionInfo.Current != null)
												{
													return false;
												}
												bool flag12 = false;
											}
											int instruction_68 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_31;
											if (*(short*)((byte*)GlobalVariablePointers.g_run_len3_to_4 + sizeof(short) * (int)(uint)instruction_68) == 0)
											{
												goto IL_15cd;
											}
											int instruction_69 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23;
											int instruction_70 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_31;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_35 = instruction_69 + instruction_70;
											if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_35 > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_7)
											{
												goto IL_1656;
											}
											if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_16 != null)
											{
												if (((byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_24 | (byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_25 | (byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_26) == 0)
												{
													IntrinsicFunctions.Implemented.llvm_memcpy_p0_p0_i64((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_17 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23, (byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_16 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23, (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_31, false);
													int instruction_71 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_35;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 = instruction_71;
												}
												else
												{
													do
													{
														int num10;
														checked
														{
															num10 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_16)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23]) + unchecked((byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_24);
														}
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23] = (sbyte)num10;
														int num11;
														checked
														{
															num11 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 + 1)]) + unchecked((byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_25);
														}
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 + 1)] = (sbyte)num11;
														int num12;
														checked
														{
															num12 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 + 2)]) + unchecked((byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_26);
														}
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 + 2)] = (sbyte)num12;
														int instruction_72 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23;
														startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 = instruction_72 + 3;
													}
													while ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 < (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_35);
												}
											}
											else
											{
												do
												{
													sbyte instruction_73 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_24;
													((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23] = instruction_73;
													sbyte instruction_74 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_25;
													((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 + 1)] = instruction_74;
													sbyte instruction_75 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_26;
													((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 + 2)] = instruction_75;
													int instruction_76 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 = instruction_76 + 3;
												}
												while ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 < (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_35);
											}
										}
										else
										{
											int instruction_77 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_27;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_38 = instruction_77 >>> 25;
											if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_38 != 0)
											{
												int instruction_78 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_27;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_36 = (instruction_78 >>> 16) & 0x1FF;
												int instruction_79 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_38;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_40 = instruction_79;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_40 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_40)
												{
													bool flag13 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_bahgbqd, GlobalVariablePointers.String_uxbkrtb, 2399);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag13 = false;
												}
												int instruction_80 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_40;
												long instruction_81 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 = instruction_81 >>> (int)(uint)instruction_80;
												int instruction_82 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_40;
												int instruction_83 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 = instruction_83 - instruction_82;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 >= 12u)
												{
													bool flag14 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2401);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag14 = false;
												}
												int instruction_84 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 & 0xFFFL));
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_37 = instruction_84;
												int instruction_85 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_37;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_39 = (instruction_85 >>> 9) & 0xF;
												if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_39 == 0)
												{
													goto IL_1f52;
												}
											}
											else
											{
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 >= 12u)
												{
													bool flag15 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2409);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag15 = false;
												}
												int instruction_86 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 & 0xFFFL));
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_36 = instruction_86;
												int instruction_87 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_36;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_41 = (instruction_87 >>> 9) & 0xF;
												if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_41 == 0)
												{
													goto IL_2077;
												}
												int instruction_88 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_41;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_42 = instruction_88;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_42 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_42)
												{
													bool flag16 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_bahgbqd, GlobalVariablePointers.String_uxbkrtb, 2414);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag16 = false;
												}
												int instruction_89 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_42;
												long instruction_90 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 = instruction_90 >>> (int)(uint)instruction_89;
												int instruction_91 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_42;
												int instruction_92 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 = instruction_92 - instruction_91;
												int instruction_93 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_36;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_39 = instruction_93 >>> 25;
												if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_39 != 0)
												{
													int instruction_94 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_36;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_37 = instruction_94 >>> 16;
												}
												else
												{
													if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 >= 12u)
													{
														bool flag17 = true;
													}
													else
													{
														IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2421);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														bool flag17 = false;
													}
													int instruction_95 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 & 0xFFFL));
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_37 = instruction_95;
													int instruction_96 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_37;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_39 = (instruction_96 >>> 9) & 0xF;
													if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_39 == 0)
													{
														goto IL_2358;
													}
												}
											}
											int instruction_97 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_39;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_43 = instruction_97;
											if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_43 <= 32u)
											{
												bool flag18 = true;
											}
											else
											{
												IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mf9hyza, GlobalVariablePointers.String_uxbkrtb, 2429);
												if (ExceptionInfo.Current != null)
												{
													return false;
												}
												bool flag18 = false;
											}
											int instruction_98 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_43;
											long instruction_99 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 = instruction_99 >>> (int)(uint)instruction_98;
											int instruction_100 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_43;
											int instruction_101 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 = instruction_101 - instruction_100;
											if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 < 32u)
											{
												if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_5)
												{
													goto IL_24de;
												}
												long num13 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10);
												long instruction_102 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 = instruction_102 | num13;
												int instruction_103 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8 = instruction_103 + 4;
												int instruction_104 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 = instruction_104 + 32;
											}
											if (((startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_36 | startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_37) & 0x100) != 0)
											{
												goto IL_264c;
											}
											if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_16 != null)
											{
												int num14 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_16)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23];
												int instruction_105 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_28;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23] = (sbyte)(num14 + instruction_105);
												int num15 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 + 1)];
												int instruction_106 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_36;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 + 1)] = (sbyte)(num15 + instruction_106);
												int num16 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 + 2)];
												int instruction_107 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_37;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 + 2)] = (sbyte)(num16 + instruction_107);
											}
											else
											{
												int instruction_108 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_28;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23] = (sbyte)instruction_108;
												int instruction_109 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_36;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 + 1)] = (sbyte)instruction_109;
												int instruction_110 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_37;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 + 2)] = (sbyte)instruction_110;
											}
											int instruction_111 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 = instruction_111 + 3;
											int instruction_112 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_28;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_24 = (sbyte)instruction_112;
											int instruction_113 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_36;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_25 = (sbyte)instruction_113;
											int instruction_114 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_37;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_26 = (sbyte)instruction_114;
											int instruction_115 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_37;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_44 = instruction_115 >>> 25;
											if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_44 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 < (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_7)
											{
												int instruction_116 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_37;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_28 = (instruction_116 >>> 16) & 0x1FF;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_28 < 256u)
												{
													int instruction_117 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_44;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_45 = instruction_117;
													if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_45 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_45)
													{
														bool flag19 = true;
													}
													else
													{
														IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_bahgbqd, GlobalVariablePointers.String_uxbkrtb, 2481);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														bool flag19 = false;
													}
													int instruction_118 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_45;
													long instruction_119 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 = instruction_119 >>> (int)(uint)instruction_118;
													int instruction_120 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_45;
													int instruction_121 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 = instruction_121 - instruction_120;
													if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 >= 12u)
													{
														bool flag20 = true;
													}
													else
													{
														IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2483);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														bool flag20 = false;
													}
													int instruction_122 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 & 0xFFFL));
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_36 = instruction_122;
													int instruction_123 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_36;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_46 = (instruction_123 >>> 9) & 0xF;
													if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_46 == 0)
													{
														goto IL_2e22;
													}
													int instruction_124 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_46;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_47 = instruction_124;
													if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_47 <= 32u)
													{
														bool flag21 = true;
													}
													else
													{
														IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mf9hyza, GlobalVariablePointers.String_uxbkrtb, 2488);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														bool flag21 = false;
													}
													int instruction_125 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_47;
													long instruction_126 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 = instruction_126 >>> (int)(uint)instruction_125;
													int instruction_127 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_47;
													int instruction_128 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 = instruction_128 - instruction_127;
													if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 < 32u)
													{
														if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_5)
														{
															goto IL_2fa2;
														}
														long num17 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10);
														long instruction_129 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9;
														startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 = instruction_129 | num17;
														int instruction_130 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8;
														startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8 = instruction_130 + 4;
														int instruction_131 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10;
														startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 = instruction_131 + 32;
													}
													int instruction_132 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_36;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_39 = instruction_132 >>> 25;
													if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_39 != 0)
													{
														int instruction_133 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_36;
														startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_37 = instruction_133 >>> 16;
													}
													else
													{
														if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 >= 12u)
														{
															bool flag22 = true;
														}
														else
														{
															IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2495);
															if (ExceptionInfo.Current != null)
															{
																return false;
															}
															bool flag22 = false;
														}
														int instruction_134 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 & 0xFFFL));
														startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_37 = instruction_134;
														int instruction_135 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_37;
														startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_39 = (instruction_135 >>> 9) & 0xF;
														if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_39 == 0)
														{
															goto IL_324e;
														}
													}
													int instruction_136 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_39;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_48 = instruction_136;
													if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_48 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_48)
													{
														bool flag23 = true;
													}
													else
													{
														IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_bahgbqd, GlobalVariablePointers.String_uxbkrtb, 2502);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														bool flag23 = false;
													}
													int instruction_137 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_48;
													long instruction_138 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 = instruction_138 >>> (int)(uint)instruction_137;
													int instruction_139 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_48;
													int instruction_140 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 = instruction_140 - instruction_139;
													if (((startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_36 | startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_37) & 0x100) != 0)
													{
														goto IL_33f4;
													}
													if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_16 != null)
													{
														int num18 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_16)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23];
														int instruction_141 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_28;
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23] = (sbyte)(num18 + instruction_141);
														int num19 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 + 1)];
														int instruction_142 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_36;
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 + 1)] = (sbyte)(num19 + instruction_142);
														int num20 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 + 2)];
														int instruction_143 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_37;
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 + 2)] = (sbyte)(num20 + instruction_143);
													}
													else
													{
														int instruction_144 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_28;
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23] = (sbyte)instruction_144;
														int instruction_145 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_36;
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 + 1)] = (sbyte)instruction_145;
														int instruction_146 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_37;
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 + 2)] = (sbyte)instruction_146;
													}
													int instruction_147 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 = instruction_147 + 3;
													int instruction_148 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_28;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_24 = (sbyte)instruction_148;
													int instruction_149 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_36;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_25 = (sbyte)instruction_149;
													int instruction_150 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_37;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_26 = (sbyte)instruction_150;
												}
											}
										}
										if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_23 < (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_7)
										{
											continue;
										}
										goto IL_38d3;
									}
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
									break;
								}
								if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 >= 12u)
								{
									bool flag24 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2560);
									if (ExceptionInfo.Current != null)
									{
										return false;
									}
									bool flag24 = false;
								}
								int instruction_151 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 & 0xFFFL));
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_49 = instruction_151;
								int instruction_152 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_49;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_50 = (instruction_152 >>> 9) & 0xF;
								if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_50 == 0)
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
									break;
								}
								int instruction_153 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_49;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_49 = instruction_153 & 0x1FF;
								if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_49 != 256)
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
									break;
								}
								int instruction_154 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_50;
								int instruction_155 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 = instruction_155 - instruction_154;
								int instruction_156 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_50;
								long instruction_157 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 = instruction_157 >>> (int)(uint)instruction_156;
								int instruction_158 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_51 = instruction_158 & 7;
								int instruction_159 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_51;
								int instruction_160 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 = instruction_160 - instruction_159;
								int instruction_161 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_51;
								long instruction_162 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_9 = instruction_162 >>> (int)(uint)instruction_161;
								if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8 < (uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 >>> 3))
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
									break;
								}
								int num21 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_10 >>> 3;
								int instruction_163 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8 = instruction_163 - num21;
								if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_8 + 4 != startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_4)
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
								}
								else
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = true;
								}
								break;
								IL_38d3:
								void* instruction_164 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_17;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_16 = instruction_164;
								int instruction_165 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_7;
								void* instruction_166 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_17;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_17 = (byte*)instruction_166 + (uint)instruction_165;
								int instruction_167 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_18;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_18 = instruction_167 + 1;
								continue;
								IL_15cd:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
								break;
								IL_10ff:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
								break;
								IL_33f4:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
								break;
								IL_0fac:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
								break;
								IL_1656:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
								break;
								IL_24de:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
								break;
								IL_2358:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
								break;
								IL_1f52:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
								break;
								IL_324e:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
								break;
								IL_2fa2:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
								break;
								IL_264c:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
								break;
								IL_2077:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
								break;
								IL_2e22:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0 = false;
								break;
							}
						}
					}
				}
			}
			goto IL_3d40;
		}
		IL_3d40:
		bool instruction_168 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_prmnnjb>().Instruction_0;
		StackFrameList.Current.Clear(startFrame);
		return instruction_168;
	}

	[MangledName("??$fpng_pixel_zlib_decompress_4@$02@fpng@@YA_NPEBEIIPEAEII@Z")]
	[DemangledName("bool __cdecl fpng::fpng_pixel_zlib_decompress_4<3>(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int, unsigned int)")]
	[CleanName("fpng_pixel_zlib_decompress_4")]
	public unsafe static bool fpng_pixel_zlib_decompress_4_xygi9td(void* P_0, int P_1, int P_2, void* P_3, int P_4, int P_5)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>();
		int* ptr = &startFrame.GetLocalsPointer<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>()->Instruction_8;
		long* ptr2 = &startFrame.GetLocalsPointer<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>()->Instruction_9;
		int* ptr3 = &startFrame.GetLocalsPointer<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>()->Instruction_10;
		InlineArray_4096_vqkfj7a* ptr4 = &startFrame.GetLocalsPointer<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>()->Instruction_15;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_1 = P_5;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_2 = P_4;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_3 = P_3;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_4 = P_2;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_5 = P_1;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_6 = P_0;
		unchecked
		{
			if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_5 >= (uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_4 + 4))
			{
				bool flag = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_497patd, GlobalVariablePointers.String_uxbkrtb, 2592);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				bool flag = false;
			}
			int instruction_ = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_2;
			startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_7 = instruction_ * 3;
			if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_4 < 7u)
			{
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
			}
			else if ((byte)(*(sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_6) != 120 || (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_6)[1L] != 1)
			{
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
			}
			else
			{
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8 = 2;
				if (((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_6)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8] & 6) == 0)
				{
					int instruction_2 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_1;
					int instruction_3 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_2;
					void* instruction_4 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_3;
					int instruction_5 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_4;
					int instruction_6 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_5;
					bool instruction_7 = fpng_pixel_zlib_raw_decompress(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_6, instruction_6, instruction_5, instruction_4, instruction_3, instruction_2, 4, 3);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = instruction_7;
				}
				else if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_5)
				{
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
				}
				else
				{
					int num = *(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8);
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 = (uint)num;
					int instruction_8 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8 = instruction_8 + 4;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 = 32;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_13 = 1;
					if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_13 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_13 <= 32u)
					{
						bool flag2 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_aa3exrc, GlobalVariablePointers.String_uxbkrtb, 2617);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						bool flag2 = false;
					}
					long instruction_9 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9;
					int instruction_10 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_13;
					int num2 = *(int*)((byte*)GlobalVariablePointers.g_bitmasks + sizeof(int) * (int)(uint)instruction_10);
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_11 = (int)(instruction_9 & (uint)num2);
					int instruction_11 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_13;
					long instruction_12 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 = instruction_12 >>> (int)(uint)instruction_11;
					int instruction_13 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_13;
					int instruction_14 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 = instruction_14 - instruction_13;
					if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 < 32u)
					{
						if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_5)
						{
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
							goto IL_354c;
						}
						long num3 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10);
						long instruction_15 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 = instruction_15 | num3;
						int instruction_16 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8 = instruction_16 + 4;
						int instruction_17 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 = instruction_17 + 32;
					}
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_14 = 2;
					if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_14 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_14 <= 32u)
					{
						bool flag3 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_aa3exrc, GlobalVariablePointers.String_uxbkrtb, 2618);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						bool flag3 = false;
					}
					long instruction_18 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9;
					int instruction_19 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_14;
					int num4 = *(int*)((byte*)GlobalVariablePointers.g_bitmasks + sizeof(int) * (int)(uint)instruction_19);
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_12 = (int)(instruction_18 & (uint)num4);
					int instruction_20 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_14;
					long instruction_21 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 = instruction_21 >>> (int)(uint)instruction_20;
					int instruction_22 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_14;
					int instruction_23 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 = instruction_23 - instruction_22;
					if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 < 32u)
					{
						if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_5)
						{
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
							goto IL_354c;
						}
						long num5 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10);
						long instruction_24 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 = instruction_24 | num5;
						int instruction_25 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8 = instruction_25 + 4;
						int instruction_26 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 = instruction_26 + 32;
					}
					if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_11 != 1 || startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_12 != 2)
					{
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
					}
					else
					{
						int* ptr5 = (int*)((byte*)ptr4 + sizeof(int) * 0);
						int instruction_27 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_5;
						bool flag4 = prepare_dynamic_block(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_6, instruction_27, ptr, ptr3, ptr2, ptr5, 4);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag4)
						{
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
						}
						else
						{
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_16 = null;
							void* instruction_28 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_3;
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_17 = instruction_28;
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_18 = 0;
							while (true)
							{
								if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_18 < (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_1)
								{
									if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 >= 12u)
									{
										bool flag5 = true;
									}
									else
									{
										IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2634);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										bool flag5 = false;
									}
									int instruction_29 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 & 0xFFFL));
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_19 = instruction_29;
									int instruction_30 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_19;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_20 = (instruction_30 >>> 9) & 0xF;
									if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_20 == 0)
									{
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
										break;
									}
									int instruction_31 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_20;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_21 = instruction_31;
									if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_21 <= 32u)
									{
										bool flag6 = true;
									}
									else
									{
										IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mf9hyza, GlobalVariablePointers.String_uxbkrtb, 2639);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										bool flag6 = false;
									}
									int instruction_32 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_21;
									long instruction_33 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 = instruction_33 >>> (int)(uint)instruction_32;
									int instruction_34 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_21;
									int instruction_35 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 = instruction_35 - instruction_34;
									if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 < 32u)
									{
										if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_5)
										{
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
											break;
										}
										long num6 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10);
										long instruction_36 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 = instruction_36 | num6;
										int instruction_37 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8 = instruction_37 + 4;
										int instruction_38 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 = instruction_38 + 32;
									}
									int instruction_39 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_19;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_19 = instruction_39 & 0x1FF;
									bool flag7 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_18 != 0;
									long num7 = (flag7 ? 1L : 0L);
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_22 = (flag7 ? 2 : 0);
									if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_19 != startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_22)
									{
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
										break;
									}
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23 = 0;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_24 = 0;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_25 = 0;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_26 = 0;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_27 = 0;
									while (true)
									{
										if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 >= 12u)
										{
											bool flag8 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2650);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											bool flag8 = false;
										}
										int instruction_40 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 & 0xFFFL));
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_28 = instruction_40;
										int instruction_41 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_28;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_29 = instruction_41;
										int instruction_42 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_28;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_30 = (instruction_42 >>> 9) & 0xF;
										if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_30 == 0)
										{
											break;
										}
										int instruction_43 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_30;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_31 = instruction_43;
										if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_31 <= 32u)
										{
											bool flag9 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mf9hyza, GlobalVariablePointers.String_uxbkrtb, 2657);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											bool flag9 = false;
										}
										int instruction_44 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_31;
										long instruction_45 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 = instruction_45 >>> (int)(uint)instruction_44;
										int instruction_46 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_31;
										int instruction_47 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 = instruction_47 - instruction_46;
										if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 < 32u)
										{
											if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_5)
											{
												goto IL_0fba;
											}
											long num8 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10);
											long instruction_48 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 = instruction_48 | num8;
											int instruction_49 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8 = instruction_49 + 4;
											int instruction_50 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 = instruction_50 + 32;
										}
										if ((startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_29 & 0x100) != 0)
										{
											int instruction_51 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_29;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_29 = instruction_51 & 0x1FF;
											if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_29 == 256)
											{
												goto IL_110d;
											}
											int instruction_52 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_29;
											int instruction_53 = *(int*)((byte*)GlobalVariablePointers.s_length_range + sizeof(int) * (int)(uint)(instruction_52 - 257));
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_32 = instruction_53;
											if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_29 >= 265u)
											{
												int instruction_54 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_29;
												int instruction_55 = *(int*)((byte*)GlobalVariablePointers.s_length_extra + sizeof(int) * (int)(uint)(instruction_54 - 257));
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_34 = instruction_55;
												if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_34 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_34 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_34)
												{
													bool flag10 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ftb25bb, GlobalVariablePointers.String_uxbkrtb, 2672);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag10 = false;
												}
												long instruction_56 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9;
												int instruction_57 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_34;
												int num9 = *(int*)((byte*)GlobalVariablePointers.g_bitmasks + sizeof(int) * (int)(uint)instruction_57);
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_33 = (int)(instruction_56 & (uint)num9);
												int instruction_58 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_34;
												long instruction_59 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 = instruction_59 >>> (int)(uint)instruction_58;
												int instruction_60 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_34;
												int instruction_61 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 = instruction_61 - instruction_60;
												int instruction_62 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_33;
												int instruction_63 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_32;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_32 = instruction_63 + instruction_62;
											}
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_35 = 1;
											if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_35 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_35)
											{
												bool flag11 = true;
											}
											else
											{
												IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_bahgbqd, GlobalVariablePointers.String_uxbkrtb, 2678);
												if (ExceptionInfo.Current != null)
												{
													return false;
												}
												bool flag11 = false;
											}
											int instruction_64 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_35;
											long instruction_65 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 = instruction_65 >>> (int)(uint)instruction_64;
											int instruction_66 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_35;
											int instruction_67 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 = instruction_67 - instruction_66;
											if ((startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_32 & 3) != 0)
											{
												goto IL_1558;
											}
											int instruction_68 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_32;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_36 = (instruction_68 >>> 2) * 3;
											int instruction_69 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23;
											int instruction_70 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_36;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_37 = instruction_69 + instruction_70;
											if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_37 > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_7)
											{
												goto IL_1616;
											}
											if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_16 != null)
											{
												if (((byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_24 | (byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_25 | (byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_26 | (byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_27) == 0)
												{
													IntrinsicFunctions.Implemented.llvm_memcpy_p0_p0_i64((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_17 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23, (byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_16 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23, (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_36, false);
													int instruction_71 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_37;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23 = instruction_71;
												}
												else
												{
													do
													{
														int num10;
														checked
														{
															num10 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_16)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23]) + unchecked((byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_24);
														}
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23] = (sbyte)num10;
														int num11;
														checked
														{
															num11 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23 + 1)]) + unchecked((byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_25);
														}
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23 + 1)] = (sbyte)num11;
														int num12;
														checked
														{
															num12 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23 + 2)]) + unchecked((byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_26);
														}
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23 + 2)] = (sbyte)num12;
														int instruction_72 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23;
														startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23 = instruction_72 + 3;
													}
													while ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23 < (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_37);
												}
											}
											else
											{
												do
												{
													sbyte instruction_73 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_24;
													((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23] = instruction_73;
													sbyte instruction_74 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_25;
													((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23 + 1)] = instruction_74;
													sbyte instruction_75 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_26;
													((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23 + 2)] = instruction_75;
													int instruction_76 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23 = instruction_76 + 3;
												}
												while ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23 < (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_37);
											}
										}
										else
										{
											int instruction_77 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_28;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_40 = instruction_77 >>> 25;
											if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_40 != 0)
											{
												int instruction_78 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_28;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_38 = (instruction_78 >>> 16) & 0x1FF;
												int instruction_79 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_40;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_42 = instruction_79;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_42 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_42)
												{
													bool flag12 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_bahgbqd, GlobalVariablePointers.String_uxbkrtb, 2771);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag12 = false;
												}
												int instruction_80 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_42;
												long instruction_81 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 = instruction_81 >>> (int)(uint)instruction_80;
												int instruction_82 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_42;
												int instruction_83 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 = instruction_83 - instruction_82;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 >= 12u)
												{
													bool flag13 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2773);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag13 = false;
												}
												int instruction_84 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 & 0xFFFL));
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_39 = instruction_84;
												int instruction_85 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_39;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_41 = (instruction_85 >>> 9) & 0xF;
												if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_41 == 0)
												{
													goto IL_1f39;
												}
											}
											else
											{
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 >= 12u)
												{
													bool flag14 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2781);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag14 = false;
												}
												int instruction_86 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 & 0xFFFL));
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_38 = instruction_86;
												int instruction_87 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_38;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_43 = (instruction_87 >>> 9) & 0xF;
												if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_43 == 0)
												{
													goto IL_205e;
												}
												int instruction_88 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_43;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_44 = instruction_88;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_44 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_44)
												{
													bool flag15 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_bahgbqd, GlobalVariablePointers.String_uxbkrtb, 2786);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag15 = false;
												}
												int instruction_89 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_44;
												long instruction_90 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 = instruction_90 >>> (int)(uint)instruction_89;
												int instruction_91 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_44;
												int instruction_92 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 = instruction_92 - instruction_91;
												int instruction_93 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_38;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_41 = instruction_93 >>> 25;
												if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_41 != 0)
												{
													int instruction_94 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_38;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_39 = instruction_94 >>> 16;
												}
												else
												{
													if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 >= 12u)
													{
														bool flag16 = true;
													}
													else
													{
														IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2793);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														bool flag16 = false;
													}
													int instruction_95 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 & 0xFFFL));
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_39 = instruction_95;
													int instruction_96 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_39;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_41 = (instruction_96 >>> 9) & 0xF;
													if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_41 == 0)
													{
														goto IL_233f;
													}
												}
											}
											int instruction_97 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_39;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_46 = instruction_97 >>> 25;
											if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_46 != 0)
											{
												int instruction_98 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_39;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_45 = instruction_98 >>> 16;
												int instruction_99 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_41;
												int instruction_100 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_46;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_47 = instruction_99 + instruction_100;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_47 <= 32u)
												{
													bool flag17 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mf9hyza, GlobalVariablePointers.String_uxbkrtb, 2807);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag17 = false;
												}
												int instruction_101 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_47;
												long instruction_102 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 = instruction_102 >>> (int)(uint)instruction_101;
												int instruction_103 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_47;
												int instruction_104 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 = instruction_104 - instruction_103;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 < 32u)
												{
													if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_5)
													{
														goto IL_2564;
													}
													long num13 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10);
													long instruction_105 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 = instruction_105 | num13;
													int instruction_106 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8 = instruction_106 + 4;
													int instruction_107 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 = instruction_107 + 32;
												}
											}
											else
											{
												int instruction_108 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_41;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_48 = instruction_108;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_48 <= 32u)
												{
													bool flag18 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mf9hyza, GlobalVariablePointers.String_uxbkrtb, 2811);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag18 = false;
												}
												int instruction_109 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_48;
												long instruction_110 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 = instruction_110 >>> (int)(uint)instruction_109;
												int instruction_111 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_48;
												int instruction_112 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 = instruction_112 - instruction_111;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 < 32u)
												{
													if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_5)
													{
														goto IL_27f2;
													}
													long num14 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10);
													long instruction_113 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 = instruction_113 | num14;
													int instruction_114 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8 = instruction_114 + 4;
													int instruction_115 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 = instruction_115 + 32;
												}
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 >= 12u)
												{
													bool flag19 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2813);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag19 = false;
												}
												int instruction_116 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 & 0xFFFL));
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_45 = instruction_116;
												int instruction_117 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_45;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_46 = (instruction_117 >>> 9) & 0xF;
												if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_46 == 0)
												{
													goto IL_2a19;
												}
												int instruction_118 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_46;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_49 = instruction_118;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_49 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_49)
												{
													bool flag20 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_bahgbqd, GlobalVariablePointers.String_uxbkrtb, 2819);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag20 = false;
												}
												int instruction_119 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_49;
												long instruction_120 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 = instruction_120 >>> (int)(uint)instruction_119;
												int instruction_121 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_49;
												int instruction_122 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 = instruction_122 - instruction_121;
											}
											if (((startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_38 | startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_39 | startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_45) & 0x100) != 0)
											{
												goto IL_2bdc;
											}
											if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_16 != null)
											{
												int num15 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_16)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23];
												int instruction_123 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_29;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23] = (sbyte)(num15 + instruction_123);
												int num16 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23 + 1)];
												int instruction_124 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_38;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23 + 1)] = (sbyte)(num16 + instruction_124);
												int num17 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23 + 2)];
												int instruction_125 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_39;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23 + 2)] = (sbyte)(num17 + instruction_125);
											}
											else
											{
												int instruction_126 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_29;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23] = (sbyte)instruction_126;
												int instruction_127 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_38;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23 + 1)] = (sbyte)instruction_127;
												int instruction_128 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_39;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23 + 2)] = (sbyte)instruction_128;
											}
											int instruction_129 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23 = instruction_129 + 3;
											int instruction_130 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_29;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_24 = (sbyte)instruction_130;
											int instruction_131 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_38;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_25 = (sbyte)instruction_131;
											int instruction_132 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_39;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_26 = (sbyte)instruction_132;
											int instruction_133 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_45;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_27 = (sbyte)instruction_133;
										}
										if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_23 < (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_7)
										{
											continue;
										}
										goto IL_30df;
									}
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
									break;
								}
								if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 >= 12u)
								{
									bool flag21 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2876);
									if (ExceptionInfo.Current != null)
									{
										return false;
									}
									bool flag21 = false;
								}
								int instruction_134 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 & 0xFFFL));
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_50 = instruction_134;
								int instruction_135 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_50;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_51 = (instruction_135 >>> 9) & 0xF;
								if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_51 == 0)
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
									break;
								}
								int instruction_136 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_50;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_50 = instruction_136 & 0x1FF;
								if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_50 != 256)
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
									break;
								}
								int instruction_137 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_51;
								int instruction_138 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 = instruction_138 - instruction_137;
								int instruction_139 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_51;
								long instruction_140 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 = instruction_140 >>> (int)(uint)instruction_139;
								int instruction_141 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_52 = instruction_141 & 7;
								int instruction_142 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_52;
								int instruction_143 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 = instruction_143 - instruction_142;
								int instruction_144 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_52;
								long instruction_145 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_9 = instruction_145 >>> (int)(uint)instruction_144;
								if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8 < (uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 >>> 3))
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
									break;
								}
								int num18 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_10 >>> 3;
								int instruction_146 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8 = instruction_146 - num18;
								if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_8 + 4 != startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_4)
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
								}
								else
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = true;
								}
								break;
								IL_233f:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
								break;
								IL_2bdc:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
								break;
								IL_2a19:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
								break;
								IL_1616:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
								break;
								IL_1558:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
								break;
								IL_2564:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
								break;
								IL_27f2:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
								break;
								IL_30df:
								void* instruction_147 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_17;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_16 = instruction_147;
								int instruction_148 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_7;
								void* instruction_149 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_17;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_17 = (byte*)instruction_149 + (uint)instruction_148;
								int instruction_150 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_18;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_18 = instruction_150 + 1;
								continue;
								IL_110d:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
								break;
								IL_205e:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
								break;
								IL_1f39:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
								break;
								IL_0fba:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0 = false;
								break;
							}
						}
					}
				}
			}
			goto IL_354c;
		}
		IL_354c:
		bool instruction_151 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_xygi9td>().Instruction_0;
		StackFrameList.Current.Clear(startFrame);
		return instruction_151;
	}

	[MangledName("??$fpng_pixel_zlib_decompress_3@$03@fpng@@YA_NPEBEIIPEAEII@Z")]
	[DemangledName("bool __cdecl fpng::fpng_pixel_zlib_decompress_3<4>(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int, unsigned int)")]
	[CleanName("fpng_pixel_zlib_decompress_3")]
	public unsafe static bool fpng_pixel_zlib_decompress_3_yffw42c(void* P_0, int P_1, int P_2, void* P_3, int P_4, int P_5)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>();
		int* ptr = &startFrame.GetLocalsPointer<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>()->Instruction_8;
		long* ptr2 = &startFrame.GetLocalsPointer<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>()->Instruction_9;
		int* ptr3 = &startFrame.GetLocalsPointer<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>()->Instruction_10;
		InlineArray_4096_vqkfj7a* ptr4 = &startFrame.GetLocalsPointer<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>()->Instruction_15;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_1 = P_5;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_2 = P_4;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_3 = P_3;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_4 = P_2;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_5 = P_1;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_6 = P_0;
		unchecked
		{
			if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_5 >= (uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_4 + 4))
			{
				bool flag = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_497patd, GlobalVariablePointers.String_uxbkrtb, 2214);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				bool flag = false;
			}
			int instruction_ = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_2;
			startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_7 = instruction_ * 4;
			if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_4 < 7u)
			{
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
			}
			else if ((byte)(*(sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_6) != 120 || (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_6)[1L] != 1)
			{
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
			}
			else
			{
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8 = 2;
				if (((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_6)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8] & 6) == 0)
				{
					int instruction_2 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_1;
					int instruction_3 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_2;
					void* instruction_4 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_3;
					int instruction_5 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_4;
					int instruction_6 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_5;
					bool instruction_7 = fpng_pixel_zlib_raw_decompress(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_6, instruction_6, instruction_5, instruction_4, instruction_3, instruction_2, 3, 4);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = instruction_7;
				}
				else if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_5)
				{
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
				}
				else
				{
					int num = *(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8);
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 = (uint)num;
					int instruction_8 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8 = instruction_8 + 4;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 = 32;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_13 = 1;
					if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_13 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_13 <= 32u)
					{
						bool flag2 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_aa3exrc, GlobalVariablePointers.String_uxbkrtb, 2239);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						bool flag2 = false;
					}
					long instruction_9 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9;
					int instruction_10 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_13;
					int num2 = *(int*)((byte*)GlobalVariablePointers.g_bitmasks + sizeof(int) * (int)(uint)instruction_10);
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_11 = (int)(instruction_9 & (uint)num2);
					int instruction_11 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_13;
					long instruction_12 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 = instruction_12 >>> (int)(uint)instruction_11;
					int instruction_13 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_13;
					int instruction_14 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 = instruction_14 - instruction_13;
					if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 < 32u)
					{
						if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_5)
						{
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
							goto IL_3f57;
						}
						long num3 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10);
						long instruction_15 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 = instruction_15 | num3;
						int instruction_16 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8 = instruction_16 + 4;
						int instruction_17 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 = instruction_17 + 32;
					}
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_14 = 2;
					if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_14 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_14 <= 32u)
					{
						bool flag3 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_aa3exrc, GlobalVariablePointers.String_uxbkrtb, 2240);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						bool flag3 = false;
					}
					long instruction_18 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9;
					int instruction_19 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_14;
					int num4 = *(int*)((byte*)GlobalVariablePointers.g_bitmasks + sizeof(int) * (int)(uint)instruction_19);
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_12 = (int)(instruction_18 & (uint)num4);
					int instruction_20 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_14;
					long instruction_21 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 = instruction_21 >>> (int)(uint)instruction_20;
					int instruction_22 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_14;
					int instruction_23 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 = instruction_23 - instruction_22;
					if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 < 32u)
					{
						if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_5)
						{
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
							goto IL_3f57;
						}
						long num5 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10);
						long instruction_24 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 = instruction_24 | num5;
						int instruction_25 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8 = instruction_25 + 4;
						int instruction_26 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 = instruction_26 + 32;
					}
					if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_11 != 1 || startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_12 != 2)
					{
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
					}
					else
					{
						int* ptr5 = (int*)((byte*)ptr4 + sizeof(int) * 0);
						int instruction_27 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_5;
						bool flag4 = prepare_dynamic_block(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_6, instruction_27, ptr, ptr3, ptr2, ptr5, 3);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag4)
						{
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
						}
						else
						{
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_16 = null;
							void* instruction_28 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_3;
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17 = instruction_28;
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_18 = 0;
							while (true)
							{
								if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_18 < (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_1)
								{
									if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 >= 12u)
									{
										bool flag5 = true;
									}
									else
									{
										IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2256);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										bool flag5 = false;
									}
									int instruction_29 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 & 0xFFFL));
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_19 = instruction_29;
									int instruction_30 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_19;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_20 = (instruction_30 >>> 9) & 0xF;
									if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_20 == 0)
									{
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
										break;
									}
									int instruction_31 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_20;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_21 = instruction_31;
									if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_21 <= 32u)
									{
										bool flag6 = true;
									}
									else
									{
										IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mf9hyza, GlobalVariablePointers.String_uxbkrtb, 2261);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										bool flag6 = false;
									}
									int instruction_32 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_21;
									long instruction_33 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 = instruction_33 >>> (int)(uint)instruction_32;
									int instruction_34 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_21;
									int instruction_35 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 = instruction_35 - instruction_34;
									if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 < 32u)
									{
										if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_5)
										{
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
											break;
										}
										long num6 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10);
										long instruction_36 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 = instruction_36 | num6;
										int instruction_37 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8 = instruction_37 + 4;
										int instruction_38 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 = instruction_38 + 32;
									}
									int instruction_39 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_19;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_19 = instruction_39 & 0x1FF;
									bool flag7 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_18 != 0;
									long num7 = (flag7 ? 1L : 0L);
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_22 = (flag7 ? 2 : 0);
									if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_19 != startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_22)
									{
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
										break;
									}
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 = 0;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_24 = 0;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_25 = 0;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_26 = 0;
									while (true)
									{
										if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 >= 12u)
										{
											bool flag8 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2272);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											bool flag8 = false;
										}
										int instruction_40 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 & 0xFFFL));
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_27 = instruction_40;
										int instruction_41 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_27;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_28 = instruction_41;
										int instruction_42 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_27;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_29 = (instruction_42 >>> 9) & 0xF;
										if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_29 == 0)
										{
											break;
										}
										int instruction_43 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_29;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_30 = instruction_43;
										if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_30 <= 32u)
										{
											bool flag9 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mf9hyza, GlobalVariablePointers.String_uxbkrtb, 2279);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											bool flag9 = false;
										}
										int instruction_44 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_30;
										long instruction_45 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 = instruction_45 >>> (int)(uint)instruction_44;
										int instruction_46 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_30;
										int instruction_47 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 = instruction_47 - instruction_46;
										if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 < 32u)
										{
											if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_5)
											{
												goto IL_0fac;
											}
											long num8 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10);
											long instruction_48 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 = instruction_48 | num8;
											int instruction_49 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8 = instruction_49 + 4;
											int instruction_50 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 = instruction_50 + 32;
										}
										if ((startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_28 & 0x100) != 0)
										{
											int instruction_51 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_28;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_28 = instruction_51 & 0x1FF;
											if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_28 == 256)
											{
												goto IL_10ff;
											}
											int instruction_52 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_28;
											int instruction_53 = *(int*)((byte*)GlobalVariablePointers.s_length_range + sizeof(int) * (int)(uint)(instruction_52 - 257));
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_31 = instruction_53;
											if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_28 >= 265u)
											{
												int instruction_54 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_28;
												int instruction_55 = *(int*)((byte*)GlobalVariablePointers.s_length_extra + sizeof(int) * (int)(uint)(instruction_54 - 257));
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_33 = instruction_55;
												if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_33 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_33 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_33)
												{
													bool flag10 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ftb25bb, GlobalVariablePointers.String_uxbkrtb, 2294);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag10 = false;
												}
												long instruction_56 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9;
												int instruction_57 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_33;
												int num9 = *(int*)((byte*)GlobalVariablePointers.g_bitmasks + sizeof(int) * (int)(uint)instruction_57);
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_32 = (int)(instruction_56 & (uint)num9);
												int instruction_58 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_33;
												long instruction_59 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 = instruction_59 >>> (int)(uint)instruction_58;
												int instruction_60 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_33;
												int instruction_61 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 = instruction_61 - instruction_60;
												int instruction_62 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_32;
												int instruction_63 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_31;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_31 = instruction_63 + instruction_62;
											}
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_34 = 1;
											if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_34 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_34)
											{
												bool flag11 = true;
											}
											else
											{
												IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_bahgbqd, GlobalVariablePointers.String_uxbkrtb, 2300);
												if (ExceptionInfo.Current != null)
												{
													return false;
												}
												bool flag11 = false;
											}
											int instruction_64 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_34;
											long instruction_65 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 = instruction_65 >>> (int)(uint)instruction_64;
											int instruction_66 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_34;
											int instruction_67 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 = instruction_67 - instruction_66;
											if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_31 % 3u == 0)
											{
												bool flag12 = true;
											}
											else
											{
												IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_a5rp7bb, GlobalVariablePointers.String_uxbkrtb, 2303);
												if (ExceptionInfo.Current != null)
												{
													return false;
												}
												bool flag12 = false;
											}
											int instruction_68 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23;
											int instruction_69 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_31;
											short num10 = *(short*)((byte*)GlobalVariablePointers.g_run_len3_to_4 + sizeof(short) * (int)(uint)instruction_69);
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_35 = instruction_68 + (ushort)num10;
											if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 == startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_35)
											{
												goto IL_1625;
											}
											if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_35 > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_7)
											{
												goto IL_1670;
											}
											if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_16 != null)
											{
												if (((byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_24 | (byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_25 | (byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_26) == 0)
												{
													IntrinsicFunctions.Implemented.llvm_memcpy_p0_p0_i64((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23, (byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_16 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23, (uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_35 - startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23), false);
													int instruction_70 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_35;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 = instruction_70;
												}
												else
												{
													do
													{
														int num11;
														checked
														{
															num11 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_16)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23]) + unchecked((byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_24);
														}
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23] = (sbyte)num11;
														int num12;
														checked
														{
															num12 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 1)]) + unchecked((byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_25);
														}
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 1)] = (sbyte)num12;
														int num13;
														checked
														{
															num13 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 2)]) + unchecked((byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_26);
														}
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 2)] = (sbyte)num13;
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 3)] = -1;
														int instruction_71 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23;
														startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 = instruction_71 + 4;
													}
													while ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 < (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_35);
												}
											}
											else
											{
												do
												{
													sbyte instruction_72 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_24;
													((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23] = instruction_72;
													sbyte instruction_73 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_25;
													((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 1)] = instruction_73;
													sbyte instruction_74 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_26;
													((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 2)] = instruction_74;
													((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 3)] = -1;
													int instruction_75 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 = instruction_75 + 4;
												}
												while ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 < (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_35);
											}
										}
										else
										{
											int instruction_76 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_27;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_38 = instruction_76 >>> 25;
											if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_38 != 0)
											{
												int instruction_77 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_27;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_36 = (instruction_77 >>> 16) & 0x1FF;
												int instruction_78 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_38;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_40 = instruction_78;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_40 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_40)
												{
													bool flag13 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_bahgbqd, GlobalVariablePointers.String_uxbkrtb, 2399);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag13 = false;
												}
												int instruction_79 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_40;
												long instruction_80 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 = instruction_80 >>> (int)(uint)instruction_79;
												int instruction_81 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_40;
												int instruction_82 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 = instruction_82 - instruction_81;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 >= 12u)
												{
													bool flag14 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2401);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag14 = false;
												}
												int instruction_83 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 & 0xFFFL));
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_37 = instruction_83;
												int instruction_84 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_37;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_39 = (instruction_84 >>> 9) & 0xF;
												if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_39 == 0)
												{
													goto IL_2029;
												}
											}
											else
											{
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 >= 12u)
												{
													bool flag15 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2409);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag15 = false;
												}
												int instruction_85 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 & 0xFFFL));
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_36 = instruction_85;
												int instruction_86 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_36;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_41 = (instruction_86 >>> 9) & 0xF;
												if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_41 == 0)
												{
													goto IL_214e;
												}
												int instruction_87 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_41;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_42 = instruction_87;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_42 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_42)
												{
													bool flag16 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_bahgbqd, GlobalVariablePointers.String_uxbkrtb, 2414);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag16 = false;
												}
												int instruction_88 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_42;
												long instruction_89 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 = instruction_89 >>> (int)(uint)instruction_88;
												int instruction_90 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_42;
												int instruction_91 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 = instruction_91 - instruction_90;
												int instruction_92 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_36;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_39 = instruction_92 >>> 25;
												if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_39 != 0)
												{
													int instruction_93 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_36;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_37 = instruction_93 >>> 16;
												}
												else
												{
													if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 >= 12u)
													{
														bool flag17 = true;
													}
													else
													{
														IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2421);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														bool flag17 = false;
													}
													int instruction_94 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 & 0xFFFL));
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_37 = instruction_94;
													int instruction_95 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_37;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_39 = (instruction_95 >>> 9) & 0xF;
													if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_39 == 0)
													{
														goto IL_242f;
													}
												}
											}
											int instruction_96 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_39;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_43 = instruction_96;
											if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_43 <= 32u)
											{
												bool flag18 = true;
											}
											else
											{
												IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mf9hyza, GlobalVariablePointers.String_uxbkrtb, 2429);
												if (ExceptionInfo.Current != null)
												{
													return false;
												}
												bool flag18 = false;
											}
											int instruction_97 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_43;
											long instruction_98 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 = instruction_98 >>> (int)(uint)instruction_97;
											int instruction_99 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_43;
											int instruction_100 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 = instruction_100 - instruction_99;
											if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 < 32u)
											{
												if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_5)
												{
													goto IL_25b5;
												}
												long num14 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10);
												long instruction_101 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 = instruction_101 | num14;
												int instruction_102 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8 = instruction_102 + 4;
												int instruction_103 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 = instruction_103 + 32;
											}
											if (((startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_36 | startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_37) & 0x100) != 0)
											{
												goto IL_2723;
											}
											if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_16 != null)
											{
												int num15 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_16)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23];
												int instruction_104 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_28;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23] = (sbyte)(num15 + instruction_104);
												int num16 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 1)];
												int instruction_105 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_36;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 1)] = (sbyte)(num16 + instruction_105);
												int num17 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 2)];
												int instruction_106 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_37;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 2)] = (sbyte)(num17 + instruction_106);
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 3)] = -1;
											}
											else
											{
												int instruction_107 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_28;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23] = (sbyte)instruction_107;
												int instruction_108 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_36;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 1)] = (sbyte)instruction_108;
												int instruction_109 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_37;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 2)] = (sbyte)instruction_109;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 3)] = -1;
											}
											int instruction_110 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 = instruction_110 + 4;
											int instruction_111 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_28;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_24 = (sbyte)instruction_111;
											int instruction_112 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_36;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_25 = (sbyte)instruction_112;
											int instruction_113 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_37;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_26 = (sbyte)instruction_113;
											int instruction_114 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_37;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_44 = instruction_114 >>> 25;
											if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_44 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 < (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_7)
											{
												int instruction_115 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_37;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_28 = (instruction_115 >>> 16) & 0x1FF;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_28 < 256u)
												{
													int instruction_116 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_44;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_45 = instruction_116;
													if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_45 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_45)
													{
														bool flag19 = true;
													}
													else
													{
														IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_bahgbqd, GlobalVariablePointers.String_uxbkrtb, 2481);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														bool flag19 = false;
													}
													int instruction_117 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_45;
													long instruction_118 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 = instruction_118 >>> (int)(uint)instruction_117;
													int instruction_119 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_45;
													int instruction_120 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 = instruction_120 - instruction_119;
													if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 >= 12u)
													{
														bool flag20 = true;
													}
													else
													{
														IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2483);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														bool flag20 = false;
													}
													int instruction_121 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 & 0xFFFL));
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_36 = instruction_121;
													int instruction_122 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_36;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_46 = (instruction_122 >>> 9) & 0xF;
													if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_46 == 0)
													{
														goto IL_2f99;
													}
													int instruction_123 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_46;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_47 = instruction_123;
													if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_47 <= 32u)
													{
														bool flag21 = true;
													}
													else
													{
														IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mf9hyza, GlobalVariablePointers.String_uxbkrtb, 2488);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														bool flag21 = false;
													}
													int instruction_124 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_47;
													long instruction_125 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 = instruction_125 >>> (int)(uint)instruction_124;
													int instruction_126 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_47;
													int instruction_127 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 = instruction_127 - instruction_126;
													if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 < 32u)
													{
														if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_5)
														{
															goto IL_3119;
														}
														long num18 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10);
														long instruction_128 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9;
														startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 = instruction_128 | num18;
														int instruction_129 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8;
														startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8 = instruction_129 + 4;
														int instruction_130 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10;
														startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 = instruction_130 + 32;
													}
													int instruction_131 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_36;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_39 = instruction_131 >>> 25;
													if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_39 != 0)
													{
														int instruction_132 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_36;
														startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_37 = instruction_132 >>> 16;
													}
													else
													{
														if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 >= 12u)
														{
															bool flag22 = true;
														}
														else
														{
															IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2495);
															if (ExceptionInfo.Current != null)
															{
																return false;
															}
															bool flag22 = false;
														}
														int instruction_133 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 & 0xFFFL));
														startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_37 = instruction_133;
														int instruction_134 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_37;
														startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_39 = (instruction_134 >>> 9) & 0xF;
														if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_39 == 0)
														{
															goto IL_33c5;
														}
													}
													int instruction_135 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_39;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_48 = instruction_135;
													if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_48 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_48)
													{
														bool flag23 = true;
													}
													else
													{
														IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_bahgbqd, GlobalVariablePointers.String_uxbkrtb, 2502);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														bool flag23 = false;
													}
													int instruction_136 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_48;
													long instruction_137 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 = instruction_137 >>> (int)(uint)instruction_136;
													int instruction_138 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_48;
													int instruction_139 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 = instruction_139 - instruction_138;
													if (((startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_36 | startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_37) & 0x100) != 0)
													{
														goto IL_356b;
													}
													if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_16 != null)
													{
														int num19 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_16)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23];
														int instruction_140 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_28;
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23] = (sbyte)(num19 + instruction_140);
														int num20 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 1)];
														int instruction_141 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_36;
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 1)] = (sbyte)(num20 + instruction_141);
														int num21 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 2)];
														int instruction_142 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_37;
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 2)] = (sbyte)(num21 + instruction_142);
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 3)] = -1;
													}
													else
													{
														int instruction_143 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_28;
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23] = (sbyte)instruction_143;
														int instruction_144 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_36;
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 1)] = (sbyte)instruction_144;
														int instruction_145 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_37;
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 2)] = (sbyte)instruction_145;
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 + 3)] = -1;
													}
													int instruction_146 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 = instruction_146 + 4;
													int instruction_147 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_28;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_24 = (sbyte)instruction_147;
													int instruction_148 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_36;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_25 = (sbyte)instruction_148;
													int instruction_149 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_37;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_26 = (sbyte)instruction_149;
												}
											}
										}
										if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_23 < (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_7)
										{
											continue;
										}
										goto IL_3aea;
									}
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
									break;
								}
								if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 >= 12u)
								{
									bool flag24 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2560);
									if (ExceptionInfo.Current != null)
									{
										return false;
									}
									bool flag24 = false;
								}
								int instruction_150 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 & 0xFFFL));
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_49 = instruction_150;
								int instruction_151 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_49;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_50 = (instruction_151 >>> 9) & 0xF;
								if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_50 == 0)
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
									break;
								}
								int instruction_152 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_49;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_49 = instruction_152 & 0x1FF;
								if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_49 != 256)
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
									break;
								}
								int instruction_153 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_50;
								int instruction_154 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 = instruction_154 - instruction_153;
								int instruction_155 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_50;
								long instruction_156 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 = instruction_156 >>> (int)(uint)instruction_155;
								int instruction_157 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_51 = instruction_157 & 7;
								int instruction_158 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_51;
								int instruction_159 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 = instruction_159 - instruction_158;
								int instruction_160 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_51;
								long instruction_161 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_9 = instruction_161 >>> (int)(uint)instruction_160;
								if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8 < (uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 >>> 3))
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
									break;
								}
								int num22 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_10 >>> 3;
								int instruction_162 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8 = instruction_162 - num22;
								if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_8 + 4 != startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_4)
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
								}
								else
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = true;
								}
								break;
								IL_1670:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
								break;
								IL_3aea:
								void* instruction_163 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_16 = instruction_163;
								int instruction_164 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_7;
								void* instruction_165 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_17 = (byte*)instruction_165 + (uint)instruction_164;
								int instruction_166 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_18;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_18 = instruction_166 + 1;
								continue;
								IL_10ff:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
								break;
								IL_356b:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
								break;
								IL_0fac:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
								break;
								IL_1625:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
								break;
								IL_25b5:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
								break;
								IL_242f:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
								break;
								IL_2029:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
								break;
								IL_33c5:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
								break;
								IL_3119:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
								break;
								IL_2723:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
								break;
								IL_214e:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
								break;
								IL_2f99:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0 = false;
								break;
							}
						}
					}
				}
			}
			goto IL_3f57;
		}
		IL_3f57:
		bool instruction_167 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_3_yffw42c>().Instruction_0;
		StackFrameList.Current.Clear(startFrame);
		return instruction_167;
	}

	[MangledName("??$fpng_pixel_zlib_decompress_4@$03@fpng@@YA_NPEBEIIPEAEII@Z")]
	[DemangledName("bool __cdecl fpng::fpng_pixel_zlib_decompress_4<4>(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int, unsigned int)")]
	[CleanName("fpng_pixel_zlib_decompress_4")]
	public unsafe static bool fpng_pixel_zlib_decompress_4_amptoaa(void* P_0, int P_1, int P_2, void* P_3, int P_4, int P_5)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>();
		int* ptr = &startFrame.GetLocalsPointer<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>()->Instruction_8;
		long* ptr2 = &startFrame.GetLocalsPointer<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>()->Instruction_9;
		int* ptr3 = &startFrame.GetLocalsPointer<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>()->Instruction_10;
		InlineArray_4096_vqkfj7a* ptr4 = &startFrame.GetLocalsPointer<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>()->Instruction_15;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_1 = P_5;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_2 = P_4;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_3 = P_3;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_4 = P_2;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_5 = P_1;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_6 = P_0;
		unchecked
		{
			if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_5 >= (uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_4 + 4))
			{
				bool flag = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_497patd, GlobalVariablePointers.String_uxbkrtb, 2592);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				bool flag = false;
			}
			int instruction_ = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_2;
			startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_7 = instruction_ * 4;
			if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_4 < 7u)
			{
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
			}
			else if ((byte)(*(sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_6) != 120 || (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_6)[1L] != 1)
			{
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
			}
			else
			{
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8 = 2;
				if (((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_6)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8] & 6) == 0)
				{
					int instruction_2 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_1;
					int instruction_3 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_2;
					void* instruction_4 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_3;
					int instruction_5 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_4;
					int instruction_6 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_5;
					bool instruction_7 = fpng_pixel_zlib_raw_decompress(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_6, instruction_6, instruction_5, instruction_4, instruction_3, instruction_2, 4, 4);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = instruction_7;
				}
				else if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_5)
				{
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
				}
				else
				{
					int num = *(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8);
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 = (uint)num;
					int instruction_8 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8 = instruction_8 + 4;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 = 32;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_13 = 1;
					if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_13 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_13 <= 32u)
					{
						bool flag2 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_aa3exrc, GlobalVariablePointers.String_uxbkrtb, 2617);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						bool flag2 = false;
					}
					long instruction_9 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9;
					int instruction_10 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_13;
					int num2 = *(int*)((byte*)GlobalVariablePointers.g_bitmasks + sizeof(int) * (int)(uint)instruction_10);
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_11 = (int)(instruction_9 & (uint)num2);
					int instruction_11 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_13;
					long instruction_12 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 = instruction_12 >>> (int)(uint)instruction_11;
					int instruction_13 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_13;
					int instruction_14 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 = instruction_14 - instruction_13;
					if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 < 32u)
					{
						if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_5)
						{
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
							goto IL_379c;
						}
						long num3 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10);
						long instruction_15 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 = instruction_15 | num3;
						int instruction_16 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8 = instruction_16 + 4;
						int instruction_17 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 = instruction_17 + 32;
					}
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_14 = 2;
					if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_14 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_14 <= 32u)
					{
						bool flag3 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_aa3exrc, GlobalVariablePointers.String_uxbkrtb, 2618);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						bool flag3 = false;
					}
					long instruction_18 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9;
					int instruction_19 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_14;
					int num4 = *(int*)((byte*)GlobalVariablePointers.g_bitmasks + sizeof(int) * (int)(uint)instruction_19);
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_12 = (int)(instruction_18 & (uint)num4);
					int instruction_20 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_14;
					long instruction_21 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 = instruction_21 >>> (int)(uint)instruction_20;
					int instruction_22 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_14;
					int instruction_23 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 = instruction_23 - instruction_22;
					if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 < 32u)
					{
						if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_5)
						{
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
							goto IL_379c;
						}
						long num5 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10);
						long instruction_24 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 = instruction_24 | num5;
						int instruction_25 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8 = instruction_25 + 4;
						int instruction_26 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 = instruction_26 + 32;
					}
					if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_11 != 1 || startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_12 != 2)
					{
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
					}
					else
					{
						int* ptr5 = (int*)((byte*)ptr4 + sizeof(int) * 0);
						int instruction_27 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_5;
						bool flag4 = prepare_dynamic_block(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_6, instruction_27, ptr, ptr3, ptr2, ptr5, 4);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag4)
						{
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
						}
						else
						{
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_16 = null;
							void* instruction_28 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_3;
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_17 = instruction_28;
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_18 = 0;
							while (true)
							{
								if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_18 < (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_1)
								{
									if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 >= 12u)
									{
										bool flag5 = true;
									}
									else
									{
										IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2634);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										bool flag5 = false;
									}
									int instruction_29 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 & 0xFFFL));
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_19 = instruction_29;
									int instruction_30 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_19;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_20 = (instruction_30 >>> 9) & 0xF;
									if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_20 == 0)
									{
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
										break;
									}
									int instruction_31 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_20;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_21 = instruction_31;
									if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_21 <= 32u)
									{
										bool flag6 = true;
									}
									else
									{
										IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mf9hyza, GlobalVariablePointers.String_uxbkrtb, 2639);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										bool flag6 = false;
									}
									int instruction_32 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_21;
									long instruction_33 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 = instruction_33 >>> (int)(uint)instruction_32;
									int instruction_34 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_21;
									int instruction_35 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 = instruction_35 - instruction_34;
									if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 < 32u)
									{
										if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_5)
										{
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
											break;
										}
										long num6 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10);
										long instruction_36 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 = instruction_36 | num6;
										int instruction_37 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8 = instruction_37 + 4;
										int instruction_38 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 = instruction_38 + 32;
									}
									int instruction_39 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_19;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_19 = instruction_39 & 0x1FF;
									bool flag7 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_18 != 0;
									long num7 = (flag7 ? 1L : 0L);
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_22 = (flag7 ? 2 : 0);
									if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_19 != startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_22)
									{
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
										break;
									}
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 = 0;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_24 = 0;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_25 = 0;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_26 = 0;
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_27 = 0;
									while (true)
									{
										if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 >= 12u)
										{
											bool flag8 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2650);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											bool flag8 = false;
										}
										int instruction_40 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 & 0xFFFL));
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_28 = instruction_40;
										int instruction_41 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_28;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_29 = instruction_41;
										int instruction_42 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_28;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_30 = (instruction_42 >>> 9) & 0xF;
										if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_30 == 0)
										{
											break;
										}
										int instruction_43 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_30;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_31 = instruction_43;
										if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_31 <= 32u)
										{
											bool flag9 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mf9hyza, GlobalVariablePointers.String_uxbkrtb, 2657);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											bool flag9 = false;
										}
										int instruction_44 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_31;
										long instruction_45 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 = instruction_45 >>> (int)(uint)instruction_44;
										int instruction_46 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_31;
										int instruction_47 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10;
										startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 = instruction_47 - instruction_46;
										if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 < 32u)
										{
											if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_5)
											{
												goto IL_0fba;
											}
											long num8 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10);
											long instruction_48 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 = instruction_48 | num8;
											int instruction_49 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8 = instruction_49 + 4;
											int instruction_50 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 = instruction_50 + 32;
										}
										if ((startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_29 & 0x100) != 0)
										{
											int instruction_51 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_29;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_29 = instruction_51 & 0x1FF;
											if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_29 == 256)
											{
												goto IL_110d;
											}
											int instruction_52 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_29;
											int instruction_53 = *(int*)((byte*)GlobalVariablePointers.s_length_range + sizeof(int) * (int)(uint)(instruction_52 - 257));
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_32 = instruction_53;
											if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_29 >= 265u)
											{
												int instruction_54 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_29;
												int instruction_55 = *(int*)((byte*)GlobalVariablePointers.s_length_extra + sizeof(int) * (int)(uint)(instruction_54 - 257));
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_34 = instruction_55;
												if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_34 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_34 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_34)
												{
													bool flag10 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ftb25bb, GlobalVariablePointers.String_uxbkrtb, 2672);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag10 = false;
												}
												long instruction_56 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9;
												int instruction_57 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_34;
												int num9 = *(int*)((byte*)GlobalVariablePointers.g_bitmasks + sizeof(int) * (int)(uint)instruction_57);
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_33 = (int)(instruction_56 & (uint)num9);
												int instruction_58 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_34;
												long instruction_59 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 = instruction_59 >>> (int)(uint)instruction_58;
												int instruction_60 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_34;
												int instruction_61 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 = instruction_61 - instruction_60;
												int instruction_62 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_33;
												int instruction_63 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_32;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_32 = instruction_63 + instruction_62;
											}
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_35 = 1;
											if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_35 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_35)
											{
												bool flag11 = true;
											}
											else
											{
												IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_bahgbqd, GlobalVariablePointers.String_uxbkrtb, 2678);
												if (ExceptionInfo.Current != null)
												{
													return false;
												}
												bool flag11 = false;
											}
											int instruction_64 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_35;
											long instruction_65 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 = instruction_65 >>> (int)(uint)instruction_64;
											int instruction_66 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_35;
											int instruction_67 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 = instruction_67 - instruction_66;
											if ((startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_32 & 3) != 0)
											{
												goto IL_1558;
											}
											int instruction_68 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23;
											int instruction_69 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_32;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_36 = instruction_68 + instruction_69;
											if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_36 > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_7)
											{
												goto IL_15e1;
											}
											if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_16 != null)
											{
												if (((byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_24 | (byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_25 | (byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_26 | (byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_27) == 0)
												{
													IntrinsicFunctions.Implemented.llvm_memcpy_p0_p0_i64((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_17 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23, (byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_16 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23, (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_32, false);
													int instruction_70 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_36;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 = instruction_70;
												}
												else
												{
													do
													{
														int num10;
														checked
														{
															num10 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_16)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23]) + unchecked((byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_24);
														}
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23] = (sbyte)num10;
														int num11;
														checked
														{
															num11 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 + 1)]) + unchecked((byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_25);
														}
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 + 1)] = (sbyte)num11;
														int num12;
														checked
														{
															num12 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 + 2)]) + unchecked((byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_26);
														}
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 + 2)] = (sbyte)num12;
														int num13;
														checked
														{
															num13 = unchecked((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 + 3)]) + unchecked((byte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_27);
														}
														((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 + 3)] = (sbyte)num13;
														int instruction_71 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23;
														startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 = instruction_71 + 4;
													}
													while ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 < (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_36);
												}
											}
											else
											{
												do
												{
													sbyte instruction_72 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_24;
													((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23] = instruction_72;
													sbyte instruction_73 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_25;
													((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 + 1)] = instruction_73;
													sbyte instruction_74 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_26;
													((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 + 2)] = instruction_74;
													sbyte instruction_75 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_27;
													((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 + 3)] = instruction_75;
													int instruction_76 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 = instruction_76 + 4;
												}
												while ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 < (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_36);
											}
										}
										else
										{
											int instruction_77 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_28;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_39 = instruction_77 >>> 25;
											if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_39 != 0)
											{
												int instruction_78 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_28;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_37 = (instruction_78 >>> 16) & 0x1FF;
												int instruction_79 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_39;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_41 = instruction_79;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_41 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_41)
												{
													bool flag12 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_bahgbqd, GlobalVariablePointers.String_uxbkrtb, 2771);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag12 = false;
												}
												int instruction_80 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_41;
												long instruction_81 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 = instruction_81 >>> (int)(uint)instruction_80;
												int instruction_82 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_41;
												int instruction_83 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 = instruction_83 - instruction_82;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 >= 12u)
												{
													bool flag13 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2773);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag13 = false;
												}
												int instruction_84 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 & 0xFFFL));
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_38 = instruction_84;
												int instruction_85 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_38;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_40 = (instruction_85 >>> 9) & 0xF;
												if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_40 == 0)
												{
													goto IL_2047;
												}
											}
											else
											{
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 >= 12u)
												{
													bool flag14 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2781);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag14 = false;
												}
												int instruction_86 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 & 0xFFFL));
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_37 = instruction_86;
												int instruction_87 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_37;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_42 = (instruction_87 >>> 9) & 0xF;
												if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_42 == 0)
												{
													goto IL_216c;
												}
												int instruction_88 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_42;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_43 = instruction_88;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_43 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_43)
												{
													bool flag15 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_bahgbqd, GlobalVariablePointers.String_uxbkrtb, 2786);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag15 = false;
												}
												int instruction_89 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_43;
												long instruction_90 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 = instruction_90 >>> (int)(uint)instruction_89;
												int instruction_91 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_43;
												int instruction_92 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 = instruction_92 - instruction_91;
												int instruction_93 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_37;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_40 = instruction_93 >>> 25;
												if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_40 != 0)
												{
													int instruction_94 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_37;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_38 = instruction_94 >>> 16;
												}
												else
												{
													if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 >= 12u)
													{
														bool flag16 = true;
													}
													else
													{
														IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2793);
														if (ExceptionInfo.Current != null)
														{
															return false;
														}
														bool flag16 = false;
													}
													int instruction_95 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 & 0xFFFL));
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_38 = instruction_95;
													int instruction_96 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_38;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_40 = (instruction_96 >>> 9) & 0xF;
													if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_40 == 0)
													{
														goto IL_244d;
													}
												}
											}
											int instruction_97 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_38;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_45 = instruction_97 >>> 25;
											if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_45 != 0)
											{
												int instruction_98 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_38;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_44 = instruction_98 >>> 16;
												int instruction_99 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_40;
												int instruction_100 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_45;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_46 = instruction_99 + instruction_100;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_46 <= 32u)
												{
													bool flag17 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mf9hyza, GlobalVariablePointers.String_uxbkrtb, 2807);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag17 = false;
												}
												int instruction_101 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_46;
												long instruction_102 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 = instruction_102 >>> (int)(uint)instruction_101;
												int instruction_103 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_46;
												int instruction_104 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 = instruction_104 - instruction_103;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 < 32u)
												{
													if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_5)
													{
														goto IL_2672;
													}
													long num14 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10);
													long instruction_105 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 = instruction_105 | num14;
													int instruction_106 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8 = instruction_106 + 4;
													int instruction_107 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 = instruction_107 + 32;
												}
											}
											else
											{
												int instruction_108 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_40;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_47 = instruction_108;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_47 <= 32u)
												{
													bool flag18 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mf9hyza, GlobalVariablePointers.String_uxbkrtb, 2811);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag18 = false;
												}
												int instruction_109 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_47;
												long instruction_110 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 = instruction_110 >>> (int)(uint)instruction_109;
												int instruction_111 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_47;
												int instruction_112 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 = instruction_112 - instruction_111;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 < 32u)
												{
													if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_5)
													{
														goto IL_2900;
													}
													long num15 = (long)((ulong)(uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_6 + (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8)) << (int)(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10);
													long instruction_113 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 = instruction_113 | num15;
													int instruction_114 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8 = instruction_114 + 4;
													int instruction_115 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10;
													startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 = instruction_115 + 32;
												}
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 >= 12u)
												{
													bool flag19 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2813);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag19 = false;
												}
												int instruction_116 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 & 0xFFFL));
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_44 = instruction_116;
												int instruction_117 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_44;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_45 = (instruction_117 >>> 9) & 0xF;
												if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_45 == 0)
												{
													goto IL_2b27;
												}
												int instruction_118 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_45;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_48 = instruction_118;
												if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_48 <= 32u && (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 >= (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_48)
												{
													bool flag20 = true;
												}
												else
												{
													IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_bahgbqd, GlobalVariablePointers.String_uxbkrtb, 2819);
													if (ExceptionInfo.Current != null)
													{
														return false;
													}
													bool flag20 = false;
												}
												int instruction_119 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_48;
												long instruction_120 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 = instruction_120 >>> (int)(uint)instruction_119;
												int instruction_121 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_48;
												int instruction_122 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10;
												startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 = instruction_122 - instruction_121;
											}
											if (((startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_37 | startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_38 | startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_44) & 0x100) != 0)
											{
												goto IL_2cea;
											}
											if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_16 != null)
											{
												int num16 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_16)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23];
												int instruction_123 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_29;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23] = (sbyte)(num16 + instruction_123);
												int num17 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 + 1)];
												int instruction_124 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_37;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 + 1)] = (sbyte)(num17 + instruction_124);
												int num18 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 + 2)];
												int instruction_125 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_38;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 + 2)] = (sbyte)(num18 + instruction_125);
												int num19 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_16)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 + 3)];
												int instruction_126 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_44;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 + 3)] = (sbyte)(num19 + instruction_126);
											}
											else
											{
												int instruction_127 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_29;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_17)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23] = (sbyte)instruction_127;
												int instruction_128 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_37;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 + 1)] = (sbyte)instruction_128;
												int instruction_129 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_38;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 + 2)] = (sbyte)instruction_129;
												int instruction_130 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_44;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_17)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 + 3)] = (sbyte)instruction_130;
											}
											int instruction_131 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 = instruction_131 + 4;
											int instruction_132 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_29;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_24 = (sbyte)instruction_132;
											int instruction_133 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_37;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_25 = (sbyte)instruction_133;
											int instruction_134 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_38;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_26 = (sbyte)instruction_134;
											int instruction_135 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_44;
											startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_27 = (sbyte)instruction_135;
										}
										if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_23 < (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_7)
										{
											continue;
										}
										goto IL_332f;
									}
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
									break;
								}
								if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 >= 12u)
								{
									bool flag21 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ktv524d, GlobalVariablePointers.String_uxbkrtb, 2876);
									if (ExceptionInfo.Current != null)
									{
										return false;
									}
									bool flag21 = false;
								}
								int instruction_136 = *(int*)((byte*)ptr4 + sizeof(int) * (int)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 & 0xFFFL));
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_49 = instruction_136;
								int instruction_137 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_49;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_50 = (instruction_137 >>> 9) & 0xF;
								if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_50 == 0)
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
									break;
								}
								int instruction_138 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_49;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_49 = instruction_138 & 0x1FF;
								if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_49 != 256)
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
									break;
								}
								int instruction_139 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_50;
								int instruction_140 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 = instruction_140 - instruction_139;
								int instruction_141 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_50;
								long instruction_142 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 = instruction_142 >>> (int)(uint)instruction_141;
								int instruction_143 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_51 = instruction_143 & 7;
								int instruction_144 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_51;
								int instruction_145 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 = instruction_145 - instruction_144;
								int instruction_146 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_51;
								long instruction_147 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_9 = instruction_147 >>> (int)(uint)instruction_146;
								if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8 < (uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 >>> 3))
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
									break;
								}
								int num20 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_10 >>> 3;
								int instruction_148 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8 = instruction_148 - num20;
								if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_8 + 4 != startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_4)
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
								}
								else
								{
									startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = true;
								}
								break;
								IL_244d:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
								break;
								IL_2cea:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
								break;
								IL_2b27:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
								break;
								IL_15e1:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
								break;
								IL_1558:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
								break;
								IL_2672:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
								break;
								IL_2900:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
								break;
								IL_332f:
								void* instruction_149 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_17;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_16 = instruction_149;
								int instruction_150 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_7;
								void* instruction_151 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_17;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_17 = (byte*)instruction_151 + (uint)instruction_150;
								int instruction_152 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_18;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_18 = instruction_152 + 1;
								continue;
								IL_110d:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
								break;
								IL_216c:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
								break;
								IL_2047:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
								break;
								IL_0fba:
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0 = false;
								break;
							}
						}
					}
				}
			}
			goto IL_379c;
		}
		IL_379c:
		bool instruction_153 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_decompress_4_amptoaa>().Instruction_0;
		StackFrameList.Current.Clear(startFrame);
		return instruction_153;
	}

	[MangledName("??0?$allocator@I@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::allocator<unsigned int>::allocator<unsigned int>(void)")]
	public unsafe static void* allocator_unsigned_int_Constructor(void* P_0)
	{
		return P_0;
	}

	[MangledName("??0?$vector@IV?$allocator@I@std@@@std@@QEAA@_KAEBV?$allocator@I@1@@Z")]
	[DemangledName("public: __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::vector<unsigned int, class std::allocator<unsigned int>>(unsigned __int64, class std::allocator<unsigned int> const &)")]
	public unsafe static void* vector_unsigned_int_class_std_allocator_unsigned_int_Constructor(void* P_0, long P_1, void* P_2)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_vector_unsigned_int_class_std_allocator_unsigned_int_Constructor>();
		std_One_then_variadic_args_t* ptr = &startFrame.GetLocalsPointer<LocalVariables_vector_unsigned_int_class_std_allocator_unsigned_int_Constructor>()->Instruction_3;
		startFrame.GetLocalsRef<LocalVariables_vector_unsigned_int_class_std_allocator_unsigned_int_Constructor>().Instruction_0 = P_2;
		startFrame.GetLocalsRef<LocalVariables_vector_unsigned_int_class_std_allocator_unsigned_int_Constructor>().Instruction_1 = P_1;
		startFrame.GetLocalsRef<LocalVariables_vector_unsigned_int_class_std_allocator_unsigned_int_Constructor>().Instruction_2 = P_0;
		void* instruction_ = startFrame.GetLocalsRef<LocalVariables_vector_unsigned_int_class_std_allocator_unsigned_int_Constructor>().Instruction_2;
		std_Compressed_pair_1* field_ = &unchecked((std_vector_0*)instruction_)->field_0;
		void* instruction_2 = startFrame.GetLocalsRef<LocalVariables_vector_unsigned_int_class_std_allocator_unsigned_int_Constructor>().Instruction_0;
		void* ptr2 = Compressed_pair_class_std_allocator_unsigned_int_class_std_Vector_val_struct_std_Simple_types_unsigned_int_1_Constructor(field_, ptr->field_0, instruction_2);
		Construct_n(instruction_, startFrame.GetLocalsRef<LocalVariables_vector_unsigned_int_class_std_allocator_unsigned_int_Constructor>().Instruction_1);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		StackFrameList.Current.Clear(startFrame);
		return instruction_;
	}

	[MangledName("?data@?$vector@IV?$allocator@I@std@@@std@@QEAAPEAIXZ")]
	[DemangledName("public: unsigned int * __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::data(void)")]
	[CleanName("data")]
	public unsafe static void* data_uf9yj3b(void* P_0)
	{
		return Unfancy_maybe_null_ys5czvb(unchecked((std_vector_0*)P_0)->field_0.field_0.field_0);
	}

	[MangledName("?READ_RGB_PIXEL@fpng@@YAIPEBX@Z")]
	[DemangledName("unsigned int __cdecl fpng::READ_RGB_PIXEL(void const *)")]
	public unsafe static int READ_RGB_PIXEL(void* P_0)
	{
		return *unchecked((int*)P_0) & 0xFFFFFF;
	}

	[MangledName("??$minimum@H@fpng@@YAHHH@Z")]
	[DemangledName("int __cdecl fpng::minimum<int>(int, int)")]
	[CleanName("minimum")]
	public static int minimum_ymfg3kb(int P_0, int P_1)
	{
		if (P_0 >= P_1)
		{
			return P_1;
		}
		return P_0;
	}

	[MangledName("?size@?$vector@IV?$allocator@I@std@@@std@@QEBA_KXZ")]
	[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::size(void) const")]
	[CleanName("size")]
	public unsafe static long size_wtrvsgc(void* P_0)
	{
		unchecked
		{
			void* field_ = &((std_vector_0*)P_0)->field_0.field_0;
			return ((long)((std_Vector_val_4*)field_)->field_1 - (long)((std_Vector_val_4*)field_)->field_0) / 4L;
		}
	}

	[MangledName("?adjust_freq32@fpng@@YAXIPEAIPEAG@Z")]
	[DemangledName("void __cdecl fpng::adjust_freq32(unsigned int, unsigned int *, unsigned short *)")]
	public unsafe static void adjust_freq32(int P_0, void* P_1, void* P_2)
	{
		int num = 0;
		unchecked
		{
			for (int i = 0; (uint)i < (uint)P_0; i++)
			{
				num += ((int*)P_1)[(uint)i];
			}
			if (num == 0)
			{
				IntrinsicFunctions.Implemented.llvm_memset_p0_i64(P_2, 0, (long)(uint)P_0 * 2L, false);
				return;
			}
			int num2 = 0;
			for (int j = 0; (uint)j < (uint)P_0; j++)
			{
				long num3 = (uint)((int*)P_1)[(uint)j];
				if (num3 == 0L)
				{
					((short*)P_2)[(uint)j] = 0;
					continue;
				}
				((short*)P_2)[(uint)j] = (short)maximum_y5wzmwb(1, (int)((ulong)(num3 * 65535L) / (ulong)(uint)num));
				num2 += (ushort)((short*)P_2)[(uint)j];
			}
			while ((uint)num2 > 65535u)
			{
				num2 = 0;
				for (int k = 0; (uint)k < (uint)P_0; k++)
				{
					if (((int*)P_1)[(uint)k] != 0)
					{
						((int*)P_1)[(uint)k] = maximum_y5wzmwb(1, ((int*)P_1)[(uint)k] >>> 1);
						num2 += ((int*)P_1)[(uint)k];
					}
				}
			}
		}
	}

	[MangledName("?defl_start_dynamic_block@fpng@@YA_NPEAUdefl_huff@1@PEAEAEAIIAEA_KAEAH@Z")]
	[DemangledName("bool __cdecl fpng::defl_start_dynamic_block(struct fpng::defl_huff *, unsigned char *, unsigned int &, unsigned int, unsigned __int64 &, int &)")]
	public unsafe static bool defl_start_dynamic_block(void* P_0, void* P_1, void* P_2, int P_3, void* P_4, void* P_5)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_defl_start_dynamic_block>();
		InlineArray_320_w3otm9c* ptr = &startFrame.GetLocalsPointer<LocalVariables_defl_start_dynamic_block>()->Instruction_16;
		InlineArray_320_w3otm9c* ptr2 = &startFrame.GetLocalsPointer<LocalVariables_defl_start_dynamic_block>()->Instruction_17;
		startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1 = P_5;
		startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_2 = P_4;
		startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_3 = P_3;
		startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_4 = P_2;
		startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_5 = P_1;
		startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6 = P_0;
		startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_18 = -1;
		unchecked
		{
			*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * 256) = 1;
			defl_optimize_huffman_table(startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6, 0, 288, 12, 0);
			defl_optimize_huffman_table(startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6, 1, 32, 12, 0);
			startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_7 = 286;
			while (startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_7 > 257 && ((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * checked(startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_7 - 1)] == 0)
			{
				int instruction_ = checked(startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_7 + -1);
				startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_7 = instruction_;
			}
			startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_8 = 30;
			while (startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_8 > 1 && ((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_2) + sizeof(InlineArray_288_w3otm9c) * 1)[sizeof(sbyte) * checked(startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_8 - 1)] == 0)
			{
				int instruction_2 = checked(startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_8 + -1);
				startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_8 = instruction_2;
			}
			IntrinsicFunctions.Implemented.llvm_memcpy_p0_p0_i64((byte*)ptr + sizeof(sbyte) * 0, (byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_2) + sizeof(InlineArray_288_w3otm9c) * 0 + sizeof(sbyte) * 0, startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_7, false);
			IntrinsicFunctions.Implemented.llvm_memcpy_p0_p0_i64((byte*)ptr + sizeof(sbyte) * 0 + startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_7, (byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_2) + sizeof(InlineArray_288_w3otm9c) * 1 + sizeof(sbyte) * 0, startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_8, false);
			int instruction_3 = checked(startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_7 + startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_8);
			startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_11 = instruction_3;
			startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = 0;
			startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 = 0;
			startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 = 0;
			IntrinsicFunctions.Implemented.llvm_memset_p0_i64((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 0, 0, 38L, false);
			startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_10 = 0;
			while ((uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_10 < (uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_11)
			{
				sbyte instruction_4 = ((sbyte*)ptr)[sizeof(sbyte) * (int)(uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_10];
				startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_19 = instruction_4;
				if (startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_19 == 0)
				{
					if (startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 != 0)
					{
						if ((uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 < 3u)
						{
							int num = (ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * (byte)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_18));
							int instruction_5 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14;
							*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * (byte)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_18) = (short)(num + instruction_5);
							while (true)
							{
								int instruction_6 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14;
								startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 = instruction_6 + -1;
								if (instruction_6 == 0)
								{
									break;
								}
								sbyte instruction_7 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_18;
								int instruction_8 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
								startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_8 + 1;
								((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_8] = instruction_7;
							}
						}
						else
						{
							int num2;
							checked
							{
								num2 = unchecked((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 16))) + 1;
							}
							*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 16) = (short)num2;
							int instruction_9 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
							startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_9 + 1;
							((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_9] = 16;
							sbyte b = (sbyte)(startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 - 3);
							int instruction_10 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
							startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_10 + 1;
							((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_10] = b;
						}
						startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 = 0;
					}
					int num3 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 + 1;
					startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 = num3;
					if (num3 == 138 && startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 != 0)
					{
						if ((uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 < 3u)
						{
							int num4 = (ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 0));
							int instruction_11 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13;
							*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 0) = (short)(num4 + instruction_11);
							while (true)
							{
								int instruction_12 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13;
								startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 = instruction_12 + -1;
								if (instruction_12 == 0)
								{
									break;
								}
								int instruction_13 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
								startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_13 + 1;
								((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_13] = 0;
							}
						}
						else if ((uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 <= 10u)
						{
							int num5;
							checked
							{
								num5 = unchecked((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 17))) + 1;
							}
							*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 17) = (short)num5;
							int instruction_14 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
							startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_14 + 1;
							((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_14] = 17;
							sbyte b2 = (sbyte)(startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 - 3);
							int instruction_15 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
							startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_15 + 1;
							((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_15] = b2;
						}
						else
						{
							int num6;
							checked
							{
								num6 = unchecked((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 18))) + 1;
							}
							*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 18) = (short)num6;
							int instruction_16 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
							startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_16 + 1;
							((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_16] = 18;
							sbyte b3 = (sbyte)(startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 - 11);
							int instruction_17 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
							startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_17 + 1;
							((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_17] = b3;
						}
						startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 = 0;
					}
				}
				else
				{
					if (startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 != 0)
					{
						if ((uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 < 3u)
						{
							int num7 = (ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 0));
							int instruction_18 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13;
							*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 0) = (short)(num7 + instruction_18);
							while (true)
							{
								int instruction_19 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13;
								startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 = instruction_19 + -1;
								if (instruction_19 == 0)
								{
									break;
								}
								int instruction_20 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
								startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_20 + 1;
								((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_20] = 0;
							}
						}
						else if ((uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 <= 10u)
						{
							int num8;
							checked
							{
								num8 = unchecked((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 17))) + 1;
							}
							*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 17) = (short)num8;
							int instruction_21 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
							startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_21 + 1;
							((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_21] = 17;
							sbyte b4 = (sbyte)(startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 - 3);
							int instruction_22 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
							startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_22 + 1;
							((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_22] = b4;
						}
						else
						{
							int num9;
							checked
							{
								num9 = unchecked((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 18))) + 1;
							}
							*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 18) = (short)num9;
							int instruction_23 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
							startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_23 + 1;
							((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_23] = 18;
							sbyte b5 = (sbyte)(startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 - 11);
							int instruction_24 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
							startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_24 + 1;
							((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_24] = b5;
						}
						startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 = 0;
					}
					if ((byte)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_19 != (byte)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_18)
					{
						if (startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 != 0)
						{
							if ((uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 < 3u)
							{
								int num10 = (ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * (byte)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_18));
								int instruction_25 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14;
								*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * (byte)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_18) = (short)(num10 + instruction_25);
								while (true)
								{
									int instruction_26 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14;
									startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 = instruction_26 + -1;
									if (instruction_26 == 0)
									{
										break;
									}
									sbyte instruction_27 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_18;
									int instruction_28 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
									startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_28 + 1;
									((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_28] = instruction_27;
								}
							}
							else
							{
								int num11;
								checked
								{
									num11 = unchecked((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 16))) + 1;
								}
								*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 16) = (short)num11;
								int instruction_29 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
								startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_29 + 1;
								((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_29] = 16;
								sbyte b6 = (sbyte)(startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 - 3);
								int instruction_30 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
								startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_30 + 1;
								((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_30] = b6;
							}
							startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 = 0;
						}
						int num12;
						checked
						{
							num12 = unchecked((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * (byte)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_19))) + 1;
						}
						*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * (byte)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_19) = (short)num12;
						sbyte instruction_31 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_19;
						int instruction_32 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
						startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_32 + 1;
						((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_32] = instruction_31;
					}
					else
					{
						int num13 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 + 1;
						startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 = num13;
						if (num13 == 6 && startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 != 0)
						{
							if ((uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 < 3u)
							{
								int num14 = (ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * (byte)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_18));
								int instruction_33 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14;
								*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * (byte)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_18) = (short)(num14 + instruction_33);
								while (true)
								{
									int instruction_34 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14;
									startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 = instruction_34 + -1;
									if (instruction_34 == 0)
									{
										break;
									}
									sbyte instruction_35 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_18;
									int instruction_36 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
									startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_36 + 1;
									((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_36] = instruction_35;
								}
							}
							else
							{
								int num15;
								checked
								{
									num15 = unchecked((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 16))) + 1;
								}
								*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 16) = (short)num15;
								int instruction_37 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
								startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_37 + 1;
								((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_37] = 16;
								sbyte b7 = (sbyte)(startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 - 3);
								int instruction_38 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
								startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_38 + 1;
								((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_38] = b7;
							}
							startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 = 0;
						}
					}
				}
				sbyte instruction_39 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_19;
				startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_18 = instruction_39;
				int instruction_40 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_10;
				startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_10 = instruction_40 + 1;
			}
			if (startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 != 0)
			{
				if (startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 != 0)
				{
					if ((uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 < 3u)
					{
						int num16 = (ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * (byte)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_18));
						int instruction_41 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14;
						*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * (byte)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_18) = (short)(num16 + instruction_41);
						while (true)
						{
							int instruction_42 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14;
							startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 = instruction_42 + -1;
							if (instruction_42 == 0)
							{
								break;
							}
							sbyte instruction_43 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_18;
							int instruction_44 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
							startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_44 + 1;
							((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_44] = instruction_43;
						}
					}
					else
					{
						int num17;
						checked
						{
							num17 = unchecked((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 16))) + 1;
						}
						*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 16) = (short)num17;
						int instruction_45 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
						startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_45 + 1;
						((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_45] = 16;
						sbyte b8 = (sbyte)(startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 - 3);
						int instruction_46 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
						startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_46 + 1;
						((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_46] = b8;
					}
					startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_14 = 0;
				}
			}
			else if (startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 != 0)
			{
				if ((uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 < 3u)
				{
					int num18 = (ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 0));
					int instruction_47 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13;
					*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 0) = (short)(num18 + instruction_47);
					while (true)
					{
						int instruction_48 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13;
						startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 = instruction_48 + -1;
						if (instruction_48 == 0)
						{
							break;
						}
						int instruction_49 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
						startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_49 + 1;
						((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_49] = 0;
					}
				}
				else if ((uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 <= 10u)
				{
					int num19;
					checked
					{
						num19 = unchecked((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 17))) + 1;
					}
					*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 17) = (short)num19;
					int instruction_50 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
					startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_50 + 1;
					((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_50] = 17;
					sbyte b9 = (sbyte)(startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 - 3);
					int instruction_51 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
					startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_51 + 1;
					((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_51] = b9;
				}
				else
				{
					int num20;
					checked
					{
						num20 = unchecked((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 18))) + 1;
					}
					*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 18) = (short)num20;
					int instruction_52 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
					startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_52 + 1;
					((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_52] = 18;
					sbyte b10 = (sbyte)(startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 - 11);
					int instruction_53 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12;
					startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12 = instruction_53 + 1;
					((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_53] = b10;
				}
				startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_13 = 0;
			}
			defl_optimize_huffman_table(startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6, 2, 19, 7, 0);
			startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_20 = 2;
			startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_21 = 2;
			if ((uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_21 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_21 <= 16u)
			{
				bool flag = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 799);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				bool flag = false;
			}
			if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_20 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_21))
			{
				bool flag2 = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 799);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				bool flag2 = false;
			}
			long num21 = (uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_20;
			int instruction_54 = *(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1;
			*(long*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_2 |= num21 << (int)(uint)instruction_54;
			int instruction_55 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_21;
			*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1 += instruction_55;
			if (*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1 <= 64)
			{
				bool flag3 = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 799);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				bool flag3 = false;
			}
			while (true)
			{
				if (*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1 >= 8)
				{
					if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_4 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_3)
					{
						startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_0 = false;
						break;
					}
					long instruction_56 = *(long*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_2;
					((sbyte*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_5)[(uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_4)] = (sbyte)instruction_56;
					(*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_4)++;
					*(long*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_2 >>>= 8;
					checked
					{
						*unchecked((int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1) -= 8;
						continue;
					}
				}
				int instruction_57 = checked(startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_7 - 257);
				startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_22 = instruction_57;
				startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_23 = 5;
				if ((uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_23 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_23 <= 16u)
				{
					bool flag4 = true;
				}
				else
				{
					IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 801);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					bool flag4 = false;
				}
				if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_22 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_23))
				{
					bool flag5 = true;
				}
				else
				{
					IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 801);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					bool flag5 = false;
				}
				long num22 = (uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_22;
				int instruction_58 = *(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1;
				*(long*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_2 |= num22 << (int)(uint)instruction_58;
				int instruction_59 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_23;
				*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1 += instruction_59;
				if (*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1 <= 64)
				{
					bool flag6 = true;
				}
				else
				{
					IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 801);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					bool flag6 = false;
				}
				while (true)
				{
					if (*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1 >= 8)
					{
						if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_4 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_3)
						{
							startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_0 = false;
							break;
						}
						long instruction_60 = *(long*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_2;
						((sbyte*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_5)[(uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_4)] = (sbyte)instruction_60;
						(*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_4)++;
						*(long*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_2 >>>= 8;
						checked
						{
							*unchecked((int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1) -= 8;
							continue;
						}
					}
					int instruction_61 = checked(startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_8 - 1);
					startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_24 = instruction_61;
					startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_25 = 5;
					if ((uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_25 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_25 <= 16u)
					{
						bool flag7 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 802);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						bool flag7 = false;
					}
					if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_24 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_25))
					{
						bool flag8 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 802);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						bool flag8 = false;
					}
					long num23 = (uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_24;
					int instruction_62 = *(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1;
					*(long*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_2 |= num23 << (int)(uint)instruction_62;
					int instruction_63 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_25;
					*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1 += instruction_63;
					if (*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1 <= 64)
					{
						bool flag9 = true;
					}
					else
					{
						IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 802);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						bool flag9 = false;
					}
					while (true)
					{
						if (*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1 >= 8)
						{
							if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_4 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_3)
							{
								startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_0 = false;
								break;
							}
							long instruction_64 = *(long*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_2;
							((sbyte*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_5)[(uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_4)] = (sbyte)instruction_64;
							(*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_4)++;
							*(long*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_2 >>>= 8;
							checked
							{
								*unchecked((int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1) -= 8;
								continue;
							}
						}
						startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_9 = 18;
						while (startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_9 >= 0)
						{
							InlineArray_288_w3otm9c* ptr3 = (InlineArray_288_w3otm9c*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_2) + sizeof(InlineArray_288_w3otm9c) * 2);
							int instruction_65 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_9;
							if (((bool*)ptr3)[sizeof(sbyte) * (byte)((sbyte*)GlobalVariablePointers.g_defl_packed_code_size_syms_swizzle)[sizeof(sbyte) * instruction_65]])
							{
								break;
							}
							int instruction_66 = checked(startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_9 + -1);
							startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_9 = instruction_66;
						}
						checked
						{
							int instruction_67 = maximum_sfjssib(4, startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_9 + 1);
							startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_9 = instruction_67;
							int instruction_68 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_9 - 4;
							startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_26 = instruction_68;
							startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_27 = 4;
						}
						if ((uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_27 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_27 <= 16u)
						{
							bool flag10 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 805);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							bool flag10 = false;
						}
						if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_26 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_27))
						{
							bool flag11 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 805);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							bool flag11 = false;
						}
						long num24 = (uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_26;
						int instruction_69 = *(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1;
						*(long*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_2 |= num24 << (int)(uint)instruction_69;
						int instruction_70 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_27;
						*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1 += instruction_70;
						if (*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1 <= 64)
						{
							bool flag12 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 805);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							bool flag12 = false;
						}
						while (true)
						{
							if (*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1 >= 8)
							{
								if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_4 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_3)
								{
									startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_0 = false;
									break;
								}
								long instruction_71 = *(long*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_2;
								((sbyte*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_5)[(uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_4)] = (sbyte)instruction_71;
								(*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_4)++;
								*(long*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_2 >>>= 8;
								checked
								{
									*unchecked((int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1) -= 8;
									continue;
								}
							}
							startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_10 = 0;
							while (true)
							{
								if (startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_10 < startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_9)
								{
									InlineArray_288_w3otm9c* ptr4 = (InlineArray_288_w3otm9c*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_2) + sizeof(InlineArray_288_w3otm9c) * 2);
									int instruction_72 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_10;
									sbyte b11 = ((sbyte*)ptr4)[sizeof(sbyte) * (byte)((sbyte*)GlobalVariablePointers.g_defl_packed_code_size_syms_swizzle)[sizeof(sbyte) * (int)(uint)instruction_72]];
									startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_28 = (byte)b11;
									startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_29 = 3;
									if ((uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_29 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_29 <= 16u)
									{
										bool flag13 = true;
									}
									else
									{
										IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 806);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										bool flag13 = false;
									}
									if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_28 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_29))
									{
										bool flag14 = true;
									}
									else
									{
										IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 806);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										bool flag14 = false;
									}
									long num25 = (uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_28;
									int instruction_73 = *(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1;
									*(long*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_2 |= num25 << (int)(uint)instruction_73;
									int instruction_74 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_29;
									*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1 += instruction_74;
									if (*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1 <= 64)
									{
										bool flag15 = true;
									}
									else
									{
										IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 806);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										bool flag15 = false;
									}
									while (*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1 >= 8)
									{
										if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_4 + 1) <= (uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_3)
										{
											long instruction_75 = *(long*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_2;
											((sbyte*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_5)[(uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_4)] = (sbyte)instruction_75;
											(*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_4)++;
											*(long*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_2 >>>= 8;
											checked
											{
												*unchecked((int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1) -= 8;
												continue;
											}
										}
										goto IL_3d6c;
									}
									int instruction_76 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_10;
									startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_10 = instruction_76 + 1;
									continue;
								}
								startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_15 = 0;
								while (true)
								{
									if ((uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_15 < (uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_12)
									{
										int instruction_77 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_15;
										startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_15 = instruction_77 + 1;
										sbyte b12 = ((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_77];
										startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_30 = (byte)b12;
										if ((uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_30 < 19u)
										{
											bool flag16 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_erkdsbd, GlobalVariablePointers.String_uxbkrtb, 810);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											bool flag16 = false;
										}
										short num26 = *(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_1) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * (int)(uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_30);
										startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_31 = (ushort)num26;
										sbyte b13 = (sbyte)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_6)->field_2) + sizeof(InlineArray_288_w3otm9c) * 2)[sizeof(sbyte) * (int)(uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_30];
										startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_32 = (byte)b13;
										if ((uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_32 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_32 <= 16u)
										{
											bool flag17 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 811);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											bool flag17 = false;
										}
										if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_31 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_32))
										{
											bool flag18 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 811);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											bool flag18 = false;
										}
										long num27 = (uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_31;
										int instruction_78 = *(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1;
										*(long*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_2 |= num27 << (int)(uint)instruction_78;
										int instruction_79 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_32;
										*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1 += instruction_79;
										if (*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1 <= 64)
										{
											bool flag19 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 811);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											bool flag19 = false;
										}
										while (*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1 >= 8)
										{
											if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_4 + 1) <= (uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_3)
											{
												long instruction_80 = *(long*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_2;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_5)[(uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_4)] = (sbyte)instruction_80;
												(*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_4)++;
												*(long*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_2 >>>= 8;
												checked
												{
													*unchecked((int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1) -= 8;
													continue;
												}
											}
											goto IL_43b4;
										}
										if ((uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_30 < 16u)
										{
											continue;
										}
										int instruction_81 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_15;
										startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_15 = instruction_81 + 1;
										sbyte b14 = ((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_81];
										startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_33 = (byte)b14;
										int instruction_82 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_30;
										sbyte b15 = ((sbyte*)GlobalVariablePointers.String_o9ulvgb)[sizeof(sbyte) * (int)(uint)(instruction_82 - 16)];
										startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_34 = b15;
										if ((uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_34 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_34 <= 16u)
										{
											bool flag20 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_isj2lib, GlobalVariablePointers.String_uxbkrtb, 812);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											bool flag20 = false;
										}
										if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_33 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_34))
										{
											bool flag21 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ooiduua, GlobalVariablePointers.String_uxbkrtb, 812);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											bool flag21 = false;
										}
										long num28 = (uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_33;
										int instruction_83 = *(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1;
										*(long*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_2 |= num28 << (int)(uint)instruction_83;
										int instruction_84 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_34;
										*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1 += instruction_84;
										if (*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1 <= 64)
										{
											bool flag22 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mggwlgb, GlobalVariablePointers.String_uxbkrtb, 812);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											bool flag22 = false;
										}
										while (*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1 >= 8)
										{
											if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_4 + 1) <= (uint)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_3)
											{
												long instruction_85 = *(long*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_2;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_5)[(uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_4)] = (sbyte)instruction_85;
												(*(int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_4)++;
												*(long*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_2 >>>= 8;
												checked
												{
													*unchecked((int*)startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_1) -= 8;
													continue;
												}
											}
											goto IL_4877;
										}
										continue;
									}
									startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_0 = true;
									break;
									IL_43b4:
									startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_0 = false;
									break;
									IL_4877:
									startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_0 = false;
									break;
								}
								break;
								IL_3d6c:
								startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_0 = false;
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
			bool instruction_86 = startFrame.GetLocalsRef<LocalVariables_defl_start_dynamic_block>().Instruction_0;
			StackFrameList.Current.Clear(startFrame);
			return instruction_86;
		}
	}

	[MangledName("??A?$vector@IV?$allocator@I@std@@@std@@QEAAAEAI_K@Z")]
	[DemangledName("public: unsigned int & __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::operator[](unsigned __int64)")]
	[CleanName("operator")]
	public unsafe static void* operator_2nyjhmb(void* P_0, long P_1)
	{
		return unchecked((byte*)((std_vector_0*)P_0)->field_0.field_0.field_0 + (nint)P_1 * 4);
	}

	[MangledName("??1?$vector@IV?$allocator@I@std@@@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::~vector<unsigned int, class std::allocator<unsigned int>>(void)")]
	public unsafe static void vector_unsigned_int_class_std_allocator_unsigned_int_Destructor(void* P_0)
	{
		Tidy_kyqxybb(P_0);
	}

	[MangledName("??$?0AEBV?$allocator@I@std@@$$V@?$_Compressed_pair@V?$allocator@I@std@@V?$_Vector_val@U?$_Simple_types@I@std@@@2@$00@std@@QEAA@U_One_then_variadic_args_t@1@AEBV?$allocator@I@1@@Z")]
	[DemangledName("public: __cdecl std::_Compressed_pair<class std::allocator<unsigned int>, class std::_Vector_val<struct std::_Simple_types<unsigned int>>, 1>::_Compressed_pair<class std::allocator<unsigned int>, class std::_Vector_val<struct std::_Simple_types<unsigned int>>, 1><class std::allocator<unsigned int> const &>(struct std::_One_then_variadic_args_t, class std::allocator<unsigned int> const &)")]
	public unsafe static void* Compressed_pair_class_std_allocator_unsigned_int_class_std_Vector_val_struct_std_Simple_types_unsigned_int_1_Constructor(void* P_0, sbyte P_1, void* P_2)
	{
		std_One_then_variadic_args_t std_One_then_variadic_args_t = default(std_One_then_variadic_args_t);
		std_One_then_variadic_args_t.field_0 = P_1;
		void* ptr = Vector_val_struct_std_Simple_types_unsigned_int_Constructor(&unchecked((std_Compressed_pair_1*)P_0)->field_0);
		return P_0;
	}

	[MangledName("??$_Construct_n@$$V@?$vector@IV?$allocator@I@std@@@std@@AEAAX_K@Z")]
	[DemangledName("private: void __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::_Construct_n<>(unsigned __int64)")]
	public unsafe static void Construct_n(void* P_0, long P_1)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_Construct_n>();
		std_Fake_allocator* instruction_ = &startFrame.GetLocalsPointer<LocalVariables_Construct_n>()->Instruction_4;
		std_Fake_proxy_ptr_impl* ptr = &startFrame.GetLocalsPointer<LocalVariables_Construct_n>()->Instruction_6;
		std_Tidy_guard* ptr2 = &startFrame.GetLocalsPointer<LocalVariables_Construct_n>()->Instruction_7;
		startFrame.GetLocalsRef<LocalVariables_Construct_n>().Instruction_0 = P_1;
		startFrame.GetLocalsRef<LocalVariables_Construct_n>().Instruction_1 = P_0;
		void* instruction_2 = startFrame.GetLocalsRef<LocalVariables_Construct_n>().Instruction_1;
		void* instruction_3 = Getal_t2pmqoc(instruction_2);
		startFrame.GetLocalsRef<LocalVariables_Construct_n>().Instruction_2 = instruction_3;
		startFrame.GetLocalsRef<LocalVariables_Construct_n>().Instruction_3 = instruction_;
		unchecked
		{
			std_Vector_val_4* field_ = &((std_vector_0*)instruction_2)->field_0.field_0;
			startFrame.GetLocalsRef<LocalVariables_Construct_n>().Instruction_5 = field_;
			void* instruction_4 = startFrame.GetLocalsRef<LocalVariables_Construct_n>().Instruction_5;
			void* ptr3 = Fake_proxy_ptr_impl_Constructor(ptr, startFrame.GetLocalsRef<LocalVariables_Construct_n>().Instruction_3, instruction_4);
			if (startFrame.GetLocalsRef<LocalVariables_Construct_n>().Instruction_0 != 0L)
			{
				Buy_nonzero(instruction_2, startFrame.GetLocalsRef<LocalVariables_Construct_n>().Instruction_0);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				ptr2->field_0 = instruction_2;
				void* instruction_5 = startFrame.GetLocalsRef<LocalVariables_Construct_n>().Instruction_2;
				long instruction_6 = startFrame.GetLocalsRef<LocalVariables_Construct_n>().Instruction_0;
				void* field_2 = Uninitialized_value_construct_n_zg4iwva(((std_Vector_val_4*)startFrame.GetLocalsRef<LocalVariables_Construct_n>().Instruction_5)->field_0, instruction_6, instruction_5);
				if (ExceptionInfo.Current != null)
				{
					ExceptionInfo current = ExceptionInfo.Current;
					ExceptionInfo.Current = null;
					Tidy_guard_class_std_vector_unsigned_int_class_std_allocator_unsigned_int_Destructor(ptr2);
					ExceptionInfo.Current = current;
					return;
				}
				((std_Vector_val_4*)startFrame.GetLocalsRef<LocalVariables_Construct_n>().Instruction_5)->field_1 = field_2;
				ptr2->field_0 = null;
				Tidy_guard_class_std_vector_unsigned_int_class_std_allocator_unsigned_int_Destructor(ptr2);
			}
			Release(ptr);
			StackFrameList.Current.Clear(startFrame);
		}
	}

	[MangledName("??0?$_Vector_val@U?$_Simple_types@I@std@@@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::_Vector_val<struct std::_Simple_types<unsigned int>>::_Vector_val<struct std::_Simple_types<unsigned int>>(void)")]
	public unsafe static void* Vector_val_struct_std_Simple_types_unsigned_int_Constructor(void* P_0)
	{
		unchecked
		{
			((std_Vector_val_4*)P_0)->field_0 = null;
			((std_Vector_val_4*)P_0)->field_1 = null;
			((std_Vector_val_4*)P_0)->field_2 = null;
			return P_0;
		}
	}

	[MangledName("?_Getal@?$vector@IV?$allocator@I@std@@@std@@AEAAAEAV?$allocator@I@2@XZ")]
	[DemangledName("private: class std::allocator<unsigned int> & __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::_Getal(void)")]
	[CleanName("Getal")]
	public unsafe static void* Getal_t2pmqoc(void* P_0)
	{
		return Get_first_evhdorb(&unchecked((std_vector_0*)P_0)->field_0);
	}

	[MangledName("??0_Fake_proxy_ptr_impl@std@@QEAA@AEBU_Fake_allocator@1@AEBU_Container_base0@1@@Z")]
	[DemangledName("public: __cdecl std::_Fake_proxy_ptr_impl::_Fake_proxy_ptr_impl(struct std::_Fake_allocator const &, struct std::_Container_base0 const &)")]
	public unsafe static void* Fake_proxy_ptr_impl_Constructor(void* P_0, void* P_1, void* P_2)
	{
		return P_0;
	}

	[MangledName("?_Buy_nonzero@?$vector@IV?$allocator@I@std@@@std@@AEAAX_K@Z")]
	[DemangledName("private: void __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::_Buy_nonzero(unsigned __int64)")]
	public unsafe static void Buy_nonzero(void* P_0, long P_1)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_Buy_nonzero>();
		startFrame.GetLocalsRef<LocalVariables_Buy_nonzero>().Instruction_0 = P_1;
		startFrame.GetLocalsRef<LocalVariables_Buy_nonzero>().Instruction_1 = P_0;
		void* instruction_ = startFrame.GetLocalsRef<LocalVariables_Buy_nonzero>().Instruction_1;
		if (unchecked((ulong)startFrame.GetLocalsRef<LocalVariables_Buy_nonzero>().Instruction_0 > (ulong)max_size_qdwnpha(instruction_)))
		{
			Xlength_nubzgpc();
			throw null;
		}
		Buy_raw(instruction_, startFrame.GetLocalsRef<LocalVariables_Buy_nonzero>().Instruction_0);
		if (ExceptionInfo.Current == null)
		{
			StackFrameList.Current.Clear(startFrame);
		}
	}

	[MangledName("??$_Uninitialized_value_construct_n@V?$allocator@I@std@@@std@@YAPEAIPEAI_KAEAV?$allocator@I@0@@Z")]
	[DemangledName("unsigned int * __cdecl std::_Uninitialized_value_construct_n<class std::allocator<unsigned int>>(unsigned int *, unsigned __int64, class std::allocator<unsigned int> &)")]
	[CleanName("Uninitialized_value_construct_n")]
	public unsafe static void* Uninitialized_value_construct_n_zg4iwva(void* P_0, long P_1, void* P_2)
	{
		void* ptr = Unfancy_xjzn42c(P_0);
		unchecked
		{
			void* ptr2 = Zero_range_dc39dpa(ptr, (byte*)ptr + (nint)P_1 * 4);
			return (byte*)P_0 + (nint)P_1 * 4;
		}
	}

	[MangledName("??1?$_Tidy_guard@V?$vector@IV?$allocator@I@std@@@std@@@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::_Tidy_guard<class std::vector<unsigned int, class std::allocator<unsigned int>>>::~_Tidy_guard<class std::vector<unsigned int, class std::allocator<unsigned int>>>(void)")]
	public unsafe static void Tidy_guard_class_std_vector_unsigned_int_class_std_allocator_unsigned_int_Destructor(void* P_0)
	{
		unchecked
		{
			if (((std_Tidy_guard*)P_0)->field_0 != null)
			{
				Tidy_kyqxybb(((std_Tidy_guard*)P_0)->field_0);
			}
		}
	}

	[MangledName("?_Release@_Fake_proxy_ptr_impl@std@@QEAAXXZ")]
	[DemangledName("public: void __cdecl std::_Fake_proxy_ptr_impl::_Release(void)")]
	public unsafe static void Release(void* P_0)
	{
	}

	[MangledName("?_Get_first@?$_Compressed_pair@V?$allocator@I@std@@V?$_Vector_val@U?$_Simple_types@I@std@@@2@$00@std@@QEAAAEAV?$allocator@I@2@XZ")]
	[DemangledName("public: class std::allocator<unsigned int> & __cdecl std::_Compressed_pair<class std::allocator<unsigned int>, class std::_Vector_val<struct std::_Simple_types<unsigned int>>, 1>::_Get_first(void)")]
	[CleanName("Get_first")]
	public unsafe static void* Get_first_evhdorb(void* P_0)
	{
		return P_0;
	}

	[MangledName("?max_size@?$vector@IV?$allocator@I@std@@@std@@QEBA_KXZ")]
	[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::max_size(void) const")]
	[CleanName("max_size")]
	public unsafe static long max_size_qdwnpha(void* P_0)
	{
		long num = 0L;
		long* ptr = &num;
		long num2 = 0L;
		long* ptr2 = &num2;
		num = max_size_snq294b(Getal_r5wdlvb(P_0));
		num2 = Max_limit();
		return *unchecked((long*)min(ptr2, ptr));
	}

	[MangledName("?_Xlength@?$vector@IV?$allocator@I@std@@@std@@CAXXZ")]
	[DemangledName("private: static void __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::_Xlength(void)")]
	[CleanName("Xlength")]
	public unsafe static void Xlength_nubzgpc()
	{
		IntrinsicFunctions.Unimplemented.Xlength_error(GlobalVariablePointers.String_7b7kt9c);
		throw null;
	}

	[MangledName("?_Buy_raw@?$vector@IV?$allocator@I@std@@@std@@AEAAX_K@Z")]
	[DemangledName("private: void __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::_Buy_raw(unsigned __int64)")]
	public unsafe static void Buy_raw(void* P_0, long P_1)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_Buy_raw>();
		long* ptr = &startFrame.GetLocalsPointer<LocalVariables_Buy_raw>()->Instruction_0;
		startFrame.GetLocalsRef<LocalVariables_Buy_raw>().Instruction_0 = P_1;
		startFrame.GetLocalsRef<LocalVariables_Buy_raw>().Instruction_1 = P_0;
		void* instruction_ = startFrame.GetLocalsRef<LocalVariables_Buy_raw>().Instruction_1;
		unchecked
		{
			std_Vector_val_4* field_ = &((std_vector_0*)instruction_)->field_0.field_0;
			startFrame.GetLocalsRef<LocalVariables_Buy_raw>().Instruction_2 = field_;
			void** field_2 = &((std_Vector_val_4*)startFrame.GetLocalsRef<LocalVariables_Buy_raw>().Instruction_2)->field_0;
			startFrame.GetLocalsRef<LocalVariables_Buy_raw>().Instruction_3 = field_2;
			void** field_3 = &((std_Vector_val_4*)startFrame.GetLocalsRef<LocalVariables_Buy_raw>().Instruction_2)->field_1;
			startFrame.GetLocalsRef<LocalVariables_Buy_raw>().Instruction_4 = field_3;
			void** field_4 = &((std_Vector_val_4*)startFrame.GetLocalsRef<LocalVariables_Buy_raw>().Instruction_2)->field_2;
			startFrame.GetLocalsRef<LocalVariables_Buy_raw>().Instruction_5 = field_4;
			void* instruction_2 = Allocate_at_least_helper_22hwyxd(Getal_t2pmqoc(instruction_), ptr);
			if (ExceptionInfo.Current == null)
			{
				startFrame.GetLocalsRef<LocalVariables_Buy_raw>().Instruction_6 = instruction_2;
				void* instruction_3 = startFrame.GetLocalsRef<LocalVariables_Buy_raw>().Instruction_6;
				*(void**)startFrame.GetLocalsRef<LocalVariables_Buy_raw>().Instruction_3 = instruction_3;
				void* instruction_4 = startFrame.GetLocalsRef<LocalVariables_Buy_raw>().Instruction_6;
				*(void**)startFrame.GetLocalsRef<LocalVariables_Buy_raw>().Instruction_4 = instruction_4;
				void* instruction_5 = startFrame.GetLocalsRef<LocalVariables_Buy_raw>().Instruction_6;
				long instruction_6 = startFrame.GetLocalsRef<LocalVariables_Buy_raw>().Instruction_0;
				*(byte**)startFrame.GetLocalsRef<LocalVariables_Buy_raw>().Instruction_5 = (byte*)instruction_5 + (nint)instruction_6 * 4;
				StackFrameList.Current.Clear(startFrame);
			}
		}
	}

	[MangledName("??$min@_K@std@@YAAEB_KAEB_K0@Z")]
	[DemangledName("unsigned __int64 const & __cdecl std::min<unsigned __int64>(unsigned __int64 const &, unsigned __int64 const &)")]
	public unsafe static void* min(void* P_0, void* P_1)
	{
		if (unchecked((ulong)(*(long*)P_1) >= (ulong)(*(long*)P_0)))
		{
			return P_0;
		}
		return P_1;
	}

	[MangledName("?max_size@?$_Default_allocator_traits@V?$allocator@I@std@@@std@@SA_KAEBV?$allocator@I@2@@Z")]
	[DemangledName("public: static unsigned __int64 __cdecl std::_Default_allocator_traits<class std::allocator<unsigned int>>::max_size(class std::allocator<unsigned int> const &)")]
	[CleanName("max_size")]
	public unsafe static long max_size_snq294b(void* P_0)
	{
		return 4611686018427387903L;
	}

	[MangledName("?_Getal@?$vector@IV?$allocator@I@std@@@std@@AEBAAEBV?$allocator@I@2@XZ")]
	[DemangledName("private: class std::allocator<unsigned int> const & __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::_Getal(void) const")]
	[CleanName("Getal")]
	public unsafe static void* Getal_r5wdlvb(void* P_0)
	{
		return Get_first_gs7mvkc(&unchecked((std_vector_0*)P_0)->field_0);
	}

	[MangledName("??$_Max_limit@_J@std@@YA_JXZ")]
	[DemangledName("__int64 __cdecl std::_Max_limit<__int64>(void)")]
	public static long Max_limit()
	{
		long num = -1L;
		return long.MaxValue;
	}

	[MangledName("?_Get_first@?$_Compressed_pair@V?$allocator@I@std@@V?$_Vector_val@U?$_Simple_types@I@std@@@2@$00@std@@QEBAAEBV?$allocator@I@2@XZ")]
	[DemangledName("public: class std::allocator<unsigned int> const & __cdecl std::_Compressed_pair<class std::allocator<unsigned int>, class std::_Vector_val<struct std::_Simple_types<unsigned int>>, 1>::_Get_first(void) const")]
	[CleanName("Get_first")]
	public unsafe static void* Get_first_gs7mvkc(void* P_0)
	{
		return P_0;
	}

	[MangledName("??$_Allocate_at_least_helper@V?$allocator@I@std@@@std@@YAPEAIAEAV?$allocator@I@0@AEA_K@Z")]
	[DemangledName("unsigned int * __cdecl std::_Allocate_at_least_helper<class std::allocator<unsigned int>>(class std::allocator<unsigned int> &, unsigned __int64 &)")]
	[CleanName("Allocate_at_least_helper")]
	public unsafe static void* Allocate_at_least_helper_22hwyxd(void* P_0, void* P_1)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_Allocate_at_least_helper_22hwyxd>();
		startFrame.GetLocalsRef<LocalVariables_Allocate_at_least_helper_22hwyxd>().Instruction_0 = P_1;
		startFrame.GetLocalsRef<LocalVariables_Allocate_at_least_helper_22hwyxd>().Instruction_1 = P_0;
		void* result = allocate_wor4ptd(startFrame.GetLocalsRef<LocalVariables_Allocate_at_least_helper_22hwyxd>().Instruction_1, *unchecked((long*)startFrame.GetLocalsRef<LocalVariables_Allocate_at_least_helper_22hwyxd>().Instruction_0));
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		StackFrameList.Current.Clear(startFrame);
		return result;
	}

	[MangledName("?allocate@?$allocator@I@std@@QEAAPEAI_K@Z")]
	[DemangledName("public: unsigned int * __cdecl std::allocator<unsigned int>::allocate(unsigned __int64)")]
	[CleanName("allocate")]
	public unsafe static void* allocate_wor4ptd(void* P_0, long P_1)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_allocate_wor4ptd>();
		startFrame.GetLocalsRef<LocalVariables_allocate_wor4ptd>().Instruction_0 = P_1;
		startFrame.GetLocalsRef<LocalVariables_allocate_wor4ptd>().Instruction_1 = P_0;
		void* instruction_ = startFrame.GetLocalsRef<LocalVariables_allocate_wor4ptd>().Instruction_1;
		long num = Get_size_of_n_rdjmi2b(startFrame.GetLocalsRef<LocalVariables_allocate_wor4ptd>().Instruction_0);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		void* result = Allocate_i4jzs2a(num);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		StackFrameList.Current.Clear(startFrame);
		return result;
	}

	[MangledName("??$_Allocate@$0BA@U_Default_allocate_traits@std@@@std@@YAPEAX_K@Z")]
	[DemangledName("void * __cdecl std::_Allocate<16, struct std::_Default_allocate_traits>(unsigned __int64)")]
	[CleanName("Allocate")]
	public unsafe static void* Allocate_i4jzs2a(long P_0)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_Allocate_i4jzs2a>();
		startFrame.GetLocalsRef<LocalVariables_Allocate_i4jzs2a>().Instruction_1 = P_0;
		if (startFrame.GetLocalsRef<LocalVariables_Allocate_i4jzs2a>().Instruction_1 == 0L)
		{
			startFrame.GetLocalsRef<LocalVariables_Allocate_i4jzs2a>().Instruction_0 = null;
		}
		else if (unchecked((ulong)startFrame.GetLocalsRef<LocalVariables_Allocate_i4jzs2a>().Instruction_1) >= 4096uL)
		{
			void* instruction_ = Allocate_manually_vector_aligned(startFrame.GetLocalsRef<LocalVariables_Allocate_i4jzs2a>().Instruction_1);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			startFrame.GetLocalsRef<LocalVariables_Allocate_i4jzs2a>().Instruction_0 = instruction_;
		}
		else
		{
			void* instruction_2 = Allocate_ifu7fia(startFrame.GetLocalsRef<LocalVariables_Allocate_i4jzs2a>().Instruction_1);
			startFrame.GetLocalsRef<LocalVariables_Allocate_i4jzs2a>().Instruction_0 = instruction_2;
		}
		void* instruction_3 = startFrame.GetLocalsRef<LocalVariables_Allocate_i4jzs2a>().Instruction_0;
		StackFrameList.Current.Clear(startFrame);
		return instruction_3;
	}

	[MangledName("??$_Get_size_of_n@$03@std@@YA_K_K@Z")]
	[DemangledName("unsigned __int64 __cdecl std::_Get_size_of_n<4>(unsigned __int64)")]
	[CleanName("Get_size_of_n")]
	public static long Get_size_of_n_rdjmi2b(long P_0)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_Get_size_of_n_rdjmi2b>();
		startFrame.GetLocalsRef<LocalVariables_Get_size_of_n_rdjmi2b>().Instruction_0 = P_0;
		startFrame.GetLocalsRef<LocalVariables_Get_size_of_n_rdjmi2b>().Instruction_1 = 1;
		startFrame.GetLocalsRef<LocalVariables_Get_size_of_n_rdjmi2b>().Instruction_2 = 4611686018427387903L;
		unchecked
		{
			if ((ulong)startFrame.GetLocalsRef<LocalVariables_Get_size_of_n_rdjmi2b>().Instruction_0 > 4611686018427387903uL)
			{
				Throw_bad_array_new_length();
				if (ExceptionInfo.Current != null)
				{
					return 0L;
				}
				throw null;
			}
			long result = startFrame.GetLocalsRef<LocalVariables_Get_size_of_n_rdjmi2b>().Instruction_0 * 4L;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}

	[MangledName("??$_Allocate_manually_vector_aligned@U_Default_allocate_traits@std@@@std@@YAPEAX_K@Z")]
	[DemangledName("void * __cdecl std::_Allocate_manually_vector_aligned<struct std::_Default_allocate_traits>(unsigned __int64)")]
	public unsafe static void* Allocate_manually_vector_aligned(long P_0)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_Allocate_manually_vector_aligned>();
		startFrame.GetLocalsRef<LocalVariables_Allocate_manually_vector_aligned>().Instruction_0 = P_0;
		long instruction_ = startFrame.GetLocalsRef<LocalVariables_Allocate_manually_vector_aligned>().Instruction_0;
		unchecked
		{
			startFrame.GetLocalsRef<LocalVariables_Allocate_manually_vector_aligned>().Instruction_1 = 39L + instruction_;
			if ((ulong)startFrame.GetLocalsRef<LocalVariables_Allocate_manually_vector_aligned>().Instruction_1 <= (ulong)startFrame.GetLocalsRef<LocalVariables_Allocate_manually_vector_aligned>().Instruction_0)
			{
				Throw_bad_array_new_length();
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				throw null;
			}
			void* ptr = Allocate_ifu7fia(startFrame.GetLocalsRef<LocalVariables_Allocate_manually_vector_aligned>().Instruction_1);
			startFrame.GetLocalsRef<LocalVariables_Allocate_manually_vector_aligned>().Instruction_2 = (long)ptr;
			if (startFrame.GetLocalsRef<LocalVariables_Allocate_manually_vector_aligned>().Instruction_2 == 0L)
			{
				IntrinsicFunctions.Implemented.invoke_watson(null, null, null, 0, 0L);
				throw null;
			}
			long instruction_2 = startFrame.GetLocalsRef<LocalVariables_Allocate_manually_vector_aligned>().Instruction_2;
			startFrame.GetLocalsRef<LocalVariables_Allocate_manually_vector_aligned>().Instruction_3 = (void*)((instruction_2 + 39L) & -32L);
			long instruction_3 = startFrame.GetLocalsRef<LocalVariables_Allocate_manually_vector_aligned>().Instruction_2;
			*(long*)((byte*)startFrame.GetLocalsRef<LocalVariables_Allocate_manually_vector_aligned>().Instruction_3 + -8) = instruction_3;
			void* instruction_4 = startFrame.GetLocalsRef<LocalVariables_Allocate_manually_vector_aligned>().Instruction_3;
			StackFrameList.Current.Clear(startFrame);
			return instruction_4;
		}
	}

	[MangledName("?_Allocate@_Default_allocate_traits@std@@SAPEAX_K@Z")]
	[DemangledName("public: static void * __cdecl std::_Default_allocate_traits::_Allocate(unsigned __int64)")]
	[CleanName("Allocate")]
	public unsafe static void* Allocate_ifu7fia(long P_0)
	{
		return IntrinsicFunctions.Implemented.New(P_0);
	}

	[MangledName("?_Throw_bad_array_new_length@std@@YAXXZ")]
	[DemangledName("void __cdecl std::_Throw_bad_array_new_length(void)")]
	public unsafe static void Throw_bad_array_new_length()
	{
		std_bad_array_new_length* ptr = &StackFrameList.Current.New<LocalVariables_Throw_bad_array_new_length>().GetLocalsPointer<LocalVariables_Throw_bad_array_new_length>()->Instruction_0;
		void* ptr2 = bad_array_new_length_Constructor_fnjru5d(ptr);
		IntrinsicFunctions.Implemented.CxxThrowException(ptr, GlobalVariablePointers.TI3_AVbad_array_new_length_std);
		if (ExceptionInfo.Current != null)
		{
			return;
		}
		throw null;
	}

	[MangledName("??0bad_array_new_length@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::bad_array_new_length::bad_array_new_length(void)")]
	[CleanName("bad_array_new_length_Constructor")]
	public unsafe static void* bad_array_new_length_Constructor_fnjru5d(void* P_0)
	{
		void* ptr = bad_alloc_Constructor_72dj2ea(P_0, GlobalVariablePointers.String_gudorqc);
		unchecked
		{
			*(byte**)P_0 = (byte*)(&GlobalVariablePointers.Variable_4yxjuqa->field_0) + sizeof(nint) * 1;
			return P_0;
		}
	}

	[MangledName("??0bad_array_new_length@std@@QEAA@AEBV01@@Z")]
	[DemangledName("public: __cdecl std::bad_array_new_length::bad_array_new_length(class std::bad_array_new_length const &)")]
	[CleanName("bad_array_new_length_Constructor")]
	public unsafe static void* bad_array_new_length_Constructor_7fjuj3c(void* P_0, void* P_1)
	{
		void* ptr = bad_alloc_Constructor_3vdoaxb(P_0, P_1);
		unchecked
		{
			*(byte**)P_0 = (byte*)(&GlobalVariablePointers.Variable_4yxjuqa->field_0) + sizeof(nint) * 1;
			return P_0;
		}
	}

	[MangledName("??0bad_alloc@std@@QEAA@AEBV01@@Z")]
	[DemangledName("public: __cdecl std::bad_alloc::bad_alloc(class std::bad_alloc const &)")]
	[CleanName("bad_alloc_Constructor")]
	public unsafe static void* bad_alloc_Constructor_3vdoaxb(void* P_0, void* P_1)
	{
		void* ptr = exception_Constructor_ikocrpb(P_0, P_1);
		unchecked
		{
			*(byte**)P_0 = (byte*)(&GlobalVariablePointers.Variable_zdor9mc->field_0) + sizeof(nint) * 1;
			return P_0;
		}
	}

	[MangledName("??0exception@std@@QEAA@AEBV01@@Z")]
	[DemangledName("public: __cdecl std::exception::exception(class std::exception const &)")]
	[CleanName("exception_Constructor")]
	public unsafe static void* exception_Constructor_ikocrpb(void* P_0, void* P_1)
	{
		unchecked
		{
			*(byte**)P_0 = (byte*)(&GlobalVariablePointers.Variable_x4f2ufc->field_0) + sizeof(nint) * 1;
			IntrinsicFunctions.Implemented.llvm_memset_p0_i64(&((std_exception*)P_0)->field_1, 0, 16L, false);
			std_exception_data* field_ = &((std_exception*)P_0)->field_1;
			IntrinsicFunctions.Unimplemented.std_exception_copy(&((std_exception*)P_1)->field_1, field_);
			if (ExceptionInfo.Current == null)
			{
				return P_0;
			}
			ExceptionInfo current = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			IntrinsicFunctions.Implemented.std_terminate();
			throw null;
		}
	}

	[MangledName("??1bad_array_new_length@std@@UEAA@XZ")]
	[DemangledName("public: virtual __cdecl std::bad_array_new_length::~bad_array_new_length(void)")]
	public unsafe static void bad_array_new_length_Destructor(void* P_0)
	{
		bad_alloc_Destructor(P_0);
	}

	[MangledName("??0bad_alloc@std@@AEAA@QEBD@Z")]
	[DemangledName("private: __cdecl std::bad_alloc::bad_alloc(char const *const)")]
	[CleanName("bad_alloc_Constructor")]
	public unsafe static void* bad_alloc_Constructor_72dj2ea(void* P_0, void* P_1)
	{
		void* ptr = exception_Constructor_morlzmd(P_0, P_1, 1);
		unchecked
		{
			*(byte**)P_0 = (byte*)(&GlobalVariablePointers.Variable_zdor9mc->field_0) + sizeof(nint) * 1;
			return P_0;
		}
	}

	[MangledName("??_Gbad_array_new_length@std@@UEAAPEAXI@Z")]
	[DemangledName("public: virtual void * __cdecl std::bad_array_new_length::`scalar deleting dtor'(unsigned int)")]
	public unsafe static void* bad_array_new_length_Delete(void* P_0, int P_1)
	{
		bad_array_new_length_Destructor(P_0);
		if (P_1 != 0)
		{
			IntrinsicFunctions.Implemented.Delete(P_0, 24L);
		}
		return P_0;
	}

	[MangledName("?what@exception@std@@UEBAPEBDXZ")]
	[DemangledName("public: virtual char const * __cdecl std::exception::what(void) const")]
	public unsafe static void* what(void* P_0)
	{
		unchecked
		{
			if (((std_exception*)P_0)->field_1.field_0 != null)
			{
				return ((std_exception*)P_0)->field_1.field_0;
			}
			return GlobalVariablePointers.String_ja3ma5d;
		}
	}

	[MangledName("??0exception@std@@QEAA@QEBDH@Z")]
	[DemangledName("public: __cdecl std::exception::exception(char const *const, int)")]
	[CleanName("exception_Constructor")]
	public unsafe static void* exception_Constructor_morlzmd(void* P_0, void* P_1, int P_2)
	{
		unchecked
		{
			*(byte**)P_0 = (byte*)(&GlobalVariablePointers.Variable_x4f2ufc->field_0) + sizeof(nint) * 1;
			IntrinsicFunctions.Implemented.llvm_memset_p0_i64(&((std_exception*)P_0)->field_1, 0, 16L, false);
			((std_exception*)P_0)->field_1.field_0 = P_1;
			return P_0;
		}
	}

	[MangledName("??_Gbad_alloc@std@@UEAAPEAXI@Z")]
	[DemangledName("public: virtual void * __cdecl std::bad_alloc::`scalar deleting dtor'(unsigned int)")]
	public unsafe static void* bad_alloc_Delete(void* P_0, int P_1)
	{
		bad_alloc_Destructor(P_0);
		if (P_1 != 0)
		{
			IntrinsicFunctions.Implemented.Delete(P_0, 24L);
		}
		return P_0;
	}

	[MangledName("??_Gexception@std@@UEAAPEAXI@Z")]
	[DemangledName("public: virtual void * __cdecl std::exception::`scalar deleting dtor'(unsigned int)")]
	public unsafe static void* exception_Delete(void* P_0, int P_1)
	{
		exception_Destructor(P_0);
		if (P_1 != 0)
		{
			IntrinsicFunctions.Implemented.Delete(P_0, 24L);
		}
		return P_0;
	}

	[MangledName("??1exception@std@@UEAA@XZ")]
	[DemangledName("public: virtual __cdecl std::exception::~exception(void)")]
	public unsafe static void exception_Destructor(void* P_0)
	{
		unchecked
		{
			*(byte**)P_0 = (byte*)(&GlobalVariablePointers.Variable_x4f2ufc->field_0) + sizeof(nint) * 1;
			IntrinsicFunctions.Unimplemented.std_exception_destroy(&((std_exception*)P_0)->field_1);
			if (ExceptionInfo.Current == null)
			{
				return;
			}
			ExceptionInfo current = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			IntrinsicFunctions.Implemented.std_terminate();
			throw null;
		}
	}

	[MangledName("??1bad_alloc@std@@UEAA@XZ")]
	[DemangledName("public: virtual __cdecl std::bad_alloc::~bad_alloc(void)")]
	public unsafe static void bad_alloc_Destructor(void* P_0)
	{
		exception_Destructor(P_0);
	}

	[MangledName("??$_Unfancy@I@std@@YAPEAIPEAI@Z")]
	[DemangledName("unsigned int * __cdecl std::_Unfancy<unsigned int>(unsigned int *)")]
	[CleanName("Unfancy")]
	public unsafe static void* Unfancy_xjzn42c(void* P_0)
	{
		return P_0;
	}

	[MangledName("??$_Zero_range@PEAI@std@@YAPEAIQEAI0@Z")]
	[DemangledName("unsigned int * __cdecl std::_Zero_range<unsigned int *>(unsigned int *const, unsigned int *const)")]
	[CleanName("Zero_range")]
	public unsafe static void* Zero_range_dc39dpa(void* P_0, void* P_1)
	{
		void* result = null;
		void** ptr = &result;
		void* ptr2 = null;
		void** ptr3 = &ptr2;
		result = P_1;
		ptr2 = P_0;
		void* ptr4 = To_address_aoz7nfb(ptr3);
		IntrinsicFunctions.Implemented.llvm_memset_p0_i64(ptr4, 0, unchecked((long)To_address_aoz7nfb(ptr) - (long)ptr4), false);
		return result;
	}

	[MangledName("??$_To_address@PEAI@std@@YA?A_PAEBQEAI@Z")]
	[DemangledName("auto __cdecl std::_To_address<unsigned int *>(unsigned int *const &)")]
	[CleanName("To_address")]
	public unsafe static void* To_address_aoz7nfb(void* P_0)
	{
		return *unchecked((void**)P_0);
	}

	[MangledName("?_Tidy@?$vector@IV?$allocator@I@std@@@std@@AEAAXXZ")]
	[DemangledName("private: void __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::_Tidy(void)")]
	[CleanName("Tidy")]
	public unsafe static void Tidy_kyqxybb(void* P_0)
	{
		void* ptr = Getal_t2pmqoc(P_0);
		unchecked
		{
			void* field_ = &((std_vector_0*)P_0)->field_0.field_0;
			void* field_2 = &((std_Vector_val_4*)field_)->field_0;
			void* field_3 = &((std_Vector_val_4*)field_)->field_1;
			void* field_4 = &((std_Vector_val_4*)field_)->field_2;
			Orphan_all(field_);
			if (*(IntPtr*)field_2 != (IntPtr)(nint)0)
			{
				void* ptr2 = ptr;
				void* ptr3 = *(void**)field_3;
				Destroy_range_9rluabc(*(void**)field_2, ptr3, ptr2);
				void* ptr4 = ptr;
				long num = ((long)(nuint)(*(nint*)field_4) - (long)(nuint)(*(nint*)field_2)) / 4L;
				deallocate_gfl4ncc(ptr4, *(void**)field_2, num);
				*(IntPtr*)field_2 = (nint)0;
				*(IntPtr*)field_3 = (nint)0;
				*(IntPtr*)field_4 = (nint)0;
			}
		}
	}

	[MangledName("?_Orphan_all@_Container_base0@std@@QEAAXXZ")]
	[DemangledName("public: void __cdecl std::_Container_base0::_Orphan_all(void)")]
	public unsafe static void Orphan_all(void* P_0)
	{
	}

	[MangledName("??$_Destroy_range@V?$allocator@I@std@@@std@@YAXPEAIQEAIAEAV?$allocator@I@0@@Z")]
	[DemangledName("void __cdecl std::_Destroy_range<class std::allocator<unsigned int>>(unsigned int *, unsigned int *const, class std::allocator<unsigned int> &)")]
	[CleanName("Destroy_range")]
	public unsafe static void Destroy_range_9rluabc(void* P_0, void* P_1, void* P_2)
	{
	}

	[MangledName("?deallocate@?$allocator@I@std@@QEAAXQEAI_K@Z")]
	[DemangledName("public: void __cdecl std::allocator<unsigned int>::deallocate(unsigned int *const, unsigned __int64)")]
	[CleanName("deallocate")]
	public unsafe static void deallocate_gfl4ncc(void* P_0, void* P_1, long P_2)
	{
		Deallocate(P_1, unchecked(4L * P_2));
	}

	[MangledName("??$_Deallocate@$0BA@@std@@YAXPEAX_K@Z")]
	[DemangledName("void __cdecl std::_Deallocate<16>(void *, unsigned __int64)")]
	public unsafe static void Deallocate(void* P_0, long P_1)
	{
		long num = 0L;
		long* ptr = &num;
		void* ptr2 = null;
		void** ptr3 = &ptr2;
		num = P_1;
		ptr2 = P_0;
		if (unchecked((ulong)num) >= 4096uL)
		{
			Adjust_manually_vector_aligned(ptr3, ptr);
			if (ExceptionInfo.Current != null)
			{
				ExceptionInfo current = ExceptionInfo.Current;
				ExceptionInfo.Current = null;
				IntrinsicFunctions.Implemented.std_terminate();
				throw null;
			}
		}
		IntrinsicFunctions.Implemented.Delete(ptr2, num);
	}

	[MangledName("?_Adjust_manually_vector_aligned@std@@YAXAEAPEAXAEA_K@Z")]
	[DemangledName("void __cdecl std::_Adjust_manually_vector_aligned(void *&, unsigned __int64 &)")]
	public unsafe static void Adjust_manually_vector_aligned(void* P_0, void* P_1)
	{
		unchecked
		{
			*(long*)P_1 += 39L;
			long num = *(long*)((nint)(*(IntPtr*)P_0) + -8);
			long num2 = 8L;
			long num3 = (long)(nuint)(*(nint*)P_0) - num;
			if ((ulong)num3 < 8uL || (ulong)num3 > 39uL)
			{
				IntrinsicFunctions.Implemented.invoke_watson(null, null, null, 0, 0L);
				throw null;
			}
			*(IntPtr*)P_0 = (nint)num;
		}
	}

	[MangledName("??$_Unfancy_maybe_null@I@std@@YAPEAIPEAI@Z")]
	[DemangledName("unsigned int * __cdecl std::_Unfancy_maybe_null<unsigned int>(unsigned int *)")]
	[CleanName("Unfancy_maybe_null")]
	public unsafe static void* Unfancy_maybe_null_ys5czvb(void* P_0)
	{
		return P_0;
	}

	[MangledName("??$maximum@I@fpng@@YAIII@Z")]
	[DemangledName("unsigned int __cdecl fpng::maximum<unsigned int>(unsigned int, unsigned int)")]
	[CleanName("maximum")]
	public static int maximum_y5wzmwb(int P_0, int P_1)
	{
		if (unchecked((uint)P_0 <= (uint)P_1))
		{
			return P_1;
		}
		return P_0;
	}

	[MangledName("?defl_optimize_huffman_table@fpng@@YAXPEAUdefl_huff@1@HHHH@Z")]
	[DemangledName("void __cdecl fpng::defl_optimize_huffman_table(struct fpng::defl_huff *, int, int, int, int)")]
	public unsafe static void defl_optimize_huffman_table(void* P_0, int P_1, int P_2, int P_3, int P_4)
	{
		InlineArray_33_vqkfj7a inlineArray_33_vqkfj7a = default(InlineArray_33_vqkfj7a);
		InlineArray_33_vqkfj7a* ptr = &inlineArray_33_vqkfj7a;
		InlineArray_33_vqkfj7a inlineArray_33_vqkfj7a2 = default(InlineArray_33_vqkfj7a);
		InlineArray_33_vqkfj7a* ptr2 = &inlineArray_33_vqkfj7a2;
		InlineArray_288_27j5lac inlineArray_288_27j5lac = default(InlineArray_288_27j5lac);
		InlineArray_288_27j5lac* ptr3 = &inlineArray_288_27j5lac;
		InlineArray_288_27j5lac inlineArray_288_27j5lac2 = default(InlineArray_288_27j5lac);
		InlineArray_288_27j5lac* ptr4 = &inlineArray_288_27j5lac2;
		IntrinsicFunctions.Implemented.llvm_memset_p0_i64(ptr, 0, 132L, false);
		int num2;
		if (P_4 != 0)
		{
			for (int i = 0; i < P_2; i++)
			{
				(*unchecked((int*)((byte*)ptr + sizeof(int) * ((byte*)(&((fpng_defl_huff*)P_0)->field_2) + sizeof(InlineArray_288_w3otm9c) * P_1)[sizeof(sbyte) * i])))++;
			}
		}
		else
		{
			int num = 0;
			void* ptr6;
			unchecked
			{
				void* ptr5 = (byte*)(&((fpng_defl_huff*)P_0)->field_0) + sizeof(InlineArray_288_oeds4ea) * P_1 + sizeof(short) * 0;
				for (int i = 0; i < P_2; i = checked(i + 1))
				{
					if (((short*)ptr5)[i] != 0)
					{
						short field_ = ((short*)ptr5)[i];
						((fpng_defl_sym_freq*)((byte*)ptr3 + sizeof(fpng_defl_sym_freq) * num))->field_0 = field_;
						((fpng_defl_sym_freq*)((byte*)ptr3 + sizeof(fpng_defl_sym_freq) * checked(num++)))->field_1 = (short)i;
					}
				}
				ptr6 = defl_radix_sort_syms(num, (byte*)ptr3 + sizeof(fpng_defl_sym_freq) * 0, (byte*)ptr4 + sizeof(fpng_defl_sym_freq) * 0);
				defl_calculate_minimum_redundancy(ptr6, num);
			}
			for (int i = 0; i < num; i++)
			{
				(*unchecked((int*)((byte*)ptr + sizeof(int) * (ushort)((fpng_defl_sym_freq*)ptr6)[i].field_0)))++;
			}
			unchecked
			{
				defl_huffman_enforce_max_code_size((byte*)ptr + sizeof(int) * 0, num, P_3);
				IntrinsicFunctions.Implemented.llvm_memset_p0_i64((byte*)(&((fpng_defl_huff*)P_0)->field_2) + sizeof(InlineArray_288_w3otm9c) * P_1, 0, 288L, false);
				IntrinsicFunctions.Implemented.llvm_memset_p0_i64((byte*)(&((fpng_defl_huff*)P_0)->field_1) + sizeof(InlineArray_288_oeds4ea) * P_1, 0, 576L, false);
				int i = 1;
				num2 = num;
				for (; i <= P_3; i = checked(i + 1))
				{
					for (int j = *(int*)((byte*)ptr + sizeof(int) * i); j > 0; j = checked(j + -1))
					{
						sbyte b = (sbyte)i;
						InlineArray_288_w3otm9c* ptr7 = (InlineArray_288_w3otm9c*)((byte*)(&((fpng_defl_huff*)P_0)->field_2) + sizeof(InlineArray_288_w3otm9c) * P_1);
						void* ptr8 = ptr6;
						int num3 = checked(num2 + -1);
						num2 = num3;
						((sbyte*)ptr7)[sizeof(sbyte) * (ushort)((fpng_defl_sym_freq*)ptr8)[num3].field_1] = b;
					}
				}
			}
		}
		*unchecked((int*)((byte*)ptr2 + sizeof(int) * 1)) = 0;
		num2 = 0;
		for (int i = 2; i <= P_3; i++)
		{
			num2 = (*unchecked((int*)((byte*)ptr2 + sizeof(int) * i)) = num2 + *unchecked((int*)((byte*)ptr + sizeof(int) * checked(i - 1))) << 1);
		}
		for (int i = 0; i < P_2; i++)
		{
			int num4 = 0;
			unchecked
			{
				int num5 = ((byte*)(&((fpng_defl_huff*)P_0)->field_2) + sizeof(InlineArray_288_w3otm9c) * P_1)[sizeof(sbyte) * i];
				int num6 = num5;
				if (num5 != 0)
				{
					int num7 = (*(int*)((byte*)ptr2 + sizeof(int) * (int)(uint)num6))++;
					int j = num6;
					while (j > 0)
					{
						num4 = (num4 << 1) | (num7 & 1);
						j = checked(j + -1);
						num7 >>>= 1;
					}
					*(short*)((byte*)(&((fpng_defl_huff*)P_0)->field_1) + sizeof(InlineArray_288_oeds4ea) * P_1 + sizeof(short) * i) = (short)num4;
				}
			}
		}
	}

	[MangledName("??$maximum@H@fpng@@YAHHH@Z")]
	[DemangledName("int __cdecl fpng::maximum<int>(int, int)")]
	[CleanName("maximum")]
	public static int maximum_sfjssib(int P_0, int P_1)
	{
		if (P_0 <= P_1)
		{
			return P_1;
		}
		return P_0;
	}

	[MangledName("?defl_radix_sort_syms@fpng@@YAPEAUdefl_sym_freq@1@IPEAU21@0@Z")]
	[DemangledName("struct fpng::defl_sym_freq * __cdecl fpng::defl_radix_sort_syms(unsigned int, struct fpng::defl_sym_freq *, struct fpng::defl_sym_freq *)")]
	public unsafe static void* defl_radix_sort_syms(int P_0, void* P_1, void* P_2)
	{
		InlineArray_512_vqkfj7a inlineArray_512_vqkfj7a = default(InlineArray_512_vqkfj7a);
		InlineArray_512_vqkfj7a* ptr = &inlineArray_512_vqkfj7a;
		InlineArray_256_vqkfj7a inlineArray_256_vqkfj7a = default(InlineArray_256_vqkfj7a);
		InlineArray_256_vqkfj7a* ptr2 = &inlineArray_256_vqkfj7a;
		int i = 2;
		void* ptr3 = P_1;
		void* ptr4 = P_2;
		IntrinsicFunctions.Implemented.llvm_memset_p0_i64(ptr, 0, 2048L, false);
		unchecked
		{
			for (int j = 0; (uint)j < (uint)P_0; j++)
			{
				int num = (ushort)((fpng_defl_sym_freq*)P_1)[(uint)j].field_0;
				(*(int*)((byte*)ptr + sizeof(int) * (int)(uint)(num & 0xFF)))++;
				(*(int*)((byte*)ptr + sizeof(int) * (int)(uint)(256 + ((num >>> 8) & 0xFF))))++;
			}
			for (; (uint)i > 1u && P_0 == *(int*)((byte*)ptr + sizeof(int) * (int)(uint)((i - 1) * 256)); i += -1)
			{
			}
			int num2 = 0;
			int num3 = 0;
			while ((uint)num3 < (uint)i)
			{
				void* ptr5 = (byte*)ptr + sizeof(int) * (int)(uint)(num3 << 8);
				int num4 = 0;
				for (int j = 0; (uint)j < 256u; j++)
				{
					*(int*)((byte*)ptr2 + sizeof(int) * (int)(uint)j) = num4;
					num4 += ((int*)ptr5)[(uint)j];
				}
				for (int j = 0; (uint)j < (uint)P_0; j++)
				{
					IntrinsicFunctions.Implemented.llvm_memcpy_p0_p0_i64((byte*)ptr4 + (nint)(uint)(*(int*)((byte*)ptr2 + sizeof(int) * (((ushort)((fpng_defl_sym_freq*)ptr3)[(uint)j].field_0 >> num2) & 0xFF)))++ * (nint)sizeof(fpng_defl_sym_freq), (byte*)ptr3 + (nint)(uint)j * (nint)sizeof(fpng_defl_sym_freq), 4L, false);
				}
				void* ptr6 = ptr3;
				ptr3 = ptr4;
				ptr4 = ptr6;
				num3++;
				num2 += 8;
			}
			return ptr3;
		}
	}

	[MangledName("?defl_calculate_minimum_redundancy@fpng@@YAXPEAUdefl_sym_freq@1@H@Z")]
	[DemangledName("void __cdecl fpng::defl_calculate_minimum_redundancy(struct fpng::defl_sym_freq *, int)")]
	public unsafe static void defl_calculate_minimum_redundancy(void* P_0, int P_1)
	{
		if (P_1 == 0)
		{
			return;
		}
		int num3;
		int num2;
		unchecked
		{
			if (P_1 == 1)
			{
				((fpng_defl_sym_freq*)P_0)->field_0 = 1;
				return;
			}
			int num = (ushort)((fpng_defl_sym_freq*)P_0)[1L].field_0;
			short* field_ = &((fpng_defl_sym_freq*)P_0)->field_0;
			*field_ = (short)checked(unchecked((ushort)(*field_)) + num);
			num2 = 0;
			num3 = 2;
		}
		int i;
		for (i = 1; i < P_1 - 1; i++)
		{
			unchecked
			{
				if (num3 >= P_1 || (ushort)((fpng_defl_sym_freq*)P_0)[num2].field_0 < (ushort)((fpng_defl_sym_freq*)P_0)[num3].field_0)
				{
					short field_2 = ((fpng_defl_sym_freq*)P_0)[num2].field_0;
					((fpng_defl_sym_freq*)P_0)[i].field_0 = field_2;
					((fpng_defl_sym_freq*)P_0)[checked(num2++)].field_0 = (short)i;
				}
				else
				{
					short field_3 = ((fpng_defl_sym_freq*)P_0)[checked(num3++)].field_0;
					((fpng_defl_sym_freq*)P_0)[i].field_0 = field_3;
				}
				if (num3 >= P_1 || (num2 < i && (ushort)((fpng_defl_sym_freq*)P_0)[num2].field_0 < (ushort)((fpng_defl_sym_freq*)P_0)[num3].field_0))
				{
					int num4;
					checked
					{
						num4 = unchecked((ushort)((fpng_defl_sym_freq*)P_0)[i].field_0) + unchecked((ushort)((fpng_defl_sym_freq*)P_0)[num2].field_0);
					}
					((fpng_defl_sym_freq*)P_0)[i].field_0 = (short)num4;
					((fpng_defl_sym_freq*)P_0)[checked(num2++)].field_0 = (short)i;
				}
				else
				{
					int num5;
					checked
					{
						num5 = unchecked((ushort)((fpng_defl_sym_freq*)P_0)[i].field_0) + unchecked((ushort)((fpng_defl_sym_freq*)P_0)[checked(num3++)].field_0);
					}
					((fpng_defl_sym_freq*)P_0)[i].field_0 = (short)num5;
				}
			}
		}
		unchecked((fpng_defl_sym_freq*)P_0)[P_1 - 2].field_0 = 0;
		for (i = P_1 - 3; i >= 0; i += -1)
		{
			int num6 = unchecked((ushort)((fpng_defl_sym_freq*)P_0)[(ushort)((fpng_defl_sym_freq*)P_0)[i].field_0].field_0) + 1;
			unchecked
			{
				((fpng_defl_sym_freq*)P_0)[i].field_0 = (short)num6;
			}
		}
		int j = 1;
		int num7 = 0;
		int num8 = 0;
		num2 = P_1 - 2;
		i = P_1 - 1;
		while (j > 0)
		{
			for (; num2 >= 0 && unchecked((ushort)((fpng_defl_sym_freq*)P_0)[num2].field_0) == num7; num2 += -1)
			{
				num8++;
			}
			for (; j > num8; j += -1)
			{
				short field_4 = unchecked((short)num7);
				void* ptr = P_0;
				int num9 = i;
				i = num9 + -1;
				unchecked((fpng_defl_sym_freq*)ptr)[num9].field_0 = field_4;
			}
			j = 2 * num8;
			num7++;
			num8 = 0;
		}
	}

	[MangledName("?defl_huffman_enforce_max_code_size@fpng@@YAXPEAHHH@Z")]
	[DemangledName("void __cdecl fpng::defl_huffman_enforce_max_code_size(int *, int, int)")]
	public unsafe static void defl_huffman_enforce_max_code_size(void* P_0, int P_1, int P_2)
	{
		int i = 0;
		if (P_1 <= 1)
		{
			return;
		}
		for (int j = P_2 + 1; j <= 32; j++)
		{
			unchecked((int*)P_0)[P_2] += unchecked((int*)P_0)[j];
		}
		for (int j = P_2; j > 0; j += -1)
		{
			unchecked
			{
				i += ((int*)P_0)[j] << checked(P_2 - j);
			}
		}
		for (; i != 1 << P_2; i = unchecked(i + -1))
		{
			unchecked((int*)P_0)[P_2] += -1;
			for (int j = P_2 - 1; j > 0; j += -1)
			{
				if (unchecked((int*)P_0)[j] != 0)
				{
					unchecked((int*)P_0)[j] += -1;
					unchecked((int*)P_0)[j + 1] += 2;
					break;
				}
			}
		}
	}

	[MangledName("??0?$vector@_KV?$allocator@_K@std@@@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::vector<unsigned __int64, class std::allocator<unsigned __int64>>(void)")]
	public unsafe static void* vector_unsigned_int64_class_std_allocator_unsigned_int64_Constructor(void* P_0)
	{
		std_Zero_then_variadic_args_t std_Zero_then_variadic_args_t = default(std_Zero_then_variadic_args_t);
		std_Zero_then_variadic_args_t* ptr = &std_Zero_then_variadic_args_t;
		std_Fake_allocator std_Fake_allocator = default(std_Fake_allocator);
		std_Fake_allocator* ptr2 = &std_Fake_allocator;
		unchecked
		{
			void* ptr3 = Compressed_pair_class_std_allocator_unsigned_int64_class_std_Vector_val_struct_std_Simple_types_unsigned_int64_1_Constructor(&((std_vector_5*)P_0)->field_0, ptr->field_0);
			Alloc_proxy(&((std_vector_5*)P_0)->field_0.field_0, ptr2);
			return P_0;
		}
	}

	[MangledName("?resize@?$vector@_KV?$allocator@_K@std@@@std@@QEAAX_K@Z")]
	[DemangledName("public: void __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::resize(unsigned __int64)")]
	[CleanName("resize")]
	public unsafe static void resize_d4pmvud(void* P_0, long P_1)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_resize_d4pmvud>();
		std_Value_init_tag* ptr = &startFrame.GetLocalsPointer<LocalVariables_resize_d4pmvud>()->Instruction_2;
		startFrame.GetLocalsRef<LocalVariables_resize_d4pmvud>().Instruction_0 = P_1;
		startFrame.GetLocalsRef<LocalVariables_resize_d4pmvud>().Instruction_1 = P_0;
		Resize_2s9rs9d(startFrame.GetLocalsRef<LocalVariables_resize_d4pmvud>().Instruction_1, startFrame.GetLocalsRef<LocalVariables_resize_d4pmvud>().Instruction_0, ptr);
		if (ExceptionInfo.Current == null)
		{
			StackFrameList.Current.Clear(startFrame);
		}
	}

	[MangledName("?data@?$vector@_KV?$allocator@_K@std@@@std@@QEAAPEA_KXZ")]
	[DemangledName("public: unsigned __int64 * __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::data(void)")]
	[CleanName("data")]
	public unsafe static void* data_dtgl25a(void* P_0)
	{
		return Unfancy_maybe_null_uqd3pbd(unchecked((std_vector_5*)P_0)->field_0.field_0.field_0);
	}

	[MangledName("?size@?$vector@_KV?$allocator@_K@std@@@std@@QEBA_KXZ")]
	[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::size(void) const")]
	[CleanName("size")]
	public unsafe static long size_trt5i3d(void* P_0)
	{
		unchecked
		{
			void* field_ = &((std_vector_5*)P_0)->field_0.field_0;
			return ((long)((std_Vector_val_9*)field_)->field_1 - (long)((std_Vector_val_9*)field_)->field_0) / 8L;
		}
	}

	[MangledName("??A?$vector@_KV?$allocator@_K@std@@@std@@QEAAAEA_K_K@Z")]
	[DemangledName("public: unsigned __int64 & __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::operator[](unsigned __int64)")]
	[CleanName("operator")]
	public unsafe static void* operator_7d577ub(void* P_0, long P_1)
	{
		return unchecked((byte*)((std_vector_5*)P_0)->field_0.field_0.field_0 + (nint)P_1 * 8);
	}

	[MangledName("??1?$vector@_KV?$allocator@_K@std@@@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::~vector<unsigned __int64, class std::allocator<unsigned __int64>>(void)")]
	public unsafe static void vector_unsigned_int64_class_std_allocator_unsigned_int64_Destructor(void* P_0)
	{
		Tidy_hq3jjxb(P_0);
	}

	[MangledName("??$?0$$V@?$_Compressed_pair@V?$allocator@_K@std@@V?$_Vector_val@U?$_Simple_types@_K@std@@@2@$00@std@@QEAA@U_Zero_then_variadic_args_t@1@@Z")]
	[DemangledName("public: __cdecl std::_Compressed_pair<class std::allocator<unsigned __int64>, class std::_Vector_val<struct std::_Simple_types<unsigned __int64>>, 1>::_Compressed_pair<class std::allocator<unsigned __int64>, class std::_Vector_val<struct std::_Simple_types<unsigned __int64>>, 1><>(struct std::_Zero_then_variadic_args_t)")]
	public unsafe static void* Compressed_pair_class_std_allocator_unsigned_int64_class_std_Vector_val_struct_std_Simple_types_unsigned_int64_1_Constructor(void* P_0, sbyte P_1)
	{
		std_Zero_then_variadic_args_t std_Zero_then_variadic_args_t = default(std_Zero_then_variadic_args_t);
		std_Zero_then_variadic_args_t.field_0 = P_1;
		void* ptr = allocator_unsigned_int64_Constructor(P_0);
		void* ptr2 = Vector_val_struct_std_Simple_types_unsigned_int64_Constructor(&unchecked((std_Compressed_pair_6*)P_0)->field_0);
		return P_0;
	}

	[MangledName("?_Alloc_proxy@_Container_base0@std@@QEAAXAEBU_Fake_allocator@2@@Z")]
	[DemangledName("public: void __cdecl std::_Container_base0::_Alloc_proxy(struct std::_Fake_allocator const &)")]
	public unsafe static void Alloc_proxy(void* P_0, void* P_1)
	{
	}

	[MangledName("??0?$allocator@_K@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::allocator<unsigned __int64>::allocator<unsigned __int64>(void)")]
	public unsafe static void* allocator_unsigned_int64_Constructor(void* P_0)
	{
		return P_0;
	}

	[MangledName("??0?$_Vector_val@U?$_Simple_types@_K@std@@@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::_Vector_val<struct std::_Simple_types<unsigned __int64>>::_Vector_val<struct std::_Simple_types<unsigned __int64>>(void)")]
	public unsafe static void* Vector_val_struct_std_Simple_types_unsigned_int64_Constructor(void* P_0)
	{
		unchecked
		{
			((std_Vector_val_9*)P_0)->field_0 = null;
			((std_Vector_val_9*)P_0)->field_1 = null;
			((std_Vector_val_9*)P_0)->field_2 = null;
			return P_0;
		}
	}

	[MangledName("??$_Resize@U_Value_init_tag@std@@@?$vector@_KV?$allocator@_K@std@@@std@@AEAAX_KAEBU_Value_init_tag@1@@Z")]
	[DemangledName("private: void __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Resize<struct std::_Value_init_tag>(unsigned __int64, struct std::_Value_init_tag const &)")]
	[CleanName("Resize")]
	public unsafe static void Resize_2s9rs9d(void* P_0, long P_1, void* P_2)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_Resize_2s9rs9d>();
		startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_0 = P_2;
		startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_1 = P_1;
		startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_2 = P_0;
		void* instruction_ = startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_2;
		void* instruction_2 = Getal_kuj7nva(instruction_);
		startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_3 = instruction_2;
		unchecked
		{
			std_Vector_val_9* field_ = &((std_vector_5*)instruction_)->field_0.field_0;
			startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_4 = field_;
			void** field_2 = &((std_Vector_val_9*)startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_4)->field_0;
			startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_5 = field_2;
			void** field_3 = &((std_Vector_val_9*)startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_4)->field_1;
			startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_6 = field_3;
			long instruction_3 = ((long)(nuint)(*(nint*)startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_6) - (long)(nuint)(*(nint*)startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_5)) / 8L;
			startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_7 = instruction_3;
			if ((ulong)startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_1 < (ulong)startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_7)
			{
				void* instruction_4 = *(void**)startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_5;
				long instruction_5 = startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_1;
				startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_8 = (byte*)instruction_4 + (nint)instruction_5 * 8;
				void* instruction_6 = *(void**)startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_6;
				Orphan_range_qciws4b(instruction_, startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_8, instruction_6);
				void* instruction_7 = startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_3;
				void* instruction_8 = *(void**)startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_6;
				Destroy_range_qbzp7xb(startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_8, instruction_8, instruction_7);
				void* instruction_9 = startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_8;
				*(void**)startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_6 = instruction_9;
			}
			else if ((ulong)startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_1 > (ulong)startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_7)
			{
				long instruction_10 = ((long)((std_Vector_val_9*)startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_4)->field_2 - (long)(nuint)(*(nint*)startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_5)) / 8L;
				startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_9 = instruction_10;
				if ((ulong)startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_1 > (ulong)startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_9)
				{
					void* instruction_11 = startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_0;
					Resize_reallocate_ytnsorc(instruction_, startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_1, instruction_11);
					if (ExceptionInfo.Current != null)
					{
						return;
					}
				}
				else
				{
					void* instruction_12 = *(void**)startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_6;
					startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_10 = instruction_12;
					void* instruction_13 = startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_3;
					long instruction_14 = startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_1;
					long instruction_15 = startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_7;
					void* ptr = Uninitialized_value_construct_n_hqowyoc(startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_10, instruction_14 - instruction_15, instruction_13);
					*(void**)startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_6 = ptr;
					void* instruction_16 = startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_10;
					Orphan_range_qciws4b(instruction_, startFrame.GetLocalsRef<LocalVariables_Resize_2s9rs9d>().Instruction_10, instruction_16);
				}
			}
			StackFrameList.Current.Clear(startFrame);
		}
	}

	[MangledName("?_Getal@?$vector@_KV?$allocator@_K@std@@@std@@AEAAAEAV?$allocator@_K@2@XZ")]
	[DemangledName("private: class std::allocator<unsigned __int64> & __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Getal(void)")]
	[CleanName("Getal")]
	public unsafe static void* Getal_kuj7nva(void* P_0)
	{
		return Get_first_whlbtqb(&unchecked((std_vector_5*)P_0)->field_0);
	}

	[MangledName("?_Orphan_range@?$vector@_KV?$allocator@_K@std@@@std@@AEBAXPEA_K0@Z")]
	[DemangledName("private: void __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Orphan_range(unsigned __int64 *, unsigned __int64 *) const")]
	[CleanName("Orphan_range")]
	public unsafe static void Orphan_range_qciws4b(void* P_0, void* P_1, void* P_2)
	{
	}

	[MangledName("??$_Destroy_range@V?$allocator@_K@std@@@std@@YAXPEA_KQEA_KAEAV?$allocator@_K@0@@Z")]
	[DemangledName("void __cdecl std::_Destroy_range<class std::allocator<unsigned __int64>>(unsigned __int64 *, unsigned __int64 *const, class std::allocator<unsigned __int64> &)")]
	[CleanName("Destroy_range")]
	public unsafe static void Destroy_range_qbzp7xb(void* P_0, void* P_1, void* P_2)
	{
	}

	[MangledName("??$_Resize_reallocate@U_Value_init_tag@std@@@?$vector@_KV?$allocator@_K@std@@@std@@AEAAX_KAEBU_Value_init_tag@1@@Z")]
	[DemangledName("private: void __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Resize_reallocate<struct std::_Value_init_tag>(unsigned __int64, struct std::_Value_init_tag const &)")]
	[CleanName("Resize_reallocate")]
	public unsafe static void Resize_reallocate_ytnsorc(void* P_0, long P_1, void* P_2)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_Resize_reallocate_ytnsorc>();
		long* ptr = &startFrame.GetLocalsPointer<LocalVariables_Resize_reallocate_ytnsorc>()->Instruction_8;
		std_vector_unsigned_long_long_Reallocation_guard* ptr2 = &startFrame.GetLocalsPointer<LocalVariables_Resize_reallocate_ytnsorc>()->Instruction_11;
		startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_0 = P_2;
		startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_1 = P_1;
		startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_2 = P_0;
		void* instruction_ = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_2;
		unchecked
		{
			if ((ulong)startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_1 > (ulong)max_size_kyvxnnb(instruction_))
			{
				Xlength_zmqdsxa();
				throw null;
			}
			void* instruction_2 = Getal_kuj7nva(instruction_);
			startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_3 = instruction_2;
			std_Vector_val_9* field_ = &((std_vector_5*)instruction_)->field_0.field_0;
			startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_4 = field_;
			void** field_2 = &((std_Vector_val_9*)startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_4)->field_0;
			startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_5 = field_2;
			void** field_3 = &((std_Vector_val_9*)startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_4)->field_1;
			startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_6 = field_3;
			long instruction_3 = ((long)(nuint)(*(nint*)startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_6) - (long)(nuint)(*(nint*)startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_5)) / 8L;
			startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_7 = instruction_3;
			long instruction_4 = Calculate_growth_vbhwmec(instruction_, startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_1);
			startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_8 = instruction_4;
			void* instruction_5 = Allocate_at_least_helper_l9zi7qb(startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_3, ptr);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_9 = instruction_5;
			void* instruction_6 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_9;
			long instruction_7 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_7;
			startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_10 = (byte*)instruction_6 + (nint)instruction_7 * 8;
			void** field_4 = &ptr2->field_0;
			*field_4 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_3;
			void** field_5 = &ptr2->field_1;
			*field_5 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_9;
			long* field_6 = &ptr2->field_2;
			*field_6 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_8;
			void** field_7 = &ptr2->field_3;
			*field_7 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_10;
			void** field_8 = &ptr2->field_4;
			*field_8 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_10;
			void** field_9 = &ptr2->field_4;
			startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_12 = field_9;
			void* instruction_8 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_3;
			long instruction_9 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_1;
			long instruction_10 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_7;
			void* ptr3 = Uninitialized_value_construct_n_hqowyoc(startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_10, instruction_9 - instruction_10, instruction_8);
			if (ExceptionInfo.Current == null)
			{
				*(void**)startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_12 = ptr3;
				void* instruction_11 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_3;
				void* instruction_12 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_9;
				void* instruction_13 = *(void**)startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_6;
				void* ptr4 = Uninitialized_move_cbc4pbc(*(void**)startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_5, instruction_13, instruction_12, instruction_11);
				if (ExceptionInfo.Current == null)
				{
					ptr2->field_1 = null;
					long instruction_14 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_8;
					long instruction_15 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_1;
					Change_array_hgqy2vc(instruction_, startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_ytnsorc>().Instruction_9, instruction_15, instruction_14);
					Reallocation_guard_Destructor_jfaqped(ptr2);
					StackFrameList.Current.Clear(startFrame);
					return;
				}
			}
			ExceptionInfo current = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			Reallocation_guard_Destructor_jfaqped(ptr2);
			ExceptionInfo.Current = current;
		}
	}

	[MangledName("??$_Uninitialized_value_construct_n@V?$allocator@_K@std@@@std@@YAPEA_KPEA_K_KAEAV?$allocator@_K@0@@Z")]
	[DemangledName("unsigned __int64 * __cdecl std::_Uninitialized_value_construct_n<class std::allocator<unsigned __int64>>(unsigned __int64 *, unsigned __int64, class std::allocator<unsigned __int64> &)")]
	[CleanName("Uninitialized_value_construct_n")]
	public unsafe static void* Uninitialized_value_construct_n_hqowyoc(void* P_0, long P_1, void* P_2)
	{
		void* ptr = Unfancy_z2hkbxa(P_0);
		unchecked
		{
			void* ptr2 = Zero_range_lx9svca(ptr, (byte*)ptr + (nint)P_1 * 8);
			return (byte*)P_0 + (nint)P_1 * 8;
		}
	}

	[MangledName("?_Get_first@?$_Compressed_pair@V?$allocator@_K@std@@V?$_Vector_val@U?$_Simple_types@_K@std@@@2@$00@std@@QEAAAEAV?$allocator@_K@2@XZ")]
	[DemangledName("public: class std::allocator<unsigned __int64> & __cdecl std::_Compressed_pair<class std::allocator<unsigned __int64>, class std::_Vector_val<struct std::_Simple_types<unsigned __int64>>, 1>::_Get_first(void)")]
	[CleanName("Get_first")]
	public unsafe static void* Get_first_whlbtqb(void* P_0)
	{
		return P_0;
	}

	[MangledName("?max_size@?$vector@_KV?$allocator@_K@std@@@std@@QEBA_KXZ")]
	[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::max_size(void) const")]
	[CleanName("max_size")]
	public unsafe static long max_size_kyvxnnb(void* P_0)
	{
		long num = 0L;
		long* ptr = &num;
		long num2 = 0L;
		long* ptr2 = &num2;
		num = max_size_ngjedfc(Getal_2reycsb(P_0));
		num2 = Max_limit();
		return *unchecked((long*)min(ptr2, ptr));
	}

	[MangledName("?_Xlength@?$vector@_KV?$allocator@_K@std@@@std@@CAXXZ")]
	[DemangledName("private: static void __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Xlength(void)")]
	[CleanName("Xlength")]
	public unsafe static void Xlength_zmqdsxa()
	{
		IntrinsicFunctions.Unimplemented.Xlength_error(GlobalVariablePointers.String_7b7kt9c);
		throw null;
	}

	[MangledName("?_Calculate_growth@?$vector@_KV?$allocator@_K@std@@@std@@AEBA_K_K@Z")]
	[DemangledName("private: unsigned __int64 __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Calculate_growth(unsigned __int64) const")]
	[CleanName("Calculate_growth")]
	public unsafe static long Calculate_growth_vbhwmec(void* P_0, long P_1)
	{
		long num = capacity_f49yk4c(P_0);
		long num2 = max_size_kyvxnnb(P_0);
		unchecked
		{
			long result;
			if ((ulong)num > (ulong)(num2 - (long)((ulong)num / 2uL)))
			{
				result = num2;
			}
			else
			{
				long num3 = num + (long)((ulong)num / 2uL);
				result = (((ulong)num3 >= (ulong)P_1) ? num3 : P_1);
			}
			return result;
		}
	}

	[MangledName("??$_Allocate_at_least_helper@V?$allocator@_K@std@@@std@@YAPEA_KAEAV?$allocator@_K@0@AEA_K@Z")]
	[DemangledName("unsigned __int64 * __cdecl std::_Allocate_at_least_helper<class std::allocator<unsigned __int64>>(class std::allocator<unsigned __int64> &, unsigned __int64 &)")]
	[CleanName("Allocate_at_least_helper")]
	public unsafe static void* Allocate_at_least_helper_l9zi7qb(void* P_0, void* P_1)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_Allocate_at_least_helper_l9zi7qb>();
		startFrame.GetLocalsRef<LocalVariables_Allocate_at_least_helper_l9zi7qb>().Instruction_0 = P_1;
		startFrame.GetLocalsRef<LocalVariables_Allocate_at_least_helper_l9zi7qb>().Instruction_1 = P_0;
		void* result = allocate_4vpkydd(startFrame.GetLocalsRef<LocalVariables_Allocate_at_least_helper_l9zi7qb>().Instruction_1, *unchecked((long*)startFrame.GetLocalsRef<LocalVariables_Allocate_at_least_helper_l9zi7qb>().Instruction_0));
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		StackFrameList.Current.Clear(startFrame);
		return result;
	}

	[MangledName("??$_Uninitialized_move@PEA_KV?$allocator@_K@std@@@std@@YAPEA_KQEA_K0PEA_KAEAV?$allocator@_K@0@@Z")]
	[DemangledName("unsigned __int64 * __cdecl std::_Uninitialized_move<unsigned __int64 *, class std::allocator<unsigned __int64>>(unsigned __int64 *const, unsigned __int64 *const, unsigned __int64 *, class std::allocator<unsigned __int64> &)")]
	[CleanName("Uninitialized_move")]
	public unsafe static void* Uninitialized_move_cbc4pbc(void* P_0, void* P_1, void* P_2, void* P_3)
	{
		void* ptr = null;
		void** ptr2 = &ptr;
		void* ptr3 = null;
		void** ptr4 = &ptr3;
		ptr = P_1;
		ptr3 = P_0;
		void* ptr5 = Get_unwrapped_3jsimya(ptr4);
		void* ptr6 = Get_unwrapped_3jsimya(ptr2);
		void* ptr7 = Copy_memmove_uofrjzc(ptr5, ptr6, Unfancy_z2hkbxa(P_2));
		return unchecked((byte*)P_2 + (nint)(((long)ptr6 - (long)ptr5) / 8L) * 8);
	}

	[MangledName("?_Change_array@?$vector@_KV?$allocator@_K@std@@@std@@AEAAXQEA_K_K1@Z")]
	[DemangledName("private: void __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Change_array(unsigned __int64 *const, unsigned __int64, unsigned __int64)")]
	[CleanName("Change_array")]
	public unsafe static void Change_array_hgqy2vc(void* P_0, void* P_1, long P_2, long P_3)
	{
		void* ptr = Getal_kuj7nva(P_0);
		unchecked
		{
			void* field_ = &((std_vector_5*)P_0)->field_0.field_0;
			void* field_2 = &((std_Vector_val_9*)field_)->field_0;
			void* field_3 = &((std_Vector_val_9*)field_)->field_1;
			void* field_4 = &((std_Vector_val_9*)field_)->field_2;
			Orphan_all(field_);
			if (*(IntPtr*)field_2 != (IntPtr)(nint)0)
			{
				void* ptr2 = ptr;
				void* ptr3 = *(void**)field_3;
				Destroy_range_qbzp7xb(*(void**)field_2, ptr3, ptr2);
				void* ptr4 = ptr;
				long num = ((long)(nuint)(*(nint*)field_4) - (long)(nuint)(*(nint*)field_2)) / 8L;
				deallocate_yb2gvqa(ptr4, *(void**)field_2, num);
			}
			*(void**)field_2 = P_1;
			*(byte**)field_3 = (byte*)P_1 + (nint)P_2 * 8;
			*(byte**)field_4 = (byte*)P_1 + (nint)P_3 * 8;
		}
	}

	[MangledName("??1_Reallocation_guard@?$vector@_KV?$allocator@_K@std@@@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Reallocation_guard::~_Reallocation_guard(void)")]
	[CleanName("Reallocation_guard_Destructor")]
	public unsafe static void Reallocation_guard_Destructor_jfaqped(void* P_0)
	{
		unchecked
		{
			if (((std_vector_unsigned_long_long_Reallocation_guard*)P_0)->field_1 != null)
			{
				void* field_ = ((std_vector_unsigned_long_long_Reallocation_guard*)P_0)->field_0;
				void* field_2 = ((std_vector_unsigned_long_long_Reallocation_guard*)P_0)->field_4;
				Destroy_range_qbzp7xb(((std_vector_unsigned_long_long_Reallocation_guard*)P_0)->field_3, field_2, field_);
				void* field_3 = ((std_vector_unsigned_long_long_Reallocation_guard*)P_0)->field_0;
				long field_4 = ((std_vector_unsigned_long_long_Reallocation_guard*)P_0)->field_2;
				deallocate_yb2gvqa(field_3, ((std_vector_unsigned_long_long_Reallocation_guard*)P_0)->field_1, field_4);
			}
		}
	}

	[MangledName("?max_size@?$_Default_allocator_traits@V?$allocator@_K@std@@@std@@SA_KAEBV?$allocator@_K@2@@Z")]
	[DemangledName("public: static unsigned __int64 __cdecl std::_Default_allocator_traits<class std::allocator<unsigned __int64>>::max_size(class std::allocator<unsigned __int64> const &)")]
	[CleanName("max_size")]
	public unsafe static long max_size_ngjedfc(void* P_0)
	{
		return 2305843009213693951L;
	}

	[MangledName("?_Getal@?$vector@_KV?$allocator@_K@std@@@std@@AEBAAEBV?$allocator@_K@2@XZ")]
	[DemangledName("private: class std::allocator<unsigned __int64> const & __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Getal(void) const")]
	[CleanName("Getal")]
	public unsafe static void* Getal_2reycsb(void* P_0)
	{
		return Get_first_gcgh4xa(&unchecked((std_vector_5*)P_0)->field_0);
	}

	[MangledName("?_Get_first@?$_Compressed_pair@V?$allocator@_K@std@@V?$_Vector_val@U?$_Simple_types@_K@std@@@2@$00@std@@QEBAAEBV?$allocator@_K@2@XZ")]
	[DemangledName("public: class std::allocator<unsigned __int64> const & __cdecl std::_Compressed_pair<class std::allocator<unsigned __int64>, class std::_Vector_val<struct std::_Simple_types<unsigned __int64>>, 1>::_Get_first(void) const")]
	[CleanName("Get_first")]
	public unsafe static void* Get_first_gcgh4xa(void* P_0)
	{
		return P_0;
	}

	[MangledName("?capacity@?$vector@_KV?$allocator@_K@std@@@std@@QEBA_KXZ")]
	[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::capacity(void) const")]
	[CleanName("capacity")]
	public unsafe static long capacity_f49yk4c(void* P_0)
	{
		unchecked
		{
			void* field_ = &((std_vector_5*)P_0)->field_0.field_0;
			return ((long)((std_Vector_val_9*)field_)->field_2 - (long)((std_Vector_val_9*)field_)->field_0) / 8L;
		}
	}

	[MangledName("?allocate@?$allocator@_K@std@@QEAAPEA_K_K@Z")]
	[DemangledName("public: unsigned __int64 * __cdecl std::allocator<unsigned __int64>::allocate(unsigned __int64)")]
	[CleanName("allocate")]
	public unsafe static void* allocate_4vpkydd(void* P_0, long P_1)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_allocate_4vpkydd>();
		startFrame.GetLocalsRef<LocalVariables_allocate_4vpkydd>().Instruction_0 = P_1;
		startFrame.GetLocalsRef<LocalVariables_allocate_4vpkydd>().Instruction_1 = P_0;
		void* instruction_ = startFrame.GetLocalsRef<LocalVariables_allocate_4vpkydd>().Instruction_1;
		long num = Get_size_of_n_siqup9d(startFrame.GetLocalsRef<LocalVariables_allocate_4vpkydd>().Instruction_0);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		void* result = Allocate_i4jzs2a(num);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		StackFrameList.Current.Clear(startFrame);
		return result;
	}

	[MangledName("??$_Get_size_of_n@$07@std@@YA_K_K@Z")]
	[DemangledName("unsigned __int64 __cdecl std::_Get_size_of_n<8>(unsigned __int64)")]
	[CleanName("Get_size_of_n")]
	public static long Get_size_of_n_siqup9d(long P_0)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_Get_size_of_n_siqup9d>();
		startFrame.GetLocalsRef<LocalVariables_Get_size_of_n_siqup9d>().Instruction_0 = P_0;
		startFrame.GetLocalsRef<LocalVariables_Get_size_of_n_siqup9d>().Instruction_1 = 1;
		startFrame.GetLocalsRef<LocalVariables_Get_size_of_n_siqup9d>().Instruction_2 = 2305843009213693951L;
		unchecked
		{
			if ((ulong)startFrame.GetLocalsRef<LocalVariables_Get_size_of_n_siqup9d>().Instruction_0 > 2305843009213693951uL)
			{
				Throw_bad_array_new_length();
				if (ExceptionInfo.Current != null)
				{
					return 0L;
				}
				throw null;
			}
			long result = startFrame.GetLocalsRef<LocalVariables_Get_size_of_n_siqup9d>().Instruction_0 * 8L;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}

	[MangledName("??$_Get_unwrapped@AEBQEA_K@std@@YA?A_TAEBQEA_K@Z")]
	[DemangledName("decltype(auto) __cdecl std::_Get_unwrapped<unsigned __int64 *const &>(unsigned __int64 *const &)")]
	[CleanName("Get_unwrapped")]
	public unsafe static void* Get_unwrapped_3jsimya(void* P_0)
	{
		return *unchecked((void**)P_0);
	}

	[MangledName("??$_Copy_memmove@PEA_KPEA_K@std@@YAPEA_KPEA_K00@Z")]
	[DemangledName("unsigned __int64 * __cdecl std::_Copy_memmove<unsigned __int64 *, unsigned __int64 *>(unsigned __int64 *, unsigned __int64 *, unsigned __int64 *)")]
	[CleanName("Copy_memmove")]
	public unsafe static void* Copy_memmove_uofrjzc(void* P_0, void* P_1, void* P_2)
	{
		void* ptr = null;
		void** ptr2 = &ptr;
		void* ptr3 = null;
		void** ptr4 = &ptr3;
		ptr = P_1;
		ptr3 = P_0;
		void* ptr5 = To_address_l9253rd(ptr4);
		void* ptr6 = To_address_l9253rd(ptr2);
		unchecked
		{
			long num = ((long)ptr6 - (long)ptr5) / 8L;
			void* ptr7 = ptr5;
			return Copy_memmove_tail_oluaukc(ptr7, P_2, (long)ptr6 - (long)ptr7, num);
		}
	}

	[MangledName("??$_Unfancy@_K@std@@YAPEA_KPEA_K@Z")]
	[DemangledName("unsigned __int64 * __cdecl std::_Unfancy<unsigned __int64>(unsigned __int64 *)")]
	[CleanName("Unfancy")]
	public unsafe static void* Unfancy_z2hkbxa(void* P_0)
	{
		return P_0;
	}

	[MangledName("??$_To_address@PEA_K@std@@YA?A_PAEBQEA_K@Z")]
	[DemangledName("auto __cdecl std::_To_address<unsigned __int64 *>(unsigned __int64 *const &)")]
	[CleanName("To_address")]
	public unsafe static void* To_address_l9253rd(void* P_0)
	{
		return *unchecked((void**)P_0);
	}

	[MangledName("??$_Copy_memmove_tail@PEA_K@std@@YAPEA_KQEBDQEA_K_K2@Z")]
	[DemangledName("unsigned __int64 * __cdecl std::_Copy_memmove_tail<unsigned __int64 *>(char const *const, unsigned __int64 *const, unsigned __int64, unsigned __int64)")]
	[CleanName("Copy_memmove_tail")]
	public unsafe static void* Copy_memmove_tail_oluaukc(void* P_0, void* P_1, long P_2, long P_3)
	{
		void* ptr = null;
		void** ptr2 = &ptr;
		ptr = P_1;
		void* ptr3 = To_address_l9253rd(ptr2);
		IntrinsicFunctions.Implemented.llvm_memmove_p0_p0_i64(ptr3, P_0, P_2, false);
		return unchecked((byte*)ptr3) + P_2;
	}

	[MangledName("?deallocate@?$allocator@_K@std@@QEAAXQEA_K_K@Z")]
	[DemangledName("public: void __cdecl std::allocator<unsigned __int64>::deallocate(unsigned __int64 *const, unsigned __int64)")]
	[CleanName("deallocate")]
	public unsafe static void deallocate_yb2gvqa(void* P_0, void* P_1, long P_2)
	{
		Deallocate(P_1, unchecked(8L * P_2));
	}

	[MangledName("??$_Zero_range@PEA_K@std@@YAPEA_KQEA_K0@Z")]
	[DemangledName("unsigned __int64 * __cdecl std::_Zero_range<unsigned __int64 *>(unsigned __int64 *const, unsigned __int64 *const)")]
	[CleanName("Zero_range")]
	public unsafe static void* Zero_range_lx9svca(void* P_0, void* P_1)
	{
		void* result = null;
		void** ptr = &result;
		void* ptr2 = null;
		void** ptr3 = &ptr2;
		result = P_1;
		ptr2 = P_0;
		void* ptr4 = To_address_l9253rd(ptr3);
		IntrinsicFunctions.Implemented.llvm_memset_p0_i64(ptr4, 0, unchecked((long)To_address_l9253rd(ptr) - (long)ptr4), false);
		return result;
	}

	[MangledName("??$_Unfancy_maybe_null@_K@std@@YAPEA_KPEA_K@Z")]
	[DemangledName("unsigned __int64 * __cdecl std::_Unfancy_maybe_null<unsigned __int64>(unsigned __int64 *)")]
	[CleanName("Unfancy_maybe_null")]
	public unsafe static void* Unfancy_maybe_null_uqd3pbd(void* P_0)
	{
		return P_0;
	}

	[MangledName("?_Tidy@?$vector@_KV?$allocator@_K@std@@@std@@AEAAXXZ")]
	[DemangledName("private: void __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Tidy(void)")]
	[CleanName("Tidy")]
	public unsafe static void Tidy_hq3jjxb(void* P_0)
	{
		void* ptr = Getal_kuj7nva(P_0);
		unchecked
		{
			void* field_ = &((std_vector_5*)P_0)->field_0.field_0;
			void* field_2 = &((std_Vector_val_9*)field_)->field_0;
			void* field_3 = &((std_Vector_val_9*)field_)->field_1;
			void* field_4 = &((std_Vector_val_9*)field_)->field_2;
			Orphan_all(field_);
			if (*(IntPtr*)field_2 != (IntPtr)(nint)0)
			{
				void* ptr2 = ptr;
				void* ptr3 = *(void**)field_3;
				Destroy_range_qbzp7xb(*(void**)field_2, ptr3, ptr2);
				void* ptr4 = ptr;
				long num = ((long)(nuint)(*(nint*)field_4) - (long)(nuint)(*(nint*)field_2)) / 8L;
				deallocate_yb2gvqa(ptr4, *(void**)field_2, num);
				*(IntPtr*)field_2 = (nint)0;
				*(IntPtr*)field_3 = (nint)0;
				*(IntPtr*)field_4 = (nint)0;
			}
		}
	}

	[MangledName("??$minimum@I@fpng@@YAIII@Z")]
	[DemangledName("unsigned int __cdecl fpng::minimum<unsigned int>(unsigned int, unsigned int)")]
	[CleanName("minimum")]
	public static int minimum_su2nfub(int P_0, int P_1)
	{
		if (unchecked((uint)P_0 >= (uint)P_1))
		{
			return P_1;
		}
		return P_0;
	}

	[MangledName("?swap32@fpng@@YAII@Z")]
	[DemangledName("unsigned int __cdecl fpng::swap32(unsigned int)")]
	public static int swap32(int P_0)
	{
		return IntrinsicFunctions.Implemented.llvm_bswap_i32(P_0);
	}

	[MangledName("??$_Resize@U_Value_init_tag@std@@@?$vector@EV?$allocator@E@std@@@std@@AEAAX_KAEBU_Value_init_tag@1@@Z")]
	[DemangledName("private: void __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Resize<struct std::_Value_init_tag>(unsigned __int64, struct std::_Value_init_tag const &)")]
	[CleanName("Resize")]
	public unsafe static void Resize_p4x2rua(void* P_0, long P_1, void* P_2)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_Resize_p4x2rua>();
		startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_0 = P_2;
		startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_1 = P_1;
		startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_2 = P_0;
		void* instruction_ = startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_2;
		void* instruction_2 = Getal_jms5hzb(instruction_);
		startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_3 = instruction_2;
		unchecked
		{
			std_Vector_val* field_ = &((std_vector*)instruction_)->field_0.field_0;
			startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_4 = field_;
			void** field_2 = &((std_Vector_val*)startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_4)->field_0;
			startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_5 = field_2;
			void** field_3 = &((std_Vector_val*)startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_4)->field_1;
			startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_6 = field_3;
			void* instruction_3 = *(void**)startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_6;
			void* instruction_4 = *(void**)startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_5;
			startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_7 = (long)instruction_3 - (long)instruction_4;
			if ((ulong)startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_1 < (ulong)startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_7)
			{
				void* instruction_5 = *(void**)startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_5;
				long instruction_6 = startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_1;
				startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_8 = (byte*)instruction_5 + instruction_6;
				void* instruction_7 = *(void**)startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_6;
				Orphan_range_334quvb(instruction_, startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_8, instruction_7);
				void* instruction_8 = startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_3;
				void* instruction_9 = *(void**)startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_6;
				Destroy_range_jjcob5a(startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_8, instruction_9, instruction_8);
				void* instruction_10 = startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_8;
				*(void**)startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_6 = instruction_10;
			}
			else if ((ulong)startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_1 > (ulong)startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_7)
			{
				void* field_4 = ((std_Vector_val*)startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_4)->field_2;
				void* instruction_11 = *(void**)startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_5;
				startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_9 = (long)field_4 - (long)instruction_11;
				if ((ulong)startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_1 > (ulong)startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_9)
				{
					void* instruction_12 = startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_0;
					Resize_reallocate_dt5hjdb(instruction_, startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_1, instruction_12);
					if (ExceptionInfo.Current != null)
					{
						return;
					}
				}
				else
				{
					void* instruction_13 = *(void**)startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_6;
					startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_10 = instruction_13;
					void* instruction_14 = startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_3;
					long instruction_15 = startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_1;
					long instruction_16 = startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_7;
					void* ptr = Uninitialized_value_construct_n_cxm3ryd(startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_10, instruction_15 - instruction_16, instruction_14);
					*(void**)startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_6 = ptr;
					void* instruction_17 = startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_10;
					Orphan_range_334quvb(instruction_, startFrame.GetLocalsRef<LocalVariables_Resize_p4x2rua>().Instruction_10, instruction_17);
				}
			}
			StackFrameList.Current.Clear(startFrame);
		}
	}

	[MangledName("?_Getal@?$vector@EV?$allocator@E@std@@@std@@AEAAAEAV?$allocator@E@2@XZ")]
	[DemangledName("private: class std::allocator<unsigned char> & __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Getal(void)")]
	[CleanName("Getal")]
	public unsafe static void* Getal_jms5hzb(void* P_0)
	{
		return Get_first_nkl7psd(&unchecked((std_vector*)P_0)->field_0);
	}

	[MangledName("?_Orphan_range@?$vector@EV?$allocator@E@std@@@std@@AEBAXPEAE0@Z")]
	[DemangledName("private: void __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Orphan_range(unsigned char *, unsigned char *) const")]
	[CleanName("Orphan_range")]
	public unsafe static void Orphan_range_334quvb(void* P_0, void* P_1, void* P_2)
	{
	}

	[MangledName("??$_Destroy_range@V?$allocator@E@std@@@std@@YAXPEAEQEAEAEAV?$allocator@E@0@@Z")]
	[DemangledName("void __cdecl std::_Destroy_range<class std::allocator<unsigned char>>(unsigned char *, unsigned char *const, class std::allocator<unsigned char> &)")]
	[CleanName("Destroy_range")]
	public unsafe static void Destroy_range_jjcob5a(void* P_0, void* P_1, void* P_2)
	{
	}

	[MangledName("??$_Resize_reallocate@U_Value_init_tag@std@@@?$vector@EV?$allocator@E@std@@@std@@AEAAX_KAEBU_Value_init_tag@1@@Z")]
	[DemangledName("private: void __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Resize_reallocate<struct std::_Value_init_tag>(unsigned __int64, struct std::_Value_init_tag const &)")]
	[CleanName("Resize_reallocate")]
	public unsafe static void Resize_reallocate_dt5hjdb(void* P_0, long P_1, void* P_2)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_Resize_reallocate_dt5hjdb>();
		long* ptr = &startFrame.GetLocalsPointer<LocalVariables_Resize_reallocate_dt5hjdb>()->Instruction_8;
		std_vector_unsigned_char_Reallocation_guard* ptr2 = &startFrame.GetLocalsPointer<LocalVariables_Resize_reallocate_dt5hjdb>()->Instruction_11;
		startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_0 = P_2;
		startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_1 = P_1;
		startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_2 = P_0;
		void* instruction_ = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_2;
		unchecked
		{
			if ((ulong)startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_1 > (ulong)max_size_2yjes5b(instruction_))
			{
				Xlength_zpuxaia();
				throw null;
			}
			void* instruction_2 = Getal_jms5hzb(instruction_);
			startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_3 = instruction_2;
			std_Vector_val* field_ = &((std_vector*)instruction_)->field_0.field_0;
			startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_4 = field_;
			void** field_2 = &((std_Vector_val*)startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_4)->field_0;
			startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_5 = field_2;
			void** field_3 = &((std_Vector_val*)startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_4)->field_1;
			startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_6 = field_3;
			void* instruction_3 = *(void**)startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_6;
			void* instruction_4 = *(void**)startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_5;
			startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_7 = (long)instruction_3 - (long)instruction_4;
			long instruction_5 = Calculate_growth_scmxisc(instruction_, startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_1);
			startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_8 = instruction_5;
			void* instruction_6 = Allocate_at_least_helper_wikabbc(startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_3, ptr);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_9 = instruction_6;
			void* instruction_7 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_9;
			long instruction_8 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_7;
			startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_10 = (byte*)instruction_7 + instruction_8;
			void** field_4 = &ptr2->field_0;
			*field_4 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_3;
			void** field_5 = &ptr2->field_1;
			*field_5 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_9;
			long* field_6 = &ptr2->field_2;
			*field_6 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_8;
			void** field_7 = &ptr2->field_3;
			*field_7 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_10;
			void** field_8 = &ptr2->field_4;
			*field_8 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_10;
			void** field_9 = &ptr2->field_4;
			startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_12 = field_9;
			void* instruction_9 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_3;
			long instruction_10 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_1;
			long instruction_11 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_7;
			void* ptr3 = Uninitialized_value_construct_n_cxm3ryd(startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_10, instruction_10 - instruction_11, instruction_9);
			if (ExceptionInfo.Current == null)
			{
				*(void**)startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_12 = ptr3;
				void* instruction_12 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_3;
				void* instruction_13 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_9;
				void* instruction_14 = *(void**)startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_6;
				void* ptr4 = Uninitialized_move_vysyj4a(*(void**)startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_5, instruction_14, instruction_13, instruction_12);
				if (ExceptionInfo.Current == null)
				{
					ptr2->field_1 = null;
					long instruction_15 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_8;
					long instruction_16 = startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_1;
					Change_array_k9lpzqa(instruction_, startFrame.GetLocalsRef<LocalVariables_Resize_reallocate_dt5hjdb>().Instruction_9, instruction_16, instruction_15);
					Reallocation_guard_Destructor_9xb7gra(ptr2);
					StackFrameList.Current.Clear(startFrame);
					return;
				}
			}
			ExceptionInfo current = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			Reallocation_guard_Destructor_9xb7gra(ptr2);
			ExceptionInfo.Current = current;
		}
	}

	[MangledName("??$_Uninitialized_value_construct_n@V?$allocator@E@std@@@std@@YAPEAEPEAE_KAEAV?$allocator@E@0@@Z")]
	[DemangledName("unsigned char * __cdecl std::_Uninitialized_value_construct_n<class std::allocator<unsigned char>>(unsigned char *, unsigned __int64, class std::allocator<unsigned char> &)")]
	[CleanName("Uninitialized_value_construct_n")]
	public unsafe static void* Uninitialized_value_construct_n_cxm3ryd(void* P_0, long P_1, void* P_2)
	{
		void* ptr = Unfancy_aszk3nc(P_0);
		unchecked
		{
			void* ptr2 = Zero_range_927ahid(ptr, (byte*)ptr + P_1);
			return (byte*)P_0 + P_1;
		}
	}

	[MangledName("?_Get_first@?$_Compressed_pair@V?$allocator@E@std@@V?$_Vector_val@U?$_Simple_types@E@std@@@2@$00@std@@QEAAAEAV?$allocator@E@2@XZ")]
	[DemangledName("public: class std::allocator<unsigned char> & __cdecl std::_Compressed_pair<class std::allocator<unsigned char>, class std::_Vector_val<struct std::_Simple_types<unsigned char>>, 1>::_Get_first(void)")]
	[CleanName("Get_first")]
	public unsafe static void* Get_first_nkl7psd(void* P_0)
	{
		return P_0;
	}

	[MangledName("?max_size@?$vector@EV?$allocator@E@std@@@std@@QEBA_KXZ")]
	[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::max_size(void) const")]
	[CleanName("max_size")]
	public unsafe static long max_size_2yjes5b(void* P_0)
	{
		long num = 0L;
		long* ptr = &num;
		long num2 = 0L;
		long* ptr2 = &num2;
		num = max_size_hv9dl3d(Getal_llls4cc(P_0));
		num2 = Max_limit();
		return *unchecked((long*)min(ptr2, ptr));
	}

	[MangledName("?_Xlength@?$vector@EV?$allocator@E@std@@@std@@CAXXZ")]
	[DemangledName("private: static void __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Xlength(void)")]
	[CleanName("Xlength")]
	public unsafe static void Xlength_zpuxaia()
	{
		IntrinsicFunctions.Unimplemented.Xlength_error(GlobalVariablePointers.String_7b7kt9c);
		throw null;
	}

	[MangledName("?_Calculate_growth@?$vector@EV?$allocator@E@std@@@std@@AEBA_K_K@Z")]
	[DemangledName("private: unsigned __int64 __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Calculate_growth(unsigned __int64) const")]
	[CleanName("Calculate_growth")]
	public unsafe static long Calculate_growth_scmxisc(void* P_0, long P_1)
	{
		long num = capacity_mz5ysja(P_0);
		long num2 = max_size_2yjes5b(P_0);
		unchecked
		{
			long result;
			if ((ulong)num > (ulong)(num2 - (long)((ulong)num / 2uL)))
			{
				result = num2;
			}
			else
			{
				long num3 = num + (long)((ulong)num / 2uL);
				result = (((ulong)num3 >= (ulong)P_1) ? num3 : P_1);
			}
			return result;
		}
	}

	[MangledName("??$_Allocate_at_least_helper@V?$allocator@E@std@@@std@@YAPEAEAEAV?$allocator@E@0@AEA_K@Z")]
	[DemangledName("unsigned char * __cdecl std::_Allocate_at_least_helper<class std::allocator<unsigned char>>(class std::allocator<unsigned char> &, unsigned __int64 &)")]
	[CleanName("Allocate_at_least_helper")]
	public unsafe static void* Allocate_at_least_helper_wikabbc(void* P_0, void* P_1)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_Allocate_at_least_helper_wikabbc>();
		startFrame.GetLocalsRef<LocalVariables_Allocate_at_least_helper_wikabbc>().Instruction_0 = P_1;
		startFrame.GetLocalsRef<LocalVariables_Allocate_at_least_helper_wikabbc>().Instruction_1 = P_0;
		void* result = allocate_qfop4bd(startFrame.GetLocalsRef<LocalVariables_Allocate_at_least_helper_wikabbc>().Instruction_1, *unchecked((long*)startFrame.GetLocalsRef<LocalVariables_Allocate_at_least_helper_wikabbc>().Instruction_0));
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		StackFrameList.Current.Clear(startFrame);
		return result;
	}

	[MangledName("??$_Uninitialized_move@PEAEV?$allocator@E@std@@@std@@YAPEAEQEAE0PEAEAEAV?$allocator@E@0@@Z")]
	[DemangledName("unsigned char * __cdecl std::_Uninitialized_move<unsigned char *, class std::allocator<unsigned char>>(unsigned char *const, unsigned char *const, unsigned char *, class std::allocator<unsigned char> &)")]
	[CleanName("Uninitialized_move")]
	public unsafe static void* Uninitialized_move_vysyj4a(void* P_0, void* P_1, void* P_2, void* P_3)
	{
		void* ptr = null;
		void** ptr2 = &ptr;
		void* ptr3 = null;
		void** ptr4 = &ptr3;
		ptr = P_1;
		ptr3 = P_0;
		void* ptr5 = Get_unwrapped_z99fpma(ptr4);
		void* ptr6 = Get_unwrapped_z99fpma(ptr2);
		void* ptr7 = Copy_memmove_2kkdavd(ptr5, ptr6, Unfancy_aszk3nc(P_2));
		return unchecked((byte*)P_2 + ((long)ptr6 - (long)ptr5));
	}

	[MangledName("?_Change_array@?$vector@EV?$allocator@E@std@@@std@@AEAAXQEAE_K1@Z")]
	[DemangledName("private: void __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Change_array(unsigned char *const, unsigned __int64, unsigned __int64)")]
	[CleanName("Change_array")]
	public unsafe static void Change_array_k9lpzqa(void* P_0, void* P_1, long P_2, long P_3)
	{
		void* ptr = Getal_jms5hzb(P_0);
		unchecked
		{
			void* field_ = &((std_vector*)P_0)->field_0.field_0;
			void* field_2 = &((std_Vector_val*)field_)->field_0;
			void* field_3 = &((std_Vector_val*)field_)->field_1;
			void* field_4 = &((std_Vector_val*)field_)->field_2;
			Orphan_all(field_);
			if (*(IntPtr*)field_2 != (IntPtr)(nint)0)
			{
				void* ptr2 = ptr;
				void* ptr3 = *(void**)field_3;
				Destroy_range_jjcob5a(*(void**)field_2, ptr3, ptr2);
				void* ptr4 = ptr;
				void* ptr5 = *(void**)field_4;
				void* ptr6 = *(void**)field_2;
				deallocate_mc9rbjc(ptr4, *(void**)field_2, (long)ptr5 - (long)ptr6);
			}
			*(void**)field_2 = P_1;
			*(byte**)field_3 = (byte*)P_1 + P_2;
			*(byte**)field_4 = (byte*)P_1 + P_3;
		}
	}

	[MangledName("??1_Reallocation_guard@?$vector@EV?$allocator@E@std@@@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Reallocation_guard::~_Reallocation_guard(void)")]
	[CleanName("Reallocation_guard_Destructor")]
	public unsafe static void Reallocation_guard_Destructor_9xb7gra(void* P_0)
	{
		unchecked
		{
			if (((std_vector_unsigned_char_Reallocation_guard*)P_0)->field_1 != null)
			{
				void* field_ = ((std_vector_unsigned_char_Reallocation_guard*)P_0)->field_0;
				void* field_2 = ((std_vector_unsigned_char_Reallocation_guard*)P_0)->field_4;
				Destroy_range_jjcob5a(((std_vector_unsigned_char_Reallocation_guard*)P_0)->field_3, field_2, field_);
				void* field_3 = ((std_vector_unsigned_char_Reallocation_guard*)P_0)->field_0;
				long field_4 = ((std_vector_unsigned_char_Reallocation_guard*)P_0)->field_2;
				deallocate_mc9rbjc(field_3, ((std_vector_unsigned_char_Reallocation_guard*)P_0)->field_1, field_4);
			}
		}
	}

	[MangledName("?max_size@?$_Default_allocator_traits@V?$allocator@E@std@@@std@@SA_KAEBV?$allocator@E@2@@Z")]
	[DemangledName("public: static unsigned __int64 __cdecl std::_Default_allocator_traits<class std::allocator<unsigned char>>::max_size(class std::allocator<unsigned char> const &)")]
	[CleanName("max_size")]
	public unsafe static long max_size_hv9dl3d(void* P_0)
	{
		return -1L;
	}

	[MangledName("?_Getal@?$vector@EV?$allocator@E@std@@@std@@AEBAAEBV?$allocator@E@2@XZ")]
	[DemangledName("private: class std::allocator<unsigned char> const & __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Getal(void) const")]
	[CleanName("Getal")]
	public unsafe static void* Getal_llls4cc(void* P_0)
	{
		return Get_first_pnsruja(&unchecked((std_vector*)P_0)->field_0);
	}

	[MangledName("?_Get_first@?$_Compressed_pair@V?$allocator@E@std@@V?$_Vector_val@U?$_Simple_types@E@std@@@2@$00@std@@QEBAAEBV?$allocator@E@2@XZ")]
	[DemangledName("public: class std::allocator<unsigned char> const & __cdecl std::_Compressed_pair<class std::allocator<unsigned char>, class std::_Vector_val<struct std::_Simple_types<unsigned char>>, 1>::_Get_first(void) const")]
	[CleanName("Get_first")]
	public unsafe static void* Get_first_pnsruja(void* P_0)
	{
		return P_0;
	}

	[MangledName("?capacity@?$vector@EV?$allocator@E@std@@@std@@QEBA_KXZ")]
	[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::capacity(void) const")]
	[CleanName("capacity")]
	public unsafe static long capacity_mz5ysja(void* P_0)
	{
		unchecked
		{
			void* field_ = &((std_vector*)P_0)->field_0.field_0;
			return (long)((std_Vector_val*)field_)->field_2 - (long)((std_Vector_val*)field_)->field_0;
		}
	}

	[MangledName("?allocate@?$allocator@E@std@@QEAAPEAE_K@Z")]
	[DemangledName("public: unsigned char * __cdecl std::allocator<unsigned char>::allocate(unsigned __int64)")]
	[CleanName("allocate")]
	public unsafe static void* allocate_qfop4bd(void* P_0, long P_1)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_allocate_qfop4bd>();
		startFrame.GetLocalsRef<LocalVariables_allocate_qfop4bd>().Instruction_0 = P_1;
		startFrame.GetLocalsRef<LocalVariables_allocate_qfop4bd>().Instruction_1 = P_0;
		void* instruction_ = startFrame.GetLocalsRef<LocalVariables_allocate_qfop4bd>().Instruction_1;
		void* result = Allocate_i4jzs2a(Get_size_of_n_iqtw9sb(startFrame.GetLocalsRef<LocalVariables_allocate_qfop4bd>().Instruction_0));
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		StackFrameList.Current.Clear(startFrame);
		return result;
	}

	[MangledName("??$_Get_size_of_n@$00@std@@YA_K_K@Z")]
	[DemangledName("unsigned __int64 __cdecl std::_Get_size_of_n<1>(unsigned __int64)")]
	[CleanName("Get_size_of_n")]
	public static long Get_size_of_n_iqtw9sb(long P_0)
	{
		sbyte b = 0;
		return unchecked(P_0 * 1L);
	}

	[MangledName("??$_Get_unwrapped@AEBQEAE@std@@YA?A_TAEBQEAE@Z")]
	[DemangledName("decltype(auto) __cdecl std::_Get_unwrapped<unsigned char *const &>(unsigned char *const &)")]
	[CleanName("Get_unwrapped")]
	public unsafe static void* Get_unwrapped_z99fpma(void* P_0)
	{
		return *unchecked((void**)P_0);
	}

	[MangledName("??$_Copy_memmove@PEAEPEAE@std@@YAPEAEPEAE00@Z")]
	[DemangledName("unsigned char * __cdecl std::_Copy_memmove<unsigned char *, unsigned char *>(unsigned char *, unsigned char *, unsigned char *)")]
	[CleanName("Copy_memmove")]
	public unsafe static void* Copy_memmove_2kkdavd(void* P_0, void* P_1, void* P_2)
	{
		void* ptr = null;
		void** ptr2 = &ptr;
		void* ptr3 = null;
		void** ptr4 = &ptr3;
		ptr = P_1;
		ptr3 = P_0;
		void* ptr5 = To_address_enkoctc(ptr4);
		void* ptr6 = To_address_enkoctc(ptr2);
		unchecked
		{
			long num = (long)ptr6 - (long)ptr5;
			void* ptr7 = ptr5;
			return Copy_memmove_tail_x7ipzed(ptr7, P_2, (long)ptr6 - (long)ptr7, num);
		}
	}

	[MangledName("??$_Unfancy@E@std@@YAPEAEPEAE@Z")]
	[DemangledName("unsigned char * __cdecl std::_Unfancy<unsigned char>(unsigned char *)")]
	[CleanName("Unfancy")]
	public unsafe static void* Unfancy_aszk3nc(void* P_0)
	{
		return P_0;
	}

	[MangledName("??$_To_address@PEAE@std@@YA?A_PAEBQEAE@Z")]
	[DemangledName("auto __cdecl std::_To_address<unsigned char *>(unsigned char *const &)")]
	[CleanName("To_address")]
	public unsafe static void* To_address_enkoctc(void* P_0)
	{
		return *unchecked((void**)P_0);
	}

	[MangledName("??$_Copy_memmove_tail@PEAE@std@@YAPEAEQEBDQEAE_K2@Z")]
	[DemangledName("unsigned char * __cdecl std::_Copy_memmove_tail<unsigned char *>(char const *const, unsigned char *const, unsigned __int64, unsigned __int64)")]
	[CleanName("Copy_memmove_tail")]
	public unsafe static void* Copy_memmove_tail_x7ipzed(void* P_0, void* P_1, long P_2, long P_3)
	{
		void* ptr = null;
		void** ptr2 = &ptr;
		ptr = P_1;
		void* ptr3 = To_address_enkoctc(ptr2);
		IntrinsicFunctions.Implemented.llvm_memmove_p0_p0_i64(ptr3, P_0, P_2, false);
		return unchecked((byte*)ptr3) + P_2;
	}

	[MangledName("?deallocate@?$allocator@E@std@@QEAAXQEAE_K@Z")]
	[DemangledName("public: void __cdecl std::allocator<unsigned char>::deallocate(unsigned char *const, unsigned __int64)")]
	[CleanName("deallocate")]
	public unsafe static void deallocate_mc9rbjc(void* P_0, void* P_1, long P_2)
	{
		Deallocate(P_1, unchecked(1L * P_2));
	}

	[MangledName("??$_Zero_range@PEAE@std@@YAPEAEQEAE0@Z")]
	[DemangledName("unsigned char * __cdecl std::_Zero_range<unsigned char *>(unsigned char *const, unsigned char *const)")]
	[CleanName("Zero_range")]
	public unsafe static void* Zero_range_927ahid(void* P_0, void* P_1)
	{
		void* result = null;
		void** ptr = &result;
		void* ptr2 = null;
		void** ptr3 = &ptr2;
		result = P_1;
		ptr2 = P_0;
		void* ptr4 = To_address_enkoctc(ptr3);
		IntrinsicFunctions.Implemented.llvm_memset_p0_i64(ptr4, 0, unchecked((long)To_address_enkoctc(ptr) - (long)ptr4), false);
		return result;
	}

	[MangledName("??$_Unfancy_maybe_null@E@std@@YAPEAEPEAE@Z")]
	[DemangledName("unsigned char * __cdecl std::_Unfancy_maybe_null<unsigned char>(unsigned char *)")]
	[CleanName("Unfancy_maybe_null")]
	public unsafe static void* Unfancy_maybe_null_pj5f7cb(void* P_0)
	{
		return P_0;
	}

	[MangledName("??$?0$$V@?$_Compressed_pair@V?$allocator@E@std@@V?$_Vector_val@U?$_Simple_types@E@std@@@2@$00@std@@QEAA@U_Zero_then_variadic_args_t@1@@Z")]
	[DemangledName("public: __cdecl std::_Compressed_pair<class std::allocator<unsigned char>, class std::_Vector_val<struct std::_Simple_types<unsigned char>>, 1>::_Compressed_pair<class std::allocator<unsigned char>, class std::_Vector_val<struct std::_Simple_types<unsigned char>>, 1><>(struct std::_Zero_then_variadic_args_t)")]
	public unsafe static void* Compressed_pair_class_std_allocator_unsigned_char_class_std_Vector_val_struct_std_Simple_types_unsigned_char_1_Constructor(void* P_0, sbyte P_1)
	{
		std_Zero_then_variadic_args_t std_Zero_then_variadic_args_t = default(std_Zero_then_variadic_args_t);
		std_Zero_then_variadic_args_t.field_0 = P_1;
		void* ptr = allocator_unsigned_char_Constructor(P_0);
		void* ptr2 = Vector_val_struct_std_Simple_types_unsigned_char_Constructor(&unchecked((std_Compressed_pair*)P_0)->field_0);
		return P_0;
	}

	[MangledName("??0?$allocator@E@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::allocator<unsigned char>::allocator<unsigned char>(void)")]
	public unsafe static void* allocator_unsigned_char_Constructor(void* P_0)
	{
		return P_0;
	}

	[MangledName("??0?$_Vector_val@U?$_Simple_types@E@std@@@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::_Vector_val<struct std::_Simple_types<unsigned char>>::_Vector_val<struct std::_Simple_types<unsigned char>>(void)")]
	public unsafe static void* Vector_val_struct_std_Simple_types_unsigned_char_Constructor(void* P_0)
	{
		unchecked
		{
			((std_Vector_val*)P_0)->field_0 = null;
			((std_Vector_val*)P_0)->field_1 = null;
			((std_Vector_val*)P_0)->field_2 = null;
			return P_0;
		}
	}

	[MangledName("?_Tidy@?$vector@EV?$allocator@E@std@@@std@@AEAAXXZ")]
	[DemangledName("private: void __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Tidy(void)")]
	[CleanName("Tidy")]
	public unsafe static void Tidy_iono57d(void* P_0)
	{
		void* ptr = Getal_jms5hzb(P_0);
		unchecked
		{
			void* field_ = &((std_vector*)P_0)->field_0.field_0;
			void* field_2 = &((std_Vector_val*)field_)->field_0;
			void* field_3 = &((std_Vector_val*)field_)->field_1;
			void* field_4 = &((std_Vector_val*)field_)->field_2;
			Orphan_all(field_);
			if (*(IntPtr*)field_2 != (IntPtr)(nint)0)
			{
				void* ptr2 = ptr;
				void* ptr3 = *(void**)field_3;
				Destroy_range_jjcob5a(*(void**)field_2, ptr3, ptr2);
				void* ptr4 = ptr;
				void* ptr5 = *(void**)field_4;
				void* ptr6 = *(void**)field_2;
				deallocate_mc9rbjc(ptr4, *(void**)field_2, (long)ptr5 - (long)ptr6);
				*(IntPtr*)field_2 = (nint)0;
				*(IntPtr*)field_3 = (nint)0;
				*(IntPtr*)field_4 = (nint)0;
			}
		}
	}

	[MangledName("?fpng_pixel_zlib_raw_decompress@fpng@@YA_NPEBEIIPEAEIIII@Z")]
	[DemangledName("bool __cdecl fpng::fpng_pixel_zlib_raw_decompress(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int, unsigned int, unsigned int, unsigned int)")]
	public unsafe static bool fpng_pixel_zlib_raw_decompress(void* P_0, int P_1, int P_2, void* P_3, int P_4, int P_5, int P_6, int P_7)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_fpng_pixel_zlib_raw_decompress>();
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_1 = P_7;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_2 = P_6;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_3 = P_5;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_4 = P_4;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_5 = P_3;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_6 = P_2;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_7 = P_1;
		startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_8 = P_0;
		if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_2 == 3)
		{
			bool flag = true;
		}
		else if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_2 == 4)
		{
			bool flag = true;
		}
		else
		{
			IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_zixkhbc, GlobalVariablePointers.String_uxbkrtb, 2112);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			bool flag = false;
		}
		if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_1 == 3)
		{
			bool flag2 = true;
		}
		else if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_1 == 4)
		{
			bool flag2 = true;
		}
		else
		{
			IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_kppxlqc, GlobalVariablePointers.String_uxbkrtb, 2113);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			bool flag2 = false;
		}
		int instruction_ = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_4;
		int instruction_2 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_2;
		unchecked
		{
			startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_9 = instruction_ * instruction_2;
			int instruction_3 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_4;
			int instruction_4 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_1;
			startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_10 = instruction_3 * instruction_4;
			int instruction_5 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_10;
			int instruction_6 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_3;
			startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_11 = instruction_5 * instruction_6;
			startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_12 = 2;
			startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_13 = 0;
			startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_14 = 0;
			startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_15 = 0;
			while (true)
			{
				if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_12 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_7)
				{
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_0 = false;
					break;
				}
				sbyte b = ((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_8)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_12];
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_16 = ((((byte)b & 1) != 0) ? ((sbyte)1) : ((sbyte)0));
				sbyte b2 = ((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_8)[(uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_12];
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_17 = ((byte)b2 >> 1) & 3;
				if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_17 != 0)
				{
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_0 = false;
					break;
				}
				int instruction_7 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_12;
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_12 = instruction_7 + 1;
				if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_12 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_7)
				{
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_0 = false;
					break;
				}
				int num = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_8)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_12 + 0)];
				sbyte b3 = ((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_8)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_12 + 1)];
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_18 = num | ((byte)b3 << 8);
				int num2 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_8)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_12 + 2)];
				sbyte b4 = ((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_8)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_12 + 3)];
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_19 = num2 | ((byte)b4 << 8);
				int instruction_8 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_12;
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_12 = instruction_8 + 4;
				if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_18 != ((startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_19 ^ -1) & 0xFFFF))
				{
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_0 = false;
					break;
				}
				if ((uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_12 + startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_18) > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_7)
				{
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_0 = false;
					break;
				}
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_20 = 0;
				while ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_20 < (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_18)
				{
					sbyte b5 = ((sbyte*)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_8)[(uint)(startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_12 + startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_20)];
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_21 = (byte)b5;
					if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_14 == 0)
					{
						if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_21 != 0)
						{
							goto IL_0685;
						}
						if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_15 == 0)
						{
							bool flag3 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ji2h3xd, GlobalVariablePointers.String_uxbkrtb, 2160);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							bool flag3 = false;
						}
					}
					else
					{
						if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_15 < (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_1)
						{
							if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_13 == startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_11)
							{
								goto IL_073e;
							}
							sbyte b6 = (sbyte)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_21;
							void* instruction_9 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_5;
							int instruction_10 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_13;
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_13 = instruction_10 + 1;
							((sbyte*)instruction_9)[(uint)instruction_10] = b6;
						}
						int num3 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_15 + 1;
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_15 = num3;
						if (num3 == startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_2)
						{
							if ((uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_1 > (uint)startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_2)
							{
								if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_13 == startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_11)
								{
									goto IL_084c;
								}
								void* instruction_11 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_5;
								int instruction_12 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_13;
								startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_13 = instruction_12 + 1;
								((sbyte*)instruction_11)[(uint)instruction_12] = -1;
							}
							startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_15 = 0;
						}
					}
					int num4 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_14 + 1;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_14 = num4;
					if (num4 == startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_9 + 1)
					{
						if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_15 == 0)
						{
							bool flag4 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_ji2h3xd, GlobalVariablePointers.String_uxbkrtb, 2188);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							bool flag4 = false;
						}
						startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_14 = 0;
					}
					int instruction_13 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_20;
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_20 = instruction_13 + 1;
				}
				int instruction_14 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_18;
				int instruction_15 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_12;
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_12 = instruction_15 + instruction_14;
				if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_16 != 0)
				{
					continue;
				}
				if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_15 != 0)
				{
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_0 = false;
					break;
				}
				if (startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_12 + 4 != startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_6)
				{
					startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_0 = false;
					break;
				}
				int instruction_16 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_13;
				int instruction_17 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_11;
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_0 = instruction_16 == instruction_17;
				break;
				IL_073e:
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_0 = false;
				break;
				IL_084c:
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_0 = false;
				break;
				IL_0685:
				startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_0 = false;
				break;
			}
			bool instruction_18 = startFrame.GetLocalsRef<LocalVariables_fpng_pixel_zlib_raw_decompress>().Instruction_0;
			StackFrameList.Current.Clear(startFrame);
			return instruction_18;
		}
	}

	[MangledName("?prepare_dynamic_block@fpng@@YA_NPEBEIAEAI1AEA_KPEAII@Z")]
	[DemangledName("bool __cdecl fpng::prepare_dynamic_block(unsigned char const *, unsigned int, unsigned int &, unsigned int &, unsigned __int64 &, unsigned int *, unsigned int)")]
	public unsafe static bool prepare_dynamic_block(void* P_0, int P_1, void* P_2, void* P_3, void* P_4, void* P_5, int P_6)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_prepare_dynamic_block>();
		InlineArray_320_w3otm9c* ptr = &startFrame.GetLocalsPointer<LocalVariables_prepare_dynamic_block>()->Instruction_14;
		InlineArray_19_w3otm9c* ptr2 = &startFrame.GetLocalsPointer<LocalVariables_prepare_dynamic_block>()->Instruction_16;
		InlineArray_4096_vqkfj7a* ptr3 = &startFrame.GetLocalsPointer<LocalVariables_prepare_dynamic_block>()->Instruction_20;
		InlineArray_288_w3otm9c* ptr4 = &startFrame.GetLocalsPointer<LocalVariables_prepare_dynamic_block>()->Instruction_31;
		startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_1 = P_6;
		startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_2 = P_5;
		startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3 = P_4;
		startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4 = P_3;
		startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5 = P_2;
		startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_6 = P_1;
		startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_7 = P_0;
		startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_11 = 5;
		unchecked
		{
			if (startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_11 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_11 <= 32u)
			{
				bool flag = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_aa3exrc, GlobalVariablePointers.String_uxbkrtb, 1963);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				bool flag = false;
			}
			long instruction_ = *(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3;
			int instruction_2 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_11;
			int num = *(int*)((byte*)GlobalVariablePointers.g_bitmasks + sizeof(int) * (int)(uint)instruction_2);
			startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_8 = (int)(instruction_ & (uint)num);
			int instruction_3 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_11;
			*(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3 >>>= (int)(uint)instruction_3;
			int instruction_4 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_11;
			*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4 -= instruction_4;
			if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4) < 32u)
			{
				if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_6)
				{
					startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_0 = false;
					goto IL_27da;
				}
				long num2 = (uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_7 + (uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5)));
				int instruction_5 = *(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4;
				*(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3 |= num2 << (int)(uint)instruction_5;
				*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5 += 4;
				*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4 += 32;
			}
			int instruction_6 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_8;
			startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_8 = instruction_6 + 257;
			startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_12 = 5;
			if (startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_12 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_12 <= 32u)
			{
				bool flag2 = true;
			}
			else
			{
				IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_aa3exrc, GlobalVariablePointers.String_uxbkrtb, 1966);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				bool flag2 = false;
			}
			long instruction_7 = *(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3;
			int instruction_8 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_12;
			int num3 = *(int*)((byte*)GlobalVariablePointers.g_bitmasks + sizeof(int) * (int)(uint)instruction_8);
			startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_9 = (int)(instruction_7 & (uint)num3);
			int instruction_9 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_12;
			*(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3 >>>= (int)(uint)instruction_9;
			int instruction_10 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_12;
			*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4 -= instruction_10;
			if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4) < 32u)
			{
				if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_6)
				{
					startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_0 = false;
					goto IL_27da;
				}
				long num4 = (uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_7 + (uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5)));
				int instruction_11 = *(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4;
				*(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3 |= num4 << (int)(uint)instruction_11;
				*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5 += 4;
				*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4 += 32;
			}
			int instruction_12 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_9;
			startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_9 = instruction_12 + 1;
			int instruction_13 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_8;
			int instruction_14 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_9;
			startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_13 = instruction_13 + instruction_14;
			if ((uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_13 > 320u)
			{
				startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_0 = false;
			}
			else
			{
				IntrinsicFunctions.Implemented.llvm_memset_p0_i64((byte*)ptr + sizeof(sbyte) * 0, 0, 320L, false);
				startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_15 = 4;
				if (startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_15 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_15 <= 32u)
				{
					bool flag3 = true;
				}
				else
				{
					IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_aa3exrc, GlobalVariablePointers.String_uxbkrtb, 1976);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					bool flag3 = false;
				}
				long instruction_15 = *(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3;
				int instruction_16 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_15;
				int num5 = *(int*)((byte*)GlobalVariablePointers.g_bitmasks + sizeof(int) * (int)(uint)instruction_16);
				startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_10 = (int)(instruction_15 & (uint)num5);
				int instruction_17 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_15;
				*(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3 >>>= (int)(uint)instruction_17;
				int instruction_18 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_15;
				*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4 -= instruction_18;
				if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4) < 32u)
				{
					if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_6)
					{
						startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_0 = false;
						goto IL_27da;
					}
					long num6 = (uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_7 + (uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5)));
					int instruction_19 = *(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4;
					*(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3 |= num6 << (int)(uint)instruction_19;
					*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5 += 4;
					*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4 += 32;
				}
				int instruction_20 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_10;
				startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_10 = instruction_20 + 4;
				IntrinsicFunctions.Implemented.llvm_memset_p0_i64((byte*)ptr2 + sizeof(sbyte) * 0, 0, 19L, false);
				startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_17 = 0;
				while (true)
				{
					if ((uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_17 < (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_10)
					{
						startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_18 = 0;
						startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_19 = 3;
						if (startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_19 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_19 <= 32u)
						{
							bool flag4 = true;
						}
						else
						{
							IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_aa3exrc, GlobalVariablePointers.String_uxbkrtb, 1985);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							bool flag4 = false;
						}
						long instruction_21 = *(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3;
						int instruction_22 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_19;
						int num7 = *(int*)((byte*)GlobalVariablePointers.g_bitmasks + sizeof(int) * (int)(uint)instruction_22);
						startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_18 = (int)(instruction_21 & (uint)num7);
						int instruction_23 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_19;
						*(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3 >>>= (int)(uint)instruction_23;
						int instruction_24 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_19;
						*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4 -= instruction_24;
						if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4) < 32u)
						{
							if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_6)
							{
								startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_0 = false;
								break;
							}
							long num8 = (uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_7 + (uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5)));
							int instruction_25 = *(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4;
							*(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3 |= num8 << (int)(uint)instruction_25;
							*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5 += 4;
							*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4 += 32;
						}
						sbyte b = (sbyte)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_18;
						int instruction_26 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_17;
						((sbyte*)ptr2)[sizeof(sbyte) * (byte)((sbyte*)GlobalVariablePointers.s_bit_length_order)[sizeof(sbyte) * (int)(uint)instruction_26]] = b;
						int instruction_27 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_17;
						startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_17 = instruction_27 + 1;
						continue;
					}
					bool flag5 = build_decoder_table(19, (byte*)ptr2 + sizeof(sbyte) * 0, (byte*)ptr3 + sizeof(int) * 0);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (!flag5)
					{
						startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_0 = false;
						break;
					}
					startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_21 = 15;
					startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_22 = 0;
					while (true)
					{
						if ((uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_22 < (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_13)
						{
							int instruction_28 = *(int*)((byte*)ptr3 + sizeof(int) * (int)(*(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3 & 0xFFFL));
							startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_23 = instruction_28;
							int instruction_29 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_23;
							startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_24 = instruction_29 >>> 9;
							if (startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_24 == 0)
							{
								startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_0 = false;
								break;
							}
							int instruction_30 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_24;
							startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_25 = instruction_30;
							if ((uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_25 <= 32u)
							{
								bool flag6 = true;
							}
							else
							{
								IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_mf9hyza, GlobalVariablePointers.String_uxbkrtb, 2001);
								if (ExceptionInfo.Current != null)
								{
									return false;
								}
								bool flag6 = false;
							}
							int instruction_31 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_25;
							*(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3 >>>= (int)(uint)instruction_31;
							int instruction_32 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_25;
							*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4 -= instruction_32;
							if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4) < 32u)
							{
								if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_6)
								{
									startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_0 = false;
									break;
								}
								long num9 = (uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_7 + (uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5)));
								int instruction_33 = *(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4;
								*(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3 |= num9 << (int)(uint)instruction_33;
								*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5 += 4;
								*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4 += 32;
							}
							int instruction_34 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_23;
							startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_23 = instruction_34 & 0x1FF;
							if ((uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_23 <= 15u)
							{
								if ((uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_23 > 12u)
								{
									startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_0 = false;
									break;
								}
								if (startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_23 != 0)
								{
									int instruction_35 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_23;
									int instruction_36 = minimum_su2nfub(startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_21, instruction_35);
									startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_21 = instruction_36;
								}
								sbyte b2 = (sbyte)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_23;
								int instruction_37 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_22;
								startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_22 = instruction_37 + 1;
								((sbyte*)ptr)[sizeof(sbyte) * (int)(uint)instruction_37] = b2;
								continue;
							}
							startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_26 = 0;
							startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_27 = 0;
							int instruction_38 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_23;
							if (instruction_38 != 16)
							{
								if (instruction_38 != 17)
								{
									if (instruction_38 == 18)
									{
										startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_30 = 7;
										if (startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_30 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_30 <= 32u)
										{
											bool flag7 = true;
										}
										else
										{
											IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_aa3exrc, GlobalVariablePointers.String_uxbkrtb, 2039);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											bool flag7 = false;
										}
										long instruction_39 = *(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3;
										int instruction_40 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_30;
										int num10 = *(int*)((byte*)GlobalVariablePointers.g_bitmasks + sizeof(int) * (int)(uint)instruction_40);
										startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_26 = (int)(instruction_39 & (uint)num10);
										int instruction_41 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_30;
										*(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3 >>>= (int)(uint)instruction_41;
										int instruction_42 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_30;
										*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4 -= instruction_42;
										if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4) < 32u)
										{
											if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_6)
											{
												startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_0 = false;
												break;
											}
											long num11 = (uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_7 + (uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5)));
											int instruction_43 = *(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4;
											*(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3 |= num11 << (int)(uint)instruction_43;
											*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5 += 4;
											*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4 += 32;
										}
										int instruction_44 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_26;
										startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_26 = instruction_44 + 11;
										startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_27 = 0;
									}
								}
								else
								{
									startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_29 = 3;
									if (startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_29 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_29 <= 32u)
									{
										bool flag8 = true;
									}
									else
									{
										IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_aa3exrc, GlobalVariablePointers.String_uxbkrtb, 2032);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										bool flag8 = false;
									}
									long instruction_45 = *(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3;
									int instruction_46 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_29;
									int num12 = *(int*)((byte*)GlobalVariablePointers.g_bitmasks + sizeof(int) * (int)(uint)instruction_46);
									startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_26 = (int)(instruction_45 & (uint)num12);
									int instruction_47 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_29;
									*(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3 >>>= (int)(uint)instruction_47;
									int instruction_48 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_29;
									*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4 -= instruction_48;
									if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4) < 32u)
									{
										if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_6)
										{
											startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_0 = false;
											break;
										}
										long num13 = (uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_7 + (uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5)));
										int instruction_49 = *(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4;
										*(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3 |= num13 << (int)(uint)instruction_49;
										*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5 += 4;
										*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4 += 32;
									}
									int instruction_50 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_26;
									startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_26 = instruction_50 + 3;
									startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_27 = 0;
								}
							}
							else
							{
								startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_28 = 2;
								if (startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_28 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_28 <= 32u)
								{
									bool flag9 = true;
								}
								else
								{
									IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_aa3exrc, GlobalVariablePointers.String_uxbkrtb, 2023);
									if (ExceptionInfo.Current != null)
									{
										return false;
									}
									bool flag9 = false;
								}
								long instruction_51 = *(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3;
								int instruction_52 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_28;
								int num14 = *(int*)((byte*)GlobalVariablePointers.g_bitmasks + sizeof(int) * (int)(uint)instruction_52);
								startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_26 = (int)(instruction_51 & (uint)num14);
								int instruction_53 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_28;
								*(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3 >>>= (int)(uint)instruction_53;
								int instruction_54 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_28;
								*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4 -= instruction_54;
								if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4) < 32u)
								{
									if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_6)
									{
										startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_0 = false;
										break;
									}
									long num15 = (uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_7 + (uint)(*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5)));
									int instruction_55 = *(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4;
									*(long*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_3 |= num15 << (int)(uint)instruction_55;
									*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_5 += 4;
									*(int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_4 += 32;
								}
								int instruction_56 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_26;
								startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_26 = instruction_56 + 3;
								if (startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_22 == 0)
								{
									startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_0 = false;
									break;
								}
								sbyte b3 = ((sbyte*)ptr)[sizeof(sbyte) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_22 - 1)];
								startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_27 = (byte)b3;
							}
							if ((uint)(startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_22 + startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_26) > (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_13)
							{
								startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_0 = false;
								break;
							}
							while (startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_26 != 0)
							{
								sbyte b4 = (sbyte)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_27;
								int instruction_57 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_22;
								startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_22 = instruction_57 + 1;
								((sbyte*)ptr)[sizeof(sbyte) * (int)(uint)instruction_57] = b4;
								int instruction_58 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_26;
								startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_26 = instruction_58 + -1;
							}
							continue;
						}
						IntrinsicFunctions.Implemented.llvm_memcpy_p0_p0_i64((byte*)ptr4 + sizeof(sbyte) * 0, (byte*)ptr + sizeof(sbyte) * 0, (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_8, false);
						IntrinsicFunctions.Implemented.llvm_memset_p0_i64((byte*)ptr4 + sizeof(sbyte) * 0 + (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_8, 0, (uint)(288 - startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_8), false);
						startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_32 = 0;
						startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_33 = 0;
						while ((uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_33 < (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_9)
						{
							int num16 = (((byte)((sbyte*)ptr)[sizeof(sbyte) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_8 + startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_33)] == 1) ? 1 : 0);
							int instruction_59 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_32;
							startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_32 = instruction_59 + num16;
							int instruction_60 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_33;
							startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_33 = instruction_60 + 1;
						}
						if ((uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_32 < 1u || (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_32 > 2u)
						{
							startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_0 = false;
							break;
						}
						if ((byte)((sbyte*)ptr)[sizeof(sbyte) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_8 + (startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_1 - 1))] != 1)
						{
							startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_0 = false;
							break;
						}
						if (startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_32 == 2 && (byte)((sbyte*)ptr)[sizeof(sbyte) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_8 + startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_1)] != 1)
						{
							startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_0 = false;
							break;
						}
						void* instruction_61 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_2;
						bool flag10 = build_decoder_table(startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_8, (byte*)ptr4 + sizeof(sbyte) * 0, instruction_61);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag10)
						{
							startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_0 = false;
							break;
						}
						startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_34 = 0;
						while ((uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_34 < 4096u)
						{
							int num17 = ((int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_34];
							startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_35 = num17 & 0x1FF;
							if ((uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_35 < 256u)
							{
								int num18 = ((int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_34];
								startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_36 = (num18 >>> 9) & 0xF;
								if (startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_36 != 0)
								{
									if ((uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_36 <= 12u)
									{
										bool flag11 = true;
									}
									else
									{
										IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_nlshwsc, GlobalVariablePointers.String_uxbkrtb, 2089);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										bool flag11 = false;
									}
									int instruction_62 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_36;
									startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_37 = 12 - instruction_62;
									if ((uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_37 >= (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_21)
									{
										int instruction_63 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_34;
										int instruction_64 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_36;
										startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_38 = instruction_63 >>> instruction_64;
										int num19 = ((int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_38];
										startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_39 = num19 & 0x1FF;
										int num20 = ((int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_38];
										startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_40 = (num20 >>> 9) & 0xF;
										if (startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_40 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_37 >= (uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_40)
										{
											int num21 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_39 << 16;
											int instruction_65 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_40;
											((int*)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_34] |= num21 | (instruction_65 << 25);
										}
									}
								}
							}
							int instruction_66 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_34;
							startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_34 = instruction_66 + 1;
						}
						startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_0 = true;
						break;
					}
					break;
				}
			}
			goto IL_27da;
		}
		IL_27da:
		bool instruction_67 = startFrame.GetLocalsRef<LocalVariables_prepare_dynamic_block>().Instruction_0;
		StackFrameList.Current.Clear(startFrame);
		return instruction_67;
	}

	[MangledName("?build_decoder_table@fpng@@YA_NIPEAEPEAI@Z")]
	[DemangledName("bool __cdecl fpng::build_decoder_table(unsigned int, unsigned char *, unsigned int *)")]
	public unsafe static bool build_decoder_table(int P_0, void* P_1, void* P_2)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables_build_decoder_table>();
		InlineArray_16_vqkfj7a* ptr = &startFrame.GetLocalsPointer<LocalVariables_build_decoder_table>()->Instruction_4;
		InlineArray_17_vqkfj7a* ptr2 = &startFrame.GetLocalsPointer<LocalVariables_build_decoder_table>()->Instruction_6;
		InlineArray_288_vqkfj7a* ptr3 = &startFrame.GetLocalsPointer<LocalVariables_build_decoder_table>()->Instruction_11;
		startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_1 = P_2;
		startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_2 = P_1;
		startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_3 = P_0;
		unchecked
		{
			IntrinsicFunctions.Implemented.llvm_memset_p0_i64((byte*)ptr + sizeof(int) * 0, 0, 64L, false);
			startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_5 = 0;
			while ((uint)startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_5 < (uint)startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_3)
			{
				if ((uint)(byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_5] <= 4096u)
				{
					bool flag = true;
				}
				else
				{
					IntrinsicFunctions.Implemented.wassert(GlobalVariablePointers.String_32otbnd, GlobalVariablePointers.String_uxbkrtb, 1843);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					bool flag = false;
				}
				(*(int*)((byte*)ptr + sizeof(int) * (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_5]))++;
				int instruction_ = startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_5;
				startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_5 = instruction_ + 1;
			}
			*(int*)((byte*)ptr2 + sizeof(int) * 1) = 0;
			*(int*)((byte*)ptr2 + sizeof(int) * 0) = 0;
			startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_7 = 0;
			startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_8 = 1;
			while ((uint)startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_8 <= 15u)
			{
				int num = startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_7 + *(int*)((byte*)ptr + sizeof(int) * (int)(uint)startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_8) << 1;
				startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_7 = num;
				*(int*)((byte*)ptr2 + sizeof(int) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_8 + 1)) = num;
				int instruction_2 = startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_8;
				startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_8 = instruction_2 + 1;
			}
			if (startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_7 != 65536)
			{
				startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_9 = 0;
				startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_10 = 15;
				while (startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_10 != 0)
				{
					int num2 = *(int*)((byte*)ptr + sizeof(int) * (int)(uint)startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_10);
					int num3 = startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_9 + num2;
					startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_9 = num3;
					if ((uint)num3 <= 1u)
					{
						int instruction_3 = startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_10;
						startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_10 = instruction_3 + -1;
						continue;
					}
					goto IL_03bb;
				}
				if (startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_9 != 1)
				{
					startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_0 = false;
					goto IL_0822;
				}
			}
			startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_12 = 0;
			while ((uint)startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_12 < (uint)startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_3)
			{
				int num4 = (*(int*)((byte*)ptr2 + sizeof(int) * (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_12]))++;
				*(int*)((byte*)ptr3 + sizeof(int) * (int)(uint)startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_12) = num4;
				int instruction_4 = startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_12;
				startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_12 = instruction_4 + 1;
			}
			IntrinsicFunctions.Implemented.llvm_memset_p0_i64(startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_1, 0, 16384L, false);
			startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_13 = 0;
			while ((uint)startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_13 < (uint)startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_3)
			{
				sbyte b = ((sbyte*)startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_13];
				startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_14 = (byte)b;
				if (startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_14 != 0)
				{
					int instruction_5 = *(int*)((byte*)ptr3 + sizeof(int) * (int)(uint)startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_13);
					startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_15 = instruction_5;
					startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_16 = 0;
					int instruction_6 = startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_14;
					startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_17 = instruction_6;
					while (startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_17 != 0)
					{
						int num5 = startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_16 << 1;
						int instruction_7 = startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_15;
						startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_16 = num5 | (instruction_7 & 1);
						int instruction_8 = startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_15;
						startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_15 = instruction_8 >>> 1;
						int instruction_9 = startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_17;
						startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_17 = instruction_9 + -1;
					}
					int instruction_10 = startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_14;
					startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_18 = 1 << instruction_10;
					while ((uint)startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_16 < 4096u)
					{
						int instruction_11 = startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_13;
						int instruction_12 = startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_14;
						((int*)startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_1)[(uint)startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_16] = instruction_11 | (instruction_12 << 9);
						int instruction_13 = startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_18;
						int instruction_14 = startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_16;
						startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_16 = instruction_14 + instruction_13;
					}
				}
				int instruction_15 = startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_13;
				startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_13 = instruction_15 + 1;
			}
			startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_0 = true;
			goto IL_0822;
		}
		IL_03bb:
		startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_0 = false;
		goto IL_0822;
		IL_0822:
		bool instruction_16 = startFrame.GetLocalsRef<LocalVariables_build_decoder_table>().Instruction_0;
		StackFrameList.Current.Clear(startFrame);
		return instruction_16;
	}
}
