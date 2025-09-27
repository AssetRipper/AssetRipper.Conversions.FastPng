using System.Runtime.InteropServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("struct.std::_Tidy_guard")]
[DemangledName("std::_Tidy_guard")]
public partial struct std_Tidy_guard
{
	[FieldOffset(0)]
	public unsafe void* Target;
}
