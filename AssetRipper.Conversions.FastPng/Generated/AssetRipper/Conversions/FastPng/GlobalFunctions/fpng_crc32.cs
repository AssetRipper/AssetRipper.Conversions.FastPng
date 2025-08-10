using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?fpng_crc32@fpng@@YAIPEBX_KI@Z")]
[DemangledName("unsigned int __cdecl fpng::fpng_crc32(void const *, unsigned __int64, unsigned int)")]
internal static partial class fpng_crc32
{
	public unsafe static int Invoke(void* pData, long size, int prev_crc32)
	{
		return crc32_slice_by_4.Invoke(pData, size, prev_crc32);
	}
}
