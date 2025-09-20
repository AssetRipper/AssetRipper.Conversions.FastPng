using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(288)]
public partial struct InlineArray288_SByte : IEquatable<InlineArray288_SByte>, IEqualityOperators<InlineArray288_SByte, InlineArray288_SByte, bool>, IEnumerable, IInlineArray<InlineArray288_SByte, sbyte>, IInlineArray<InlineArray288_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 288;

	public static bool operator ==(InlineArray288_SByte x, InlineArray288_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray288_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray288_SByte x, InlineArray288_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray288_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray288_SByte)
		{
			return Equals((InlineArray288_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray288_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
