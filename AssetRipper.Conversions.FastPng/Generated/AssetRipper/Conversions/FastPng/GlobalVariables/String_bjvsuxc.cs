using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1CG@PKEJNHCM@?$AAs?$AAr?$AAc?$AA_?$AAo?$AAf?$AAs?$AA?5?$AA?$DN?$AA?$DN?$AA?5?$AAh?$AA?5?$AA?$CK?$AA?5?$AAb?$AAp?$AAl?$AA?$AA@")]
[DemangledName("L\"src_ofs == h * bpl\"")]
[CleanName("String")]
internal static partial class String_bjvsuxc
{
	public unsafe static InlineArray19_Int16* __pointer;

	public unsafe static InlineArray19_Int16 Value
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

	unsafe static String_bjvsuxc()
	{
		__pointer = unchecked((InlineArray19_Int16*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray19_Int16))));
		Value = InlineArrayHelper.Create<InlineArray19_Int16, char>("src_ofs == h * bpl\0".ToCharacterSpan());
	}
}
