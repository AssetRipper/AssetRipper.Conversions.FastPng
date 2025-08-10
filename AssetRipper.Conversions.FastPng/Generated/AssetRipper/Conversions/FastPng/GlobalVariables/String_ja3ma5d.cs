using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_0BC@EOODALEL@Unknown?5exception?$AA@")]
[DemangledName("\"Unknown exception\"")]
[CleanName("String")]
internal static partial class String_ja3ma5d
{
	public unsafe static InlineArray_18_w3otm9c* __pointer;

	public unsafe static InlineArray_18_w3otm9c Value
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

	unsafe static String_ja3ma5d()
	{
		__pointer = unchecked((InlineArray_18_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_18_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_18_w3otm9c, byte>("Unknown exception\0"u8);
	}
}
