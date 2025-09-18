using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$?0$$V@?$_Compressed_pair@V?$allocator@_K@std@@V?$_Vector_val@U?$_Simple_types@_K@std@@@2@$00@std@@QEAA@U_Zero_then_variadic_args_t@1@@Z")]
[DemangledName("public: __cdecl std::_Compressed_pair<class std::allocator<unsigned __int64>, class std::_Vector_val<struct std::_Simple_types<unsigned __int64>>, 1>::_Compressed_pair<class std::allocator<unsigned __int64>, class std::_Vector_val<struct std::_Simple_types<unsigned __int64>>, 1><>(struct std::_Zero_then_variadic_args_t)")]
internal static partial class Compressed_pair_class_std_allocator_unsigned_int64_class_std_Vector_val_struct_std_Simple_types_unsigned_int64_1_Constructor
{
	public unsafe static void* Invoke(void* @this, [MangledName(".coerce")][NativeType("struct std::_Zero_then_variadic_args_t")] sbyte coerce)
	{
		std_Zero_then_variadic_args_t std_Zero_then_variadic_args_t = new std_Zero_then_variadic_args_t
		{
			field_0 = coerce
		};
		allocator_unsigned_int64_Constructor.Invoke(@this);
		Vector_val_struct_std_Simple_types_unsigned_int64_Constructor.Invoke(&unchecked((std_Compressed_pair_6*)@this)->field_0);
		return @this;
	}
}
