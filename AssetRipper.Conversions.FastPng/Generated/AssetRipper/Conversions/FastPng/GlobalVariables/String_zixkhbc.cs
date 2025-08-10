using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1EK@NPDOIFAN@?$AA?$CI?$AAs?$AAr?$AAc?$AA_?$AAc?$AAh?$AAa?$AAn?$AAs?$AA?5?$AA?$DN?$AA?$DN?$AA?5?$AA3?$AA?$CJ?$AA?5?$AA?$HM?$AA?$HM?$AA?5?$AA?$CI?$AAs?$AAr?$AAc?$AA_?$AAc?$AAh?$AAa?$AAn?$AAs?$AA?5?$AA?$DN@")]
[DemangledName("L\"(src_chans == 3) || (src_chans =\"...")]
[CleanName("String")]
internal static partial class String_zixkhbc
{
	public unsafe static InlineArray_37_oeds4ea* __pointer;

	public unsafe static InlineArray_37_oeds4ea Value
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

	unsafe static String_zixkhbc()
	{
		__pointer = unchecked((InlineArray_37_oeds4ea*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_37_oeds4ea))));
		Value = InlineArrayHelper.Create<InlineArray_37_oeds4ea, char>("(src_chans == 3) || (src_chans == 4)\0".ToCharacterSpan());
	}
}
