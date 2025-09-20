using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(31)]
public partial struct InlineArray31_Int32 : IEquatable<InlineArray31_Int32>, IEqualityOperators<InlineArray31_Int32, InlineArray31_Int32, bool>, IEnumerable, IInlineArray<InlineArray31_Int32, int>, IInlineArray<InlineArray31_Int32, uint>
{
	private int __element0;

	public static int Length => 31;

	public static bool operator ==(InlineArray31_Int32 x, InlineArray31_Int32 y)
	{
		return InlineArrayHelper.Equals<InlineArray31_Int32, int>(x, y);
	}

	public static bool operator !=(InlineArray31_Int32 x, InlineArray31_Int32 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray31_Int32 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray31_Int32)
		{
			return Equals((InlineArray31_Int32)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray31_Int32, int>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<int>)this).GetEnumerator();
	}
}
