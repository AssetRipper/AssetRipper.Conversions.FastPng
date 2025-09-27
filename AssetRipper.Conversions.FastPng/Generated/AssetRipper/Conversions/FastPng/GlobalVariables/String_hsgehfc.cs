using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1DI@FDHIJIML@?$AAt?$AAo?$AAt?$AAa?$AAl?$AA_?$AAc?$AAo?$AAd?$AAe?$AAs?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AAc?$AAo?$AAd?$AAe?$AAs?$AA?4?$AAs?$AAi?$AAz?$AAe?$AA?$CI?$AA?$CJ?$AA?$AA@")]
[DemangledName("L\"total_codes <= codes.size()\"")]
[CleanName("String")]
internal static partial class String_hsgehfc
{
	public unsafe static InlineArray28_Int16* __pointer;

	public unsafe static InlineArray28_Int16 Value
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

	unsafe static String_hsgehfc()
	{
		__pointer = unchecked((InlineArray28_Int16*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray28_Int16))));
		Value = InlineArrayHelper.Create<InlineArray28_Int16, char>("total_codes <= codes.size()\0");
	}
}
