using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_R2bad_alloc@std@@8")]
[DemangledName("std::bad_alloc::`RTTI Base Class Array'")]
internal static partial class R2bad_alloc
{
	public unsafe static InlineArray3_Int32* __pointer;

	public unsafe static InlineArray3_Int32 Value
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

	unsafe static R2bad_alloc()
	{
		__pointer = unchecked((InlineArray3_Int32*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray3_Int32))));
		Value = new InlineArrayBuilder<InlineArray3_Int32, int>
		{
			PointerIndices.GetIndex(R1A_vzsilob.__pointer),
			PointerIndices.GetIndex(R1A_bbqer2a.__pointer),
			0
		};
	}
}
