using System;
using System.Runtime.InteropServices;

namespace AssetRipper.Conversions.FastPng.Helpers;

internal static partial class NativeMemoryHelper
{
	public unsafe static void* Allocate(int size)
	{
		return unchecked((IntPtr)Marshal.AllocHGlobal(size)).ToPointer();
	}

	public unsafe static void* Allocate(long size)
	{
		unchecked
		{
			return ((IntPtr)Marshal.AllocHGlobal(checked((nint)size))).ToPointer();
		}
	}

	public unsafe static void Free(void* ptr)
	{
		Marshal.FreeHGlobal((nint)ptr);
	}

	public unsafe static void* Reallocate(void* ptr, int newSize)
	{
		unchecked
		{
			return ((IntPtr)Marshal.ReAllocHGlobal(checked((nint)ptr), newSize)).ToPointer();
		}
	}

	public unsafe static void* Reallocate(void* ptr, long newSize)
	{
		unchecked
		{
			return ((IntPtr)checked(Marshal.ReAllocHGlobal((nint)ptr, (nint)newSize))).ToPointer();
		}
	}
}
