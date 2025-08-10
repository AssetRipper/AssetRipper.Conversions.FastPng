using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??0?$vector@_KV?$allocator@_K@std@@@std@@QEAA@XZ")]
[DemangledName("public: __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::vector<unsigned __int64, class std::allocator<unsigned __int64>>(void)")]
internal static partial class vector_unsigned_int64_class_std_allocator_unsigned_int64_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		std_Zero_then_variadic_args_t std_Zero_then_variadic_args_t = default(std_Zero_then_variadic_args_t);
		std_Zero_then_variadic_args_t* ptr = &std_Zero_then_variadic_args_t;
		std_Fake_allocator std_Fake_allocator = default(std_Fake_allocator);
		std_Fake_allocator* parameter_ = &std_Fake_allocator;
		unchecked
		{
			Compressed_pair_class_std_allocator_unsigned_int64_class_std_Vector_val_struct_std_Simple_types_unsigned_int64_1_Constructor.Invoke(&((std_vector_5*)@this)->field_0, ptr->field_0);
			Alloc_proxy.Invoke(&((std_vector_5*)@this)->field_0.field_0, parameter_);
			return @this;
		}
	}
}
