using System.Runtime.InteropServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Structures;

[StructLayout(LayoutKind.Explicit, Size = 4)]
[MangledName("struct.anon")]
public partial struct anon
{
	[FieldOffset(0)]
	public sbyte field_0;

	[FieldOffset(2)]
	public short field_1;
}
