using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(36)]
public partial struct InlineArray_36_oeds4ea : IInlineArray<short>, IInlineArray<ushort>, IInlineArray<char>
{
	private short __element0;

	public static int Length => 36;

	static int IInlineArray<ushort>.Length => 36;

	static int IInlineArray<char>.Length => 36;
}
