using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1EA@NGEOLJKL@?$AAt?$AAe?$AAm?$AAp?$AA_?$AAb?$AAu?$AAf?$AA_?$AAo?$AAf?$AAs?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AAt?$AAe?$AAm?$AAp?$AA_?$AAb?$AAu?$AAf?$AA?4?$AAs?$AAi?$AAz?$AAe?$AA?$CI?$AA?$CJ?$AA?$AA@")]
[DemangledName("L\"temp_buf_ofs <= temp_buf.size()\"")]
[CleanName("String")]
internal static partial class String_bik4erc
{
	public unsafe static InlineArray_32_oeds4ea* __pointer;

	public unsafe static InlineArray_32_oeds4ea Value
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
		__pointer = unchecked((InlineArray_32_oeds4ea*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_32_oeds4ea))));
		Value = InlineArrayHelper.Create<InlineArray_32_oeds4ea, char>("temp_buf_ofs <= temp_buf.size()\0".ToCharacterSpan());
	}
}
