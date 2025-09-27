using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1CG@LKELDOLB@?$AAb?$AAi?$AAt?$AA_?$AAb?$AAu?$AAf?$AA_?$AAs?$AAi?$AAz?$AAe?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AA6?$AA4?$AA?$AA@")]
[DemangledName("L\"bit_buf_size <= 64\"")]
[CleanName("String")]
internal static partial class String_mggwlgb
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

	unsafe static String_mggwlgb()
	{
		__pointer = unchecked((InlineArray19_Int16*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray19_Int16))));
		Value = InlineArrayHelper.Create<InlineArray19_Int16, char>("bit_buf_size <= 64\0");
	}
}
