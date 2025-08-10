using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("?g_dyn_huff_4@fpng@@3QBEB")]
[DemangledName("unsigned char const *const fpng::g_dyn_huff_4")]
internal static partial class g_dyn_huff_4
{
	public unsafe static InlineArray_61_w3otm9c* __pointer;

	public unsafe static InlineArray_61_w3otm9c Value
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

	unsafe static g_dyn_huff_4()
	{
		__pointer = unchecked((InlineArray_61_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_61_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_61_w3otm9c, byte>(new byte[61]
		{
			120, 1, 229, 196, 99, 180, 37, 103, 218, 128,
			225, 251, 121, 171, 106, 243, 216, 231, 180, 109,
			196, 182, 51, 51, 73, 6, 201, 216, 182, 109,
			219, 182, 17, 140, 98, 219, 102, 219, 60, 125,
			172, 205, 170, 122, 159, 111, 213, 143, 179, 214,
			94, 189, 58, 153, 104, 166, 103, 190, 247, 199,
			117
		});
	}
}
