using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??_Gbad_alloc@std@@UEAAPEAXI@Z")]
[DemangledName("public: virtual void * __cdecl std::bad_alloc::`scalar deleting dtor'(unsigned int)")]
internal static partial class bad_alloc_Delete
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, int, void*>)(&Invoke));

	[return: NativeType("void *")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned int")] int should_call_delete)
	{
		bad_alloc_Destructor.Invoke(@this);
		if (should_call_delete != 0)
		{
			Delete.Invoke(@this, 24L);
		}
		return @this;
	}
}
