using System.Runtime.InteropServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("struct.__std_exception_data")]
public partial struct std_exception_data
{
	[FieldOffset(0)]
	public unsafe void* field_0;

	[FieldOffset(8)]
	public sbyte field_1;
}
