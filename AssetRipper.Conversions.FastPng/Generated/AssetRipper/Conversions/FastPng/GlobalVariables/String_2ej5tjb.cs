using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1CG@JFLKAPAP@?$AAb?$AAi?$AAt?$AAs?$AA_?$AAt?$AAo?$AA_?$AAs?$AAh?$AAi?$AAf?$AAt?$AA?5?$AA?$DM?$AA?5?$AA6?$AA4?$AA?$AA@")]
[DemangledName("L\"bits_to_shift < 64\"")]
[CleanName("String")]
internal static partial class String_2ej5tjb
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

	unsafe static String_2ej5tjb()
	{
		__pointer = unchecked((InlineArray_19_oeds4ea*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_19_oeds4ea))));
		Value = InlineArrayHelper.Create<InlineArray_19_oeds4ea, char>("bits_to_shift < 64\0".ToCharacterSpan());
	}
}
