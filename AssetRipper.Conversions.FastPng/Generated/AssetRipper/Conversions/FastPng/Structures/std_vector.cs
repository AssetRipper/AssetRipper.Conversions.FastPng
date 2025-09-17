using System.Runtime.InteropServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("class.std::vector")]
public partial struct std_vector
{
	[FieldOffset(0)]
	public std_Compressed_pair field_0;
}
