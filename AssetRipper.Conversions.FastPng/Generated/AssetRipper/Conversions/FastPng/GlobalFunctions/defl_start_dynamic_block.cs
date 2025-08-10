using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?defl_start_dynamic_block@fpng@@YA_NPEAUdefl_huff@1@PEAEAEAIIAEA_KAEAH@Z")]
[DemangledName("bool __cdecl fpng::defl_start_dynamic_block(struct fpng::defl_huff *, unsigned char *, unsigned int &, unsigned int, unsigned __int64 &, int &)")]
internal static partial class defl_start_dynamic_block
{
	private partial struct LocalVariables
	{
		public bool Instruction_0;

		public unsafe void* Instruction_1;

		public unsafe void* Instruction_2;

		public int Instruction_3;

		public unsafe void* Instruction_4;

		public unsafe void* Instruction_5;

		public unsafe void* Instruction_6;

		public int Instruction_7;

		public int Instruction_8;

		public int Instruction_9;

		public int Instruction_10;

		public int Instruction_11;

		public int Instruction_12;

		public int Instruction_13;

		public int Instruction_14;

		public int Instruction_15;

		public InlineArray_320_w3otm9c Instruction_16;

		public InlineArray_320_w3otm9c Instruction_17;

		public sbyte Instruction_18;

		public sbyte Instruction_19;

		public int Instruction_20;

		public int Instruction_21;

		public int Instruction_22;

		public int Instruction_23;

		public int Instruction_24;

		public int Instruction_25;

		public int Instruction_26;

		public int Instruction_27;

		public int Instruction_28;

		public int Instruction_29;

		public int Instruction_30;

		public int Instruction_31;

		public int Instruction_32;

		public int Instruction_33;

		public int Instruction_34;
	}

	public unsafe static bool Invoke(void* d, void* pDst, void* dst_ofs, int dst_buf_size, void* bit_buf, void* bit_buf_size)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		InlineArray_320_w3otm9c* ptr = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_16;
		InlineArray_320_w3otm9c* ptr2 = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_17;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = bit_buf_size;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = bit_buf;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = dst_buf_size;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_4 = dst_ofs;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_5 = pDst;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_6 = d;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_18 = -1;
		unchecked
		{
			*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 0 + sizeof(short) * 256) = 1;
			defl_optimize_huffman_table.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_6, 0, 288, 12, 0);
			defl_optimize_huffman_table.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_6, 1, 32, 12, 0);
			startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = 286;
			while (startFrame.GetLocalsRef<LocalVariables>().Instruction_7 > 257 && ((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_2) + sizeof(InlineArray_288_w3otm9c) * 0)[sizeof(sbyte) * checked(startFrame.GetLocalsRef<LocalVariables>().Instruction_7 - 1)] == 0)
			{
				int instruction_ = checked(startFrame.GetLocalsRef<LocalVariables>().Instruction_7 + -1);
				startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = instruction_;
			}
			startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = 30;
			while (startFrame.GetLocalsRef<LocalVariables>().Instruction_8 > 1 && ((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_2) + sizeof(InlineArray_288_w3otm9c) * 1)[sizeof(sbyte) * checked(startFrame.GetLocalsRef<LocalVariables>().Instruction_8 - 1)] == 0)
			{
				int instruction_2 = checked(startFrame.GetLocalsRef<LocalVariables>().Instruction_8 + -1);
				startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_2;
			}
			llvm_memcpy_p0_p0_i64.Invoke((byte*)ptr + sizeof(sbyte) * 0, (byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_2) + sizeof(InlineArray_288_w3otm9c) * 0 + sizeof(sbyte) * 0, startFrame.GetLocalsRef<LocalVariables>().Instruction_7, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke((byte*)ptr + sizeof(sbyte) * 0 + startFrame.GetLocalsRef<LocalVariables>().Instruction_7, (byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_2) + sizeof(InlineArray_288_w3otm9c) * 1 + sizeof(sbyte) * 0, startFrame.GetLocalsRef<LocalVariables>().Instruction_8, isVolatile: false);
			int instruction_3 = checked(startFrame.GetLocalsRef<LocalVariables>().Instruction_7 + startFrame.GetLocalsRef<LocalVariables>().Instruction_8);
			startFrame.GetLocalsRef<LocalVariables>().Instruction_11 = instruction_3;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = 0;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_13 = 0;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_14 = 0;
			llvm_memset_p0_i64.Invoke((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 0, 0, 38L, isVolatile: false);
			startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = 0;
			while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_11)
			{
				sbyte instruction_4 = ((sbyte*)ptr)[sizeof(sbyte) * (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10];
				startFrame.GetLocalsRef<LocalVariables>().Instruction_19 = instruction_4;
				if (startFrame.GetLocalsRef<LocalVariables>().Instruction_19 == 0)
				{
					if (startFrame.GetLocalsRef<LocalVariables>().Instruction_14 != 0)
					{
						if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_14 < 3u)
						{
							int num = (ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * (byte)startFrame.GetLocalsRef<LocalVariables>().Instruction_18));
							int instruction_5 = startFrame.GetLocalsRef<LocalVariables>().Instruction_14;
							*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * (byte)startFrame.GetLocalsRef<LocalVariables>().Instruction_18) = (short)(num + instruction_5);
							while (true)
							{
								int instruction_6 = startFrame.GetLocalsRef<LocalVariables>().Instruction_14;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_14 = instruction_6 + -1;
								if (instruction_6 == 0)
								{
									break;
								}
								sbyte instruction_7 = startFrame.GetLocalsRef<LocalVariables>().Instruction_18;
								int instruction_8 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_8 + 1;
								((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_8] = instruction_7;
							}
						}
						else
						{
							int num2;
							checked
							{
								num2 = unchecked((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 16))) + 1;
							}
							*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 16) = (short)num2;
							int instruction_9 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_9 + 1;
							((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_9] = 16;
							sbyte b = (sbyte)(startFrame.GetLocalsRef<LocalVariables>().Instruction_14 - 3);
							int instruction_10 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_10 + 1;
							((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_10] = b;
						}
						startFrame.GetLocalsRef<LocalVariables>().Instruction_14 = 0;
					}
					int num3 = startFrame.GetLocalsRef<LocalVariables>().Instruction_13 + 1;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_13 = num3;
					if (num3 == 138 && startFrame.GetLocalsRef<LocalVariables>().Instruction_13 != 0)
					{
						if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_13 < 3u)
						{
							int num4 = (ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 0));
							int instruction_11 = startFrame.GetLocalsRef<LocalVariables>().Instruction_13;
							*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 0) = (short)(num4 + instruction_11);
							while (true)
							{
								int instruction_12 = startFrame.GetLocalsRef<LocalVariables>().Instruction_13;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_13 = instruction_12 + -1;
								if (instruction_12 == 0)
								{
									break;
								}
								int instruction_13 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_13 + 1;
								((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_13] = 0;
							}
						}
						else if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_13 <= 10u)
						{
							int num5;
							checked
							{
								num5 = unchecked((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 17))) + 1;
							}
							*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 17) = (short)num5;
							int instruction_14 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_14 + 1;
							((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_14] = 17;
							sbyte b2 = (sbyte)(startFrame.GetLocalsRef<LocalVariables>().Instruction_13 - 3);
							int instruction_15 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_15 + 1;
							((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_15] = b2;
						}
						else
						{
							int num6;
							checked
							{
								num6 = unchecked((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 18))) + 1;
							}
							*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 18) = (short)num6;
							int instruction_16 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_16 + 1;
							((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_16] = 18;
							sbyte b3 = (sbyte)(startFrame.GetLocalsRef<LocalVariables>().Instruction_13 - 11);
							int instruction_17 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_17 + 1;
							((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_17] = b3;
						}
						startFrame.GetLocalsRef<LocalVariables>().Instruction_13 = 0;
					}
				}
				else
				{
					if (startFrame.GetLocalsRef<LocalVariables>().Instruction_13 != 0)
					{
						if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_13 < 3u)
						{
							int num7 = (ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 0));
							int instruction_18 = startFrame.GetLocalsRef<LocalVariables>().Instruction_13;
							*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 0) = (short)(num7 + instruction_18);
							while (true)
							{
								int instruction_19 = startFrame.GetLocalsRef<LocalVariables>().Instruction_13;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_13 = instruction_19 + -1;
								if (instruction_19 == 0)
								{
									break;
								}
								int instruction_20 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_20 + 1;
								((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_20] = 0;
							}
						}
						else if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_13 <= 10u)
						{
							int num8;
							checked
							{
								num8 = unchecked((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 17))) + 1;
							}
							*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 17) = (short)num8;
							int instruction_21 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_21 + 1;
							((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_21] = 17;
							sbyte b4 = (sbyte)(startFrame.GetLocalsRef<LocalVariables>().Instruction_13 - 3);
							int instruction_22 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_22 + 1;
							((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_22] = b4;
						}
						else
						{
							int num9;
							checked
							{
								num9 = unchecked((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 18))) + 1;
							}
							*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 18) = (short)num9;
							int instruction_23 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_23 + 1;
							((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_23] = 18;
							sbyte b5 = (sbyte)(startFrame.GetLocalsRef<LocalVariables>().Instruction_13 - 11);
							int instruction_24 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_24 + 1;
							((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_24] = b5;
						}
						startFrame.GetLocalsRef<LocalVariables>().Instruction_13 = 0;
					}
					if ((byte)startFrame.GetLocalsRef<LocalVariables>().Instruction_19 != (byte)startFrame.GetLocalsRef<LocalVariables>().Instruction_18)
					{
						if (startFrame.GetLocalsRef<LocalVariables>().Instruction_14 != 0)
						{
							if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_14 < 3u)
							{
								int num10 = (ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * (byte)startFrame.GetLocalsRef<LocalVariables>().Instruction_18));
								int instruction_25 = startFrame.GetLocalsRef<LocalVariables>().Instruction_14;
								*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * (byte)startFrame.GetLocalsRef<LocalVariables>().Instruction_18) = (short)(num10 + instruction_25);
								while (true)
								{
									int instruction_26 = startFrame.GetLocalsRef<LocalVariables>().Instruction_14;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_14 = instruction_26 + -1;
									if (instruction_26 == 0)
									{
										break;
									}
									sbyte instruction_27 = startFrame.GetLocalsRef<LocalVariables>().Instruction_18;
									int instruction_28 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_28 + 1;
									((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_28] = instruction_27;
								}
							}
							else
							{
								int num11;
								checked
								{
									num11 = unchecked((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 16))) + 1;
								}
								*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 16) = (short)num11;
								int instruction_29 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_29 + 1;
								((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_29] = 16;
								sbyte b6 = (sbyte)(startFrame.GetLocalsRef<LocalVariables>().Instruction_14 - 3);
								int instruction_30 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_30 + 1;
								((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_30] = b6;
							}
							startFrame.GetLocalsRef<LocalVariables>().Instruction_14 = 0;
						}
						int num12;
						checked
						{
							num12 = unchecked((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * (byte)startFrame.GetLocalsRef<LocalVariables>().Instruction_19))) + 1;
						}
						*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * (byte)startFrame.GetLocalsRef<LocalVariables>().Instruction_19) = (short)num12;
						sbyte instruction_31 = startFrame.GetLocalsRef<LocalVariables>().Instruction_19;
						int instruction_32 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_32 + 1;
						((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_32] = instruction_31;
					}
					else
					{
						int num13 = startFrame.GetLocalsRef<LocalVariables>().Instruction_14 + 1;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_14 = num13;
						if (num13 == 6 && startFrame.GetLocalsRef<LocalVariables>().Instruction_14 != 0)
						{
							if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_14 < 3u)
							{
								int num14 = (ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * (byte)startFrame.GetLocalsRef<LocalVariables>().Instruction_18));
								int instruction_33 = startFrame.GetLocalsRef<LocalVariables>().Instruction_14;
								*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * (byte)startFrame.GetLocalsRef<LocalVariables>().Instruction_18) = (short)(num14 + instruction_33);
								while (true)
								{
									int instruction_34 = startFrame.GetLocalsRef<LocalVariables>().Instruction_14;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_14 = instruction_34 + -1;
									if (instruction_34 == 0)
									{
										break;
									}
									sbyte instruction_35 = startFrame.GetLocalsRef<LocalVariables>().Instruction_18;
									int instruction_36 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_36 + 1;
									((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_36] = instruction_35;
								}
							}
							else
							{
								int num15;
								checked
								{
									num15 = unchecked((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 16))) + 1;
								}
								*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 16) = (short)num15;
								int instruction_37 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_37 + 1;
								((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_37] = 16;
								sbyte b7 = (sbyte)(startFrame.GetLocalsRef<LocalVariables>().Instruction_14 - 3);
								int instruction_38 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_38 + 1;
								((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_38] = b7;
							}
							startFrame.GetLocalsRef<LocalVariables>().Instruction_14 = 0;
						}
					}
				}
				sbyte instruction_39 = startFrame.GetLocalsRef<LocalVariables>().Instruction_19;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_18 = instruction_39;
				int instruction_40 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_40 + 1;
			}
			if (startFrame.GetLocalsRef<LocalVariables>().Instruction_14 != 0)
			{
				if (startFrame.GetLocalsRef<LocalVariables>().Instruction_14 != 0)
				{
					if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_14 < 3u)
					{
						int num16 = (ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * (byte)startFrame.GetLocalsRef<LocalVariables>().Instruction_18));
						int instruction_41 = startFrame.GetLocalsRef<LocalVariables>().Instruction_14;
						*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * (byte)startFrame.GetLocalsRef<LocalVariables>().Instruction_18) = (short)(num16 + instruction_41);
						while (true)
						{
							int instruction_42 = startFrame.GetLocalsRef<LocalVariables>().Instruction_14;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_14 = instruction_42 + -1;
							if (instruction_42 == 0)
							{
								break;
							}
							sbyte instruction_43 = startFrame.GetLocalsRef<LocalVariables>().Instruction_18;
							int instruction_44 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_44 + 1;
							((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_44] = instruction_43;
						}
					}
					else
					{
						int num17;
						checked
						{
							num17 = unchecked((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 16))) + 1;
						}
						*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 16) = (short)num17;
						int instruction_45 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_45 + 1;
						((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_45] = 16;
						sbyte b8 = (sbyte)(startFrame.GetLocalsRef<LocalVariables>().Instruction_14 - 3);
						int instruction_46 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_46 + 1;
						((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_46] = b8;
					}
					startFrame.GetLocalsRef<LocalVariables>().Instruction_14 = 0;
				}
			}
			else if (startFrame.GetLocalsRef<LocalVariables>().Instruction_13 != 0)
			{
				if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_13 < 3u)
				{
					int num18 = (ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 0));
					int instruction_47 = startFrame.GetLocalsRef<LocalVariables>().Instruction_13;
					*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 0) = (short)(num18 + instruction_47);
					while (true)
					{
						int instruction_48 = startFrame.GetLocalsRef<LocalVariables>().Instruction_13;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_13 = instruction_48 + -1;
						if (instruction_48 == 0)
						{
							break;
						}
						int instruction_49 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_49 + 1;
						((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_49] = 0;
					}
				}
				else if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_13 <= 10u)
				{
					int num19;
					checked
					{
						num19 = unchecked((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 17))) + 1;
					}
					*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 17) = (short)num19;
					int instruction_50 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_50 + 1;
					((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_50] = 17;
					sbyte b9 = (sbyte)(startFrame.GetLocalsRef<LocalVariables>().Instruction_13 - 3);
					int instruction_51 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_51 + 1;
					((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_51] = b9;
				}
				else
				{
					int num20;
					checked
					{
						num20 = unchecked((ushort)(*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 18))) + 1;
					}
					*(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_0) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * 18) = (short)num20;
					int instruction_52 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_52 + 1;
					((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_52] = 18;
					sbyte b10 = (sbyte)(startFrame.GetLocalsRef<LocalVariables>().Instruction_13 - 11);
					int instruction_53 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = instruction_53 + 1;
					((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_53] = b10;
				}
				startFrame.GetLocalsRef<LocalVariables>().Instruction_13 = 0;
			}
			defl_optimize_huffman_table.Invoke(startFrame.GetLocalsRef<LocalVariables>().Instruction_6, 2, 19, 7, 0);
			startFrame.GetLocalsRef<LocalVariables>().Instruction_20 = 2;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_21 = 2;
			if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_21 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_21 <= 16u)
			{
				_ = -1;
			}
			else
			{
				wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 799);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				_ = 0;
			}
			if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_20 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_21))
			{
				_ = -1;
			}
			else
			{
				wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 799);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				_ = 0;
			}
			long num21 = (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_20;
			int instruction_54 = *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1;
			*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 |= num21 << (int)(uint)instruction_54;
			int instruction_55 = startFrame.GetLocalsRef<LocalVariables>().Instruction_21;
			*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 += instruction_55;
			if (*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 <= 64)
			{
				_ = -1;
			}
			else
			{
				wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 799);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				_ = 0;
			}
			while (true)
			{
				if (*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 >= 8)
				{
					if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_3)
					{
						startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
						break;
					}
					long instruction_56 = *(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2;
					((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)[(uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4)] = (sbyte)instruction_56;
					(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4)++;
					*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 >>>= 8;
					checked
					{
						*unchecked((int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1) -= 8;
						continue;
					}
				}
				int instruction_57 = checked(startFrame.GetLocalsRef<LocalVariables>().Instruction_7 - 257);
				startFrame.GetLocalsRef<LocalVariables>().Instruction_22 = instruction_57;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_23 = 5;
				if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23 <= 16u)
				{
					_ = -1;
				}
				else
				{
					wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 801);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					_ = 0;
				}
				if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_22 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23))
				{
					_ = -1;
				}
				else
				{
					wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 801);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					_ = 0;
				}
				long num22 = (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_22;
				int instruction_58 = *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1;
				*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 |= num22 << (int)(uint)instruction_58;
				int instruction_59 = startFrame.GetLocalsRef<LocalVariables>().Instruction_23;
				*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 += instruction_59;
				if (*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 <= 64)
				{
					_ = -1;
				}
				else
				{
					wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 801);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					_ = 0;
				}
				while (true)
				{
					if (*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 >= 8)
					{
						if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_3)
						{
							startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
							break;
						}
						long instruction_60 = *(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2;
						((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)[(uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4)] = (sbyte)instruction_60;
						(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4)++;
						*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 >>>= 8;
						checked
						{
							*unchecked((int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1) -= 8;
							continue;
						}
					}
					int instruction_61 = checked(startFrame.GetLocalsRef<LocalVariables>().Instruction_8 - 1);
					startFrame.GetLocalsRef<LocalVariables>().Instruction_24 = instruction_61;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_25 = 5;
					if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_25 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_25 <= 16u)
					{
						_ = -1;
					}
					else
					{
						wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 802);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						_ = 0;
					}
					if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_24 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_25))
					{
						_ = -1;
					}
					else
					{
						wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 802);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						_ = 0;
					}
					long num23 = (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_24;
					int instruction_62 = *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1;
					*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 |= num23 << (int)(uint)instruction_62;
					int instruction_63 = startFrame.GetLocalsRef<LocalVariables>().Instruction_25;
					*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 += instruction_63;
					if (*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 <= 64)
					{
						_ = -1;
					}
					else
					{
						wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 802);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						_ = 0;
					}
					while (true)
					{
						if (*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 >= 8)
						{
							if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_3)
							{
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
								break;
							}
							long instruction_64 = *(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2;
							((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)[(uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4)] = (sbyte)instruction_64;
							(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4)++;
							*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 >>>= 8;
							checked
							{
								*unchecked((int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1) -= 8;
								continue;
							}
						}
						startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = 18;
						while (startFrame.GetLocalsRef<LocalVariables>().Instruction_9 >= 0)
						{
							InlineArray_288_w3otm9c* ptr3 = (InlineArray_288_w3otm9c*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_2) + sizeof(InlineArray_288_w3otm9c) * 2);
							int instruction_65 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
							if (((bool*)ptr3)[sizeof(sbyte) * (byte)((sbyte*)g_defl_packed_code_size_syms_swizzle.__pointer)[sizeof(sbyte) * instruction_65]])
							{
								break;
							}
							int instruction_66 = checked(startFrame.GetLocalsRef<LocalVariables>().Instruction_9 + -1);
							startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_66;
						}
						checked
						{
							int instruction_67 = maximum_sfjssib.Invoke(4, startFrame.GetLocalsRef<LocalVariables>().Instruction_9 + 1);
							startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_67;
							int instruction_68 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9 - 4;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_26 = instruction_68;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_27 = 4;
						}
						if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_27 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_27 <= 16u)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 805);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							_ = 0;
						}
						if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_26 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_27))
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 805);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							_ = 0;
						}
						long num24 = (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_26;
						int instruction_69 = *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1;
						*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 |= num24 << (int)(uint)instruction_69;
						int instruction_70 = startFrame.GetLocalsRef<LocalVariables>().Instruction_27;
						*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 += instruction_70;
						if (*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 <= 64)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 805);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							_ = 0;
						}
						while (true)
						{
							if (*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 >= 8)
							{
								if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 + 1) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_3)
								{
									startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
									break;
								}
								long instruction_71 = *(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2;
								((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)[(uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4)] = (sbyte)instruction_71;
								(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4)++;
								*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 >>>= 8;
								checked
								{
									*unchecked((int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1) -= 8;
									continue;
								}
							}
							startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = 0;
							while (true)
							{
								if (startFrame.GetLocalsRef<LocalVariables>().Instruction_10 < startFrame.GetLocalsRef<LocalVariables>().Instruction_9)
								{
									InlineArray_288_w3otm9c* ptr4 = (InlineArray_288_w3otm9c*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_2) + sizeof(InlineArray_288_w3otm9c) * 2);
									int instruction_72 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
									sbyte b11 = ((sbyte*)ptr4)[sizeof(sbyte) * (byte)((sbyte*)g_defl_packed_code_size_syms_swizzle.__pointer)[sizeof(sbyte) * (int)(uint)instruction_72]];
									startFrame.GetLocalsRef<LocalVariables>().Instruction_28 = (byte)b11;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_29 = 3;
									if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_29 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_29 <= 16u)
									{
										_ = -1;
									}
									else
									{
										wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 806);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										_ = 0;
									}
									if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_28 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_29))
									{
										_ = -1;
									}
									else
									{
										wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 806);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										_ = 0;
									}
									long num25 = (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_28;
									int instruction_73 = *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1;
									*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 |= num25 << (int)(uint)instruction_73;
									int instruction_74 = startFrame.GetLocalsRef<LocalVariables>().Instruction_29;
									*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 += instruction_74;
									if (*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 <= 64)
									{
										_ = -1;
									}
									else
									{
										wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 806);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										_ = 0;
									}
									while (*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 >= 8)
									{
										if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 + 1) <= (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_3)
										{
											long instruction_75 = *(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2;
											((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)[(uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4)] = (sbyte)instruction_75;
											(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4)++;
											*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 >>>= 8;
											checked
											{
												*unchecked((int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1) -= 8;
												continue;
											}
										}
										goto IL_36ec;
									}
									int instruction_76 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_76 + 1;
									continue;
								}
								startFrame.GetLocalsRef<LocalVariables>().Instruction_15 = 0;
								while (true)
								{
									if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_15 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_12)
									{
										int instruction_77 = startFrame.GetLocalsRef<LocalVariables>().Instruction_15;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_15 = instruction_77 + 1;
										sbyte b12 = ((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_77];
										startFrame.GetLocalsRef<LocalVariables>().Instruction_30 = (byte)b12;
										if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_30 < 19u)
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_erkdsbd.__pointer, String_uxbkrtb.__pointer, 810);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											_ = 0;
										}
										short num26 = *(short*)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_1) + sizeof(InlineArray_288_oeds4ea) * 2 + sizeof(short) * (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_30);
										startFrame.GetLocalsRef<LocalVariables>().Instruction_31 = (ushort)num26;
										sbyte b13 = (sbyte)((byte*)(&((fpng_defl_huff*)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)->field_2) + sizeof(InlineArray_288_w3otm9c) * 2)[sizeof(sbyte) * (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_30];
										startFrame.GetLocalsRef<LocalVariables>().Instruction_32 = (byte)b13;
										if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_32 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_32 <= 16u)
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 811);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											_ = 0;
										}
										if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_31 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_32))
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 811);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											_ = 0;
										}
										long num27 = (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_31;
										int instruction_78 = *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1;
										*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 |= num27 << (int)(uint)instruction_78;
										int instruction_79 = startFrame.GetLocalsRef<LocalVariables>().Instruction_32;
										*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 += instruction_79;
										if (*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 <= 64)
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 811);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											_ = 0;
										}
										while (*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 >= 8)
										{
											if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 + 1) <= (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_3)
											{
												long instruction_80 = *(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)[(uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4)] = (sbyte)instruction_80;
												(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4)++;
												*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 >>>= 8;
												checked
												{
													*unchecked((int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1) -= 8;
													continue;
												}
											}
											goto IL_3cbc;
										}
										if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_30 < 16u)
										{
											continue;
										}
										int instruction_81 = startFrame.GetLocalsRef<LocalVariables>().Instruction_15;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_15 = instruction_81 + 1;
										sbyte b14 = ((sbyte*)ptr2)[sizeof(sbyte) * (int)(uint)instruction_81];
										startFrame.GetLocalsRef<LocalVariables>().Instruction_33 = (byte)b14;
										int instruction_82 = startFrame.GetLocalsRef<LocalVariables>().Instruction_30;
										sbyte b15 = ((sbyte*)String_o9ulvgb.__pointer)[sizeof(sbyte) * (int)(uint)(instruction_82 - 16)];
										startFrame.GetLocalsRef<LocalVariables>().Instruction_34 = b15;
										if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_34 >= 1u && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_34 <= 16u)
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_isj2lib.__pointer, String_uxbkrtb.__pointer, 812);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											_ = 0;
										}
										if ((ulong)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_33 < (ulong)(1L << (int)(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_34))
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_ooiduua.__pointer, String_uxbkrtb.__pointer, 812);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											_ = 0;
										}
										long num28 = (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_33;
										int instruction_83 = *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1;
										*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 |= num28 << (int)(uint)instruction_83;
										int instruction_84 = startFrame.GetLocalsRef<LocalVariables>().Instruction_34;
										*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 += instruction_84;
										if (*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 <= 64)
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_mggwlgb.__pointer, String_uxbkrtb.__pointer, 812);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											_ = 0;
										}
										while (*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1 >= 8)
										{
											if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 + 1) <= (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_3)
											{
												long instruction_85 = *(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2;
												((sbyte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)[(uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4)] = (sbyte)instruction_85;
												(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4)++;
												*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2 >>>= 8;
												checked
												{
													*unchecked((int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_1) -= 8;
													continue;
												}
											}
											goto IL_413d;
										}
										continue;
									}
									startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = true;
									break;
									IL_3cbc:
									startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
									break;
									IL_413d:
									startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
									break;
								}
								break;
								IL_36ec:
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
								break;
							}
							break;
						}
						break;
					}
					break;
				}
				break;
			}
			bool instruction_86 = startFrame.GetLocalsRef<LocalVariables>().Instruction_0;
			StackFrameList.Current.Clear(startFrame);
			return instruction_86;
		}
	}
}
