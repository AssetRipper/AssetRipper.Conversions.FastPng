using System.Runtime.CompilerServices;
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
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		InlineArray_33_vqkfj7a inlineArray_33_vqkfj7a = default(InlineArray_33_vqkfj7a);
		InlineArray_33_vqkfj7a inlineArray_33_vqkfj7a2 = default(InlineArray_33_vqkfj7a);
		InlineArray_288_27j5lac inlineArray_288_27j5lac = default(InlineArray_288_27j5lac);
		InlineArray_288_27j5lac inlineArray_288_27j5lac2 = default(InlineArray_288_27j5lac);
		void* ptr = null;
		int num4 = 0;
		void* ptr2 = null;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		llvm_memset_p0_i64.Invoke(&inlineArray_33_vqkfj7a, 0, 132L, isVolatile: false);
		if (static_table != 0)
		{
			for (num = 0; num < table_len; num++)
			{
				(*unchecked((int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray_33_vqkfj7a, (nint)((byte*)(&((fpng_defl_huff*)d)->field_2) + (nint)table_num * (nint)sizeof(InlineArray_288_w3otm9c))[num] * (nint)4))))++;
			}
		}
		else
		{
			num4 = 0;
			unchecked
			{
				ptr2 = (byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)table_num * (nint)sizeof(InlineArray_288_oeds4ea);
				for (num = 0; num < table_len; num = checked(num + 1))
				{
					if (((short*)ptr2)[num] != 0)
					{
						short field_ = ((short*)ptr2)[num];
						Unsafe.As<InlineArray_288_27j5lac, fpng_defl_sym_freq>(ref Unsafe.AddByteOffset(ref inlineArray_288_27j5lac, (nint)num4 * (nint)sizeof(fpng_defl_sym_freq))).field_0 = field_;
						Unsafe.As<InlineArray_288_27j5lac, fpng_defl_sym_freq>(ref Unsafe.AddByteOffset(ref inlineArray_288_27j5lac, (nint)checked(num4++) * (nint)sizeof(fpng_defl_sym_freq))).field_1 = (short)num;
					}
				}
				ptr = defl_radix_sort_syms.Invoke(num4, &inlineArray_288_27j5lac, &inlineArray_288_27j5lac2);
				defl_calculate_minimum_redundancy.Invoke(ptr, num4);
			}
			for (num = 0; num < num4; num++)
			{
				(*unchecked((int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray_33_vqkfj7a, (nint)(ushort)((fpng_defl_sym_freq*)ptr)[num].field_0 * (nint)4))))++;
			}
			defl_huffman_enforce_max_code_size.Invoke(&inlineArray_33_vqkfj7a, num4, code_size_limit);
			unchecked
			{
				llvm_memset_p0_i64.Invoke((byte*)(&((fpng_defl_huff*)d)->field_2) + (nint)table_num * (nint)sizeof(InlineArray_288_w3otm9c), 0, 288L, isVolatile: false);
				llvm_memset_p0_i64.Invoke((byte*)(&((fpng_defl_huff*)d)->field_1) + (nint)table_num * (nint)sizeof(InlineArray_288_oeds4ea), 0, 576L, isVolatile: false);
				num = 1;
				num2 = num4;
				for (; num <= code_size_limit; num = checked(num + 1))
				{
					for (num3 = Unsafe.As<InlineArray_33_vqkfj7a, int>(ref Unsafe.AddByteOffset(ref inlineArray_33_vqkfj7a, (nint)num * (nint)4)); num3 > 0; num3 = checked(num3 + -1))
					{
						sbyte b = (sbyte)num;
						byte* num8 = (byte*)(&((fpng_defl_huff*)d)->field_2) + (nint)table_num * (nint)sizeof(InlineArray_288_w3otm9c);
						void* num9 = ptr;
						int num10 = checked(num2 + -1);
						num2 = num10;
						num8[(ushort)((fpng_defl_sym_freq*)num9)[num10].field_1] = (byte)b;
					}
				}
			}
		}
		Unsafe.As<InlineArray_33_vqkfj7a, int>(ref Unsafe.AddByteOffset(ref inlineArray_33_vqkfj7a2, 4)) = 0;
		num2 = 0;
		for (num = 2; num <= code_size_limit; num++)
		{
			num2 = (Unsafe.As<InlineArray_33_vqkfj7a, int>(ref Unsafe.AddByteOffset(ref inlineArray_33_vqkfj7a2, unchecked((nint)num * (nint)4))) = num2 + Unsafe.As<InlineArray_33_vqkfj7a, int>(ref Unsafe.AddByteOffset(ref inlineArray_33_vqkfj7a, unchecked((nint)checked(num - 1) * (nint)4))) << 1);
		}
		for (num = 0; num < table_len; num++)
		{
			num5 = 0;
			unchecked
			{
				int num11 = ((byte*)(&((fpng_defl_huff*)d)->field_2) + (nint)table_num * (nint)sizeof(InlineArray_288_w3otm9c))[num];
				num7 = num11;
				if (num11 != 0)
				{
					num6 = (*(int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray_33_vqkfj7a2, (nint)(uint)num7 * (nint)4)))++;
					num3 = num7;
					while (num3 > 0)
					{
						num5 = (num5 << 1) | (num6 & 1);
						num3 = checked(num3 + -1);
						num6 >>>= 1;
					}
					((short*)((byte*)(&((fpng_defl_huff*)d)->field_1) + (nint)table_num * (nint)sizeof(InlineArray_288_oeds4ea)))[num] = (short)num5;
				}
			}
		}
	}
}
