using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1BE@DFLAPPIJ@?$AAp?$AAP?$AAr?$AAe?$AAv?$AA_?$AAs?$AAr?$AAc?$AA?$AA@")]
[DemangledName("L\"pPrev_src\"")]
[CleanName("String")]
internal static partial class String_uc52kza
{
	public unsafe static InlineArray_10_oeds4ea* __pointer;

	public unsafe static InlineArray_10_oeds4ea Value
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

	unsafe static String_uc52kza()
	{
		__pointer = unchecked((InlineArray_10_oeds4ea*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_10_oeds4ea))));
		Value = InlineArrayHelper.Create<InlineArray_10_oeds4ea, char>("pPrev_src\0".ToCharacterSpan());
	}
}
