using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_To_address@PEAE@std@@YA?A_PAEBQEAE@Z")]
[DemangledName("auto __cdecl std::_To_address<unsigned char *>(unsigned char *const &)")]
[CleanName("To_address")]
internal static partial class To_address_e887gk
{
	[return: NativeType("auto")]
	public unsafe static void* Invoke([MangledName("_Val")][NativeType("unsigned char *const &")] void* Val)
	{
		return *unchecked((void**)Val);
	}
}
