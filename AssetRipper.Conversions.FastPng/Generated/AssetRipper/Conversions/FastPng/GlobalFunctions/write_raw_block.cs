using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?write_raw_block@fpng@@YAIPEBEIPEAEI@Z")]
[DemangledName("unsigned int __cdecl fpng::write_raw_block(unsigned char const *, unsigned int, unsigned char *, unsigned int)")]
internal static partial class write_raw_block
{
	public unsafe static int Invoke(void* pSrc, int src_len, void* pDst, int dst_buf_size)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		sbyte b = 0;
		int num6 = 0;
		int num7 = 0;
		unchecked
		{
			if ((uint)dst_buf_size < 2u)
			{
				return 0;
			}
			*(sbyte*)pDst = 120;
			((sbyte*)pDst)[1] = 1;
			num2 = 2;
			num3 = 0;
			while ((uint)num3 < (uint)src_len)
			{
				num4 = src_len - num3;
				num5 = minimum_su2nfub.Invoke(65535, num4);
				b = ((num5 == num4) ? ((sbyte)1) : ((sbyte)0));
				if ((uint)(num2 + 5 + num5) > (uint)dst_buf_size)
				{
					return 0;
				}
				bool flag = (b & 1) == 1;
				_ = flag;
				((sbyte*)pDst)[(uint)(num2 + 0)] = (sbyte)InstructionHelper.Select(flag, 1, 0);
				((sbyte*)pDst)[(uint)(num2 + 1)] = (sbyte)(num5 & 0xFF);
				((sbyte*)pDst)[(uint)(num2 + 2)] = (sbyte)((num5 >>> 8) & 0xFF);
				((sbyte*)pDst)[(uint)(num2 + 3)] = (sbyte)((num5 ^ -1) & 0xFF);
				((sbyte*)pDst)[(uint)(num2 + 4)] = (sbyte)(((num5 ^ -1) >>> 8) & 0xFF);
				llvm_memcpy_p0_p0_i64.Invoke((byte*)pDst + (uint)num2 + 5, (byte*)pSrc + (uint)num3, (uint)num5, isVolatile: false);
				num3 += num5;
				num2 += 5 + num5;
			}
			num6 = fpng_adler32.Invoke(pSrc, (uint)src_len, 1);
			for (num7 = 0; (uint)num7 < 4u; num7++)
			{
				if ((uint)(num2 + 1) > (uint)dst_buf_size)
				{
					return 0;
				}
				((sbyte*)pDst)[(uint)num2] = (sbyte)(num6 >>> 24);
				num2++;
				num6 <<= 8;
			}
			return num2;
		}
	}
}
