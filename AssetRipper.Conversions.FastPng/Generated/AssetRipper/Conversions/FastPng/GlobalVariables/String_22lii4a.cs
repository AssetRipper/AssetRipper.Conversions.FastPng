using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_C@_04DGOOLJLG@fdEC?$AA@")]
[DemangledName("\"fdEC\"")]
[CleanName("String")]
internal static partial class String_22lii4a
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

	unsafe static String_22lii4a()
	{
		__pointer = unchecked((InlineArray5_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray5_SByte))));
		Value = InlineArrayHelper.Create<InlineArray5_SByte, byte>("fdEC\0"u8);
	}
}
