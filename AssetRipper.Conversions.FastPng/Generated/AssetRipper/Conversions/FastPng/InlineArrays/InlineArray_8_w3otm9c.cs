using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(8)]
public partial struct InlineArray_8_w3otm9c : IInlineArray<sbyte>, IInlineArray<byte>
{
	private sbyte __element0;

	public static int Length => 8;

	static int IInlineArray<byte>.Length => 8;
}
