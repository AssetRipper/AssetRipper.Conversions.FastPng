using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(22)]
public partial struct InlineArray_22_oeds4ea : IInlineArray<short>, IInlineArray<ushort>, IInlineArray<char>
{
	private short __element0;

	public static int Length => 22;

	static int IInlineArray<ushort>.Length => 22;

	static int IInlineArray<char>.Length => 22;
}
