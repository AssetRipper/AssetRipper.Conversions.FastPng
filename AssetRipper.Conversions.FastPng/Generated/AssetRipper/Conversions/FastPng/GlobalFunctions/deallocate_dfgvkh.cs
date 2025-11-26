using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?deallocate@?$allocator@I@std@@QEAAXQEAI_K@Z")]
[DemangledName("public: void __cdecl std::allocator<unsigned int>::deallocate(unsigned int *const, unsigned __int64)")]
[CleanName("deallocate")]
internal static partial class deallocate_dfgvkh
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [MangledName("_Ptr")][NativeType("unsigned int *const")] void* Ptr, [MangledName("_Count")][NativeType("unsigned __int64")] long Count)
	{
		Deallocate.Invoke(Ptr, unchecked(4L * Count));
	}
}
