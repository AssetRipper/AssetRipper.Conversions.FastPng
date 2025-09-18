using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Get_size_of_n@$07@std@@YA_K_K@Z")]
[DemangledName("unsigned __int64 __cdecl std::_Get_size_of_n<8>(unsigned __int64)")]
[CleanName("Get_size_of_n")]
internal static partial class Get_size_of_n_siqup9d
{
	[return: NativeType("unsigned __int64")]
	public static long Invoke([MangledName("_Count")][NativeType("unsigned __int64")] long Count)
	{
		unchecked
		{
			if ((ulong)Count > 2305843009213693951uL)
			{
				Throw_bad_array_new_length.Invoke();
				if (ExceptionInfo.Current != null)
				{
					return 0L;
				}
				throw null;
			}
			return Count * 8L;
		}
	}
}
