using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_R4exception@std@@6B@")]
[DemangledName("const std::exception::`RTTI Complete Object Locator'")]
internal static partial class R4exception
{
	public unsafe static rtti_CompleteObjectLocator* __pointer;

	public unsafe static rtti_CompleteObjectLocator Value
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

	unsafe static R4exception()
	{
		__pointer = unchecked((rtti_CompleteObjectLocator*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(rtti_CompleteObjectLocator))));
		Value = new rtti_CompleteObjectLocator
		{
			field_0 = 1,
			field_1 = 0,
			field_2 = 0,
			field_3 = PointerIndices.GetIndex(R0_AVexception.__pointer),
			field_4 = PointerIndices.GetIndex(R3exception.__pointer),
			field_5 = PointerIndices.GetIndex(__pointer)
		};
	}
}
