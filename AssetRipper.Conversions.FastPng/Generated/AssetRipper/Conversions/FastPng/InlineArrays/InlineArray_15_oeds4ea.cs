using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(15)]
public partial struct InlineArray_15_oeds4ea : IInlineArray<short>, IInlineArray<ushort>, IInlineArray<char>
{
	private short __element0;

	public static int Length => 15;

	static int IInlineArray<ushort>.Length => 15;

	static int IInlineArray<char>.Length => 15;
}
