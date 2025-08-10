using AssetRipper.Conversions.FastPng.GlobalVariables;
using AssetRipper.Conversions.FastPng.Helpers;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Intrinsics.Implemented;

namespace AssetRipper.Conversions.FastPng.GlobalFunctions;

[MangledName("?prepare_dynamic_block@fpng@@YA_NPEBEIAEAI1AEA_KPEAII@Z")]
[DemangledName("bool __cdecl fpng::prepare_dynamic_block(unsigned char const *, unsigned int, unsigned int &, unsigned int &, unsigned __int64 &, unsigned int *, unsigned int)")]
internal static partial class prepare_dynamic_block
{
	private partial struct LocalVariables
	{
		public bool Instruction_0;

		public int Instruction_1;

		public unsafe void* Instruction_2;

		public unsafe void* Instruction_3;

		public unsafe void* Instruction_4;

		public unsafe void* Instruction_5;

		public int Instruction_6;

		public unsafe void* Instruction_7;

		public int Instruction_8;

		public int Instruction_9;

		public int Instruction_10;

		public int Instruction_11;

		public int Instruction_12;

		public int Instruction_13;

		public InlineArray_320_w3otm9c Instruction_14;

		public int Instruction_15;

		public InlineArray_19_w3otm9c Instruction_16;

		public int Instruction_17;

		public int Instruction_18;

		public int Instruction_19;

		public InlineArray_4096_vqkfj7a Instruction_20;

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

		public InlineArray_288_w3otm9c Instruction_31;

		public int Instruction_32;

		public int Instruction_33;

		public int Instruction_34;

		public int Instruction_35;

		public int Instruction_36;

		public int Instruction_37;

		public int Instruction_38;

		public int Instruction_39;

		public int Instruction_40;
	}

	public unsafe static bool Invoke(void* pSrc, int src_len, void* src_ofs, void* bit_buf_size, void* bit_buf, void* pLit_table, int num_chans)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		InlineArray_320_w3otm9c* ptr = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_14;
		InlineArray_19_w3otm9c* ptr2 = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_16;
		InlineArray_4096_vqkfj7a* ptr3 = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_20;
		InlineArray_288_w3otm9c* ptr4 = &startFrame.GetLocalsPointer<LocalVariables>()->Instruction_31;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_1 = num_chans;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_2 = pLit_table;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_3 = bit_buf;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_4 = bit_buf_size;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_5 = src_ofs;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_6 = src_len;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_7 = pSrc;
		startFrame.GetLocalsRef<LocalVariables>().Instruction_11 = 5;
		unchecked
		{
			if (startFrame.GetLocalsRef<LocalVariables>().Instruction_11 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_11 <= 32u)
			{
				_ = -1;
			}
			else
			{
				wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 1963);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				_ = 0;
			}
			long instruction_ = *(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3;
			int instruction_2 = startFrame.GetLocalsRef<LocalVariables>().Instruction_11;
			int num = *(int*)((byte*)g_bitmasks.__pointer + sizeof(int) * (int)(uint)instruction_2);
			startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = (int)(instruction_ & (uint)num);
			int instruction_3 = startFrame.GetLocalsRef<LocalVariables>().Instruction_11;
			*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 >>>= (int)(uint)instruction_3;
			int instruction_4 = startFrame.GetLocalsRef<LocalVariables>().Instruction_11;
			*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 -= instruction_4;
			if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4) < 32u)
			{
				if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)
				{
					startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
					goto IL_25b0;
				}
				long num2 = (uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_7 + (uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)));
				int instruction_5 = *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4;
				*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 |= num2 << (int)(uint)instruction_5;
				*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 += 4;
				*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 += 32;
			}
			int instruction_6 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_8 = instruction_6 + 257;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_12 = 5;
			if (startFrame.GetLocalsRef<LocalVariables>().Instruction_12 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_12 <= 32u)
			{
				_ = -1;
			}
			else
			{
				wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 1966);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				_ = 0;
			}
			long instruction_7 = *(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3;
			int instruction_8 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
			int num3 = *(int*)((byte*)g_bitmasks.__pointer + sizeof(int) * (int)(uint)instruction_8);
			startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = (int)(instruction_7 & (uint)num3);
			int instruction_9 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
			*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 >>>= (int)(uint)instruction_9;
			int instruction_10 = startFrame.GetLocalsRef<LocalVariables>().Instruction_12;
			*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 -= instruction_10;
			if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4) < 32u)
			{
				if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)
				{
					startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
					goto IL_25b0;
				}
				long num4 = (uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_7 + (uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)));
				int instruction_11 = *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4;
				*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 |= num4 << (int)(uint)instruction_11;
				*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 += 4;
				*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 += 32;
			}
			int instruction_12 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_9 = instruction_12 + 1;
			int instruction_13 = startFrame.GetLocalsRef<LocalVariables>().Instruction_8;
			int instruction_14 = startFrame.GetLocalsRef<LocalVariables>().Instruction_9;
			startFrame.GetLocalsRef<LocalVariables>().Instruction_13 = instruction_13 + instruction_14;
			if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_13 > 320u)
			{
				startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
			}
			else
			{
				llvm_memset_p0_i64.Invoke((byte*)ptr + sizeof(sbyte) * 0, 0, 320L, isVolatile: false);
				startFrame.GetLocalsRef<LocalVariables>().Instruction_15 = 4;
				if (startFrame.GetLocalsRef<LocalVariables>().Instruction_15 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_15 <= 32u)
				{
					_ = -1;
				}
				else
				{
					wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 1976);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					_ = 0;
				}
				long instruction_15 = *(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3;
				int instruction_16 = startFrame.GetLocalsRef<LocalVariables>().Instruction_15;
				int num5 = *(int*)((byte*)g_bitmasks.__pointer + sizeof(int) * (int)(uint)instruction_16);
				startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = (int)(instruction_15 & (uint)num5);
				int instruction_17 = startFrame.GetLocalsRef<LocalVariables>().Instruction_15;
				*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 >>>= (int)(uint)instruction_17;
				int instruction_18 = startFrame.GetLocalsRef<LocalVariables>().Instruction_15;
				*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 -= instruction_18;
				if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4) < 32u)
				{
					if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)
					{
						startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
						goto IL_25b0;
					}
					long num6 = (uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_7 + (uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)));
					int instruction_19 = *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4;
					*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 |= num6 << (int)(uint)instruction_19;
					*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 += 4;
					*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 += 32;
				}
				int instruction_20 = startFrame.GetLocalsRef<LocalVariables>().Instruction_10;
				startFrame.GetLocalsRef<LocalVariables>().Instruction_10 = instruction_20 + 4;
				llvm_memset_p0_i64.Invoke((byte*)ptr2 + sizeof(sbyte) * 0, 0, 19L, isVolatile: false);
				startFrame.GetLocalsRef<LocalVariables>().Instruction_17 = 0;
				while (true)
				{
					if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_17 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_10)
					{
						startFrame.GetLocalsRef<LocalVariables>().Instruction_18 = 0;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_19 = 3;
						if (startFrame.GetLocalsRef<LocalVariables>().Instruction_19 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_19 <= 32u)
						{
							_ = -1;
						}
						else
						{
							wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 1985);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							_ = 0;
						}
						long instruction_21 = *(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3;
						int instruction_22 = startFrame.GetLocalsRef<LocalVariables>().Instruction_19;
						int num7 = *(int*)((byte*)g_bitmasks.__pointer + sizeof(int) * (int)(uint)instruction_22);
						startFrame.GetLocalsRef<LocalVariables>().Instruction_18 = (int)(instruction_21 & (uint)num7);
						int instruction_23 = startFrame.GetLocalsRef<LocalVariables>().Instruction_19;
						*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 >>>= (int)(uint)instruction_23;
						int instruction_24 = startFrame.GetLocalsRef<LocalVariables>().Instruction_19;
						*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 -= instruction_24;
						if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4) < 32u)
						{
							if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)
							{
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
								break;
							}
							long num8 = (uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_7 + (uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)));
							int instruction_25 = *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4;
							*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 |= num8 << (int)(uint)instruction_25;
							*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 += 4;
							*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 += 32;
						}
						sbyte b = (sbyte)startFrame.GetLocalsRef<LocalVariables>().Instruction_18;
						int instruction_26 = startFrame.GetLocalsRef<LocalVariables>().Instruction_17;
						((sbyte*)ptr2)[sizeof(sbyte) * (byte)((sbyte*)s_bit_length_order.__pointer)[sizeof(sbyte) * (int)(uint)instruction_26]] = b;
						int instruction_27 = startFrame.GetLocalsRef<LocalVariables>().Instruction_17;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_17 = instruction_27 + 1;
						continue;
					}
					bool flag = build_decoder_table.Invoke(19, (byte*)ptr2 + sizeof(sbyte) * 0, (byte*)ptr3 + sizeof(int) * 0);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (!flag)
					{
						startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
						break;
					}
					startFrame.GetLocalsRef<LocalVariables>().Instruction_21 = 15;
					startFrame.GetLocalsRef<LocalVariables>().Instruction_22 = 0;
					while (true)
					{
						if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_22 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_13)
						{
							int instruction_28 = *(int*)((byte*)ptr3 + sizeof(int) * (int)(*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 & 0xFFFL));
							startFrame.GetLocalsRef<LocalVariables>().Instruction_23 = instruction_28;
							int instruction_29 = startFrame.GetLocalsRef<LocalVariables>().Instruction_23;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_24 = instruction_29 >>> 9;
							if (startFrame.GetLocalsRef<LocalVariables>().Instruction_24 == 0)
							{
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
								break;
							}
							int instruction_30 = startFrame.GetLocalsRef<LocalVariables>().Instruction_24;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_25 = instruction_30;
							if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_25 <= 32u)
							{
								_ = -1;
							}
							else
							{
								wassert.Invoke(String_mf9hyza.__pointer, String_uxbkrtb.__pointer, 2001);
								if (ExceptionInfo.Current != null)
								{
									return false;
								}
								_ = 0;
							}
							int instruction_31 = startFrame.GetLocalsRef<LocalVariables>().Instruction_25;
							*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 >>>= (int)(uint)instruction_31;
							int instruction_32 = startFrame.GetLocalsRef<LocalVariables>().Instruction_25;
							*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 -= instruction_32;
							if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4) < 32u)
							{
								if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)
								{
									startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
									break;
								}
								long num9 = (uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_7 + (uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)));
								int instruction_33 = *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4;
								*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 |= num9 << (int)(uint)instruction_33;
								*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 += 4;
								*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 += 32;
							}
							int instruction_34 = startFrame.GetLocalsRef<LocalVariables>().Instruction_23;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_23 = instruction_34 & 0x1FF;
							if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23 <= 15u)
							{
								if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_23 > 12u)
								{
									startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
									break;
								}
								if (startFrame.GetLocalsRef<LocalVariables>().Instruction_23 != 0)
								{
									int instruction_35 = minimum_su2nfub.Invoke(b: startFrame.GetLocalsRef<LocalVariables>().Instruction_23, a: startFrame.GetLocalsRef<LocalVariables>().Instruction_21);
									startFrame.GetLocalsRef<LocalVariables>().Instruction_21 = instruction_35;
								}
								sbyte b2 = (sbyte)startFrame.GetLocalsRef<LocalVariables>().Instruction_23;
								int instruction_36 = startFrame.GetLocalsRef<LocalVariables>().Instruction_22;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_22 = instruction_36 + 1;
								((sbyte*)ptr)[sizeof(sbyte) * (int)(uint)instruction_36] = b2;
								continue;
							}
							startFrame.GetLocalsRef<LocalVariables>().Instruction_26 = 0;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_27 = 0;
							int instruction_37 = startFrame.GetLocalsRef<LocalVariables>().Instruction_23;
							if (instruction_37 != 16)
							{
								if (instruction_37 != 17)
								{
									if (instruction_37 == 18)
									{
										startFrame.GetLocalsRef<LocalVariables>().Instruction_30 = 7;
										if (startFrame.GetLocalsRef<LocalVariables>().Instruction_30 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_30 <= 32u)
										{
											_ = -1;
										}
										else
										{
											wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 2039);
											if (ExceptionInfo.Current != null)
											{
												return false;
											}
											_ = 0;
										}
										long instruction_38 = *(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3;
										int instruction_39 = startFrame.GetLocalsRef<LocalVariables>().Instruction_30;
										int num10 = *(int*)((byte*)g_bitmasks.__pointer + sizeof(int) * (int)(uint)instruction_39);
										startFrame.GetLocalsRef<LocalVariables>().Instruction_26 = (int)(instruction_38 & (uint)num10);
										int instruction_40 = startFrame.GetLocalsRef<LocalVariables>().Instruction_30;
										*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 >>>= (int)(uint)instruction_40;
										int instruction_41 = startFrame.GetLocalsRef<LocalVariables>().Instruction_30;
										*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 -= instruction_41;
										if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4) < 32u)
										{
											if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)
											{
												startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
												break;
											}
											long num11 = (uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_7 + (uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)));
											int instruction_42 = *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4;
											*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 |= num11 << (int)(uint)instruction_42;
											*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 += 4;
											*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 += 32;
										}
										int instruction_43 = startFrame.GetLocalsRef<LocalVariables>().Instruction_26;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_26 = instruction_43 + 11;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_27 = 0;
									}
								}
								else
								{
									startFrame.GetLocalsRef<LocalVariables>().Instruction_29 = 3;
									if (startFrame.GetLocalsRef<LocalVariables>().Instruction_29 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_29 <= 32u)
									{
										_ = -1;
									}
									else
									{
										wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 2032);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										_ = 0;
									}
									long instruction_44 = *(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3;
									int instruction_45 = startFrame.GetLocalsRef<LocalVariables>().Instruction_29;
									int num12 = *(int*)((byte*)g_bitmasks.__pointer + sizeof(int) * (int)(uint)instruction_45);
									startFrame.GetLocalsRef<LocalVariables>().Instruction_26 = (int)(instruction_44 & (uint)num12);
									int instruction_46 = startFrame.GetLocalsRef<LocalVariables>().Instruction_29;
									*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 >>>= (int)(uint)instruction_46;
									int instruction_47 = startFrame.GetLocalsRef<LocalVariables>().Instruction_29;
									*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 -= instruction_47;
									if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4) < 32u)
									{
										if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)
										{
											startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
											break;
										}
										long num13 = (uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_7 + (uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)));
										int instruction_48 = *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4;
										*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 |= num13 << (int)(uint)instruction_48;
										*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 += 4;
										*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 += 32;
									}
									int instruction_49 = startFrame.GetLocalsRef<LocalVariables>().Instruction_26;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_26 = instruction_49 + 3;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_27 = 0;
								}
							}
							else
							{
								startFrame.GetLocalsRef<LocalVariables>().Instruction_28 = 2;
								if (startFrame.GetLocalsRef<LocalVariables>().Instruction_28 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_28 <= 32u)
								{
									_ = -1;
								}
								else
								{
									wassert.Invoke(String_aa3exrc.__pointer, String_uxbkrtb.__pointer, 2023);
									if (ExceptionInfo.Current != null)
									{
										return false;
									}
									_ = 0;
								}
								long instruction_50 = *(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3;
								int instruction_51 = startFrame.GetLocalsRef<LocalVariables>().Instruction_28;
								int num14 = *(int*)((byte*)g_bitmasks.__pointer + sizeof(int) * (int)(uint)instruction_51);
								startFrame.GetLocalsRef<LocalVariables>().Instruction_26 = (int)(instruction_50 & (uint)num14);
								int instruction_52 = startFrame.GetLocalsRef<LocalVariables>().Instruction_28;
								*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 >>>= (int)(uint)instruction_52;
								int instruction_53 = startFrame.GetLocalsRef<LocalVariables>().Instruction_28;
								*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 -= instruction_53;
								if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4) < 32u)
								{
									if ((uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 + 4) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_6)
									{
										startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
										break;
									}
									long num15 = (uint)(*(int*)((byte*)startFrame.GetLocalsRef<LocalVariables>().Instruction_7 + (uint)(*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5)));
									int instruction_54 = *(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4;
									*(long*)startFrame.GetLocalsRef<LocalVariables>().Instruction_3 |= num15 << (int)(uint)instruction_54;
									*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_5 += 4;
									*(int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_4 += 32;
								}
								int instruction_55 = startFrame.GetLocalsRef<LocalVariables>().Instruction_26;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_26 = instruction_55 + 3;
								if (startFrame.GetLocalsRef<LocalVariables>().Instruction_22 == 0)
								{
									startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
									break;
								}
								sbyte b3 = ((sbyte*)ptr)[sizeof(sbyte) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_22 - 1)];
								startFrame.GetLocalsRef<LocalVariables>().Instruction_27 = (byte)b3;
							}
							if ((uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_22 + startFrame.GetLocalsRef<LocalVariables>().Instruction_26) > (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_13)
							{
								startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
								break;
							}
							while (startFrame.GetLocalsRef<LocalVariables>().Instruction_26 != 0)
							{
								sbyte b4 = (sbyte)startFrame.GetLocalsRef<LocalVariables>().Instruction_27;
								int instruction_56 = startFrame.GetLocalsRef<LocalVariables>().Instruction_22;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_22 = instruction_56 + 1;
								((sbyte*)ptr)[sizeof(sbyte) * (int)(uint)instruction_56] = b4;
								int instruction_57 = startFrame.GetLocalsRef<LocalVariables>().Instruction_26;
								startFrame.GetLocalsRef<LocalVariables>().Instruction_26 = instruction_57 + -1;
							}
							continue;
						}
						llvm_memcpy_p0_p0_i64.Invoke((byte*)ptr4 + sizeof(sbyte) * 0, (byte*)ptr + sizeof(sbyte) * 0, (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8, isVolatile: false);
						llvm_memset_p0_i64.Invoke((byte*)ptr4 + sizeof(sbyte) * 0 + (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_8, 0, (uint)(288 - startFrame.GetLocalsRef<LocalVariables>().Instruction_8), isVolatile: false);
						startFrame.GetLocalsRef<LocalVariables>().Instruction_32 = 0;
						startFrame.GetLocalsRef<LocalVariables>().Instruction_33 = 0;
						while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_33 < (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_9)
						{
							int num16 = (((byte)((sbyte*)ptr)[sizeof(sbyte) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_8 + startFrame.GetLocalsRef<LocalVariables>().Instruction_33)] == 1) ? 1 : 0);
							int instruction_58 = startFrame.GetLocalsRef<LocalVariables>().Instruction_32;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_32 = instruction_58 + num16;
							int instruction_59 = startFrame.GetLocalsRef<LocalVariables>().Instruction_33;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_33 = instruction_59 + 1;
						}
						if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_32 < 1u || (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_32 > 2u)
						{
							startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
							break;
						}
						if ((byte)((sbyte*)ptr)[sizeof(sbyte) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_8 + (startFrame.GetLocalsRef<LocalVariables>().Instruction_1 - 1))] != 1)
						{
							startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
							break;
						}
						if (startFrame.GetLocalsRef<LocalVariables>().Instruction_32 == 2 && (byte)((sbyte*)ptr)[sizeof(sbyte) * (int)(uint)(startFrame.GetLocalsRef<LocalVariables>().Instruction_8 + startFrame.GetLocalsRef<LocalVariables>().Instruction_1)] != 1)
						{
							startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
							break;
						}
						bool flag2 = build_decoder_table.Invoke(pTable: startFrame.GetLocalsRef<LocalVariables>().Instruction_2, num_syms: startFrame.GetLocalsRef<LocalVariables>().Instruction_8, pCode_sizes: (byte*)ptr4 + sizeof(sbyte) * 0);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag2)
						{
							startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = false;
							break;
						}
						startFrame.GetLocalsRef<LocalVariables>().Instruction_34 = 0;
						while ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_34 < 4096u)
						{
							int num17 = ((int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_34];
							startFrame.GetLocalsRef<LocalVariables>().Instruction_35 = num17 & 0x1FF;
							if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_35 < 256u)
							{
								int num18 = ((int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_34];
								startFrame.GetLocalsRef<LocalVariables>().Instruction_36 = (num18 >>> 9) & 0xF;
								if (startFrame.GetLocalsRef<LocalVariables>().Instruction_36 != 0)
								{
									if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_36 <= 12u)
									{
										_ = -1;
									}
									else
									{
										wassert.Invoke(String_nlshwsc.__pointer, String_uxbkrtb.__pointer, 2089);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										_ = 0;
									}
									int instruction_60 = startFrame.GetLocalsRef<LocalVariables>().Instruction_36;
									startFrame.GetLocalsRef<LocalVariables>().Instruction_37 = 12 - instruction_60;
									if ((uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_37 >= (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_21)
									{
										int instruction_61 = startFrame.GetLocalsRef<LocalVariables>().Instruction_34;
										int instruction_62 = startFrame.GetLocalsRef<LocalVariables>().Instruction_36;
										startFrame.GetLocalsRef<LocalVariables>().Instruction_38 = instruction_61 >>> instruction_62;
										int num19 = ((int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_38];
										startFrame.GetLocalsRef<LocalVariables>().Instruction_39 = num19 & 0x1FF;
										int num20 = ((int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_38];
										startFrame.GetLocalsRef<LocalVariables>().Instruction_40 = (num20 >>> 9) & 0xF;
										if (startFrame.GetLocalsRef<LocalVariables>().Instruction_40 != 0 && (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_37 >= (uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_40)
										{
											int num21 = startFrame.GetLocalsRef<LocalVariables>().Instruction_39 << 16;
											int instruction_63 = startFrame.GetLocalsRef<LocalVariables>().Instruction_40;
											((int*)startFrame.GetLocalsRef<LocalVariables>().Instruction_2)[(uint)startFrame.GetLocalsRef<LocalVariables>().Instruction_34] |= num21 | (instruction_63 << 25);
										}
									}
								}
							}
							int instruction_64 = startFrame.GetLocalsRef<LocalVariables>().Instruction_34;
							startFrame.GetLocalsRef<LocalVariables>().Instruction_34 = instruction_64 + 1;
						}
						startFrame.GetLocalsRef<LocalVariables>().Instruction_0 = true;
						break;
					}
					break;
				}
			}
			goto IL_25b0;
		}
		IL_25b0:
		bool instruction_65 = startFrame.GetLocalsRef<LocalVariables>().Instruction_0;
		StackFrameList.Current.Clear(startFrame);
		return instruction_65;
	}
}
