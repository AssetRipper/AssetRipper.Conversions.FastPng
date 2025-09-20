using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("?g_bitmasks@fpng@@3QBIB")]
[DemangledName("unsigned int const *const fpng::g_bitmasks")]
internal static partial class g_bitmasks
{
	public unsafe static InlineArray17_Int32* __pointer;

	public unsafe static InlineArray17_Int32 Value
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

	unsafe static g_bitmasks()
	{
		__pointer = unchecked((InlineArray17_Int32*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray17_Int32))));
		Value = InlineArrayHelper.Create<InlineArray17_Int32, int>(new int[17]
		{
			0, 1, 3, 7, 15, 31, 63, 127, 255, 511,
			1023, 2047, 4095, 8191, 16383, 32767, 65535
		});
	}
}
