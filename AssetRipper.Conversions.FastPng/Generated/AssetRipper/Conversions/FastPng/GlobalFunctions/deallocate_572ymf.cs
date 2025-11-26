using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?deallocate@?$allocator@E@std@@QEAAXQEAE_K@Z")]
[DemangledName("public: void __cdecl std::allocator<unsigned char>::deallocate(unsigned char *const, unsigned __int64)")]
[CleanName("deallocate")]
internal static partial class deallocate_572ymf
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [MangledName("_Ptr")][NativeType("unsigned char *const")] void* Ptr, [MangledName("_Count")][NativeType("unsigned __int64")] long Count)
	{
		Deallocate.Invoke(Ptr, unchecked(1L * Count));
	}
}
