using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?capacity@?$vector@_KV?$allocator@_K@std@@@std@@QEBA_KXZ")]
[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::capacity(void) const")]
[CleanName("capacity")]
internal static partial class capacity_e227dw
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke(void* @this)
	{
		unchecked
		{
			void* myval = &((std_vector_ucmdxb*)@this)->Mypair.Myval2;
			return ((long)((std_Vector_val_i7igbu*)myval)->Myend - (long)((std_Vector_val_i7igbu*)myval)->Myfirst) / 8L;
		}
	}
}
