using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Getal@?$vector@IV?$allocator@I@std@@@std@@AEBAAEBV?$allocator@I@2@XZ")]
[DemangledName("private: class std::allocator<unsigned int> const & __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::_Getal(void) const")]
[CleanName("Getal")]
internal static partial class Getal_kwpsjz
{
	[return: NativeType("class std::allocator<unsigned int> const &")]
	public unsafe static void* Invoke(void* @this)
	{
		return Get_first_djzrvk.Invoke(&unchecked((std_vector_jsyy6a*)@this)->Mypair);
	}
}
