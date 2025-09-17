using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?defl_calculate_minimum_redundancy@fpng@@YAXPEAUdefl_sym_freq@1@H@Z")]
[DemangledName("void __cdecl fpng::defl_calculate_minimum_redundancy(struct fpng::defl_sym_freq *, int)")]
internal static partial class defl_calculate_minimum_redundancy
{
	public unsafe static void Invoke(void* A, int n)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		unchecked
		{
			switch (n)
			{
			case 0:
				return;
			case 1:
				((fpng_defl_sym_freq*)A)->field_0 = 1;
				return;
			}
			int num7 = (ushort)((fpng_defl_sym_freq*)A)[1].field_0;
			short* field_ = &((fpng_defl_sym_freq*)A)->field_0;
			*field_ = (short)checked(unchecked((ushort)(*field_)) + num7);
			num = 0;
			num2 = 2;
		}
		for (num3 = 1; num3 < n - 1; num3++)
		{
			unchecked
			{
				if (num2 >= n || (ushort)((fpng_defl_sym_freq*)A)[num].field_0 < (ushort)((fpng_defl_sym_freq*)A)[num2].field_0)
				{
					((fpng_defl_sym_freq*)A)[num3].field_0 = ((fpng_defl_sym_freq*)A)[num].field_0;
					((fpng_defl_sym_freq*)A)[checked(num++)].field_0 = (short)num3;
				}
				else
				{
					((fpng_defl_sym_freq*)A)[num3].field_0 = ((fpng_defl_sym_freq*)A)[checked(num2++)].field_0;
				}
				if (num2 >= n || (num < num3 && (ushort)((fpng_defl_sym_freq*)A)[num].field_0 < (ushort)((fpng_defl_sym_freq*)A)[num2].field_0))
				{
					((fpng_defl_sym_freq*)A)[num3].field_0 = (short)checked(unchecked((ushort)((fpng_defl_sym_freq*)A)[num3].field_0) + unchecked((ushort)((fpng_defl_sym_freq*)A)[num].field_0));
					((fpng_defl_sym_freq*)A)[checked(num++)].field_0 = (short)num3;
				}
				else
				{
					((fpng_defl_sym_freq*)A)[num3].field_0 = (short)checked(unchecked((ushort)((fpng_defl_sym_freq*)A)[num3].field_0) + unchecked((ushort)((fpng_defl_sym_freq*)A)[checked(num2++)].field_0));
				}
			}
		}
		unchecked((fpng_defl_sym_freq*)A)[n - 2].field_0 = 0;
		for (num3 = n - 3; num3 >= 0; num3 += -1)
		{
			unchecked
			{
				((fpng_defl_sym_freq*)A)[num3].field_0 = (short)checked(unchecked((ushort)((fpng_defl_sym_freq*)A)[(ushort)((fpng_defl_sym_freq*)A)[num3].field_0].field_0) + 1);
			}
		}
		num4 = 1;
		num6 = 0;
		num5 = 0;
		num = n - 2;
		num3 = n - 1;
		while (num4 > 0)
		{
			for (; num >= 0 && unchecked((ushort)((fpng_defl_sym_freq*)A)[num].field_0) == num6; num += -1)
			{
				num5++;
			}
			for (; num4 > num5; num4 += -1)
			{
				short field_2 = unchecked((short)num6);
				int num8 = num3;
				num3 = num8 + -1;
				unchecked((fpng_defl_sym_freq*)A)[num8].field_0 = field_2;
			}
			num4 = 2 * num5;
			num6++;
			num5 = 0;
		}
	}
}
