using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.InlineArrays;

[InlineArray(4)]
public partial struct InlineArray_4_vjlif9a : IEquatable<InlineArray_4_vjlif9a>, IEqualityOperators<InlineArray_4_vjlif9a, InlineArray_4_vjlif9a, bool>, IInlineArray<InlineArray_256_vqkfj7a>, IInlineArray<int>, IInlineArray<uint>
{
	private InlineArray_256_vqkfj7a __element0;

	public static int Length => 4;

	static int IInlineArray<int>.Length => 1024;

	static int IInlineArray<uint>.Length => 1024;

	public static bool operator ==(InlineArray_4_vjlif9a x, InlineArray_4_vjlif9a y)
	{
		return InlineArrayHelper.Equals<InlineArray_4_vjlif9a, InlineArray_256_vqkfj7a>(x, y);
	}

	public static bool operator !=(InlineArray_4_vjlif9a x, InlineArray_4_vjlif9a y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_4_vjlif9a other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_4_vjlif9a)
		{
			return Equals((InlineArray_4_vjlif9a)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_4_vjlif9a, InlineArray_256_vqkfj7a>();
	}
}
