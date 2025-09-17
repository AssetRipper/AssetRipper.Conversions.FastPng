using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Buy_nonzero@?$vector@IV?$allocator@I@std@@@std@@AEAAX_K@Z")]
[DemangledName("private: void __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::_Buy_nonzero(unsigned __int64)")]
internal static partial class Buy_nonzero
{
	public unsafe static void Invoke(void* @this, long Newcapacity)
	{
		if (unchecked((ulong)Newcapacity > (ulong)max_size_qdwnpha.Invoke(@this)))
		{
			Xlength_nubzgpc.Invoke();
			throw null;
		}
		Buy_raw.Invoke(@this, Newcapacity);
		if (ExceptionInfo.Current == null)
		{
		}
	}
}
