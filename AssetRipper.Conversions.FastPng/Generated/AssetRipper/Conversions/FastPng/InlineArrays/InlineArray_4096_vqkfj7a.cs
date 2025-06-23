using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(4096)]
public partial struct InlineArray_4096_vqkfj7a : IInlineArray<int>, IInlineArray<uint>
{
	private int __element0;

	public static int Length => 4096;

	static int IInlineArray<uint>.Length => 4096;
}
