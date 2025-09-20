using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(20)]
public partial struct InlineArray20_Int16 : IEquatable<InlineArray20_Int16>, IEqualityOperators<InlineArray20_Int16, InlineArray20_Int16, bool>, IEnumerable, IInlineArray<InlineArray20_Int16, short>, IInlineArray<InlineArray20_Int16, ushort>, IInlineArray<InlineArray20_Int16, char>
{
	private short __element0;

	public static int Length => 20;

	public static bool operator ==(InlineArray20_Int16 x, InlineArray20_Int16 y)
	{
		return InlineArrayHelper.Equals<InlineArray20_Int16, short>(x, y);
	}

	public static bool operator !=(InlineArray20_Int16 x, InlineArray20_Int16 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray20_Int16 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray20_Int16)
		{
			return Equals((InlineArray20_Int16)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray20_Int16, short>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<short>)this).GetEnumerator();
	}
}
