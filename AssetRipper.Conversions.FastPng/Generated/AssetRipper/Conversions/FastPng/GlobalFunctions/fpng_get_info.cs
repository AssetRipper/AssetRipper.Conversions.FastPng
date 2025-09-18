using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?fpng_get_info@fpng@@YAHPEBXIAEAI11@Z")]
[DemangledName("int __cdecl fpng::fpng_get_info(void const *, unsigned int, unsigned int &, unsigned int &, unsigned int &)")]
internal static partial class fpng_get_info
{
	private partial struct LocalVariables
	{
		public int field_0;

		public int field_1;
	}

	[return: NativeType("int")]
	public unsafe static int Invoke([NativeType("void const *")] void* pImage, [NativeType("unsigned int")] int image_size, [NativeType("unsigned int &")] void* width, [NativeType("unsigned int &")] void* height, [NativeType("unsigned int &")] void* channels_in_file)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
		int result = fpng_get_info_internal.Invoke(pImage, image_size, width, height, channels_in_file, &startFrame.GetLocalsPointer<LocalVariables>()->field_0, &startFrame.GetLocalsPointer<LocalVariables>()->field_1);
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
