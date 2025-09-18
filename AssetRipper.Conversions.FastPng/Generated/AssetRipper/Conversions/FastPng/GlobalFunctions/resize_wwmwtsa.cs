using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?resize@?$vector@EV?$allocator@E@std@@@std@@QEAAX_K@Z")]
[DemangledName("public: void __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::resize(unsigned __int64)")]
[CleanName("resize")]
internal static partial class resize_wwmwtsa
{
	private partial struct LocalVariables
	{
		public std_Value_init_tag field_0;
	}

	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [MangledName("_Newsize")][NativeType("unsigned __int64")] long Newsize)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = default(std_Value_init_tag);
		Resize_p4x2rua.Invoke(@this, Newsize, &startFrame.GetLocalsPointer<LocalVariables>()->field_0);
		if (ExceptionInfo.Current == null)
		{
			StackFrameList.Current.Clear(startFrame);
		}
	}
}
