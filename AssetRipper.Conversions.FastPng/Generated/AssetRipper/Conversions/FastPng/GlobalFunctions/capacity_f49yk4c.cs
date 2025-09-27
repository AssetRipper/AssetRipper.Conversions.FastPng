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
			void* myval = &((std_vector_mvt3mha*)@this)->Mypair.Myval2;
			return ((long)((std_Vector_val_zgi5p7d*)myval)->Myend - (long)((std_Vector_val_zgi5p7d*)myval)->Myfirst) / 8L;
		}
	}
}
