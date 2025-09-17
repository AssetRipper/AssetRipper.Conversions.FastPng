using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Deallocate@$0BA@@std@@YAXPEAX_K@Z")]
[DemangledName("void __cdecl std::_Deallocate<16>(void *, unsigned __int64)")]
internal static partial class Deallocate
{
	public unsafe static void Invoke(void* Ptr, long Bytes)
	{
		long num = 0L;
		void* ptr = null;
		num = Bytes;
		ptr = Ptr;
		if (unchecked((ulong)num) >= 4096uL)
		{
			Adjust_manually_vector_aligned.Invoke(&ptr, &num);
			if (ExceptionInfo.Current != null)
			{
				ExceptionInfo.Current = null;
				std_terminate.Invoke();
				throw null;
			}
		}
		Delete.Invoke(ptr, num);
	}
}
