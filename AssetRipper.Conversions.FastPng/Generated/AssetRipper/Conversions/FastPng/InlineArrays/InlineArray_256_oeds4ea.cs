using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(256)]
public partial struct InlineArray_256_oeds4ea : IInlineArray<short>, IInlineArray<ushort>, IInlineArray<char>
{
	private short __element0;

	public static int Length => 256;

	static int IInlineArray<ushort>.Length => 256;

	static int IInlineArray<char>.Length => 256;
}
