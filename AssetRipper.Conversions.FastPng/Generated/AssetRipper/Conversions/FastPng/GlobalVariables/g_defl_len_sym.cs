using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("?g_defl_len_sym@fpng@@3QBGB")]
[DemangledName("unsigned short const *const fpng::g_defl_len_sym")]
internal static partial class g_defl_len_sym
{
	public unsafe static InlineArray_256_oeds4ea* __pointer;

	public unsafe static InlineArray_256_oeds4ea Value
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

	unsafe static g_defl_len_sym()
	{
		__pointer = unchecked((InlineArray_256_oeds4ea*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_256_oeds4ea))));
		Value = InlineArrayHelper.Create<InlineArray_256_oeds4ea, short>(new short[256]
		{
			257, 258, 259, 260, 261, 262, 263, 264, 265, 265,
			266, 266, 267, 267, 268, 268, 269, 269, 269, 269,
			270, 270, 270, 270, 271, 271, 271, 271, 272, 272,
			272, 272, 273, 273, 273, 273, 273, 273, 273, 273,
			274, 274, 274, 274, 274, 274, 274, 274, 275, 275,
			275, 275, 275, 275, 275, 275, 276, 276, 276, 276,
			276, 276, 276, 276, 277, 277, 277, 277, 277, 277,
			277, 277, 277, 277, 277, 277, 277, 277, 277, 277,
			278, 278, 278, 278, 278, 278, 278, 278, 278, 278,
			278, 278, 278, 278, 278, 278, 279, 279, 279, 279,
			279, 279, 279, 279, 279, 279, 279, 279, 279, 279,
			279, 279, 280, 280, 280, 280, 280, 280, 280, 280,
			280, 280, 280, 280, 280, 280, 280, 280, 281, 281,
			281, 281, 281, 281, 281, 281, 281, 281, 281, 281,
			281, 281, 281, 281, 281, 281, 281, 281, 281, 281,
			281, 281, 281, 281, 281, 281, 281, 281, 281, 281,
			282, 282, 282, 282, 282, 282, 282, 282, 282, 282,
			282, 282, 282, 282, 282, 282, 282, 282, 282, 282,
			282, 282, 282, 282, 282, 282, 282, 282, 282, 282,
			282, 282, 283, 283, 283, 283, 283, 283, 283, 283,
			283, 283, 283, 283, 283, 283, 283, 283, 283, 283,
			283, 283, 283, 283, 283, 283, 283, 283, 283, 283,
			283, 283, 283, 283, 284, 284, 284, 284, 284, 284,
			284, 284, 284, 284, 284, 284, 284, 284, 284, 284,
			284, 284, 284, 284, 284, 284, 284, 284, 284, 284,
			284, 284, 284, 284, 284, 285
		});
	}
}
