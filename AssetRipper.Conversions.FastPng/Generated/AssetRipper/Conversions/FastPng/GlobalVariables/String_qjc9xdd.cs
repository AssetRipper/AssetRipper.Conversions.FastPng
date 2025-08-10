using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_04NHMHICBH@IDAT?$AA@")]
[DemangledName("\"IDAT\"")]
[CleanName("String")]
internal static partial class String_qjc9xdd
{
	public unsafe static InlineArray_5_w3otm9c* __pointer;

	public unsafe static InlineArray_5_w3otm9c Value
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

	unsafe static String_qjc9xdd()
	{
		__pointer = unchecked((InlineArray_5_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_5_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_5_w3otm9c, byte>("IDAT\0"u8);
	}
}
