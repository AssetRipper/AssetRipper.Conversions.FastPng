using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_0BF@KINCDENJ@bad?5array?5new?5length?$AA@")]
[DemangledName("\"bad array new length\"")]
[CleanName("String")]
internal static partial class String_gudorqc
{
	public unsafe static InlineArray_21_w3otm9c* __pointer;

	public unsafe static InlineArray_21_w3otm9c Value
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

	unsafe static String_gudorqc()
	{
		__pointer = unchecked((InlineArray_21_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_21_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_21_w3otm9c, byte>("bad array new length\0"u8);
	}
}
