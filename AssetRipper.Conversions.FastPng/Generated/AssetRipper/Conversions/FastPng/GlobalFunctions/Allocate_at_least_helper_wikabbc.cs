using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Allocate_at_least_helper@V?$allocator@E@std@@@std@@YAPEAEAEAV?$allocator@E@0@AEA_K@Z")]
[DemangledName("unsigned char * __cdecl std::_Allocate_at_least_helper<class std::allocator<unsigned char>>(class std::allocator<unsigned char> &, unsigned __int64 &)")]
[CleanName("Allocate_at_least_helper")]
internal static partial class Allocate_at_least_helper_wikabbc
{
	public unsafe static void* Invoke(void* Al, void* Count)
	{
		void* result = allocate_qfop4bd.Invoke(Al, *unchecked((long*)Count));
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return result;
	}
}
