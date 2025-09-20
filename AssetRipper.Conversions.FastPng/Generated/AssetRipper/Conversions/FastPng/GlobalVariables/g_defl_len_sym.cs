using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalVariables;

[MangledName("?g_defl_len_sym@fpng@@3QBGB")]
[DemangledName("unsigned short const *const fpng::g_defl_len_sym")]
internal static partial class g_defl_len_sym
{
	public unsafe static InlineArray256_Int16* __pointer;

	public unsafe static InlineArray256_Int16 Value
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
		__pointer = unchecked((InlineArray256_Int16*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray256_Int16))));
		Value = InlineArrayHelper.Create<InlineArray256_Int16, short>(new short[256]
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
