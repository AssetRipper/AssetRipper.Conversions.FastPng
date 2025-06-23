using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(4)]
public partial struct InlineArray_4_vjlif9a : IInlineArray<InlineArray_256_vqkfj7a>, IInlineArray<int>, IInlineArray<uint>
{
	private InlineArray_256_vqkfj7a __element0;

	public static int Length => 4;

	static int IInlineArray<int>.Length => 1024;

	static int IInlineArray<uint>.Length => 1024;
}
