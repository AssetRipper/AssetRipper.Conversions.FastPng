using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_0BA@FOIKENOD@vector?5too?5long?$AA@")]
[DemangledName("\"vector too long\"")]
[CleanName("String")]
internal static partial class String_7b7kt9c
{
	public unsafe static InlineArray_16_w3otm9c* __pointer;

	public unsafe static InlineArray_16_w3otm9c Value
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

	unsafe static String_7b7kt9c()
	{
		__pointer = unchecked((InlineArray_16_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_16_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_16_w3otm9c, byte>("vector too long\0"u8);
	}
}
