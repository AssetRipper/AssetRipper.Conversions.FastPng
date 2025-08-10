using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("?s_color_type@?1??fpng_encode_image_to_memory@fpng@@YA_NPEBXIIIAEAV?$vector@EV?$allocator@E@std@@@std@@I@Z@4QBEB")]
[DemangledName("unsigned char const *const `bool __cdecl fpng::fpng_encode_image_to_memory(void const *, unsigned int, unsigned int, unsigned int, class std::vector<unsigned char, class std::allocator<unsigned char>> &, unsigned int)'::`2'::s_color_type")]
internal static partial class s_color_type
{
	public unsafe static InlineArray_5_w3otm9c* __pointer;

	public unsafe static InlineArray_5_w3otm9c Value
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

	unsafe static s_color_type()
	{
		__pointer = unchecked((InlineArray_5_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_5_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_5_w3otm9c, byte>(new byte[5] { 0, 0, 4, 2, 6 });
	}
}
