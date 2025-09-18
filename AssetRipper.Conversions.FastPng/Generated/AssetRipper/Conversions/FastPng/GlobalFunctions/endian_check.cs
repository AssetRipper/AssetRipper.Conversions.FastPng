using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?endian_check@fpng@@YA_NXZ")]
[DemangledName("bool __cdecl fpng::endian_check(void)")]
internal static partial class endian_check
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke()
	{
		int num = 0;
		num = 305441741;
		return unchecked((byte)(*(sbyte*)(&num))) == 205;
	}
}
