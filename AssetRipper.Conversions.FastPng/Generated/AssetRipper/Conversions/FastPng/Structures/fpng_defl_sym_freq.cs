using System.Runtime.InteropServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Structures;

[StructLayout(LayoutKind.Explicit, Size = 4)]
[MangledName("struct.fpng::defl_sym_freq")]
[DemangledName("fpng::defl_sym_freq")]
public partial struct fpng_defl_sym_freq
{
	[FieldOffset(0)]
	public short m_key;

	[FieldOffset(2)]
	public short m_sym_index;
}
