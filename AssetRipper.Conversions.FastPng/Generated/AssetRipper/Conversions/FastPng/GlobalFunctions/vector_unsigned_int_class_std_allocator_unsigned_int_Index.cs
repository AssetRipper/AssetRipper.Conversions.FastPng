using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??A?$vector@IV?$allocator@I@std@@@std@@QEAAAEAI_K@Z")]
[DemangledName("public: unsigned int & __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::operator[](unsigned __int64)")]
internal static partial class vector_unsigned_int_class_std_allocator_unsigned_int_Index
{
	public unsafe static void* Invoke(void* @this, long Pos)
	{
		return unchecked((byte*)((std_vector_0*)@this)->field_0.field_0.field_0 + (nint)Pos * 4);
	}
}
