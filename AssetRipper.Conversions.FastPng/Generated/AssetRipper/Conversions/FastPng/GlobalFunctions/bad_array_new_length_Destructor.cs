using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??1bad_array_new_length@std@@UEAA@XZ")]
[DemangledName("public: virtual __cdecl std::bad_array_new_length::~bad_array_new_length(void)")]
internal static partial class bad_array_new_length_Destructor
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, void>)(&Invoke));

	public unsafe static void Invoke(void* @this)
	{
		bad_alloc_Destructor.Invoke(@this);
	}
}
