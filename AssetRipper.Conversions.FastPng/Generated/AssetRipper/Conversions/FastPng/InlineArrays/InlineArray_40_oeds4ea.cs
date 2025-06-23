using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(40)]
public partial struct InlineArray_40_oeds4ea : IInlineArray<short>, IInlineArray<ushort>, IInlineArray<char>
{
	private short __element0;

	public static int Length => 40;

	static int IInlineArray<ushort>.Length => 40;

	static int IInlineArray<char>.Length => 40;
}
