using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?size@?$vector@EV?$allocator@E@std@@@std@@QEBA_KXZ")]
[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::size(void) const")]
[CleanName("size")]
internal static partial class size_78pg66
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke(void* @this)
	{
		unchecked
		{
			void* myval = &((std_vector_4tqn2f*)@this)->Mypair.Myval2;
			return (long)((std_Vector_val_ghsspe*)myval)->Mylast - (long)((std_Vector_val_ghsspe*)myval)->Myfirst;
		}
	}
}
