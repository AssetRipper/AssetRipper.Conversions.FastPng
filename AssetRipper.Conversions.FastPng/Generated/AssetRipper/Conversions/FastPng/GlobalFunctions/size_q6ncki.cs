using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?size@?$vector@_KV?$allocator@_K@std@@@std@@QEBA_KXZ")]
[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::size(void) const")]
[CleanName("size")]
internal static partial class size_q6ncki
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke(void* @this)
	{
		unchecked
		{
			void* myval = &((std_vector_ucmdxb*)@this)->Mypair.Myval2;
			return ((long)((std_Vector_val_i7igbu*)myval)->Mylast - (long)((std_Vector_val_i7igbu*)myval)->Myfirst) / 8L;
		}
	}
}
