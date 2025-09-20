using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?capacity@?$vector@EV?$allocator@E@std@@@std@@QEBA_KXZ")]
[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::capacity(void) const")]
[CleanName("capacity")]
internal static partial class capacity_mz5ysja
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke(void* @this)
	{
		unchecked
		{
			void* field_ = &((std_vector_7uge3hb*)@this)->field_0.field_0;
			return (long)((std_Vector_val_p59sy9d*)field_)->field_2 - (long)((std_Vector_val_p59sy9d*)field_)->field_0;
		}
	}
}
