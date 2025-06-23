using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(4)]
public partial struct InlineArray_4_w3otm9c : IInlineArray<sbyte>, IInlineArray<byte>
{
	private sbyte __element0;

	public static int Length => 4;

	static int IInlineArray<byte>.Length => 4;
}
