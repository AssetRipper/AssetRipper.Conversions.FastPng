using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(288)]
public partial struct InlineArray_288_oeds4ea : IInlineArray<short>, IInlineArray<ushort>, IInlineArray<char>
{
	private short __element0;

	public static int Length => 288;

	static int IInlineArray<ushort>.Length => 288;

	static int IInlineArray<char>.Length => 288;
}
