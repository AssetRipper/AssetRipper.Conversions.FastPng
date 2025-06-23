using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Conversions.FastPng;

internal partial struct StackFrame
{
	internal readonly int Index;

	private unsafe void* Locals;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe StackFrame(int index, int size)
	{
		Index = index;
		Locals = ((size > 0) ? unchecked((void*)Marshal.AllocHGlobal(size)) : ((void*)null));
	}

	internal unsafe void FreeLocals()
	{
		if (Locals != null)
		{
			Marshal.FreeHGlobal(unchecked((nint)Locals));
			Locals = null;
		}
	}

	public unsafe readonly ref T GetLocalsRef<T>() where T : unmanaged
	{
		return ref Unsafe.AsRef<T>(Locals);
	}

	public unsafe readonly T* GetLocalsPointer<T>() where T : unmanaged
	{
		return unchecked((T*)Locals);
	}

	internal unsafe static StackFrame Create<T>(int index) where T : unmanaged
	{
		return new StackFrame(index, sizeof(T));
	}
}
