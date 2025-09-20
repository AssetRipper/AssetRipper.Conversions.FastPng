using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(58)]
public partial struct InlineArray58_SByte : IEquatable<InlineArray58_SByte>, IEqualityOperators<InlineArray58_SByte, InlineArray58_SByte, bool>, IEnumerable, IInlineArray<InlineArray58_SByte, sbyte>, IInlineArray<InlineArray58_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 58;

	public static bool operator ==(InlineArray58_SByte x, InlineArray58_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray58_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray58_SByte x, InlineArray58_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray58_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray58_SByte)
		{
			return Equals((InlineArray58_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray58_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
