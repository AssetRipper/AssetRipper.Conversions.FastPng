using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_R1A@?0A@EA@bad_array_new_length@std@@8")]
[DemangledName("std::bad_array_new_length::`RTTI Base Class Descriptor at (0, -1, 0, 64)'")]
[CleanName("R1A")]
internal static partial class R1A_9w7p7zd
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

	unsafe static R1A_9w7p7zd()
	{
		__pointer = unchecked((rtti_BaseClassDescriptor*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(rtti_BaseClassDescriptor))));
		rtti_BaseClassDescriptor value = default(rtti_BaseClassDescriptor);
		ref int field_ = ref value.field_0;
		field_ = PointerIndices.GetIndex(R0_AVbad_array_new_length.__pointer);
		value.field_1 = 2;
		value.field_2 = 0;
		value.field_3 = -1;
		value.field_4 = 0;
		value.field_5 = 64;
		ref int field_2 = ref value.field_6;
		field_2 = PointerIndices.GetIndex(R3bad_array_new_length.__pointer);
		Value = value;
	}
}
