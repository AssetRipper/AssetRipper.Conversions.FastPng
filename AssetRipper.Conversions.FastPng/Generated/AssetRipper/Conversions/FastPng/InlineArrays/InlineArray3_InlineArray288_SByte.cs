using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(3)]
public partial struct InlineArray3_InlineArray288_SByte : IEquatable<InlineArray3_InlineArray288_SByte>, IEqualityOperators<InlineArray3_InlineArray288_SByte, InlineArray3_InlineArray288_SByte, bool>, IEnumerable, IInlineArray<InlineArray3_InlineArray288_SByte, InlineArray288_SByte>, IInlineArray<InlineArray3_InlineArray288_SByte, sbyte>, IInlineArray<InlineArray3_InlineArray288_SByte, byte>
{
	private InlineArray288_SByte __element0;

	public static int Length => 3;

	static int IInlineArray<sbyte>.Length => 864;

	static int IInlineArray<byte>.Length => 864;

	public static bool operator ==(InlineArray3_InlineArray288_SByte x, InlineArray3_InlineArray288_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray3_InlineArray288_SByte, InlineArray288_SByte>(x, y);
	}

	public static bool operator !=(InlineArray3_InlineArray288_SByte x, InlineArray3_InlineArray288_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray3_InlineArray288_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray3_InlineArray288_SByte)
		{
			return Equals((InlineArray3_InlineArray288_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray3_InlineArray288_SByte, InlineArray288_SByte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<InlineArray288_SByte>)this).GetEnumerator();
	}
}
