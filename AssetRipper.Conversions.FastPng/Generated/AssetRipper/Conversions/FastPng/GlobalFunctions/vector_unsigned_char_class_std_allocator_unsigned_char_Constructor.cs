using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??0?$vector@EV?$allocator@E@std@@@std@@QEAA@XZ")]
[DemangledName("public: __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::vector<unsigned char, class std::allocator<unsigned char>>(void)")]
internal static partial class vector_unsigned_char_class_std_allocator_unsigned_char_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		std_Zero_then_variadic_args_t std_Zero_then_variadic_args_t = default(std_Zero_then_variadic_args_t);
		std_Fake_allocator std_Fake_allocator = default(std_Fake_allocator);
		unchecked
		{
			Compressed_pair_class_std_allocator_unsigned_char_class_std_Vector_val_struct_std_Simple_types_unsigned_char_1_Constructor.Invoke(&((std_vector_7uge3hb*)@this)->field_0, std_Zero_then_variadic_args_t.field_0);
			std_Vector_val_p59sy9d* field_ = &((std_vector_7uge3hb*)@this)->field_0.field_0;
			Get_proxy_allocator_zrfshta.Invoke(Getal_jms5hzb.Invoke(@this));
			Alloc_proxy.Invoke(field_, &std_Fake_allocator);
			return @this;
		}
	}
}
