using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Getal@?$vector@_KV?$allocator@_K@std@@@std@@AEBAAEBV?$allocator@_K@2@XZ")]
[DemangledName("private: class std::allocator<unsigned __int64> const & __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Getal(void) const")]
[CleanName("Getal")]
internal static partial class Getal_vgvjy8
{
	[return: NativeType("class std::allocator<unsigned __int64> const &")]
	public unsafe static void* Invoke(void* @this)
	{
		return Get_first_6qcwh9.Invoke(&unchecked((std_vector_ucmdxb*)@this)->Mypair);
	}
}
