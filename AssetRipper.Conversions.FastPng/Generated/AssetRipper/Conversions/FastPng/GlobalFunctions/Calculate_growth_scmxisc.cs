using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Calculate_growth@?$vector@EV?$allocator@E@std@@@std@@AEBA_K_K@Z")]
[DemangledName("private: unsigned __int64 __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Calculate_growth(unsigned __int64) const")]
[CleanName("Calculate_growth")]
internal static partial class Calculate_growth_scmxisc
{
	public unsafe static long Invoke(void* @this, long Newsize)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = capacity_mz5ysja.Invoke(@this);
		long num4 = max_size_2yjes5b.Invoke(@this);
		unchecked
		{
			if ((ulong)num3 > (ulong)(num4 - (long)((ulong)num3 / 2uL)))
			{
				return num4;
			}
			num2 = num3 + (long)((ulong)num3 / 2uL);
			if ((ulong)num2 < (ulong)Newsize)
			{
				return Newsize;
			}
			return num2;
		}
	}
}
