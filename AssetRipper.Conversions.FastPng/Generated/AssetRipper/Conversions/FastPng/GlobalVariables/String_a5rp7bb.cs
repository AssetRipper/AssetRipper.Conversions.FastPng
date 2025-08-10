using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1CG@ELPAFFDG@?$AA?$CI?$AAr?$AAu?$AAn?$AA_?$AAl?$AAe?$AAn?$AA?5?$AA?$CF?$AA?5?$AA3?$AA?$CJ?$AA?5?$AA?$DN?$AA?$DN?$AA?5?$AA0?$AA?$AA@")]
[DemangledName("L\"(run_len % 3) == 0\"")]
[CleanName("String")]
internal static partial class String_a5rp7bb
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

	unsafe static String_a5rp7bb()
	{
		__pointer = unchecked((InlineArray_19_oeds4ea*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_19_oeds4ea))));
		Value = InlineArrayHelper.Create<InlineArray_19_oeds4ea, char>("(run_len % 3) == 0\0".ToCharacterSpan());
	}
}
