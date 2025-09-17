using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??0exception@std@@QEAA@QEBDH@Z")]
[DemangledName("public: __cdecl std::exception::exception(char const *const, int)")]
[CleanName("exception_Constructor")]
internal static partial class exception_Constructor_morlzmd
{
	public unsafe static void* Invoke(void* @this, void* Message, int parameter_2)
	{
		unchecked
		{
			*(byte**)@this = (byte*)(&Variable_x4f2ufc.__pointer->field_0) + sizeof(nint);
			llvm_memset_p0_i64.Invoke(&((std_exception*)@this)->field_1, 0, 16L, isVolatile: false);
			((std_exception*)@this)->field_1.field_0 = Message;
			return @this;
		}
	}
}
