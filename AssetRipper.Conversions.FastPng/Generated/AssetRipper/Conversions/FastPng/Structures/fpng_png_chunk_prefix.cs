using System.Runtime.InteropServices;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("struct.fpng::png_chunk_prefix")]
[DemangledName("fpng::png_chunk_prefix")]
public partial struct fpng_png_chunk_prefix
{
	[FieldOffset(0)]
	public int m_length;

	[FieldOffset(4)]
	public InlineArray4_SByte m_type;
}
