using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_R3exception@std@@8")]
[DemangledName("std::exception::`RTTI Class Hierarchy Descriptor'")]
internal static partial class R3exception
{
	public unsafe static rtti_ClassHierarchyDescriptor* __pointer;

	public unsafe static rtti_ClassHierarchyDescriptor Value
	{
		get
		{
			return *__pointer;
		}
		set
		{
			*__pointer = value;
		}
	}

	unsafe static R3exception()
	{
		__pointer = unchecked((rtti_ClassHierarchyDescriptor*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(rtti_ClassHierarchyDescriptor))));
		Value = new rtti_ClassHierarchyDescriptor
		{
			field_0 = 0,
			field_1 = 0,
			field_2 = 1,
			field_3 = PointerIndices.GetIndex(R2exception.__pointer)
		};
	}
}
