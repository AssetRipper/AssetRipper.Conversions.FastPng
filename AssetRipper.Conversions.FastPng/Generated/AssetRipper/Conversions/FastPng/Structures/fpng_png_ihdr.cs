using System.Runtime.InteropServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Structures;

[StructLayout(LayoutKind.Explicit, Size = 25)]
[MangledName("struct.fpng::png_ihdr")]
[DemangledName("fpng::png_ihdr")]
public partial struct fpng_png_ihdr
{
	[FieldOffset(0)]
	public fpng_png_chunk_prefix field_0;

	[FieldOffset(8)]
	public int field_1;

	[FieldOffset(12)]
	public int field_2;

	[FieldOffset(16)]
	public sbyte field_3;

	[FieldOffset(17)]
	public sbyte field_4;

	[FieldOffset(18)]
	public sbyte field_5;

	[FieldOffset(19)]
	public sbyte field_6;

	[FieldOffset(20)]
	public sbyte field_7;

	[FieldOffset(21)]
	public int field_8;
}
