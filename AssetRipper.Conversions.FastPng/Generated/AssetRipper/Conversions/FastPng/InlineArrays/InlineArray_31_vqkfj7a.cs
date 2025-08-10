using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(31)]
public partial struct InlineArray_31_vqkfj7a : IEquatable<InlineArray_31_vqkfj7a>, IEqualityOperators<InlineArray_31_vqkfj7a, InlineArray_31_vqkfj7a, bool>, IInlineArray<int>, IInlineArray<uint>
{
	private int __element0;

	public static int Length => 31;

	public static bool operator ==(InlineArray_31_vqkfj7a x, InlineArray_31_vqkfj7a y)
	{
		return InlineArrayHelper.Equals<InlineArray_31_vqkfj7a, int>(x, y);
	}

	public static bool operator !=(InlineArray_31_vqkfj7a x, InlineArray_31_vqkfj7a y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_31_vqkfj7a other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_31_vqkfj7a)
		{
			return Equals((InlineArray_31_vqkfj7a)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_31_vqkfj7a, int>();
	}
}
