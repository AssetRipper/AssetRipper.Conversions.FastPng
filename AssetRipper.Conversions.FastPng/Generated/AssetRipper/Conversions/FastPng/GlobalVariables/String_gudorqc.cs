using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_0BF@KINCDENJ@bad?5array?5new?5length?$AA@")]
[DemangledName("\"bad array new length\"")]
[CleanName("String")]
internal static partial class String_gudorqc
{
	public unsafe static InlineArray21_SByte* __pointer;

	public unsafe static InlineArray21_SByte Value
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
		__pointer = unchecked((InlineArray21_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray21_SByte))));
		Value = InlineArrayHelper.Create<InlineArray21_SByte, byte>("bad array new length\0"u8);
	}
}
