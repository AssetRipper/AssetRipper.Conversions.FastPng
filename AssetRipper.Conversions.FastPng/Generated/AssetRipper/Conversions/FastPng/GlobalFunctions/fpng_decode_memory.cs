using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?fpng_decode_memory@fpng@@YAHPEBXIAEAV?$vector@EV?$allocator@E@std@@@std@@AEAI22I@Z")]
[DemangledName("int __cdecl fpng::fpng_decode_memory(void const *, unsigned int, class std::vector<unsigned char, class std::allocator<unsigned char>> &, unsigned int &, unsigned int &, unsigned int &, unsigned int)")]
internal static partial class fpng_decode_memory
{
	private partial struct LocalVariables
	{
		public int Instruction_0;

		public int Instruction_1;

		public unsafe void* Instruction_2;

		public unsafe void* Instruction_3;

		public unsafe void* Instruction_4;

		public unsafe void* Instruction_5;

		public int Instruction_6;

		public unsafe void* Instruction_7;

		public int Instruction_8;

		public int Instruction_9;

		public int Instruction_10;

		public long Instruction_11;

		public unsafe void* Instruction_12;

		public int Instruction_13;

		public sbyte Instruction_14;
	}

	public unsafe static int Invoke(void* pImage, int image_size, void* @out, void* width, void* height, void* channels_in_file, int desired_channels)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		int* idat_ofs = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_8;
		int* idat_len = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_9;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = desired_channels;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = channels_in_file;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = height;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_4 = width;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_5 = @out;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_6 = image_size;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = pImage;
		resize_wwmwtsa.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_5, 0L);
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		unchecked
		{
			*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 = 0;
			*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = 0;
			*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = 0;
			if (startFrame.GetLocalsRef<LocalVariables>().Instruction_7 == null || startFrame.GetLocalsRef<LocalVariables>().Instruction_6 == 0 || (startFrame.GetLocalsRef<LocalVariables>().Instruction_1 != 3 && startFrame.GetLocalsRef<LocalVariables>().Instruction_1 != 4))
			{
				wassert.Invoke(String_kdrammb.__pointer, String_uxbkrtb.__pointer, 3094);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 2;
			}
			else
			{
				startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = 0;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = 0;
				int instruction_ = fpng_get_info_internal.Invoke(channels_in_file: startFrame.GetLocalsRef<LocalVariables>().Instruction_2, height: startFrame.GetLocalsRef<LocalVariables>().Instruction_3, width: startFrame.GetLocalsRef<LocalVariables>().Instruction_4, image_size: startFrame.GetLocalsRef<LocalVariables>().Instruction_6, pImage: startFrame.GetLocalsRef<LocalVariables>().Instruction_7, idat_ofs: idat_ofs, idat_len: idat_len);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_;
				if (startFrame.GetLocalsRef<LocalVariables>().Instruction_10 != 0)
				{
					int instruction_2 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = instruction_2;
				}
				else
				{
					long num = (long)(uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4) * (long)(uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3);
					int instruction_3 = startFrame.GetLocalsRef<LocalVariables>().Instruction_1;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_11 = num * (uint)instruction_3;
					if ((ulong)startFrame.GetLocalsRef<LocalVariables>().Instruction_11 > 4294967295uL)
					{
						startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 6;
					}
					else
					{
						resize_wwmwtsa.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_5, startFrame.GetLocalsRef<LocalVariables>().Instruction_11);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						void* instruction_4 = startFrame.GetLocalsRef<LocalVariables>().Instruction_7;
						int instruction_5 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = (byte*)instruction_4 + (uint)instruction_5 + 8L;
						long num2 = (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_6;
						int instruction_6 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_13 = (int)(num2 - ((long)(uint)instruction_6 + 8L));
						if (startFrame.GetLocalsRef<LocalVariables>().Instruction_1 == 3)
						{
							if (*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 == 3)
							{
								bool flag = fpng_pixel_zlib_decompress_3_prmnnjb.Invoke(h: *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3, w: *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4, pDst: data_efhnzgd.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_5), zlib_len: startFrame.GetLocalsRef<LocalVariables>().Instruction_9, src_len: startFrame.GetLocalsRef<LocalVariables>().Instruction_13, pSrc: startFrame.GetLocalsRef<LocalVariables>().Instruction_12);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								startFrame.GetLocalsRef<LocalVariables>().Instruction_14 = (flag ? ((sbyte)1) : ((sbyte)0));
							}
							else
							{
								bool flag2 = fpng_pixel_zlib_decompress_4_xygi9td.Invoke(h: *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3, w: *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4, pDst: data_efhnzgd.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_5), zlib_len: startFrame.GetLocalsRef<LocalVariables>().Instruction_9, src_len: startFrame.GetLocalsRef<LocalVariables>().Instruction_13, pSrc: startFrame.GetLocalsRef<LocalVariables>().Instruction_12);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								startFrame.GetLocalsRef<LocalVariables>().Instruction_14 = (flag2 ? ((sbyte)1) : ((sbyte)0));
							}
						}
						else if (*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 == 3)
						{
							bool flag3 = fpng_pixel_zlib_decompress_3_yffw42c.Invoke(h: *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3, w: *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4, pDst: data_efhnzgd.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_5), zlib_len: startFrame.GetLocalsRef<LocalVariables>().Instruction_9, src_len: startFrame.GetLocalsRef<LocalVariables>().Instruction_13, pSrc: startFrame.GetLocalsRef<LocalVariables>().Instruction_12);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							startFrame.GetLocalsRef<LocalVariables>().Instruction_14 = (flag3 ? ((sbyte)1) : ((sbyte)0));
						}
						else
						{
							bool flag4 = fpng_pixel_zlib_decompress_4_amptoaa.Invoke(h: *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3, w: *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4, pDst: data_efhnzgd.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_5), zlib_len: startFrame.GetLocalsRef<LocalVariables>().Instruction_9, src_len: startFrame.GetLocalsRef<LocalVariables>().Instruction_13, pSrc: startFrame.GetLocalsRef<LocalVariables>().Instruction_12);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							startFrame.GetLocalsRef<LocalVariables>().Instruction_14 = (flag4 ? ((sbyte)1) : ((sbyte)0));
						}
						if ((startFrame.GetLocalsRef<LocalVariables>().Instruction_14 & 1) != 1)
						{
							startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 1;
						}
						else
						{
							startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = 0;
						}
					}
				}
			}
			int instruction_7 = startFrame.GetLocalsRef<LocalVariables>().Instruction_0;
			StackFrameList.Current.Clear(startFrame);
			return instruction_7;
		}
	}
}
