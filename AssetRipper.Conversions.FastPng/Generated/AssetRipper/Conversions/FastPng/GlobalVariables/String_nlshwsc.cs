using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1EI@CMIKALPF@?$AAs?$AAy?$AAm?$AA_?$AAb?$AAi?$AAt?$AAs?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AAF?$AAP?$AAN?$AAG?$AA_?$AAD?$AAE?$AAC?$AAO?$AAD?$AAE?$AAR?$AA_?$AAT?$AAA?$AAB?$AAL?$AAE?$AA_?$AAB@")]
[DemangledName("L\"sym_bits <= FPNG_DECODER_TABLE_B\"...")]
[CleanName("String")]
internal static partial class String_nlshwsc
{
	public unsafe static InlineArray_36_oeds4ea* __pointer;

	public unsafe static InlineArray_36_oeds4ea Value
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

	unsafe static String_nlshwsc()
	{
		__pointer = unchecked((InlineArray_36_oeds4ea*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_36_oeds4ea))));
		Value = InlineArrayHelper.Create<InlineArray_36_oeds4ea, char>("sym_bits <= FPNG_DECODER_TABLE_BITS\0".ToCharacterSpan());
	}
}
