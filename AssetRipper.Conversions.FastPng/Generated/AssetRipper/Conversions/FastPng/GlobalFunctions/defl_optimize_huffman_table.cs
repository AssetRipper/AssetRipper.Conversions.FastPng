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
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		InlineArray33_Int32 inlineArray33_Int = default(InlineArray33_Int32);
		InlineArray33_Int32 inlineArray33_Int2 = default(InlineArray33_Int32);
		InlineArray288_fpng_defl_sym_freq inlineArray288_fpng_defl_sym_freq = default(InlineArray288_fpng_defl_sym_freq);
		InlineArray288_fpng_defl_sym_freq inlineArray288_fpng_defl_sym_freq2 = default(InlineArray288_fpng_defl_sym_freq);
		void* ptr = null;
		int num4 = 0;
		void* ptr2 = null;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		llvm_memset_p0_i64.Invoke(&inlineArray33_Int, 0, 132L, isVolatile: false);
		if (static_table != 0)
		{
			for (num = 0; num < table_len; num++)
			{
				(*unchecked((int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray33_Int, (nint)((byte*)(&((fpng_defl_huff*)d)->field_2) + (nint)table_num * (nint)sizeof(InlineArray288_SByte))[num] * (nint)4))))++;
			}
		}
		else
		{
			num4 = 0;
			unchecked
			{
				ptr2 = (byte*)(&((fpng_defl_huff*)d)->field_0) + (nint)table_num * (nint)sizeof(InlineArray288_Int16);
				for (num = 0; num < table_len; num = checked(num + 1))
				{
					if (((short*)ptr2)[num] != 0)
					{
						short field_ = ((short*)ptr2)[num];
						Unsafe.As<InlineArray288_fpng_defl_sym_freq, fpng_defl_sym_freq>(ref Unsafe.AddByteOffset(ref inlineArray288_fpng_defl_sym_freq, (nint)num4 * (nint)sizeof(fpng_defl_sym_freq))).field_0 = field_;
						Unsafe.As<InlineArray288_fpng_defl_sym_freq, fpng_defl_sym_freq>(ref Unsafe.AddByteOffset(ref inlineArray288_fpng_defl_sym_freq, (nint)checked(num4++) * (nint)sizeof(fpng_defl_sym_freq))).field_1 = (short)num;
					}
				}
				ptr = defl_radix_sort_syms.Invoke(num4, &inlineArray288_fpng_defl_sym_freq, &inlineArray288_fpng_defl_sym_freq2);
				defl_calculate_minimum_redundancy.Invoke(ptr, num4);
			}
			for (num = 0; num < num4; num++)
			{
				(*unchecked((int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray33_Int, (nint)(ushort)((fpng_defl_sym_freq*)ptr)[num].field_0 * (nint)4))))++;
			}
			defl_huffman_enforce_max_code_size.Invoke(&inlineArray33_Int, num4, code_size_limit);
			unchecked
			{
				llvm_memset_p0_i64.Invoke((byte*)(&((fpng_defl_huff*)d)->field_2) + (nint)table_num * (nint)sizeof(InlineArray288_SByte), 0, 288L, isVolatile: false);
				llvm_memset_p0_i64.Invoke((byte*)(&((fpng_defl_huff*)d)->field_1) + (nint)table_num * (nint)sizeof(InlineArray288_Int16), 0, 576L, isVolatile: false);
				num = 1;
				num2 = num4;
				for (; num <= code_size_limit; num = checked(num + 1))
				{
					for (num3 = Unsafe.As<InlineArray33_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray33_Int, (nint)num * (nint)4)); num3 > 0; num3 = checked(num3 + -1))
					{
						sbyte b = (sbyte)num;
						byte* num8 = (byte*)(&((fpng_defl_huff*)d)->field_2) + (nint)table_num * (nint)sizeof(InlineArray288_SByte);
						void* num9 = ptr;
						int num10 = checked(num2 + -1);
						num2 = num10;
						num8[(ushort)((fpng_defl_sym_freq*)num9)[num10].field_1] = (byte)b;
					}
				}
			}
		}
		Unsafe.As<InlineArray33_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray33_Int2, 4)) = 0;
		num2 = 0;
		for (num = 2; num <= code_size_limit; num++)
		{
			num2 = (Unsafe.As<InlineArray33_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray33_Int2, unchecked((nint)num * (nint)4))) = num2 + Unsafe.As<InlineArray33_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray33_Int, unchecked((nint)checked(num - 1) * (nint)4))) << 1);
		}
		for (num = 0; num < table_len; num++)
		{
			num5 = 0;
			unchecked
			{
				int num11 = ((byte*)(&((fpng_defl_huff*)d)->field_2) + (nint)table_num * (nint)sizeof(InlineArray288_SByte))[num];
				num7 = num11;
				if (num11 != 0)
				{
					num6 = (*(int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray33_Int2, (nint)(uint)num7 * (nint)4)))++;
					num3 = num7;
					while (num3 > 0)
					{
						num5 = (num5 << 1) | (num6 & 1);
						num3 = checked(num3 + -1);
						num6 >>>= 1;
					}
					((short*)((byte*)(&((fpng_defl_huff*)d)->field_1) + (nint)table_num * (nint)sizeof(InlineArray288_Int16)))[num] = (short)num5;
				}
			}
		}
	}
}
