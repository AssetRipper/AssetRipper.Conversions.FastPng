using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(256)]
public partial struct InlineArray_256_vqkfj7a : IEquatable<InlineArray_256_vqkfj7a>, IEqualityOperators<InlineArray_256_vqkfj7a, InlineArray_256_vqkfj7a, bool>, IEnumerable, IInlineArray<InlineArray_256_vqkfj7a, int>, IInlineArray<InlineArray_256_vqkfj7a, uint>
{
	private int __element0;

	public static int Length => 256;

	public static bool operator ==(InlineArray_256_vqkfj7a x, InlineArray_256_vqkfj7a y)
	{
		return InlineArrayHelper.Equals<InlineArray_256_vqkfj7a, int>(x, y);
	}

	public static bool operator !=(InlineArray_256_vqkfj7a x, InlineArray_256_vqkfj7a y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_256_vqkfj7a other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_256_vqkfj7a)
		{
			return Equals((InlineArray_256_vqkfj7a)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_256_vqkfj7a, int>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<int>)this).GetEnumerator();
	}
}
