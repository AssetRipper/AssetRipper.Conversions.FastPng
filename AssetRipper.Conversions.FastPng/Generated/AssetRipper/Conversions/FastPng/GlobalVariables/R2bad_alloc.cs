using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_R2bad_alloc@std@@8")]
[DemangledName("std::bad_alloc::`RTTI Base Class Array'")]
internal static partial class R2bad_alloc
{
	public unsafe static InlineArray_3_vqkfj7a* __pointer;

	public unsafe static InlineArray_3_vqkfj7a Value
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
		__pointer = unchecked((InlineArray_3_vqkfj7a*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_3_vqkfj7a))));
		Value = new InlineArrayBuilder<InlineArray_3_vqkfj7a, int>
		{
			PointerIndices.GetIndex(R1A_vzsilob.__pointer),
			PointerIndices.GetIndex(R1A_bbqer2a.__pointer),
			0
		};
	}
}
