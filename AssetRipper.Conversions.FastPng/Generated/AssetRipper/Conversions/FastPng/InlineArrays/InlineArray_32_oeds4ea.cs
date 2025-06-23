using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(32)]
public partial struct InlineArray_32_oeds4ea : IInlineArray<short>, IInlineArray<ushort>, IInlineArray<char>
{
	private short __element0;

	public static int Length => 32;

	static int IInlineArray<ushort>.Length => 32;

	static int IInlineArray<char>.Length => 32;
}
