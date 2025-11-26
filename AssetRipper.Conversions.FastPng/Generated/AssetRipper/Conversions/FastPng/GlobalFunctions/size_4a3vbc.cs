using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?size@?$vector@IV?$allocator@I@std@@@std@@QEBA_KXZ")]
[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::size(void) const")]
[CleanName("size")]
internal static partial class size_4a3vbc
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke(void* @this)
	{
		unchecked
		{
			void* myval = &((std_vector_jsyy6a*)@this)->Mypair.Myval2;
			return ((long)((std_Vector_val_fju23j*)myval)->Mylast - (long)((std_Vector_val_fju23j*)myval)->Myfirst) / 4L;
		}
	}
}
