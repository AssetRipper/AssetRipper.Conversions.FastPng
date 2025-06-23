using System;

namespace AssetRipper.Conversions.FastPng;

[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
internal sealed partial class MangledNameAttribute : NameAttribute
{
	public MangledNameAttribute(string name)
		: base(name)
	{
	}
}
