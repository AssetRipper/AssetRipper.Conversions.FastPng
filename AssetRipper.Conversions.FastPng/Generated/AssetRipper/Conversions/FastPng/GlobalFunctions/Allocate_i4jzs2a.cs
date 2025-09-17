using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Allocate@$0BA@U_Default_allocate_traits@std@@@std@@YAPEAX_K@Z")]
[DemangledName("void * __cdecl std::_Allocate<16, struct std::_Default_allocate_traits>(unsigned __int64)")]
[CleanName("Allocate")]
internal static partial class Allocate_i4jzs2a
{
	public unsafe static void* Invoke(long Bytes)
	{
		void* ptr = null;
		if (Bytes == 0L)
		{
			return null;
		}
		if (unchecked((ulong)Bytes) >= 4096uL)
		{
			void* result = Allocate_manually_vector_aligned.Invoke(Bytes);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			return result;
		}
		return Allocate_ifu7fia.Invoke(Bytes);
	}
}
