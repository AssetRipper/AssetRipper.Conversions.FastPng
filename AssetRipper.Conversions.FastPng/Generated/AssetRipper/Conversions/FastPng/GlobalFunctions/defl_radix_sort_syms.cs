using System.Runtime.CompilerServices;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?defl_radix_sort_syms@fpng@@YAPEAUdefl_sym_freq@1@IPEAU21@0@Z")]
[DemangledName("struct fpng::defl_sym_freq * __cdecl fpng::defl_radix_sort_syms(unsigned int, struct fpng::defl_sym_freq *, struct fpng::defl_sym_freq *)")]
internal static partial class defl_radix_sort_syms
{
	[return: NativeType("struct fpng::defl_sym_freq *")]
	public unsafe static void* Invoke([NativeType("unsigned int")] int num_syms, [NativeType("struct fpng::defl_sym_freq *")] void* pSyms0, [NativeType("struct fpng::defl_sym_freq *")] void* pSyms1)
	{
		InlineArray512_Int32 inlineArray512_Int = default(InlineArray512_Int32);
		InlineArray256_Int32 inlineArray256_Int = default(InlineArray256_Int32);
		int i = 2;
		void* ptr = pSyms0;
		void* ptr2 = pSyms1;
		llvm_memset_p0_i64.Invoke(&inlineArray512_Int, 0, 2048L, isVolatile: false);
		unchecked
		{
			for (int j = 0; (uint)j < (uint)num_syms; j++)
			{
				int num = (ushort)((fpng_defl_sym_freq*)pSyms0)[(uint)j].m_key;
				(*(int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray512_Int, (nint)(uint)(num & 0xFF) * (nint)4)))++;
				(*(int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray512_Int, (nint)(uint)(256 + ((num >>> 8) & 0xFF)) * (nint)4)))++;
			}
			for (; (uint)i > 1u && num_syms == Unsafe.As<InlineArray512_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray512_Int, (nint)(uint)((i - 1) * 256) * (nint)4)); i += -1)
			{
			}
			int num2 = 0;
			int num3 = 0;
			while ((uint)num3 < (uint)i)
			{
				void* ptr3 = Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray512_Int, (nint)(uint)(num3 << 8) * (nint)4));
				int num4 = 0;
				for (int j = 0; (uint)j < 256u; j++)
				{
					Unsafe.As<InlineArray256_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray256_Int, (nint)(uint)j * (nint)4)) = num4;
					num4 += ((int*)ptr3)[(uint)j];
				}
				for (int j = 0; (uint)j < (uint)num_syms; j++)
				{
					llvm_memcpy_p0_p0_i64.Invoke((byte*)ptr2 + (nint)(uint)(*(int*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray256_Int, (nint)(((ushort)((fpng_defl_sym_freq*)ptr)[(uint)j].m_key >> num2) & 0xFF) * (nint)4)))++ * (nint)sizeof(fpng_defl_sym_freq), (byte*)ptr + (nint)(uint)j * (nint)sizeof(fpng_defl_sym_freq), 4L, isVolatile: false);
				}
				void* ptr4 = ptr;
				ptr = ptr2;
				ptr2 = ptr4;
				num3++;
				num2 += 8;
			}
			return ptr;
		}
	}
}
