using System;

namespace AssetRipper.Conversions.FastPng.Helpers;

internal sealed partial class FatalException : Exception
{
	public FatalException()
	{
	}

	public FatalException(string? message)
		: base(message)
	{
	}
}
