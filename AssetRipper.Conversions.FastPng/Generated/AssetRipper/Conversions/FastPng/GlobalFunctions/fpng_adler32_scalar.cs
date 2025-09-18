using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?fpng_adler32_scalar@fpng@@YAIPEBE_KI@Z")]
[DemangledName("unsigned int __cdecl fpng::fpng_adler32_scalar(unsigned char const *, unsigned __int64, unsigned int)")]
internal static partial class fpng_adler32_scalar
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("unsigned char const *")] void* ptr, [NativeType("unsigned __int64")] long buf_len, [NativeType("unsigned int")] int adler)
	{
		int num = 0;
		int num2 = 0;
		long num3 = buf_len;
		void* ptr2 = ptr;
		int num4 = adler & 0xFFFF;
		int num5 = adler >>> 16;
		unchecked
		{
			int num6 = (int)((ulong)num3 % 5552uL);
			if (ptr2 == null)
			{
				return 1;
			}
			while (num3 != 0L)
			{
				num2 = 0;
				while ((uint)(num2 + 7) < (uint)num6)
				{
					num4 += (byte)(*(sbyte*)ptr2);
					num5 += num4;
					num4 += (byte)((sbyte*)ptr2)[1];
					num5 += num4;
					num4 += (byte)((sbyte*)ptr2)[2];
					num5 += num4;
					num4 += (byte)((sbyte*)ptr2)[3];
					num5 += num4;
					num4 += (byte)((sbyte*)ptr2)[4];
					num5 += num4;
					num4 += (byte)((sbyte*)ptr2)[5];
					num5 += num4;
					num4 += (byte)((sbyte*)ptr2)[6];
					num5 += num4;
					num4 += (byte)((sbyte*)ptr2)[7];
					num5 += num4;
					num2 += 8;
					ptr2 = (byte*)ptr2 + 8;
				}
				for (; (uint)num2 < (uint)num6; num2++)
				{
					void* ptr3 = ptr2;
					ptr2 = (byte*)ptr3 + 1;
					num4 += (byte)(*(sbyte*)ptr3);
					num5 += num4;
				}
				num4 = (int)((uint)num4 % 65521u);
				num5 = (int)((uint)num5 % 65521u);
				num3 -= (uint)num6;
				num6 = 5552;
			}
			return (num5 << 16) + num4;
		}
	}
}
