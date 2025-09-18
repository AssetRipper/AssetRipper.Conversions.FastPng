using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?_Throw_bad_array_new_length@std@@YAXXZ")]
[DemangledName("void __cdecl std::_Throw_bad_array_new_length(void)")]
internal static partial class Throw_bad_array_new_length
{
	private partial struct LocalVariables
	{
		public std_bad_array_new_length field_0;
	}

	[return: NativeType("void")]
	public unsafe static void Invoke()
	{
		StackFrame stackFrame = StackFrameList.Current.New<LocalVariables>();
		stackFrame.GetLocalsPointer<LocalVariables>()->field_0 = default(std_bad_array_new_length);
		bad_array_new_length_Constructor_fnjru5d.Invoke(&stackFrame.GetLocalsPointer<LocalVariables>()->field_0);
		CxxThrowException.Invoke(&stackFrame.GetLocalsPointer<LocalVariables>()->field_0, TI3_AVbad_array_new_length_std.__pointer);
		if (ExceptionInfo.Current != null)
		{
			return;
		}
		throw null;
	}
}
