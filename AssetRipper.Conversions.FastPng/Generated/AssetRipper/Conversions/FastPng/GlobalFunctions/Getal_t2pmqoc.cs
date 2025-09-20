using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Getal@?$vector@IV?$allocator@I@std@@@std@@AEAAAEAV?$allocator@I@2@XZ")]
[DemangledName("private: class std::allocator<unsigned int> & __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::_Getal(void)")]
[CleanName("Getal")]
internal static partial class Getal_t2pmqoc
{
	[return: NativeType("class std::allocator<unsigned int> &")]
	public unsafe static void* Invoke(void* @this)
	{
		return Get_first_evhdorb.Invoke(&unchecked((std_vector_drook9b*)@this)->field_0);
	}
}
