using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_03DJLFMAPG@?$AC?$AD?$AH?$AA@")]
[DemangledName("\"\\x02\\x03\\a\"")]
[CleanName("String")]
internal static partial class String_rvc6pt
{
	public unsafe static InlineArray4_SByte* __pointer;

	public unsafe static InlineArray4_SByte Value
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

	unsafe static String_rvc6pt()
	{
		__pointer = unchecked((InlineArray4_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray4_SByte))));
		Value = InlineArrayHelper.Create<InlineArray4_SByte, byte>(new byte[4] { 2, 3, 7, 0 });
	}
}
