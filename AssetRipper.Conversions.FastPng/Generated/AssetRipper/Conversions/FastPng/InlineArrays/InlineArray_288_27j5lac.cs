using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(288)]
public partial struct InlineArray_288_27j5lac : IEquatable<InlineArray_288_27j5lac>, IEqualityOperators<InlineArray_288_27j5lac, InlineArray_288_27j5lac, bool>, IEnumerable, IInlineArray<InlineArray_288_27j5lac, fpng_defl_sym_freq>
{
	private fpng_defl_sym_freq __element0;

	public static int Length => 288;

	public static bool operator ==(InlineArray_288_27j5lac x, InlineArray_288_27j5lac y)
	{
		return InlineArrayHelper.Equals<InlineArray_288_27j5lac, fpng_defl_sym_freq>(x, y);
	}

	public static bool operator !=(InlineArray_288_27j5lac x, InlineArray_288_27j5lac y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_288_27j5lac other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_288_27j5lac)
		{
			return Equals((InlineArray_288_27j5lac)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_288_27j5lac, fpng_defl_sym_freq>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<fpng_defl_sym_freq>)this).GetEnumerator();
	}
}
