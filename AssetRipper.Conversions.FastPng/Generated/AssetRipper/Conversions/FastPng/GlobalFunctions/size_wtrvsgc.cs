using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?size@?$vector@IV?$allocator@I@std@@@std@@QEBA_KXZ")]
[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::size(void) const")]
[CleanName("size")]
internal static partial class size_wtrvsgc
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke(void* @this)
	{
		unchecked
		{
			void* field_ = &((std_vector_drook9b*)@this)->field_0.field_0;
			return ((long)((std_Vector_val_edx9ebc*)field_)->field_1 - (long)((std_Vector_val_edx9ebc*)field_)->field_0) / 4L;
		}
	}
}
