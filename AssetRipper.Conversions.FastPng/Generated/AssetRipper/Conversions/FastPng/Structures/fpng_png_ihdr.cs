using System.Runtime.InteropServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Structures;

[StructLayout(LayoutKind.Explicit, Size = 25)]
[MangledName("struct.fpng::png_ihdr")]
[DemangledName("fpng::png_ihdr")]
public partial struct fpng_png_ihdr
{
	[FieldOffset(0)]
	public fpng_png_chunk_prefix m_prefix;

	[FieldOffset(8)]
	public int m_width;

	[FieldOffset(12)]
	public int m_height;

	[FieldOffset(16)]
	public sbyte m_bitdepth;

	[FieldOffset(17)]
	public sbyte m_color_type;

	[FieldOffset(18)]
	public sbyte m_comp_method;

	[FieldOffset(19)]
	public sbyte m_filter_method;

	[FieldOffset(20)]
	public sbyte m_interlace_method;

	[FieldOffset(21)]
	public int m_crc32;
}
