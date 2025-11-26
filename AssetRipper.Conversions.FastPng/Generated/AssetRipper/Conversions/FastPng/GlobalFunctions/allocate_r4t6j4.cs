using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?allocate@?$allocator@I@std@@QEAAPEAI_K@Z")]
[DemangledName("public: unsigned int * __cdecl std::allocator<unsigned int>::allocate(unsigned __int64)")]
[CleanName("allocate")]
internal static partial class allocate_r4t6j4
{
	[return: NativeType("unsigned int *")]
	public unsafe static void* Invoke(void* @this, [MangledName("_Count")][NativeType("unsigned __int64")] long Count)
	{
		long bytes = Get_size_of_n_4bnjce.Invoke(Count);
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
