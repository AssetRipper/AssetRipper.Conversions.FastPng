using System.Runtime.InteropServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Structures;

[StructLayout(LayoutKind.Explicit, Size = 28)]
[MangledName("rtti.BaseClassDescriptor")]
[DemangledName("rtti.BaseClassDescriptor")]
public partial struct rtti_BaseClassDescriptor
{
	[FieldOffset(0)]
	public int field_0;

	[FieldOffset(4)]
	public int field_1;

	[FieldOffset(8)]
	public int field_2;

	[FieldOffset(12)]
	public int field_3;

	[FieldOffset(16)]
	public int field_4;

	[FieldOffset(20)]
	public int field_5;

	[FieldOffset(24)]
	public int field_6;
}
