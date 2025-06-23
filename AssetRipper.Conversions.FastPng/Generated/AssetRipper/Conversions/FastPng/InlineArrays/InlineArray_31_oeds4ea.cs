using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(31)]
public partial struct InlineArray_31_oeds4ea : IInlineArray<short>, IInlineArray<ushort>, IInlineArray<char>
{
	private short __element0;

	public static int Length => 31;

	static int IInlineArray<ushort>.Length => 31;

	static int IInlineArray<char>.Length => 31;
}
