using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??A?$vector@_KV?$allocator@_K@std@@@std@@QEAAAEA_K_K@Z")]
[DemangledName("public: unsigned __int64 & __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::operator[](unsigned __int64)")]
internal static partial class vector_unsigned_int64_class_std_allocator_unsigned_int64_Index
{
	[return: NativeType("unsigned __int64 &")]
	public unsafe static void* Invoke(void* @this, [MangledName("_Pos")][NativeType("unsigned __int64")] long Pos)
	{
		return unchecked((byte*)((std_vector_mvt3mha*)@this)->Mypair.Myval2.Myfirst + (nint)Pos * 8);
	}
}
