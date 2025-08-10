using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?max_size@?$vector@IV?$allocator@I@std@@@std@@QEBA_KXZ")]
[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::max_size(void) const")]
[CleanName("max_size")]
internal static partial class max_size_qdwnpha
{
	public unsafe static long Invoke(void* @this)
	{
		long num = 0L;
		long* right = &num;
		long num2 = 0L;
		long* left = &num2;
		num = max_size_snq294b.Invoke(Getal_r5wdlvb.Invoke(@this));
		num2 = Max_limit.Invoke();
		return *unchecked((long*)min.Invoke(left, right));
	}
}
