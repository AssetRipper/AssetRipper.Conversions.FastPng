using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("?g_dyn_huff_3@fpng@@3QBEB")]
[DemangledName("unsigned char const *const fpng::g_dyn_huff_3")]
internal static partial class g_dyn_huff_3
{
	public unsafe static InlineArray62_SByte* __pointer;

	public unsafe static InlineArray62_SByte Value
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

	unsafe static g_dyn_huff_3()
	{
		__pointer = unchecked((InlineArray62_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray62_SByte))));
		Value = InlineArrayHelper.Create<InlineArray62_SByte, byte>(new byte[62]
		{
			120, 1, 237, 195, 3, 176, 110, 89, 122, 128,
			225, 247, 251, 214, 218, 248, 113, 124, 173, 190,
			109, 12, 50, 201, 196, 182, 109, 219, 182, 109,
			219, 182, 109, 219, 201, 36, 147, 153, 105, 235,
			246, 53, 142, 207, 143, 141, 181, 214, 151, 93,
			117, 170, 78, 117, 117, 58, 206, 77, 210, 217,
			169, 122
		});
	}
}
