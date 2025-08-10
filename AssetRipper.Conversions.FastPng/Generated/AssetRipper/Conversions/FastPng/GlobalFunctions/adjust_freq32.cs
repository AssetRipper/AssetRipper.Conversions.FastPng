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
		unchecked
		{
			for (int i = 0; (uint)i < (uint)num_freq; i++)
			{
				num += ((int*)pFreq)[(uint)i];
			}
			if (num == 0)
			{
				llvm_memset_p0_i64.Invoke(pFreq16, 0, (long)(uint)num_freq * 2L, isVolatile: false);
				return;
			}
			int num2 = 0;
			for (int j = 0; (uint)j < (uint)num_freq; j++)
			{
				long num3 = (uint)((int*)pFreq)[(uint)j];
				if (num3 == 0L)
				{
					((short*)pFreq16)[(uint)j] = 0;
					continue;
				}
				((short*)pFreq16)[(uint)j] = (short)maximum_y5wzmwb.Invoke(1, (int)((ulong)(num3 * 65535L) / (ulong)(uint)num));
				num2 += (ushort)((short*)pFreq16)[(uint)j];
			}
			while ((uint)num2 > 65535u)
			{
				num2 = 0;
				for (int k = 0; (uint)k < (uint)num_freq; k++)
				{
					if (((int*)pFreq)[(uint)k] != 0)
					{
						((int*)pFreq)[(uint)k] = maximum_y5wzmwb.Invoke(1, ((int*)pFreq)[(uint)k] >>> 1);
						num2 += ((int*)pFreq)[(uint)k];
					}
				}
			}
		}
	}
}
