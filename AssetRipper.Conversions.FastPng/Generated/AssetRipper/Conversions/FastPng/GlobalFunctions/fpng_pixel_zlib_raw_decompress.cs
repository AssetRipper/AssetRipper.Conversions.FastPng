using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?fpng_pixel_zlib_raw_decompress@fpng@@YA_NPEBEIIPEAEIIII@Z")]
[DemangledName("bool __cdecl fpng::fpng_pixel_zlib_raw_decompress(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int, unsigned int, unsigned int, unsigned int)")]
internal static partial class fpng_pixel_zlib_raw_decompress
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("unsigned char const *")] void* pSrc, [NativeType("unsigned int")] int src_len, [NativeType("unsigned int")] int zlib_len, [NativeType("unsigned char *")] void* pDst, [NativeType("unsigned int")] int w, [NativeType("unsigned int")] int h, [NativeType("unsigned int")] int src_chans, [NativeType("unsigned int")] int dst_chans)
	{
		if (src_chans != 3 && src_chans != 4)
		{
			wassert.Invoke(String_uk2xnu.__pointer, String_ksmiy6.__pointer, 2112);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
		}
		if (dst_chans != 3 && dst_chans != 4)
		{
			wassert.Invoke(String_9t5ec6.__pointer, String_ksmiy6.__pointer, 2113);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
		}
		unchecked
		{
			int num = w * src_chans;
			int num2 = w * dst_chans * h;
			int num3 = 2;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			sbyte b;
			do
			{
				if ((uint)(num3 + 1) > (uint)src_len)
				{
					return false;
				}
				b = ((((byte)((sbyte*)pSrc)[(uint)num3] & 1) != 0) ? ((sbyte)1) : ((sbyte)0));
				if ((((byte)((sbyte*)pSrc)[(uint)num3] >> 1) & 3) != 0)
				{
					return false;
				}
				num3++;
				if ((uint)(num3 + 4) > (uint)src_len)
				{
					return false;
				}
				int num7 = (byte)((sbyte*)pSrc)[(uint)(num3 + 0)] | ((byte)((sbyte*)pSrc)[(uint)(num3 + 1)] << 8);
				int num8 = (byte)((sbyte*)pSrc)[(uint)(num3 + 2)] | ((byte)((sbyte*)pSrc)[(uint)(num3 + 3)] << 8);
				num3 += 4;
				if (num7 != ((num8 ^ -1) & 0xFFFF))
				{
					return false;
				}
				if ((uint)(num3 + num7) > (uint)src_len)
				{
					return false;
				}
				for (int i = 0; (uint)i < (uint)num7; i++)
				{
					int num9 = (byte)((sbyte*)pSrc)[(uint)(num3 + i)];
					if (num5 == 0)
					{
						if (num9 != 0)
						{
							return false;
						}
						if (num6 != 0)
						{
							wassert.Invoke(String_z2hmfq.__pointer, String_ksmiy6.__pointer, 2160);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
						}
					}
					else
					{
						if ((uint)num6 < (uint)dst_chans)
						{
							if (num4 == num2)
							{
								return false;
							}
							((sbyte*)pDst)[(uint)num4++] = (sbyte)num9;
						}
						int num10 = num6 + 1;
						num6 = num10;
						if (num10 == src_chans)
						{
							if ((uint)dst_chans > (uint)src_chans)
							{
								if (num4 == num2)
								{
									return false;
								}
								((sbyte*)pDst)[(uint)num4++] = -1;
							}
							num6 = 0;
						}
					}
					int num11 = num5 + 1;
					num5 = num11;
					if (num11 != num + 1)
					{
						continue;
					}
					if (num6 != 0)
					{
						wassert.Invoke(String_z2hmfq.__pointer, String_ksmiy6.__pointer, 2188);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
					}
					num5 = 0;
				}
				num3 += num7;
			}
			while ((b & 1) != 1);
			if (num6 != 0)
			{
				return false;
			}
			if (num3 + 4 != zlib_len)
			{
				return false;
			}
			return num4 == num2;
		}
	}
}
