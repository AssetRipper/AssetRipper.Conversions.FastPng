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
		public long field_0;

		public int field_1;

		public int field_2;

		public std_vector_5 field_3;

		public InlineArray_288_vqkfj7a field_4;

		public fpng_defl_huff field_5;
	}

	public unsafe static int Invoke(void* pImg, int w, int h, void* pDst, int dst_buf_size)
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
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = default(std_vector_5);
		void* ptr = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_4 = default(InlineArray_288_vqkfj7a);
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
		startFrame.GetLocalsPointer<LocalVariables>()->field_5 = default(fpng_defl_huff);
		int num21 = 0;
		int num22 = 0;
		long num23 = 0L;
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
		int num45 = 0;
		int num46 = 0;
		int num47 = 0;
		unchecked
		{
			int num48 = 1 + w * 4;
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = 0L;
			startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
			startFrame.GetLocalsPointer<LocalVariables>()->field_2 = 0;
			num2 = 120;
			num3 = 8;
			int num49;
			if ((uint)num3 >= 0u && (uint)num3 <= 16u)
			{
				num49 = -1;
			}
			else
			{
				wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1279);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num49 = 0;
			}
			int num50;
			if ((ulong)(uint)num2 < (ulong)(1L << (int)(uint)num3))
			{
				num50 = -1;
			}
			else
			{
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1279);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num50 = 0;
			}
			long num51 = (long)((ulong)(uint)num2 << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1);
			long field_ = startFrame.GetLocalsPointer<LocalVariables>()->field_0 | num51;
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_;
			int field_2 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 + num3;
			startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_2;
			int num52;
			if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= 64)
			{
				num52 = -1;
			}
			else
			{
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1279);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num52 = 0;
			}
			num4 = 1;
			num5 = 8;
			int num53;
			if ((uint)num5 >= 0u && (uint)num5 <= 16u)
			{
				num53 = -1;
			}
			else
			{
				wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1280);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num53 = 0;
			}
			int num54;
			if ((ulong)(uint)num4 < (ulong)(1L << (int)(uint)num5))
			{
				num54 = -1;
			}
			else
			{
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1280);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num54 = 0;
			}
			long num55 = (long)((ulong)(uint)num4 << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1);
			long field_3 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 | num55;
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_3;
			int field_4 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 + num5;
			startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_4;
			int num56;
			if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= 64)
			{
				num56 = -1;
			}
			else
			{
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1280);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num56 = 0;
			}
			num6 = 1;
			num7 = 1;
			int num57;
			if ((uint)num7 >= 0u && (uint)num7 <= 16u)
			{
				num57 = -1;
			}
			else
			{
				wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1283);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num57 = 0;
			}
			int num58;
			if ((ulong)(uint)num6 < (ulong)(1L << (int)(uint)num7))
			{
				num58 = -1;
			}
			else
			{
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1283);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num58 = 0;
			}
			long num59 = (long)((ulong)(uint)num6 << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1);
			long field_5 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 | num59;
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_5;
			int field_6 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 + num7;
			startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_6;
			int num60;
			if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= 64)
			{
				num60 = -1;
			}
			else
			{
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1283);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num60 = 0;
			}
			vector_unsigned_int64_class_std_allocator_unsigned_int64_Constructor.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_3);
			resize_d4pmvud.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_3, (uint)((w + 1) * h));
			if (ExceptionInfo.Current == null)
			{
				ptr = data_dtgl25a.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_3);
				llvm_memset_p0_i64.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_4, 0, 1152L, isVolatile: false);
				ptr2 = pImg;
				num8 = 0;
				int num61 = fpng_adler32.Invoke(pImg, (uint)(num48 * h), 1);
				if (ExceptionInfo.Current == null)
				{
					num9 = num61;
					num10 = 3;
					for (num11 = 0; (uint)num11 < (uint)h; num11++)
					{
						num12 = num8 + num48;
						num13 = (byte)((sbyte*)ptr2)[(uint)num8++];
						long num62 = (uint)(1 | (num13 << 8));
						void* ptr3 = ptr;
						ptr = (byte*)ptr3 + 8;
						*(long*)ptr3 = num62;
						((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_4))[(uint)num13]++;
						num15 = *(int*)((byte*)ptr2 + (uint)num8);
						long num63 = (long)((ulong)(uint)num15 << 8);
						void* ptr4 = ptr;
						ptr = (byte*)ptr4 + 8;
						*(long*)ptr4 = num63;
						((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_4))[(uint)(num15 & 0xFF)]++;
						((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_4))[(uint)((num15 >>> 8) & 0xFF)]++;
						((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_4))[(uint)((num15 >>> 16) & 0xFF)]++;
						((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_4))[(uint)(num15 >>> 24)]++;
						num8 += 4;
						num14 = num15;
						while ((uint)num8 < (uint)num12)
						{
							num16 = *(int*)((byte*)ptr2 + (uint)num8);
							if (num16 == num14)
							{
								num17 = 4;
								for (num18 = minimum_ymfg3kb.Invoke(252, num12 - num8); (uint)num17 < (uint)num18 && *(int*)((byte*)ptr2 + (uint)num8 + (uint)num17) == num16; num17 += 4)
								{
								}
								long num64 = (uint)(num17 - 1);
								void* ptr5 = ptr;
								ptr = (byte*)ptr5 + 8;
								*(long*)ptr5 = num64;
								long num65 = (ushort)((short*)g_defl_len_sym.__pointer)[(uint)(num17 - 3)];
								((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_4))[num65]++;
								num8 += num17;
							}
							else
							{
								long num66 = (long)((ulong)(uint)num16 << 8);
								void* ptr6 = ptr;
								ptr = (byte*)ptr6 + 8;
								*(long*)ptr6 = num66;
								((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_4))[(uint)(num16 & 0xFF)]++;
								((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_4))[(uint)((num16 >>> 8) & 0xFF)]++;
								((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_4))[(uint)((num16 >>> 16) & 0xFF)]++;
								((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_4))[(uint)(num16 >>> 24)]++;
								num14 = num16;
								num8 += 4;
							}
						}
					}
					int num67;
					if (num8 == h * num48)
					{
						num67 = -1;
					}
					else
					{
						wassert.Invoke(String_bjvsuxc.__pointer, String_uxbkrtb.__pointer, 1365);
						if (ExceptionInfo.Current != null)
						{
							goto IL_19b9;
						}
						num67 = 0;
					}
					num20 = (int)(((long)ptr - (long)data_dtgl25a.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_3)) / 8L);
					int num68;
					if ((ulong)(uint)num20 <= (ulong)size_trt5i3d.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_3))
					{
						num68 = -1;
					}
					else
					{
						wassert.Invoke(String_hsgehfc.__pointer, String_uxbkrtb.__pointer, 1367);
						if (ExceptionInfo.Current != null)
						{
							goto IL_19b9;
						}
						num68 = 0;
					}
					((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_4))[256] = 1;
					adjust_freq32.Invoke(pFreq16: &startFrame.GetLocalsPointer<LocalVariables>()->field_5.field_0, num_freq: 288, pFreq: &startFrame.GetLocalsPointer<LocalVariables>()->field_4);
					if (ExceptionInfo.Current == null)
					{
						llvm_memset_p0_i64.Invoke((byte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5.field_0) + sizeof(InlineArray_288_oeds4ea), 0, 64L, isVolatile: false);
						((short*)((byte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5.field_0) + sizeof(InlineArray_288_oeds4ea)))[3] = 1;
						((short*)((byte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5.field_0) + sizeof(InlineArray_288_oeds4ea)))[4] = 1;
						bool flag = defl_start_dynamic_block.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_5, pDst, &startFrame.GetLocalsPointer<LocalVariables>()->field_2, dst_buf_size, &startFrame.GetLocalsPointer<LocalVariables>()->field_0, &startFrame.GetLocalsPointer<LocalVariables>()->field_1);
						if (ExceptionInfo.Current == null)
						{
							if (!flag)
							{
								num = 0;
								num21 = 1;
							}
							else
							{
								int num69;
								if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= 7)
								{
									num69 = -1;
								}
								else
								{
									wassert.Invoke(String_vpte4cc.__pointer, String_uxbkrtb.__pointer, 1382);
									if (ExceptionInfo.Current != null)
									{
										goto IL_19b9;
									}
									num69 = 0;
								}
								int num70;
								if ((ushort)((short*)((byte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5.field_1) + sizeof(InlineArray_288_oeds4ea)))[3] == 0 && ((byte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5.field_2) + sizeof(InlineArray_288_w3otm9c))[3] == 1)
								{
									num70 = -1;
								}
								else
								{
									wassert.Invoke(String_df5ko9b.__pointer, String_uxbkrtb.__pointer, 1383);
									if (ExceptionInfo.Current != null)
									{
										goto IL_19b9;
									}
									num70 = 0;
								}
								long field_27;
								int field_28;
								for (num22 = 0; (uint)num22 < (uint)num20; field_27 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 >>> (int)(uint)num44, startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_27, field_28 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 - num44, startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_28, num22++)
								{
									num23 = *(long*)vector_unsigned_int64_class_std_allocator_unsigned_int64_Index.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_3, (uint)num22);
									num24 = (int)(num23 & 0xFFL);
									if (num24 == 0)
									{
										num25 = (int)(num23 >>> 8);
										num26 = (ushort)((short*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5.field_1))[(uint)(num25 & 0xFF)];
										num27 = (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5.field_2))[(uint)(num25 & 0xFF)];
										int num71;
										if ((uint)num27 >= 1u && (uint)num27 <= 16u)
										{
											num71 = -1;
										}
										else
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1394);
											if (ExceptionInfo.Current != null)
											{
												goto IL_19b9;
											}
											num71 = 0;
										}
										int num72;
										if ((ulong)(uint)num26 < (ulong)(1L << (int)(uint)num27))
										{
											num72 = -1;
										}
										else
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1394);
											if (ExceptionInfo.Current != null)
											{
												goto IL_19b9;
											}
											num72 = 0;
										}
										long num73 = (long)((ulong)(uint)num26 << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1);
										long field_7 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 | num73;
										startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_7;
										int field_8 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 + num27;
										startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_8;
										int num74;
										if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= 64)
										{
											num74 = -1;
										}
										else
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1394);
											if (ExceptionInfo.Current != null)
											{
												goto IL_19b9;
											}
											num74 = 0;
										}
										num25 >>>= 8;
										num28 = (ushort)((short*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5.field_1))[(uint)(num25 & 0xFF)];
										num29 = (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5.field_2))[(uint)(num25 & 0xFF)];
										int num75;
										if ((uint)num29 >= 1u && (uint)num29 <= 16u)
										{
											num75 = -1;
										}
										else
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1397);
											if (ExceptionInfo.Current != null)
											{
												goto IL_19b9;
											}
											num75 = 0;
										}
										int num76;
										if ((ulong)(uint)num28 < (ulong)(1L << (int)(uint)num29))
										{
											num76 = -1;
										}
										else
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1397);
											if (ExceptionInfo.Current != null)
											{
												goto IL_19b9;
											}
											num76 = 0;
										}
										long num77 = (long)((ulong)(uint)num28 << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1);
										long field_9 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 | num77;
										startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_9;
										int field_10 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 + num29;
										startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_10;
										int num78;
										if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= 64)
										{
											num78 = -1;
										}
										else
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1397);
											if (ExceptionInfo.Current != null)
											{
												goto IL_19b9;
											}
											num78 = 0;
										}
										num25 >>>= 8;
										num30 = (ushort)((short*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5.field_1))[(uint)(num25 & 0xFF)];
										num31 = (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5.field_2))[(uint)(num25 & 0xFF)];
										int num79;
										if ((uint)num31 >= 1u && (uint)num31 <= 16u)
										{
											num79 = -1;
										}
										else
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1400);
											if (ExceptionInfo.Current != null)
											{
												goto IL_19b9;
											}
											num79 = 0;
										}
										int num80;
										if ((ulong)(uint)num30 < (ulong)(1L << (int)(uint)num31))
										{
											num80 = -1;
										}
										else
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1400);
											if (ExceptionInfo.Current != null)
											{
												goto IL_19b9;
											}
											num80 = 0;
										}
										long num81 = (long)((ulong)(uint)num30 << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1);
										long field_11 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 | num81;
										startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_11;
										int field_12 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 + num31;
										startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_12;
										int num82;
										if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= 64)
										{
											num82 = -1;
										}
										else
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1400);
											if (ExceptionInfo.Current != null)
											{
												goto IL_19b9;
											}
											num82 = 0;
										}
										num25 >>>= 8;
										if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 >= 49)
										{
											if ((uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 8) > (uint)dst_buf_size)
											{
												goto IL_0f76;
											}
											long field_13 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
											*(long*)((byte*)pDst + (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2) = field_13;
											num32 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 & -8;
											int field_14 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 + (num32 >>> 3);
											startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_14;
											int num83;
											if ((uint)num32 < 64u)
											{
												num83 = -1;
											}
											else
											{
												wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1405);
												if (ExceptionInfo.Current != null)
												{
													goto IL_19b9;
												}
												num83 = 0;
											}
											long field_15 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 >>> (int)(uint)num32;
											startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_15;
											int field_16 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 - num32;
											startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_16;
										}
										num33 = (ushort)((short*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5.field_1))[(uint)num25];
										num34 = (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5.field_2))[(uint)num25];
										int num84;
										if ((uint)num34 >= 1u && (uint)num34 <= 16u)
										{
											num84 = -1;
										}
										else
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1408);
											if (ExceptionInfo.Current != null)
											{
												goto IL_19b9;
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
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1408);
											if (ExceptionInfo.Current != null)
											{
												goto IL_19b9;
											}
											num85 = 0;
										}
										long num86 = (long)((ulong)(uint)num33 << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1);
										long field_17 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 | num86;
										startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_17;
										int field_18 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 + num34;
										startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_18;
										int num87;
										if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= 64)
										{
											num87 = -1;
										}
										else
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1408);
											if (ExceptionInfo.Current != null)
											{
												goto IL_19b9;
											}
											num87 = 0;
										}
									}
									else if (num24 == 1)
									{
										num35 = (int)(num23 >>> 8);
										num36 = (ushort)((short*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5.field_1))[(uint)num35];
										num37 = (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5.field_2))[(uint)num35];
										int num88;
										if ((uint)num37 >= 1u && (uint)num37 <= 16u)
										{
											num88 = -1;
										}
										else
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1413);
											if (ExceptionInfo.Current != null)
											{
												goto IL_19b9;
											}
											num88 = 0;
										}
										int num89;
										if ((ulong)(uint)num36 < (ulong)(1L << (int)(uint)num37))
										{
											num89 = -1;
										}
										else
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1413);
											if (ExceptionInfo.Current != null)
											{
												goto IL_19b9;
											}
											num89 = 0;
										}
										long num90 = (long)((ulong)(uint)num36 << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1);
										long field_19 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 | num90;
										startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_19;
										int field_20 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 + num37;
										startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_20;
										int num91;
										if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= 64)
										{
											num91 = -1;
										}
										else
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1413);
											if (ExceptionInfo.Current != null)
											{
												goto IL_19b9;
											}
											num91 = 0;
										}
									}
									else
									{
										num39 = num24 + 1 - 3;
										num40 = (ushort)((short*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5.field_1))[(ushort)((short*)g_defl_len_sym.__pointer)[(uint)num39]];
										num41 = (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5.field_2))[(ushort)((short*)g_defl_len_sym.__pointer)[(uint)num39]];
										int num92;
										if ((uint)num41 >= 1u && (uint)num41 <= 16u)
										{
											num92 = -1;
										}
										else
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1421);
											if (ExceptionInfo.Current != null)
											{
												goto IL_19b9;
											}
											num92 = 0;
										}
										int num93;
										if ((ulong)(uint)num40 < (ulong)(1L << (int)(uint)num41))
										{
											num93 = -1;
										}
										else
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1421);
											if (ExceptionInfo.Current != null)
											{
												goto IL_19b9;
											}
											num93 = 0;
										}
										long num94 = (long)((ulong)(uint)num40 << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1);
										long field_21 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 | num94;
										startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_21;
										int field_22 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 + num41;
										startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_22;
										int num95;
										if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= 64)
										{
											num95 = -1;
										}
										else
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1421);
											if (ExceptionInfo.Current != null)
											{
												goto IL_19b9;
											}
											num95 = 0;
										}
										int num96 = num39;
										long num97 = (byte)((sbyte*)g_defl_len_extra.__pointer)[(uint)num39];
										num42 = num96 & ((int*)g_bitmasks.__pointer)[num97];
										checked
										{
											num43 = unchecked((byte)((sbyte*)g_defl_len_extra.__pointer)[(uint)num39]) + 1;
										}
										int num98;
										if ((uint)num43 >= 0u && (uint)num43 <= 16u)
										{
											num98 = -1;
										}
										else
										{
											wassert.Invoke(String_9hewgtd.__pointer, String_uxbkrtb.__pointer, 1422);
											if (ExceptionInfo.Current != null)
											{
												goto IL_19b9;
											}
											num98 = 0;
										}
										int num99;
										if ((ulong)(uint)num42 < (ulong)(1L << (int)(uint)num43))
										{
											num99 = -1;
										}
										else
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1422);
											if (ExceptionInfo.Current != null)
											{
												goto IL_19b9;
											}
											num99 = 0;
										}
										long num100 = (long)((ulong)(uint)num42 << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1);
										long field_23 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 | num100;
										startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_23;
										int field_24 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 + num43;
										startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_24;
										int num101;
										if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= 64)
										{
											num101 = -1;
										}
										else
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1422);
											if (ExceptionInfo.Current != null)
											{
												goto IL_19b9;
											}
											num101 = 0;
										}
									}
									if ((uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 8) > (uint)dst_buf_size)
									{
										goto IL_160e;
									}
									long field_25 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
									*(long*)((byte*)pDst + (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2) = field_25;
									num44 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 & -8;
									int field_26 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 + (num44 >>> 3);
									startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_26;
									int num102;
									if ((uint)num44 < 64u)
									{
										num102 = -1;
										continue;
									}
									wassert.Invoke(String_2ej5tjb.__pointer, String_uxbkrtb.__pointer, 1428);
									if (ExceptionInfo.Current == null)
									{
										num102 = 0;
										continue;
									}
									goto IL_19b9;
								}
								num45 = (ushort)((short*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5.field_1))[256];
								num46 = (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5.field_2))[256];
								int num103;
								if ((uint)num46 >= 1u && (uint)num46 <= 16u)
								{
									num103 = -1;
								}
								else
								{
									wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 1431);
									if (ExceptionInfo.Current != null)
									{
										goto IL_19b9;
									}
									num103 = 0;
								}
								int num104;
								if ((ulong)(uint)num45 < (ulong)(1L << (int)(uint)num46))
								{
									num104 = -1;
								}
								else
								{
									wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 1431);
									if (ExceptionInfo.Current != null)
									{
										goto IL_19b9;
									}
									num104 = 0;
								}
								long num105 = (long)((ulong)(uint)num45 << (int)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1);
								long field_29 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 | num105;
								startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_29;
								int field_30 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 + num46;
								startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_30;
								int num106;
								if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= 64)
								{
									num106 = -1;
								}
								else
								{
									wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 1431);
									if (ExceptionInfo.Current != null)
									{
										goto IL_19b9;
									}
									num106 = 0;
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
										int field_31 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 1;
										startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_31;
										long field_32 = startFrame.GetLocalsPointer<LocalVariables>()->field_0 >>> 8;
										startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_32;
										int field_33 = checked(startFrame.GetLocalsPointer<LocalVariables>()->field_1 - 8);
										startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_33;
										continue;
									}
									num47 = 0;
									while (true)
									{
										if ((uint)num47 < 4u)
										{
											if ((uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 1) > (uint)dst_buf_size)
											{
												num = 0;
												num21 = 1;
												break;
											}
											((sbyte*)pDst)[(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2] = (sbyte)(num9 >>> 24);
											int field_34 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 1;
											startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_34;
											num9 <<= 8;
											num47++;
											continue;
										}
										num = startFrame.GetLocalsPointer<LocalVariables>()->field_2;
										num21 = 1;
										break;
									}
									break;
								}
							}
							goto IL_199a;
						}
					}
				}
			}
			goto IL_19b9;
		}
		IL_160e:
		num = 0;
		num21 = 1;
		goto IL_199a;
		IL_0f76:
		num = 0;
		num21 = 1;
		goto IL_199a;
		IL_199a:
		vector_unsigned_int64_class_std_allocator_unsigned_int64_Destructor.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_3);
		int result = num;
		StackFrameList.Current.Clear(startFrame);
		return result;
		IL_19b9:
		ExceptionInfo? current = ExceptionInfo.Current;
		ExceptionInfo.Current = null;
		vector_unsigned_int64_class_std_allocator_unsigned_int64_Destructor.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_3);
		ExceptionInfo.Current = current;
		return 0;
	}
}
