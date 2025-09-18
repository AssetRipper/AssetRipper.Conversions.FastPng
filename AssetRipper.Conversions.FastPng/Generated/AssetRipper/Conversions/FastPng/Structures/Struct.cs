using System.Runtime.InteropServices;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
public partial struct Struct
{
	[FieldOffset(0)]
	public InlineArray_3_gbfuvwd field_0;
}
