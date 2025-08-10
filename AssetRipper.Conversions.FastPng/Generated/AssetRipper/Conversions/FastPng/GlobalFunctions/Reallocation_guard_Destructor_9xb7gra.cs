using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??1_Reallocation_guard@?$vector@EV?$allocator@E@std@@@std@@QEAA@XZ")]
[DemangledName("public: __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Reallocation_guard::~_Reallocation_guard(void)")]
[CleanName("Reallocation_guard_Destructor")]
internal static partial class Reallocation_guard_Destructor_9xb7gra
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((std_vector_unsigned_char_Reallocation_guard*)@this)->field_1 != null)
			{
				Destroy_range_jjcob5a.Invoke(Al: ((std_vector_unsigned_char_Reallocation_guard*)@this)->field_0, Last: ((std_vector_unsigned_char_Reallocation_guard*)@this)->field_4, First: ((std_vector_unsigned_char_Reallocation_guard*)@this)->field_3);
				deallocate_mc9rbjc.Invoke(((std_vector_unsigned_char_Reallocation_guard*)@this)->field_0, Count: ((std_vector_unsigned_char_Reallocation_guard*)@this)->field_2, Ptr: ((std_vector_unsigned_char_Reallocation_guard*)@this)->field_1);
			}
		}
	}
}
