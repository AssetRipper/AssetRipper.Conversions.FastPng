using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?fpng_adler32@fpng@@YAIPEBX_KI@Z")]
[DemangledName("unsigned int __cdecl fpng::fpng_adler32(void const *, unsigned __int64, unsigned int)")]
internal static partial class fpng_adler32
{
	public unsafe static int Invoke(void* pData, long size, int adler)
	{
		return fpng_adler32_scalar.Invoke(pData, size, adler);
	}
}
