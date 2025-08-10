using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?fpng_get_info_internal@fpng@@YAHPEBXIAEAI1111@Z")]
[DemangledName("int __cdecl fpng::fpng_get_info_internal(void const *, unsigned int, unsigned int &, unsigned int &, unsigned int &, unsigned int &, unsigned int &)")]
internal static partial class fpng_get_info_internal
{
	private partial struct LocalVariables
	{
		public int Instruction_0;

		public unsafe void* Instruction_1;

		public unsafe void* Instruction_2;

		public unsafe void* Instruction_3;

		public unsafe void* Instruction_4;

		public unsafe void* Instruction_5;

		public int Instruction_6;

		public unsafe void* Instruction_7;

		public unsafe void* Instruction_8;

		public unsafe void* Instruction_9;

		public long Instruction_10;

		public sbyte Instruction_11;

		public long Instruction_12;

		public int Instruction_13;

		public unsafe void* Instruction_14;

		public int Instruction_15;

		public int Instruction_16;

		public sbyte Instruction_17;

		public sbyte Instruction_18;

		public sbyte Instruction_19;

		public int Instruction_20;

		public InlineArray_5_w3otm9c Instruction_21;

		public sbyte Instruction_22;

		public int Instruction_23;

		public unsafe void* Instruction_24;
	}

	public unsafe static int Invoke(void* pImage, int image_size, void* width, void* height, void* channels_in_file, void* idat_ofs, void* idat_len)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		InlineArray_5_w3otm9c* ptr = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_21;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = idat_len;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = idat_ofs;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = channels_in_file;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_4 = height;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_5 = width;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_6 = image_size;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = pImage;
		unchecked
		{
			if (!endian_check.Invoke())
			{
				wassert.Invoke(String_kdrammb.__pointer, String_uxbkrtb.__pointer, 2936);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 0;
			}
			else
			{
				*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 = 0;
				*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 = 0;
				*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = 0;
				*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = 0;
				*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = 0;
				if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_6 < 58uL)
				{
					startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 3;
				}
				else if (memcmp.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_7, s_png_sig.__pointer, 8L) != 0)
				{
					startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 3;
				}
				else
				{
					void* instruction_ = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = (byte*)instruction_ + 8L;
					void* instruction_2 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_2;
					void* instruction_3 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = (byte*)instruction_3 + 25L;
					if (swap32.Invoke(((fpng_png_ihdr*)startFrame.GetLocalsRef<LocalVariables>().Instruction_9)->field_0.field_0) != 13)
					{
						startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 3;
					}
					else if (fpng_crc32.Invoke((byte*)(&((fpng_png_ihdr*)startFrame.GetLocalsRef<LocalVariables>().Instruction_9)->field_0.field_1) + sizeof(sbyte) * 0, 17L, 0) != swap32.Invoke(((fpng_png_ihdr*)startFrame.GetLocalsRef<LocalVariables>().Instruction_9)->field_8))
					{
						startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 4;
					}
					else
					{
						int num = swap32.Invoke(((fpng_png_ihdr*)startFrame.GetLocalsRef<LocalVariables>().Instruction_9)->field_1);
						*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 = num;
						int num2 = swap32.Invoke(((fpng_png_ihdr*)startFrame.GetLocalsRef<LocalVariables>().Instruction_9)->field_2);
						*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 = num2;
						if (*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 == 0 || *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 == 0 || (uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5) > 16777216u || (uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4) > 16777216u)
						{
							startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 5;
						}
						else
						{
							long num3 = (uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5);
							int instruction_4 = *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = num3 * (uint)instruction_4;
							if ((ulong)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 > 1073741824uL)
							{
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 5;
							}
							else if (((fpng_png_ihdr*)startFrame.GetLocalsRef<LocalVariables>().Instruction_9)->field_5 != 0 || ((fpng_png_ihdr*)startFrame.GetLocalsRef<LocalVariables>().Instruction_9)->field_6 != 0 || ((fpng_png_ihdr*)startFrame.GetLocalsRef<LocalVariables>().Instruction_9)->field_7 != 0 || (byte)((fpng_png_ihdr*)startFrame.GetLocalsRef<LocalVariables>().Instruction_9)->field_3 != 8)
							{
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 1;
							}
							else
							{
								if ((byte)((fpng_png_ihdr*)startFrame.GetLocalsRef<LocalVariables>().Instruction_9)->field_4 == 2)
								{
									*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = 3;
								}
								else if ((byte)((fpng_png_ihdr*)startFrame.GetLocalsRef<LocalVariables>().Instruction_9)->field_4 == 6)
								{
									*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = 4;
								}
								if (*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 == 0)
								{
									startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 1;
								}
								else
								{
									startFrame.GetLocalsRef<LocalVariables>().Instruction_11 = 0;
									while (true)
									{
										void* instruction_5 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
										void* instruction_6 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = (long)instruction_5 - (long)instruction_6;
										if ((ulong)startFrame.GetLocalsRef<LocalVariables>().Instruction_12 >= (ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)
										{
											startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 7;
											break;
										}
										int instruction_7 = startFrame.GetLocalsRef<LocalVariables>().Instruction_6;
										long instruction_8 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_13 = instruction_7 - (int)instruction_8;
										if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_13 < 12uL)
										{
											startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 7;
											break;
										}
										void* instruction_9 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_14 = instruction_9;
										int instruction_10 = swap32.Invoke(((fpng_png_chunk_prefix*)startFrame.GetLocalsRef<LocalVariables>().Instruction_14)->field_0);
										startFrame.GetLocalsRef<LocalVariables>().Instruction_15 = instruction_10;
										if ((ulong)(startFrame.GetLocalsRef<LocalVariables>().Instruction_12 + 8L + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_15 + 4L) > (ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)
										{
											startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 7;
											break;
										}
										startFrame.GetLocalsRef<LocalVariables>().Instruction_16 = 0;
										while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_16 < 4u)
										{
											sbyte instruction_11 = ((sbyte*)(&((fpng_png_chunk_prefix*)startFrame.GetLocalsRef<LocalVariables>().Instruction_14)->field_1))[sizeof(sbyte) * (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_16];
											startFrame.GetLocalsRef<LocalVariables>().Instruction_17 = instruction_11;
											bool flag = (byte)startFrame.GetLocalsRef<LocalVariables>().Instruction_17 >= 65 && (byte)startFrame.GetLocalsRef<LocalVariables>().Instruction_17 <= 90;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_18 = (flag ? ((sbyte)1) : ((sbyte)0));
											bool flag2 = (byte)startFrame.GetLocalsRef<LocalVariables>().Instruction_17 >= 97 && (byte)startFrame.GetLocalsRef<LocalVariables>().Instruction_17 <= 122;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_19 = (flag2 ? ((sbyte)1) : ((sbyte)0));
											if ((startFrame.GetLocalsRef<LocalVariables>().Instruction_18 & 1) != 1 && (startFrame.GetLocalsRef<LocalVariables>().Instruction_19 & 1) != 1)
											{
												goto IL_0950;
											}
											int instruction_12 = startFrame.GetLocalsRef<LocalVariables>().Instruction_16;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_16 = instruction_12 + 1;
										}
										int instruction_13 = swap32.Invoke(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_8 + 8L + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_15));
										startFrame.GetLocalsRef<LocalVariables>().Instruction_20 = instruction_13;
										sbyte instruction_14 = ((sbyte*)(&((fpng_png_chunk_prefix*)startFrame.GetLocalsRef<LocalVariables>().Instruction_14)->field_1))[sizeof(sbyte) * 0];
										Unsafe.As<InlineArray_5_w3otm9c, sbyte>(ref startFrame.GetLocalsRef<LocalVariables>().Instruction_21) = instruction_14;
										((sbyte*)ptr)[1L] = ((sbyte*)(&((fpng_png_chunk_prefix*)startFrame.GetLocalsRef<LocalVariables>().Instruction_14)->field_1))[sizeof(sbyte) * 1];
										((sbyte*)ptr)[2L] = ((sbyte*)(&((fpng_png_chunk_prefix*)startFrame.GetLocalsRef<LocalVariables>().Instruction_14)->field_1))[sizeof(sbyte) * 2];
										((sbyte*)ptr)[3L] = ((sbyte*)(&((fpng_png_chunk_prefix*)startFrame.GetLocalsRef<LocalVariables>().Instruction_14)->field_1))[sizeof(sbyte) * 3];
										((sbyte*)ptr)[4L] = 0;
										int num4 = strcmp.Invoke((byte*)ptr + sizeof(sbyte) * 0, String_qjc9xdd.__pointer);
										startFrame.GetLocalsRef<LocalVariables>().Instruction_22 = ((num4 == 0) ? ((sbyte)1) : ((sbyte)0));
										if ((startFrame.GetLocalsRef<LocalVariables>().Instruction_22 & 1) != 1)
										{
											int instruction_15 = fpng_crc32.Invoke(size: 4L + (long)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_15, pData: (byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_8 + 4L, prev_crc32: 0);
											startFrame.GetLocalsRef<LocalVariables>().Instruction_23 = instruction_15;
											if (startFrame.GetLocalsRef<LocalVariables>().Instruction_23 != startFrame.GetLocalsRef<LocalVariables>().Instruction_20)
											{
												startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 4;
												break;
											}
										}
										void* instruction_16 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_24 = (byte*)instruction_16 + 8L;
										if (strcmp.Invoke((byte*)ptr + sizeof(sbyte) * 0, String_p7olgfc.__pointer) != 0)
										{
											if ((startFrame.GetLocalsRef<LocalVariables>().Instruction_22 & 1) == 1)
											{
												if (*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 != 0 || (startFrame.GetLocalsRef<LocalVariables>().Instruction_11 & 1) != 1)
												{
													startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 1;
													break;
												}
												long instruction_17 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
												*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = (int)instruction_17;
												int instruction_18 = startFrame.GetLocalsRef<LocalVariables>().Instruction_15;
												*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = instruction_18;
												if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1) < 7u)
												{
													startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 8;
													break;
												}
											}
											else if (strcmp.Invoke((byte*)ptr + sizeof(sbyte) * 0, String_22lii4a.__pointer) == 0)
											{
												if ((startFrame.GetLocalsRef<LocalVariables>().Instruction_11 & 1) == 1)
												{
													startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 1;
													break;
												}
												if (startFrame.GetLocalsRef<LocalVariables>().Instruction_15 != 5)
												{
													startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 1;
													break;
												}
												if ((byte)(*(sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_24) != 82 || (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_24)[1L] != 36 || (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_24)[2L] != 147 || (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_24)[3L] != 227)
												{
													startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 1;
													break;
												}
												if ((byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_24)[4L] != 0)
												{
													startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 1;
													break;
												}
												startFrame.GetLocalsRef<LocalVariables>().Instruction_11 = 1;
											}
											else if ((((sbyte*)ptr)[sizeof(sbyte) * 0] & 0x20) == 0)
											{
												startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 1;
												break;
											}
											long num5 = 8L + (long)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_15 + 4L;
											void* instruction_19 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
											startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = (byte*)instruction_19 + num5;
											continue;
										}
										if ((startFrame.GetLocalsRef<LocalVariables>().Instruction_11 & 1) != 1 || *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 == 0)
										{
											startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 1;
										}
										else
										{
											startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 0;
										}
										break;
										IL_0950:
										startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 7;
										break;
									}
								}
							}
						}
					}
				}
			}
			int instruction_20 = startFrame.GetLocalsRef<LocalVariables>().Instruction_0;
			StackFrameList.Current.Clear(startFrame);
			return instruction_20;
		}
	}
}
