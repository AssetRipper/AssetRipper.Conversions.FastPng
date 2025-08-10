using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_03DJLFMAPG@?$AC?$AD?$AH?$AA@")]
[DemangledName("\"\\x02\\x03\\a\"")]
[CleanName("String")]
internal static partial class String_o9ulvgb
{
	public unsafe static InlineArray_4_w3otm9c* __pointer;

	public unsafe static InlineArray_4_w3otm9c Value
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

	unsafe static String_o9ulvgb()
	{
		__pointer = unchecked((InlineArray_4_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_4_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_4_w3otm9c, byte>(new byte[4] { 2, 3, 7, 0 });
	}
}
