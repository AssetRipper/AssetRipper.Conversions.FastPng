using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?capacity@?$vector@_KV?$allocator@_K@std@@@std@@QEBA_KXZ")]
[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::capacity(void) const")]
[CleanName("capacity")]
internal static partial class capacity_f49yk4c
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke(void* @this)
	{
		unchecked
		{
			void* field_ = &((std_vector_5*)@this)->field_0.field_0;
			return ((long)((std_Vector_val_9*)field_)->field_2 - (long)((std_Vector_val_9*)field_)->field_0) / 8L;
		}
	}
}
