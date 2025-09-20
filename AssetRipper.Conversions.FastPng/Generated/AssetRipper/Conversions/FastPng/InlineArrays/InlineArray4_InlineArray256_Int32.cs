using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(4)]
public partial struct InlineArray4_InlineArray256_Int32 : IEquatable<InlineArray4_InlineArray256_Int32>, IEqualityOperators<InlineArray4_InlineArray256_Int32, InlineArray4_InlineArray256_Int32, bool>, IEnumerable, IInlineArray<InlineArray4_InlineArray256_Int32, InlineArray256_Int32>, IInlineArray<InlineArray4_InlineArray256_Int32, int>, IInlineArray<InlineArray4_InlineArray256_Int32, uint>
{
	private InlineArray256_Int32 __element0;

	public static int Length => 4;

	static int IInlineArray<int>.Length => 1024;

	static int IInlineArray<uint>.Length => 1024;

	public static bool operator ==(InlineArray4_InlineArray256_Int32 x, InlineArray4_InlineArray256_Int32 y)
	{
		return InlineArrayHelper.Equals<InlineArray4_InlineArray256_Int32, InlineArray256_Int32>(x, y);
	}

	public static bool operator !=(InlineArray4_InlineArray256_Int32 x, InlineArray4_InlineArray256_Int32 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray4_InlineArray256_Int32 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray4_InlineArray256_Int32)
		{
			return Equals((InlineArray4_InlineArray256_Int32)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray4_InlineArray256_Int32, InlineArray256_Int32>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<InlineArray256_Int32>)this).GetEnumerator();
	}
}
