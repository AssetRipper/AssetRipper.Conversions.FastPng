using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?crc32_slice_by_4@fpng@@YAIPEBX_KI@Z")]
[DemangledName("unsigned int __cdecl fpng::crc32_slice_by_4(void const *, unsigned __int64, unsigned int)")]
internal static partial class crc32_slice_by_4
{
	public unsafe static int Invoke(void* pData, long data_len, int cur_crc32)
	{
		int num = 0;
		void* ptr = null;
		long num2 = data_len;
		int num3 = cur_crc32 ^ -1;
		void* ptr2 = pData;
		unchecked
		{
			while ((ulong)num2 >= 4uL)
			{
				num = *(int*)ptr2 ^ num3;
				num3 = ((int*)g_crc32_4.__pointer)[(uint)(num >>> 24)] ^ ((int*)((byte*)g_crc32_4.__pointer + sizeof(InlineArray_256_vqkfj7a)))[(uint)((num >>> 16) & 0xFF)] ^ ((int*)((byte*)g_crc32_4.__pointer + (nint)2 * sizeof(InlineArray_256_vqkfj7a)))[(uint)((num >>> 8) & 0xFF)] ^ ((int*)((byte*)g_crc32_4.__pointer + (nint)3 * sizeof(InlineArray_256_vqkfj7a)))[(uint)(num & 0xFF)];
				ptr2 = (byte*)ptr2 + 4;
				num2 -= 4L;
			}
			ptr = ptr2;
			for (; num2 != 0L; num2 += -1L)
			{
				int num4 = num3 >>> 8;
				int num5 = num3 & 0xFF;
				void* ptr3 = ptr;
				ptr = (byte*)ptr3 + 1;
				long num6 = (uint)(num5 ^ (byte)(*(sbyte*)ptr3));
				num3 = num4 ^ ((int*)g_crc32_4.__pointer)[num6];
			}
			return num3 ^ -1;
		}
	}
}
