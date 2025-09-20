using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1EK@BJMGPLPL@?$AA?$CI?$AAd?$AAs?$AAt?$AA_?$AAc?$AAh?$AAa?$AAn?$AAs?$AA?5?$AA?$DN?$AA?$DN?$AA?5?$AA3?$AA?$CJ?$AA?5?$AA?$HM?$AA?$HM?$AA?5?$AA?$CI?$AAd?$AAs?$AAt?$AA_?$AAc?$AAh?$AAa?$AAn?$AAs?$AA?5?$AA?$DN@")]
[DemangledName("L\"(dst_chans == 3) || (dst_chans =\"...")]
[CleanName("String")]
internal static partial class String_kppxlqc
{
	public unsafe static InlineArray37_Int16* __pointer;

	public unsafe static InlineArray37_Int16 Value
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

	unsafe static String_kppxlqc()
	{
		__pointer = unchecked((InlineArray37_Int16*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray37_Int16))));
		Value = InlineArrayHelper.Create<InlineArray37_Int16, char>("(dst_chans == 3) || (dst_chans == 4)\0".ToCharacterSpan());
	}
}
