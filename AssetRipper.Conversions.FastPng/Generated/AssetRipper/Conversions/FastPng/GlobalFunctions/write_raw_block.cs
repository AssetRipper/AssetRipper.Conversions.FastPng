using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?write_raw_block@fpng@@YAIPEBEIPEAEI@Z")]
[DemangledName("unsigned int __cdecl fpng::write_raw_block(unsigned char const *, unsigned int, unsigned char *, unsigned int)")]
internal static partial class write_raw_block
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("unsigned char const *")] void* pSrc, [NativeType("unsigned int")] int src_len, [NativeType("unsigned char *")] void* pDst, [NativeType("unsigned int")] int dst_buf_size)
	{
		unchecked
		{
			if ((uint)dst_buf_size < 2u)
			{
				return 0;
			}
			*(sbyte*)pDst = 120;
			((sbyte*)pDst)[1] = 1;
			int num = 2;
			int num2 = 0;
			while ((uint)num2 < (uint)src_len)
			{
				int num3 = src_len - num2;
				int num4 = minimum_sh5ug2.Invoke(65535, num3);
				sbyte b = ((num4 == num3) ? ((sbyte)1) : ((sbyte)0));
				if ((uint)(num + 5 + num4) > (uint)dst_buf_size)
				{
					return 0;
				}
				((sbyte*)pDst)[(uint)(num + 0)] = (sbyte)InstructionHelper.Select((b & 1) == 1, 1, 0);
				((sbyte*)pDst)[(uint)(num + 1)] = (sbyte)(num4 & 0xFF);
				((sbyte*)pDst)[(uint)(num + 2)] = (sbyte)((num4 >>> 8) & 0xFF);
				((sbyte*)pDst)[(uint)(num + 3)] = (sbyte)((num4 ^ -1) & 0xFF);
				((sbyte*)pDst)[(uint)(num + 4)] = (sbyte)(((num4 ^ -1) >>> 8) & 0xFF);
				llvm_memcpy_p0_p0_i64.Invoke((byte*)pDst + (uint)num + 5, (byte*)pSrc + (uint)num2, (uint)num4, isVolatile: false);
				num2 += num4;
				num += 5 + num4;
			}
			int num5 = fpng_adler32.Invoke(pSrc, (uint)src_len, 1);
			for (int i = 0; (uint)i < 4u; i++)
			{
				if ((uint)(num + 1) > (uint)dst_buf_size)
				{
					return 0;
				}
				((sbyte*)pDst)[(uint)num] = (sbyte)(num5 >>> 24);
				num++;
				num5 <<= 8;
			}
			return num;
		}
	}
}
