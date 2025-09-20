using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(18)]
public partial struct InlineArray18_Int16 : IEquatable<InlineArray18_Int16>, IEqualityOperators<InlineArray18_Int16, InlineArray18_Int16, bool>, IEnumerable, IInlineArray<InlineArray18_Int16, short>, IInlineArray<InlineArray18_Int16, ushort>, IInlineArray<InlineArray18_Int16, char>
{
	private short __element0;

	public static int Length => 18;

	public static bool operator ==(InlineArray18_Int16 x, InlineArray18_Int16 y)
	{
		return InlineArrayHelper.Equals<InlineArray18_Int16, short>(x, y);
	}

	public static bool operator !=(InlineArray18_Int16 x, InlineArray18_Int16 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray18_Int16 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray18_Int16)
		{
			return Equals((InlineArray18_Int16)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray18_Int16, short>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<short>)this).GetEnumerator();
	}
}
