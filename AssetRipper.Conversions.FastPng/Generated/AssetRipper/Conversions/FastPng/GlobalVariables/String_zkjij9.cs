using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_04NHMHICBH@IDAT?$AA@")]
[DemangledName("\"IDAT\"")]
[CleanName("String")]
internal static partial class String_zkjij9
{
	public unsafe static InlineArray5_SByte* __pointer;

	public unsafe static InlineArray5_SByte Value
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

	unsafe static String_zkjij9()
	{
		__pointer = unchecked((InlineArray5_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray5_SByte))));
		Value = InlineArrayHelper.Create<InlineArray5_SByte, byte>("IDAT\0"u8);
	}
}
