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
		Value = new rtti_BaseClassDescriptor
		{
			field_0 = PointerIndices.GetIndex(R0_AVbad_alloc.__pointer),
			field_1 = 1,
			field_2 = 0,
			field_3 = -1,
			field_4 = 0,
			field_5 = 64,
			field_6 = PointerIndices.GetIndex(R3bad_alloc.__pointer)
		};
	}
}
