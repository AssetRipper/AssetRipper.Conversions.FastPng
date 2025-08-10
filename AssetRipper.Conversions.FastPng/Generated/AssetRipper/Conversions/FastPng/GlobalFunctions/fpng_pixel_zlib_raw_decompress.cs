using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?fpng_pixel_zlib_raw_decompress@fpng@@YA_NPEBEIIPEAEIIII@Z")]
[DemangledName("bool __cdecl fpng::fpng_pixel_zlib_raw_decompress(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int, unsigned int, unsigned int, unsigned int)")]
internal static partial class fpng_pixel_zlib_raw_decompress
{
	private partial struct LocalVariables
	{
		public bool Instruction_0;

		public int Instruction_1;

		public int Instruction_2;

		public int Instruction_3;

		public int Instruction_4;

		public unsafe void* Instruction_5;

		public int Instruction_6;

		public int Instruction_7;

		public unsafe void* Instruction_8;

		public int Instruction_9;

		public int Instruction_10;

		public int Instruction_11;

		public int Instruction_12;

		public int Instruction_13;

		public int Instruction_14;

		public int Instruction_15;

		public sbyte Instruction_16;

		public int Instruction_17;

		public int Instruction_18;

		public int Instruction_19;

		public int Instruction_20;

		public int Instruction_21;
	}

	public unsafe static bool Invoke(void* pSrc, int src_len, int zlib_len, void* pDst, int w, int h, int src_chans, int dst_chans)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = dst_chans;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = src_chans;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = h;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_4 = w;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_5 = pDst;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_6 = zlib_len;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = src_len;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = pSrc;
		if (startFrame.GetLocalsRef<LocalVariables>().Instruction_2 == 3)
		{
			_ = -1;
		}
		else if (startFrame.GetLocalsRef<LocalVariables>().Instruction_2 == 4)
		{
			_ = -1;
		}
		else
		{
			wassert.Invoke(String_zixkhbc.__pointer, String_uxbkrtb.__pointer, 2112);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			_ = 0;
		}
		if (startFrame.GetLocalsRef<LocalVariables>().Instruction_1 == 3)
		{
			_ = -1;
		}
		else if (startFrame.GetLocalsRef<LocalVariables>().Instruction_1 == 4)
		{
			_ = -1;
		}
		else
		{
			wassert.Invoke(String_kppxlqc.__pointer, String_uxbkrtb.__pointer, 2113);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			_ = 0;
		}
		int instruction_ = startFrame.GetLocalsRef<LocalVariables>().Instruction_4;
		int instruction_2 = startFrame.GetLocalsRef<LocalVariables>().Instruction_2;
		unchecked
		{
			startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_ * instruction_2;
			int instruction_3 = startFrame.GetLocalsRef<LocalVariables>().Instruction_4;
			int instruction_4 = startFrame.GetLocalsRef<LocalVariables>().Instruction_1;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_3 * instruction_4;
			int instruction_5 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
			int instruction_6 = startFrame.GetLocalsRef<LocalVariables>().Instruction_3;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_11 = instruction_5 * instruction_6;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = 2;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_13 = 0;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_14 = 0;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_15 = 0;
			while (true)
			{
				if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_12 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_7)
				{
					startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
					break;
				}
				sbyte b = ((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_8)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_12];
				startFrame.GetLocalsRef<LocalVariables>().Instruction_16 = ((((byte)b & 1) != 0) ? ((sbyte)1) : ((sbyte)0));
				sbyte b2 = ((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_8)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_12];
				startFrame.GetLocalsRef<LocalVariables>().Instruction_17 = ((byte)b2 >> 1) & 3;
				if (startFrame.GetLocalsRef<LocalVariables>().Instruction_17 != 0)
				{
					startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
					break;
				}
				int instruction_7 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_7 + 1;
				if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_12 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_7)
				{
					startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
					break;
				}
				int num = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_8)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_12 + 0)];
				sbyte b3 = ((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_8)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_12 + 1)];
				startFrame.GetLocalsRef<LocalVariables>().Instruction_18 = num | ((byte)b3 << 8);
				int num2 = (byte)((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_8)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_12 + 2)];
				sbyte b4 = ((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_8)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_12 + 3)];
				startFrame.GetLocalsRef<LocalVariables>().Instruction_19 = num2 | ((byte)b4 << 8);
				int instruction_8 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_8 + 4;
				if (startFrame.GetLocalsRef<LocalVariables>().Instruction_18 != ((startFrame.GetLocalsRef<LocalVariables>().Instruction_19 ^ -1) & 0xFFFF))
				{
					startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
					break;
				}
				if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_12 + startFrame.GetLocalsRef<LocalVariables>().Instruction_18) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_7)
				{
					startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
					break;
				}
				startFrame.GetLocalsRef<LocalVariables>().Instruction_20 = 0;
				while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_20 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_18)
				{
					sbyte b5 = ((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_8)[(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_12 + startFrame.GetLocalsRef<LocalVariables>().Instruction_20)];
					startFrame.GetLocalsRef<LocalVariables>().Instruction_21 = (byte)b5;
					if (startFrame.GetLocalsRef<LocalVariables>().Instruction_14 == 0)
					{
						if (startFrame.GetLocalsRef<LocalVariables>().Instruction_21 != 0)
						{
							goto IL_063f;
						}
						if (startFrame.GetLocalsRef<LocalVariables>().Instruction_15 == 0)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_ji2h3xd.__pointer, String_uxbkrtb.__pointer, 2160);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							_ = 0;
						}
					}
					else
					{
						if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_15 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_1)
						{
							if (startFrame.GetLocalsRef<LocalVariables>().Instruction_13 == startFrame.GetLocalsRef<LocalVariables>().Instruction_11)
							{
								goto IL_06f0;
							}
							sbyte b6 = (sbyte)startFrame.GetLocalsRef<LocalVariables>().Instruction_21;
							void* instruction_9 = startFrame.GetLocalsRef<LocalVariables>().Instruction_5;
							int instruction_10 = startFrame.GetLocalsRef<LocalVariables>().Instruction_13;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_13 = instruction_10 + 1;
							((sbyte*)instruction_9)[(uint)instruction_10] = b6;
						}
						int num3 = startFrame.GetLocalsRef<LocalVariables>().Instruction_15 + 1;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_15 = num3;
						if (num3 == startFrame.GetLocalsRef<LocalVariables>().Instruction_2)
						{
							if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)
							{
								if (startFrame.GetLocalsRef<LocalVariables>().Instruction_13 == startFrame.GetLocalsRef<LocalVariables>().Instruction_11)
								{
									goto IL_07f5;
								}
								void* instruction_11 = startFrame.GetLocalsRef<LocalVariables>().Instruction_5;
								int instruction_12 = startFrame.GetLocalsRef<LocalVariables>().Instruction_13;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_13 = instruction_12 + 1;
								((sbyte*)instruction_11)[(uint)instruction_12] = -1;
							}
							startFrame.GetLocalsRef<LocalVariables>().Instruction_15 = 0;
						}
					}
					int num4 = startFrame.GetLocalsRef<LocalVariables>().Instruction_14 + 1;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_14 = num4;
					if (num4 == startFrame.GetLocalsRef<LocalVariables>().Instruction_9 + 1)
					{
						if (startFrame.GetLocalsRef<LocalVariables>().Instruction_15 == 0)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_ji2h3xd.__pointer, String_uxbkrtb.__pointer, 2188);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							_ = 0;
						}
						startFrame.GetLocalsRef<LocalVariables>().Instruction_14 = 0;
					}
					int instruction_13 = startFrame.GetLocalsRef<LocalVariables>().Instruction_20;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_20 = instruction_13 + 1;
				}
				int instruction_14 = startFrame.GetLocalsRef<LocalVariables>().Instruction_18;
				int instruction_15 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_15 + instruction_14;
				if ((startFrame.GetLocalsRef<LocalVariables>().Instruction_16 & 1) != 1)
				{
					continue;
				}
				if (startFrame.GetLocalsRef<LocalVariables>().Instruction_15 != 0)
				{
					startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
					break;
				}
				if (startFrame.GetLocalsRef<LocalVariables>().Instruction_12 + 4 != startFrame.GetLocalsRef<LocalVariables>().Instruction_6)
				{
					startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
					break;
				}
				int instruction_16 = startFrame.GetLocalsRef<LocalVariables>().Instruction_13;
				int instruction_17 = startFrame.GetLocalsRef<LocalVariables>().Instruction_11;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = instruction_16 == instruction_17;
				break;
				IL_06f0:
				startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
				break;
				IL_07f5:
				startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
				break;
				IL_063f:
				startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
				break;
			}
			bool instruction_18 = startFrame.GetLocalsRef<LocalVariables>().Instruction_0;
			StackFrameList.Current.Clear(startFrame);
			return instruction_18;
		}
	}
}
