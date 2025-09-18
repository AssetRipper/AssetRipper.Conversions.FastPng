using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Get_proxy_allocator@V?$allocator@_K@std@@@std@@YA?AU_Fake_allocator@0@AEBV?$allocator@_K@0@@Z")]
[DemangledName("struct std::_Fake_allocator __cdecl std::_Get_proxy_allocator<class std::allocator<unsigned __int64>>(class std::allocator<unsigned __int64> const &)")]
[CleanName("Get_proxy_allocator")]
internal static partial class Get_proxy_allocator_9e3ilvb
{
	[return: NativeType("struct std::_Fake_allocator")]
	public unsafe static sbyte Invoke([NativeType("class std::allocator<unsigned __int64> const &")] void* parameter_0)
	{
		return default(std_Fake_allocator).field_0;
	}
}
