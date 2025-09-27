using System.Runtime.InteropServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("class.std::exception")]
[DemangledName("std::exception")]
public partial struct std_exception
{
	[FieldOffset(0)]
	public unsafe void* vptr_exception;

	[FieldOffset(8)]
	public std_exception_data Data;
}
