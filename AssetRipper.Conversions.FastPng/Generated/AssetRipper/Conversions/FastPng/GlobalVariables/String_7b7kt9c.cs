using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_0BA@FOIKENOD@vector?5too?5long?$AA@")]
[DemangledName("\"vector too long\"")]
[CleanName("String")]
internal static partial class String_7b7kt9c
{
	public unsafe static InlineArray16_SByte* __pointer;

	public unsafe static InlineArray16_SByte Value
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
		__pointer = unchecked((InlineArray16_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray16_SByte))));
		Value = InlineArrayHelper.Create<InlineArray16_SByte, byte>("vector too long\0"u8);
	}
}
