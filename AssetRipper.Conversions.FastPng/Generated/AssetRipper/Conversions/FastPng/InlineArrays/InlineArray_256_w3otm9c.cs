using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(256)]
public partial struct InlineArray_256_w3otm9c : IEquatable<InlineArray_256_w3otm9c>, IEqualityOperators<InlineArray_256_w3otm9c, InlineArray_256_w3otm9c, bool>, IEnumerable, IInlineArray<InlineArray_256_w3otm9c, sbyte>, IInlineArray<InlineArray_256_w3otm9c, byte>
{
	private sbyte __element0;

	public static int Length => 256;

	public static bool operator ==(InlineArray_256_w3otm9c x, InlineArray_256_w3otm9c y)
	{
		return InlineArrayHelper.Equals<InlineArray_256_w3otm9c, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray_256_w3otm9c x, InlineArray_256_w3otm9c y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_256_w3otm9c other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_256_w3otm9c)
		{
			return Equals((InlineArray_256_w3otm9c)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_256_w3otm9c, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
