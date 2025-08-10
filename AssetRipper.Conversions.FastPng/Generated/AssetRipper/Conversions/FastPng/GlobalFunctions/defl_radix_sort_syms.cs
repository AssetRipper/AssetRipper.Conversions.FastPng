using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?defl_radix_sort_syms@fpng@@YAPEAUdefl_sym_freq@1@IPEAU21@0@Z")]
[DemangledName("struct fpng::defl_sym_freq * __cdecl fpng::defl_radix_sort_syms(unsigned int, struct fpng::defl_sym_freq *, struct fpng::defl_sym_freq *)")]
internal static partial class defl_radix_sort_syms
{
	public unsafe static void* Invoke(int num_syms, void* pSyms0, void* pSyms1)
	{
		InlineArray_512_vqkfj7a inlineArray_512_vqkfj7a = default(InlineArray_512_vqkfj7a);
		InlineArray_512_vqkfj7a* ptr = &inlineArray_512_vqkfj7a;
		InlineArray_256_vqkfj7a inlineArray_256_vqkfj7a = default(InlineArray_256_vqkfj7a);
		InlineArray_256_vqkfj7a* ptr2 = &inlineArray_256_vqkfj7a;
		int i = 2;
		void* ptr3 = pSyms0;
		void* ptr4 = pSyms1;
		llvm_memset_p0_i64.Invoke(ptr, 0, 2048L, isVolatile: false);
		unchecked
		{
			for (int j = 0; (uint)j < (uint)num_syms; j++)
			{
				int num = (ushort)((fpng_defl_sym_freq*)pSyms0)[(uint)j].field_0;
				(*(int*)((byte*)ptr + sizeof(int) * (int)(uint)(num & 0xFF)))++;
				(*(int*)((byte*)ptr + sizeof(int) * (int)(uint)(256 + ((num >>> 8) & 0xFF))))++;
			}
			for (; (uint)i > 1u && num_syms == *(int*)((byte*)ptr + sizeof(int) * (int)(uint)((i - 1) * 256)); i += -1)
			{
			}
			int num2 = 0;
			int num3 = 0;
			while ((uint)num3 < (uint)i)
			{
				void* ptr5 = (byte*)ptr + sizeof(int) * (int)(uint)(num3 << 8);
				int num4 = 0;
				for (int j = 0; (uint)j < 256u; j++)
				{
					*(int*)((byte*)ptr2 + sizeof(int) * (int)(uint)j) = num4;
					num4 += ((int*)ptr5)[(uint)j];
				}
				for (int j = 0; (uint)j < (uint)num_syms; j++)
				{
					llvm_memcpy_p0_p0_i64.Invoke((byte*)ptr4 + (nint)(uint)(*(int*)((byte*)ptr2 + sizeof(int) * (((ushort)((fpng_defl_sym_freq*)ptr3)[(uint)j].field_0 >> num2) & 0xFF)))++ * (nint)sizeof(fpng_defl_sym_freq), (byte*)ptr3 + (nint)(uint)j * (nint)sizeof(fpng_defl_sym_freq), 4L, isVolatile: false);
				}
				void* ptr6 = ptr3;
				ptr3 = ptr4;
				ptr4 = ptr6;
				num3++;
				num2 += 8;
			}
			return ptr3;
		}
	}
}
