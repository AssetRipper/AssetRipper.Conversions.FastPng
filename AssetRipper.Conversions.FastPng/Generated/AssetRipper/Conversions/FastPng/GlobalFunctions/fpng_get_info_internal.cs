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
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(InlineArray5_SByte);
		unchecked
		{
			int num;
			if (!endian_check.Invoke())
			{
				wassert.Invoke(String_v852r7.__pointer, String_ksmiy6.__pointer, 2936);
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
					void* ptr = (byte*)pImage + 8;
					void* ptr2 = ptr;
					ptr = (byte*)ptr + 25;
					if (swap32.Invoke(((fpng_png_ihdr*)ptr2)->m_prefix.m_length) != 13)
					{
						num = 3;
					}
					else if (fpng_crc32.Invoke(&((fpng_png_ihdr*)ptr2)->m_prefix.m_type, 17L, 0) != swap32.Invoke(((fpng_png_ihdr*)ptr2)->m_crc32))
					{
						num = 4;
					}
					else
					{
						*(int*)width = swap32.Invoke(((fpng_png_ihdr*)ptr2)->m_width);
						*(int*)height = swap32.Invoke(((fpng_png_ihdr*)ptr2)->m_height);
						if (*(int*)width == 0 || *(int*)height == 0 || (uint)(*(int*)width) > 16777216u || (uint)(*(int*)height) > 16777216u)
						{
							num = 5;
						}
						else if ((ulong)((long)(uint)(*(int*)width) * (long)(uint)(*(int*)height)) > 1073741824uL)
						{
							num = 5;
						}
						else if (((fpng_png_ihdr*)ptr2)->m_comp_method != 0 || ((fpng_png_ihdr*)ptr2)->m_filter_method != 0 || ((fpng_png_ihdr*)ptr2)->m_interlace_method != 0 || (byte)((fpng_png_ihdr*)ptr2)->m_bitdepth != 8)
						{
							num = 1;
						}
						else
						{
							if ((byte)((fpng_png_ihdr*)ptr2)->m_color_type == 2)
							{
								*(int*)channels_in_file = 3;
							}
							else if ((byte)((fpng_png_ihdr*)ptr2)->m_color_type == 6)
							{
								*(int*)channels_in_file = 4;
							}
							if (*(int*)channels_in_file == 0)
							{
								num = 1;
							}
							else
							{
								sbyte b = 0;
								while (true)
								{
									long num2 = (long)ptr - (long)pImage;
									if ((ulong)num2 >= (ulong)(uint)image_size)
									{
										num = 7;
										break;
									}
									if ((ulong)(uint)(image_size - (int)num2) < 12uL)
									{
										num = 7;
										break;
									}
									void* ptr3 = ptr;
									int num3 = swap32.Invoke(((fpng_png_chunk_prefix*)ptr3)->m_length);
									if ((ulong)(num2 + 8L + (uint)num3 + 4L) > (ulong)(uint)image_size)
									{
										num = 7;
										break;
									}
									int num4 = 0;
									while ((uint)num4 < 4u)
									{
										sbyte b2 = ((sbyte*)(&((fpng_png_chunk_prefix*)ptr3)->m_type))[(uint)num4];
										sbyte b3 = (((byte)b2 >= 65 && (byte)b2 <= 90) ? ((sbyte)1) : ((sbyte)0));
										sbyte b4 = (((byte)b2 >= 97 && (byte)b2 <= 122) ? ((sbyte)1) : ((sbyte)0));
										if ((b3 & 1) != 1 && (b4 & 1) != 1)
										{
											goto IL_036a;
										}
										num4++;
									}
									int num5 = swap32.Invoke(*(int*)((byte*)ptr + 8 + (uint)num3));
									sbyte type = *(sbyte*)(&((fpng_png_chunk_prefix*)ptr3)->m_type);
									*(sbyte*)(&localsPointer->field_0) = type;
									((sbyte*)(&localsPointer->field_0))[1] = ((sbyte*)(&((fpng_png_chunk_prefix*)ptr3)->m_type))[1];
									((sbyte*)(&localsPointer->field_0))[2] = ((sbyte*)(&((fpng_png_chunk_prefix*)ptr3)->m_type))[2];
									((sbyte*)(&localsPointer->field_0))[3] = ((sbyte*)(&((fpng_png_chunk_prefix*)ptr3)->m_type))[3];
									((sbyte*)(&localsPointer->field_0))[4] = 0;
									sbyte b5 = ((strcmp.Invoke(&localsPointer->field_0, String_zkjij9.__pointer) == 0) ? ((sbyte)1) : ((sbyte)0));
									if ((b5 & 1) != 1 && fpng_crc32.Invoke((byte*)ptr + 4, 4L + (long)(uint)num3, 0) != num5)
									{
										num = 4;
										break;
									}
									void* ptr4 = (byte*)ptr + 8;
									if (strcmp.Invoke(&localsPointer->field_0, String_tnwibv.__pointer) != 0)
									{
										if ((b5 & 1) == 1)
										{
											if (*(int*)idat_ofs != 0 || (b & 1) != 1)
											{
												num = 1;
												break;
											}
											*(int*)idat_ofs = (int)num2;
											*(int*)idat_len = num3;
											if ((uint)(*(int*)idat_len) < 7u)
											{
												num = 8;
												break;
											}
										}
										else if (strcmp.Invoke(&localsPointer->field_0, String_rgccyn.__pointer) == 0)
										{
											if ((b & 1) == 1)
											{
												num = 1;
												break;
											}
											if (num3 != 5)
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
										else if ((*(sbyte*)(&localsPointer->field_0) & 0x20) == 0)
										{
											num = 1;
											break;
										}
										ptr = (byte*)ptr + (8L + (long)(uint)num3 + 4L);
										continue;
									}
									num = (((b & 1) != 1 || *(int*)idat_ofs == 0) ? 1 : 0);
									break;
									IL_036a:
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
