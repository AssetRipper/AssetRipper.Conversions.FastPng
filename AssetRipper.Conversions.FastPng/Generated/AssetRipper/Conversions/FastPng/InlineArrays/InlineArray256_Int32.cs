using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(256)]
public partial struct InlineArray256_Int32 : IEquatable<InlineArray256_Int32>, IEqualityOperators<InlineArray256_Int32, InlineArray256_Int32, bool>, IEnumerable, IInlineArray<InlineArray256_Int32, int>, IInlineArray<InlineArray256_Int32, uint>
{
	private int __element0;

	public static int Length => 256;

	public static bool operator ==(InlineArray256_Int32 x, InlineArray256_Int32 y)
	{
		return InlineArrayHelper.Equals<InlineArray256_Int32, int>(x, y);
	}

	public static bool operator !=(InlineArray256_Int32 x, InlineArray256_Int32 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray256_Int32 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray256_Int32)
		{
			return Equals((InlineArray256_Int32)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray256_Int32, int>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<int>)this).GetEnumerator();
	}
}
