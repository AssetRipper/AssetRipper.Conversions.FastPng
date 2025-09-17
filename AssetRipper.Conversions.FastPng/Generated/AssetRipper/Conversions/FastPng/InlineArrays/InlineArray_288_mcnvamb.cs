using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(288)]
public partial struct InlineArray_288_mcnvamb : IEquatable<InlineArray_288_mcnvamb>, IEqualityOperators<InlineArray_288_mcnvamb, InlineArray_288_mcnvamb, bool>, IEnumerable, IInlineArray<InlineArray_288_mcnvamb, anon_11>
{
	private anon_11 __element0;

	public static int Length => 288;

	public static bool operator ==(InlineArray_288_mcnvamb x, InlineArray_288_mcnvamb y)
	{
		return InlineArrayHelper.Equals<InlineArray_288_mcnvamb, anon_11>(x, y);
	}

	public static bool operator !=(InlineArray_288_mcnvamb x, InlineArray_288_mcnvamb y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_288_mcnvamb other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_288_mcnvamb)
		{
			return Equals((InlineArray_288_mcnvamb)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_288_mcnvamb, anon_11>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<anon_11>)this).GetEnumerator();
	}
}
