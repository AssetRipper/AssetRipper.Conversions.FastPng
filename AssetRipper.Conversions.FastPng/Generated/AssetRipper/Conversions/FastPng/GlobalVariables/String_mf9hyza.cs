using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1BA@ONNHMHEP@?$AAl?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AA3?$AA2?$AA?$AA@")]
[DemangledName("L\"l <= 32\"")]
[CleanName("String")]
internal static partial class String_mf9hyza
{
	public unsafe static InlineArray_8_oeds4ea* __pointer;

	public unsafe static InlineArray_8_oeds4ea Value
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

	unsafe static String_mf9hyza()
	{
		__pointer = unchecked((InlineArray_8_oeds4ea*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_8_oeds4ea))));
		Value = InlineArrayHelper.Create<InlineArray_8_oeds4ea, char>("l <= 32\0".ToCharacterSpan());
	}
}
