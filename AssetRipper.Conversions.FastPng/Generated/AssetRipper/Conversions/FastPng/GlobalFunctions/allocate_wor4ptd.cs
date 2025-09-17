using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?allocate@?$allocator@I@std@@QEAAPEAI_K@Z")]
[DemangledName("public: unsigned int * __cdecl std::allocator<unsigned int>::allocate(unsigned __int64)")]
[CleanName("allocate")]
internal static partial class allocate_wor4ptd
{
	public unsafe static void* Invoke(void* @this, long Count)
	{
		long bytes = Get_size_of_n_rdjmi2b.Invoke(Count);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		void* result = Allocate_i4jzs2a.Invoke(bytes);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return result;
	}
}
