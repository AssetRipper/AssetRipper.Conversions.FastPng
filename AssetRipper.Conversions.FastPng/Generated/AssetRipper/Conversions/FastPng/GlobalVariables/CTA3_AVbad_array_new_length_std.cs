using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("_CTA3?AVbad_array_new_length@std@@")]
[DemangledName("_CTA3?AVbad_array_new_length@std@@")]
internal static partial class CTA3_AVbad_array_new_length_std
{
	public unsafe static eh_CatchableTypeArray_3* __pointer;

	public unsafe static eh_CatchableTypeArray_3 Value
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

	unsafe static CTA3_AVbad_array_new_length_std()
	{
		__pointer = unchecked((eh_CatchableTypeArray_3*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(eh_CatchableTypeArray_3))));
		Value = new eh_CatchableTypeArray_3
		{
			field_0 = 3,
			field_1 = new InlineArrayBuilder<InlineArray_3_vqkfj7a, int>
			{
				PointerIndices.GetIndex(CT_R0_AVbad_array_new_length_std_8_0bad_array_new_length_std_QEAA_AEBV01_Z24.__pointer),
				PointerIndices.GetIndex(CT_R0_AVbad_alloc_std_8_0bad_alloc_std_QEAA_AEBV01_Z24.__pointer),
				PointerIndices.GetIndex(CT_R0_AVexception_std_8_0exception_std_QEAA_AEBV01_Z24.__pointer)
			}
		};
	}
}
