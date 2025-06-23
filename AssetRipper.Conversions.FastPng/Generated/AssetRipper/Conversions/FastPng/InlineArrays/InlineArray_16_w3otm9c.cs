using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(16)]
public partial struct InlineArray_16_w3otm9c : IInlineArray<sbyte>, IInlineArray<byte>
{
	private sbyte __element0;

	public static int Length => 16;

	static int IInlineArray<byte>.Length => 16;
}
