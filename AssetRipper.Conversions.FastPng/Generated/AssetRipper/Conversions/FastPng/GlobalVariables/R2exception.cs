using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_R2exception@std@@8")]
[DemangledName("std::exception::`RTTI Base Class Array'")]
internal static partial class R2exception
{
	public unsafe static InlineArray2_Int32* __pointer;

	public unsafe static InlineArray2_Int32 Value
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

	unsafe static R2exception()
	{
		__pointer = unchecked((InlineArray2_Int32*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray2_Int32))));
		Value = new InlineArrayBuilder<InlineArray2_Int32, int>
		{
			PointerIndices.GetIndex(R1A_cfk42d.__pointer),
			0
		};
	}
}
