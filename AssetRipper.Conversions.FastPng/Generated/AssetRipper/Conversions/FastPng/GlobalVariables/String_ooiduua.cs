using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1CI@EDFEPIBM@?$AA?$CI?$AAb?$AA?$CJ?$AA?5?$AA?$DM?$AA?5?$AA?$CI?$AA1?$AAU?$AAL?$AAL?$AA?5?$AA?$DM?$AA?$DM?$AA?5?$AA?$CI?$AAl?$AA?$CJ?$AA?$CJ?$AA?$AA@")]
[DemangledName("L\"(b) < (1ULL << (l))\"")]
[CleanName("String")]
internal static partial class String_ooiduua
{
	public unsafe static InlineArray_20_oeds4ea* __pointer;

	public unsafe static InlineArray_20_oeds4ea Value
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

	unsafe static String_ooiduua()
	{
		__pointer = unchecked((InlineArray_20_oeds4ea*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_20_oeds4ea))));
		Value = InlineArrayHelper.Create<InlineArray_20_oeds4ea, char>("(b) < (1ULL << (l))\0".ToCharacterSpan());
	}
}
