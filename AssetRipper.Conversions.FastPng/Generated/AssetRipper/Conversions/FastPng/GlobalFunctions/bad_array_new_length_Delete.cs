using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??_Gbad_array_new_length@std@@UEAAPEAXI@Z")]
[DemangledName("public: virtual void * __cdecl std::bad_array_new_length::`scalar deleting dtor'(unsigned int)")]
internal static partial class bad_array_new_length_Delete
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, int, void*>)(&Invoke));

	[return: NativeType("void *")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned int")] int should_call_delete)
	{
		bad_array_new_length_Destructor.Invoke(@this);
		if (should_call_delete != 0)
		{
			Delete.Invoke(@this, 24L);
		}
		return @this;
	}
}
