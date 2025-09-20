using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_0BC@EOODALEL@Unknown?5exception?$AA@")]
[DemangledName("\"Unknown exception\"")]
[CleanName("String")]
internal static partial class String_ja3ma5d
{
	public unsafe static InlineArray18_SByte* __pointer;

	public unsafe static InlineArray18_SByte Value
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
		__pointer = unchecked((InlineArray18_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray18_SByte))));
		Value = InlineArrayHelper.Create<InlineArray18_SByte, byte>("Unknown exception\0"u8);
	}
}
