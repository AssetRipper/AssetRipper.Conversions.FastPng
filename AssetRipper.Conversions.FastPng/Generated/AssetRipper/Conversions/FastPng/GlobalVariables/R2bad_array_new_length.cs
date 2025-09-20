using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("??_R2bad_array_new_length@std@@8")]
[DemangledName("std::bad_array_new_length::`RTTI Base Class Array'")]
internal static partial class R2bad_array_new_length
{
	public unsafe static InlineArray4_Int32* __pointer;

	public unsafe static InlineArray4_Int32 Value
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
		__pointer = unchecked((InlineArray4_Int32*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray4_Int32))));
		Value = new InlineArrayBuilder<InlineArray4_Int32, int>
		{
			PointerIndices.GetIndex(R1A_9w7p7zd.__pointer),
			PointerIndices.GetIndex(R1A_vzsilob.__pointer),
			PointerIndices.GetIndex(R1A_bbqer2a.__pointer),
			0
		};
	}
}
