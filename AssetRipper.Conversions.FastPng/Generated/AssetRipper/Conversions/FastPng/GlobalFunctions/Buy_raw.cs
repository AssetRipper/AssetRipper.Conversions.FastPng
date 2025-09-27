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
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = Newcapacity;
		unchecked
		{
			void* myval = &((std_vector_drook9b*)@this)->Mypair.Myval2;
			void* myfirst = &((std_Vector_val_edx9ebc*)myval)->Myfirst;
			void* mylast = &((std_Vector_val_edx9ebc*)myval)->Mylast;
			void* myend = &((std_Vector_val_edx9ebc*)myval)->Myend;
			void* ptr = Allocate_at_least_helper_22hwyxd.Invoke(Getal_t2pmqoc.Invoke(@this), &localsPointer->field_0);
			if (ExceptionInfo.Current == null)
			{
				*(byte**)myend = (byte*)(*(void**)mylast = (*(void**)myfirst = ptr)) + (nint)localsPointer->field_0 * 4;
				StackFrameList.Current.Clear(startFrame);
			}
		}
	}
}
