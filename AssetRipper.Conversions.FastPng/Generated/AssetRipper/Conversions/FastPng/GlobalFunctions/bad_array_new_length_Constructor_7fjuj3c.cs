using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??0bad_array_new_length@std@@QEAA@AEBV01@@Z")]
[DemangledName("public: __cdecl std::bad_array_new_length::bad_array_new_length(class std::bad_array_new_length const &)")]
[CleanName("bad_array_new_length_Constructor")]
internal static partial class bad_array_new_length_Constructor_7fjuj3c
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, void*, void*>)(&Invoke));

	public unsafe static void* Invoke(void* @this, [NativeType("class std::bad_array_new_length const &")] void* parameter_1)
	{
		bad_alloc_Constructor_3vdoaxb.Invoke(@this, parameter_1);
		unchecked
		{
			*(byte**)@this = (byte*)(&Variable_4yxjuqa.__pointer->field_0) + sizeof(nint);
			return @this;
		}
	}
}
