using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Conversions.FastPng;

internal static partial class SpanHelper
{
	public static ReadOnlySpan<T> ToReadOnly<T>(this Span<T> span)
	{
		return span;
	}

	public static ReadOnlySpan<char> ToCharacterSpan(this string str)
	{
		return str.AsSpan();
	}

	public unsafe static T* ToPointer<T>(this ReadOnlySpan<T> span) where T : unmanaged
	{
		return unchecked((T*)Unsafe.AsPointer(ref MemoryMarshal.GetReference(span)));
	}
}
