using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1FA@FOPIPCKM@?$AA?$CI?$AAo?$AAu?$AAt?$AA_?$AAo?$AAf?$AAs?$AA?5?$AA?$CL?$AA?5?$AAz?$AAl?$AAi?$AAb?$AA_?$AAs?$AAi?$AAz?$AAe?$AA?$CJ?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AAo?$AAu?$AAt?$AA_?$AAb?$AAu?$AAf@")]
[DemangledName("L\"(out_ofs + zlib_size) <= out_buf\"...")]
[CleanName("String")]
internal static partial class String_dqvhqxc
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

	unsafe static String_dqvhqxc()
	{
		__pointer = unchecked((InlineArray40_Int16*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray40_Int16))));
		Value = InlineArrayHelper.Create<InlineArray40_Int16, char>("(out_ofs + zlib_size) <= out_buf.size()\0");
	}
}
