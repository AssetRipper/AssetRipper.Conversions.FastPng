using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_R0?AVbad_array_new_length@std@@@8")]
[DemangledName("class std::bad_array_new_length `RTTI Type Descriptor'")]
internal static partial class R0_AVbad_array_new_length
{
	public unsafe static rtti_TypeDescriptor30* __pointer;

	public unsafe static rtti_TypeDescriptor30 Value
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

	unsafe static R0_AVbad_array_new_length()
	{
		__pointer = unchecked((rtti_TypeDescriptor30*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(rtti_TypeDescriptor30))));
		Value = new rtti_TypeDescriptor30
		{
			field_0 = _7type_info.__pointer,
			field_1 = null,
			field_2 = InlineArrayHelper.Create<InlineArray31_SByte, byte>(".?AVbad_array_new_length@std@@\0"u8)
		};
	}
}
