using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(76)]
public partial struct InlineArray76_Int16 : IEquatable<InlineArray76_Int16>, IEqualityOperators<InlineArray76_Int16, InlineArray76_Int16, bool>, IEnumerable, IInlineArray<InlineArray76_Int16, short>, IInlineArray<InlineArray76_Int16, ushort>, IInlineArray<InlineArray76_Int16, char>
{
	private short __element0;

	public static int Length => 76;

	public static bool operator ==(InlineArray76_Int16 x, InlineArray76_Int16 y)
	{
		return InlineArrayHelper.Equals<InlineArray76_Int16, short>(x, y);
	}

	public static bool operator !=(InlineArray76_Int16 x, InlineArray76_Int16 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray76_Int16 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray76_Int16)
		{
			return Equals((InlineArray76_Int16)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray76_Int16, short>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<short>)this).GetEnumerator();
	}
}
