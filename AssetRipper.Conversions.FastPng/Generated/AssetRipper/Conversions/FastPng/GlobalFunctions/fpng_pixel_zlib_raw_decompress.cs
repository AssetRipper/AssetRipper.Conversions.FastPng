using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?fpng_pixel_zlib_raw_decompress@fpng@@YA_NPEBEIIPEAEIIII@Z")]
[DemangledName("bool __cdecl fpng::fpng_pixel_zlib_raw_decompress(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int, unsigned int, unsigned int, unsigned int)")]
internal static partial class fpng_pixel_zlib_raw_decompress
{
	public unsafe static bool Invoke(void* pSrc, int src_len, int zlib_len, void* pDst, int w, int h, int src_chans, int dst_chans)
	{
		bool flag = false;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		sbyte b = 0;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		int num11 = 0;
		int num12 = 0;
		int num13;
		switch (src_chans)
		{
		case 3:
			num13 = -1;
			break;
		case 4:
			num13 = -1;
			break;
		default:
			wassert.Invoke(String_zixkhbc.__pointer, String_uxbkrtb.__pointer, 2112);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			num13 = 0;
			break;
		}
		int num14;
		switch (dst_chans)
		{
		case 3:
			num14 = -1;
			break;
		case 4:
			num14 = -1;
			break;
		default:
			wassert.Invoke(String_kppxlqc.__pointer, String_uxbkrtb.__pointer, 2113);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			num14 = 0;
			break;
		}
		unchecked
		{
			num = w * src_chans;
			num3 = w * dst_chans * h;
			num4 = 2;
			num5 = 0;
			num6 = 0;
			num7 = 0;
			do
			{
				if ((uint)(num4 + 1) > (uint)src_len)
				{
					return false;
				}
				b = ((((byte)((sbyte*)pSrc)[(uint)num4] & 1) != 0) ? ((sbyte)1) : ((sbyte)0));
				if ((((byte)((sbyte*)pSrc)[(uint)num4] >> 1) & 3) != 0)
				{
					return false;
				}
				num4++;
				if ((uint)(num4 + 4) > (uint)src_len)
				{
					return false;
				}
				num9 = (byte)((sbyte*)pSrc)[(uint)(num4 + 0)] | ((byte)((sbyte*)pSrc)[(uint)(num4 + 1)] << 8);
				num10 = (byte)((sbyte*)pSrc)[(uint)(num4 + 2)] | ((byte)((sbyte*)pSrc)[(uint)(num4 + 3)] << 8);
				num4 += 4;
				if (num9 != ((num10 ^ -1) & 0xFFFF))
				{
					return false;
				}
				if ((uint)(num4 + num9) > (uint)src_len)
				{
					return false;
				}
				for (num11 = 0; (uint)num11 < (uint)num9; num11++)
				{
					num12 = (byte)((sbyte*)pSrc)[(uint)(num4 + num11)];
					if (num6 == 0)
					{
						if (num12 != 0)
						{
							return false;
						}
						int num15;
						if (num7 == 0)
						{
							num15 = -1;
						}
						else
						{
							wassert.Invoke(String_ji2h3xd.__pointer, String_uxbkrtb.__pointer, 2160);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							num15 = 0;
						}
					}
					else
					{
						if ((uint)num7 < (uint)dst_chans)
						{
							if (num5 == num3)
							{
								return false;
							}
							((sbyte*)pDst)[(uint)num5++] = (sbyte)num12;
						}
						int num16 = num7 + 1;
						num7 = num16;
						if (num16 == src_chans)
						{
							if ((uint)dst_chans > (uint)src_chans)
							{
								if (num5 == num3)
								{
									return false;
								}
								((sbyte*)pDst)[(uint)num5++] = -1;
							}
							num7 = 0;
						}
					}
					int num17 = num6 + 1;
					num6 = num17;
					if (num17 != num + 1)
					{
						continue;
					}
					int num18;
					if (num7 == 0)
					{
						num18 = -1;
					}
					else
					{
						wassert.Invoke(String_ji2h3xd.__pointer, String_uxbkrtb.__pointer, 2188);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						num18 = 0;
					}
					num6 = 0;
				}
				num4 += num9;
			}
			while ((b & 1) != 1);
			if (num7 != 0)
			{
				return false;
			}
			if (num4 + 4 != zlib_len)
			{
				return false;
			}
			return num5 == num3;
		}
	}
}
