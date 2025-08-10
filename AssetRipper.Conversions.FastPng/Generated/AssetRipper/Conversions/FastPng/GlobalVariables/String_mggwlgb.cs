using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1CG@LKELDOLB@?$AAb?$AAi?$AAt?$AA_?$AAb?$AAu?$AAf?$AA_?$AAs?$AAi?$AAz?$AAe?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AA6?$AA4?$AA?$AA@")]
[DemangledName("L\"bit_buf_size <= 64\"")]
[CleanName("String")]
internal static partial class String_mggwlgb
{
	public unsafe static InlineArray_19_oeds4ea* __pointer;

	public unsafe static InlineArray_19_oeds4ea Value
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

	unsafe static String_mggwlgb()
	{
		__pointer = unchecked((InlineArray_19_oeds4ea*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_19_oeds4ea))));
		Value = InlineArrayHelper.Create<InlineArray_19_oeds4ea, char>("bit_buf_size <= 64\0".ToCharacterSpan());
	}
}
