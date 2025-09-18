using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?allocate@?$allocator@E@std@@QEAAPEAE_K@Z")]
[DemangledName("public: unsigned char * __cdecl std::allocator<unsigned char>::allocate(unsigned __int64)")]
[CleanName("allocate")]
internal static partial class allocate_qfop4bd
{
	[return: NativeType("unsigned char *")]
	public unsafe static void* Invoke(void* @this, [MangledName("_Count")][NativeType("unsigned __int64")] long Count)
	{
		void* result = Allocate_i4jzs2a.Invoke(Get_size_of_n_iqtw9sb.Invoke(Count));
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return result;
	}
}
