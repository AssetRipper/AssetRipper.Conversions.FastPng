using System;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_R2exception@std@@8")]
[DemangledName("std::exception::`RTTI Base Class Array'")]
internal static partial class R2exception
{
	public unsafe static InlineArray_2_vqkfj7a* __pointer;

	public unsafe static InlineArray_2_vqkfj7a Value
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
		__pointer = unchecked((InlineArray_2_vqkfj7a*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_2_vqkfj7a))));
		InlineArray_2_vqkfj7a buffer = default(InlineArray_2_vqkfj7a);
		Span<int> span = buffer.AsSpan<InlineArray_2_vqkfj7a, int>();
		span[0] = PointerIndices.GetIndex(R1A_bbqer2a.__pointer);
		span[1] = 0;
		Value = buffer;
	}
}
