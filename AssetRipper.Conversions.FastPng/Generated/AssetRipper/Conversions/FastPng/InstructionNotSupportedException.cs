using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace AssetRipper.Conversions.FastPng;

internal sealed partial class InstructionNotSupportedException : NotSupportedException
{
	public string OpCode { get; }

	public string Line { get; }

	public override string Message => "Instruction with op code " + OpCode + " is not supported.";

	public InstructionNotSupportedException(string code, string line)
	{
		OpCode = code;
		Line = line;
	}

	[DebuggerHidden]
	[StackTraceHidden]
	[DoesNotReturn]
	public static void Throw(string code, string line)
	{
		throw new InstructionNotSupportedException(code, line);
	}

	[DebuggerHidden]
	[StackTraceHidden]
	[DoesNotReturn]
	internal unsafe static void* ThrowPointer(string code, string line)
	{
		Throw(code, line);
		return null;
	}

	[DebuggerHidden]
	[StackTraceHidden]
	[DoesNotReturn]
	internal static T ThrowStruct<T>(string code, string line)
	{
		Throw(code, line);
		return default(T);
	}
}
