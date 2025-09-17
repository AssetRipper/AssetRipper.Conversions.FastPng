using System.Runtime.InteropServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("class.std::_Vector_val")]
public partial struct std_Vector_val
{
	[FieldOffset(0)]
	public unsafe void* field_0;

	[FieldOffset(8)]
	public unsafe void* field_1;

	[FieldOffset(16)]
	public unsafe void* field_2;
}
