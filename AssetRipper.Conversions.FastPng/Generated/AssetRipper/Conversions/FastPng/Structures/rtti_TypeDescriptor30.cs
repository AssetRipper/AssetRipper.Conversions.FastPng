using System.Runtime.InteropServices;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.Structures;

[StructLayout(LayoutKind.Explicit, Size = 48)]
[MangledName("rtti.TypeDescriptor30")]
public partial struct rtti_TypeDescriptor30
{
	[FieldOffset(0)]
	public unsafe void* field_0;

	[FieldOffset(8)]
	public unsafe void* field_1;

	[FieldOffset(16)]
	public InlineArray_31_w3otm9c field_2;
}
