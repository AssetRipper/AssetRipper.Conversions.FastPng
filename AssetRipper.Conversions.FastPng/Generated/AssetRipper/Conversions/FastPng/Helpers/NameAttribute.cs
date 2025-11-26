using System;

namespace AssetRipper.Conversions.FastPng.Helpers;

internal abstract partial class NameAttribute(string name) : Attribute
{
	public string Name { get; } = name;
}
