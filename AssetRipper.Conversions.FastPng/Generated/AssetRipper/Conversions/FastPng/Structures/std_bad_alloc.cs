using System.Runtime.InteropServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("class.std::bad_alloc")]
[DemangledName("std::bad_alloc")]
public partial struct std_bad_alloc
{
	[FieldOffset(0)]
	public std_exception field_0;
}
