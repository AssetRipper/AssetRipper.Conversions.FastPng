using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1BO@DPMPJCNO@?$AAl?$AA?5?$AA?$CG?$AA?$CG?$AA?5?$AA?$CI?$AAl?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AA3?$AA2?$AA?$CJ?$AA?$AA@")]
[DemangledName("L\"l && (l <= 32)\"")]
[CleanName("String")]
internal static partial class String_aa3exrc
{
	public unsafe static InlineArray15_Int16* __pointer;

	public unsafe static InlineArray15_Int16 Value
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

	unsafe static String_aa3exrc()
	{
		__pointer = unchecked((InlineArray15_Int16*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray15_Int16))));
		Value = InlineArrayHelper.Create<InlineArray15_Int16, char>("l && (l <= 32)\0".ToCharacterSpan());
	}
}
