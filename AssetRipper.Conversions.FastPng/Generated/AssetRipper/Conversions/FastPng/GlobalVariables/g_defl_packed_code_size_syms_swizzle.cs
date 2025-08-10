using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("?g_defl_packed_code_size_syms_swizzle@fpng@@3PAEA")]
[DemangledName("unsigned char *fpng::g_defl_packed_code_size_syms_swizzle")]
internal static partial class g_defl_packed_code_size_syms_swizzle
{
	public unsafe static InlineArray_19_w3otm9c* __pointer;

	public unsafe static InlineArray_19_w3otm9c Value
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

	unsafe static g_defl_packed_code_size_syms_swizzle()
	{
		__pointer = unchecked((InlineArray_19_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_19_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_19_w3otm9c, byte>(new byte[19]
		{
			16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
			11, 4, 12, 3, 13, 2, 14, 1, 15
		});
	}
}
