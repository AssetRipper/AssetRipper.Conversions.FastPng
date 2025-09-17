using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Calculate_growth@?$vector@_KV?$allocator@_K@std@@@std@@AEBA_K_K@Z")]
[DemangledName("private: unsigned __int64 __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Calculate_growth(unsigned __int64) const")]
[CleanName("Calculate_growth")]
internal static partial class Calculate_growth_vbhwmec
{
	public unsafe static long Invoke(void* @this, long Newsize)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = capacity_f49yk4c.Invoke(@this);
		long num4 = max_size_kyvxnnb.Invoke(@this);
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
