using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1DO@GINGNLCO@?$AAl?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AA3?$AA2?$AA?5?$AA?$CG?$AA?$CG?$AA?5?$AA?$CI?$AAb?$AAi?$AAt?$AA_?$AAb?$AAu?$AAf?$AA_?$AAs?$AAi?$AAz?$AAe?$AA?5?$AA?$DO?$AA?$DN?$AA?5?$AAl?$AA?$CJ?$AA?$AA@")]
[DemangledName("L\"l <= 32 && (bit_buf_size >= l)\"")]
[CleanName("String")]
internal static partial class String_bahgbqd
{
	public unsafe static InlineArray_31_oeds4ea* __pointer;

	public unsafe static InlineArray_31_oeds4ea Value
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

	unsafe static String_bahgbqd()
	{
		__pointer = unchecked((InlineArray_31_oeds4ea*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_31_oeds4ea))));
		Value = InlineArrayHelper.Create<InlineArray_31_oeds4ea, char>("l <= 32 && (bit_buf_size >= l)\0".ToCharacterSpan());
	}
}
