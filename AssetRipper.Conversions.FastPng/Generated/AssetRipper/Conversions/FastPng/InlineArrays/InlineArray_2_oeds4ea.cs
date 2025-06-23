using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(2)]
public partial struct InlineArray_2_oeds4ea : IInlineArray<short>, IInlineArray<ushort>, IInlineArray<char>
{
	private short __element0;

	public static int Length => 2;

	static int IInlineArray<ushort>.Length => 2;

	static int IInlineArray<char>.Length => 2;
}
