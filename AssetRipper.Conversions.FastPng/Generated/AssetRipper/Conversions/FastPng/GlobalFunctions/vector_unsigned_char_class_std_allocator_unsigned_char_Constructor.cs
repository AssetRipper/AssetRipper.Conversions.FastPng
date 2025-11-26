using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??0?$vector@EV?$allocator@E@std@@@std@@QEAA@XZ")]
[DemangledName("public: __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::vector<unsigned char, class std::allocator<unsigned char>>(void)")]
internal static partial class vector_unsigned_char_class_std_allocator_unsigned_char_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		std_Zero_then_variadic_args_t std_Zero_then_variadic_args_t2 = default(std_Zero_then_variadic_args_t);
		std_Fake_allocator std_Fake_allocator2 = default(std_Fake_allocator);
		unchecked
		{
			Compressed_pair_class_std_allocator_unsigned_char_class_std_Vector_val_struct_std_Simple_types_unsigned_char_1_Constructor.Invoke(&((std_vector_4tqn2f*)@this)->Mypair, std_Zero_then_variadic_args_t2.field_0);
			std_Vector_val_ghsspe* myval = &((std_vector_4tqn2f*)@this)->Mypair.Myval2;
			Get_proxy_allocator_gq86h4.Invoke(Getal_vpqbcr.Invoke(@this));
			Alloc_proxy.Invoke(myval, &std_Fake_allocator2);
			return @this;
		}
	}
}
