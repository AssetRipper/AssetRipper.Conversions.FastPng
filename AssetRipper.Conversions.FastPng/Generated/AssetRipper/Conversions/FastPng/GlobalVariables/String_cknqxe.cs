using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1DO@PIFJFOL@?$AAc?$AAo?$AAd?$AAe?$AA?5?$AA?$DM?$AA?5?$AAD?$AAE?$AAF?$AAL?$AA_?$AAM?$AAA?$AAX?$AA_?$AAH?$AAU?$AAF?$AAF?$AA_?$AAS?$AAY?$AAM?$AAB?$AAO?$AAL?$AAS?$AA_?$AA2?$AA?$AA@")]
[DemangledName("L\"code < DEFL_MAX_HUFF_SYMBOLS_2\"")]
[CleanName("String")]
internal static partial class String_cknqxe
{
	public unsafe static InlineArray31_Int16* __pointer;

	public unsafe static InlineArray31_Int16 Value
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

	unsafe static String_cknqxe()
	{
		__pointer = unchecked((InlineArray31_Int16*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray31_Int16))));
		Value = InlineArrayHelper.Create<InlineArray31_Int16, char>("code < DEFL_MAX_HUFF_SYMBOLS_2\0");
	}
}
