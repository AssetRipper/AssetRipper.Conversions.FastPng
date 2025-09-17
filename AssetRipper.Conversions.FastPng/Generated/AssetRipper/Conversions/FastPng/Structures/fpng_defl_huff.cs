using System.Runtime.InteropServices;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.Structures;

[StructLayout(LayoutKind.Explicit, Size = 4320)]
[MangledName("struct.fpng::defl_huff")]
public partial struct fpng_defl_huff
{
	[FieldOffset(0)]
	public InlineArray_3_xe2dfrb field_0;

	[FieldOffset(1728)]
	public InlineArray_3_xe2dfrb field_1;

	[FieldOffset(3456)]
	public InlineArray_3_xrp35oc field_2;
}
