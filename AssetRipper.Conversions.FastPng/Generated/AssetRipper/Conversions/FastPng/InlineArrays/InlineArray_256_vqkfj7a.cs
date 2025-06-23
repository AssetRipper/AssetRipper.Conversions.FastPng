using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(256)]
public partial struct InlineArray_256_vqkfj7a : IInlineArray<int>, IInlineArray<uint>
{
	private int __element0;

	public static int Length => 256;

	static int IInlineArray<uint>.Length => 256;
}
