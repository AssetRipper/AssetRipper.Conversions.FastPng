using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(8)]
public partial struct InlineArray_8_oeds4ea : IInlineArray<short>, IInlineArray<ushort>, IInlineArray<char>
{
	private short __element0;

	public static int Length => 8;

	static int IInlineArray<ushort>.Length => 8;

	static int IInlineArray<char>.Length => 8;
}
