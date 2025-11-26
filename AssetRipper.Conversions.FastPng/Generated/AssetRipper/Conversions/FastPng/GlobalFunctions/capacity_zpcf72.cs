using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?capacity@?$vector@EV?$allocator@E@std@@@std@@QEBA_KXZ")]
[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::capacity(void) const")]
[CleanName("capacity")]
internal static partial class capacity_zpcf72
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke(void* @this)
	{
		unchecked
		{
			void* myval = &((std_vector_4tqn2f*)@this)->Mypair.Myval2;
			return (long)((std_Vector_val_ghsspe*)myval)->Myend - (long)((std_Vector_val_ghsspe*)myval)->Myfirst;
		}
	}
}
