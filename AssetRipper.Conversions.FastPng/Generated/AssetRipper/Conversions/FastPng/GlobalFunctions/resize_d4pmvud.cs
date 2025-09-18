using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?resize@?$vector@_KV?$allocator@_K@std@@@std@@QEAAX_K@Z")]
[DemangledName("public: void __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::resize(unsigned __int64)")]
[CleanName("resize")]
internal static partial class resize_d4pmvud
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
		Resize_2s9rs9d.Invoke(@this, Newsize, &startFrame.GetLocalsPointer<LocalVariables>()->field_0);
		if (ExceptionInfo.Current == null)
		{
			StackFrameList.Current.Clear(startFrame);
		}
	}
}
