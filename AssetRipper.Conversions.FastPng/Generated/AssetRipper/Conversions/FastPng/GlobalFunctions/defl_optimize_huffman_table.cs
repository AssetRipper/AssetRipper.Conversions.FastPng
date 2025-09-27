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
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("struct fpng::defl_huff *")] void* d, [NativeType("int")] int table_num, [NativeType("int")] int table_len, [NativeType("int")] int code_size_limit, [NativeType("int")] int static_table)
	{
		InlineArray33_Int32 inlineArray33_Int = default(InlineArray33_Int32);
		InlineArray33_Int32 inlineArray33_Int2 = default(InlineArray33_Int32);
		InlineArray288_fpng_defl_sym_freq inlineArray288_fpng_defl_sym_freq = default(InlineArray288_fpng_defl_sym_freq);
		InlineArray288_fpng_defl_sym_freq inlineArray288_fpng_defl_sym_freq2 = default(InlineArray288_fpng_defl_sym_freq);
		llvm_memset_p0_i64.Invoke(&inlineArray33_Int, 0, 132L, isVolatile: false);
		int num2;
		if (static_table != 0)
		{
			for (int i = 0; i < table_len; i++)
			{
				(*unchecked((int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray33_Int, (nint)((byte*)(&((fpng_defl_huff*)d)->m_huff_code_sizes) + (nint)table_num * (nint)sizeof(InlineArray288_SByte))[i] * (nint)4))))++;
			}
		}
		else
		{
			int num = 0;
			void* ptr2;
			unchecked
			{
				void* ptr = (byte*)(&((fpng_defl_huff*)d)->m_huff_count) + (nint)table_num * (nint)sizeof(InlineArray288_Int16);
				for (int i = 0; i < table_len; i = checked(i + 1))
				{
					if (((short*)ptr)[i] != 0)
					{
						short key = ((short*)ptr)[i];
						Unsafe.As<InlineArray288_fpng_defl_sym_freq, fpng_defl_sym_freq>(ref Unsafe.AddByteOffset(ref inlineArray288_fpng_defl_sym_freq, (nint)num * (nint)sizeof(fpng_defl_sym_freq))).m_key = key;
						Unsafe.As<InlineArray288_fpng_defl_sym_freq, fpng_defl_sym_freq>(ref Unsafe.AddByteOffset(ref inlineArray288_fpng_defl_sym_freq, (nint)checked(num++) * (nint)sizeof(fpng_defl_sym_freq))).m_sym_index = (short)i;
					}
				}
				ptr2 = defl_radix_sort_syms.Invoke(num, &inlineArray288_fpng_defl_sym_freq, &inlineArray288_fpng_defl_sym_freq2);
				defl_calculate_minimum_redundancy.Invoke(ptr2, num);
			}
			for (int i = 0; i < num; i++)
			{
				(*unchecked((int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray33_Int, (nint)(ushort)((fpng_defl_sym_freq*)ptr2)[i].m_key * (nint)4))))++;
			}
			defl_huffman_enforce_max_code_size.Invoke(&inlineArray33_Int, num, code_size_limit);
			unchecked
			{
				llvm_memset_p0_i64.Invoke((byte*)(&((fpng_defl_huff*)d)->m_huff_code_sizes) + (nint)table_num * (nint)sizeof(InlineArray288_SByte), 0, 288L, isVolatile: false);
				llvm_memset_p0_i64.Invoke((byte*)(&((fpng_defl_huff*)d)->m_huff_codes) + (nint)table_num * (nint)sizeof(InlineArray288_Int16), 0, 576L, isVolatile: false);
				int i = 1;
				num2 = num;
				for (; i <= code_size_limit; i = checked(i + 1))
				{
					for (int j = Unsafe.As<InlineArray33_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray33_Int, (nint)i * (nint)4)); j > 0; j = checked(j + -1))
					{
						sbyte b = (sbyte)i;
						byte* num3 = (byte*)(&((fpng_defl_huff*)d)->m_huff_code_sizes) + (nint)table_num * (nint)sizeof(InlineArray288_SByte);
						int num4 = checked(num2 + -1);
						num2 = num4;
						num3[(ushort)((fpng_defl_sym_freq*)ptr2)[num4].m_sym_index] = (byte)b;
					}
				}
			}
		}
		Unsafe.As<InlineArray33_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray33_Int2, 4)) = 0;
		num2 = 0;
		for (int i = 2; i <= code_size_limit; i++)
		{
			num2 = (Unsafe.As<InlineArray33_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray33_Int2, unchecked((nint)i * (nint)4))) = num2 + Unsafe.As<InlineArray33_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray33_Int, unchecked((nint)checked(i - 1) * (nint)4))) << 1);
		}
		for (int i = 0; i < table_len; i++)
		{
			int num5 = 0;
			unchecked
			{
				int num6 = ((byte*)(&((fpng_defl_huff*)d)->m_huff_code_sizes) + (nint)table_num * (nint)sizeof(InlineArray288_SByte))[i];
				int num7 = num6;
				if (num6 != 0)
				{
					int num8 = (*(int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray33_Int2, (nint)(uint)num7 * (nint)4)))++;
					int j = num7;
					while (j > 0)
					{
						num5 = (num5 << 1) | (num8 & 1);
						j = checked(j + -1);
						num8 >>>= 1;
					}
					((short*)((byte*)(&((fpng_defl_huff*)d)->m_huff_codes) + (nint)table_num * (nint)sizeof(InlineArray288_Int16)))[i] = (short)num5;
				}
			}
		}
	}
}
