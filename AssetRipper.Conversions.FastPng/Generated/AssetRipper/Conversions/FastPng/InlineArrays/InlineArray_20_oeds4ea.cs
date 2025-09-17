using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(20)]
public partial struct InlineArray_20_oeds4ea : IEquatable<InlineArray_20_oeds4ea>, IEqualityOperators<InlineArray_20_oeds4ea, InlineArray_20_oeds4ea, bool>, IEnumerable, IInlineArray<InlineArray_20_oeds4ea, short>, IInlineArray<InlineArray_20_oeds4ea, ushort>, IInlineArray<InlineArray_20_oeds4ea, char>
{
	private short __element0;

	public static int Length => 20;

	public static bool operator ==(InlineArray_20_oeds4ea x, InlineArray_20_oeds4ea y)
	{
		return InlineArrayHelper.Equals<InlineArray_20_oeds4ea, short>(x, y);
	}

	public static bool operator !=(InlineArray_20_oeds4ea x, InlineArray_20_oeds4ea y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_20_oeds4ea other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_20_oeds4ea)
		{
			return Equals((InlineArray_20_oeds4ea)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_20_oeds4ea, short>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<short>)this).GetEnumerator();
	}
}
