using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?allocate@?$allocator@_K@std@@QEAAPEA_K_K@Z")]
[DemangledName("public: unsigned __int64 * __cdecl std::allocator<unsigned __int64>::allocate(unsigned __int64)")]
[CleanName("allocate")]
internal static partial class allocate_hfyt8m
{
	[return: NativeType("unsigned __int64 *")]
	public unsafe static void* Invoke(void* @this, [MangledName("_Count")][NativeType("unsigned __int64")] long Count)
	{
		long bytes = Get_size_of_n_p7wxpq.Invoke(Count);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		void* result = Allocate_4exgpj.Invoke(bytes);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return result;
	}
}
