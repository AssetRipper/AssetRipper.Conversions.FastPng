using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;
using AssetRipper.Conversions.FastPng.Intrinsics.Unimplemented;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??0exception@std@@QEAA@AEBV01@@Z")]
[DemangledName("public: __cdecl std::exception::exception(class std::exception const &)")]
[CleanName("exception_Constructor")]
internal static partial class exception_Constructor_ikocrpb
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, void*, void*>)(&Invoke));

	public unsafe static void* Invoke(void* @this, [MangledName("_Other")][NativeType("class std::exception const &")] void* Other)
	{
		unchecked
		{
			*(byte**)@this = (byte*)(&Variable_x4f2ufc.__pointer->field_0) + sizeof(nint);
			llvm_memset_p0_i64.Invoke(&((std_exception*)@this)->field_1, 0, 16L, isVolatile: false);
			std_exception_copy.Invoke(parameter_1: &((std_exception*)@this)->field_1, parameter_0: &((std_exception*)Other)->field_1);
			if (ExceptionInfo.Current == null)
			{
				return @this;
			}
			ExceptionInfo.Current = null;
			std_terminate.Invoke();
			throw null;
		}
	}
}
