using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(18)]
public partial struct InlineArray18_SByte : IEquatable<InlineArray18_SByte>, IEqualityOperators<InlineArray18_SByte, InlineArray18_SByte, bool>, IEnumerable, IInlineArray<InlineArray18_SByte, sbyte>, IInlineArray<InlineArray18_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 18;

	public static bool operator ==(InlineArray18_SByte x, InlineArray18_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray18_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray18_SByte x, InlineArray18_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray18_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray18_SByte)
		{
			return Equals((InlineArray18_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray18_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
