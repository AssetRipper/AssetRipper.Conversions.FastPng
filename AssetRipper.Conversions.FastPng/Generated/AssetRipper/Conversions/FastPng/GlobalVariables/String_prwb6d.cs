using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1CE@GPOANAFC@?$AAb?$AAi?$AAt?$AA_?$AAb?$AAu?$AAf?$AA_?$AAs?$AAi?$AAz?$AAe?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AA7?$AA?$AA@")]
[DemangledName("L\"bit_buf_size <= 7\"")]
[CleanName("String")]
internal static partial class String_prwb6d
{
	public unsafe static InlineArray18_Int16* __pointer;

	public unsafe static InlineArray18_Int16 Value
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

	unsafe static String_prwb6d()
	{
		__pointer = unchecked((InlineArray18_Int16*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray18_Int16))));
		Value = InlineArrayHelper.Create<InlineArray18_Int16, char>("bit_buf_size <= 7\0");
	}
}
