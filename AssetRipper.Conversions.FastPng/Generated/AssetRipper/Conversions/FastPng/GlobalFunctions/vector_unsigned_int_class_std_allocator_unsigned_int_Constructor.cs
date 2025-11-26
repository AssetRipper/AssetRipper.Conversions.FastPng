using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??0?$vector@IV?$allocator@I@std@@@std@@QEAA@_KAEBV?$allocator@I@1@@Z")]
[DemangledName("public: __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::vector<unsigned int, class std::allocator<unsigned int>>(unsigned __int64, class std::allocator<unsigned int> const &)")]
internal static partial class vector_unsigned_int_class_std_allocator_unsigned_int_Constructor
{
	private partial struct LocalVariables
	{
		public std_One_then_variadic_args_t field_0;
	}

	public unsafe static void* Invoke(void* @this, [MangledName("_Count")][NativeType("unsigned __int64")] long Count, [MangledName("_Al")][NativeType("class std::allocator<unsigned int> const &")] void* Al)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(std_One_then_variadic_args_t);
		Compressed_pair_class_std_allocator_unsigned_int_class_std_Vector_val_struct_std_Simple_types_unsigned_int_1_Constructor.Invoke(&unchecked((std_vector_jsyy6a*)@this)->Mypair, localsPointer->field_0.field_0, Al);
		Construct_n.Invoke(@this, Count);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		StackFrameList.Current.Clear(startFrame);
		return @this;
	}
}
