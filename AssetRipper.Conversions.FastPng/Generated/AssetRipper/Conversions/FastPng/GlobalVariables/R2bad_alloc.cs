using System;
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
		InlineArray_3_vqkfj7a buffer = default(InlineArray_3_vqkfj7a);
		Span<int> span = buffer.AsSpan<InlineArray_3_vqkfj7a, int>();
		span[0] = PointerIndices.GetIndex(R1A_vzsilob.__pointer);
		span[1] = PointerIndices.GetIndex(R1A_bbqer2a.__pointer);
		span[2] = 0;
		Value = buffer;
	}
}
