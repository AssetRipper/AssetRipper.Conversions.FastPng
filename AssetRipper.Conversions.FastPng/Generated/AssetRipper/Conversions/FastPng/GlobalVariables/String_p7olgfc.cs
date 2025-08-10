using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_04COOFLABO@IEND?$AA@")]
[DemangledName("\"IEND\"")]
[CleanName("String")]
internal static partial class String_p7olgfc
{
	public unsafe static InlineArray_5_w3otm9c* __pointer;

	public unsafe static InlineArray_5_w3otm9c Value
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

	unsafe static String_p7olgfc()
	{
		__pointer = unchecked((InlineArray_5_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_5_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_5_w3otm9c, byte>("IEND\0"u8);
	}
}
