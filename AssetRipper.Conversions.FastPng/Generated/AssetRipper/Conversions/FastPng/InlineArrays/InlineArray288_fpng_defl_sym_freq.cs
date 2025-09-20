using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(288)]
public partial struct InlineArray288_fpng_defl_sym_freq : IEquatable<InlineArray288_fpng_defl_sym_freq>, IEqualityOperators<InlineArray288_fpng_defl_sym_freq, InlineArray288_fpng_defl_sym_freq, bool>, IEnumerable, IInlineArray<InlineArray288_fpng_defl_sym_freq, fpng_defl_sym_freq>
{
	private fpng_defl_sym_freq __element0;

	public static int Length => 288;

	public static bool operator ==(InlineArray288_fpng_defl_sym_freq x, InlineArray288_fpng_defl_sym_freq y)
	{
		return InlineArrayHelper.Equals<InlineArray288_fpng_defl_sym_freq, fpng_defl_sym_freq>(x, y);
	}

	public static bool operator !=(InlineArray288_fpng_defl_sym_freq x, InlineArray288_fpng_defl_sym_freq y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray288_fpng_defl_sym_freq other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray288_fpng_defl_sym_freq)
		{
			return Equals((InlineArray288_fpng_defl_sym_freq)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray288_fpng_defl_sym_freq, fpng_defl_sym_freq>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<fpng_defl_sym_freq>)this).GetEnumerator();
	}
}
