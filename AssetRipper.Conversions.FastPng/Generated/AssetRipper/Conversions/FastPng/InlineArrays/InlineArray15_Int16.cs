using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(15)]
public partial struct InlineArray15_Int16 : IEquatable<InlineArray15_Int16>, IEqualityOperators<InlineArray15_Int16, InlineArray15_Int16, bool>, IEnumerable, IInlineArray<InlineArray15_Int16, short>, IInlineArray<InlineArray15_Int16, ushort>, IInlineArray<InlineArray15_Int16, char>
{
	private short __element0;

	public static int Length => 15;

	public static bool operator ==(InlineArray15_Int16 x, InlineArray15_Int16 y)
	{
		return InlineArrayHelper.Equals<InlineArray15_Int16, short>(x, y);
	}

	public static bool operator !=(InlineArray15_Int16 x, InlineArray15_Int16 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray15_Int16 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray15_Int16)
		{
			return Equals((InlineArray15_Int16)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray15_Int16, short>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<short>)this).GetEnumerator();
	}
}
