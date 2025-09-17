using System.Runtime.InteropServices;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("eh.CatchableTypeArray.3")]
public partial struct eh_CatchableTypeArray_3
{
	[FieldOffset(0)]
	public int field_0;

	[FieldOffset(4)]
	public InlineArray_3_vqkfj7a field_1;
}
