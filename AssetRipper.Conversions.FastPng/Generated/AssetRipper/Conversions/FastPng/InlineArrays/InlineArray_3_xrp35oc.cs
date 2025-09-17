using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(3)]
public partial struct InlineArray_3_xrp35oc : IEquatable<InlineArray_3_xrp35oc>, IEqualityOperators<InlineArray_3_xrp35oc, InlineArray_3_xrp35oc, bool>, IEnumerable, IInlineArray<InlineArray_3_xrp35oc, InlineArray_288_w3otm9c>, IInlineArray<InlineArray_3_xrp35oc, sbyte>, IInlineArray<InlineArray_3_xrp35oc, byte>
{
	private InlineArray_288_w3otm9c __element0;

	public static int Length => 3;

	static int IInlineArray<sbyte>.Length => 864;

	static int IInlineArray<byte>.Length => 864;

	public static bool operator ==(InlineArray_3_xrp35oc x, InlineArray_3_xrp35oc y)
	{
		return InlineArrayHelper.Equals<InlineArray_3_xrp35oc, InlineArray_288_w3otm9c>(x, y);
	}

	public static bool operator !=(InlineArray_3_xrp35oc x, InlineArray_3_xrp35oc y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_3_xrp35oc other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_3_xrp35oc)
		{
			return Equals((InlineArray_3_xrp35oc)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_3_xrp35oc, InlineArray_288_w3otm9c>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<InlineArray_288_w3otm9c>)this).GetEnumerator();
	}
}
