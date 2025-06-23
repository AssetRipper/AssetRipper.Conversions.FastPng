using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(5)]
public partial struct InlineArray_5_w3otm9c : IInlineArray<sbyte>, IInlineArray<byte>
{
	private sbyte __element0;

	public static int Length => 5;

	static int IInlineArray<byte>.Length => 5;
}
