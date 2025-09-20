using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1EA@NGEOLJKL@?$AAt?$AAe?$AAm?$AAp?$AA_?$AAb?$AAu?$AAf?$AA_?$AAo?$AAf?$AAs?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AAt?$AAe?$AAm?$AAp?$AA_?$AAb?$AAu?$AAf?$AA?4?$AAs?$AAi?$AAz?$AAe?$AA?$CI?$AA?$CJ?$AA?$AA@")]
[DemangledName("L\"temp_buf_ofs <= temp_buf.size()\"")]
[CleanName("String")]
internal static partial class String_bik4erc
{
	public unsafe static InlineArray32_Int16* __pointer;

	public unsafe static InlineArray32_Int16 Value
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

	unsafe static String_bik4erc()
	{
		__pointer = unchecked((InlineArray32_Int16*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray32_Int16))));
		Value = InlineArrayHelper.Create<InlineArray32_Int16, char>("temp_buf_ofs <= temp_buf.size()\0".ToCharacterSpan());
	}
}
