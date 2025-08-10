using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?READ_RGB_PIXEL@fpng@@YAIPEBX@Z")]
[DemangledName("unsigned int __cdecl fpng::READ_RGB_PIXEL(void const *)")]
internal static partial class READ_RGB_PIXEL
{
	public unsafe static int Invoke(void* p)
	{
		return *unchecked((int*)p) & 0xFFFFFF;
	}
}
