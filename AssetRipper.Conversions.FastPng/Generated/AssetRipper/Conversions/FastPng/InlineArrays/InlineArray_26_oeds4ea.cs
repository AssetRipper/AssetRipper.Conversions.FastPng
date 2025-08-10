using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(26)]
public partial struct InlineArray_26_oeds4ea : IEquatable<InlineArray_26_oeds4ea>, IEqualityOperators<InlineArray_26_oeds4ea, InlineArray_26_oeds4ea, bool>, IInlineArray<short>, IInlineArray<ushort>, IInlineArray<char>
{
	private short __element0;

	public static int Length => 26;

	public static bool operator ==(InlineArray_26_oeds4ea x, InlineArray_26_oeds4ea y)
	{
		return InlineArrayHelper.Equals<InlineArray_26_oeds4ea, short>(x, y);
	}

	public static bool operator !=(InlineArray_26_oeds4ea x, InlineArray_26_oeds4ea y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_26_oeds4ea other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_26_oeds4ea)
		{
			return Equals((InlineArray_26_oeds4ea)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_26_oeds4ea, short>();
	}
}
