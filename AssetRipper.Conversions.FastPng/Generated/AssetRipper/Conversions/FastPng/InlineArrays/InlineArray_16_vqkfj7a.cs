using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(16)]
public partial struct InlineArray_16_vqkfj7a : IInlineArray<int>, IInlineArray<uint>
{
	private int __element0;

	public static int Length => 16;

	static int IInlineArray<uint>.Length => 16;
}
