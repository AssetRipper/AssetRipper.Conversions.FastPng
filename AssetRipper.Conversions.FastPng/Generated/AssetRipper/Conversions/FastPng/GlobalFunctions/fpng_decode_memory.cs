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
		public int field_0;

		public int field_1;
	}

	[return: NativeType("int")]
	public unsafe static int Invoke([NativeType("void const *")] void* pImage, [NativeType("unsigned int")] int image_size, [NativeType("class std::vector<unsigned char, class std::allocator<unsigned char>> &")] void* @out, [NativeType("unsigned int &")] void* width, [NativeType("unsigned int &")] void* height, [NativeType("unsigned int &")] void* channels_in_file, [NativeType("unsigned int")] int desired_channels)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		int num = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
		int num2 = 0;
		long num3 = 0L;
		void* ptr = null;
		int num4 = 0;
		sbyte b = 0;
		resize_wwmwtsa.Invoke(@out, 0L);
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		unchecked
		{
			*(int*)width = 0;
			*(int*)height = 0;
			*(int*)channels_in_file = 0;
			if (pImage == null || image_size == 0 || (desired_channels != 3 && desired_channels != 4))
			{
				wassert.Invoke(String_kdrammb.__pointer, String_uxbkrtb.__pointer, 3094);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num = 2;
			}
			else
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = 0;
				startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
				int num5 = fpng_get_info_internal.Invoke(pImage, image_size, width, height, channels_in_file, &startFrame.GetLocalsPointer<LocalVariables>()->field_0, &startFrame.GetLocalsPointer<LocalVariables>()->field_1);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num2 = num5;
				if (num2 != 0)
				{
					num = num2;
				}
				else
				{
					num3 = (long)(uint)(*(int*)width) * (long)(uint)(*(int*)height) * (uint)desired_channels;
					if ((ulong)num3 > 4294967295uL)
					{
						num = 6;
					}
					else
					{
						resize_wwmwtsa.Invoke(@out, num3);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						ptr = (byte*)pImage + (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 8;
						num4 = (int)((uint)image_size - ((long)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 8L));
						if (desired_channels == 3)
						{
							if (*(int*)channels_in_file == 3)
							{
								bool flag = fpng_pixel_zlib_decompress_3_prmnnjb.Invoke(h: *(int*)height, w: *(int*)width, pDst: data_efhnzgd.Invoke(@out), pSrc: ptr, src_len: num4, zlib_len: startFrame.GetLocalsPointer<LocalVariables>()->field_1);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								b = (flag ? ((sbyte)1) : ((sbyte)0));
							}
							else
							{
								bool flag2 = fpng_pixel_zlib_decompress_4_xygi9td.Invoke(h: *(int*)height, w: *(int*)width, pDst: data_efhnzgd.Invoke(@out), pSrc: ptr, src_len: num4, zlib_len: startFrame.GetLocalsPointer<LocalVariables>()->field_1);
								if (ExceptionInfo.Current != null)
								{
									return 0;
								}
								b = (flag2 ? ((sbyte)1) : ((sbyte)0));
							}
						}
						else if (*(int*)channels_in_file == 3)
						{
							bool flag3 = fpng_pixel_zlib_decompress_3_yffw42c.Invoke(h: *(int*)height, w: *(int*)width, pDst: data_efhnzgd.Invoke(@out), pSrc: ptr, src_len: num4, zlib_len: startFrame.GetLocalsPointer<LocalVariables>()->field_1);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							b = (flag3 ? ((sbyte)1) : ((sbyte)0));
						}
						else
						{
							bool flag4 = fpng_pixel_zlib_decompress_4_amptoaa.Invoke(h: *(int*)height, w: *(int*)width, pDst: data_efhnzgd.Invoke(@out), pSrc: ptr, src_len: num4, zlib_len: startFrame.GetLocalsPointer<LocalVariables>()->field_1);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							b = (flag4 ? ((sbyte)1) : ((sbyte)0));
						}
						num = (((b & 1) != 1) ? 1 : 0);
					}
				}
			}
			int result = num;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
