using System;
using System.Runtime.InteropServices;
using AssetRipper.Conversions.FastPng.InlineArrays;
using AssetRipper.Conversions.FastPng.Structures;

namespace AssetRipper.Conversions.FastPng;

internal static partial class GlobalVariablePointers
{
	[MangledName("_Avx2WmemEnabledWeakValue")]
	[DemangledName("_Avx2WmemEnabledWeakValue")]
	public unsafe static int* Avx2WmemEnabledWeakValue
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_Avx2WmemEnabledWeakValue == IntPtr.Zero)
				{
					int* ptr = (int*)Marshal.AllocHGlobal(sizeof(int));
					*ptr = 0;
					PointerCache.variable_Avx2WmemEnabledWeakValue = (nint)ptr;
				}
				return (int*)PointerCache.variable_Avx2WmemEnabledWeakValue;
			}
		}
	}

	[MangledName("??_C@_1DK@OKEJEHAG@?$AA?4?$AA?4?$AA?1?$AA?4?$AA?4?$AA?1?$AA?4?$AA?4?$AA?1?$AA?4?$AA?4?$AA?1?$AAS?$AAa?$AAm?$AAp?$AAl?$AAe?$AAs?$AA?2?$AAf?$AAp?$AAn?$AAg?$AA?4?$AAc?$AAp?$AAp?$AA?$AA@")]
	[DemangledName("L\"../../../../Samples\\\\fpng.cpp\"")]
	[CleanName("String")]
	public unsafe static InlineArray_29_oeds4ea* String_uxbkrtb
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_uxbkrtb == IntPtr.Zero)
				{
					InlineArray_29_oeds4ea* ptr = (InlineArray_29_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_29_oeds4ea));
					*ptr = default(InlineArray_29_oeds4ea);
					PointerCache.variable_String_uxbkrtb = (nint)ptr;
				}
				return (InlineArray_29_oeds4ea*)PointerCache.variable_String_uxbkrtb;
			}
		}
	}

	[MangledName("??_C@_13COJANIEC@?$AA0?$AA?$AA@")]
	[DemangledName("L\"0\"")]
	[CleanName("String")]
	public unsafe static InlineArray_2_oeds4ea* String_kdrammb
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_kdrammb == IntPtr.Zero)
				{
					InlineArray_2_oeds4ea* ptr = (InlineArray_2_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_2_oeds4ea));
					*ptr = default(InlineArray_2_oeds4ea);
					PointerCache.variable_String_kdrammb = (nint)ptr;
				}
				return (InlineArray_2_oeds4ea*)PointerCache.variable_String_kdrammb;
			}
		}
	}

	[MangledName("??_C@_1EA@NGEOLJKL@?$AAt?$AAe?$AAm?$AAp?$AA_?$AAb?$AAu?$AAf?$AA_?$AAo?$AAf?$AAs?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AAt?$AAe?$AAm?$AAp?$AA_?$AAb?$AAu?$AAf?$AA?4?$AAs?$AAi?$AAz?$AAe?$AA?$CI?$AA?$CJ?$AA?$AA@")]
	[DemangledName("L\"temp_buf_ofs <= temp_buf.size()\"")]
	[CleanName("String")]
	public unsafe static InlineArray_32_oeds4ea* String_bik4erc
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_bik4erc == IntPtr.Zero)
				{
					InlineArray_32_oeds4ea* ptr = (InlineArray_32_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_32_oeds4ea));
					*ptr = default(InlineArray_32_oeds4ea);
					PointerCache.variable_String_bik4erc = (nint)ptr;
				}
				return (InlineArray_32_oeds4ea*)PointerCache.variable_String_bik4erc;
			}
		}
	}

	[MangledName("??_C@_1FA@FOPIPCKM@?$AA?$CI?$AAo?$AAu?$AAt?$AA_?$AAo?$AAf?$AAs?$AA?5?$AA?$CL?$AA?5?$AAz?$AAl?$AAi?$AAb?$AA_?$AAs?$AAi?$AAz?$AAe?$AA?$CJ?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AAo?$AAu?$AAt?$AA_?$AAb?$AAu?$AAf@")]
	[DemangledName("L\"(out_ofs + zlib_size) <= out_buf\"...")]
	[CleanName("String")]
	public unsafe static InlineArray_40_oeds4ea* String_dqvhqxc
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_dqvhqxc == IntPtr.Zero)
				{
					InlineArray_40_oeds4ea* ptr = (InlineArray_40_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_40_oeds4ea));
					*ptr = default(InlineArray_40_oeds4ea);
					PointerCache.variable_String_dqvhqxc = (nint)ptr;
				}
				return (InlineArray_40_oeds4ea*)PointerCache.variable_String_dqvhqxc;
			}
		}
	}

	[MangledName("?s_color_type@?1??fpng_encode_image_to_memory@fpng@@YA_NPEBXIIIAEAV?$vector@EV?$allocator@E@std@@@std@@I@Z@4QBEB")]
	[DemangledName("unsigned char const *const `bool __cdecl fpng::fpng_encode_image_to_memory(void const *, unsigned int, unsigned int, unsigned int, class std::vector<unsigned char, class std::allocator<unsigned char>> &, unsigned int)'::`2'::s_color_type")]
	public unsafe static InlineArray_5_w3otm9c* s_color_type
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_s_color_type == IntPtr.Zero)
				{
					InlineArray_5_w3otm9c* ptr = (InlineArray_5_w3otm9c*)Marshal.AllocHGlobal(sizeof(InlineArray_5_w3otm9c));
					*ptr = default(InlineArray_5_w3otm9c);
					PointerCache.variable_s_color_type = (nint)ptr;
				}
				return (InlineArray_5_w3otm9c*)PointerCache.variable_s_color_type;
			}
		}
	}

	[MangledName("??_C@_0BB@BKMJLBGB@?$AA?$AA?$AA?$AA?$AA?$AA?$AA?$AAIEND?$KOB?$GA?$IC?$AA@")]
	[DemangledName("\"\\0\\0\\0\\0\\0\\0\\0\\0IEND\\xAEB`\\x82\"")]
	[CleanName("String")]
	public unsafe static InlineArray_17_w3otm9c* String_nz3h57a
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_nz3h57a == IntPtr.Zero)
				{
					InlineArray_17_w3otm9c* ptr = (InlineArray_17_w3otm9c*)Marshal.AllocHGlobal(sizeof(InlineArray_17_w3otm9c));
					*ptr = default(InlineArray_17_w3otm9c);
					PointerCache.variable_String_nz3h57a = (nint)ptr;
				}
				return (InlineArray_17_w3otm9c*)PointerCache.variable_String_nz3h57a;
			}
		}
	}

	[MangledName("?g_crc32_4@fpng@@3QAY0BAA@$$CBIA")]
	[DemangledName("unsigned int const (*const fpng::g_crc32_4)[256]")]
	public unsafe static InlineArray_4_vjlif9a* g_crc32_4
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_g_crc32_4 == IntPtr.Zero)
				{
					InlineArray_4_vjlif9a* ptr = (InlineArray_4_vjlif9a*)Marshal.AllocHGlobal(sizeof(InlineArray_4_vjlif9a));
					*ptr = default(InlineArray_4_vjlif9a);
					PointerCache.variable_g_crc32_4 = (nint)ptr;
				}
				return (InlineArray_4_vjlif9a*)PointerCache.variable_g_crc32_4;
			}
		}
	}

	[MangledName("??_C@_1BE@DFLAPPIJ@?$AAp?$AAP?$AAr?$AAe?$AAv?$AA_?$AAs?$AAr?$AAc?$AA?$AA@")]
	[DemangledName("L\"pPrev_src\"")]
	[CleanName("String")]
	public unsafe static InlineArray_10_oeds4ea* String_uc52kza
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_uc52kza == IntPtr.Zero)
				{
					InlineArray_10_oeds4ea* ptr = (InlineArray_10_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_10_oeds4ea));
					*ptr = default(InlineArray_10_oeds4ea);
					PointerCache.variable_String_uc52kza = (nint)ptr;
				}
				return (InlineArray_10_oeds4ea*)PointerCache.variable_String_uc52kza;
			}
		}
	}

	[MangledName("??_C@_1CM@PHNBINKF@?$AA?$CI?$AAl?$AA?$CJ?$AA?5?$AA?$DO?$AA?$DN?$AA?5?$AA0?$AA?5?$AA?$CG?$AA?$CG?$AA?5?$AA?$CI?$AAl?$AA?$CJ?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AA1?$AA6?$AA?$AA@")]
	[DemangledName("L\"(l) >= 0 && (l) <= 16\"")]
	[CleanName("String")]
	public unsafe static InlineArray_22_oeds4ea* String_9hewgtd
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_9hewgtd == IntPtr.Zero)
				{
					InlineArray_22_oeds4ea* ptr = (InlineArray_22_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_22_oeds4ea));
					*ptr = default(InlineArray_22_oeds4ea);
					PointerCache.variable_String_9hewgtd = (nint)ptr;
				}
				return (InlineArray_22_oeds4ea*)PointerCache.variable_String_9hewgtd;
			}
		}
	}

	[MangledName("??_C@_1CI@EDFEPIBM@?$AA?$CI?$AAb?$AA?$CJ?$AA?5?$AA?$DM?$AA?5?$AA?$CI?$AA1?$AAU?$AAL?$AAL?$AA?5?$AA?$DM?$AA?$DM?$AA?5?$AA?$CI?$AAl?$AA?$CJ?$AA?$CJ?$AA?$AA@")]
	[DemangledName("L\"(b) < (1ULL << (l))\"")]
	[CleanName("String")]
	public unsafe static InlineArray_20_oeds4ea* String_ooiduua
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_ooiduua == IntPtr.Zero)
				{
					InlineArray_20_oeds4ea* ptr = (InlineArray_20_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_20_oeds4ea));
					*ptr = default(InlineArray_20_oeds4ea);
					PointerCache.variable_String_ooiduua = (nint)ptr;
				}
				return (InlineArray_20_oeds4ea*)PointerCache.variable_String_ooiduua;
			}
		}
	}

	[MangledName("??_C@_1CG@LKELDOLB@?$AAb?$AAi?$AAt?$AA_?$AAb?$AAu?$AAf?$AA_?$AAs?$AAi?$AAz?$AAe?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AA6?$AA4?$AA?$AA@")]
	[DemangledName("L\"bit_buf_size <= 64\"")]
	[CleanName("String")]
	public unsafe static InlineArray_19_oeds4ea* String_mggwlgb
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_mggwlgb == IntPtr.Zero)
				{
					InlineArray_19_oeds4ea* ptr = (InlineArray_19_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_19_oeds4ea));
					*ptr = default(InlineArray_19_oeds4ea);
					PointerCache.variable_String_mggwlgb = (nint)ptr;
				}
				return (InlineArray_19_oeds4ea*)PointerCache.variable_String_mggwlgb;
			}
		}
	}

	[MangledName("?g_defl_len_sym@fpng@@3QBGB")]
	[DemangledName("unsigned short const *const fpng::g_defl_len_sym")]
	public unsafe static InlineArray_256_oeds4ea* g_defl_len_sym
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_g_defl_len_sym == IntPtr.Zero)
				{
					InlineArray_256_oeds4ea* ptr = (InlineArray_256_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_256_oeds4ea));
					*ptr = default(InlineArray_256_oeds4ea);
					PointerCache.variable_g_defl_len_sym = (nint)ptr;
				}
				return (InlineArray_256_oeds4ea*)PointerCache.variable_g_defl_len_sym;
			}
		}
	}

	[MangledName("??_C@_1CG@PKEJNHCM@?$AAs?$AAr?$AAc?$AA_?$AAo?$AAf?$AAs?$AA?5?$AA?$DN?$AA?$DN?$AA?5?$AAh?$AA?5?$AA?$CK?$AA?5?$AAb?$AAp?$AAl?$AA?$AA@")]
	[DemangledName("L\"src_ofs == h * bpl\"")]
	[CleanName("String")]
	public unsafe static InlineArray_19_oeds4ea* String_bjvsuxc
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_bjvsuxc == IntPtr.Zero)
				{
					InlineArray_19_oeds4ea* ptr = (InlineArray_19_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_19_oeds4ea));
					*ptr = default(InlineArray_19_oeds4ea);
					PointerCache.variable_String_bjvsuxc = (nint)ptr;
				}
				return (InlineArray_19_oeds4ea*)PointerCache.variable_String_bjvsuxc;
			}
		}
	}

	[MangledName("??_C@_1DI@FDHIJIML@?$AAt?$AAo?$AAt?$AAa?$AAl?$AA_?$AAc?$AAo?$AAd?$AAe?$AAs?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AAc?$AAo?$AAd?$AAe?$AAs?$AA?4?$AAs?$AAi?$AAz?$AAe?$AA?$CI?$AA?$CJ?$AA?$AA@")]
	[DemangledName("L\"total_codes <= codes.size()\"")]
	[CleanName("String")]
	public unsafe static InlineArray_28_oeds4ea* String_hsgehfc
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_hsgehfc == IntPtr.Zero)
				{
					InlineArray_28_oeds4ea* ptr = (InlineArray_28_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_28_oeds4ea));
					*ptr = default(InlineArray_28_oeds4ea);
					PointerCache.variable_String_hsgehfc = (nint)ptr;
				}
				return (InlineArray_28_oeds4ea*)PointerCache.variable_String_hsgehfc;
			}
		}
	}

	[MangledName("??_C@_1CE@GPOANAFC@?$AAb?$AAi?$AAt?$AA_?$AAb?$AAu?$AAf?$AA_?$AAs?$AAi?$AAz?$AAe?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AA7?$AA?$AA@")]
	[DemangledName("L\"bit_buf_size <= 7\"")]
	[CleanName("String")]
	public unsafe static InlineArray_18_oeds4ea* String_vpte4cc
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_vpte4cc == IntPtr.Zero)
				{
					InlineArray_18_oeds4ea* ptr = (InlineArray_18_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_18_oeds4ea));
					*ptr = default(InlineArray_18_oeds4ea);
					PointerCache.variable_String_vpte4cc = (nint)ptr;
				}
				return (InlineArray_18_oeds4ea*)PointerCache.variable_String_vpte4cc;
			}
		}
	}

	[MangledName("??_C@_1JI@IFFHKEFF@?$AAd?$AAh?$AA?4?$AAm?$AA_?$AAh?$AAu?$AAf?$AAf?$AA_?$AAc?$AAo?$AAd?$AAe?$AAs?$AA?$FL?$AA1?$AA?$FN?$AA?$FL?$AAd?$AAi?$AAs?$AAt?$AA_?$AAs?$AAy?$AAm?$AA?$FN?$AA?5?$AA?$DN?$AA?$DN?$AA?5@")]
	[DemangledName("L\"dh.m_huff_codes[1][dist_sym] == \"...")]
	[CleanName("String")]
	public unsafe static InlineArray_76_oeds4ea* String_df5ko9b
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_df5ko9b == IntPtr.Zero)
				{
					InlineArray_76_oeds4ea* ptr = (InlineArray_76_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_76_oeds4ea));
					*ptr = default(InlineArray_76_oeds4ea);
					PointerCache.variable_String_df5ko9b = (nint)ptr;
				}
				return (InlineArray_76_oeds4ea*)PointerCache.variable_String_df5ko9b;
			}
		}
	}

	[MangledName("??_C@_1CM@MLLBGOKN@?$AA?$CI?$AAl?$AA?$CJ?$AA?5?$AA?$DO?$AA?$DN?$AA?5?$AA1?$AA?5?$AA?$CG?$AA?$CG?$AA?5?$AA?$CI?$AAl?$AA?$CJ?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AA1?$AA6?$AA?$AA@")]
	[DemangledName("L\"(l) >= 1 && (l) <= 16\"")]
	[CleanName("String")]
	public unsafe static InlineArray_22_oeds4ea* String_isj2lib
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_isj2lib == IntPtr.Zero)
				{
					InlineArray_22_oeds4ea* ptr = (InlineArray_22_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_22_oeds4ea));
					*ptr = default(InlineArray_22_oeds4ea);
					PointerCache.variable_String_isj2lib = (nint)ptr;
				}
				return (InlineArray_22_oeds4ea*)PointerCache.variable_String_isj2lib;
			}
		}
	}

	[MangledName("?g_bitmasks@fpng@@3QBIB")]
	[DemangledName("unsigned int const *const fpng::g_bitmasks")]
	public unsafe static InlineArray_17_vqkfj7a* g_bitmasks
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_g_bitmasks == IntPtr.Zero)
				{
					InlineArray_17_vqkfj7a* ptr = (InlineArray_17_vqkfj7a*)Marshal.AllocHGlobal(sizeof(InlineArray_17_vqkfj7a));
					*ptr = default(InlineArray_17_vqkfj7a);
					PointerCache.variable_g_bitmasks = (nint)ptr;
				}
				return (InlineArray_17_vqkfj7a*)PointerCache.variable_g_bitmasks;
			}
		}
	}

	[MangledName("?g_defl_len_extra@fpng@@3QBEB")]
	[DemangledName("unsigned char const *const fpng::g_defl_len_extra")]
	public unsafe static InlineArray_256_w3otm9c* g_defl_len_extra
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_g_defl_len_extra == IntPtr.Zero)
				{
					InlineArray_256_w3otm9c* ptr = (InlineArray_256_w3otm9c*)Marshal.AllocHGlobal(sizeof(InlineArray_256_w3otm9c));
					*ptr = default(InlineArray_256_w3otm9c);
					PointerCache.variable_g_defl_len_extra = (nint)ptr;
				}
				return (InlineArray_256_w3otm9c*)PointerCache.variable_g_defl_len_extra;
			}
		}
	}

	[MangledName("??_C@_1CG@JFLKAPAP@?$AAb?$AAi?$AAt?$AAs?$AA_?$AAt?$AAo?$AA_?$AAs?$AAh?$AAi?$AAf?$AAt?$AA?5?$AA?$DM?$AA?5?$AA6?$AA4?$AA?$AA@")]
	[DemangledName("L\"bits_to_shift < 64\"")]
	[CleanName("String")]
	public unsafe static InlineArray_19_oeds4ea* String_2ej5tjb
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_2ej5tjb == IntPtr.Zero)
				{
					InlineArray_19_oeds4ea* ptr = (InlineArray_19_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_19_oeds4ea));
					*ptr = default(InlineArray_19_oeds4ea);
					PointerCache.variable_String_2ej5tjb = (nint)ptr;
				}
				return (InlineArray_19_oeds4ea*)PointerCache.variable_String_2ej5tjb;
			}
		}
	}

	[MangledName("??_C@_0BA@FOIKENOD@vector?5too?5long?$AA@")]
	[DemangledName("\"vector too long\"")]
	[CleanName("String")]
	public unsafe static InlineArray_16_w3otm9c* String_7b7kt9c
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_7b7kt9c == IntPtr.Zero)
				{
					InlineArray_16_w3otm9c* ptr = (InlineArray_16_w3otm9c*)Marshal.AllocHGlobal(sizeof(InlineArray_16_w3otm9c));
					*ptr = default(InlineArray_16_w3otm9c);
					PointerCache.variable_String_7b7kt9c = (nint)ptr;
				}
				return (InlineArray_16_w3otm9c*)PointerCache.variable_String_7b7kt9c;
			}
		}
	}

	[MangledName("??_7type_info@@6B@")]
	[DemangledName("const type_info::`vftable'")]
	public unsafe static void** _7type_info
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable__7type_info == IntPtr.Zero)
				{
					void** ptr = (void**)Marshal.AllocHGlobal(sizeof(void*));
					*ptr = null;
					PointerCache.variable__7type_info = (nint)ptr;
				}
				return (void**)PointerCache.variable__7type_info;
			}
		}
	}

	[MangledName("??_R0?AVbad_array_new_length@std@@@8")]
	[DemangledName("class std::bad_array_new_length `RTTI Type Descriptor'")]
	public unsafe static rtti_TypeDescriptor30* R0_AVbad_array_new_length
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_R0_AVbad_array_new_length == IntPtr.Zero)
				{
					rtti_TypeDescriptor30* ptr = (rtti_TypeDescriptor30*)Marshal.AllocHGlobal(sizeof(rtti_TypeDescriptor30));
					*ptr = default(rtti_TypeDescriptor30);
					PointerCache.variable_R0_AVbad_array_new_length = (nint)ptr;
				}
				return (rtti_TypeDescriptor30*)PointerCache.variable_R0_AVbad_array_new_length;
			}
		}
	}

	[MangledName("__ImageBase")]
	[DemangledName("__ImageBase")]
	public unsafe static sbyte* ImageBase
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_ImageBase == IntPtr.Zero)
				{
					sbyte* ptr = (sbyte*)Marshal.AllocHGlobal(sizeof(sbyte));
					*ptr = 0;
					PointerCache.variable_ImageBase = (nint)ptr;
				}
				return (sbyte*)PointerCache.variable_ImageBase;
			}
		}
	}

	[MangledName("_CT??_R0?AVbad_array_new_length@std@@@8??0bad_array_new_length@std@@QEAA@AEBV01@@Z24")]
	[DemangledName("_CT??_R0?AVbad_array_new_length@std@@@8??0bad_array_new_length@std@@QEAA@AEBV01@@Z24")]
	public unsafe static eh_CatchableType* CT_R0_AVbad_array_new_length_std_8_0bad_array_new_length_std_QEAA_AEBV01_Z24
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_CT_R0_AVbad_array_new_length_std_8_0bad_array_new_length_std_QEAA_AEBV01_Z24 == IntPtr.Zero)
				{
					eh_CatchableType* ptr = (eh_CatchableType*)Marshal.AllocHGlobal(sizeof(eh_CatchableType));
					*ptr = default(eh_CatchableType);
					PointerCache.variable_CT_R0_AVbad_array_new_length_std_8_0bad_array_new_length_std_QEAA_AEBV01_Z24 = (nint)ptr;
				}
				return (eh_CatchableType*)PointerCache.variable_CT_R0_AVbad_array_new_length_std_8_0bad_array_new_length_std_QEAA_AEBV01_Z24;
			}
		}
	}

	[MangledName("??_R0?AVbad_alloc@std@@@8")]
	[DemangledName("class std::bad_alloc `RTTI Type Descriptor'")]
	public unsafe static rtti_TypeDescriptor19* R0_AVbad_alloc
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_R0_AVbad_alloc == IntPtr.Zero)
				{
					rtti_TypeDescriptor19* ptr = (rtti_TypeDescriptor19*)Marshal.AllocHGlobal(sizeof(rtti_TypeDescriptor19));
					*ptr = default(rtti_TypeDescriptor19);
					PointerCache.variable_R0_AVbad_alloc = (nint)ptr;
				}
				return (rtti_TypeDescriptor19*)PointerCache.variable_R0_AVbad_alloc;
			}
		}
	}

	[MangledName("_CT??_R0?AVbad_alloc@std@@@8??0bad_alloc@std@@QEAA@AEBV01@@Z24")]
	[DemangledName("_CT??_R0?AVbad_alloc@std@@@8??0bad_alloc@std@@QEAA@AEBV01@@Z24")]
	public unsafe static eh_CatchableType* CT_R0_AVbad_alloc_std_8_0bad_alloc_std_QEAA_AEBV01_Z24
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_CT_R0_AVbad_alloc_std_8_0bad_alloc_std_QEAA_AEBV01_Z24 == IntPtr.Zero)
				{
					eh_CatchableType* ptr = (eh_CatchableType*)Marshal.AllocHGlobal(sizeof(eh_CatchableType));
					*ptr = default(eh_CatchableType);
					PointerCache.variable_CT_R0_AVbad_alloc_std_8_0bad_alloc_std_QEAA_AEBV01_Z24 = (nint)ptr;
				}
				return (eh_CatchableType*)PointerCache.variable_CT_R0_AVbad_alloc_std_8_0bad_alloc_std_QEAA_AEBV01_Z24;
			}
		}
	}

	[MangledName("??_R0?AVexception@std@@@8")]
	[DemangledName("class std::exception `RTTI Type Descriptor'")]
	public unsafe static rtti_TypeDescriptor19* R0_AVexception
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_R0_AVexception == IntPtr.Zero)
				{
					rtti_TypeDescriptor19* ptr = (rtti_TypeDescriptor19*)Marshal.AllocHGlobal(sizeof(rtti_TypeDescriptor19));
					*ptr = default(rtti_TypeDescriptor19);
					PointerCache.variable_R0_AVexception = (nint)ptr;
				}
				return (rtti_TypeDescriptor19*)PointerCache.variable_R0_AVexception;
			}
		}
	}

	[MangledName("_CT??_R0?AVexception@std@@@8??0exception@std@@QEAA@AEBV01@@Z24")]
	[DemangledName("_CT??_R0?AVexception@std@@@8??0exception@std@@QEAA@AEBV01@@Z24")]
	public unsafe static eh_CatchableType* CT_R0_AVexception_std_8_0exception_std_QEAA_AEBV01_Z24
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_CT_R0_AVexception_std_8_0exception_std_QEAA_AEBV01_Z24 == IntPtr.Zero)
				{
					eh_CatchableType* ptr = (eh_CatchableType*)Marshal.AllocHGlobal(sizeof(eh_CatchableType));
					*ptr = default(eh_CatchableType);
					PointerCache.variable_CT_R0_AVexception_std_8_0exception_std_QEAA_AEBV01_Z24 = (nint)ptr;
				}
				return (eh_CatchableType*)PointerCache.variable_CT_R0_AVexception_std_8_0exception_std_QEAA_AEBV01_Z24;
			}
		}
	}

	[MangledName("_CTA3?AVbad_array_new_length@std@@")]
	[DemangledName("_CTA3?AVbad_array_new_length@std@@")]
	public unsafe static eh_CatchableTypeArray_3* CTA3_AVbad_array_new_length_std
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_CTA3_AVbad_array_new_length_std == IntPtr.Zero)
				{
					eh_CatchableTypeArray_3* ptr = (eh_CatchableTypeArray_3*)Marshal.AllocHGlobal(sizeof(eh_CatchableTypeArray_3));
					*ptr = default(eh_CatchableTypeArray_3);
					PointerCache.variable_CTA3_AVbad_array_new_length_std = (nint)ptr;
				}
				return (eh_CatchableTypeArray_3*)PointerCache.variable_CTA3_AVbad_array_new_length_std;
			}
		}
	}

	[MangledName("_TI3?AVbad_array_new_length@std@@")]
	[DemangledName("_TI3?AVbad_array_new_length@std@@")]
	public unsafe static eh_ThrowInfo* TI3_AVbad_array_new_length_std
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_TI3_AVbad_array_new_length_std == IntPtr.Zero)
				{
					eh_ThrowInfo* ptr = (eh_ThrowInfo*)Marshal.AllocHGlobal(sizeof(eh_ThrowInfo));
					*ptr = default(eh_ThrowInfo);
					PointerCache.variable_TI3_AVbad_array_new_length_std = (nint)ptr;
				}
				return (eh_ThrowInfo*)PointerCache.variable_TI3_AVbad_array_new_length_std;
			}
		}
	}

	[MangledName("??_C@_0BF@KINCDENJ@bad?5array?5new?5length?$AA@")]
	[DemangledName("\"bad array new length\"")]
	[CleanName("String")]
	public unsafe static InlineArray_21_w3otm9c* String_gudorqc
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_gudorqc == IntPtr.Zero)
				{
					InlineArray_21_w3otm9c* ptr = (InlineArray_21_w3otm9c*)Marshal.AllocHGlobal(sizeof(InlineArray_21_w3otm9c));
					*ptr = default(InlineArray_21_w3otm9c);
					PointerCache.variable_String_gudorqc = (nint)ptr;
				}
				return (InlineArray_21_w3otm9c*)PointerCache.variable_String_gudorqc;
			}
		}
	}

	[MangledName("")]
	[CleanName("Variable")]
	public unsafe static Struct* Variable_4yxjuqa
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_Variable_4yxjuqa == IntPtr.Zero)
				{
					Struct* ptr = (Struct*)Marshal.AllocHGlobal(sizeof(Struct));
					*ptr = default(Struct);
					PointerCache.variable_Variable_4yxjuqa = (nint)ptr;
				}
				return (Struct*)PointerCache.variable_Variable_4yxjuqa;
			}
		}
	}

	[MangledName("??_R4bad_array_new_length@std@@6B@")]
	[DemangledName("const std::bad_array_new_length::`RTTI Complete Object Locator'")]
	public unsafe static rtti_CompleteObjectLocator* R4bad_array_new_length
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_R4bad_array_new_length == IntPtr.Zero)
				{
					rtti_CompleteObjectLocator* ptr = (rtti_CompleteObjectLocator*)Marshal.AllocHGlobal(sizeof(rtti_CompleteObjectLocator));
					*ptr = default(rtti_CompleteObjectLocator);
					PointerCache.variable_R4bad_array_new_length = (nint)ptr;
				}
				return (rtti_CompleteObjectLocator*)PointerCache.variable_R4bad_array_new_length;
			}
		}
	}

	[MangledName("??_R3bad_array_new_length@std@@8")]
	[DemangledName("std::bad_array_new_length::`RTTI Class Hierarchy Descriptor'")]
	public unsafe static rtti_ClassHierarchyDescriptor* R3bad_array_new_length
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_R3bad_array_new_length == IntPtr.Zero)
				{
					rtti_ClassHierarchyDescriptor* ptr = (rtti_ClassHierarchyDescriptor*)Marshal.AllocHGlobal(sizeof(rtti_ClassHierarchyDescriptor));
					*ptr = default(rtti_ClassHierarchyDescriptor);
					PointerCache.variable_R3bad_array_new_length = (nint)ptr;
				}
				return (rtti_ClassHierarchyDescriptor*)PointerCache.variable_R3bad_array_new_length;
			}
		}
	}

	[MangledName("??_R2bad_array_new_length@std@@8")]
	[DemangledName("std::bad_array_new_length::`RTTI Base Class Array'")]
	public unsafe static InlineArray_4_vqkfj7a* R2bad_array_new_length
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_R2bad_array_new_length == IntPtr.Zero)
				{
					InlineArray_4_vqkfj7a* ptr = (InlineArray_4_vqkfj7a*)Marshal.AllocHGlobal(sizeof(InlineArray_4_vqkfj7a));
					*ptr = default(InlineArray_4_vqkfj7a);
					PointerCache.variable_R2bad_array_new_length = (nint)ptr;
				}
				return (InlineArray_4_vqkfj7a*)PointerCache.variable_R2bad_array_new_length;
			}
		}
	}

	[MangledName("??_R1A@?0A@EA@bad_array_new_length@std@@8")]
	[DemangledName("std::bad_array_new_length::`RTTI Base Class Descriptor at (0, -1, 0, 64)'")]
	[CleanName("R1A")]
	public unsafe static rtti_BaseClassDescriptor* R1A_9w7p7zd
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_R1A_9w7p7zd == IntPtr.Zero)
				{
					rtti_BaseClassDescriptor* ptr = (rtti_BaseClassDescriptor*)Marshal.AllocHGlobal(sizeof(rtti_BaseClassDescriptor));
					*ptr = default(rtti_BaseClassDescriptor);
					PointerCache.variable_R1A_9w7p7zd = (nint)ptr;
				}
				return (rtti_BaseClassDescriptor*)PointerCache.variable_R1A_9w7p7zd;
			}
		}
	}

	[MangledName("??_R1A@?0A@EA@bad_alloc@std@@8")]
	[DemangledName("std::bad_alloc::`RTTI Base Class Descriptor at (0, -1, 0, 64)'")]
	[CleanName("R1A")]
	public unsafe static rtti_BaseClassDescriptor* R1A_vzsilob
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_R1A_vzsilob == IntPtr.Zero)
				{
					rtti_BaseClassDescriptor* ptr = (rtti_BaseClassDescriptor*)Marshal.AllocHGlobal(sizeof(rtti_BaseClassDescriptor));
					*ptr = default(rtti_BaseClassDescriptor);
					PointerCache.variable_R1A_vzsilob = (nint)ptr;
				}
				return (rtti_BaseClassDescriptor*)PointerCache.variable_R1A_vzsilob;
			}
		}
	}

	[MangledName("??_R3bad_alloc@std@@8")]
	[DemangledName("std::bad_alloc::`RTTI Class Hierarchy Descriptor'")]
	public unsafe static rtti_ClassHierarchyDescriptor* R3bad_alloc
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_R3bad_alloc == IntPtr.Zero)
				{
					rtti_ClassHierarchyDescriptor* ptr = (rtti_ClassHierarchyDescriptor*)Marshal.AllocHGlobal(sizeof(rtti_ClassHierarchyDescriptor));
					*ptr = default(rtti_ClassHierarchyDescriptor);
					PointerCache.variable_R3bad_alloc = (nint)ptr;
				}
				return (rtti_ClassHierarchyDescriptor*)PointerCache.variable_R3bad_alloc;
			}
		}
	}

	[MangledName("??_R2bad_alloc@std@@8")]
	[DemangledName("std::bad_alloc::`RTTI Base Class Array'")]
	public unsafe static InlineArray_3_vqkfj7a* R2bad_alloc
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_R2bad_alloc == IntPtr.Zero)
				{
					InlineArray_3_vqkfj7a* ptr = (InlineArray_3_vqkfj7a*)Marshal.AllocHGlobal(sizeof(InlineArray_3_vqkfj7a));
					*ptr = default(InlineArray_3_vqkfj7a);
					PointerCache.variable_R2bad_alloc = (nint)ptr;
				}
				return (InlineArray_3_vqkfj7a*)PointerCache.variable_R2bad_alloc;
			}
		}
	}

	[MangledName("??_R1A@?0A@EA@exception@std@@8")]
	[DemangledName("std::exception::`RTTI Base Class Descriptor at (0, -1, 0, 64)'")]
	[CleanName("R1A")]
	public unsafe static rtti_BaseClassDescriptor* R1A_bbqer2a
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_R1A_bbqer2a == IntPtr.Zero)
				{
					rtti_BaseClassDescriptor* ptr = (rtti_BaseClassDescriptor*)Marshal.AllocHGlobal(sizeof(rtti_BaseClassDescriptor));
					*ptr = default(rtti_BaseClassDescriptor);
					PointerCache.variable_R1A_bbqer2a = (nint)ptr;
				}
				return (rtti_BaseClassDescriptor*)PointerCache.variable_R1A_bbqer2a;
			}
		}
	}

	[MangledName("??_R3exception@std@@8")]
	[DemangledName("std::exception::`RTTI Class Hierarchy Descriptor'")]
	public unsafe static rtti_ClassHierarchyDescriptor* R3exception
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_R3exception == IntPtr.Zero)
				{
					rtti_ClassHierarchyDescriptor* ptr = (rtti_ClassHierarchyDescriptor*)Marshal.AllocHGlobal(sizeof(rtti_ClassHierarchyDescriptor));
					*ptr = default(rtti_ClassHierarchyDescriptor);
					PointerCache.variable_R3exception = (nint)ptr;
				}
				return (rtti_ClassHierarchyDescriptor*)PointerCache.variable_R3exception;
			}
		}
	}

	[MangledName("??_R2exception@std@@8")]
	[DemangledName("std::exception::`RTTI Base Class Array'")]
	public unsafe static InlineArray_2_vqkfj7a* R2exception
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_R2exception == IntPtr.Zero)
				{
					InlineArray_2_vqkfj7a* ptr = (InlineArray_2_vqkfj7a*)Marshal.AllocHGlobal(sizeof(InlineArray_2_vqkfj7a));
					*ptr = default(InlineArray_2_vqkfj7a);
					PointerCache.variable_R2exception = (nint)ptr;
				}
				return (InlineArray_2_vqkfj7a*)PointerCache.variable_R2exception;
			}
		}
	}

	[MangledName("")]
	[CleanName("Variable")]
	public unsafe static Struct* Variable_zdor9mc
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_Variable_zdor9mc == IntPtr.Zero)
				{
					Struct* ptr = (Struct*)Marshal.AllocHGlobal(sizeof(Struct));
					*ptr = default(Struct);
					PointerCache.variable_Variable_zdor9mc = (nint)ptr;
				}
				return (Struct*)PointerCache.variable_Variable_zdor9mc;
			}
		}
	}

	[MangledName("??_R4bad_alloc@std@@6B@")]
	[DemangledName("const std::bad_alloc::`RTTI Complete Object Locator'")]
	public unsafe static rtti_CompleteObjectLocator* R4bad_alloc
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_R4bad_alloc == IntPtr.Zero)
				{
					rtti_CompleteObjectLocator* ptr = (rtti_CompleteObjectLocator*)Marshal.AllocHGlobal(sizeof(rtti_CompleteObjectLocator));
					*ptr = default(rtti_CompleteObjectLocator);
					PointerCache.variable_R4bad_alloc = (nint)ptr;
				}
				return (rtti_CompleteObjectLocator*)PointerCache.variable_R4bad_alloc;
			}
		}
	}

	[MangledName("")]
	[CleanName("Variable")]
	public unsafe static Struct* Variable_x4f2ufc
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_Variable_x4f2ufc == IntPtr.Zero)
				{
					Struct* ptr = (Struct*)Marshal.AllocHGlobal(sizeof(Struct));
					*ptr = default(Struct);
					PointerCache.variable_Variable_x4f2ufc = (nint)ptr;
				}
				return (Struct*)PointerCache.variable_Variable_x4f2ufc;
			}
		}
	}

	[MangledName("??_R4exception@std@@6B@")]
	[DemangledName("const std::exception::`RTTI Complete Object Locator'")]
	public unsafe static rtti_CompleteObjectLocator* R4exception
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_R4exception == IntPtr.Zero)
				{
					rtti_CompleteObjectLocator* ptr = (rtti_CompleteObjectLocator*)Marshal.AllocHGlobal(sizeof(rtti_CompleteObjectLocator));
					*ptr = default(rtti_CompleteObjectLocator);
					PointerCache.variable_R4exception = (nint)ptr;
				}
				return (rtti_CompleteObjectLocator*)PointerCache.variable_R4exception;
			}
		}
	}

	[MangledName("??_C@_0BC@EOODALEL@Unknown?5exception?$AA@")]
	[DemangledName("\"Unknown exception\"")]
	[CleanName("String")]
	public unsafe static InlineArray_18_w3otm9c* String_ja3ma5d
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_ja3ma5d == IntPtr.Zero)
				{
					InlineArray_18_w3otm9c* ptr = (InlineArray_18_w3otm9c*)Marshal.AllocHGlobal(sizeof(InlineArray_18_w3otm9c));
					*ptr = default(InlineArray_18_w3otm9c);
					PointerCache.variable_String_ja3ma5d = (nint)ptr;
				}
				return (InlineArray_18_w3otm9c*)PointerCache.variable_String_ja3ma5d;
			}
		}
	}

	[MangledName("?g_defl_packed_code_size_syms_swizzle@fpng@@3PAEA")]
	[DemangledName("unsigned char *fpng::g_defl_packed_code_size_syms_swizzle")]
	public unsafe static InlineArray_19_w3otm9c* g_defl_packed_code_size_syms_swizzle
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_g_defl_packed_code_size_syms_swizzle == IntPtr.Zero)
				{
					InlineArray_19_w3otm9c* ptr = (InlineArray_19_w3otm9c*)Marshal.AllocHGlobal(sizeof(InlineArray_19_w3otm9c));
					*ptr = default(InlineArray_19_w3otm9c);
					PointerCache.variable_g_defl_packed_code_size_syms_swizzle = (nint)ptr;
				}
				return (InlineArray_19_w3otm9c*)PointerCache.variable_g_defl_packed_code_size_syms_swizzle;
			}
		}
	}

	[MangledName("??_C@_1DO@PIFJFOL@?$AAc?$AAo?$AAd?$AAe?$AA?5?$AA?$DM?$AA?5?$AAD?$AAE?$AAF?$AAL?$AA_?$AAM?$AAA?$AAX?$AA_?$AAH?$AAU?$AAF?$AAF?$AA_?$AAS?$AAY?$AAM?$AAB?$AAO?$AAL?$AAS?$AA_?$AA2?$AA?$AA@")]
	[DemangledName("L\"code < DEFL_MAX_HUFF_SYMBOLS_2\"")]
	[CleanName("String")]
	public unsafe static InlineArray_31_oeds4ea* String_erkdsbd
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_erkdsbd == IntPtr.Zero)
				{
					InlineArray_31_oeds4ea* ptr = (InlineArray_31_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_31_oeds4ea));
					*ptr = default(InlineArray_31_oeds4ea);
					PointerCache.variable_String_erkdsbd = (nint)ptr;
				}
				return (InlineArray_31_oeds4ea*)PointerCache.variable_String_erkdsbd;
			}
		}
	}

	[MangledName("??_C@_03DJLFMAPG@?$AC?$AD?$AH?$AA@")]
	[DemangledName("\"\\x02\\x03\\a\"")]
	[CleanName("String")]
	public unsafe static InlineArray_4_w3otm9c* String_o9ulvgb
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_o9ulvgb == IntPtr.Zero)
				{
					InlineArray_4_w3otm9c* ptr = (InlineArray_4_w3otm9c*)Marshal.AllocHGlobal(sizeof(InlineArray_4_w3otm9c));
					*ptr = default(InlineArray_4_w3otm9c);
					PointerCache.variable_String_o9ulvgb = (nint)ptr;
				}
				return (InlineArray_4_w3otm9c*)PointerCache.variable_String_o9ulvgb;
			}
		}
	}

	[MangledName("?g_dyn_huff_3@fpng@@3QBEB")]
	[DemangledName("unsigned char const *const fpng::g_dyn_huff_3")]
	public unsafe static InlineArray_62_w3otm9c* g_dyn_huff_3
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_g_dyn_huff_3 == IntPtr.Zero)
				{
					InlineArray_62_w3otm9c* ptr = (InlineArray_62_w3otm9c*)Marshal.AllocHGlobal(sizeof(InlineArray_62_w3otm9c));
					*ptr = default(InlineArray_62_w3otm9c);
					PointerCache.variable_g_dyn_huff_3 = (nint)ptr;
				}
				return (InlineArray_62_w3otm9c*)PointerCache.variable_g_dyn_huff_3;
			}
		}
	}

	[MangledName("?g_dyn_huff_3_codes@fpng@@3QBU<unnamed-type-g_dyn_huff_3_codes>@1@B")]
	[DemangledName("struct fpng::<unnamed-type-g_dyn_huff_3_codes> const *const fpng::g_dyn_huff_3_codes")]
	public unsafe static InlineArray_288_chfa5zb* g_dyn_huff_3_codes
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_g_dyn_huff_3_codes == IntPtr.Zero)
				{
					InlineArray_288_chfa5zb* ptr = (InlineArray_288_chfa5zb*)Marshal.AllocHGlobal(sizeof(InlineArray_288_chfa5zb));
					*ptr = default(InlineArray_288_chfa5zb);
					PointerCache.variable_g_dyn_huff_3_codes = (nint)ptr;
				}
				return (InlineArray_288_chfa5zb*)PointerCache.variable_g_dyn_huff_3_codes;
			}
		}
	}

	[MangledName("?g_dyn_huff_4@fpng@@3QBEB")]
	[DemangledName("unsigned char const *const fpng::g_dyn_huff_4")]
	public unsafe static InlineArray_61_w3otm9c* g_dyn_huff_4
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_g_dyn_huff_4 == IntPtr.Zero)
				{
					InlineArray_61_w3otm9c* ptr = (InlineArray_61_w3otm9c*)Marshal.AllocHGlobal(sizeof(InlineArray_61_w3otm9c));
					*ptr = default(InlineArray_61_w3otm9c);
					PointerCache.variable_g_dyn_huff_4 = (nint)ptr;
				}
				return (InlineArray_61_w3otm9c*)PointerCache.variable_g_dyn_huff_4;
			}
		}
	}

	[MangledName("?g_dyn_huff_4_codes@fpng@@3QBU<unnamed-type-g_dyn_huff_4_codes>@1@B")]
	[DemangledName("struct fpng::<unnamed-type-g_dyn_huff_4_codes> const *const fpng::g_dyn_huff_4_codes")]
	public unsafe static InlineArray_288_mcnvamb* g_dyn_huff_4_codes
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_g_dyn_huff_4_codes == IntPtr.Zero)
				{
					InlineArray_288_mcnvamb* ptr = (InlineArray_288_mcnvamb*)Marshal.AllocHGlobal(sizeof(InlineArray_288_mcnvamb));
					*ptr = default(InlineArray_288_mcnvamb);
					PointerCache.variable_g_dyn_huff_4_codes = (nint)ptr;
				}
				return (InlineArray_288_mcnvamb*)PointerCache.variable_g_dyn_huff_4_codes;
			}
		}
	}

	[MangledName("?s_png_sig@?1??fpng_get_info_internal@fpng@@YAHPEBXIAEAI1111@Z@4QBEB")]
	[DemangledName("unsigned char const *const `int __cdecl fpng::fpng_get_info_internal(void const *, unsigned int, unsigned int &, unsigned int &, unsigned int &, unsigned int &, unsigned int &)'::`2'::s_png_sig")]
	public unsafe static InlineArray_8_w3otm9c* s_png_sig
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_s_png_sig == IntPtr.Zero)
				{
					InlineArray_8_w3otm9c* ptr = (InlineArray_8_w3otm9c*)Marshal.AllocHGlobal(sizeof(InlineArray_8_w3otm9c));
					*ptr = default(InlineArray_8_w3otm9c);
					PointerCache.variable_s_png_sig = (nint)ptr;
				}
				return (InlineArray_8_w3otm9c*)PointerCache.variable_s_png_sig;
			}
		}
	}

	[MangledName("??_C@_04NHMHICBH@IDAT?$AA@")]
	[DemangledName("\"IDAT\"")]
	[CleanName("String")]
	public unsafe static InlineArray_5_w3otm9c* String_qjc9xdd
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_qjc9xdd == IntPtr.Zero)
				{
					InlineArray_5_w3otm9c* ptr = (InlineArray_5_w3otm9c*)Marshal.AllocHGlobal(sizeof(InlineArray_5_w3otm9c));
					*ptr = default(InlineArray_5_w3otm9c);
					PointerCache.variable_String_qjc9xdd = (nint)ptr;
				}
				return (InlineArray_5_w3otm9c*)PointerCache.variable_String_qjc9xdd;
			}
		}
	}

	[MangledName("??_C@_04COOFLABO@IEND?$AA@")]
	[DemangledName("\"IEND\"")]
	[CleanName("String")]
	public unsafe static InlineArray_5_w3otm9c* String_p7olgfc
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_p7olgfc == IntPtr.Zero)
				{
					InlineArray_5_w3otm9c* ptr = (InlineArray_5_w3otm9c*)Marshal.AllocHGlobal(sizeof(InlineArray_5_w3otm9c));
					*ptr = default(InlineArray_5_w3otm9c);
					PointerCache.variable_String_p7olgfc = (nint)ptr;
				}
				return (InlineArray_5_w3otm9c*)PointerCache.variable_String_p7olgfc;
			}
		}
	}

	[MangledName("??_C@_04DGOOLJLG@fdEC?$AA@")]
	[DemangledName("\"fdEC\"")]
	[CleanName("String")]
	public unsafe static InlineArray_5_w3otm9c* String_22lii4a
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_22lii4a == IntPtr.Zero)
				{
					InlineArray_5_w3otm9c* ptr = (InlineArray_5_w3otm9c*)Marshal.AllocHGlobal(sizeof(InlineArray_5_w3otm9c));
					*ptr = default(InlineArray_5_w3otm9c);
					PointerCache.variable_String_22lii4a = (nint)ptr;
				}
				return (InlineArray_5_w3otm9c*)PointerCache.variable_String_22lii4a;
			}
		}
	}

	[MangledName("??_C@_1DE@LOJFIBNB@?$AAs?$AAr?$AAc?$AA_?$AAl?$AAe?$AAn?$AA?5?$AA?$DO?$AA?$DN?$AA?5?$AA?$CI?$AAz?$AAl?$AAi?$AAb?$AA_?$AAl?$AAe?$AAn?$AA?5?$AA?$CL?$AA?5?$AA4?$AA?$CJ?$AA?$AA@")]
	[DemangledName("L\"src_len >= (zlib_len + 4)\"")]
	[CleanName("String")]
	public unsafe static InlineArray_26_oeds4ea* String_497patd
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_497patd == IntPtr.Zero)
				{
					InlineArray_26_oeds4ea* ptr = (InlineArray_26_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_26_oeds4ea));
					*ptr = default(InlineArray_26_oeds4ea);
					PointerCache.variable_String_497patd = (nint)ptr;
				}
				return (InlineArray_26_oeds4ea*)PointerCache.variable_String_497patd;
			}
		}
	}

	[MangledName("??_C@_1BO@DPMPJCNO@?$AAl?$AA?5?$AA?$CG?$AA?$CG?$AA?5?$AA?$CI?$AAl?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AA3?$AA2?$AA?$CJ?$AA?$AA@")]
	[DemangledName("L\"l && (l <= 32)\"")]
	[CleanName("String")]
	public unsafe static InlineArray_15_oeds4ea* String_aa3exrc
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_aa3exrc == IntPtr.Zero)
				{
					InlineArray_15_oeds4ea* ptr = (InlineArray_15_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_15_oeds4ea));
					*ptr = default(InlineArray_15_oeds4ea);
					PointerCache.variable_String_aa3exrc = (nint)ptr;
				}
				return (InlineArray_15_oeds4ea*)PointerCache.variable_String_aa3exrc;
			}
		}
	}

	[MangledName("??_C@_1FA@PEENLMBD@?$AAb?$AAi?$AAt?$AA_?$AAb?$AAu?$AAf?$AA_?$AAs?$AAi?$AAz?$AAe?$AA?5?$AA?$DO?$AA?$DN?$AA?5?$AAF?$AAP?$AAN?$AAG?$AA_?$AAD?$AAE?$AAC?$AAO?$AAD?$AAE?$AAR?$AA_?$AAT?$AAA?$AAB@")]
	[DemangledName("L\"bit_buf_size >= FPNG_DECODER_TAB\"...")]
	[CleanName("String")]
	public unsafe static InlineArray_40_oeds4ea* String_ktv524d
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_ktv524d == IntPtr.Zero)
				{
					InlineArray_40_oeds4ea* ptr = (InlineArray_40_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_40_oeds4ea));
					*ptr = default(InlineArray_40_oeds4ea);
					PointerCache.variable_String_ktv524d = (nint)ptr;
				}
				return (InlineArray_40_oeds4ea*)PointerCache.variable_String_ktv524d;
			}
		}
	}

	[MangledName("??_C@_1BA@ONNHMHEP@?$AAl?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AA3?$AA2?$AA?$AA@")]
	[DemangledName("L\"l <= 32\"")]
	[CleanName("String")]
	public unsafe static InlineArray_8_oeds4ea* String_mf9hyza
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_mf9hyza == IntPtr.Zero)
				{
					InlineArray_8_oeds4ea* ptr = (InlineArray_8_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_8_oeds4ea));
					*ptr = default(InlineArray_8_oeds4ea);
					PointerCache.variable_String_mf9hyza = (nint)ptr;
				}
				return (InlineArray_8_oeds4ea*)PointerCache.variable_String_mf9hyza;
			}
		}
	}

	[MangledName("?s_length_range@fpng@@3QBHB")]
	[DemangledName("int const *const fpng::s_length_range")]
	public unsafe static InlineArray_31_vqkfj7a* s_length_range
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_s_length_range == IntPtr.Zero)
				{
					InlineArray_31_vqkfj7a* ptr = (InlineArray_31_vqkfj7a*)Marshal.AllocHGlobal(sizeof(InlineArray_31_vqkfj7a));
					*ptr = default(InlineArray_31_vqkfj7a);
					PointerCache.variable_s_length_range = (nint)ptr;
				}
				return (InlineArray_31_vqkfj7a*)PointerCache.variable_s_length_range;
			}
		}
	}

	[MangledName("?s_length_extra@fpng@@3QBHB")]
	[DemangledName("int const *const fpng::s_length_extra")]
	public unsafe static InlineArray_31_vqkfj7a* s_length_extra
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_s_length_extra == IntPtr.Zero)
				{
					InlineArray_31_vqkfj7a* ptr = (InlineArray_31_vqkfj7a*)Marshal.AllocHGlobal(sizeof(InlineArray_31_vqkfj7a));
					*ptr = default(InlineArray_31_vqkfj7a);
					PointerCache.variable_s_length_extra = (nint)ptr;
				}
				return (InlineArray_31_vqkfj7a*)PointerCache.variable_s_length_extra;
			}
		}
	}

	[MangledName("??_C@_1EM@LNFOKHHI@?$AAl?$AA?5?$AA?$CG?$AA?$CG?$AA?5?$AA?$CI?$AAl?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AA3?$AA2?$AA?$CJ?$AA?5?$AA?$CG?$AA?$CG?$AA?5?$AA?$CI?$AAb?$AAi?$AAt?$AA_?$AAb?$AAu?$AAf?$AA_?$AAs?$AAi?$AAz?$AAe?$AA?5@")]
	[DemangledName("L\"l && (l <= 32) && (bit_buf_size \"...")]
	[CleanName("String")]
	public unsafe static InlineArray_38_oeds4ea* String_ftb25bb
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_ftb25bb == IntPtr.Zero)
				{
					InlineArray_38_oeds4ea* ptr = (InlineArray_38_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_38_oeds4ea));
					*ptr = default(InlineArray_38_oeds4ea);
					PointerCache.variable_String_ftb25bb = (nint)ptr;
				}
				return (InlineArray_38_oeds4ea*)PointerCache.variable_String_ftb25bb;
			}
		}
	}

	[MangledName("??_C@_1DO@GINGNLCO@?$AAl?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AA3?$AA2?$AA?5?$AA?$CG?$AA?$CG?$AA?5?$AA?$CI?$AAb?$AAi?$AAt?$AA_?$AAb?$AAu?$AAf?$AA_?$AAs?$AAi?$AAz?$AAe?$AA?5?$AA?$DO?$AA?$DN?$AA?5?$AAl?$AA?$CJ?$AA?$AA@")]
	[DemangledName("L\"l <= 32 && (bit_buf_size >= l)\"")]
	[CleanName("String")]
	public unsafe static InlineArray_31_oeds4ea* String_bahgbqd
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_bahgbqd == IntPtr.Zero)
				{
					InlineArray_31_oeds4ea* ptr = (InlineArray_31_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_31_oeds4ea));
					*ptr = default(InlineArray_31_oeds4ea);
					PointerCache.variable_String_bahgbqd = (nint)ptr;
				}
				return (InlineArray_31_oeds4ea*)PointerCache.variable_String_bahgbqd;
			}
		}
	}

	[MangledName("??_C@_1CG@ELPAFFDG@?$AA?$CI?$AAr?$AAu?$AAn?$AA_?$AAl?$AAe?$AAn?$AA?5?$AA?$CF?$AA?5?$AA3?$AA?$CJ?$AA?5?$AA?$DN?$AA?$DN?$AA?5?$AA0?$AA?$AA@")]
	[DemangledName("L\"(run_len % 3) == 0\"")]
	[CleanName("String")]
	public unsafe static InlineArray_19_oeds4ea* String_a5rp7bb
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_a5rp7bb == IntPtr.Zero)
				{
					InlineArray_19_oeds4ea* ptr = (InlineArray_19_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_19_oeds4ea));
					*ptr = default(InlineArray_19_oeds4ea);
					PointerCache.variable_String_a5rp7bb = (nint)ptr;
				}
				return (InlineArray_19_oeds4ea*)PointerCache.variable_String_a5rp7bb;
			}
		}
	}

	[MangledName("?g_run_len3_to_4@fpng@@3QBGB")]
	[DemangledName("unsigned short const *const fpng::g_run_len3_to_4")]
	public unsafe static InlineArray_259_oeds4ea* g_run_len3_to_4
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_g_run_len3_to_4 == IntPtr.Zero)
				{
					InlineArray_259_oeds4ea* ptr = (InlineArray_259_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_259_oeds4ea));
					*ptr = default(InlineArray_259_oeds4ea);
					PointerCache.variable_g_run_len3_to_4 = (nint)ptr;
				}
				return (InlineArray_259_oeds4ea*)PointerCache.variable_g_run_len3_to_4;
			}
		}
	}

	[MangledName("??_C@_1EK@NPDOIFAN@?$AA?$CI?$AAs?$AAr?$AAc?$AA_?$AAc?$AAh?$AAa?$AAn?$AAs?$AA?5?$AA?$DN?$AA?$DN?$AA?5?$AA3?$AA?$CJ?$AA?5?$AA?$HM?$AA?$HM?$AA?5?$AA?$CI?$AAs?$AAr?$AAc?$AA_?$AAc?$AAh?$AAa?$AAn?$AAs?$AA?5?$AA?$DN@")]
	[DemangledName("L\"(src_chans == 3) || (src_chans =\"...")]
	[CleanName("String")]
	public unsafe static InlineArray_37_oeds4ea* String_zixkhbc
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_zixkhbc == IntPtr.Zero)
				{
					InlineArray_37_oeds4ea* ptr = (InlineArray_37_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_37_oeds4ea));
					*ptr = default(InlineArray_37_oeds4ea);
					PointerCache.variable_String_zixkhbc = (nint)ptr;
				}
				return (InlineArray_37_oeds4ea*)PointerCache.variable_String_zixkhbc;
			}
		}
	}

	[MangledName("??_C@_1EK@BJMGPLPL@?$AA?$CI?$AAd?$AAs?$AAt?$AA_?$AAc?$AAh?$AAa?$AAn?$AAs?$AA?5?$AA?$DN?$AA?$DN?$AA?5?$AA3?$AA?$CJ?$AA?5?$AA?$HM?$AA?$HM?$AA?5?$AA?$CI?$AAd?$AAs?$AAt?$AA_?$AAc?$AAh?$AAa?$AAn?$AAs?$AA?5?$AA?$DN@")]
	[DemangledName("L\"(dst_chans == 3) || (dst_chans =\"...")]
	[CleanName("String")]
	public unsafe static InlineArray_37_oeds4ea* String_kppxlqc
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_kppxlqc == IntPtr.Zero)
				{
					InlineArray_37_oeds4ea* ptr = (InlineArray_37_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_37_oeds4ea));
					*ptr = default(InlineArray_37_oeds4ea);
					PointerCache.variable_String_kppxlqc = (nint)ptr;
				}
				return (InlineArray_37_oeds4ea*)PointerCache.variable_String_kppxlqc;
			}
		}
	}

	[MangledName("??_C@_1BE@MMMJACNB@?$AA?$CB?$AAc?$AAo?$AAm?$AAp?$AA_?$AAo?$AAf?$AAs?$AA?$AA@")]
	[DemangledName("L\"!comp_ofs\"")]
	[CleanName("String")]
	public unsafe static InlineArray_10_oeds4ea* String_ji2h3xd
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_ji2h3xd == IntPtr.Zero)
				{
					InlineArray_10_oeds4ea* ptr = (InlineArray_10_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_10_oeds4ea));
					*ptr = default(InlineArray_10_oeds4ea);
					PointerCache.variable_String_ji2h3xd = (nint)ptr;
				}
				return (InlineArray_10_oeds4ea*)PointerCache.variable_String_ji2h3xd;
			}
		}
	}

	[MangledName("?s_bit_length_order@?1??prepare_dynamic_block@fpng@@YA_NPEBEIAEAI1AEA_KPEAII@Z@4QBEB")]
	[DemangledName("unsigned char const *const `bool __cdecl fpng::prepare_dynamic_block(unsigned char const *, unsigned int, unsigned int &, unsigned int &, unsigned __int64 &, unsigned int *, unsigned int)'::`2'::s_bit_length_order")]
	public unsafe static InlineArray_19_w3otm9c* s_bit_length_order
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_s_bit_length_order == IntPtr.Zero)
				{
					InlineArray_19_w3otm9c* ptr = (InlineArray_19_w3otm9c*)Marshal.AllocHGlobal(sizeof(InlineArray_19_w3otm9c));
					*ptr = default(InlineArray_19_w3otm9c);
					PointerCache.variable_s_bit_length_order = (nint)ptr;
				}
				return (InlineArray_19_w3otm9c*)PointerCache.variable_s_bit_length_order;
			}
		}
	}

	[MangledName("??_C@_1EI@CMIKALPF@?$AAs?$AAy?$AAm?$AA_?$AAb?$AAi?$AAt?$AAs?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AAF?$AAP?$AAN?$AAG?$AA_?$AAD?$AAE?$AAC?$AAO?$AAD?$AAE?$AAR?$AA_?$AAT?$AAA?$AAB?$AAL?$AAE?$AA_?$AAB@")]
	[DemangledName("L\"sym_bits <= FPNG_DECODER_TABLE_B\"...")]
	[CleanName("String")]
	public unsafe static InlineArray_36_oeds4ea* String_nlshwsc
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_nlshwsc == IntPtr.Zero)
				{
					InlineArray_36_oeds4ea* ptr = (InlineArray_36_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_36_oeds4ea));
					*ptr = default(InlineArray_36_oeds4ea);
					PointerCache.variable_String_nlshwsc = (nint)ptr;
				}
				return (InlineArray_36_oeds4ea*)PointerCache.variable_String_nlshwsc;
			}
		}
	}

	[MangledName("??_C@_1FE@PPLLBMKL@?$AAp?$AAC?$AAo?$AAd?$AAe?$AA_?$AAs?$AAi?$AAz?$AAe?$AAs?$AA?$FL?$AAi?$AA?$FN?$AA?5?$AA?$DM?$AA?$DN?$AA?5?$AAF?$AAP?$AAN?$AAG?$AA_?$AAD?$AAE?$AAC?$AAO?$AAD?$AAE?$AAR?$AA_?$AAT@")]
	[DemangledName("L\"pCode_sizes[i] <= FPNG_DECODER_T\"...")]
	[CleanName("String")]
	public unsafe static InlineArray_42_oeds4ea* String_32otbnd
	{
		get
		{
			unchecked
			{
				if (PointerCache.variable_String_32otbnd == IntPtr.Zero)
				{
					InlineArray_42_oeds4ea* ptr = (InlineArray_42_oeds4ea*)Marshal.AllocHGlobal(sizeof(InlineArray_42_oeds4ea));
					*ptr = default(InlineArray_42_oeds4ea);
					PointerCache.variable_String_32otbnd = (nint)ptr;
				}
				return (InlineArray_42_oeds4ea*)PointerCache.variable_String_32otbnd;
			}
		}
	}

	static GlobalVariablePointers()
	{
		GlobalVariableInitializers.Initialize_Avx2WmemEnabledWeakValue();
		GlobalVariableInitializers.Initialize_String_uxbkrtb();
		GlobalVariableInitializers.Initialize_String_kdrammb();
		GlobalVariableInitializers.Initialize_String_bik4erc();
		GlobalVariableInitializers.Initialize_String_dqvhqxc();
		GlobalVariableInitializers.Initialize_s_color_type();
		GlobalVariableInitializers.Initialize_String_nz3h57a();
		GlobalVariableInitializers.Initialize_g_crc32_4();
		GlobalVariableInitializers.Initialize_String_uc52kza();
		GlobalVariableInitializers.Initialize_String_9hewgtd();
		GlobalVariableInitializers.Initialize_String_ooiduua();
		GlobalVariableInitializers.Initialize_String_mggwlgb();
		GlobalVariableInitializers.Initialize_g_defl_len_sym();
		GlobalVariableInitializers.Initialize_String_bjvsuxc();
		GlobalVariableInitializers.Initialize_String_hsgehfc();
		GlobalVariableInitializers.Initialize_String_vpte4cc();
		GlobalVariableInitializers.Initialize_String_df5ko9b();
		GlobalVariableInitializers.Initialize_String_isj2lib();
		GlobalVariableInitializers.Initialize_g_bitmasks();
		GlobalVariableInitializers.Initialize_g_defl_len_extra();
		GlobalVariableInitializers.Initialize_String_2ej5tjb();
		GlobalVariableInitializers.Initialize_String_7b7kt9c();
		GlobalVariableInitializers.Initialize_R0_AVbad_array_new_length();
		GlobalVariableInitializers.Initialize_CT_R0_AVbad_array_new_length_std_8_0bad_array_new_length_std_QEAA_AEBV01_Z24();
		GlobalVariableInitializers.Initialize_R0_AVbad_alloc();
		GlobalVariableInitializers.Initialize_CT_R0_AVbad_alloc_std_8_0bad_alloc_std_QEAA_AEBV01_Z24();
		GlobalVariableInitializers.Initialize_R0_AVexception();
		GlobalVariableInitializers.Initialize_CT_R0_AVexception_std_8_0exception_std_QEAA_AEBV01_Z24();
		GlobalVariableInitializers.Initialize_CTA3_AVbad_array_new_length_std();
		GlobalVariableInitializers.Initialize_TI3_AVbad_array_new_length_std();
		GlobalVariableInitializers.Initialize_String_gudorqc();
		GlobalVariableInitializers.Initialize_Variable_4yxjuqa();
		GlobalVariableInitializers.Initialize_R4bad_array_new_length();
		GlobalVariableInitializers.Initialize_R3bad_array_new_length();
		GlobalVariableInitializers.Initialize_R2bad_array_new_length();
		GlobalVariableInitializers.Initialize_R1A_9w7p7zd();
		GlobalVariableInitializers.Initialize_R1A_vzsilob();
		GlobalVariableInitializers.Initialize_R3bad_alloc();
		GlobalVariableInitializers.Initialize_R2bad_alloc();
		GlobalVariableInitializers.Initialize_R1A_bbqer2a();
		GlobalVariableInitializers.Initialize_R3exception();
		GlobalVariableInitializers.Initialize_R2exception();
		GlobalVariableInitializers.Initialize_Variable_zdor9mc();
		GlobalVariableInitializers.Initialize_R4bad_alloc();
		GlobalVariableInitializers.Initialize_Variable_x4f2ufc();
		GlobalVariableInitializers.Initialize_R4exception();
		GlobalVariableInitializers.Initialize_String_ja3ma5d();
		GlobalVariableInitializers.Initialize_g_defl_packed_code_size_syms_swizzle();
		GlobalVariableInitializers.Initialize_String_erkdsbd();
		GlobalVariableInitializers.Initialize_String_o9ulvgb();
		GlobalVariableInitializers.Initialize_g_dyn_huff_3();
		GlobalVariableInitializers.Initialize_g_dyn_huff_3_codes();
		GlobalVariableInitializers.Initialize_g_dyn_huff_4();
		GlobalVariableInitializers.Initialize_g_dyn_huff_4_codes();
		GlobalVariableInitializers.Initialize_s_png_sig();
		GlobalVariableInitializers.Initialize_String_qjc9xdd();
		GlobalVariableInitializers.Initialize_String_p7olgfc();
		GlobalVariableInitializers.Initialize_String_22lii4a();
		GlobalVariableInitializers.Initialize_String_497patd();
		GlobalVariableInitializers.Initialize_String_aa3exrc();
		GlobalVariableInitializers.Initialize_String_ktv524d();
		GlobalVariableInitializers.Initialize_String_mf9hyza();
		GlobalVariableInitializers.Initialize_s_length_range();
		GlobalVariableInitializers.Initialize_s_length_extra();
		GlobalVariableInitializers.Initialize_String_ftb25bb();
		GlobalVariableInitializers.Initialize_String_bahgbqd();
		GlobalVariableInitializers.Initialize_String_a5rp7bb();
		GlobalVariableInitializers.Initialize_g_run_len3_to_4();
		GlobalVariableInitializers.Initialize_String_zixkhbc();
		GlobalVariableInitializers.Initialize_String_kppxlqc();
		GlobalVariableInitializers.Initialize_String_ji2h3xd();
		GlobalVariableInitializers.Initialize_s_bit_length_order();
		GlobalVariableInitializers.Initialize_String_nlshwsc();
		GlobalVariableInitializers.Initialize_String_32otbnd();
	}
}
