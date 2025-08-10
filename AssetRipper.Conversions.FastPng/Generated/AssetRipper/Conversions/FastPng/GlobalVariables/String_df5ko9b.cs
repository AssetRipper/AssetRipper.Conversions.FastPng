using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1JI@IFFHKEFF@?$AAd?$AAh?$AA?4?$AAm?$AA_?$AAh?$AAu?$AAf?$AAf?$AA_?$AAc?$AAo?$AAd?$AAe?$AAs?$AA?$FL?$AA1?$AA?$FN?$AA?$FL?$AAd?$AAi?$AAs?$AAt?$AA_?$AAs?$AAy?$AAm?$AA?$FN?$AA?5?$AA?$DN?$AA?$DN?$AA?5@")]
[DemangledName("L\"dh.m_huff_codes[1][dist_sym] == \"...")]
[CleanName("String")]
internal static partial class String_df5ko9b
{
	public unsafe static InlineArray_76_oeds4ea* __pointer;

	public unsafe static InlineArray_76_oeds4ea Value
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

	unsafe static String_df5ko9b()
	{
		__pointer = unchecked((InlineArray_76_oeds4ea*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_76_oeds4ea))));
		Value = InlineArrayHelper.Create<InlineArray_76_oeds4ea, char>("dh.m_huff_codes[1][dist_sym] == 0 && dh.m_huff_code_sizes[1][dist_sym] == 1\0".ToCharacterSpan());
	}
}
