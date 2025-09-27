using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1FE@PPLLBMKL@?$AAp?$AAC?$AAo?$AAd?$AAe?$AA_?$AAs?$AAi?$AAz?$AAe?$AAs?$AA?$FL?$AAi?$AA?$FN?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AAF?$AAP?$AAN?$AAG?$AA_?$AAD?$AAE?$AAC?$AAO?$AAD?$AAE?$AAR?$AA_?$AAT@")]
[DemangledName("L\"pCode_sizes[i] <= FPNG_DECODER_T\"...")]
[CleanName("String")]
internal static partial class String_32otbnd
{
	public unsafe static InlineArray42_Int16* __pointer;

	public unsafe static InlineArray42_Int16 Value
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

	unsafe static String_32otbnd()
	{
		__pointer = unchecked((InlineArray42_Int16*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray42_Int16))));
		Value = InlineArrayHelper.Create<InlineArray42_Int16, char>("pCode_sizes[i] <= FPNG_DECODER_TABLE_SIZE\0");
	}
}
