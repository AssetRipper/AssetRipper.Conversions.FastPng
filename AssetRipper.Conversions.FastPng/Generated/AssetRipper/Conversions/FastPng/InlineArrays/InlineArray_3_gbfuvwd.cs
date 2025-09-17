using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(3)]
public partial struct InlineArray_3_gbfuvwd : IEquatable<InlineArray_3_gbfuvwd>, IEqualityOperators<InlineArray_3_gbfuvwd, InlineArray_3_gbfuvwd, bool>, IEnumerable, IInlineArray<InlineArray_3_gbfuvwd, nint>, IInlineArray<InlineArray_3_gbfuvwd, nuint>
{
	private nint __element0;

	public static int Length => 3;

	public static bool operator ==(InlineArray_3_gbfuvwd x, InlineArray_3_gbfuvwd y)
	{
		return InlineArrayHelper.Equals<InlineArray_3_gbfuvwd, nint>(x, y);
	}

	public static bool operator !=(InlineArray_3_gbfuvwd x, InlineArray_3_gbfuvwd y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_3_gbfuvwd other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_3_gbfuvwd)
		{
			return Equals((InlineArray_3_gbfuvwd)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_3_gbfuvwd, nint>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<nint>)this).GetEnumerator();
	}
}
