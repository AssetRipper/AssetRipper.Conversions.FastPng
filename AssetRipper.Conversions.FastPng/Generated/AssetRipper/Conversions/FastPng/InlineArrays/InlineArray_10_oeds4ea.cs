using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(10)]
public partial struct InlineArray_10_oeds4ea : IInlineArray<short>, IInlineArray<ushort>, IInlineArray<char>
{
	private short __element0;

	public static int Length => 10;

	static int IInlineArray<ushort>.Length => 10;

	static int IInlineArray<char>.Length => 10;
}
