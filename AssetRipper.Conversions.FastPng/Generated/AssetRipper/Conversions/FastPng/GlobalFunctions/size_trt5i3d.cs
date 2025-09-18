using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?size@?$vector@_KV?$allocator@_K@std@@@std@@QEBA_KXZ")]
[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::size(void) const")]
[CleanName("size")]
internal static partial class size_trt5i3d
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke(void* @this)
	{
		unchecked
		{
			void* field_ = &((std_vector_5*)@this)->field_0.field_0;
			return ((long)((std_Vector_val_9*)field_)->field_1 - (long)((std_Vector_val_9*)field_)->field_0) / 8L;
		}
	}
}
