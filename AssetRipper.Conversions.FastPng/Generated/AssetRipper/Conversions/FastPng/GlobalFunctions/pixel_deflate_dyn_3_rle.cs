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
		public long field_0;

		public int field_1;

		public int field_2;

		public std_vector_0 field_3;

		public std_allocator_2 field_4;

		public InlineArray_288_vqkfj7a field_5;

		public fpng_defl_huff field_6;
	}

	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("unsigned char const *")] void* pImg, [NativeType("unsigned int")] int w, [NativeType("unsigned int")] int h, [NativeType("unsigned char *")] void* pDst, [NativeType("unsigned int")] int dst_buf_size)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		int num = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = 0L;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = default(std_vector_0);
		startFrame.GetLocalsPointer<LocalVariables>()->field_4 = default(std_allocator_2);
		void* ptr = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_5 = default(InlineArray_288_vqkfj7a);
		void* ptr2 = null;
		int num8 = 0;
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
		startFrame.GetLocalsPointer<LocalVariables>()->field_6 = default(fpng_defl_huff);
		int num21 = 0;
		int num22 = 0;
		int num23 = 0;
		int num24 = 0;
		int num25 = 0;
		int num26 = 0;
		int num27 = 0;
		int num28 = 0;
		int num29 = 0;
		int num30 = 0;
		int num31 = 0;
		int num32 = 0;
		int num33 = 0;
		int num34 = 0;
		int num35 = 0;
		int num36 = 0;
		int num37 = 0;
		int num38 = 0;
		int num39 = 0;
		int num40 = 0;
		int num41 = 0;
		int num42 = 0;
		int num43 = 0;
		int num44 = 0;
		unchecked
		{
			int num45 = 1 + w * 3;
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = 0L;
			startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
			startFrame.GetLocalsPointer<LocalVariables>()->field_2 = 0;
			num2 = 120;
			num3 = 8;
			int num46;
			if ((uint)num3 >= 0u && (uint)num3 <= 16u)
			{
				num46 = -1;
			}
			else
			{
				wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1002);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num46 = 0;
			}
			int num47;
			if ((ulong)(uint)num2 < (ulong)(1L << (int)(uint)num3))
			{
				num47 = -1;
			}
			else
			{
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1002);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num47 = 0;
			}
			long num48 = (long)((ulong)(uint)num2 << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1);
			long field_ = startFrame.GetLocalsPointer<LocalVariables>()->field_0 | num48;
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_;
			int field_2 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 + num3;
			startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_2;
			int num49;
			if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= 64)
			{
				num49 = -1;
			}
			else
			{
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1002);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num49 = 0;
			}
			num4 = 1;
			num5 = 8;
			int num50;
			if ((uint)num5 >= 0u && (uint)num5 <= 16u)
			{
				num50 = -1;
			}
			else
			{
				wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1003);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num50 = 0;
			}
			int num51;
			if ((ulong)(uint)num4 < (ulong)(1L << (int)(uint)num5))
			{
				num51 = -1;
			}
			else
			{
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1003);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num51 = 0;
			}
			long num52 = (long)((ulong)(uint)num4 << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1);
			long field_3 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 | num52;
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_3;
			int field_4 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 + num5;
			startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_4;
			int num53;
			if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= 64)
			{
				num53 = -1;
			}
			else
			{
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1003);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num53 = 0;
			}
			num6 = 1;
			num7 = 1;
			int num54;
			if ((uint)num7 >= 0u && (uint)num7 <= 16u)
			{
				num54 = -1;
			}
			else
			{
				wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1006);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num54 = 0;
			}
			int num55;
			if ((ulong)(uint)num6 < (ulong)(1L << (int)(uint)num7))
			{
				num55 = -1;
			}
			else
			{
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1006);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num55 = 0;
			}
			long num56 = (long)((ulong)(uint)num6 << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1);
			long field_5 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 | num56;
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_5;
			int field_6 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 + num7;
			startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_6;
			int num57;
			if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= 64)
			{
				num57 = -1;
			}
			else
			{
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1006);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num57 = 0;
			}
			allocator_unsigned_int_Constructor.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_4);
			vector_unsigned_int_class_std_allocator_unsigned_int_Constructor.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_3, (uint)((w + 1) * h), &startFrame.GetLocalsPointer<LocalVariables>()->field_4);
			if (ExceptionInfo.Current != null)
			{
				return 0;
			}
			ptr = data_uf9yj3b.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_3);
			llvm_memset_p0_i64.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_5, 0, 1152L, isVolatile: false);
			ptr2 = pImg;
			num8 = 0;
			int num58 = fpng_adler32.Invoke(pImg, (uint)(num45 * h), 1);
			if (ExceptionInfo.Current == null)
			{
				num9 = num58;
				num10 = 2;
				num11 = 0;
				while (true)
				{
					if ((uint)num11 < (uint)h)
					{
						num12 = num8 + num45;
						num13 = (byte)((sbyte*)ptr2)[(uint)num8++];
						int num59 = 1 | (num13 << 8);
						void* ptr3 = ptr;
						ptr = (byte*)ptr3 + 4;
						*(int*)ptr3 = num59;
						((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5))[(uint)num13]++;
						int num60 = READ_RGB_PIXEL.Invoke((byte*)ptr2 + (uint)num8);
						if (ExceptionInfo.Current != null)
						{
							break;
						}
						num15 = num60;
						int num61 = num15 << 8;
						void* ptr4 = ptr;
						ptr = (byte*)ptr4 + 4;
						*(int*)ptr4 = num61;
						((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5))[(uint)(num15 & 0xFF)]++;
						((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5))[(uint)((num15 >>> 8) & 0xFF)]++;
						((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5))[(uint)(num15 >>> 16)]++;
						num8 += 3;
						num14 = num15;
						while ((uint)num8 < (uint)num12)
						{
							int num62 = READ_RGB_PIXEL.Invoke((byte*)ptr2 + (uint)num8);
							if (ExceptionInfo.Current != null)
							{
								goto end_IL_0545;
							}
							num16 = num62;
							if (num16 == num14)
							{
								num17 = 3;
								int num63 = minimum_ymfg3kb.Invoke(255, num12 - num8);
								if (ExceptionInfo.Current != null)
								{
									goto end_IL_0545;
								}
								for (num18 = num63; (uint)num17 < (uint)num18; num17 += 3)
								{
									int num64 = READ_RGB_PIXEL.Invoke((byte*)ptr2 + (uint)num8 + (uint)num17);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0545;
									}
									if (num64 != num16)
									{
										break;
									}
								}
								int num65 = num17 - 1;
								void* ptr5 = ptr;
								ptr = (byte*)ptr5 + 4;
								*(int*)ptr5 = num65;
								long num66 = (ushort)((short*)g_defl_len_sym.__pointer)[(uint)(num17 - 3)];
								((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5))[num66]++;
								num8 += num17;
							}
							else
							{
								int num67 = num16 << 8;
								void* ptr6 = ptr;
								ptr = (byte*)ptr6 + 4;
								*(int*)ptr6 = num67;
								((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5))[(uint)(num16 & 0xFF)]++;
								((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5))[(uint)((num16 >>> 8) & 0xFF)]++;
								((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5))[(uint)(num16 >>> 16)]++;
								num14 = num16;
								num8 += 3;
							}
						}
						num11++;
						continue;
					}
					int num68;
					if (num8 == h * num45)
					{
						num68 = -1;
					}
					else
					{
						wassert.Invoke(String_bjvsuxc.__pointer, String_uxbkrtb.__pointer, 1086);
						if (ExceptionInfo.Current != null)
						{
							break;
						}
						num68 = 0;
					}
					num20 = (int)(((long)ptr - (long)data_uf9yj3b.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_3)) / 4L);
					int num69;
					if ((ulong)(uint)num20 <= (ulong)size_wtrvsgc.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_3))
					{
						num69 = -1;
					}
					else
					{
						wassert.Invoke(String_hsgehfc.__pointer, String_uxbkrtb.__pointer, 1088);
						if (ExceptionInfo.Current != null)
						{
							break;
						}
						num69 = 0;
					}
					((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5))[256] = 1;
					adjust_freq32.Invoke(pFreq16: &startFrame.GetLocalsPointer<LocalVariables>()->field_6.field_0, num_freq: 288, pFreq: &startFrame.GetLocalsPointer<LocalVariables>()->field_5);
					if (ExceptionInfo.Current != null)
					{
						break;
					}
					llvm_memset_p0_i64.Invoke((byte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_6.field_0) + sizeof(InlineArray_288_oeds4ea), 0, 64L, isVolatile: false);
					((short*)((byte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_6.field_0) + sizeof(InlineArray_288_oeds4ea)))[2] = 1;
					((short*)((byte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_6.field_0) + sizeof(InlineArray_288_oeds4ea)))[3] = 1;
					bool flag = defl_start_dynamic_block.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_6, pDst, &startFrame.GetLocalsPointer<LocalVariables>()->field_2, dst_buf_size, &startFrame.GetLocalsPointer<LocalVariables>()->field_0, &startFrame.GetLocalsPointer<LocalVariables>()->field_1);
					if (ExceptionInfo.Current != null)
					{
						break;
					}
					if (!flag)
					{
						num = 0;
						num21 = 1;
					}
					else
					{
						int num70;
						if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= 7)
						{
							num70 = -1;
						}
						else
						{
							wassert.Invoke(String_vpte4cc.__pointer, String_uxbkrtb.__pointer, 1103);
							if (ExceptionInfo.Current != null)
							{
								break;
							}
							num70 = 0;
						}
						int num71;
						if ((ushort)((short*)((byte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_6.field_1) + sizeof(InlineArray_288_oeds4ea)))[2] == 0 && ((byte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_6.field_2) + sizeof(InlineArray_288_w3otm9c))[2] == 1)
						{
							num71 = -1;
						}
						else
						{
							wassert.Invoke(String_df5ko9b.__pointer, String_uxbkrtb.__pointer, 1104);
							if (ExceptionInfo.Current != null)
							{
								break;
							}
							num71 = 0;
						}
						num22 = 0;
						while ((uint)num22 < (uint)num20)
						{
							num23 = *(int*)vector_unsigned_int_class_std_allocator_unsigned_int_Index.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_3, (uint)num22);
							num24 = num23 & 0xFF;
							if (num24 == 0)
							{
								num25 = num23 >>> 8;
								num26 = (ushort)((short*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_6.field_1))[(uint)(num25 & 0xFF)];
								num27 = (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_6.field_2))[(uint)(num25 & 0xFF)];
								int num72;
								if ((uint)num27 >= 1u && (uint)num27 <= 16u)
								{
									num72 = -1;
								}
								else
								{
									wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1115);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0545;
									}
									num72 = 0;
								}
								int num73;
								if ((ulong)(uint)num26 < (ulong)(1L << (int)(uint)num27))
								{
									num73 = -1;
								}
								else
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1115);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0545;
									}
									num73 = 0;
								}
								long num74 = (long)((ulong)(uint)num26 << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1);
								long field_7 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 | num74;
								startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_7;
								int field_8 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 + num27;
								startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_8;
								int num75;
								if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= 64)
								{
									num75 = -1;
								}
								else
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1115);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0545;
									}
									num75 = 0;
								}
								num25 >>>= 8;
								num28 = (ushort)((short*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_6.field_1))[(uint)(num25 & 0xFF)];
								num29 = (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_6.field_2))[(uint)(num25 & 0xFF)];
								int num76;
								if ((uint)num29 >= 1u && (uint)num29 <= 16u)
								{
									num76 = -1;
								}
								else
								{
									wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1118);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0545;
									}
									num76 = 0;
								}
								int num77;
								if ((ulong)(uint)num28 < (ulong)(1L << (int)(uint)num29))
								{
									num77 = -1;
								}
								else
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1118);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0545;
									}
									num77 = 0;
								}
								long num78 = (long)((ulong)(uint)num28 << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1);
								long field_9 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 | num78;
								startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_9;
								int field_10 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 + num29;
								startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_10;
								int num79;
								if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= 64)
								{
									num79 = -1;
								}
								else
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1118);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0545;
									}
									num79 = 0;
								}
								num25 >>>= 8;
								num30 = (ushort)((short*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_6.field_1))[(uint)num25];
								num31 = (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_6.field_2))[(uint)num25];
								int num80;
								if ((uint)num31 >= 1u && (uint)num31 <= 16u)
								{
									num80 = -1;
								}
								else
								{
									wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1121);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0545;
									}
									num80 = 0;
								}
								int num81;
								if ((ulong)(uint)num30 < (ulong)(1L << (int)(uint)num31))
								{
									num81 = -1;
								}
								else
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1121);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0545;
									}
									num81 = 0;
								}
								long num82 = (long)((ulong)(uint)num30 << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1);
								long field_11 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 | num82;
								startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_11;
								int field_12 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 + num31;
								startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_12;
								int num83;
								if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= 64)
								{
									num83 = -1;
								}
								else
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1121);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0545;
									}
									num83 = 0;
								}
							}
							else if (num24 == 1)
							{
								num32 = num23 >>> 8;
								num33 = (ushort)((short*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_6.field_1))[(uint)num32];
								num34 = (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_6.field_2))[(uint)num32];
								int num84;
								if ((uint)num34 >= 1u && (uint)num34 <= 16u)
								{
									num84 = -1;
								}
								else
								{
									wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1126);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0545;
									}
									num84 = 0;
								}
								int num85;
								if ((ulong)(uint)num33 < (ulong)(1L << (int)(uint)num34))
								{
									num85 = -1;
								}
								else
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1126);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0545;
									}
									num85 = 0;
								}
								long num86 = (long)((ulong)(uint)num33 << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1);
								long field_13 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 | num86;
								startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_13;
								int field_14 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 + num34;
								startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_14;
								int num87;
								if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= 64)
								{
									num87 = -1;
								}
								else
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1126);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0545;
									}
									num87 = 0;
								}
							}
							else
							{
								num36 = num24 + 1 - 3;
								num37 = (ushort)((short*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_6.field_1))[(ushort)((short*)g_defl_len_sym.__pointer)[(uint)num36]];
								num38 = (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_6.field_2))[(ushort)((short*)g_defl_len_sym.__pointer)[(uint)num36]];
								int num88;
								if ((uint)num38 >= 1u && (uint)num38 <= 16u)
								{
									num88 = -1;
								}
								else
								{
									wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1134);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0545;
									}
									num88 = 0;
								}
								int num89;
								if ((ulong)(uint)num37 < (ulong)(1L << (int)(uint)num38))
								{
									num89 = -1;
								}
								else
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1134);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0545;
									}
									num89 = 0;
								}
								long num90 = (long)((ulong)(uint)num37 << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1);
								long field_15 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 | num90;
								startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_15;
								int field_16 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 + num38;
								startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_16;
								int num91;
								if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= 64)
								{
									num91 = -1;
								}
								else
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1134);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0545;
									}
									num91 = 0;
								}
								int num92 = num36;
								long num93 = (byte)((sbyte*)g_defl_len_extra.__pointer)[(uint)num36];
								num39 = num92 & ((int*)g_bitmasks.__pointer)[num93];
								checked
								{
									num40 = unchecked((byte)((sbyte*)g_defl_len_extra.__pointer)[(uint)num36]) + 1;
								}
								int num94;
								if ((uint)num40 >= 0u && (uint)num40 <= 16u)
								{
									num94 = -1;
								}
								else
								{
									wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1135);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0545;
									}
									num94 = 0;
								}
								int num95;
								if ((ulong)(uint)num39 < (ulong)(1L << (int)(uint)num40))
								{
									num95 = -1;
								}
								else
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1135);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0545;
									}
									num95 = 0;
								}
								long num96 = (long)((ulong)(uint)num39 << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1);
								long field_17 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 | num96;
								startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_17;
								int field_18 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 + num40;
								startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_18;
								int num97;
								if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= 64)
								{
									num97 = -1;
								}
								else
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1135);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0545;
									}
									num97 = 0;
								}
							}
							if ((uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 8) <= (uint)dst_buf_size)
							{
								long field_19 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
								*(long*)((byte*)pDst + (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2) = field_19;
								num41 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 & -8;
								int field_20 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 + (num41 >>> 3);
								startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_20;
								int num98;
								if ((uint)num41 < 64u)
								{
									num98 = -1;
								}
								else
								{
									wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1142);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0545;
									}
									num98 = 0;
								}
								long field_21 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 >>> (int)(uint)num41;
								startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_21;
								int field_22 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 - num41;
								startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_22;
								num22++;
								continue;
							}
							goto IL_136f;
						}
						num42 = (ushort)((short*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_6.field_1))[256];
						num43 = (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_6.field_2))[256];
						int num99;
						if ((uint)num43 >= 1u && (uint)num43 <= 16u)
						{
							num99 = -1;
						}
						else
						{
							wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1145);
							if (ExceptionInfo.Current != null)
							{
								break;
							}
							num99 = 0;
						}
						int num100;
						if ((ulong)(uint)num42 < (ulong)(1L << (int)(uint)num43))
						{
							num100 = -1;
						}
						else
						{
							wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1145);
							if (ExceptionInfo.Current != null)
							{
								break;
							}
							num100 = 0;
						}
						long num101 = (long)((ulong)(uint)num42 << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1);
						long field_23 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 | num101;
						startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_23;
						int field_24 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 + num43;
						startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_24;
						int num102;
						if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= 64)
						{
							num102 = -1;
						}
						else
						{
							wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1145);
							if (ExceptionInfo.Current != null)
							{
								break;
							}
							num102 = 0;
						}
						while (true)
						{
							if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 > 0)
							{
								if ((uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 1) > (uint)dst_buf_size)
								{
									num = 0;
									num21 = 1;
									break;
								}
								sbyte b = (sbyte)startFrame.GetLocalsPointer<LocalVariables>()->field_0;
								((sbyte*)pDst)[(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2] = b;
								int field_25 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 1;
								startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_25;
								long field_26 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 >>> 8;
								startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_26;
								int field_27 = checked(startFrame.GetLocalsPointer<LocalVariables>()->field_1 - 8);
								startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_27;
								continue;
							}
							num44 = 0;
							while (true)
							{
								if ((uint)num44 < 4u)
								{
									if ((uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 1) > (uint)dst_buf_size)
									{
										num = 0;
										num21 = 1;
										break;
									}
									((sbyte*)pDst)[(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2] = (sbyte)(num9 >>> 24);
									int field_28 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 1;
									startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_28;
									num9 <<= 8;
									num44++;
									continue;
								}
								num = startFrame.GetLocalsPointer<LocalVariables>()->field_2;
								num21 = 1;
								break;
							}
							break;
						}
					}
					goto IL_16fb;
					IL_16fb:
					vector_unsigned_int_class_std_allocator_unsigned_int_Destructor.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_3);
					int result = num;
					StackFrameList.Current.Clear(startFrame);
					return result;
					IL_136f:
					num = 0;
					num21 = 1;
					goto IL_16fb;
					continue;
					end_IL_0545:
					break;
				}
			}
			ExceptionInfo? current = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			vector_unsigned_int_class_std_allocator_unsigned_int_Destructor.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_3);
			ExceptionInfo.Current = current;
			return 0;
		}
	}
}
