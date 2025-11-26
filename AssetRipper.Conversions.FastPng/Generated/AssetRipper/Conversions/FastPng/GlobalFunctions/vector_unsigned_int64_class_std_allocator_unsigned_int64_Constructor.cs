using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??0?$vector@_KV?$allocator@_K@std@@@std@@QEAA@XZ")]
[DemangledName("public: __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::vector<unsigned __int64, class std::allocator<unsigned __int64>>(void)")]
internal static partial class vector_unsigned_int64_class_std_allocator_unsigned_int64_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		std_Zero_then_variadic_args_t std_Zero_then_variadic_args_t2 = default(std_Zero_then_variadic_args_t);
		std_Fake_allocator std_Fake_allocator2 = default(std_Fake_allocator);
		unchecked
		{
			Compressed_pair_class_std_allocator_unsigned_int64_class_std_Vector_val_struct_std_Simple_types_unsigned_int64_1_Constructor.Invoke(&((std_vector_ucmdxb*)@this)->Mypair, std_Zero_then_variadic_args_t2.field_0);
			std_Vector_val_i7igbu* myval = &((std_vector_ucmdxb*)@this)->Mypair.Myval2;
			Get_proxy_allocator_pz3zxs.Invoke(Getal_ie7hg9.Invoke(@this));
			Alloc_proxy.Invoke(myval, &std_Fake_allocator2);
			return @this;
		}
	}
}
