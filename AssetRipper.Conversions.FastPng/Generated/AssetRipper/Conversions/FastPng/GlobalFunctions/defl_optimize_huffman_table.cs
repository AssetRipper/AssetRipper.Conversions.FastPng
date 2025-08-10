using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?defl_optimize_huffman_table@fpng@@YAXPEAUdefl_huff@1@HHHH@Z")]
[DemangledName("void __cdecl fpng::defl_optimize_huffman_table(struct fpng::defl_huff *, int, int, int, int)")]
internal static partial class defl_optimize_huffman_table
{
	public unsafe static void Invoke(void* d, int table_num, int table_len, int code_size_limit, int static_table)
	{
		InlineArray_33_vqkfj7a inlineArray_33_vqkfj7a = default(InlineArray_33_vqkfj7a);
		InlineArray_33_vqkfj7a* ptr = &inlineArray_33_vqkfj7a;
		InlineArray_33_vqkfj7a inlineArray_33_vqkfj7a2 = default(InlineArray_33_vqkfj7a);
		InlineArray_33_vqkfj7a* ptr2 = &inlineArray_33_vqkfj7a2;
		InlineArray_288_27j5lac inlineArray_288_27j5lac = default(InlineArray_288_27j5lac);
		InlineArray_288_27j5lac* ptr3 = &inlineArray_288_27j5lac;
		InlineArray_288_27j5lac inlineArray_288_27j5lac2 = default(InlineArray_288_27j5lac);
		InlineArray_288_27j5lac* ptr4 = &inlineArray_288_27j5lac2;
		llvm_memset_p0_i64.Invoke(ptr, 0, 132L, isVolatile: false);
		int num2;
		if (static_table != 0)
		{
			for (int i = 0; i < table_len; i++)
			{
				(*unchecked((int*)((byte*)ptr + sizeof(int) * ((byte*)(&((fpng_defl_huff*)d)->field_2) + sizeof(InlineArray_288_w3otm9c) * table_num)[sizeof(sbyte) * i])))++;
			}
		}
		else
		{
			int num = 0;
			void* ptr6;
			unchecked
			{
				void* ptr5 = (byte*)(&((fpng_defl_huff*)d)->field_0) + sizeof(InlineArray_288_oeds4ea) * table_num + sizeof(short) * 0;
				for (int i = 0; i < table_len; i = checked(i + 1))
				{
					if (((short*)ptr5)[i] != 0)
					{
						short field_ = ((short*)ptr5)[i];
						((fpng_defl_sym_freq*)((byte*)ptr3 + sizeof(fpng_defl_sym_freq) * num))->field_0 = field_;
						((fpng_defl_sym_freq*)((byte*)ptr3 + sizeof(fpng_defl_sym_freq) * checked(num++)))->field_1 = (short)i;
					}
				}
				ptr6 = defl_radix_sort_syms.Invoke(num, (byte*)ptr3 + sizeof(fpng_defl_sym_freq) * 0, (byte*)ptr4 + sizeof(fpng_defl_sym_freq) * 0);
				defl_calculate_minimum_redundancy.Invoke(ptr6, num);
			}
			for (int i = 0; i < num; i++)
			{
				(*unchecked((int*)((byte*)ptr + sizeof(int) * (ushort)((fpng_defl_sym_freq*)ptr6)[i].field_0)))++;
			}
			unchecked
			{
				defl_huffman_enforce_max_code_size.Invoke((byte*)ptr + sizeof(int) * 0, num, code_size_limit);
				llvm_memset_p0_i64.Invoke((byte*)(&((fpng_defl_huff*)d)->field_2) + sizeof(InlineArray_288_w3otm9c) * table_num, 0, 288L, isVolatile: false);
				llvm_memset_p0_i64.Invoke((byte*)(&((fpng_defl_huff*)d)->field_1) + sizeof(InlineArray_288_oeds4ea) * table_num, 0, 576L, isVolatile: false);
				int i = 1;
				num2 = num;
				for (; i <= code_size_limit; i = checked(i + 1))
				{
					for (int j = *(int*)((byte*)ptr + sizeof(int) * i); j > 0; j = checked(j + -1))
					{
						sbyte b = (sbyte)i;
						InlineArray_288_w3otm9c* ptr7 = (InlineArray_288_w3otm9c*)((byte*)(&((fpng_defl_huff*)d)->field_2) + sizeof(InlineArray_288_w3otm9c) * table_num);
						void* ptr8 = ptr6;
						int num3 = checked(num2 + -1);
						num2 = num3;
						((sbyte*)ptr7)[sizeof(sbyte) * (ushort)((fpng_defl_sym_freq*)ptr8)[num3].field_1] = b;
					}
				}
			}
		}
		*unchecked((int*)((byte*)ptr2 + sizeof(int) * 1)) = 0;
		num2 = 0;
		for (int i = 2; i <= code_size_limit; i++)
		{
			num2 = (*unchecked((int*)((byte*)ptr2 + sizeof(int) * i)) = num2 + *unchecked((int*)((byte*)ptr + sizeof(int) * checked(i - 1))) << 1);
		}
		for (int i = 0; i < table_len; i++)
		{
			int num4 = 0;
			unchecked
			{
				int num5 = ((byte*)(&((fpng_defl_huff*)d)->field_2) + sizeof(InlineArray_288_w3otm9c) * table_num)[sizeof(sbyte) * i];
				int num6 = num5;
				if (num5 != 0)
				{
					int num7 = (*(int*)((byte*)ptr2 + sizeof(int) * (int)(uint)num6))++;
					int j = num6;
					while (j > 0)
					{
						num4 = (num4 << 1) | (num7 & 1);
						j = checked(j + -1);
						num7 >>>= 1;
					}
					*(short*)((byte*)(&((fpng_defl_huff*)d)->field_1) + sizeof(InlineArray_288_oeds4ea) * table_num + sizeof(short) * i) = (short)num4;
				}
			}
		}
	}
}
