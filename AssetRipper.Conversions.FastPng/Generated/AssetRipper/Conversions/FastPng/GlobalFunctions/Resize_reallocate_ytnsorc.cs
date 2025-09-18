using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Resize_reallocate@U_Value_init_tag@std@@@?$vector@_KV?$allocator@_K@std@@@std@@AEAAX_KAEBU_Value_init_tag@1@@Z")]
[DemangledName("private: void __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Resize_reallocate<struct std::_Value_init_tag>(unsigned __int64, struct std::_Value_init_tag const &)")]
[CleanName("Resize_reallocate")]
internal static partial class Resize_reallocate_ytnsorc
{
	private partial struct LocalVariables
	{
		public long field_0;

		public std_vector_unsigned_long_long_Reallocation_guard field_1;
	}

	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [MangledName("_Newsize")][NativeType("unsigned __int64")] long Newsize, [MangledName("_Val")][NativeType("struct std::_Value_init_tag const &")] void* Val)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		void* ptr = null;
		void* ptr2 = null;
		void* ptr3 = null;
		void* ptr4 = null;
		long num = 0L;
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = 0L;
		void* ptr5 = null;
		void* ptr6 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = default(std_vector_unsigned_long_long_Reallocation_guard);
		void* ptr7 = null;
		unchecked
		{
			if ((ulong)Newsize > (ulong)max_size_kyvxnnb.Invoke(@this))
			{
				Xlength_zmqdsxa.Invoke();
				throw null;
			}
			ptr = Getal_kuj7nva.Invoke(@this);
			ptr2 = &((std_vector_5*)@this)->field_0.field_0;
			ptr3 = &((std_Vector_val_9*)ptr2)->field_0;
			ptr4 = &((std_Vector_val_9*)ptr2)->field_1;
			num = ((long)(nuint)(*(nint*)ptr4) - (long)(nuint)(*(nint*)ptr3)) / 8L;
			long field_ = Calculate_growth_vbhwmec.Invoke(@this, Newsize);
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_;
			void* ptr8 = Allocate_at_least_helper_l9zi7qb.Invoke(ptr, &startFrame.GetLocalsPointer<LocalVariables>()->field_0);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			ptr5 = ptr8;
			ptr6 = (byte*)ptr5 + (nint)num * 8;
			startFrame.GetLocalsPointer<LocalVariables>()->field_1.field_0 = ptr;
			startFrame.GetLocalsPointer<LocalVariables>()->field_1.field_1 = ptr5;
			startFrame.GetLocalsPointer<LocalVariables>()->field_1.field_2 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
			startFrame.GetLocalsPointer<LocalVariables>()->field_1.field_3 = ptr6;
			startFrame.GetLocalsPointer<LocalVariables>()->field_1.field_4 = ptr6;
			ptr7 = &startFrame.GetLocalsPointer<LocalVariables>()->field_1.field_4;
			void* ptr9 = Uninitialized_value_construct_n_hqowyoc.Invoke(ptr6, Newsize - num, ptr);
			if (ExceptionInfo.Current == null)
			{
				*(void**)ptr7 = ptr9;
				Uninitialized_move_cbc4pbc.Invoke(Al: ptr, Dest: ptr5, Last: *(void**)ptr4, First: *(void**)ptr3);
				if (ExceptionInfo.Current == null)
				{
					startFrame.GetLocalsPointer<LocalVariables>()->field_1.field_1 = null;
					Change_array_hgqy2vc.Invoke(@this, ptr5, Newsize, startFrame.GetLocalsPointer<LocalVariables>()->field_0);
					Reallocation_guard_Destructor_jfaqped.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_1);
					StackFrameList.Current.Clear(startFrame);
					return;
				}
			}
			ExceptionInfo? current = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			Reallocation_guard_Destructor_jfaqped.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_1);
			ExceptionInfo.Current = current;
		}
	}
}
