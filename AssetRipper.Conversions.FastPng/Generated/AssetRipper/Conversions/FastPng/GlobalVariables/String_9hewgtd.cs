using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1CM@PHNBINKF@?$AA?$CI?$AAl?$AA?$CJ?$AA?5?$AA?$DO?$AA?$DN?$AA?5?$AA0?$AA?5?$AA?$CG?$AA?$CG?$AA?5?$AA?$CI?$AAl?$AA?$CJ?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AA1?$AA6?$AA?$AA@")]
[DemangledName("L\"(l) >= 0 && (l) <= 16\"")]
[CleanName("String")]
internal static partial class String_9hewgtd
{
	public unsafe static InlineArray_22_oeds4ea* __pointer;

	public unsafe static InlineArray_22_oeds4ea Value
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

	unsafe static String_9hewgtd()
	{
		__pointer = unchecked((InlineArray_22_oeds4ea*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_22_oeds4ea))));
		Value = InlineArrayHelper.Create<InlineArray_22_oeds4ea, char>("(l) >= 0 && (l) <= 16\0".ToCharacterSpan());
	}
}
