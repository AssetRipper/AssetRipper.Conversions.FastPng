using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?data@?$vector@EV?$allocator@E@std@@@std@@QEAAPEAEXZ")]
[DemangledName("public: unsigned char * __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::data(void)")]
[CleanName("data")]
internal static partial class data_efhnzgd
{
	[return: NativeType("unsigned char *")]
	public unsafe static void* Invoke(void* @this)
	{
		return Unfancy_maybe_null_pj5f7cb.Invoke(unchecked((std_vector_7uge3hb*)@this)->Mypair.Myval2.Myfirst);
	}
}
