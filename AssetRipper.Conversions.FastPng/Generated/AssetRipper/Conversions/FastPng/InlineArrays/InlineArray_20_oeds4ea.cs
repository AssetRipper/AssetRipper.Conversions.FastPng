using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(20)]
public partial struct InlineArray_20_oeds4ea : IInlineArray<short>, IInlineArray<ushort>, IInlineArray<char>
{
	private short __element0;

	public static int Length => 20;

	static int IInlineArray<ushort>.Length => 20;

	static int IInlineArray<char>.Length => 20;
}
