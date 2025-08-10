using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_R0?AVexception@std@@@8")]
[DemangledName("class std::exception `RTTI Type Descriptor'")]
internal static partial class R0_AVexception
{
	public unsafe static rtti_TypeDescriptor19* __pointer;

	public unsafe static rtti_TypeDescriptor19 Value
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

	unsafe static R0_AVexception()
	{
		__pointer = unchecked((rtti_TypeDescriptor19*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(rtti_TypeDescriptor19))));
		rtti_TypeDescriptor19 value = default(rtti_TypeDescriptor19);
		ref void* field_ = ref value.field_0;
		field_ = _7type_info.__pointer;
		value.field_1 = null;
		ref InlineArray_20_w3otm9c field_2 = ref value.field_2;
		field_2 = InlineArrayHelper.Create<InlineArray_20_w3otm9c, byte>(".?AVexception@std@@\0"u8);
		Value = value;
	}
}
