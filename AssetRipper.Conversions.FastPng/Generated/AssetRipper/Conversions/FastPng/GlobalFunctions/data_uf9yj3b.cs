using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?data@?$vector@IV?$allocator@I@std@@@std@@QEAAPEAIXZ")]
[DemangledName("public: unsigned int * __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::data(void)")]
[CleanName("data")]
internal static partial class data_uf9yj3b
{
	[return: NativeType("unsigned int *")]
	public unsafe static void* Invoke(void* @this)
	{
		return Unfancy_maybe_null_ys5czvb.Invoke(unchecked((std_vector_drook9b*)@this)->field_0.field_0.field_0);
	}
}
