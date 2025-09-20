using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(288)]
public partial struct InlineArray288_Int32 : IEquatable<InlineArray288_Int32>, IEqualityOperators<InlineArray288_Int32, InlineArray288_Int32, bool>, IEnumerable, IInlineArray<InlineArray288_Int32, int>, IInlineArray<InlineArray288_Int32, uint>
{
	private int __element0;

	public static int Length => 288;

	public static bool operator ==(InlineArray288_Int32 x, InlineArray288_Int32 y)
	{
		return InlineArrayHelper.Equals<InlineArray288_Int32, int>(x, y);
	}

	public static bool operator !=(InlineArray288_Int32 x, InlineArray288_Int32 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray288_Int32 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray288_Int32)
		{
			return Equals((InlineArray288_Int32)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray288_Int32, int>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<int>)this).GetEnumerator();
	}
}
