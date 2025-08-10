using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?pixel_deflate_dyn_4_rle@fpng@@YAIPEBEIIPEAEI@Z")]
[DemangledName("unsigned int __cdecl fpng::pixel_deflate_dyn_4_rle(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int)")]
internal static partial class pixel_deflate_dyn_4_rle
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

		public std_vector_5 Instruction_16;

		public unsafe void* Instruction_17;

		public InlineArray_288_vqkfj7a Instruction_18;

		public unsafe void* Instruction_19;

		public int Instruction_20;

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

		public fpng_defl_huff Instruction_33;

		public int Instruction_34;

		public int Instruction_35;

		public long Instruction_36;

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

		public int Instruction_59;

		public int Instruction_60;
	}

	public unsafe static int Invoke(void* pImg, int w, int h, void* pDst, int dst_buf_size)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		long* bit_buf = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_7;
		int* bit_buf_size = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_8;
		int* dst_ofs = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_9;
		std_vector_5* ptr = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_16;
		InlineArray_288_vqkfj7a* ptr2 = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_18;
		fpng_defl_huff* ptr3 = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_33;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = dst_buf_size;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = pDst;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = h;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_4 = w;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_5 = pImg;
		int instruction_ = startFrame.GetLocalsRef<LocalVariables>().Instruction_4;
		unchecked
		{
			startFrame.GetLocalsRef<LocalVariables>().Instruction_6 = 1 + instruction_ * 4;
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
				wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1279);
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
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1279);
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
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1279);
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
				wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1280);
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
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1280);
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
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1280);
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
				wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1283);
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
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1283);
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
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1283);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				_ = 0;
			}
			vector_unsigned_int64_class_std_allocator_unsigned_int64_Constructor.Invoke(ptr);
			resize_d4pmvud.Invoke(ptr, (uint)((startFrame.GetLocalsRef<LocalVariables>().Instruction_4 + 1) * startFrame.GetLocalsRef<LocalVariables>().Instruction_3));
			if (ExceptionInfo.Current == null)
			{
				void* instruction_11 = data_dtgl25a.Invoke(ptr);
				startFrame.GetLocalsRef<LocalVariables>().Instruction_17 = instruction_11;
				llvm_memset_p0_i64.Invoke((byte*)ptr2 + sizeof(int) * 0, 0, 1152L, isVolatile: false);
				void* instruction_12 = startFrame.GetLocalsRef<LocalVariables>().Instruction_5;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_19 = instruction_12;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_20 = 0;
				int instruction_13 = fpng_adler32.Invoke(size: (uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_6 * startFrame.GetLocalsRef<LocalVariables>().Instruction_3), pData: startFrame.GetLocalsRef<LocalVariables>().Instruction_5, adler: 1);
				if (ExceptionInfo.Current == null)
				{
					startFrame.GetLocalsRef<LocalVariables>().Instruction_21 = instruction_13;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_22 = 3;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_23 = 0;
					while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_3)
					{
						int instruction_14 = startFrame.GetLocalsRef<LocalVariables>().Instruction_20;
						int instruction_15 = startFrame.GetLocalsRef<LocalVariables>().Instruction_6;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_24 = instruction_14 + instruction_15;
						void* instruction_16 = startFrame.GetLocalsRef<LocalVariables>().Instruction_19;
						int instruction_17 = startFrame.GetLocalsRef<LocalVariables>().Instruction_20;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_20 = instruction_17 + 1;
						sbyte b = ((sbyte*)instruction_16)[(uint)instruction_17];
						startFrame.GetLocalsRef<LocalVariables>().Instruction_25 = (byte)b;
						long num4 = (uint)(1 | (startFrame.GetLocalsRef<LocalVariables>().Instruction_25 << 8));
						void* instruction_18 = startFrame.GetLocalsRef<LocalVariables>().Instruction_17;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_17 = (byte*)instruction_18 + 8;
						*(long*)instruction_18 = num4;
						(*(int*)((byte*)ptr2 + sizeof(int) * (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_25))++;
						int instruction_19 = *(int*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_19 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_20);
						startFrame.GetLocalsRef<LocalVariables>().Instruction_27 = instruction_19;
						long num5 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_27 << 8);
						void* instruction_20 = startFrame.GetLocalsRef<LocalVariables>().Instruction_17;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_17 = (byte*)instruction_20 + 8;
						*(long*)instruction_20 = num5;
						(*(int*)((byte*)ptr2 + sizeof(int) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_27 & 0xFF)))++;
						(*(int*)((byte*)ptr2 + sizeof(int) * (int)(uint)((startFrame.GetLocalsRef<LocalVariables>().Instruction_27 >>> 8) & 0xFF)))++;
						(*(int*)((byte*)ptr2 + sizeof(int) * (int)(uint)((startFrame.GetLocalsRef<LocalVariables>().Instruction_27 >>> 16) & 0xFF)))++;
						(*(int*)((byte*)ptr2 + sizeof(int) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_27 >>> 24)))++;
						int instruction_21 = startFrame.GetLocalsRef<LocalVariables>().Instruction_20;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_20 = instruction_21 + 4;
						int instruction_22 = startFrame.GetLocalsRef<LocalVariables>().Instruction_27;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_26 = instruction_22;
						while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_20 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_24)
						{
							int instruction_23 = *(int*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_19 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_20);
							startFrame.GetLocalsRef<LocalVariables>().Instruction_28 = instruction_23;
							if (startFrame.GetLocalsRef<LocalVariables>().Instruction_28 == startFrame.GetLocalsRef<LocalVariables>().Instruction_26)
							{
								startFrame.GetLocalsRef<LocalVariables>().Instruction_29 = 4;
								int instruction_24 = minimum_ymfg3kb.Invoke(252, startFrame.GetLocalsRef<LocalVariables>().Instruction_24 - startFrame.GetLocalsRef<LocalVariables>().Instruction_20);
								startFrame.GetLocalsRef<LocalVariables>().Instruction_30 = instruction_24;
								while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_29 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_30 && *(int*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_19 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_20 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_29) == startFrame.GetLocalsRef<LocalVariables>().Instruction_28)
								{
									int instruction_25 = startFrame.GetLocalsRef<LocalVariables>().Instruction_29;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_29 = instruction_25 + 4;
								}
								long num6 = (uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_29 - 1);
								void* instruction_26 = startFrame.GetLocalsRef<LocalVariables>().Instruction_17;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_17 = (byte*)instruction_26 + 8;
								*(long*)instruction_26 = num6;
								int instruction_27 = startFrame.GetLocalsRef<LocalVariables>().Instruction_29;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_31 = instruction_27 - 3;
								int instruction_28 = startFrame.GetLocalsRef<LocalVariables>().Instruction_31;
								(*(int*)((byte*)ptr2 + sizeof(int) * (ushort)(*(short*)((byte*)g_defl_len_sym.__pointer + sizeof(short) * (int)(uint)instruction_28))))++;
								int instruction_29 = startFrame.GetLocalsRef<LocalVariables>().Instruction_29;
								int instruction_30 = startFrame.GetLocalsRef<LocalVariables>().Instruction_20;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_20 = instruction_30 + instruction_29;
							}
							else
							{
								long num7 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_28 << 8);
								void* instruction_31 = startFrame.GetLocalsRef<LocalVariables>().Instruction_17;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_17 = (byte*)instruction_31 + 8;
								*(long*)instruction_31 = num7;
								(*(int*)((byte*)ptr2 + sizeof(int) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_28 & 0xFF)))++;
								(*(int*)((byte*)ptr2 + sizeof(int) * (int)(uint)((startFrame.GetLocalsRef<LocalVariables>().Instruction_28 >>> 8) & 0xFF)))++;
								(*(int*)((byte*)ptr2 + sizeof(int) * (int)(uint)((startFrame.GetLocalsRef<LocalVariables>().Instruction_28 >>> 16) & 0xFF)))++;
								(*(int*)((byte*)ptr2 + sizeof(int) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_28 >>> 24)))++;
								int instruction_32 = startFrame.GetLocalsRef<LocalVariables>().Instruction_28;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_26 = instruction_32;
								int instruction_33 = startFrame.GetLocalsRef<LocalVariables>().Instruction_20;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_20 = instruction_33 + 4;
							}
						}
						int instruction_34 = startFrame.GetLocalsRef<LocalVariables>().Instruction_23;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_23 = instruction_34 + 1;
					}
					if (startFrame.GetLocalsRef<LocalVariables>().Instruction_20 == startFrame.GetLocalsRef<LocalVariables>().Instruction_3 * startFrame.GetLocalsRef<LocalVariables>().Instruction_6)
					{
						_ = -1;
					}
					else
					{
						wassert.Invoke(String_bjvsuxc.__pointer, String_uxbkrtb.__pointer, 1365);
						if (ExceptionInfo.Current != null)
						{
							goto IL_3462;
						}
						_ = 0;
					}
					long num8 = ((long)startFrame.GetLocalsRef<LocalVariables>().Instruction_17 - (long)data_dtgl25a.Invoke(ptr)) / 8L;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_32 = (int)num8;
					if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_32 <= (ulong)size_trt5i3d.Invoke(ptr))
					{
						_ = -1;
					}
					else
					{
						wassert.Invoke(String_hsgehfc.__pointer, String_uxbkrtb.__pointer, 1367);
						if (ExceptionInfo.Current != null)
						{
							goto IL_3462;
						}
						_ = 0;
					}
					*(int*)((byte*)ptr2 + sizeof(int) * 256) = 1;
					adjust_freq32.Invoke(288, (byte*)ptr2 + sizeof(int) * 0, (byte*)(&ptr3->field_0) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * 0);
					if (ExceptionInfo.Current == null)
					{
						llvm_memset_p0_i64.Invoke((byte*)(&ptr3->field_0) + sizeof(InlineArray_288_oeds4ea) * 1 + sizeof(short) * 0, 0, 64L, isVolatile: false);
						*(short*)((byte*)(&ptr3->field_0) + sizeof(InlineArray_288_oeds4ea) * 1 + sizeof(short) * 3) = 1;
						*(short*)((byte*)(&ptr3->field_0) + sizeof(InlineArray_288_oeds4ea) * 1 + sizeof(short) * 4) = 1;
						bool flag = defl_start_dynamic_block.Invoke(dst_buf_size: startFrame.GetLocalsRef<LocalVariables>().Instruction_1, d: ptr3, pDst: startFrame.GetLocalsRef<LocalVariables>().Instruction_2, dst_ofs: dst_ofs, bit_buf: bit_buf, bit_buf_size: bit_buf_size);
						if (ExceptionInfo.Current == null)
						{
							if (!flag)
							{
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 0;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_34 = 1;
							}
							else
							{
								if (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 <= 7)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_vpte4cc.__pointer, String_uxbkrtb.__pointer, 1382);
									if (ExceptionInfo.Current != null)
									{
										goto IL_3462;
									}
									_ = 0;
								}
								if ((ushort)(*(short*)((byte*)(&ptr3->field_1) + sizeof(InlineArray_288_oeds4ea) * 1 + sizeof(short) * 3)) == 0 && ((byte*)(&ptr3->field_2) + sizeof(InlineArray_288_w3otm9c) * 1)[sizeof(sbyte) * 3] == 1)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_df5ko9b.__pointer, String_uxbkrtb.__pointer, 1383);
									if (ExceptionInfo.Current != null)
									{
										goto IL_3462;
									}
									_ = 0;
								}
								startFrame.GetLocalsRef<LocalVariables>().Instruction_35 = 0;
								long instruction_81;
								int instruction_82;
								int instruction_83;
								int instruction_84;
								int instruction_85;
								for (; (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_35 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_32; instruction_81 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7, instruction_82 = startFrame.GetLocalsRef<LocalVariables>().Instruction_57, startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_81 >>> (int)(uint)instruction_82, instruction_83 = startFrame.GetLocalsRef<LocalVariables>().Instruction_57, instruction_84 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8, startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_84 - instruction_83, instruction_85 = startFrame.GetLocalsRef<LocalVariables>().Instruction_35, startFrame.GetLocalsRef<LocalVariables>().Instruction_35 = instruction_85 + 1)
								{
									long instruction_35 = *(long*)Index_7d577ub.Invoke(ptr, (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_35);
									startFrame.GetLocalsRef<LocalVariables>().Instruction_36 = instruction_35;
									long instruction_36 = startFrame.GetLocalsRef<LocalVariables>().Instruction_36;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_37 = (int)(instruction_36 & 0xFFL);
									if (startFrame.GetLocalsRef<LocalVariables>().Instruction_37 == 0)
									{
										long instruction_37 = startFrame.GetLocalsRef<LocalVariables>().Instruction_36;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_38 = (int)(instruction_37 >>> 8);
										short num9 = *(short*)((byte*)(&ptr3->field_1) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_38 & 0xFF));
										startFrame.GetLocalsRef<LocalVariables>().Instruction_39 = (ushort)num9;
										sbyte b2 = (sbyte)((byte*)(&ptr3->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_38 & 0xFF)];
										startFrame.GetLocalsRef<LocalVariables>().Instruction_40 = (byte)b2;
										if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_40 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_40 <= 16u)
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1394);
											if (ExceptionInfo.Current != null)
											{
												goto IL_3462;
											}
											_ = 0;
										}
										if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_39 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_40))
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1394);
											if (ExceptionInfo.Current != null)
											{
												goto IL_3462;
											}
											_ = 0;
										}
										long num10 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_39 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
										long instruction_38 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_38 | num10;
										int instruction_39 = startFrame.GetLocalsRef<LocalVariables>().Instruction_40;
										int instruction_40 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_40 + instruction_39;
										if (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 <= 64)
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1394);
											if (ExceptionInfo.Current != null)
											{
												goto IL_3462;
											}
											_ = 0;
										}
										int instruction_41 = startFrame.GetLocalsRef<LocalVariables>().Instruction_38;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_38 = instruction_41 >>> 8;
										short num11 = *(short*)((byte*)(&ptr3->field_1) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_38 & 0xFF));
										startFrame.GetLocalsRef<LocalVariables>().Instruction_41 = (ushort)num11;
										sbyte b3 = (sbyte)((byte*)(&ptr3->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_38 & 0xFF)];
										startFrame.GetLocalsRef<LocalVariables>().Instruction_42 = (byte)b3;
										if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_42 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_42 <= 16u)
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1397);
											if (ExceptionInfo.Current != null)
											{
												goto IL_3462;
											}
											_ = 0;
										}
										if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_41 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_42))
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1397);
											if (ExceptionInfo.Current != null)
											{
												goto IL_3462;
											}
											_ = 0;
										}
										long num12 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_41 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
										long instruction_42 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_42 | num12;
										int instruction_43 = startFrame.GetLocalsRef<LocalVariables>().Instruction_42;
										int instruction_44 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_44 + instruction_43;
										if (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 <= 64)
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1397);
											if (ExceptionInfo.Current != null)
											{
												goto IL_3462;
											}
											_ = 0;
										}
										int instruction_45 = startFrame.GetLocalsRef<LocalVariables>().Instruction_38;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_38 = instruction_45 >>> 8;
										short num13 = *(short*)((byte*)(&ptr3->field_1) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_38 & 0xFF));
										startFrame.GetLocalsRef<LocalVariables>().Instruction_43 = (ushort)num13;
										sbyte b4 = (sbyte)((byte*)(&ptr3->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_38 & 0xFF)];
										startFrame.GetLocalsRef<LocalVariables>().Instruction_44 = (byte)b4;
										if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_44 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_44 <= 16u)
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1400);
											if (ExceptionInfo.Current != null)
											{
												goto IL_3462;
											}
											_ = 0;
										}
										if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_43 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_44))
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1400);
											if (ExceptionInfo.Current != null)
											{
												goto IL_3462;
											}
											_ = 0;
										}
										long num14 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_43 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
										long instruction_46 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_46 | num14;
										int instruction_47 = startFrame.GetLocalsRef<LocalVariables>().Instruction_44;
										int instruction_48 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_48 + instruction_47;
										if (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 <= 64)
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1400);
											if (ExceptionInfo.Current != null)
											{
												goto IL_3462;
											}
											_ = 0;
										}
										int instruction_49 = startFrame.GetLocalsRef<LocalVariables>().Instruction_38;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_38 = instruction_49 >>> 8;
										if (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 >= 49)
										{
											if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_9 + 8) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)
											{
												goto IL_1dc0;
											}
											long instruction_50 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
											*(long*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9) = instruction_50;
											int instruction_51 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_45 = instruction_51 & -8;
											int num15 = startFrame.GetLocalsRef<LocalVariables>().Instruction_45 >>> 3;
											int instruction_52 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_52 + num15;
											if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_45 < 64u)
											{
												_ = -1;
											}
											else
											{
												wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1405);
												if (ExceptionInfo.Current != null)
												{
													goto IL_3462;
												}
												_ = 0;
											}
											long instruction_53 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
											int instruction_54 = startFrame.GetLocalsRef<LocalVariables>().Instruction_45;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_53 >>> (int)(uint)instruction_54;
											int instruction_55 = startFrame.GetLocalsRef<LocalVariables>().Instruction_45;
											int instruction_56 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_56 - instruction_55;
										}
										short num16 = *(short*)((byte*)(&ptr3->field_1) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_38);
										startFrame.GetLocalsRef<LocalVariables>().Instruction_46 = (ushort)num16;
										sbyte b5 = (sbyte)((byte*)(&ptr3->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_38];
										startFrame.GetLocalsRef<LocalVariables>().Instruction_47 = (byte)b5;
										if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_47 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_47 <= 16u)
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1408);
											if (ExceptionInfo.Current != null)
											{
												goto IL_3462;
											}
											_ = 0;
										}
										if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_46 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_47))
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1408);
											if (ExceptionInfo.Current != null)
											{
												goto IL_3462;
											}
											_ = 0;
										}
										long num17 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_46 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
										long instruction_57 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_57 | num17;
										int instruction_58 = startFrame.GetLocalsRef<LocalVariables>().Instruction_47;
										int instruction_59 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_59 + instruction_58;
										if (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 <= 64)
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1408);
											if (ExceptionInfo.Current != null)
											{
												goto IL_3462;
											}
											_ = 0;
										}
									}
									else if (startFrame.GetLocalsRef<LocalVariables>().Instruction_37 == 1)
									{
										long instruction_60 = startFrame.GetLocalsRef<LocalVariables>().Instruction_36;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_48 = (int)(instruction_60 >>> 8);
										short num18 = *(short*)((byte*)(&ptr3->field_1) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_48);
										startFrame.GetLocalsRef<LocalVariables>().Instruction_49 = (ushort)num18;
										sbyte b6 = (sbyte)((byte*)(&ptr3->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_48];
										startFrame.GetLocalsRef<LocalVariables>().Instruction_50 = (byte)b6;
										if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_50 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_50 <= 16u)
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1413);
											if (ExceptionInfo.Current != null)
											{
												goto IL_3462;
											}
											_ = 0;
										}
										if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_49 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_50))
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1413);
											if (ExceptionInfo.Current != null)
											{
												goto IL_3462;
											}
											_ = 0;
										}
										long num19 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_49 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
										long instruction_61 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_61 | num19;
										int instruction_62 = startFrame.GetLocalsRef<LocalVariables>().Instruction_50;
										int instruction_63 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_63 + instruction_62;
										if (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 <= 64)
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1413);
											if (ExceptionInfo.Current != null)
											{
												goto IL_3462;
											}
											_ = 0;
										}
									}
									else
									{
										int instruction_64 = startFrame.GetLocalsRef<LocalVariables>().Instruction_37;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_51 = instruction_64 + 1;
										int instruction_65 = startFrame.GetLocalsRef<LocalVariables>().Instruction_51;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_52 = instruction_65 - 3;
										InlineArray_288_oeds4ea* ptr4 = (InlineArray_288_oeds4ea*)((byte*)(&ptr3->field_1) + sizeof(InlineArray_288_oeds4ea) * 0);
										int instruction_66 = startFrame.GetLocalsRef<LocalVariables>().Instruction_52;
										short num20 = *(short*)((byte*)ptr4 + sizeof(short) * (ushort)(*(short*)((byte*)g_defl_len_sym.__pointer + sizeof(short) * (int)(uint)instruction_66)));
										startFrame.GetLocalsRef<LocalVariables>().Instruction_53 = (ushort)num20;
										InlineArray_288_w3otm9c* ptr5 = (InlineArray_288_w3otm9c*)((byte*)(&ptr3->field_2) + sizeof(InlineArray_288_w3otm9c) * 0);
										int instruction_67 = startFrame.GetLocalsRef<LocalVariables>().Instruction_52;
										sbyte b7 = ((sbyte*)ptr5)[sizeof(sbyte) * (ushort)(*(short*)((byte*)g_defl_len_sym.__pointer + sizeof(short) * (int)(uint)instruction_67))];
										startFrame.GetLocalsRef<LocalVariables>().Instruction_54 = (byte)b7;
										if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_54 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_54 <= 16u)
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1421);
											if (ExceptionInfo.Current != null)
											{
												goto IL_3462;
											}
											_ = 0;
										}
										if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_53 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_54))
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1421);
											if (ExceptionInfo.Current != null)
											{
												goto IL_3462;
											}
											_ = 0;
										}
										long num21 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_53 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
										long instruction_68 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_68 | num21;
										int instruction_69 = startFrame.GetLocalsRef<LocalVariables>().Instruction_54;
										int instruction_70 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_70 + instruction_69;
										if (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 <= 64)
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1421);
											if (ExceptionInfo.Current != null)
											{
												goto IL_3462;
											}
											_ = 0;
										}
										int instruction_71 = startFrame.GetLocalsRef<LocalVariables>().Instruction_52;
										int instruction_72 = startFrame.GetLocalsRef<LocalVariables>().Instruction_52;
										sbyte b8 = ((sbyte*)g_defl_len_extra.__pointer)[sizeof(sbyte) * (int)(uint)instruction_72];
										int num22 = *(int*)((byte*)g_bitmasks.__pointer + sizeof(int) * (byte)b8);
										startFrame.GetLocalsRef<LocalVariables>().Instruction_55 = instruction_71 & num22;
										int instruction_73 = startFrame.GetLocalsRef<LocalVariables>().Instruction_52;
										checked
										{
											int instruction_74 = unchecked((byte)((sbyte*)g_defl_len_extra.__pointer)[sizeof(sbyte) * (int)(uint)instruction_73]) + 1;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_56 = instruction_74;
										}
										if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_56 >= 0u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_56 <= 16u)
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1422);
											if (ExceptionInfo.Current != null)
											{
												goto IL_3462;
											}
											_ = 0;
										}
										if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_55 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_56))
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1422);
											if (ExceptionInfo.Current != null)
											{
												goto IL_3462;
											}
											_ = 0;
										}
										long num23 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_55 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
										long instruction_75 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_75 | num23;
										int instruction_76 = startFrame.GetLocalsRef<LocalVariables>().Instruction_56;
										int instruction_77 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_77 + instruction_76;
										if (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 <= 64)
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1422);
											if (ExceptionInfo.Current != null)
											{
												goto IL_3462;
											}
											_ = 0;
										}
									}
									if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_9 + 8) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)
									{
										goto IL_2c68;
									}
									long instruction_78 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
									*(long*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9) = instruction_78;
									int instruction_79 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_57 = instruction_79 & -8;
									int num24 = startFrame.GetLocalsRef<LocalVariables>().Instruction_57 >>> 3;
									int instruction_80 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_80 + num24;
									if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_57 < 64u)
									{
										_ = -1;
										continue;
									}
									wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1428);
									if (ExceptionInfo.Current == null)
									{
										_ = 0;
										continue;
									}
									goto IL_3462;
								}
								short num25 = *(short*)((byte*)(&ptr3->field_1) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * 256);
								startFrame.GetLocalsRef<LocalVariables>().Instruction_58 = (ushort)num25;
								sbyte b9 = (sbyte)((byte*)(&ptr3->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * 256];
								startFrame.GetLocalsRef<LocalVariables>().Instruction_59 = (byte)b9;
								if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_59 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_59 <= 16u)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1431);
									if (ExceptionInfo.Current != null)
									{
										goto IL_3462;
									}
									_ = 0;
								}
								if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_58 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_59))
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1431);
									if (ExceptionInfo.Current != null)
									{
										goto IL_3462;
									}
									_ = 0;
								}
								long num26 = (long)((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_58 << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
								long instruction_86 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_86 | num26;
								int instruction_87 = startFrame.GetLocalsRef<LocalVariables>().Instruction_59;
								int instruction_88 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_88 + instruction_87;
								if (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 <= 64)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1431);
									if (ExceptionInfo.Current != null)
									{
										goto IL_3462;
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
											startFrame.GetLocalsRef<LocalVariables>().Instruction_34 = 1;
											break;
										}
										long instruction_89 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
										((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9] = (sbyte)instruction_89;
										int instruction_90 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_90 + 1;
										long instruction_91 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_91 >>> 8;
										int instruction_92 = checked(startFrame.GetLocalsRef<LocalVariables>().Instruction_8 - 8);
										startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_92;
										continue;
									}
									startFrame.GetLocalsRef<LocalVariables>().Instruction_60 = 0;
									while (true)
									{
										if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_60 < 4u)
										{
											if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_9 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)
											{
												startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 0;
												startFrame.GetLocalsRef<LocalVariables>().Instruction_34 = 1;
												break;
											}
											int instruction_93 = startFrame.GetLocalsRef<LocalVariables>().Instruction_21;
											((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9] = (sbyte)(instruction_93 >>> 24);
											int instruction_94 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_94 + 1;
											int instruction_95 = startFrame.GetLocalsRef<LocalVariables>().Instruction_21;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_21 = instruction_95 << 8;
											int instruction_96 = startFrame.GetLocalsRef<LocalVariables>().Instruction_60;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_60 = instruction_96 + 1;
											continue;
										}
										int instruction_97 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = instruction_97;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_34 = 1;
										break;
									}
									break;
								}
							}
							goto IL_343b;
						}
					}
				}
			}
			goto IL_3462;
		}
		IL_2c68:
		startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 0;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_34 = 1;
		goto IL_343b;
		IL_1dc0:
		startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 0;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_34 = 1;
		goto IL_343b;
		IL_343b:
		vector_unsigned_int64_class_std_allocator_unsigned_int64_Destructor.Invoke(ptr);
		int instruction_98 = startFrame.GetLocalsRef<LocalVariables>().Instruction_0;
		StackFrameList.Current.Clear(startFrame);
		return instruction_98;
		IL_3462:
		ExceptionInfo current = ExceptionInfo.Current;
		ExceptionInfo.Current = null;
		vector_unsigned_int64_class_std_allocator_unsigned_int64_Destructor.Invoke(ptr);
		ExceptionInfo.Current = current;
		return 0;
	}
}
