using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(4096)]
public partial struct InlineArray_4096_vqkfj7a : IEquatable<InlineArray_4096_vqkfj7a>, IEqualityOperators<InlineArray_4096_vqkfj7a, InlineArray_4096_vqkfj7a, bool>, IInlineArray<int>, IInlineArray<uint>
{
	private int __element0;

	public static int Length => 4096;

	public static bool operator ==(InlineArray_4096_vqkfj7a x, InlineArray_4096_vqkfj7a y)
	{
		return InlineArrayHelper.Equals<InlineArray_4096_vqkfj7a, int>(x, y);
	}

	public static bool operator !=(InlineArray_4096_vqkfj7a x, InlineArray_4096_vqkfj7a y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_4096_vqkfj7a other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_4096_vqkfj7a)
		{
			return Equals((InlineArray_4096_vqkfj7a)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_4096_vqkfj7a, int>();
	}
}
