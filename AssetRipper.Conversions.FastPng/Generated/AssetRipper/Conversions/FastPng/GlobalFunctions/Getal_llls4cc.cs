using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Getal@?$vector@EV?$allocator@E@std@@@std@@AEBAAEBV?$allocator@E@2@XZ")]
[DemangledName("private: class std::allocator<unsigned char> const & __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Getal(void) const")]
[CleanName("Getal")]
internal static partial class Getal_llls4cc
{
	[return: NativeType("class std::allocator<unsigned char> const &")]
	public unsafe static void* Invoke(void* @this)
	{
		return Get_first_pnsruja.Invoke(&unchecked((std_vector_7uge3hb*)@this)->Mypair);
	}
}
