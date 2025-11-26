using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Getal@?$vector@EV?$allocator@E@std@@@std@@AEAAAEAV?$allocator@E@2@XZ")]
[DemangledName("private: class std::allocator<unsigned char> & __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Getal(void)")]
[CleanName("Getal")]
internal static partial class Getal_vpqbcr
{
	[return: NativeType("class std::allocator<unsigned char> &")]
	public unsafe static void* Invoke(void* @this)
	{
		return Get_first_2rs8wq.Invoke(&unchecked((std_vector_4tqn2f*)@this)->Mypair);
	}
}
