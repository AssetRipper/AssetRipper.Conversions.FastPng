using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(28)]
public partial struct InlineArray_28_oeds4ea : IInlineArray<short>, IInlineArray<ushort>, IInlineArray<char>
{
	private short __element0;

	public static int Length => 28;

	static int IInlineArray<ushort>.Length => 28;

	static int IInlineArray<char>.Length => 28;
}
