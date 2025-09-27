using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?crc32_slice_by_4@fpng@@YAIPEBX_KI@Z")]
[DemangledName("unsigned int __cdecl fpng::crc32_slice_by_4(void const *, unsigned __int64, unsigned int)")]
internal static partial class crc32_slice_by_4
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("void const *")] void* pData, [NativeType("unsigned __int64")] long data_len, [NativeType("unsigned int")] int cur_crc32)
	{
		long num = data_len;
		int num2 = cur_crc32 ^ -1;
		void* ptr = pData;
		unchecked
		{
			while ((ulong)num >= 4uL)
			{
				int num3 = *(int*)ptr ^ num2;
				num2 = ((int*)g_crc32_4.__pointer)[(uint)(num3 >>> 24)] ^ ((int*)((byte*)g_crc32_4.__pointer + sizeof(InlineArray256_Int32)))[(uint)((num3 >>> 16) & 0xFF)] ^ ((int*)((byte*)g_crc32_4.__pointer + (nint)2 * sizeof(InlineArray256_Int32)))[(uint)((num3 >>> 8) & 0xFF)] ^ ((int*)((byte*)g_crc32_4.__pointer + (nint)3 * sizeof(InlineArray256_Int32)))[(uint)(num3 & 0xFF)];
				ptr = (byte*)ptr + 4;
				num -= 4L;
			}
			void* ptr2 = ptr;
			for (; num != 0L; num += -1L)
			{
				int num4 = num2 >>> 8;
				int num5 = num2 & 0xFF;
				void* ptr3 = ptr2;
				ptr2 = (byte*)ptr3 + 1;
				long num6 = (uint)(num5 ^ (byte)(*(sbyte*)ptr3));
				num2 = num4 ^ ((int*)g_crc32_4.__pointer)[num6];
			}
			return num2 ^ -1;
		}
	}
}
