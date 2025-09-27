using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?what@exception@std@@UEBAPEBDXZ")]
[DemangledName("public: virtual char const * __cdecl std::exception::what(void) const")]
internal static partial class what
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, void*>)(&Invoke));

	[return: NativeType("char const *")]
	public unsafe static void* Invoke(void* @this)
	{
		return unchecked((((std_exception*)@this)->Data.What == null) ? String_ja3ma5d.__pointer : ((std_exception*)@this)->Data.What);
	}
}
