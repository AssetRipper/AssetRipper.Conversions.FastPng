using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(320)]
public partial struct InlineArray_320_w3otm9c : IEquatable<InlineArray_320_w3otm9c>, IEqualityOperators<InlineArray_320_w3otm9c, InlineArray_320_w3otm9c, bool>, IInlineArray<sbyte>, IInlineArray<byte>
{
	private sbyte __element0;

	public static int Length => 320;

	public static bool operator ==(InlineArray_320_w3otm9c x, InlineArray_320_w3otm9c y)
	{
		return InlineArrayHelper.Equals<InlineArray_320_w3otm9c, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray_320_w3otm9c x, InlineArray_320_w3otm9c y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_320_w3otm9c other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_320_w3otm9c)
		{
			return Equals((InlineArray_320_w3otm9c)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_320_w3otm9c, sbyte>();
	}
}
