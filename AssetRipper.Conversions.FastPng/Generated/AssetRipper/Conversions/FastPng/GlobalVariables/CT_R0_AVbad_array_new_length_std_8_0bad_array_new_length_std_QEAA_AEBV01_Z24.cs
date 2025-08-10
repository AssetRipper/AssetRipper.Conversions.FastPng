using AssetRipper.Conversions.FastPng.GlobalFunctions;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("_CT??_R0?AVbad_array_new_length@std@@@8??0bad_array_new_length@std@@QEAA@AEBV01@@Z24")]
[DemangledName("_CT??_R0?AVbad_array_new_length@std@@@8??0bad_array_new_length@std@@QEAA@AEBV01@@Z24")]
internal static partial class CT_R0_AVbad_array_new_length_std_8_0bad_array_new_length_std_QEAA_AEBV01_Z24
{
	public unsafe static eh_CatchableType* __pointer;

	public unsafe static eh_CatchableType Value
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

	unsafe static CT_R0_AVbad_array_new_length_std_8_0bad_array_new_length_std_QEAA_AEBV01_Z24()
	{
		__pointer = unchecked((eh_CatchableType*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(eh_CatchableType))));
		eh_CatchableType value = new eh_CatchableType
		{
			field_0 = 0
		};
		ref int field_ = ref value.field_1;
		field_ = PointerIndices.GetIndex(R0_AVbad_array_new_length.__pointer);
		value.field_2 = 0;
		value.field_3 = -1;
		value.field_4 = 0;
		value.field_5 = 24;
		ref int field_2 = ref value.field_6;
		field_2 = PointerIndices.GetIndex(bad_array_new_length_Constructor_7fjuj3c.__pointer);
		Value = value;
	}
}
