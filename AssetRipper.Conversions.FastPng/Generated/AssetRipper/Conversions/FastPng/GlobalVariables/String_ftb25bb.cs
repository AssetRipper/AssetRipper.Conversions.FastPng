using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1EM@LNFOKHHI@?$AAl?$AA?5?$AA?$CG?$AA?$CG?$AA?5?$AA?$CI?$AAl?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AA3?$AA2?$AA?$CJ?$AA?5?$AA?$CG?$AA?$CG?$AA?5?$AA?$CI?$AAb?$AAi?$AAt?$AA_?$AAb?$AAu?$AAf?$AA_?$AAs?$AAi?$AAz?$AAe?$AA?5@")]
[DemangledName("L\"l && (l <= 32) && (bit_buf_size \"...")]
[CleanName("String")]
internal static partial class String_ftb25bb
{
	public unsafe static InlineArray38_Int16* __pointer;

	public unsafe static InlineArray38_Int16 Value
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

	unsafe static String_ftb25bb()
	{
		__pointer = unchecked((InlineArray38_Int16*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray38_Int16))));
		Value = InlineArrayHelper.Create<InlineArray38_Int16, char>("l && (l <= 32) && (bit_buf_size >= l)\0".ToCharacterSpan());
	}
}
