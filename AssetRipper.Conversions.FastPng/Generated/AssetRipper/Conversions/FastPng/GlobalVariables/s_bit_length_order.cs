using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("?s_bit_length_order@?1??prepare_dynamic_block@fpng@@YA_NPEBEIAEAI1AEA_KPEAII@Z@4QBEB")]
[DemangledName("unsigned char const *const `bool __cdecl fpng::prepare_dynamic_block(unsigned char const *, unsigned int, unsigned int &, unsigned int &, unsigned __int64 &, unsigned int *, unsigned int)'::`2'::s_bit_length_order")]
internal static partial class s_bit_length_order
{
	public unsafe static InlineArray19_SByte* __pointer;

	public unsafe static InlineArray19_SByte Value
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

	unsafe static s_bit_length_order()
	{
		__pointer = unchecked((InlineArray19_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray19_SByte))));
		Value = InlineArrayHelper.Create<InlineArray19_SByte, byte>(new byte[19]
		{
			16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
			11, 4, 12, 3, 13, 2, 14, 1, 15
		});
	}
}
