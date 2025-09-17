using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??A?$vector@EV?$allocator@E@std@@@std@@QEAAAEAE_K@Z")]
[DemangledName("public: unsigned char & __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::operator[](unsigned __int64)")]
internal static partial class vector_unsigned_char_class_std_allocator_unsigned_char_Index
{
	public unsafe static void* Invoke(void* @this, long Pos)
	{
		return unchecked((byte*)((std_vector*)@this)->field_0.field_0.field_0) + Pos;
	}
}
