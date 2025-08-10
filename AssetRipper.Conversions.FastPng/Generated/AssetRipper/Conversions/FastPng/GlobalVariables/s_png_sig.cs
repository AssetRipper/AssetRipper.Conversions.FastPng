using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("?s_png_sig@?1??fpng_get_info_internal@fpng@@YAHPEBXIAEAI1111@Z@4QBEB")]
[DemangledName("unsigned char const *const `int __cdecl fpng::fpng_get_info_internal(void const *, unsigned int, unsigned int &, unsigned int &, unsigned int &, unsigned int &, unsigned int &)'::`2'::s_png_sig")]
internal static partial class s_png_sig
{
	public unsafe static InlineArray_8_w3otm9c* __pointer;

	public unsafe static InlineArray_8_w3otm9c Value
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

	unsafe static s_png_sig()
	{
		__pointer = unchecked((InlineArray_8_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_8_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_8_w3otm9c, byte>(new byte[8] { 137, 80, 78, 71, 13, 10, 26, 10 });
	}
}
