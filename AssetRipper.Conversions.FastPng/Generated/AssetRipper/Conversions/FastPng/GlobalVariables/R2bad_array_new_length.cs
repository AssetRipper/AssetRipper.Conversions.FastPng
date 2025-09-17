using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_R2bad_array_new_length@std@@8")]
[DemangledName("std::bad_array_new_length::`RTTI Base Class Array'")]
internal static partial class R2bad_array_new_length
{
	public unsafe static InlineArray_4_vqkfj7a* __pointer;

	public unsafe static InlineArray_4_vqkfj7a Value
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

	unsafe static R2bad_array_new_length()
	{
		__pointer = unchecked((InlineArray_4_vqkfj7a*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_4_vqkfj7a))));
		Value = new InlineArrayBuilder<InlineArray_4_vqkfj7a, int>
		{
			PointerIndices.GetIndex(R1A_9w7p7zd.__pointer),
			PointerIndices.GetIndex(R1A_vzsilob.__pointer),
			PointerIndices.GetIndex(R1A_bbqer2a.__pointer),
			0
		};
	}
}
