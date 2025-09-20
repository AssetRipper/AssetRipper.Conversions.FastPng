using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(3)]
public partial struct InlineArray3_IntPtr : IEquatable<InlineArray3_IntPtr>, IEqualityOperators<InlineArray3_IntPtr, InlineArray3_IntPtr, bool>, IEnumerable, IInlineArray<InlineArray3_IntPtr, nint>, IInlineArray<InlineArray3_IntPtr, nuint>
{
	private nint __element0;

	public static int Length => 3;

	public static bool operator ==(InlineArray3_IntPtr x, InlineArray3_IntPtr y)
	{
		return InlineArrayHelper.Equals<InlineArray3_IntPtr, nint>(x, y);
	}

	public static bool operator !=(InlineArray3_IntPtr x, InlineArray3_IntPtr y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray3_IntPtr other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray3_IntPtr)
		{
			return Equals((InlineArray3_IntPtr)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray3_IntPtr, nint>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<nint>)this).GetEnumerator();
	}
}
