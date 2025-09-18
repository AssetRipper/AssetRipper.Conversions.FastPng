using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$?0AEBV?$allocator@I@std@@$$V@?$_Compressed_pair@V?$allocator@I@std@@V?$_Vector_val@U?$_Simple_types@I@std@@@2@$00@std@@QEAA@U_One_then_variadic_args_t@1@AEBV?$allocator@I@1@@Z")]
[DemangledName("public: __cdecl std::_Compressed_pair<class std::allocator<unsigned int>, class std::_Vector_val<struct std::_Simple_types<unsigned int>>, 1>::_Compressed_pair<class std::allocator<unsigned int>, class std::_Vector_val<struct std::_Simple_types<unsigned int>>, 1><class std::allocator<unsigned int> const &>(struct std::_One_then_variadic_args_t, class std::allocator<unsigned int> const &)")]
internal static partial class Compressed_pair_class_std_allocator_unsigned_int_class_std_Vector_val_struct_std_Simple_types_unsigned_int_1_Constructor
{
	public unsafe static void* Invoke(void* @this, [MangledName(".coerce")][NativeType("struct std::_One_then_variadic_args_t")] sbyte coerce, [MangledName("_Val1")][NativeType("class std::allocator<unsigned int> const &")] void* Val1)
	{
		std_One_then_variadic_args_t std_One_then_variadic_args_t = new std_One_then_variadic_args_t
		{
			field_0 = coerce
		};
		Vector_val_struct_std_Simple_types_unsigned_int_Constructor.Invoke(&unchecked((std_Compressed_pair_1*)@this)->field_0);
		return @this;
	}
}
