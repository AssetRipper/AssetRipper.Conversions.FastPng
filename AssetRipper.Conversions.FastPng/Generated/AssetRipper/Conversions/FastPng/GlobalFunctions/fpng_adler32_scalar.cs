using AssetRipper.Conversions.FastPng.Helpers;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?fpng_adler32_scalar@fpng@@YAIPEBE_KI@Z")]
[DemangledName("unsigned int __cdecl fpng::fpng_adler32_scalar(unsigned char const *, unsigned __int64, unsigned int)")]
internal static partial class fpng_adler32_scalar
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("unsigned char const *")] void* ptr, [NativeType("unsigned __int64")] long buf_len, [NativeType("unsigned int")] int adler)
	{
		long num = buf_len;
		void* ptr2 = ptr;
		int num2 = adler & 0xFFFF;
		int num3 = adler >>> 16;
		unchecked
		{
			int num4 = (int)((ulong)num % 5552uL);
			if (ptr2 == null)
			{
				return 1;
			}
			while (num != 0L)
			{
				int i = 0;
				while ((uint)(i + 7) < (uint)num4)
				{
					num2 += (byte)(*(sbyte*)ptr2);
					num3 += num2;
					num2 += (byte)((sbyte*)ptr2)[1];
					num3 += num2;
					num2 += (byte)((sbyte*)ptr2)[2];
					num3 += num2;
					num2 += (byte)((sbyte*)ptr2)[3];
					num3 += num2;
					num2 += (byte)((sbyte*)ptr2)[4];
					num3 += num2;
					num2 += (byte)((sbyte*)ptr2)[5];
					num3 += num2;
					num2 += (byte)((sbyte*)ptr2)[6];
					num3 += num2;
					num2 += (byte)((sbyte*)ptr2)[7];
					num3 += num2;
					i += 8;
					ptr2 = (byte*)ptr2 + 8;
				}
				for (; (uint)i < (uint)num4; i++)
				{
					void* ptr3 = ptr2;
					ptr2 = (byte*)ptr3 + 1;
					num2 += (byte)(*(sbyte*)ptr3);
					num3 += num2;
				}
				num2 = (int)((uint)num2 % 65521u);
				num3 = (int)((uint)num3 % 65521u);
				num -= (uint)num4;
				num4 = 5552;
			}
			return (num3 << 16) + num2;
		}
	}
}
