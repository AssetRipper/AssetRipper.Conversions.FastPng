using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(5)]
public partial struct InlineArray5_SByte : IEquatable<InlineArray5_SByte>, IEqualityOperators<InlineArray5_SByte, InlineArray5_SByte, bool>, IEnumerable, IInlineArray<InlineArray5_SByte, sbyte>, IInlineArray<InlineArray5_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 5;

	public static bool operator ==(InlineArray5_SByte x, InlineArray5_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray5_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray5_SByte x, InlineArray5_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray5_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray5_SByte)
		{
			return Equals((InlineArray5_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray5_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
