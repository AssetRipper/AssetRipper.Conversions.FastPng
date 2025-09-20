using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_R0?AVbad_alloc@std@@@8")]
[DemangledName("class std::bad_alloc `RTTI Type Descriptor'")]
internal static partial class R0_AVbad_alloc
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

	unsafe static R0_AVbad_alloc()
	{
		__pointer = unchecked((rtti_TypeDescriptor19*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(rtti_TypeDescriptor19))));
		Value = new rtti_TypeDescriptor19
		{
			field_0 = _7type_info.__pointer,
			field_1 = null,
			field_2 = InlineArrayHelper.Create<InlineArray20_SByte, byte>(".?AVbad_alloc@std@@\0"u8)
		};
	}
}
