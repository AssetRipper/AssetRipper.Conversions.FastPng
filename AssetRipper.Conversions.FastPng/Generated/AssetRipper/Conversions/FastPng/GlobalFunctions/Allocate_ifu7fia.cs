using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Allocate@_Default_allocate_traits@std@@SAPEAX_K@Z")]
[DemangledName("public: static void * __cdecl std::_Default_allocate_traits::_Allocate(unsigned __int64)")]
[CleanName("Allocate")]
internal static partial class Allocate_ifu7fia
{
	[return: NativeType("void *")]
	public unsafe static void* Invoke([MangledName("_Bytes")][NativeType("unsigned __int64")] long Bytes)
	{
		return New.Invoke(Bytes);
	}
}
