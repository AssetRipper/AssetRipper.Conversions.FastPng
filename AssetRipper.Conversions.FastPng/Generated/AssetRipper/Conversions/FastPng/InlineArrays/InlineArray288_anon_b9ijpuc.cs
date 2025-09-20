using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(288)]
public partial struct InlineArray288_anon_b9ijpuc : IEquatable<InlineArray288_anon_b9ijpuc>, IEqualityOperators<InlineArray288_anon_b9ijpuc, InlineArray288_anon_b9ijpuc, bool>, IEnumerable, IInlineArray<InlineArray288_anon_b9ijpuc, anon_b9ijpuc>
{
	private anon_b9ijpuc __element0;

	public static int Length => 288;

	public static bool operator ==(InlineArray288_anon_b9ijpuc x, InlineArray288_anon_b9ijpuc y)
	{
		return InlineArrayHelper.Equals<InlineArray288_anon_b9ijpuc, anon_b9ijpuc>(x, y);
	}

	public static bool operator !=(InlineArray288_anon_b9ijpuc x, InlineArray288_anon_b9ijpuc y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray288_anon_b9ijpuc other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray288_anon_b9ijpuc)
		{
			return Equals((InlineArray288_anon_b9ijpuc)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray288_anon_b9ijpuc, anon_b9ijpuc>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<anon_b9ijpuc>)this).GetEnumerator();
	}
}
