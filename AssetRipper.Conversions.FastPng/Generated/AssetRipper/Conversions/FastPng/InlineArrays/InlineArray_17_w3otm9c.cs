using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(17)]
public partial struct InlineArray_17_w3otm9c : IEquatable<InlineArray_17_w3otm9c>, IEqualityOperators<InlineArray_17_w3otm9c, InlineArray_17_w3otm9c, bool>, IInlineArray<sbyte>, IInlineArray<byte>
{
	private sbyte __element0;

	public static int Length => 17;

	public static bool operator ==(InlineArray_17_w3otm9c x, InlineArray_17_w3otm9c y)
	{
		return InlineArrayHelper.Equals<InlineArray_17_w3otm9c, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray_17_w3otm9c x, InlineArray_17_w3otm9c y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_17_w3otm9c other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_17_w3otm9c)
		{
			return Equals((InlineArray_17_w3otm9c)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_17_w3otm9c, sbyte>();
	}
}
