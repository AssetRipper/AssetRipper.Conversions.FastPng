using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_R3bad_alloc@std@@8")]
[DemangledName("std::bad_alloc::`RTTI Class Hierarchy Descriptor'")]
internal static partial class R3bad_alloc
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

	unsafe static R3bad_alloc()
	{
		__pointer = unchecked((rtti_ClassHierarchyDescriptor*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(rtti_ClassHierarchyDescriptor))));
		rtti_ClassHierarchyDescriptor value = new rtti_ClassHierarchyDescriptor
		{
			field_0 = 0,
			field_1 = 0,
			field_2 = 2
		};
		ref int field_ = ref value.field_3;
		field_ = PointerIndices.GetIndex(R2bad_alloc.__pointer);
		Value = value;
	}
}
