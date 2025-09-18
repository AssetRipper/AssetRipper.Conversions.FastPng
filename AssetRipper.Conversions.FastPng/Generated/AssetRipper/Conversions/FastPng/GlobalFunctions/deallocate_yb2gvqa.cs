using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?deallocate@?$allocator@_K@std@@QEAAXQEA_K_K@Z")]
[DemangledName("public: void __cdecl std::allocator<unsigned __int64>::deallocate(unsigned __int64 *const, unsigned __int64)")]
[CleanName("deallocate")]
internal static partial class deallocate_yb2gvqa
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [MangledName("_Ptr")][NativeType("unsigned __int64 *const")] void* Ptr, [MangledName("_Count")][NativeType("unsigned __int64")] long Count)
	{
		Deallocate.Invoke(Ptr, unchecked(8L * Count));
	}
}
