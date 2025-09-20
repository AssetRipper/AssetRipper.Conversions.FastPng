using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(3)]
public partial struct InlineArray3_InlineArray288_Int16 : IEquatable<InlineArray3_InlineArray288_Int16>, IEqualityOperators<InlineArray3_InlineArray288_Int16, InlineArray3_InlineArray288_Int16, bool>, IEnumerable, IInlineArray<InlineArray3_InlineArray288_Int16, InlineArray288_Int16>, IInlineArray<InlineArray3_InlineArray288_Int16, short>, IInlineArray<InlineArray3_InlineArray288_Int16, ushort>, IInlineArray<InlineArray3_InlineArray288_Int16, char>
{
	private InlineArray288_Int16 __element0;

	public static int Length => 3;

	static int IInlineArray<short>.Length => 864;

	static int IInlineArray<ushort>.Length => 864;

	static int IInlineArray<char>.Length => 864;

	public static bool operator ==(InlineArray3_InlineArray288_Int16 x, InlineArray3_InlineArray288_Int16 y)
	{
		return InlineArrayHelper.Equals<InlineArray3_InlineArray288_Int16, InlineArray288_Int16>(x, y);
	}

	public static bool operator !=(InlineArray3_InlineArray288_Int16 x, InlineArray3_InlineArray288_Int16 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray3_InlineArray288_Int16 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray3_InlineArray288_Int16)
		{
			return Equals((InlineArray3_InlineArray288_Int16)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray3_InlineArray288_Int16, InlineArray288_Int16>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<InlineArray288_Int16>)this).GetEnumerator();
	}
}
