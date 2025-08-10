using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1FA@FOPIPCKM@?$AA?$CI?$AAo?$AAu?$AAt?$AA_?$AAo?$AAf?$AAs?$AA?5?$AA?$CL?$AA?5?$AAz?$AAl?$AAi?$AAb?$AA_?$AAs?$AAi?$AAz?$AAe?$AA?$CJ?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AAo?$AAu?$AAt?$AA_?$AAb?$AAu?$AAf@")]
[DemangledName("L\"(out_ofs + zlib_size) <= out_buf\"...")]
[CleanName("String")]
internal static partial class String_dqvhqxc
{
	public unsafe static InlineArray_40_oeds4ea* __pointer;

	public unsafe static InlineArray_40_oeds4ea Value
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
		__pointer = unchecked((InlineArray_40_oeds4ea*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_40_oeds4ea))));
		Value = InlineArrayHelper.Create<InlineArray_40_oeds4ea, char>("(out_ofs + zlib_size) <= out_buf.size()\0".ToCharacterSpan());
	}
}
