using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("?g_bitmasks@fpng@@3QBIB")]
[DemangledName("unsigned int const *const fpng::g_bitmasks")]
internal static partial class g_bitmasks
{
	public unsafe static InlineArray_17_vqkfj7a* __pointer;

	public unsafe static InlineArray_17_vqkfj7a Value
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
		__pointer = unchecked((InlineArray_17_vqkfj7a*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_17_vqkfj7a))));
		Value = InlineArrayHelper.Create<InlineArray_17_vqkfj7a, int>(new int[17]
		{
			0, 1, 3, 7, 15, 31, 63, 127, 255, 511,
			1023, 2047, 4095, 8191, 16383, 32767, 65535
		});
	}
}
