using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?max_size@?$vector@_KV?$allocator@_K@std@@@std@@QEBA_KXZ")]
[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::max_size(void) const")]
[CleanName("max_size")]
internal static partial class max_size_kyvxnnb
{
	public unsafe static long Invoke(void* @this)
	{
		long num = max_size_ngjedfc.Invoke(Getal_2reycsb.Invoke(@this));
		long num2 = Max_limit.Invoke();
		return *unchecked((long*)min.Invoke(&num2, &num));
	}
}
