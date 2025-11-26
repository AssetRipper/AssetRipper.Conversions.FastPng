using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(288)]
public partial struct InlineArray288_anon_m9uqrv : IEquatable<InlineArray288_anon_m9uqrv>, IEqualityOperators<InlineArray288_anon_m9uqrv, InlineArray288_anon_m9uqrv, bool>, IEnumerable, IInlineArray<InlineArray288_anon_m9uqrv, anon_m9uqrv>
{
	private anon_m9uqrv __element0;

	public static int Length => 288;

	public static bool operator ==(InlineArray288_anon_m9uqrv x, InlineArray288_anon_m9uqrv y)
	{
		return InlineArrayHelper.Equals<InlineArray288_anon_m9uqrv, anon_m9uqrv>(x, y);
	}

	public static bool operator !=(InlineArray288_anon_m9uqrv x, InlineArray288_anon_m9uqrv y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray288_anon_m9uqrv other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray288_anon_m9uqrv)
		{
			return Equals((InlineArray288_anon_m9uqrv)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray288_anon_m9uqrv, anon_m9uqrv>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<anon_m9uqrv>)this).GetEnumerator();
	}
}
