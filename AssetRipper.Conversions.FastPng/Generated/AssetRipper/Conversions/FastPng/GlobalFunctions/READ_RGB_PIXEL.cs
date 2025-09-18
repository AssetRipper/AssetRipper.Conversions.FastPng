using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?READ_RGB_PIXEL@fpng@@YAIPEBX@Z")]
[DemangledName("unsigned int __cdecl fpng::READ_RGB_PIXEL(void const *)")]
internal static partial class READ_RGB_PIXEL
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("void const *")] void* p)
	{
		return *unchecked((int*)p) & 0xFFFFFF;
	}
}
