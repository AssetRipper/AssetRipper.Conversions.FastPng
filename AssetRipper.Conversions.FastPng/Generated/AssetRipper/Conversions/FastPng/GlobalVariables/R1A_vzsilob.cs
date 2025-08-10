using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_R1A@?0A@EA@bad_alloc@std@@8")]
[DemangledName("std::bad_alloc::`RTTI Base Class Descriptor at (0, -1, 0, 64)'")]
[CleanName("R1A")]
internal static partial class R1A_vzsilob
{
	public unsafe static rtti_BaseClassDescriptor* __pointer;

	public unsafe static rtti_BaseClassDescriptor Value
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

	unsafe static R1A_vzsilob()
	{
		__pointer = unchecked((rtti_BaseClassDescriptor*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(rtti_BaseClassDescriptor))));
		rtti_BaseClassDescriptor value = default(rtti_BaseClassDescriptor);
		ref int field_ = ref value.field_0;
		field_ = PointerIndices.GetIndex(R0_AVbad_alloc.__pointer);
		value.field_1 = 1;
		value.field_2 = 0;
		value.field_3 = -1;
		value.field_4 = 0;
		value.field_5 = 64;
		ref int field_2 = ref value.field_6;
		field_2 = PointerIndices.GetIndex(R3bad_alloc.__pointer);
		Value = value;
	}
}
