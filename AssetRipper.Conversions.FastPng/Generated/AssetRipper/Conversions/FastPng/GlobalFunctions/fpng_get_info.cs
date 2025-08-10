using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?fpng_get_info@fpng@@YAHPEBXIAEAI11@Z")]
[DemangledName("int __cdecl fpng::fpng_get_info(void const *, unsigned int, unsigned int &, unsigned int &, unsigned int &)")]
internal static partial class fpng_get_info
{
	private partial struct LocalVariables
	{
		public unsafe void* Instruction_0;

		public unsafe void* Instruction_1;

		public unsafe void* Instruction_2;

		public int Instruction_3;

		public unsafe void* Instruction_4;

		public int Instruction_5;

		public int Instruction_6;
	}

	public unsafe static int Invoke(void* pImage, int image_size, void* width, void* height, void* channels_in_file)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		int* idat_ofs = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_5;
		int* idat_len = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_6;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = channels_in_file;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = height;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = width;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = image_size;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_4 = pImage;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_5 = 0;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_6 = 0;
		int result = fpng_get_info_internal.Invoke(channels_in_file: startFrame.GetLocalsRef<LocalVariables>().Instruction_0, height: startFrame.GetLocalsRef<LocalVariables>().Instruction_1, width: startFrame.GetLocalsRef<LocalVariables>().Instruction_2, image_size: startFrame.GetLocalsRef<LocalVariables>().Instruction_3, pImage: startFrame.GetLocalsRef<LocalVariables>().Instruction_4, idat_ofs: idat_ofs, idat_len: idat_len);
		if (ExceptionInfo.Current != null)
		{
			return 0;
		}
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
