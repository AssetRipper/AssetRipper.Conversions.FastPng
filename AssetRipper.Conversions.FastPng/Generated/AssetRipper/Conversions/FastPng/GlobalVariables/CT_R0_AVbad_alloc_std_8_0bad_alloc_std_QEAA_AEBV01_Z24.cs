using AssetRipper.Conversions.FastPng.GlobalFunctions;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("_CT??_R0?AVbad_alloc@std@@@8??0bad_alloc@std@@QEAA@AEBV01@@Z24")]
[DemangledName("_CT??_R0?AVbad_alloc@std@@@8??0bad_alloc@std@@QEAA@AEBV01@@Z24")]
internal static partial class CT_R0_AVbad_alloc_std_8_0bad_alloc_std_QEAA_AEBV01_Z24
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

	unsafe static CT_R0_AVbad_alloc_std_8_0bad_alloc_std_QEAA_AEBV01_Z24()
	{
		__pointer = unchecked((eh_CatchableType*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(eh_CatchableType))));
		Value = new eh_CatchableType
		{
			field_0 = 16,
			field_1 = PointerIndices.GetIndex(R0_AVbad_alloc.__pointer),
			field_2 = 0,
			field_3 = -1,
			field_4 = 0,
			field_5 = 24,
			field_6 = PointerIndices.GetIndex(bad_alloc_Constructor_3vdoaxb.__pointer)
		};
	}
}
