using System.Runtime.InteropServices;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("rtti.ClassHierarchyDescriptor")]
[DemangledName("rtti.ClassHierarchyDescriptor")]
public partial struct rtti_ClassHierarchyDescriptor
{
	[FieldOffset(0)]
	public int field_0;

	[FieldOffset(4)]
	public int field_1;

	[FieldOffset(8)]
	public int field_2;

	[FieldOffset(12)]
	public int field_3;
}
