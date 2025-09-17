using System.Runtime.InteropServices;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("struct.fpng::png_chunk_prefix")]
public partial struct fpng_png_chunk_prefix
{
	[FieldOffset(0)]
	public int field_0;

	[FieldOffset(4)]
	public InlineArray_4_w3otm9c field_1;
}
