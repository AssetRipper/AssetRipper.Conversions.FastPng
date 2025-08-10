using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("??$_Resize@U_Value_init_tag@std@@@?$vector@_KV?$allocator@_K@std@@@std@@AEAAX_KAEBU_Value_init_tag@1@@Z")]
[DemangledName("private: void __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Resize<struct std::_Value_init_tag>(unsigned __int64, struct std::_Value_init_tag const &)")]
[CleanName("Resize")]
internal static partial class Resize_2s9rs9d
{
	private partial struct LocalVariables
	{
		public unsafe void* Instruction_0;

		public long Instruction_1;

		public unsafe void* Instruction_2;

		public unsafe void* Instruction_3;

		public unsafe void* Instruction_4;

		public unsafe void* Instruction_5;

		public unsafe void* Instruction_6;

		public long Instruction_7;

		public unsafe void* Instruction_8;

		public long Instruction_9;

		public unsafe void* Instruction_10;
	}

	public unsafe static void Invoke(void* @this, long Newsize, void* Val)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = Val;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = Newsize;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = @this;
		void* instruction_ = startFrame.GetLocalsRef<LocalVariables>().Instruction_2;
		void* instruction_2 = Getal_kuj7nva.Invoke(instruction_);
		startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = instruction_2;
		unchecked
		{
			std_Vector_val_9* field_ = &((std_vector_5*)instruction_)->field_0.field_0;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_4 = field_;
			void** field_2 = &((std_Vector_val_9*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4)->field_0;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_5 = field_2;
			void** field_3 = &((std_Vector_val_9*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4)->field_1;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_6 = field_3;
			long instruction_3 = ((long)(nuint)(*(nint*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6) - (long)(nuint)(*(nint*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)) / 8L;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_3;
			if ((ulong)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 < (ulong)startFrame.GetLocalsRef<LocalVariables>().Instruction_7)
			{
				void* instruction_4 = *(void**)startFrame.GetLocalsRef<LocalVariables>().Instruction_5;
				long instruction_5 = startFrame.GetLocalsRef<LocalVariables>().Instruction_1;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = (byte*)instruction_4 + (nint)instruction_5 * 8;
				Orphan_range_qciws4b.Invoke(parameter_2: *(void**)startFrame.GetLocalsRef<LocalVariables>().Instruction_6, @this: instruction_, parameter_1: startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
				Destroy_range_qbzp7xb.Invoke(Al: startFrame.GetLocalsRef<LocalVariables>().Instruction_3, Last: *(void**)startFrame.GetLocalsRef<LocalVariables>().Instruction_6, First: startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
				void* instruction_6 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
				*(void**)startFrame.GetLocalsRef<LocalVariables>().Instruction_6 = instruction_6;
			}
			else if ((ulong)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 > (ulong)startFrame.GetLocalsRef<LocalVariables>().Instruction_7)
			{
				long instruction_7 = ((long)((std_Vector_val_9*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4)->field_2 - (long)(nuint)(*(nint*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)) / 8L;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_7;
				if ((ulong)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 > (ulong)startFrame.GetLocalsRef<LocalVariables>().Instruction_9)
				{
					Resize_reallocate_ytnsorc.Invoke(Val: startFrame.GetLocalsRef<LocalVariables>().Instruction_0, @this: instruction_, Newsize: startFrame.GetLocalsRef<LocalVariables>().Instruction_1);
					if (ExceptionInfo.Current != null)
					{
						return;
					}
				}
				else
				{
					void* instruction_8 = *(void**)startFrame.GetLocalsRef<LocalVariables>().Instruction_6;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_8;
					void* ptr = Uninitialized_value_construct_n_hqowyoc.Invoke(Al: startFrame.GetLocalsRef<LocalVariables>().Instruction_3, Count: startFrame.GetLocalsRef<LocalVariables>().Instruction_1 - startFrame.GetLocalsRef<LocalVariables>().Instruction_7, First: startFrame.GetLocalsRef<LocalVariables>().Instruction_10);
					*(void**)startFrame.GetLocalsRef<LocalVariables>().Instruction_6 = ptr;
					Orphan_range_qciws4b.Invoke(parameter_2: startFrame.GetLocalsRef<LocalVariables>().Instruction_10, @this: instruction_, parameter_1: startFrame.GetLocalsRef<LocalVariables>().Instruction_10);
				}
			}
			StackFrameList.Current.Clear(startFrame);
		}
	}
}
