using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1DO@PIFJFOL@?$AAc?$AAo?$AAd?$AAe?$AA?5?$AA?$DM?$AA?5?$AAD?$AAE?$AAF?$AAL?$AA_?$AAM?$AAA?$AAX?$AA_?$AAH?$AAU?$AAF?$AAF?$AA_?$AAS?$AAY?$AAM?$AAB?$AAO?$AAL?$AAS?$AA_?$AA2?$AA?$AA@")]
[DemangledName("L\"code < DEFL_MAX_HUFF_SYMBOLS_2\"")]
[CleanName("String")]
internal static partial class String_erkdsbd
{
	public unsafe static InlineArray_31_oeds4ea* __pointer;

	public unsafe static InlineArray_31_oeds4ea Value
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

	unsafe static String_erkdsbd()
	{
		__pointer = unchecked((InlineArray_31_oeds4ea*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_31_oeds4ea))));
		Value = InlineArrayHelper.Create<InlineArray_31_oeds4ea, char>("code < DEFL_MAX_HUFF_SYMBOLS_2\0".ToCharacterSpan());
	}
}
