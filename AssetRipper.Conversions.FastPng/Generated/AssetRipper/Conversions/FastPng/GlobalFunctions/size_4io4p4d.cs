using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?size@?$vector@EV?$allocator@E@std@@@std@@QEBA_KXZ")]
[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::size(void) const")]
[CleanName("size")]
internal static partial class size_4io4p4d
{
	public unsafe static long Invoke(void* @this)
	{
		unchecked
		{
			void* field_ = &((std_vector*)@this)->field_0.field_0;
			return (long)((std_Vector_val*)field_)->field_1 - (long)((std_Vector_val*)field_)->field_0;
		}
	}
}
