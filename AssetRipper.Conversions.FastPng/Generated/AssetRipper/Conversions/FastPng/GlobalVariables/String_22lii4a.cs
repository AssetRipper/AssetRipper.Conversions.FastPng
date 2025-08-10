using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_04DGOOLJLG@fdEC?$AA@")]
[DemangledName("\"fdEC\"")]
[CleanName("String")]
internal static partial class String_22lii4a
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

	unsafe static String_22lii4a()
	{
		__pointer = unchecked((InlineArray_5_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_5_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_5_w3otm9c, byte>("fdEC\0"u8);
	}
}
