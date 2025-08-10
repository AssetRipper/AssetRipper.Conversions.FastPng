using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?deallocate@?$allocator@I@std@@QEAAXQEAI_K@Z")]
[DemangledName("public: void __cdecl std::allocator<unsigned int>::deallocate(unsigned int *const, unsigned __int64)")]
[CleanName("deallocate")]
internal static partial class deallocate_gfl4ncc
{
	public unsafe static void Invoke(void* @this, void* Ptr, long Count)
	{
		Deallocate.Invoke(Ptr, unchecked(4L * Count));
	}
}
