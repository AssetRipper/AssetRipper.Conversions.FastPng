using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(288)]
public partial struct InlineArray288_anon_atvx4gd : IEquatable<InlineArray288_anon_atvx4gd>, IEqualityOperators<InlineArray288_anon_atvx4gd, InlineArray288_anon_atvx4gd, bool>, IEnumerable, IInlineArray<InlineArray288_anon_atvx4gd, anon_atvx4gd>
{
	private anon_atvx4gd __element0;

	public static int Length => 288;

	public static bool operator ==(InlineArray288_anon_atvx4gd x, InlineArray288_anon_atvx4gd y)
	{
		return InlineArrayHelper.Equals<InlineArray288_anon_atvx4gd, anon_atvx4gd>(x, y);
	}

	public static bool operator !=(InlineArray288_anon_atvx4gd x, InlineArray288_anon_atvx4gd y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray288_anon_atvx4gd other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray288_anon_atvx4gd)
		{
			return Equals((InlineArray288_anon_atvx4gd)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray288_anon_atvx4gd, anon_atvx4gd>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<anon_atvx4gd>)this).GetEnumerator();
	}
}
