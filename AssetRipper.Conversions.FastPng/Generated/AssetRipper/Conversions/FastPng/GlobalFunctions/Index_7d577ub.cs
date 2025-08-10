using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??A?$vector@_KV?$allocator@_K@std@@@std@@QEAAAEA_K_K@Z")]
[DemangledName("public: unsigned __int64 & __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::operator[](unsigned __int64)")]
[CleanName("Index")]
internal static partial class Index_7d577ub
{
	public unsafe static void* Invoke(void* @this, long Pos)
	{
		return unchecked((byte*)((std_vector_5*)@this)->field_0.field_0.field_0 + (nint)Pos * 8);
	}
}
