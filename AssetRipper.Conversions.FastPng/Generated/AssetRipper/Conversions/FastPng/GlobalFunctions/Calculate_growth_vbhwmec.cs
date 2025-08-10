using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Calculate_growth@?$vector@_KV?$allocator@_K@std@@@std@@AEBA_K_K@Z")]
[DemangledName("private: unsigned __int64 __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Calculate_growth(unsigned __int64) const")]
[CleanName("Calculate_growth")]
internal static partial class Calculate_growth_vbhwmec
{
	public unsafe static long Invoke(void* @this, long Newsize)
	{
		long num = capacity_f49yk4c.Invoke(@this);
		long num2 = max_size_kyvxnnb.Invoke(@this);
		unchecked
		{
			long result;
			if ((ulong)num > (ulong)(num2 - (long)((ulong)num / 2uL)))
			{
				result = num2;
			}
			else
			{
				long num3 = num + (long)((ulong)num / 2uL);
				result = (((ulong)num3 >= (ulong)Newsize) ? num3 : Newsize);
			}
			return result;
		}
	}
}
