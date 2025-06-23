using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(512)]
public partial struct InlineArray_512_vqkfj7a : IInlineArray<int>, IInlineArray<uint>
{
	private int __element0;

	public static int Length => 512;

	static int IInlineArray<uint>.Length => 512;
}
