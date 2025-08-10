using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?defl_calculate_minimum_redundancy@fpng@@YAXPEAUdefl_sym_freq@1@H@Z")]
[DemangledName("void __cdecl fpng::defl_calculate_minimum_redundancy(struct fpng::defl_sym_freq *, int)")]
internal static partial class defl_calculate_minimum_redundancy
{
	public unsafe static void Invoke(void* A, int n)
	{
		if (n == 0)
		{
			return;
		}
		int num3;
		int num2;
		unchecked
		{
			if (n == 1)
			{
				((fpng_defl_sym_freq*)A)->field_0 = 1;
				return;
			}
			int num = (ushort)((fpng_defl_sym_freq*)A)[1L].field_0;
			short* field_ = &((fpng_defl_sym_freq*)A)->field_0;
			*field_ = (short)checked(unchecked((ushort)(*field_)) + num);
			num2 = 0;
			num3 = 2;
		}
		int i;
		for (i = 1; i < n - 1; i++)
		{
			unchecked
			{
				if (num3 >= n || (ushort)((fpng_defl_sym_freq*)A)[num2].field_0 < (ushort)((fpng_defl_sym_freq*)A)[num3].field_0)
				{
					short field_2 = ((fpng_defl_sym_freq*)A)[num2].field_0;
					((fpng_defl_sym_freq*)A)[i].field_0 = field_2;
					((fpng_defl_sym_freq*)A)[checked(num2++)].field_0 = (short)i;
				}
				else
				{
					short field_3 = ((fpng_defl_sym_freq*)A)[checked(num3++)].field_0;
					((fpng_defl_sym_freq*)A)[i].field_0 = field_3;
				}
				if (num3 >= n || (num2 < i && (ushort)((fpng_defl_sym_freq*)A)[num2].field_0 < (ushort)((fpng_defl_sym_freq*)A)[num3].field_0))
				{
					int num4;
					checked
					{
						num4 = unchecked((ushort)((fpng_defl_sym_freq*)A)[i].field_0) + unchecked((ushort)((fpng_defl_sym_freq*)A)[num2].field_0);
					}
					((fpng_defl_sym_freq*)A)[i].field_0 = (short)num4;
					((fpng_defl_sym_freq*)A)[checked(num2++)].field_0 = (short)i;
				}
				else
				{
					int num5;
					checked
					{
						num5 = unchecked((ushort)((fpng_defl_sym_freq*)A)[i].field_0) + unchecked((ushort)((fpng_defl_sym_freq*)A)[checked(num3++)].field_0);
					}
					((fpng_defl_sym_freq*)A)[i].field_0 = (short)num5;
				}
			}
		}
		unchecked((fpng_defl_sym_freq*)A)[n - 2].field_0 = 0;
		for (i = n - 3; i >= 0; i += -1)
		{
			int num6 = unchecked((ushort)((fpng_defl_sym_freq*)A)[(ushort)((fpng_defl_sym_freq*)A)[i].field_0].field_0) + 1;
			unchecked
			{
				((fpng_defl_sym_freq*)A)[i].field_0 = (short)num6;
			}
		}
		int j = 1;
		int num7 = 0;
		int num8 = 0;
		num2 = n - 2;
		i = n - 1;
		while (j > 0)
		{
			for (; num2 >= 0 && unchecked((ushort)((fpng_defl_sym_freq*)A)[num2].field_0) == num7; num2 += -1)
			{
				num8++;
			}
			for (; j > num8; j += -1)
			{
				short field_4 = unchecked((short)num7);
				void* ptr = A;
				int num9 = i;
				i = num9 + -1;
				unchecked((fpng_defl_sym_freq*)ptr)[num9].field_0 = field_4;
			}
			j = 2 * num8;
			num7++;
			num8 = 0;
		}
	}
}
