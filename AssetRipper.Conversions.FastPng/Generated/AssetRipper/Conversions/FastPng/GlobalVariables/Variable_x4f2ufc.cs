using System;
using AssetRipper.Conversions.FastPng.GlobalFunctions;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("")]
[CleanName("Variable")]
internal static partial class Variable_x4f2ufc
{
	public unsafe static Struct* __pointer;

	public unsafe static Struct Value
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

	unsafe static Variable_x4f2ufc()
	{
		unchecked
		{
			__pointer = (Struct*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(Struct)));
			Struct value = default(Struct);
			ref InlineArray_3_gbfuvwd field_ = ref value.field_0;
			InlineArray_3_gbfuvwd buffer = default(InlineArray_3_gbfuvwd);
			Span<nint> span = buffer.AsSpan<InlineArray_3_gbfuvwd, nint>();
			span[0] = (nint)R4exception.__pointer;
			span[1] = (nint)exception_Delete.__pointer;
			span[2] = (nint)what.__pointer;
			field_ = buffer;
			Value = value;
		}
	}
}
