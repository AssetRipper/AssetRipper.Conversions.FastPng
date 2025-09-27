using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_1BA@ONNHMHEP@?$AAl?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AA3?$AA2?$AA?$AA@")]
[DemangledName("L\"l <= 32\"")]
[CleanName("String")]
internal static partial class String_mf9hyza
{
	public unsafe static InlineArray8_Int16* __pointer;

	public unsafe static InlineArray8_Int16 Value
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
		__pointer = unchecked((InlineArray8_Int16*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray8_Int16))));
		Value = InlineArrayHelper.Create<InlineArray8_Int16, char>("l <= 32\0");
	}
}
