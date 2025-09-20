using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(40)]
public partial struct InlineArray40_Int16 : IEquatable<InlineArray40_Int16>, IEqualityOperators<InlineArray40_Int16, InlineArray40_Int16, bool>, IEnumerable, IInlineArray<InlineArray40_Int16, short>, IInlineArray<InlineArray40_Int16, ushort>, IInlineArray<InlineArray40_Int16, char>
{
	private short __element0;

	public static int Length => 40;

	public static bool operator ==(InlineArray40_Int16 x, InlineArray40_Int16 y)
	{
		return InlineArrayHelper.Equals<InlineArray40_Int16, short>(x, y);
	}

	public static bool operator !=(InlineArray40_Int16 x, InlineArray40_Int16 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray40_Int16 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray40_Int16)
		{
			return Equals((InlineArray40_Int16)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray40_Int16, short>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<short>)this).GetEnumerator();
	}
}
