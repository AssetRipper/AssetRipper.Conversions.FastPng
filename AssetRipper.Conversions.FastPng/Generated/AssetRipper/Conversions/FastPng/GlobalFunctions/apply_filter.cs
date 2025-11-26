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
				if (ptr2 == null)
				{
					wassert.Invoke(String_vtzqzc.__pointer, String_ksmiy6.__pointer, 1607);
					if (ExceptionInfo.Current != null)
					{
						break;
					}
				}
				void* ptr4 = ptr;
				ptr = (byte*)ptr4 + 1;
				*(sbyte*)ptr4 = 2;
				if (num_chans == 3)
				{
					for (int i = 0; (uint)i < (uint)w; i++)
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
				for (int j = 0; (uint)j < (uint)w; j++)
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
				wassert.Invoke(String_v852r7.__pointer, String_ksmiy6.__pointer, 1657);
				if (ExceptionInfo.Current == null)
				{
				}
				break;
			}
		}
	}
}
