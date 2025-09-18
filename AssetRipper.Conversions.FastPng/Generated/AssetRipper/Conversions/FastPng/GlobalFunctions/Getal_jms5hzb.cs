using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Getal@?$vector@EV?$allocator@E@std@@@std@@AEAAAEAV?$allocator@E@2@XZ")]
[DemangledName("private: class std::allocator<unsigned char> & __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Getal(void)")]
[CleanName("Getal")]
internal static partial class Getal_jms5hzb
{
	[return: NativeType("class std::allocator<unsigned char> &")]
	public unsafe static void* Invoke(void* @this)
	{
		return Get_first_nkl7psd.Invoke(&unchecked((std_vector*)@this)->field_0);
	}
}
