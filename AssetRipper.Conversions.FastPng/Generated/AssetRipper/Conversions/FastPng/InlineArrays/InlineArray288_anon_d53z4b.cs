using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(288)]
public partial struct InlineArray288_anon_d53z4b : IEquatable<InlineArray288_anon_d53z4b>, IEqualityOperators<InlineArray288_anon_d53z4b, InlineArray288_anon_d53z4b, bool>, IEnumerable, IInlineArray<InlineArray288_anon_d53z4b, anon_d53z4b>
{
	private anon_d53z4b __element0;

	public static int Length => 288;

	public static bool operator ==(InlineArray288_anon_d53z4b x, InlineArray288_anon_d53z4b y)
	{
		return InlineArrayHelper.Equals<InlineArray288_anon_d53z4b, anon_d53z4b>(x, y);
	}

	public static bool operator !=(InlineArray288_anon_d53z4b x, InlineArray288_anon_d53z4b y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray288_anon_d53z4b other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray288_anon_d53z4b)
		{
			return Equals((InlineArray288_anon_d53z4b)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray288_anon_d53z4b, anon_d53z4b>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<anon_d53z4b>)this).GetEnumerator();
	}
}
