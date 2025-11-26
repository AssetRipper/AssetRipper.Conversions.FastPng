using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_0BB@BKMJLBGB@?$AA?$AA?$AA?$AA?$AA?$AA?$AA?$AAIEND?$KOB?$GA?$IC?$AA@")]
[DemangledName("\"\\0\\0\\0\\0\\0\\0\\0\\0IEND\\xAEB`\\x82\"")]
[CleanName("String")]
internal static partial class String_p5jh5t
{
	public unsafe static InlineArray17_SByte* __pointer;

	public unsafe static InlineArray17_SByte Value
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

	unsafe static String_p5jh5t()
	{
		__pointer = unchecked((InlineArray17_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray17_SByte))));
		Value = InlineArrayHelper.Create<InlineArray17_SByte, byte>(new byte[17]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 73, 69,
			78, 68, 174, 66, 96, 130, 0
		});
	}
}
