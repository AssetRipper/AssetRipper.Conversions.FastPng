using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(320)]
public partial struct InlineArray320_SByte : IEquatable<InlineArray320_SByte>, IEqualityOperators<InlineArray320_SByte, InlineArray320_SByte, bool>, IEnumerable, IInlineArray<InlineArray320_SByte, sbyte>, IInlineArray<InlineArray320_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 320;

	public static bool operator ==(InlineArray320_SByte x, InlineArray320_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray320_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray320_SByte x, InlineArray320_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray320_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray320_SByte)
		{
			return Equals((InlineArray320_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray320_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
