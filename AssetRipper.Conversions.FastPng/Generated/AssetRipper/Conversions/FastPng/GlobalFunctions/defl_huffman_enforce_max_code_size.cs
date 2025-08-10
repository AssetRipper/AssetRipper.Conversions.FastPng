using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?defl_huffman_enforce_max_code_size@fpng@@YAXPEAHHH@Z")]
[DemangledName("void __cdecl fpng::defl_huffman_enforce_max_code_size(int *, int, int)")]
internal static partial class defl_huffman_enforce_max_code_size
{
	public unsafe static void Invoke(void* pNum_codes, int code_list_len, int max_code_size)
	{
		int i = 0;
		if (code_list_len <= 1)
		{
			return;
		}
		for (int j = max_code_size + 1; j <= 32; j++)
		{
			unchecked((int*)pNum_codes)[max_code_size] += unchecked((int*)pNum_codes)[j];
		}
		for (int j = max_code_size; j > 0; j += -1)
		{
			unchecked
			{
				i += ((int*)pNum_codes)[j] << checked(max_code_size - j);
			}
		}
		for (; i != 1 << max_code_size; i = unchecked(i + -1))
		{
			unchecked((int*)pNum_codes)[max_code_size] += -1;
			for (int j = max_code_size - 1; j > 0; j += -1)
			{
				if (unchecked((int*)pNum_codes)[j] != 0)
				{
					unchecked((int*)pNum_codes)[j] += -1;
					unchecked((int*)pNum_codes)[j + 1] += 2;
					break;
				}
			}
		}
	}
}
