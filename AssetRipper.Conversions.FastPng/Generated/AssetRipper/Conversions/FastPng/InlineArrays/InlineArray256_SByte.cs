using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(256)]
public partial struct InlineArray256_SByte : IEquatable<InlineArray256_SByte>, IEqualityOperators<InlineArray256_SByte, InlineArray256_SByte, bool>, IEnumerable, IInlineArray<InlineArray256_SByte, sbyte>, IInlineArray<InlineArray256_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 256;

	public static bool operator ==(InlineArray256_SByte x, InlineArray256_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray256_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray256_SByte x, InlineArray256_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray256_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray256_SByte)
		{
			return Equals((InlineArray256_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray256_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
