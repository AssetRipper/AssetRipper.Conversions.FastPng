using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?data@?$vector@_KV?$allocator@_K@std@@@std@@QEAAPEA_KXZ")]
[DemangledName("public: unsigned __int64 * __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::data(void)")]
[CleanName("data")]
internal static partial class data_xjuchx
{
	[return: NativeType("unsigned __int64 *")]
	public unsafe static void* Invoke(void* @this)
	{
		return Unfancy_maybe_null_q2cruh.Invoke(unchecked((std_vector_ucmdxb*)@this)->Mypair.Myval2.Myfirst);
	}
}
