using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$min@_K@std@@YAAEB_KAEB_K0@Z")]
[DemangledName("unsigned __int64 const & __cdecl std::min<unsigned __int64>(unsigned __int64 const &, unsigned __int64 const &)")]
internal static partial class min
{
	[return: NativeType("unsigned __int64 const &")]
	public unsafe static void* Invoke([MangledName("_Left")][NativeType("unsigned __int64 const &")] void* Left, [MangledName("_Right")][NativeType("unsigned __int64 const &")] void* Right)
	{
		return unchecked((ulong)(*(long*)Right) >= (ulong)(*(long*)Left)) ? Left : Right;
	}
}
