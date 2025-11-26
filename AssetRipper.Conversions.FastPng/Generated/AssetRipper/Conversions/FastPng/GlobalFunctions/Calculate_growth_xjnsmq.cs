using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Calculate_growth@?$vector@EV?$allocator@E@std@@@std@@AEBA_K_K@Z")]
[DemangledName("private: unsigned __int64 __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Calculate_growth(unsigned __int64) const")]
[CleanName("Calculate_growth")]
internal static partial class Calculate_growth_xjnsmq
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke(void* @this, [MangledName("_Newsize")][NativeType("unsigned __int64")] long Newsize)
	{
		long num = capacity_zpcf72.Invoke(@this);
		long num2 = max_size_zqnixi.Invoke(@this);
		unchecked
		{
			if ((ulong)num > (ulong)(num2 - (long)((ulong)num / 2uL)))
			{
				return num2;
			}
			long num3 = num + (long)((ulong)num / 2uL);
			if ((ulong)num3 < (ulong)Newsize)
			{
				return Newsize;
			}
			return num3;
		}
	}
}
