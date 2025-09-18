using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?apply_filter@fpng@@YAXIHHIIPEBE0PEAE@Z")]
[DemangledName("void __cdecl fpng::apply_filter(unsigned int, int, int, unsigned int, unsigned int, unsigned char const *, unsigned char const *, unsigned char *)")]
internal static partial class apply_filter
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("unsigned int")] int filter, [NativeType("int")] int w, [NativeType("int")] int h, [NativeType("unsigned int")] int num_chans, [NativeType("unsigned int")] int bpl, [NativeType("unsigned char const *")] void* pSrc, [NativeType("unsigned char const *")] void* pPrev_src, [NativeType("unsigned char *")] void* pDst)
	{
		int num = 0;
		int num2 = 0;
		void* ptr = pDst;
		void* ptr2 = pPrev_src;
		void* ptr3 = pSrc;
		unchecked
		{
			switch (filter)
			{
			case 0:
			{
				void* ptr5 = ptr;
				ptr = (byte*)ptr5 + 1;
				*(sbyte*)ptr5 = 0;
				llvm_memcpy_p0_p0_i64.Invoke(ptr, ptr3, (uint)bpl, isVolatile: false);
				break;
			}
			case 2:
			{
				int num3;
				if (ptr2 != null)
				{
					num3 = -1;
				}
				else
				{
					wassert.Invoke(String_uc52kza.__pointer, String_uxbkrtb.__pointer, 1607);
					if (ExceptionInfo.Current != null)
					{
						break;
					}
					num3 = 0;
				}
				void* ptr4 = ptr;
				ptr = (byte*)ptr4 + 1;
				*(sbyte*)ptr4 = 2;
				if (num_chans == 3)
				{
					for (num = 0; (uint)num < (uint)w; num++)
					{
						*(sbyte*)ptr = (sbyte)checked(unchecked((byte)(*(sbyte*)ptr3)) - unchecked((byte)(*(sbyte*)ptr2)));
						((sbyte*)ptr)[1] = (sbyte)checked(unchecked((byte)((sbyte*)ptr3)[1]) - unchecked((byte)((sbyte*)ptr2)[1]));
						((sbyte*)ptr)[2] = (sbyte)checked(unchecked((byte)((sbyte*)ptr3)[2]) - unchecked((byte)((sbyte*)ptr2)[2]));
						ptr3 = (byte*)ptr3 + 3;
						ptr2 = (byte*)ptr2 + 3;
						ptr = (byte*)ptr + 3;
					}
					break;
				}
				for (num2 = 0; (uint)num2 < (uint)w; num2++)
				{
					*(sbyte*)ptr = (sbyte)checked(unchecked((byte)(*(sbyte*)ptr3)) - unchecked((byte)(*(sbyte*)ptr2)));
					((sbyte*)ptr)[1] = (sbyte)checked(unchecked((byte)((sbyte*)ptr3)[1]) - unchecked((byte)((sbyte*)ptr2)[1]));
					((sbyte*)ptr)[2] = (sbyte)checked(unchecked((byte)((sbyte*)ptr3)[2]) - unchecked((byte)((sbyte*)ptr2)[2]));
					((sbyte*)ptr)[3] = (sbyte)checked(unchecked((byte)((sbyte*)ptr3)[3]) - unchecked((byte)((sbyte*)ptr2)[3]));
					ptr3 = (byte*)ptr3 + 4;
					ptr2 = (byte*)ptr2 + 4;
					ptr = (byte*)ptr + 4;
				}
				break;
			}
			default:
				wassert.Invoke(String_kdrammb.__pointer, String_uxbkrtb.__pointer, 1657);
				if (ExceptionInfo.Current == null)
				{
				}
				break;
			}
		}
	}
}
