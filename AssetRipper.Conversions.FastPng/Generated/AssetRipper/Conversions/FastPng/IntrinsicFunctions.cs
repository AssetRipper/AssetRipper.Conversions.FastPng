using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Conversions.FastPng;

internal static partial class IntrinsicFunctions
{
	private sealed partial class AssertExceptionInfo : ExceptionInfo
	{
		public string Message { get; }

		public AssertExceptionInfo(string message)
		{
			Message = message;
		}

		public override string? GetMessage()
		{
			return Message;
		}
	}

	[StructLayout(LayoutKind.Sequential, Size = 1)]
	private partial struct RttiTypeDescriptor
	{
	}

	private partial struct CatchableType
	{
		public int field_0;

		public int RttiTypeDescriptorIndex;

		public int field_2;

		public int field_3;

		public int field_4;

		public int field_5;

		public int ConstructorIndex;

		public unsafe readonly RttiTypeDescriptor* RttiTypeDescriptor => unchecked((RttiTypeDescriptor*)PointerIndices.GetPointer(RttiTypeDescriptorIndex));

		public unsafe readonly delegate*<void*, void*, void*> Constructor => unchecked((delegate*<void*, void*, void*>)PointerIndices.GetPointer(ConstructorIndex));
	}

	private partial struct CatchableTypeArray
	{
		public int Count;
	}

	private partial struct ThrowInfo
	{
		public int field_0;

		public int DestructorIndex;

		public int CatchableTypeArrayIndex;

		public unsafe readonly delegate*<void*, void> Destructor => unchecked((delegate*<void*, void>)PointerIndices.GetPointer(DestructorIndex));

		public unsafe readonly ReadOnlySpan<CatchableType> CatchableTypeArray
		{
			get
			{
				unchecked
				{
					CatchableTypeArray* pointer = (CatchableTypeArray*)PointerIndices.GetPointer(CatchableTypeArrayIndex);
					if (pointer == null || pointer->Count <= 0)
					{
						return default(ReadOnlySpan<CatchableType>);
					}
					return new ReadOnlySpan<CatchableType>((void*)checked(unchecked((nuint)pointer) + (nuint)4u), pointer->Count);
				}
			}
		}
	}

	private sealed partial class NativeExceptionInfo : ExceptionInfo
	{
		public unsafe void* ExceptionPointer { get; private set; }

		public unsafe ThrowInfo* ThrowInfo { get; private set; }

		public unsafe NativeExceptionInfo(void* exceptionPointer, ThrowInfo* throwInfo)
		{
			ExceptionPointer = exceptionPointer;
			ThrowInfo = throwInfo;
		}

		public unsafe bool Contains(RttiTypeDescriptor* rttiTypeDescriptor)
		{
			if (ThrowInfo == null)
			{
				return false;
			}
			ReadOnlySpan<CatchableType> catchableTypeArray = ThrowInfo->CatchableTypeArray;
			for (int i = 0; i < catchableTypeArray.Length; i = unchecked(i + 1))
			{
				if (catchableTypeArray[i].RttiTypeDescriptor == rttiTypeDescriptor)
				{
					return true;
				}
			}
			return false;
		}

		protected unsafe override void Dispose(bool disposing)
		{
			if (ExceptionPointer != null && ThrowInfo != null)
			{
				delegate*<void*, void> destructor = ThrowInfo->Destructor;
				if (destructor != unchecked((delegate*<void*, void>)null))
				{
					destructor(ExceptionPointer);
				}
			}
			ExceptionPointer = null;
			ThrowInfo = null;
		}
	}

	public static partial class Unimplemented
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[MangledName("?_Xlength_error@std@@YAXPEBD@Z")]
		[DemangledName("void __cdecl std::_Xlength_error(char const *)")]
		public unsafe static void Xlength_error(void* P_0)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[MangledName("__std_exception_destroy")]
		[DemangledName("__std_exception_destroy")]
		public unsafe static void std_exception_destroy(void* P_0)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[MangledName("__std_exception_copy")]
		[DemangledName("__std_exception_copy")]
		public unsafe static void std_exception_copy(void* P_0, void* P_1)
		{
			throw null;
		}
	}

	public static partial class Implemented
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[MangledName("_wassert")]
		[DemangledName("_wassert")]
		public unsafe static void wassert(void* P_0, void* P_1, int P_2)
		{
			unchecked
			{
				Assert((char*)P_0, (char*)P_1, (uint)P_2);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[MangledName("__CxxFrameHandler3")]
		[DemangledName("__CxxFrameHandler3")]
		public static int CxxFrameHandler3(ReadOnlySpan<nint> args)
		{
			return IntrinsicFunctions.CxxFrameHandler3(args);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[MangledName("llvm.memcpy.p0.p0.i64")]
		[DemangledName("llvm.memcpy.p0.p0.i64")]
		public unsafe static void llvm_memcpy_p0_p0_i64(void* P_0, void* P_1, long P_2, bool P_3)
		{
			IntrinsicFunctions.llvm_memcpy_p0_p0_i64(P_0, P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[MangledName("llvm.memset.p0.i64")]
		[DemangledName("llvm.memset.p0.i64")]
		public unsafe static void llvm_memset_p0_i64(void* P_0, sbyte P_1, long P_2, bool P_3)
		{
			IntrinsicFunctions.llvm_memset_p0_i64(P_0, P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[MangledName("_invoke_watson")]
		[DemangledName("_invoke_watson")]
		public unsafe static void invoke_watson(void* P_0, void* P_1, void* P_2, int P_3, long P_4)
		{
			unchecked
			{
				InvokeWatson((char*)P_0, (char*)P_1, (char*)P_2, P_3, P_4);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[MangledName("_CxxThrowException")]
		[DemangledName("_CxxThrowException")]
		public unsafe static void CxxThrowException(void* P_0, void* P_1)
		{
			IntrinsicFunctions.CxxThrowException(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[MangledName("??3@YAXPEAX_K@Z")]
		[DemangledName("void __cdecl operator delete(void *, unsigned __int64)")]
		public unsafe static void Delete(void* P_0, long P_1)
		{
			IntrinsicFunctions.Delete(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[MangledName("__std_terminate")]
		[DemangledName("__std_terminate")]
		public static void std_terminate()
		{
			Terminate();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[MangledName("??2@YAPEAX_K@Z")]
		[DemangledName("void * __cdecl operator new(unsigned __int64)")]
		public unsafe static void* New(long P_0)
		{
			return Alloc(P_0);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[MangledName("llvm.memmove.p0.p0.i64")]
		[DemangledName("llvm.memmove.p0.p0.i64")]
		public unsafe static void llvm_memmove_p0_p0_i64(void* P_0, void* P_1, long P_2, bool P_3)
		{
			IntrinsicFunctions.llvm_memmove_p0_p0_i64(P_0, P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static int memcmp(void* P_0, void* P_1, long P_2)
		{
			return unchecked(IntrinsicFunctions.memcmp((byte*)P_0, (byte*)P_1, P_2));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static int strcmp(void* P_0, void* P_1)
		{
			return unchecked(IntrinsicFunctions.strcmp((byte*)P_0, (byte*)P_1));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[MangledName("llvm.bswap.i32")]
		[DemangledName("llvm.bswap.i32")]
		public static int llvm_bswap_i32(int P_0)
		{
			return NumericHelper.BSwap(P_0);
		}
	}

	[MangledName("puts")]
	public unsafe static int PutString(sbyte* P_0)
	{
		try
		{
			Console.WriteLine(Marshal.PtrToStringAnsi((nint)P_0));
			return 0;
		}
		catch
		{
			return -1;
		}
	}

	[MangledName("_wassert")]
	public unsafe static void Assert(char* message, char* file, uint line)
	{
		ExceptionInfo.Current = new AssertExceptionInfo($"Assertion failed: {Marshal.PtrToStringUni((nint)message)} at {Marshal.PtrToStringUni((nint)file)}:{line}");
	}

	[DoesNotReturn]
	[MangledName("_invoke_watson")]
	public unsafe static void InvokeWatson(char* expression, char* function, char* file, int line, long reserved)
	{
		throw new FatalException($"Fatal assertion failed: {Marshal.PtrToStringUni((nint)expression)} in {Marshal.PtrToStringUni((nint)function)} at {Marshal.PtrToStringUni((nint)file)}:{line}");
	}

	[DoesNotReturn]
	[MangledName("__std_terminate")]
	public static void Terminate()
	{
		throw new FatalException("Terminate");
	}

	[MangledName("llvm.va.start")]
	public unsafe static void llvm_va_start(void** va_list)
	{
		throw new NotSupportedException();
	}

	[MangledName("llvm.va.copy")]
	public unsafe static void llvm_va_copy(void** destination, void** source)
	{
		*destination = *source;
	}

	[MangledName("llvm.va.end")]
	public unsafe static void llvm_va_end(void** va_list)
	{
	}

	[MangledName("strcmp")]
	public unsafe static int strcmp(byte* p1, byte* p2)
	{
		unchecked
		{
			while (*p1 == *p2 && *p1 != 0)
			{
				p1 = (byte*)checked(unchecked((nuint)p1) + (nuint)1u);
				p2 = (byte*)checked(unchecked((nuint)p2) + (nuint)1u);
			}
		}
		return *p1 - *p2;
	}

	[MangledName("memcmp")]
	public unsafe static int memcmp(byte* p1, byte* p2, long count)
	{
		for (long num = 0L; num < count; num++)
		{
			if (p1[num] != p2[num])
			{
				return p1[num] - p2[num];
			}
		}
		return 0;
	}

	[MangledName("llvm.memcpy.p0.p0.i32")]
	public unsafe static void llvm_memcpy_p0_p0_i32(void* destination, void* source, int length, bool isVolatile)
	{
		Unsafe.CopyBlock(destination, source, (uint)length);
	}

	[MangledName("llvm.memcpy.p0.p0.i64")]
	public unsafe static void llvm_memcpy_p0_p0_i64(void* destination, void* source, long length, bool isVolatile)
	{
		Unsafe.CopyBlock(destination, source, (uint)length);
	}

	[MangledName("llvm.memmove.p0.p0.i32")]
	public unsafe static void llvm_memmove_p0_p0_i32(void* destination, void* source, int length, bool isVolatile)
	{
		byte[] array = ArrayPool<byte>.Shared.Rent(length);
		Span<byte> destination2 = new Span<byte>(array, 0, length);
		new ReadOnlySpan<byte>(source, length).CopyTo(destination2);
		destination2.CopyTo(new Span<byte>(destination, length));
		ArrayPool<byte>.Shared.Return(array);
	}

	[MangledName("llvm.memmove.p0.p0.i64")]
	public unsafe static void llvm_memmove_p0_p0_i64(void* destination, void* source, long length, bool isVolatile)
	{
		llvm_memmove_p0_p0_i32(destination, source, (int)length, isVolatile);
	}

	[MangledName("llvm.memset.p0.i32")]
	public unsafe static void llvm_memset_p0_i32(void* destination, sbyte value, int length, bool isVolatile)
	{
		new Span<byte>(destination, length).Fill(unchecked((byte)value));
	}

	[MangledName("llvm.memset.p0.i64")]
	public unsafe static void llvm_memset_p0_i64(void* destination, sbyte value, long length, bool isVolatile)
	{
		llvm_memset_p0_i32(destination, value, (int)length, isVolatile);
	}

	[MangledName("malloc")]
	[MangledName("??2@YAPEAX_K@Z")]
	public unsafe static void* Alloc(long size)
	{
		unchecked
		{
			return (void*)checked((nuint)Marshal.AllocHGlobal((nint)size));
		}
	}

	[MangledName("realloc")]
	public unsafe static void* ReAlloc(void* ptr, long size)
	{
		unchecked
		{
			return (void*)checked((nuint)Marshal.ReAllocHGlobal((nint)ptr, (nint)size));
		}
	}

	[MangledName("free")]
	public unsafe static void Free(void* ptr)
	{
		Marshal.FreeHGlobal((nint)ptr);
	}

	[MangledName("??3@YAXPEAX_K@Z")]
	public unsafe static void Delete(void* ptr, long size)
	{
		Marshal.FreeHGlobal((nint)ptr);
	}

	[MangledName("expand")]
	public unsafe static void* Expand(void* ptr, long size)
	{
		return null;
	}

	[MangledName("_CxxThrowException")]
	public unsafe static void CxxThrowException(void* exceptionPointer, void* throwInfo)
	{
		ExceptionInfo.Current = new NativeExceptionInfo(exceptionPointer, unchecked((ThrowInfo*)throwInfo));
	}

	[MangledName("__CxxFrameHandler3")]
	public unsafe static int CxxFrameHandler3(ReadOnlySpan<nint> args)
	{
		if (args.Length != 3)
		{
			throw new ArgumentException("Expected 3 arguments", "args");
		}
		if (args[0] == 0 || args[1] == 0 || args[2] == 0)
		{
			throw new ArgumentNullException("args", "Arguments cannot be null");
		}
		unchecked
		{
			RttiTypeDescriptor* ptr = *(RttiTypeDescriptor**)checked((nuint)args[0]);
			int num = *(int*)checked((nuint)args[1]);
			void** ptr2 = (void**)checked((nuint)args[2]);
			if (ExceptionInfo.Current is NativeExceptionInfo nativeExceptionInfo)
			{
				if (ptr != null && !nativeExceptionInfo.Contains(ptr))
				{
					return 1;
				}
				if (ptr2 != null)
				{
					*ptr2 = nativeExceptionInfo.ExceptionPointer;
				}
				return 0;
			}
			if (ptr != null || ptr2 != null)
			{
				throw new NotSupportedException("Current exception is not a NativeExceptionInfo.");
			}
			return 0;
		}
	}
}
