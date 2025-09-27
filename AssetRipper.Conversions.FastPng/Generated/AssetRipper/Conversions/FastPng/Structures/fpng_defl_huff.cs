using System.Runtime.InteropServices;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.Structures;

[StructLayout(LayoutKind.Explicit, Size = 4320)]
[MangledName("struct.fpng::defl_huff")]
[DemangledName("fpng::defl_huff")]
public partial struct fpng_defl_huff
{
	[FieldOffset(0)]
	public InlineArray3_InlineArray288_Int16 m_huff_count;

	[FieldOffset(1728)]
	public InlineArray3_InlineArray288_Int16 m_huff_codes;

	[FieldOffset(3456)]
	public InlineArray3_InlineArray288_SByte m_huff_code_sizes;
}
