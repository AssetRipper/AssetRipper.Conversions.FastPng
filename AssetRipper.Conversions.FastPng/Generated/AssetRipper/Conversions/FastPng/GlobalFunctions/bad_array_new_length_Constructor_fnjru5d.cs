using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??0bad_array_new_length@std@@QEAA@XZ")]
[DemangledName("public: __cdecl std::bad_array_new_length::bad_array_new_length(void)")]
[CleanName("bad_array_new_length_Constructor")]
internal static partial class bad_array_new_length_Constructor_fnjru5d
{
	public unsafe static void* Invoke(void* @this)
	{
		bad_alloc_Constructor_72dj2ea.Invoke(@this, String_gudorqc.__pointer);
		unchecked
		{
			*(byte**)@this = (byte*)(&Variable_4yxjuqa.__pointer->field_0) + sizeof(nint) * 1;
			return @this;
		}
	}
}
