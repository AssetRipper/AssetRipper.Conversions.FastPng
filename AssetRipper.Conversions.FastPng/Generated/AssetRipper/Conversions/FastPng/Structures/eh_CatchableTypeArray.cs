using System.Runtime.InteropServices;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("eh.CatchableTypeArray.3")]
[DemangledName("eh.CatchableTypeArray")]
public partial struct eh_CatchableTypeArray
{
	[FieldOffset(0)]
	public int field_0;

	[FieldOffset(4)]
	public InlineArray3_Int32 field_1;
}
