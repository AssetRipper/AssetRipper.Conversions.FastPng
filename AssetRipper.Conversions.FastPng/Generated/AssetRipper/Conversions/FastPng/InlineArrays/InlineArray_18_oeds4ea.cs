using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(18)]
public partial struct InlineArray_18_oeds4ea : IInlineArray<short>, IInlineArray<ushort>, IInlineArray<char>
{
	private short __element0;

	public static int Length => 18;

	static int IInlineArray<ushort>.Length => 18;

	static int IInlineArray<char>.Length => 18;
}
