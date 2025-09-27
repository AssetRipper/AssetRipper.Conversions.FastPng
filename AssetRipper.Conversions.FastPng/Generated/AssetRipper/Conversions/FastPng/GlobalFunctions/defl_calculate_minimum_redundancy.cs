using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?defl_calculate_minimum_redundancy@fpng@@YAXPEAUdefl_sym_freq@1@H@Z")]
[DemangledName("void __cdecl fpng::defl_calculate_minimum_redundancy(struct fpng::defl_sym_freq *, int)")]
internal static partial class defl_calculate_minimum_redundancy
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("struct fpng::defl_sym_freq *")] void* A, [NativeType("int")] int n)
	{
		int num3;
		int num2;
		unchecked
		{
			switch (n)
			{
			case 0:
				return;
			case 1:
				((fpng_defl_sym_freq*)A)->m_key = 1;
				return;
			}
			int num = (ushort)((fpng_defl_sym_freq*)A)[1].m_key;
			short* key = &((fpng_defl_sym_freq*)A)->m_key;
			*key = (short)checked(unchecked((ushort)(*key)) + num);
			num2 = 0;
			num3 = 2;
		}
		int i;
		for (i = 1; i < n - 1; i++)
		{
			unchecked
			{
				if (num3 >= n || (ushort)((fpng_defl_sym_freq*)A)[num2].m_key < (ushort)((fpng_defl_sym_freq*)A)[num3].m_key)
				{
					((fpng_defl_sym_freq*)A)[i].m_key = ((fpng_defl_sym_freq*)A)[num2].m_key;
					((fpng_defl_sym_freq*)A)[checked(num2++)].m_key = (short)i;
				}
				else
				{
					((fpng_defl_sym_freq*)A)[i].m_key = ((fpng_defl_sym_freq*)A)[checked(num3++)].m_key;
				}
				if (num3 >= n || (num2 < i && (ushort)((fpng_defl_sym_freq*)A)[num2].m_key < (ushort)((fpng_defl_sym_freq*)A)[num3].m_key))
				{
					((fpng_defl_sym_freq*)A)[i].m_key = (short)checked(unchecked((ushort)((fpng_defl_sym_freq*)A)[i].m_key) + unchecked((ushort)((fpng_defl_sym_freq*)A)[num2].m_key));
					((fpng_defl_sym_freq*)A)[checked(num2++)].m_key = (short)i;
				}
				else
				{
					((fpng_defl_sym_freq*)A)[i].m_key = (short)checked(unchecked((ushort)((fpng_defl_sym_freq*)A)[i].m_key) + unchecked((ushort)((fpng_defl_sym_freq*)A)[checked(num3++)].m_key));
				}
			}
		}
		unchecked((fpng_defl_sym_freq*)A)[n - 2].m_key = 0;
		for (i = n - 3; i >= 0; i += -1)
		{
			unchecked
			{
				((fpng_defl_sym_freq*)A)[i].m_key = (short)checked(unchecked((ushort)((fpng_defl_sym_freq*)A)[(ushort)((fpng_defl_sym_freq*)A)[i].m_key].m_key) + 1);
			}
		}
		int j = 1;
		int num4 = 0;
		int num5 = 0;
		num2 = n - 2;
		i = n - 1;
		while (j > 0)
		{
			for (; num2 >= 0 && unchecked((ushort)((fpng_defl_sym_freq*)A)[num2].m_key) == num4; num2 += -1)
			{
				num5++;
			}
			for (; j > num5; j += -1)
			{
				short key2 = unchecked((short)num4);
				int num6 = i;
				i = num6 + -1;
				unchecked((fpng_defl_sym_freq*)A)[num6].m_key = key2;
			}
			j = 2 * num5;
			num4++;
			num5 = 0;
		}
	}
}
