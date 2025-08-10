using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?pixel_deflate_dyn_3_rle@fpng@@YAIPEBEIIPEAEI@Z")]
[DemangledName("unsigned int __cdecl fpng::pixel_deflate_dyn_3_rle(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int)")]
internal static partial class pixel_deflate_dyn_3_rle
{
	private partial struct LocalVariables
	{
		public int Instruction_0;

		public int Instruction_1;

		public unsafe void* Instruction_2;

		public int Instruction_3;

		public int Instruction_4;

		public unsafe void* Instruction_5;

		public int Instruction_6;

		public long Instruction_7;

		public int Instruction_8;

		public int Instruction_9;

		public int Instruction_10;

		public int Instruction_11;

		public int Instruction_12;

		public int Instruction_13;

		public int Instruction_14;

		public int Instruction_15;

		public std_vector_0 Instruction_16;

		public std_allocator_2 Instruction_17;

		public unsafe void* Instruction_18;

		public InlineArray_288_vqkfj7a Instruction_19;

		public unsafe void* Instruction_20;

		public int Instruction_21;

		public int Instruction_22;

		public int Instruction_23;

		public int Instruction_24;

		public int Instruction_25;

		public int Instruction_26;

		public int Instruction_27;

		public int Instruction_28;

		public int Instruction_29;

		public int Instruction_30;

		public int Instruction_31;

		public int Instruction_32;

		public int Instruction_33;

		public fpng_defl_huff Instruction_34;

		public int Instruction_35;

		public int Instruction_36;

		public int Instruction_37;

		public int Instruction_38;

		public int Instruction_39;

		public int Instruction_40;

		public int Instruction_41;

		public int Instruction_42;

		public int Instruction_43;

		public int Instruction_44;

		public int Instruction_45;

		public int Instruction_46;

		public int Instruction_47;

		public int Instruction_48;

		public int Instruction_49;

		public int Instruction_50;

		public int Instruction_51;

		public int Instruction_52;

		public int Instruction_53;

		public int Instruction_54;

		public int Instruction_55;

		public int Instruction_56;

		public int Instruction_57;

		public int Instruction_58;
	}

	public unsafe static int Invoke(void* pImg, int w, int h, void* pDst, int dst_buf_size)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		long* bit_buf = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_7;
		int* bit_buf_size = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_8;
		int* dst_ofs = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_9;
		std_vector_0* ptr = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_16;
		std_allocator_2* ptr2 = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_17;
		InlineArray_288_vqkfj7a* ptr3 = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_19;
		fpng_defl_huff* ptr4 = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_34;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = dst_buf_size;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = pDst;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = h;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_4 = w;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_5 = pImg;
		int instruction_ = startFrame.GetLocalsRef<LocalVariables>().Instruction_4;
		unchecked
		{
			startFrame.GetLocalsRef<LocalVariables>().Instruction_6 = 1 + instruction_ * 3;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = 0L;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = 0;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = 0;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = 120;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_11 = 8;
			if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_11 >= 0u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_11 <= 16u)
			{
				_ = -1;
			}
			else
			{
				wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1002);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				_ = 0;
			}
			if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_11))
			{
				_ = -1;
			}
			else
			{
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1002);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				_ = 0;
			}
			long num = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
			long instruction_2 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_2 | num;
			int instruction_3 = startFrame.GetLocalsRef<LocalVariables>().Instruction_11;
			int instruction_4 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_4 + instruction_3;
			if (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 <= 64)
			{
				_ = -1;
			}
			else
			{
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1002);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				_ = 0;
			}
			startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = 1;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_13 = 8;
			if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_13 >= 0u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_13 <= 16u)
			{
				_ = -1;
			}
			else
			{
				wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1003);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				_ = 0;
			}
			if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_12 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_13))
			{
				_ = -1;
			}
			else
			{
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1003);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				_ = 0;
			}
			long num2 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_12 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
			long instruction_5 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_5 | num2;
			int instruction_6 = startFrame.GetLocalsRef<LocalVariables>().Instruction_13;
			int instruction_7 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_7 + instruction_6;
			if (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 <= 64)
			{
				_ = -1;
			}
			else
			{
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1003);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				_ = 0;
			}
			startFrame.GetLocalsRef<LocalVariables>().Instruction_14 = 1;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_15 = 1;
			if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_15 >= 0u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_15 <= 16u)
			{
				_ = -1;
			}
			else
			{
				wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1006);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				_ = 0;
			}
			if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_14 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_15))
			{
				_ = -1;
			}
			else
			{
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1006);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				_ = 0;
			}
			long num3 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_14 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
			long instruction_8 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_8 | num3;
			int instruction_9 = startFrame.GetLocalsRef<LocalVariables>().Instruction_15;
			int instruction_10 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_10 + instruction_9;
			if (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 <= 64)
			{
				_ = -1;
			}
			else
			{
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1006);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				_ = 0;
			}
			allocator_unsigned_int_Constructor.Invoke(ptr2);
			vector_unsigned_int_class_std_allocator_unsigned_int_Constructor.Invoke(ptr, (uint)((startFrame.GetLocalsRef<LocalVariables>().Instruction_4 + 1) * startFrame.GetLocalsRef<LocalVariables>().Instruction_3), ptr2);
			if (ExceptionInfo.Current != null)
			{
				return 0;
			}
			void* instruction_11 = data_uf9yj3b.Invoke(ptr);
			startFrame.GetLocalsRef<LocalVariables>().Instruction_18 = instruction_11;
			llvm_memset_p0_i64.Invoke((byte*)ptr3 + sizeof(int) * 0, 0, 1152L, isVolatile: false);
			void* instruction_12 = startFrame.GetLocalsRef<LocalVariables>().Instruction_5;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_20 = instruction_12;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_21 = 0;
			int instruction_13 = fpng_adler32.Invoke(size: (uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_6 * startFrame.GetLocalsRef<LocalVariables>().Instruction_3), pData: startFrame.GetLocalsRef<LocalVariables>().Instruction_5, adler: 1);
			if (ExceptionInfo.Current == null)
			{
				startFrame.GetLocalsRef<LocalVariables>().Instruction_22 = instruction_13;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_23 = 2;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_24 = 0;
				while (true)
				{
					if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_24 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_3)
					{
						int instruction_14 = startFrame.GetLocalsRef<LocalVariables>().Instruction_21;
						int instruction_15 = startFrame.GetLocalsRef<LocalVariables>().Instruction_6;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_25 = instruction_14 + instruction_15;
						void* instruction_16 = startFrame.GetLocalsRef<LocalVariables>().Instruction_20;
						int instruction_17 = startFrame.GetLocalsRef<LocalVariables>().Instruction_21;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_21 = instruction_17 + 1;
						sbyte b = ((sbyte*)instruction_16)[(uint)instruction_17];
						startFrame.GetLocalsRef<LocalVariables>().Instruction_26 = (byte)b;
						int num4 = 1 | (startFrame.GetLocalsRef<LocalVariables>().Instruction_26 << 8);
						void* instruction_18 = startFrame.GetLocalsRef<LocalVariables>().Instruction_18;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_18 = (byte*)instruction_18 + 4;
						*(int*)instruction_18 = num4;
						(*(int*)((byte*)ptr3 + sizeof(int) * (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_26))++;
						int instruction_19 = READ_RGB_PIXEL.Invoke((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_20 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_21);
						if (ExceptionInfo.Current != null)
						{
							break;
						}
						startFrame.GetLocalsRef<LocalVariables>().Instruction_28 = instruction_19;
						int num5 = startFrame.GetLocalsRef<LocalVariables>().Instruction_28 << 8;
						void* instruction_20 = startFrame.GetLocalsRef<LocalVariables>().Instruction_18;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_18 = (byte*)instruction_20 + 4;
						*(int*)instruction_20 = num5;
						(*(int*)((byte*)ptr3 + sizeof(int) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_28 & 0xFF)))++;
						(*(int*)((byte*)ptr3 + sizeof(int) * (int)(uint)((startFrame.GetLocalsRef<LocalVariables>().Instruction_28 >>> 8) & 0xFF)))++;
						(*(int*)((byte*)ptr3 + sizeof(int) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_28 >>> 16)))++;
						int instruction_21 = startFrame.GetLocalsRef<LocalVariables>().Instruction_21;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_21 = instruction_21 + 3;
						int instruction_22 = startFrame.GetLocalsRef<LocalVariables>().Instruction_28;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_27 = instruction_22;
						while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_21 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_25)
						{
							int instruction_23 = READ_RGB_PIXEL.Invoke((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_20 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_21);
							if (ExceptionInfo.Current != null)
							{
								goto end_IL_075b;
							}
							startFrame.GetLocalsRef<LocalVariables>().Instruction_29 = instruction_23;
							if (startFrame.GetLocalsRef<LocalVariables>().Instruction_29 == startFrame.GetLocalsRef<LocalVariables>().Instruction_27)
							{
								startFrame.GetLocalsRef<LocalVariables>().Instruction_30 = 3;
								int instruction_24 = minimum_ymfg3kb.Invoke(255, startFrame.GetLocalsRef<LocalVariables>().Instruction_25 - startFrame.GetLocalsRef<LocalVariables>().Instruction_21);
								if (ExceptionInfo.Current != null)
								{
									goto end_IL_075b;
								}
								startFrame.GetLocalsRef<LocalVariables>().Instruction_31 = instruction_24;
								while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_30 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_31)
								{
									int num6 = READ_RGB_PIXEL.Invoke((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_20 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_21 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_30);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_075b;
									}
									if (num6 != startFrame.GetLocalsRef<LocalVariables>().Instruction_29)
									{
										break;
									}
									int instruction_25 = startFrame.GetLocalsRef<LocalVariables>().Instruction_30;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_30 = instruction_25 + 3;
								}
								int num7 = startFrame.GetLocalsRef<LocalVariables>().Instruction_30 - 1;
								void* instruction_26 = startFrame.GetLocalsRef<LocalVariables>().Instruction_18;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_18 = (byte*)instruction_26 + 4;
								*(int*)instruction_26 = num7;
								int instruction_27 = startFrame.GetLocalsRef<LocalVariables>().Instruction_30;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_32 = instruction_27 - 3;
								int instruction_28 = startFrame.GetLocalsRef<LocalVariables>().Instruction_32;
								(*(int*)((byte*)ptr3 + sizeof(int) * (ushort)(*(short*)((byte*)g_defl_len_sym.__pointer + sizeof(short) * (int)(uint)instruction_28))))++;
								int instruction_29 = startFrame.GetLocalsRef<LocalVariables>().Instruction_30;
								int instruction_30 = startFrame.GetLocalsRef<LocalVariables>().Instruction_21;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_21 = instruction_30 + instruction_29;
							}
							else
							{
								int num8 = startFrame.GetLocalsRef<LocalVariables>().Instruction_29 << 8;
								void* instruction_31 = startFrame.GetLocalsRef<LocalVariables>().Instruction_18;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_18 = (byte*)instruction_31 + 4;
								*(int*)instruction_31 = num8;
								(*(int*)((byte*)ptr3 + sizeof(int) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_29 & 0xFF)))++;
								(*(int*)((byte*)ptr3 + sizeof(int) * (int)(uint)((startFrame.GetLocalsRef<LocalVariables>().Instruction_29 >>> 8) & 0xFF)))++;
								(*(int*)((byte*)ptr3 + sizeof(int) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_29 >>> 16)))++;
								int instruction_32 = startFrame.GetLocalsRef<LocalVariables>().Instruction_29;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_27 = instruction_32;
								int instruction_33 = startFrame.GetLocalsRef<LocalVariables>().Instruction_21;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_21 = instruction_33 + 3;
							}
						}
						int instruction_34 = startFrame.GetLocalsRef<LocalVariables>().Instruction_24;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_24 = instruction_34 + 1;
						continue;
					}
					if (startFrame.GetLocalsRef<LocalVariables>().Instruction_21 == startFrame.GetLocalsRef<LocalVariables>().Instruction_3 * startFrame.GetLocalsRef<LocalVariables>().Instruction_6)
					{
						_ = -1;
					}
					else
					{
						wassert.Invoke(String_bjvsuxc.__pointer, String_uxbkrtb.__pointer, 1086);
						if (ExceptionInfo.Current != null)
						{
							break;
						}
						_ = 0;
					}
					long num9 = ((long)startFrame.GetLocalsRef<LocalVariables>().Instruction_18 - (long)data_uf9yj3b.Invoke(ptr)) / 4L;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_33 = (int)num9;
					if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_33 <= (ulong)size_wtrvsgc.Invoke(ptr))
					{
						_ = -1;
					}
					else
					{
						wassert.Invoke(String_hsgehfc.__pointer, String_uxbkrtb.__pointer, 1088);
						if (ExceptionInfo.Current != null)
						{
							break;
						}
						_ = 0;
					}
					*(int*)((byte*)ptr3 + sizeof(int) * 256) = 1;
					adjust_freq32.Invoke(288, (byte*)ptr3 + sizeof(int) * 0, (byte*)(&ptr4->field_0) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * 0);
					if (ExceptionInfo.Current != null)
					{
						break;
					}
					llvm_memset_p0_i64.Invoke((byte*)(&ptr4->field_0) + sizeof(InlineArray_288_oeds4ea) * 1 + sizeof(short) * 0, 0, 64L, isVolatile: false);
					*(short*)((byte*)(&ptr4->field_0) + sizeof(InlineArray_288_oeds4ea) * 1 + sizeof(short) * 2) = 1;
					*(short*)((byte*)(&ptr4->field_0) + sizeof(InlineArray_288_oeds4ea) * 1 + sizeof(short) * 3) = 1;
					bool flag = defl_start_dynamic_block.Invoke(dst_buf_size: startFrame.GetLocalsRef<LocalVariables>().Instruction_1, d: ptr4, pDst: startFrame.GetLocalsRef<LocalVariables>().Instruction_2, dst_ofs: dst_ofs, bit_buf: bit_buf, bit_buf_size: bit_buf_size);
					if (ExceptionInfo.Current != null)
					{
						break;
					}
					if (!flag)
					{
						startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 0;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_35 = 1;
					}
					else
					{
						if (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 <= 7)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_vpte4cc.__pointer, String_uxbkrtb.__pointer, 1103);
							if (ExceptionInfo.Current != null)
							{
								break;
							}
							_ = 0;
						}
						if ((ushort)(*(short*)((byte*)(&ptr4->field_1) + sizeof(InlineArray_288_oeds4ea) * 1 + sizeof(short) * 2)) == 0 && ((byte*)(&ptr4->field_2) + sizeof(InlineArray_288_w3otm9c) * 1)[sizeof(sbyte) * 2] == 1)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_df5ko9b.__pointer, String_uxbkrtb.__pointer, 1104);
							if (ExceptionInfo.Current != null)
							{
								break;
							}
							_ = 0;
						}
						startFrame.GetLocalsRef<LocalVariables>().Instruction_36 = 0;
						while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_36 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_33)
						{
							int instruction_35 = *(int*)Index_2nyjhmb.Invoke(ptr, (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_36);
							startFrame.GetLocalsRef<LocalVariables>().Instruction_37 = instruction_35;
							int instruction_36 = startFrame.GetLocalsRef<LocalVariables>().Instruction_37;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_38 = instruction_36 & 0xFF;
							if (startFrame.GetLocalsRef<LocalVariables>().Instruction_38 == 0)
							{
								int instruction_37 = startFrame.GetLocalsRef<LocalVariables>().Instruction_37;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_39 = instruction_37 >>> 8;
								short num10 = *(short*)((byte*)(&ptr4->field_1) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_39 & 0xFF));
								startFrame.GetLocalsRef<LocalVariables>().Instruction_40 = (ushort)num10;
								sbyte b2 = (sbyte)((byte*)(&ptr4->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_39 & 0xFF)];
								startFrame.GetLocalsRef<LocalVariables>().Instruction_41 = (byte)b2;
								if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_41 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_41 <= 16u)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1115);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_075b;
									}
									_ = 0;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_40 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_41))
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1115);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_075b;
									}
									_ = 0;
								}
								long num11 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_40 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
								long instruction_38 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_38 | num11;
								int instruction_39 = startFrame.GetLocalsRef<LocalVariables>().Instruction_41;
								int instruction_40 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_40 + instruction_39;
								if (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 <= 64)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1115);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_075b;
									}
									_ = 0;
								}
								int instruction_41 = startFrame.GetLocalsRef<LocalVariables>().Instruction_39;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_39 = instruction_41 >>> 8;
								short num12 = *(short*)((byte*)(&ptr4->field_1) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_39 & 0xFF));
								startFrame.GetLocalsRef<LocalVariables>().Instruction_42 = (ushort)num12;
								sbyte b3 = (sbyte)((byte*)(&ptr4->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_39 & 0xFF)];
								startFrame.GetLocalsRef<LocalVariables>().Instruction_43 = (byte)b3;
								if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_43 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_43 <= 16u)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1118);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_075b;
									}
									_ = 0;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_42 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_43))
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1118);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_075b;
									}
									_ = 0;
								}
								long num13 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_42 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
								long instruction_42 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_42 | num13;
								int instruction_43 = startFrame.GetLocalsRef<LocalVariables>().Instruction_43;
								int instruction_44 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_44 + instruction_43;
								if (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 <= 64)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1118);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_075b;
									}
									_ = 0;
								}
								int instruction_45 = startFrame.GetLocalsRef<LocalVariables>().Instruction_39;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_39 = instruction_45 >>> 8;
								short num14 = *(short*)((byte*)(&ptr4->field_1) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_39);
								startFrame.GetLocalsRef<LocalVariables>().Instruction_44 = (ushort)num14;
								sbyte b4 = (sbyte)((byte*)(&ptr4->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_39];
								startFrame.GetLocalsRef<LocalVariables>().Instruction_45 = (byte)b4;
								if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_45 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_45 <= 16u)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1121);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_075b;
									}
									_ = 0;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_44 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_45))
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1121);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_075b;
									}
									_ = 0;
								}
								long num15 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_44 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
								long instruction_46 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_46 | num15;
								int instruction_47 = startFrame.GetLocalsRef<LocalVariables>().Instruction_45;
								int instruction_48 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_48 + instruction_47;
								if (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 <= 64)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1121);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_075b;
									}
									_ = 0;
								}
							}
							else if (startFrame.GetLocalsRef<LocalVariables>().Instruction_38 == 1)
							{
								int instruction_49 = startFrame.GetLocalsRef<LocalVariables>().Instruction_37;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_46 = instruction_49 >>> 8;
								short num16 = *(short*)((byte*)(&ptr4->field_1) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_46);
								startFrame.GetLocalsRef<LocalVariables>().Instruction_47 = (ushort)num16;
								sbyte b5 = (sbyte)((byte*)(&ptr4->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_46];
								startFrame.GetLocalsRef<LocalVariables>().Instruction_48 = (byte)b5;
								if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_48 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_48 <= 16u)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1126);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_075b;
									}
									_ = 0;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_47 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_48))
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1126);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_075b;
									}
									_ = 0;
								}
								long num17 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_47 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
								long instruction_50 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_50 | num17;
								int instruction_51 = startFrame.GetLocalsRef<LocalVariables>().Instruction_48;
								int instruction_52 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_52 + instruction_51;
								if (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 <= 64)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1126);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_075b;
									}
									_ = 0;
								}
							}
							else
							{
								int instruction_53 = startFrame.GetLocalsRef<LocalVariables>().Instruction_38;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_49 = instruction_53 + 1;
								int instruction_54 = startFrame.GetLocalsRef<LocalVariables>().Instruction_49;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_50 = instruction_54 - 3;
								InlineArray_288_oeds4ea* ptr5 = (InlineArray_288_oeds4ea*)((byte*)(&ptr4->field_1) + sizeof(InlineArray_288_oeds4ea) * 0);
								int instruction_55 = startFrame.GetLocalsRef<LocalVariables>().Instruction_50;
								short num18 = *(short*)((byte*)ptr5 + sizeof(short) * (ushort)(*(short*)((byte*)g_defl_len_sym.__pointer + sizeof(short) * (int)(uint)instruction_55)));
								startFrame.GetLocalsRef<LocalVariables>().Instruction_51 = (ushort)num18;
								InlineArray_288_w3otm9c* ptr6 = (InlineArray_288_w3otm9c*)((byte*)(&ptr4->field_2) + sizeof(InlineArray_288_w3otm9c) * 0);
								int instruction_56 = startFrame.GetLocalsRef<LocalVariables>().Instruction_50;
								sbyte b6 = ((sbyte*)ptr6)[sizeof(sbyte) * (ushort)(*(short*)((byte*)g_defl_len_sym.__pointer + sizeof(short) * (int)(uint)instruction_56))];
								startFrame.GetLocalsRef<LocalVariables>().Instruction_52 = (byte)b6;
								if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_52 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_52 <= 16u)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1134);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_075b;
									}
									_ = 0;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_51 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_52))
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1134);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_075b;
									}
									_ = 0;
								}
								long num19 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_51 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
								long instruction_57 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_57 | num19;
								int instruction_58 = startFrame.GetLocalsRef<LocalVariables>().Instruction_52;
								int instruction_59 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_59 + instruction_58;
								if (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 <= 64)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1134);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_075b;
									}
									_ = 0;
								}
								int instruction_60 = startFrame.GetLocalsRef<LocalVariables>().Instruction_50;
								int instruction_61 = startFrame.GetLocalsRef<LocalVariables>().Instruction_50;
								sbyte b7 = ((sbyte*)g_defl_len_extra.__pointer)[sizeof(sbyte) * (int)(uint)instruction_61];
								int num20 = *(int*)((byte*)g_bitmasks.__pointer + sizeof(int) * (byte)b7);
								startFrame.GetLocalsRef<LocalVariables>().Instruction_53 = instruction_60 & num20;
								int instruction_62 = startFrame.GetLocalsRef<LocalVariables>().Instruction_50;
								checked
								{
									int instruction_63 = unchecked((byte)((sbyte*)g_defl_len_extra.__pointer)[sizeof(sbyte) * (int)(uint)instruction_62]) + 1;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_54 = instruction_63;
								}
								if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_54 >= 0u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_54 <= 16u)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1135);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_075b;
									}
									_ = 0;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_53 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_54))
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1135);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_075b;
									}
									_ = 0;
								}
								long num21 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_53 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
								long instruction_64 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_64 | num21;
								int instruction_65 = startFrame.GetLocalsRef<LocalVariables>().Instruction_54;
								int instruction_66 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_66 + instruction_65;
								if (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 <= 64)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1135);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_075b;
									}
									_ = 0;
								}
							}
							if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_9 + 8) <= (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)
							{
								long instruction_67 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
								*(long*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9) = instruction_67;
								int instruction_68 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_55 = instruction_68 & -8;
								int num22 = startFrame.GetLocalsRef<LocalVariables>().Instruction_55 >>> 3;
								int instruction_69 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_69 + num22;
								if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_55 < 64u)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1142);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_075b;
									}
									_ = 0;
								}
								long instruction_70 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
								int instruction_71 = startFrame.GetLocalsRef<LocalVariables>().Instruction_55;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_70 >>> (int)(uint)instruction_71;
								int instruction_72 = startFrame.GetLocalsRef<LocalVariables>().Instruction_55;
								int instruction_73 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_73 - instruction_72;
								int instruction_74 = startFrame.GetLocalsRef<LocalVariables>().Instruction_36;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_36 = instruction_74 + 1;
								continue;
							}
							goto IL_263d;
						}
						short num23 = *(short*)((byte*)(&ptr4->field_1) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * 256);
						startFrame.GetLocalsRef<LocalVariables>().Instruction_56 = (ushort)num23;
						sbyte b8 = (sbyte)((byte*)(&ptr4->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * 256];
						startFrame.GetLocalsRef<LocalVariables>().Instruction_57 = (byte)b8;
						if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_57 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_57 <= 16u)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1145);
							if (ExceptionInfo.Current != null)
							{
								break;
							}
							_ = 0;
						}
						if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_56 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_57))
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1145);
							if (ExceptionInfo.Current != null)
							{
								break;
							}
							_ = 0;
						}
						long num24 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_56 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
						long instruction_75 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_75 | num24;
						int instruction_76 = startFrame.GetLocalsRef<LocalVariables>().Instruction_57;
						int instruction_77 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_77 + instruction_76;
						if (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 <= 64)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1145);
							if (ExceptionInfo.Current != null)
							{
								break;
							}
							_ = 0;
						}
						while (true)
						{
							if (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 > 0)
							{
								if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_9 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)
								{
									startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 0;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_35 = 1;
									break;
								}
								long instruction_78 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
								((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9] = (sbyte)instruction_78;
								int instruction_79 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_79 + 1;
								long instruction_80 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_80 >>> 8;
								int instruction_81 = checked(startFrame.GetLocalsRef<LocalVariables>().Instruction_8 - 8);
								startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_81;
								continue;
							}
							startFrame.GetLocalsRef<LocalVariables>().Instruction_58 = 0;
							while (true)
							{
								if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_58 < 4u)
								{
									if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_9 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)
									{
										startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 0;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_35 = 1;
										break;
									}
									int instruction_82 = startFrame.GetLocalsRef<LocalVariables>().Instruction_22;
									((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9] = (sbyte)(instruction_82 >>> 24);
									int instruction_83 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_83 + 1;
									int instruction_84 = startFrame.GetLocalsRef<LocalVariables>().Instruction_22;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_22 = instruction_84 << 8;
									int instruction_85 = startFrame.GetLocalsRef<LocalVariables>().Instruction_58;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_58 = instruction_85 + 1;
									continue;
								}
								int instruction_86 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = instruction_86;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_35 = 1;
								break;
							}
							break;
						}
					}
					goto IL_2e10;
					IL_2e10:
					vector_unsigned_int_class_std_allocator_unsigned_int_Destructor.Invoke(ptr);
					int instruction_87 = startFrame.GetLocalsRef<LocalVariables>().Instruction_0;
					StackFrameList.Current.Clear(startFrame);
					return instruction_87;
					IL_263d:
					startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 0;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_35 = 1;
					goto IL_2e10;
					continue;
					end_IL_075b:
					break;
				}
			}
			ExceptionInfo current = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			vector_unsigned_int_class_std_allocator_unsigned_int_Destructor.Invoke(ptr);
			ExceptionInfo.Current = current;
			return 0;
		}
	}
}
