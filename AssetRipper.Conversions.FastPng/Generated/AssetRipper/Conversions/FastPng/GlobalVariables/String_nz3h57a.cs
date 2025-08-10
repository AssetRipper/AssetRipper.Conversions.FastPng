using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_0BB@BKMJLBGB@?$AA?$AA?$AA?$AA?$AA?$AA?$AA?$AAIEND?$KOB?$GA?$IC?$AA@")]
[DemangledName("\"\\0\\0\\0\\0\\0\\0\\0\\0IEND\\xAEB`\\x82\"")]
[CleanName("String")]
internal static partial class String_nz3h57a
{
	public unsafe static InlineArray_17_w3otm9c* __pointer;

	public unsafe static InlineArray_17_w3otm9c Value
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

	unsafe static String_nz3h57a()
	{
		__pointer = unchecked((InlineArray_17_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_17_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_17_w3otm9c, byte>(new byte[17]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 73, 69,
			78, 68, 174, 66, 96, 130, 0
		});
	}
}
