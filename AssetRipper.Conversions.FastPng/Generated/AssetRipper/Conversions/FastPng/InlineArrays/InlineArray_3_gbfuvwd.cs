using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(3)]
public partial struct InlineArray_3_gbfuvwd : IInlineArray<nint>, IInlineArray<nuint>
{
	private nint __element0;

	public static int Length => 3;

	static int IInlineArray<nuint>.Length => 3;
}
