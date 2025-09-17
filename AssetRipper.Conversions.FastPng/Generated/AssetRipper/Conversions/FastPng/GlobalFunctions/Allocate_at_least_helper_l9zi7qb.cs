using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Allocate_at_least_helper@V?$allocator@_K@std@@@std@@YAPEA_KAEAV?$allocator@_K@0@AEA_K@Z")]
[DemangledName("unsigned __int64 * __cdecl std::_Allocate_at_least_helper<class std::allocator<unsigned __int64>>(class std::allocator<unsigned __int64> &, unsigned __int64 &)")]
[CleanName("Allocate_at_least_helper")]
internal static partial class Allocate_at_least_helper_l9zi7qb
{
	public unsafe static void* Invoke(void* Al, void* Count)
	{
		void* result = allocate_4vpkydd.Invoke(Al, *unchecked((long*)Count));
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return result;
	}
}
