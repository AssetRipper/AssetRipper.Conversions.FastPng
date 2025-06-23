using System;

namespace AssetRipper.Conversions.FastPng;

internal abstract partial class NameAttribute(string name) : Attribute()
{
	public string Name { get; } = name;
}
