using System;
using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.FastPng.Helpers;

internal static partial class InstructionHelper
{
	public static TTo BitCast<TFrom, TTo>(TFrom value) where TFrom : struct where TTo : struct
	{
		ArgumentOutOfRangeException.ThrowIfLessThan(Unsafe.SizeOf<TFrom>(), Unsafe.SizeOf<TTo>(), "TFrom");
		return Unsafe.As<TFrom, TTo>(ref value);
	}

	public unsafe static void VAStart(void** vaListPtr, ReadOnlySpan<nint> args)
	{
		*vaListPtr = args.ToPointer<nint>();
	}

	public unsafe static void** VAArg(void*** vaListPtr)
	{
		return (*vaListPtr)++;
	}
}
