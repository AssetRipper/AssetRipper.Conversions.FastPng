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
		public InlineArray5_SByte field_0;
	}

	[return: NativeType("int")]
	public unsafe static int Invoke([NativeType("void const *")] void* pImage, [NativeType("unsigned int")] int image_size, [NativeType("unsigned int &")] void* width, [NativeType("unsigned int &")] void* height, [NativeType("unsigned int &")] void* channels_in_file, [NativeType("unsigned int &")] void* idat_ofs, [NativeType("unsigned int &")] void* idat_len)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		int num = 0;
		void* ptr = null;
		void* ptr2 = null;
		long num2 = 0L;
		sbyte b = 0;
		long num3 = 0L;
		int num4 = 0;
		void* ptr3 = null;
		int num5 = 0;
		int num6 = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		sbyte b4 = 0;
		int num7 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = default(InlineArray5_SByte);
		sbyte b5 = 0;
		int num8 = 0;
		void* ptr4 = null;
		unchecked
		{
			if (!endian_check.Invoke())
			{
				wassert.Invoke(String_kdrammb.__pointer, String_uxbkrtb.__pointer, 2936);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				num = 0;
			}
			else
			{
				*(int*)width = 0;
				*(int*)height = 0;
				*(int*)channels_in_file = 0;
				*(int*)idat_ofs = 0;
				*(int*)idat_len = 0;
				if ((ulong)(uint)image_size < 58uL)
				{
					num = 3;
				}
				else if (memcmp.Invoke(pImage, s_png_sig.__pointer, 8L) != 0)
				{
					num = 3;
				}
				else
				{
					ptr = (byte*)pImage + 8;
					ptr2 = ptr;
					ptr = (byte*)ptr + 25;
					if (swap32.Invoke(((fpng_png_ihdr*)ptr2)->field_0.field_0) != 13)
					{
						num = 3;
					}
					else if (fpng_crc32.Invoke(&((fpng_png_ihdr*)ptr2)->field_0.field_1, 17L, 0) != swap32.Invoke(((fpng_png_ihdr*)ptr2)->field_8))
					{
						num = 4;
					}
					else
					{
						*(int*)width = swap32.Invoke(((fpng_png_ihdr*)ptr2)->field_1);
						*(int*)height = swap32.Invoke(((fpng_png_ihdr*)ptr2)->field_2);
						if (*(int*)width == 0 || *(int*)height == 0 || (uint)(*(int*)width) > 16777216u || (uint)(*(int*)height) > 16777216u)
						{
							num = 5;
						}
						else if ((ulong)((long)(uint)(*(int*)width) * (long)(uint)(*(int*)height)) > 1073741824uL)
						{
							num = 5;
						}
						else if (((fpng_png_ihdr*)ptr2)->field_5 != 0 || ((fpng_png_ihdr*)ptr2)->field_6 != 0 || ((fpng_png_ihdr*)ptr2)->field_7 != 0 || (byte)((fpng_png_ihdr*)ptr2)->field_3 != 8)
						{
							num = 1;
						}
						else
						{
							if ((byte)((fpng_png_ihdr*)ptr2)->field_4 == 2)
							{
								*(int*)channels_in_file = 3;
							}
							else if ((byte)((fpng_png_ihdr*)ptr2)->field_4 == 6)
							{
								*(int*)channels_in_file = 4;
							}
							if (*(int*)channels_in_file == 0)
							{
								num = 1;
							}
							else
							{
								b = 0;
								while (true)
								{
									num3 = (long)ptr - (long)pImage;
									if ((ulong)num3 >= (ulong)(uint)image_size)
									{
										num = 7;
										break;
									}
									if ((ulong)(uint)(image_size - (int)num3) < 12uL)
									{
										num = 7;
										break;
									}
									ptr3 = ptr;
									num5 = swap32.Invoke(((fpng_png_chunk_prefix*)ptr3)->field_0);
									if ((ulong)(num3 + 8L + (uint)num5 + 4L) > (ulong)(uint)image_size)
									{
										num = 7;
										break;
									}
									num6 = 0;
									while ((uint)num6 < 4u)
									{
										b2 = ((sbyte*)(&((fpng_png_chunk_prefix*)ptr3)->field_1))[(uint)num6];
										b3 = (((byte)b2 >= 65 && (byte)b2 <= 90) ? ((sbyte)1) : ((sbyte)0));
										b4 = (((byte)b2 >= 97 && (byte)b2 <= 122) ? ((sbyte)1) : ((sbyte)0));
										if ((b3 & 1) != 1 && (b4 & 1) != 1)
										{
											goto IL_035b;
										}
										num6++;
									}
									num7 = swap32.Invoke(*(int*)((byte*)ptr + 8 + (uint)num5));
									sbyte field_ = *(sbyte*)(&((fpng_png_chunk_prefix*)ptr3)->field_1);
									*(sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_0) = field_;
									((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_0))[1] = ((sbyte*)(&((fpng_png_chunk_prefix*)ptr3)->field_1))[1];
									((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_0))[2] = ((sbyte*)(&((fpng_png_chunk_prefix*)ptr3)->field_1))[2];
									((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_0))[3] = ((sbyte*)(&((fpng_png_chunk_prefix*)ptr3)->field_1))[3];
									((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_0))[4] = 0;
									b5 = ((strcmp.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_0, String_qjc9xdd.__pointer) == 0) ? ((sbyte)1) : ((sbyte)0));
									if ((b5 & 1) != 1 && fpng_crc32.Invoke((byte*)ptr + 4, 4L + (long)(uint)num5, 0) != num7)
									{
										num = 4;
										break;
									}
									ptr4 = (byte*)ptr + 8;
									if (strcmp.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_0, String_p7olgfc.__pointer) != 0)
									{
										if ((b5 & 1) == 1)
										{
											if (*(int*)idat_ofs != 0 || (b & 1) != 1)
											{
												num = 1;
												break;
											}
											*(int*)idat_ofs = (int)num3;
											*(int*)idat_len = num5;
											if ((uint)(*(int*)idat_len) < 7u)
											{
												num = 8;
												break;
											}
										}
										else if (strcmp.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_0, String_22lii4a.__pointer) == 0)
										{
											if ((b & 1) == 1)
											{
												num = 1;
												break;
											}
											if (num5 != 5)
											{
												num = 1;
												break;
											}
											if ((byte)(*(sbyte*)ptr4) != 82 || (byte)((sbyte*)ptr4)[1] != 36 || (byte)((sbyte*)ptr4)[2] != 147 || (byte)((sbyte*)ptr4)[3] != 227)
											{
												num = 1;
												break;
											}
											if ((byte)((sbyte*)ptr4)[4] != 0)
											{
												num = 1;
												break;
											}
											b = 1;
										}
										else if ((*(sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_0) & 0x20) == 0)
										{
											num = 1;
											break;
										}
										ptr = (byte*)ptr + (8L + (long)(uint)num5 + 4L);
										continue;
									}
									num = (((b & 1) != 1 || *(int*)idat_ofs == 0) ? 1 : 0);
									break;
									IL_035b:
									num = 7;
									break;
								}
							}
						}
					}
				}
			}
			int result = num;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
