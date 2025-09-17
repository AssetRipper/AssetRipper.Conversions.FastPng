using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(38)]
public partial struct InlineArray_38_oeds4ea : IEquatable<InlineArray_38_oeds4ea>, IEqualityOperators<InlineArray_38_oeds4ea, InlineArray_38_oeds4ea, bool>, IEnumerable, IInlineArray<InlineArray_38_oeds4ea, short>, IInlineArray<InlineArray_38_oeds4ea, ushort>, IInlineArray<InlineArray_38_oeds4ea, char>
{
	private short __element0;

	public static int Length => 38;

	public static bool operator ==(InlineArray_38_oeds4ea x, InlineArray_38_oeds4ea y)
	{
		return InlineArrayHelper.Equals<InlineArray_38_oeds4ea, short>(x, y);
	}

	public static bool operator !=(InlineArray_38_oeds4ea x, InlineArray_38_oeds4ea y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_38_oeds4ea other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_38_oeds4ea)
		{
			return Equals((InlineArray_38_oeds4ea)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_38_oeds4ea, short>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<short>)this).GetEnumerator();
	}
}
