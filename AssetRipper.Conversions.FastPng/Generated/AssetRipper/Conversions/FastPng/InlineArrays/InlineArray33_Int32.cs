using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(33)]
public partial struct InlineArray33_Int32 : IEquatable<InlineArray33_Int32>, IEqualityOperators<InlineArray33_Int32, InlineArray33_Int32, bool>, IEnumerable, IInlineArray<InlineArray33_Int32, int>, IInlineArray<InlineArray33_Int32, uint>
{
	private int __element0;

	public static int Length => 33;

	public static bool operator ==(InlineArray33_Int32 x, InlineArray33_Int32 y)
	{
		return InlineArrayHelper.Equals<InlineArray33_Int32, int>(x, y);
	}

	public static bool operator !=(InlineArray33_Int32 x, InlineArray33_Int32 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray33_Int32 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray33_Int32)
		{
			return Equals((InlineArray33_Int32)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray33_Int32, int>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<int>)this).GetEnumerator();
	}
}
