using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("?s_length_extra@fpng@@3QBHB")]
[DemangledName("int const *const fpng::s_length_extra")]
internal static partial class s_length_extra
{
	public unsafe static InlineArray31_Int32* __pointer;

	public unsafe static InlineArray31_Int32 Value
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

	unsafe static s_length_extra()
	{
		__pointer = unchecked((InlineArray31_Int32*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray31_Int32))));
		Value = InlineArrayHelper.Create<InlineArray31_Int32, int>(new int[31]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
			1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
			4, 4, 4, 4, 5, 5, 5, 5, 0, 0,
			0
		});
	}
}
