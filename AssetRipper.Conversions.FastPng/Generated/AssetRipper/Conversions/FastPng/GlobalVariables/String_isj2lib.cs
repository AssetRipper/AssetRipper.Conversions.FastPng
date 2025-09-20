using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1CM@MLLBGOKN@?$AA?$CI?$AAl?$AA?$CJ?$AA?5?$AA?$DO?$AA?$DN?$AA?5?$AA1?$AA?5?$AA?$CG?$AA?$CG?$AA?5?$AA?$CI?$AAl?$AA?$CJ?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AA1?$AA6?$AA?$AA@")]
[DemangledName("L\"(l) >= 1 && (l) <= 16\"")]
[CleanName("String")]
internal static partial class String_isj2lib
{
	public unsafe static InlineArray22_Int16* __pointer;

	public unsafe static InlineArray22_Int16 Value
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

	unsafe static String_isj2lib()
	{
		__pointer = unchecked((InlineArray22_Int16*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray22_Int16))));
		Value = InlineArrayHelper.Create<InlineArray22_Int16, char>("(l) >= 1 && (l) <= 16\0".ToCharacterSpan());
	}
}
