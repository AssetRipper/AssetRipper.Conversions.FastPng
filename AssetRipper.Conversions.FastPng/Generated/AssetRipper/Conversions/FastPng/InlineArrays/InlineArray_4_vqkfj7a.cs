using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(4)]
public partial struct InlineArray_4_vqkfj7a : IEquatable<InlineArray_4_vqkfj7a>, IEqualityOperators<InlineArray_4_vqkfj7a, InlineArray_4_vqkfj7a, bool>, IEnumerable, IInlineArray<InlineArray_4_vqkfj7a, int>, IInlineArray<InlineArray_4_vqkfj7a, uint>
{
	private int __element0;

	public static int Length => 4;

	public static bool operator ==(InlineArray_4_vqkfj7a x, InlineArray_4_vqkfj7a y)
	{
		return InlineArrayHelper.Equals<InlineArray_4_vqkfj7a, int>(x, y);
	}

	public static bool operator !=(InlineArray_4_vqkfj7a x, InlineArray_4_vqkfj7a y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_4_vqkfj7a other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_4_vqkfj7a)
		{
			return Equals((InlineArray_4_vqkfj7a)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_4_vqkfj7a, int>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<int>)this).GetEnumerator();
	}
}
