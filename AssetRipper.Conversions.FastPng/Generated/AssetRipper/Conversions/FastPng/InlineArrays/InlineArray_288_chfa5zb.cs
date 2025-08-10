using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(288)]
public partial struct InlineArray_288_chfa5zb : IEquatable<InlineArray_288_chfa5zb>, IEqualityOperators<InlineArray_288_chfa5zb, InlineArray_288_chfa5zb, bool>, IInlineArray<anon>
{
	private anon __element0;

	public static int Length => 288;

	public static bool operator ==(InlineArray_288_chfa5zb x, InlineArray_288_chfa5zb y)
	{
		return InlineArrayHelper.Equals<InlineArray_288_chfa5zb, anon>(x, y);
	}

	public static bool operator !=(InlineArray_288_chfa5zb x, InlineArray_288_chfa5zb y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_288_chfa5zb other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_288_chfa5zb)
		{
			return Equals((InlineArray_288_chfa5zb)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_288_chfa5zb, anon>();
	}
}
