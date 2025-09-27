using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1BE@DFLAPPIJ@?$AAp?$AAP?$AAr?$AAe?$AAv?$AA_?$AAs?$AAr?$AAc?$AA?$AA@")]
[DemangledName("L\"pPrev_src\"")]
[CleanName("String")]
internal static partial class String_uc52kza
{
	public unsafe static InlineArray10_Int16* __pointer;

	public unsafe static InlineArray10_Int16 Value
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
		__pointer = unchecked((InlineArray10_Int16*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray10_Int16))));
		Value = InlineArrayHelper.Create<InlineArray10_Int16, char>("pPrev_src\0");
	}
}
