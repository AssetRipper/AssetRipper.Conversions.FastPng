using AssetRipper.Conversions.FastPng.GlobalFunctions;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("_TI3?AVbad_array_new_length@std@@")]
[DemangledName("_TI3?AVbad_array_new_length@std@@")]
internal static partial class TI3_AVbad_array_new_length_std
{
	public unsafe static eh_ThrowInfo* __pointer;

	public unsafe static eh_ThrowInfo Value
	{
		get
		{
			return *__pointer;
		}
		set
		{
			*__pointer = value;
		}
	}

	unsafe static TI3_AVbad_array_new_length_std()
	{
		__pointer = unchecked((eh_ThrowInfo*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(eh_ThrowInfo))));
		eh_ThrowInfo value = new eh_ThrowInfo
		{
			field_0 = 0
		};
		ref int field_ = ref value.field_1;
		field_ = PointerIndices.GetIndex(bad_array_new_length_Destructor.__pointer);
		value.field_2 = 0;
		ref int field_2 = ref value.field_3;
		field_2 = PointerIndices.GetIndex(CTA3_AVbad_array_new_length_std.__pointer);
		Value = value;
	}
}
