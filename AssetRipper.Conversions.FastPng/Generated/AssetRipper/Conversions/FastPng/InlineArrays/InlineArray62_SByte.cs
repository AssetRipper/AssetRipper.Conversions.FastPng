using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(62)]
public partial struct InlineArray62_SByte : IEquatable<InlineArray62_SByte>, IEqualityOperators<InlineArray62_SByte, InlineArray62_SByte, bool>, IEnumerable, IInlineArray<InlineArray62_SByte, sbyte>, IInlineArray<InlineArray62_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 62;

	public static bool operator ==(InlineArray62_SByte x, InlineArray62_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray62_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray62_SByte x, InlineArray62_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray62_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray62_SByte)
		{
			return Equals((InlineArray62_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray62_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
