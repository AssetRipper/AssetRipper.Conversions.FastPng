using System.Runtime.InteropServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Structures;

[StructLayout(LayoutKind.Explicit, Size = 40)]
[MangledName("struct.std::vector<unsigned char>::_Reallocation_guard")]
public partial struct std_vector_unsigned_char_Reallocation_guard
{
	[FieldOffset(0)]
	public unsafe void* field_0;

	[FieldOffset(8)]
	public unsafe void* field_1;

	[FieldOffset(16)]
	public long field_2;

	[FieldOffset(24)]
	public unsafe void* field_3;

	[FieldOffset(32)]
	public unsafe void* field_4;
}
