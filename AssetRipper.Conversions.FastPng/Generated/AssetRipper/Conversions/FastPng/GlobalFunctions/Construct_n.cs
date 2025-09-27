using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Construct_n@$$V@?$vector@IV?$allocator@I@std@@@std@@AEAAX_K@Z")]
[DemangledName("private: void __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::_Construct_n<>(unsigned __int64)")]
internal static partial class Construct_n
{
	private partial struct LocalVariables
	{
		public std_Fake_allocator field_0;

		public std_Fake_proxy_ptr_impl field_1;

		public std_Tidy_guard field_2;
	}

	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [MangledName("_Count")][NativeType("unsigned __int64")] long Count)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(std_Fake_allocator);
		localsPointer->field_1 = default(std_Fake_proxy_ptr_impl);
		localsPointer->field_2 = default(std_Tidy_guard);
		void* ptr = Getal_t2pmqoc.Invoke(@this);
		Get_proxy_allocator_uag3hnc.Invoke(ptr);
		unchecked
		{
			void* myval = &((std_vector_drook9b*)@this)->Mypair.Myval2;
			Fake_proxy_ptr_impl_Constructor.Invoke(&localsPointer->field_1, &localsPointer->field_0, myval);
			if (Count != 0L)
			{
				Buy_nonzero.Invoke(@this, Count);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				localsPointer->field_2.Target = @this;
				void* mylast = Uninitialized_value_construct_n_zg4iwva.Invoke(((std_Vector_val_edx9ebc*)myval)->Myfirst, Count, ptr);
				if (ExceptionInfo.Current != null)
				{
					ExceptionInfo? current = ExceptionInfo.Current;
					ExceptionInfo.Current = null;
					Tidy_guard_class_std_vector_unsigned_int_class_std_allocator_unsigned_int_Destructor.Invoke(&localsPointer->field_2);
					ExceptionInfo.Current = current;
					return;
				}
				((std_Vector_val_edx9ebc*)myval)->Mylast = mylast;
				localsPointer->field_2.Target = null;
				Tidy_guard_class_std_vector_unsigned_int_class_std_allocator_unsigned_int_Destructor.Invoke(&localsPointer->field_2);
			}
			Release.Invoke(&localsPointer->field_1);
			StackFrameList.Current.Clear(startFrame);
		}
	}
}
