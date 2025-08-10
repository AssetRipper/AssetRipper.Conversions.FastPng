using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?write_raw_block@fpng@@YAIPEBEIPEAEI@Z")]
[DemangledName("unsigned int __cdecl fpng::write_raw_block(unsigned char const *, unsigned int, unsigned char *, unsigned int)")]
internal static partial class write_raw_block
{
	public unsafe static int Invoke(void* pSrc, int src_len, void* pDst, int dst_buf_size)
	{
		unchecked
		{
			int result;
			if ((uint)dst_buf_size < 2u)
			{
				result = 0;
			}
			else
			{
				*(sbyte*)pDst = 120;
				((sbyte*)pDst)[1L] = 1;
				int num = 2;
				int num2 = 0;
				while (true)
				{
					if ((uint)num2 < (uint)src_len)
					{
						int num3 = src_len - num2;
						int num4 = minimum_su2nfub.Invoke(65535, num3);
						sbyte b = ((num4 == num3) ? ((sbyte)1) : ((sbyte)0));
						if ((uint)(num + 5 + num4) > (uint)dst_buf_size)
						{
							result = 0;
							break;
						}
						bool flag = (b & 1) == 1;
						_ = flag;
						((sbyte*)pDst)[(uint)(num + 0)] = (sbyte)(flag ? 1 : 0);
						((sbyte*)pDst)[(uint)(num + 1)] = (sbyte)(num4 & 0xFF);
						((sbyte*)pDst)[(uint)(num + 2)] = (sbyte)((num4 >>> 8) & 0xFF);
						((sbyte*)pDst)[(uint)(num + 3)] = (sbyte)((num4 ^ -1) & 0xFF);
						((sbyte*)pDst)[(uint)(num + 4)] = (sbyte)(((num4 ^ -1) >>> 8) & 0xFF);
						llvm_memcpy_p0_p0_i64.Invoke((byte*)pDst + (uint)num + 5L, (byte*)pSrc + (uint)num2, (uint)num4, isVolatile: false);
						num2 += num4;
						num += 5 + num4;
						continue;
					}
					int num5 = fpng_adler32.Invoke(pSrc, (uint)src_len, 1);
					int num6 = 0;
					while (true)
					{
						if ((uint)num6 < 4u)
						{
							if ((uint)(num + 1) > (uint)dst_buf_size)
							{
								result = 0;
								break;
							}
							((sbyte*)pDst)[(uint)num] = (sbyte)(num5 >>> 24);
							num++;
							num5 <<= 8;
							num6++;
							continue;
						}
						result = num;
						break;
					}
					break;
				}
			}
			return result;
		}
	}
}
