using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?adjust_freq32@fpng@@YAXIPEAIPEAG@Z")]
[DemangledName("void __cdecl fpng::adjust_freq32(unsigned int, unsigned int *, unsigned short *)")]
internal static partial class adjust_freq32
{
	public unsafe static void Invoke(int num_freq, void* pFreq, void* pFreq16)
	{
		int num = 0;
		int num2 = 0;
		long num3 = 0L;
		int num4 = 0;
		int num5 = 0;
		unchecked
		{
			for (int i = 0; (uint)i < (uint)num_freq; i++)
			{
				num5 += ((int*)pFreq)[(uint)i];
			}
			if (num5 == 0)
			{
				llvm_memset_p0_i64.Invoke(pFreq16, 0, (long)(uint)num_freq * 2L, isVolatile: false);
				return;
			}
			num = 0;
			for (num2 = 0; (uint)num2 < (uint)num_freq; num2++)
			{
				num3 = (uint)((int*)pFreq)[(uint)num2];
				if (num3 == 0L)
				{
					((short*)pFreq16)[(uint)num2] = 0;
					continue;
				}
				((short*)pFreq16)[(uint)num2] = (short)maximum_y5wzmwb.Invoke(1, (int)((ulong)(num3 * 65535L) / (ulong)(uint)num5));
				num += (ushort)((short*)pFreq16)[(uint)num2];
			}
			while ((uint)num > 65535u)
			{
				num = 0;
				for (num4 = 0; (uint)num4 < (uint)num_freq; num4++)
				{
					if (((int*)pFreq)[(uint)num4] != 0)
					{
						((int*)pFreq)[(uint)num4] = maximum_y5wzmwb.Invoke(1, ((int*)pFreq)[(uint)num4] >>> 1);
						num += ((int*)pFreq)[(uint)num4];
					}
				}
			}
		}
	}
}
