using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_13COJANIEC@?$AA0?$AA?$AA@")]
[DemangledName("L\"0\"")]
[CleanName("String")]
internal static partial class String_v852r7
{
	public unsafe static InlineArray2_Int16* __pointer;

	public unsafe static InlineArray2_Int16 Value
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

	unsafe static String_v852r7()
	{
		__pointer = unchecked((InlineArray2_Int16*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray2_Int16))));
		Value = InlineArrayHelper.Create<InlineArray2_Int16, char>("0\0");
	}
}
