using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_13COJANIEC@?$AA0?$AA?$AA@")]
[DemangledName("L\"0\"")]
[CleanName("String")]
internal static partial class String_kdrammb
{
	public unsafe static InlineArray_2_oeds4ea* __pointer;

	public unsafe static InlineArray_2_oeds4ea Value
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

	unsafe static String_kdrammb()
	{
		__pointer = unchecked((InlineArray_2_oeds4ea*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_2_oeds4ea))));
		Value = InlineArrayHelper.Create<InlineArray_2_oeds4ea, char>("0\0".ToCharacterSpan());
	}
}
