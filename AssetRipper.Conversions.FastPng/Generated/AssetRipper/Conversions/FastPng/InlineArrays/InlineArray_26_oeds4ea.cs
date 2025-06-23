using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(26)]
public partial struct InlineArray_26_oeds4ea : IInlineArray<short>, IInlineArray<ushort>, IInlineArray<char>
{
	private short __element0;

	public static int Length => 26;

	static int IInlineArray<ushort>.Length => 26;

	static int IInlineArray<char>.Length => 26;
}
