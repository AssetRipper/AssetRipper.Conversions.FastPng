using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??0bad_alloc@std@@QEAA@AEBV01@@Z")]
[DemangledName("public: __cdecl std::bad_alloc::bad_alloc(class std::bad_alloc const &)")]
[CleanName("bad_alloc_Constructor")]
internal static partial class bad_alloc_Constructor_3vdoaxb
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, void*, void*>)(&Invoke));

	public unsafe static void* Invoke(void* @this, void* parameter_1)
	{
		exception_Constructor_ikocrpb.Invoke(@this, parameter_1);
		unchecked
		{
			*(byte**)@this = (byte*)(&Variable_zdor9mc.__pointer->field_0) + sizeof(nint);
			return @this;
		}
	}
}
