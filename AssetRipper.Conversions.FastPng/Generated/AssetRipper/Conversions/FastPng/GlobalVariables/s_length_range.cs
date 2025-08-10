using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("?s_length_range@fpng@@3QBHB")]
[DemangledName("int const *const fpng::s_length_range")]
internal static partial class s_length_range
{
	public unsafe static InlineArray_31_vqkfj7a* __pointer;

	public unsafe static InlineArray_31_vqkfj7a Value
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

	unsafe static s_length_range()
	{
		__pointer = unchecked((InlineArray_31_vqkfj7a*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_31_vqkfj7a))));
		Value = InlineArrayHelper.Create<InlineArray_31_vqkfj7a, int>(new int[31]
		{
			3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
			15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
			67, 83, 99, 115, 131, 163, 195, 227, 258, 0,
			0
		});
	}
}
