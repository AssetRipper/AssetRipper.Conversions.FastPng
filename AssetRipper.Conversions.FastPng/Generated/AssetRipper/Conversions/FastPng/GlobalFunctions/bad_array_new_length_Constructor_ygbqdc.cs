using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??0bad_array_new_length@std@@QEAA@XZ")]
[DemangledName("public: __cdecl std::bad_array_new_length::bad_array_new_length(void)")]
[CleanName("bad_array_new_length_Constructor")]
internal static partial class bad_array_new_length_Constructor_ygbqdc
{
	public unsafe static void* Invoke(void* @this)
	{
		bad_alloc_Constructor_479urr.Invoke(@this, String_73ugr6.__pointer);
		unchecked
		{
			*(byte**)@this = (byte*)(&Variable_fiz2nb.__pointer->field_0) + sizeof(nint);
			return @this;
		}
	}
}
