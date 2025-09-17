using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?defl_huffman_enforce_max_code_size@fpng@@YAXPEAHHH@Z")]
[DemangledName("void __cdecl fpng::defl_huffman_enforce_max_code_size(int *, int, int)")]
internal static partial class defl_huffman_enforce_max_code_size
{
	public unsafe static void Invoke(void* pNum_codes, int code_list_len, int max_code_size)
	{
		int num = 0;
		int i = 0;
		if (code_list_len <= 1)
		{
			return;
		}
		for (num = max_code_size + 1; num <= 32; num++)
		{
			unchecked((int*)pNum_codes)[max_code_size] += unchecked((int*)pNum_codes)[num];
		}
		for (num = max_code_size; num > 0; num += -1)
		{
			unchecked
			{
				i += ((int*)pNum_codes)[num] << checked(max_code_size - num);
			}
		}
		for (; i != 1 << max_code_size; i = unchecked(i + -1))
		{
			unchecked((int*)pNum_codes)[max_code_size] += -1;
			for (num = max_code_size - 1; num > 0; num += -1)
			{
				if (unchecked((int*)pNum_codes)[num] != 0)
				{
					unchecked((int*)pNum_codes)[num] += -1;
					unchecked((int*)pNum_codes)[num + 1] += 2;
					break;
				}
			}
		}
	}
}
