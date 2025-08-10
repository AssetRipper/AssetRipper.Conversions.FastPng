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
		rtti_TypeDescriptor30 value = default(rtti_TypeDescriptor30);
		ref void* field_ = ref value.field_0;
		field_ = _7type_info.__pointer;
		value.field_1 = null;
		ref InlineArray_31_w3otm9c field_2 = ref value.field_2;
		field_2 = InlineArrayHelper.Create<InlineArray_31_w3otm9c, byte>(".?AVbad_array_new_length@std@@\0"u8);
		Value = value;
	}
}
