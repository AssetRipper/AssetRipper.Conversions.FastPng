using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1DE@LOJFIBNB@?$AAs?$AAr?$AAc?$AA_?$AAl?$AAe?$AAn?$AA?5?$AA?$DO?$AA?$DN?$AA?5?$AA?$CI?$AAz?$AAl?$AAi?$AAb?$AA_?$AAl?$AAe?$AAn?$AA?5?$AA?$CL?$AA?5?$AA4?$AA?$CJ?$AA?$AA@")]
[DemangledName("L\"src_len >= (zlib_len + 4)\"")]
[CleanName("String")]
internal static partial class String_497patd
{
	public unsafe static InlineArray_26_oeds4ea* __pointer;

	public unsafe static InlineArray_26_oeds4ea Value
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

	unsafe static String_497patd()
	{
		__pointer = unchecked((InlineArray_26_oeds4ea*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_26_oeds4ea))));
		Value = InlineArrayHelper.Create<InlineArray_26_oeds4ea, char>("src_len >= (zlib_len + 4)\0".ToCharacterSpan());
	}
}
