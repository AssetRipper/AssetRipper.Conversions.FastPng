using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?max_size@?$vector@EV?$allocator@E@std@@@std@@QEBA_KXZ")]
[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::max_size(void) const")]
[CleanName("max_size")]
internal static partial class max_size_2yjes5b
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke(void* @this)
	{
		long num = max_size_hv9dl3d.Invoke(Getal_llls4cc.Invoke(@this));
		long num2 = Max_limit.Invoke();
		return *unchecked((long*)min.Invoke(&num2, &num));
	}
}
