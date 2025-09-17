using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(3)]
public partial struct InlineArray_3_xe2dfrb : IEquatable<InlineArray_3_xe2dfrb>, IEqualityOperators<InlineArray_3_xe2dfrb, InlineArray_3_xe2dfrb, bool>, IEnumerable, IInlineArray<InlineArray_3_xe2dfrb, InlineArray_288_oeds4ea>, IInlineArray<InlineArray_3_xe2dfrb, short>, IInlineArray<InlineArray_3_xe2dfrb, ushort>, IInlineArray<InlineArray_3_xe2dfrb, char>
{
	private InlineArray_288_oeds4ea __element0;

	public static int Length => 3;

	static int IInlineArray<short>.Length => 864;

	static int IInlineArray<ushort>.Length => 864;

	static int IInlineArray<char>.Length => 864;

	public static bool operator ==(InlineArray_3_xe2dfrb x, InlineArray_3_xe2dfrb y)
	{
		return InlineArrayHelper.Equals<InlineArray_3_xe2dfrb, InlineArray_288_oeds4ea>(x, y);
	}

	public static bool operator !=(InlineArray_3_xe2dfrb x, InlineArray_3_xe2dfrb y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_3_xe2dfrb other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_3_xe2dfrb)
		{
			return Equals((InlineArray_3_xe2dfrb)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_3_xe2dfrb, InlineArray_288_oeds4ea>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<InlineArray_288_oeds4ea>)this).GetEnumerator();
	}
}
