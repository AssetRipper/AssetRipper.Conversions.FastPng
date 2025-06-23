using System;

namespace AssetRipper.Conversions.FastPng;

public sealed partial class FatalException : Exception
{
	public FatalException()
	{
	}

	public FatalException(string? message)
		: base(message)
	{
	}
}
