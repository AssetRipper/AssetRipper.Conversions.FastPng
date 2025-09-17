using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(42)]
public partial struct InlineArray_42_oeds4ea : IEquatable<InlineArray_42_oeds4ea>, IEqualityOperators<InlineArray_42_oeds4ea, InlineArray_42_oeds4ea, bool>, IEnumerable, IInlineArray<InlineArray_42_oeds4ea, short>, IInlineArray<InlineArray_42_oeds4ea, ushort>, IInlineArray<InlineArray_42_oeds4ea, char>
{
	private short __element0;

	public static int Length => 42;

	public static bool operator ==(InlineArray_42_oeds4ea x, InlineArray_42_oeds4ea y)
	{
		return InlineArrayHelper.Equals<InlineArray_42_oeds4ea, short>(x, y);
	}

	public static bool operator !=(InlineArray_42_oeds4ea x, InlineArray_42_oeds4ea y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_42_oeds4ea other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_42_oeds4ea)
		{
			return Equals((InlineArray_42_oeds4ea)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_42_oeds4ea, short>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<short>)this).GetEnumerator();
	}
}
