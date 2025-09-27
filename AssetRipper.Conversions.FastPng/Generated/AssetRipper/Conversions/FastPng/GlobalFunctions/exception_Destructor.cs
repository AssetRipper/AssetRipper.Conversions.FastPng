using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;
using AssetRipper.Conversions.FastPng.Intrinsics.Unimplemented;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??1exception@std@@UEAA@XZ")]
[DemangledName("public: virtual __cdecl std::exception::~exception(void)")]
internal static partial class exception_Destructor
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			*(byte**)@this = (byte*)(&Variable_x4f2ufc.__pointer->field_0) + sizeof(nint);
			std_exception_destroy.Invoke(&((std_exception*)@this)->Data);
			if (ExceptionInfo.Current == null)
			{
				return;
			}
			ExceptionInfo.Current = null;
			std_terminate.Invoke();
			throw null;
		}
	}
}
