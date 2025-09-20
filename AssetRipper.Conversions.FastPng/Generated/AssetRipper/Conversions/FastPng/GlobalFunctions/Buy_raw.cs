using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Buy_raw@?$vector@IV?$allocator@I@std@@@std@@AEAAX_K@Z")]
[DemangledName("private: void __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::_Buy_raw(unsigned __int64)")]
internal static partial class Buy_raw
{
	private partial struct LocalVariables
	{
		public long field_0;
	}

	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [MangledName("_Newcapacity")][NativeType("unsigned __int64")] long Newcapacity)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = Newcapacity;
		unchecked
		{
			void* field_ = &((std_vector_drook9b*)@this)->field_0.field_0;
			void* field_2 = &((std_Vector_val_edx9ebc*)field_)->field_0;
			void* field_3 = &((std_Vector_val_edx9ebc*)field_)->field_1;
			void* field_4 = &((std_Vector_val_edx9ebc*)field_)->field_2;
			void* ptr = Allocate_at_least_helper_22hwyxd.Invoke(Getal_t2pmqoc.Invoke(@this), &startFrame.GetLocalsPointer<LocalVariables>()->field_0);
			if (ExceptionInfo.Current == null)
			{
				*(byte**)field_4 = (byte*)(*(void**)field_3 = (*(void**)field_2 = ptr)) + (nint)startFrame.GetLocalsPointer<LocalVariables>()->field_0 * 4;
				StackFrameList.Current.Clear(startFrame);
			}
		}
	}
}
