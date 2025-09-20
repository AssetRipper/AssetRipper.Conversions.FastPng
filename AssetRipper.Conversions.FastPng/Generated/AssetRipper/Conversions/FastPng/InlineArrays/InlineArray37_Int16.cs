using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(37)]
public partial struct InlineArray37_Int16 : IEquatable<InlineArray37_Int16>, IEqualityOperators<InlineArray37_Int16, InlineArray37_Int16, bool>, IEnumerable, IInlineArray<InlineArray37_Int16, short>, IInlineArray<InlineArray37_Int16, ushort>, IInlineArray<InlineArray37_Int16, char>
{
	private short __element0;

	public static int Length => 37;

	public static bool operator ==(InlineArray37_Int16 x, InlineArray37_Int16 y)
	{
		return InlineArrayHelper.Equals<InlineArray37_Int16, short>(x, y);
	}

	public static bool operator !=(InlineArray37_Int16 x, InlineArray37_Int16 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray37_Int16 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray37_Int16)
		{
			return Equals((InlineArray37_Int16)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray37_Int16, short>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<short>)this).GetEnumerator();
	}
}
