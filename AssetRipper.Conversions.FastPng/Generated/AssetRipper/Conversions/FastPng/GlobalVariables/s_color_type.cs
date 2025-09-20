using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("?s_color_type@?1??fpng_encode_image_to_memory@fpng@@YA_NPEBXIIIAEAV?$vector@EV?$allocator@E@std@@@std@@I@Z@4QBEB")]
[DemangledName("unsigned char const *const `bool __cdecl fpng::fpng_encode_image_to_memory(void const *, unsigned int, unsigned int, unsigned int, class std::vector<unsigned char, class std::allocator<unsigned char>> &, unsigned int)'::`2'::s_color_type")]
internal static partial class s_color_type
{
	public unsafe static InlineArray5_SByte* __pointer;

	public unsafe static InlineArray5_SByte Value
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
		__pointer = unchecked((InlineArray5_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray5_SByte))));
		Value = InlineArrayHelper.Create<InlineArray5_SByte, byte>(new byte[5] { 0, 0, 4, 2, 6 });
	}
}
