using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_04COOFLABO@IEND?$AA@")]
[DemangledName("\"IEND\"")]
[CleanName("String")]
internal static partial class String_p7olgfc
{
	public unsafe static InlineArray5_SByte* __pointer;

	public unsafe static InlineArray5_SByte Value
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
		__pointer = unchecked((InlineArray5_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray5_SByte))));
		Value = InlineArrayHelper.Create<InlineArray5_SByte, byte>("IEND\0"u8);
	}
}
