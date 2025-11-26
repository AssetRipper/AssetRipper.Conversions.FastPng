using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??1?$_Tidy_guard@V?$vector@IV?$allocator@I@std@@@std@@@std@@QEAA@XZ")]
[DemangledName("public: __cdecl std::_Tidy_guard<class std::vector<unsigned int, class std::allocator<unsigned int>>>::~_Tidy_guard<class std::vector<unsigned int, class std::allocator<unsigned int>>>(void)")]
internal static partial class Tidy_guard_class_std_vector_unsigned_int_class_std_allocator_unsigned_int_Destructor
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((std_Tidy_guard*)@this)->Target != null)
			{
				Tidy_t4s52y.Invoke(((std_Tidy_guard*)@this)->Target);
			}
		}
	}
}
