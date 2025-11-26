using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1DE@LOJFIBNB@?$AAs?$AAr?$AAc?$AA_?$AAl?$AAe?$AAn?$AA?5?$AA?$DO?$AA?$DN?$AA?5?$AA?$CI?$AAz?$AAl?$AAi?$AAb?$AA_?$AAl?$AAe?$AAn?$AA?5?$AA?$CL?$AA?5?$AA4?$AA?$CJ?$AA?$AA@")]
[DemangledName("L\"src_len >= (zlib_len + 4)\"")]
[CleanName("String")]
internal static partial class String_wv8pqk
{
	public unsafe static InlineArray26_Int16* __pointer;

	public unsafe static InlineArray26_Int16 Value
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

	unsafe static String_wv8pqk()
	{
		__pointer = unchecked((InlineArray26_Int16*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray26_Int16))));
		Value = InlineArrayHelper.Create<InlineArray26_Int16, char>("src_len >= (zlib_len + 4)\0");
	}
}
