using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1FA@PEENLMBD@?$AAb?$AAi?$AAt?$AA_?$AAb?$AAu?$AAf?$AA_?$AAs?$AAi?$AAz?$AAe?$AA?5?$AA?$DO?$AA?$DN?$AA?5?$AAF?$AAP?$AAN?$AAG?$AA_?$AAD?$AAE?$AAC?$AAO?$AAD?$AAE?$AAR?$AA_?$AAT?$AAA?$AAB@")]
[DemangledName("L\"bit_buf_size >= FPNG_DECODER_TAB\"...")]
[CleanName("String")]
internal static partial class String_ktv524d
{
	public unsafe static InlineArray40_Int16* __pointer;

	public unsafe static InlineArray40_Int16 Value
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

	unsafe static String_ktv524d()
	{
		__pointer = unchecked((InlineArray40_Int16*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray40_Int16))));
		Value = InlineArrayHelper.Create<InlineArray40_Int16, char>("bit_buf_size >= FPNG_DECODER_TABLE_BITS\0");
	}
}
