using AssetRipper.Conversions.FastPng.GlobalFunctions;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("_CT??_R0?AVexception@std@@@8??0exception@std@@QEAA@AEBV01@@Z24")]
[DemangledName("_CT??_R0?AVexception@std@@@8??0exception@std@@QEAA@AEBV01@@Z24")]
internal static partial class CT_R0_AVexception_std_8_0exception_std_QEAA_AEBV01_Z24
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

	unsafe static CT_R0_AVexception_std_8_0exception_std_QEAA_AEBV01_Z24()
	{
		__pointer = unchecked((eh_CatchableType*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(eh_CatchableType))));
		Value = new eh_CatchableType
		{
			field_0 = 0,
			field_1 = PointerIndices.GetIndex(R0_AVexception.__pointer),
			field_2 = 0,
			field_3 = -1,
			field_4 = 0,
			field_5 = 24,
			field_6 = PointerIndices.GetIndex(exception_Constructor_ikocrpb.__pointer)
		};
	}
}
