using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(61)]
public partial struct InlineArray_61_w3otm9c : IEquatable<InlineArray_61_w3otm9c>, IEqualityOperators<InlineArray_61_w3otm9c, InlineArray_61_w3otm9c, bool>, IInlineArray<sbyte>, IInlineArray<byte>
{
	private sbyte __element0;

	public static int Length => 61;

	public static bool operator ==(InlineArray_61_w3otm9c x, InlineArray_61_w3otm9c y)
	{
		return InlineArrayHelper.Equals<InlineArray_61_w3otm9c, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray_61_w3otm9c x, InlineArray_61_w3otm9c y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_61_w3otm9c other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_61_w3otm9c)
		{
			return Equals((InlineArray_61_w3otm9c)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_61_w3otm9c, sbyte>();
	}
}
