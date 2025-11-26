using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Get_proxy_allocator@V?$allocator@E@std@@@std@@YA?AU_Fake_allocator@0@AEBV?$allocator@E@0@@Z")]
[DemangledName("struct std::_Fake_allocator __cdecl std::_Get_proxy_allocator<class std::allocator<unsigned char>>(class std::allocator<unsigned char> const &)")]
[CleanName("Get_proxy_allocator")]
internal static partial class Get_proxy_allocator_gq86h4
{
	[return: NativeType("struct std::_Fake_allocator")]
	public unsafe static sbyte Invoke([NativeType("class std::allocator<unsigned char> const &")] void* parameter_0)
	{
		return default(std_Fake_allocator).field_0;
	}
}
