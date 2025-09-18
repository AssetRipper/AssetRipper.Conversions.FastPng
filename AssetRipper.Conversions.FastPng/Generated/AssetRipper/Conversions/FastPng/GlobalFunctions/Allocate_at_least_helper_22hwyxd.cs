using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Allocate_at_least_helper@V?$allocator@I@std@@@std@@YAPEAIAEAV?$allocator@I@0@AEA_K@Z")]
[DemangledName("unsigned int * __cdecl std::_Allocate_at_least_helper<class std::allocator<unsigned int>>(class std::allocator<unsigned int> &, unsigned __int64 &)")]
[CleanName("Allocate_at_least_helper")]
internal static partial class Allocate_at_least_helper_22hwyxd
{
	[return: NativeType("unsigned int *")]
	public unsafe static void* Invoke([MangledName("_Al")][NativeType("class std::allocator<unsigned int> &")] void* Al, [MangledName("_Count")][NativeType("unsigned __int64 &")] void* Count)
	{
		void* result = allocate_wor4ptd.Invoke(Al, *unchecked((long*)Count));
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return result;
	}
}
