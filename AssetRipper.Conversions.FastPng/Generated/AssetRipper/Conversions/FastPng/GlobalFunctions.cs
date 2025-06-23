namespace AssetRipper.Conversions.FastPng;

public static partial class GlobalFunctions
{
	[MangledName("?fpng_init@fpng@@YAXXZ")]
	[DemangledName("void __cdecl fpng::fpng_init(void)")]
	public static void fpng_init()
	{
		GlobalFunctionImplementations.fpng_init();
	}

	[MangledName("?fpng_cpu_supports_sse41@fpng@@YA_NXZ")]
	[DemangledName("bool __cdecl fpng::fpng_cpu_supports_sse41(void)")]
	public static bool fpng_cpu_supports_sse41()
	{
		return GlobalFunctionImplementations.fpng_cpu_supports_sse41();
	}

	[MangledName("?fpng_crc32@fpng@@YAIPEBX_KI@Z")]
	[DemangledName("unsigned int __cdecl fpng::fpng_crc32(void const *, unsigned __int64, unsigned int)")]
	public unsafe static int fpng_crc32(void* P_0, long P_1, int P_2)
	{
		return GlobalFunctionImplementations.fpng_crc32(P_0, P_1, P_2);
	}

	[MangledName("?crc32_slice_by_4@fpng@@YAIPEBX_KI@Z")]
	[DemangledName("unsigned int __cdecl fpng::crc32_slice_by_4(void const *, unsigned __int64, unsigned int)")]
	public unsafe static int crc32_slice_by_4(void* P_0, long P_1, int P_2)
	{
		return GlobalFunctionImplementations.crc32_slice_by_4(P_0, P_1, P_2);
	}

	[MangledName("?fpng_adler32@fpng@@YAIPEBX_KI@Z")]
	[DemangledName("unsigned int __cdecl fpng::fpng_adler32(void const *, unsigned __int64, unsigned int)")]
	public unsafe static int fpng_adler32(void* P_0, long P_1, int P_2)
	{
		return GlobalFunctionImplementations.fpng_adler32(P_0, P_1, P_2);
	}

	[MangledName("?fpng_adler32_scalar@fpng@@YAIPEBE_KI@Z")]
	[DemangledName("unsigned int __cdecl fpng::fpng_adler32_scalar(unsigned char const *, unsigned __int64, unsigned int)")]
	public unsafe static int fpng_adler32_scalar(void* P_0, long P_1, int P_2)
	{
		return GlobalFunctionImplementations.fpng_adler32_scalar(P_0, P_1, P_2);
	}

	[MangledName("?fpng_encode_image_to_memory@fpng@@YA_NPEBXIIIAEAV?$vector@EV?$allocator@E@std@@@std@@I@Z")]
	[DemangledName("bool __cdecl fpng::fpng_encode_image_to_memory(void const *, unsigned int, unsigned int, unsigned int, class std::vector<unsigned char, class std::allocator<unsigned char>> &, unsigned int)")]
	public unsafe static bool fpng_encode_image_to_memory(void* P_0, int P_1, int P_2, int P_3, void* P_4, int P_5)
	{
		bool result = GlobalFunctionImplementations.fpng_encode_image_to_memory(P_0, P_1, P_2, P_3, P_4, P_5);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?endian_check@fpng@@YA_NXZ")]
	[DemangledName("bool __cdecl fpng::endian_check(void)")]
	public static bool endian_check()
	{
		return GlobalFunctionImplementations.endian_check();
	}

	[MangledName("??0?$vector@EV?$allocator@E@std@@@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::vector<unsigned char, class std::allocator<unsigned char>>(void)")]
	public unsafe static void* vector_unsigned_char_class_std_allocator_unsigned_char_Constructor(void* P_0)
	{
		return GlobalFunctionImplementations.vector_unsigned_char_class_std_allocator_unsigned_char_Constructor(P_0);
	}

	[MangledName("?resize@?$vector@EV?$allocator@E@std@@@std@@QEAAX_K@Z")]
	[DemangledName("public: void __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::resize(unsigned __int64)")]
	[CleanName("resize")]
	public unsafe static void resize_wwmwtsa(void* P_0, long P_1)
	{
		GlobalFunctionImplementations.resize_wwmwtsa(P_0, P_1);
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??A?$vector@EV?$allocator@E@std@@@std@@QEAAAEAE_K@Z")]
	[DemangledName("public: unsigned char & __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::operator[](unsigned __int64)")]
	[CleanName("operator")]
	public unsafe static void* operator_zukzlzc(void* P_0, long P_1)
	{
		return GlobalFunctionImplementations.operator_zukzlzc(P_0, P_1);
	}

	[MangledName("?apply_filter@fpng@@YAXIHHIIPEBE0PEAE@Z")]
	[DemangledName("void __cdecl fpng::apply_filter(unsigned int, int, int, unsigned int, unsigned int, unsigned char const *, unsigned char const *, unsigned char *)")]
	public unsafe static void apply_filter(int P_0, int P_1, int P_2, int P_3, int P_4, void* P_5, void* P_6, void* P_7)
	{
		GlobalFunctionImplementations.apply_filter(P_0, P_1, P_2, P_3, P_4, P_5, P_6, P_7);
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?pixel_deflate_dyn_3_rle@fpng@@YAIPEBEIIPEAEI@Z")]
	[DemangledName("unsigned int __cdecl fpng::pixel_deflate_dyn_3_rle(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int)")]
	public unsafe static int pixel_deflate_dyn_3_rle(void* P_0, int P_1, int P_2, void* P_3, int P_4)
	{
		int result = GlobalFunctionImplementations.pixel_deflate_dyn_3_rle(P_0, P_1, P_2, P_3, P_4);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?size@?$vector@EV?$allocator@E@std@@@std@@QEBA_KXZ")]
	[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::size(void) const")]
	[CleanName("size")]
	public unsafe static long size_4io4p4d(void* P_0)
	{
		return GlobalFunctionImplementations.size_4io4p4d(P_0);
	}

	[MangledName("?data@?$vector@EV?$allocator@E@std@@@std@@QEAAPEAEXZ")]
	[DemangledName("public: unsigned char * __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::data(void)")]
	[CleanName("data")]
	public unsafe static void* data_efhnzgd(void* P_0)
	{
		return GlobalFunctionImplementations.data_efhnzgd(P_0);
	}

	[MangledName("?pixel_deflate_dyn_3_rle_one_pass@fpng@@YAIPEBEIIPEAEI@Z")]
	[DemangledName("unsigned int __cdecl fpng::pixel_deflate_dyn_3_rle_one_pass(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int)")]
	public unsafe static int pixel_deflate_dyn_3_rle_one_pass(void* P_0, int P_1, int P_2, void* P_3, int P_4)
	{
		int result = GlobalFunctionImplementations.pixel_deflate_dyn_3_rle_one_pass(P_0, P_1, P_2, P_3, P_4);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?pixel_deflate_dyn_4_rle@fpng@@YAIPEBEIIPEAEI@Z")]
	[DemangledName("unsigned int __cdecl fpng::pixel_deflate_dyn_4_rle(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int)")]
	public unsafe static int pixel_deflate_dyn_4_rle(void* P_0, int P_1, int P_2, void* P_3, int P_4)
	{
		int result = GlobalFunctionImplementations.pixel_deflate_dyn_4_rle(P_0, P_1, P_2, P_3, P_4);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?pixel_deflate_dyn_4_rle_one_pass@fpng@@YAIPEBEIIPEAEI@Z")]
	[DemangledName("unsigned int __cdecl fpng::pixel_deflate_dyn_4_rle_one_pass(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int)")]
	public unsafe static int pixel_deflate_dyn_4_rle_one_pass(void* P_0, int P_1, int P_2, void* P_3, int P_4)
	{
		int result = GlobalFunctionImplementations.pixel_deflate_dyn_4_rle_one_pass(P_0, P_1, P_2, P_3, P_4);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?write_raw_block@fpng@@YAIPEBEIPEAEI@Z")]
	[DemangledName("unsigned int __cdecl fpng::write_raw_block(unsigned char const *, unsigned int, unsigned char *, unsigned int)")]
	public unsafe static int write_raw_block(void* P_0, int P_1, void* P_2, int P_3)
	{
		return GlobalFunctionImplementations.write_raw_block(P_0, P_1, P_2, P_3);
	}

	[MangledName("?vector_append@fpng@@YAXAEAV?$vector@EV?$allocator@E@std@@@std@@PEBX_K@Z")]
	[DemangledName("void __cdecl fpng::vector_append(class std::vector<unsigned char, class std::allocator<unsigned char>> &, void const *, unsigned __int64)")]
	public unsafe static void vector_append(void* P_0, void* P_1, long P_2)
	{
		GlobalFunctionImplementations.vector_append(P_0, P_1, P_2);
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??1?$vector@EV?$allocator@E@std@@@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::~vector<unsigned char, class std::allocator<unsigned char>>(void)")]
	public unsafe static void vector_unsigned_char_class_std_allocator_unsigned_char_Destructor(void* P_0)
	{
		GlobalFunctionImplementations.vector_unsigned_char_class_std_allocator_unsigned_char_Destructor(P_0);
	}

	[MangledName("?fpng_get_info@fpng@@YAHPEBXIAEAI11@Z")]
	[DemangledName("int __cdecl fpng::fpng_get_info(void const *, unsigned int, unsigned int &, unsigned int &, unsigned int &)")]
	public unsafe static int fpng_get_info(void* P_0, int P_1, void* P_2, void* P_3, void* P_4)
	{
		int result = GlobalFunctionImplementations.fpng_get_info(P_0, P_1, P_2, P_3, P_4);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?fpng_get_info_internal@fpng@@YAHPEBXIAEAI1111@Z")]
	[DemangledName("int __cdecl fpng::fpng_get_info_internal(void const *, unsigned int, unsigned int &, unsigned int &, unsigned int &, unsigned int &, unsigned int &)")]
	public unsafe static int fpng_get_info_internal(void* P_0, int P_1, void* P_2, void* P_3, void* P_4, void* P_5, void* P_6)
	{
		int result = GlobalFunctionImplementations.fpng_get_info_internal(P_0, P_1, P_2, P_3, P_4, P_5, P_6);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?fpng_decode_memory@fpng@@YAHPEBXIAEAV?$vector@EV?$allocator@E@std@@@std@@AEAI22I@Z")]
	[DemangledName("int __cdecl fpng::fpng_decode_memory(void const *, unsigned int, class std::vector<unsigned char, class std::allocator<unsigned char>> &, unsigned int &, unsigned int &, unsigned int &, unsigned int)")]
	public unsafe static int fpng_decode_memory(void* P_0, int P_1, void* P_2, void* P_3, void* P_4, void* P_5, int P_6)
	{
		int result = GlobalFunctionImplementations.fpng_decode_memory(P_0, P_1, P_2, P_3, P_4, P_5, P_6);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$fpng_pixel_zlib_decompress_3@$02@fpng@@YA_NPEBEIIPEAEII@Z")]
	[DemangledName("bool __cdecl fpng::fpng_pixel_zlib_decompress_3<3>(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int, unsigned int)")]
	[CleanName("fpng_pixel_zlib_decompress_3")]
	public unsafe static bool fpng_pixel_zlib_decompress_3_prmnnjb(void* P_0, int P_1, int P_2, void* P_3, int P_4, int P_5)
	{
		bool result = GlobalFunctionImplementations.fpng_pixel_zlib_decompress_3_prmnnjb(P_0, P_1, P_2, P_3, P_4, P_5);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$fpng_pixel_zlib_decompress_4@$02@fpng@@YA_NPEBEIIPEAEII@Z")]
	[DemangledName("bool __cdecl fpng::fpng_pixel_zlib_decompress_4<3>(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int, unsigned int)")]
	[CleanName("fpng_pixel_zlib_decompress_4")]
	public unsafe static bool fpng_pixel_zlib_decompress_4_xygi9td(void* P_0, int P_1, int P_2, void* P_3, int P_4, int P_5)
	{
		bool result = GlobalFunctionImplementations.fpng_pixel_zlib_decompress_4_xygi9td(P_0, P_1, P_2, P_3, P_4, P_5);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$fpng_pixel_zlib_decompress_3@$03@fpng@@YA_NPEBEIIPEAEII@Z")]
	[DemangledName("bool __cdecl fpng::fpng_pixel_zlib_decompress_3<4>(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int, unsigned int)")]
	[CleanName("fpng_pixel_zlib_decompress_3")]
	public unsafe static bool fpng_pixel_zlib_decompress_3_yffw42c(void* P_0, int P_1, int P_2, void* P_3, int P_4, int P_5)
	{
		bool result = GlobalFunctionImplementations.fpng_pixel_zlib_decompress_3_yffw42c(P_0, P_1, P_2, P_3, P_4, P_5);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$fpng_pixel_zlib_decompress_4@$03@fpng@@YA_NPEBEIIPEAEII@Z")]
	[DemangledName("bool __cdecl fpng::fpng_pixel_zlib_decompress_4<4>(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int, unsigned int)")]
	[CleanName("fpng_pixel_zlib_decompress_4")]
	public unsafe static bool fpng_pixel_zlib_decompress_4_amptoaa(void* P_0, int P_1, int P_2, void* P_3, int P_4, int P_5)
	{
		bool result = GlobalFunctionImplementations.fpng_pixel_zlib_decompress_4_amptoaa(P_0, P_1, P_2, P_3, P_4, P_5);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??0?$allocator@I@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::allocator<unsigned int>::allocator<unsigned int>(void)")]
	public unsafe static void* allocator_unsigned_int_Constructor(void* P_0)
	{
		return GlobalFunctionImplementations.allocator_unsigned_int_Constructor(P_0);
	}

	[MangledName("??0?$vector@IV?$allocator@I@std@@@std@@QEAA@_KAEBV?$allocator@I@1@@Z")]
	[DemangledName("public: __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::vector<unsigned int, class std::allocator<unsigned int>>(unsigned __int64, class std::allocator<unsigned int> const &)")]
	public unsafe static void* vector_unsigned_int_class_std_allocator_unsigned_int_Constructor(void* P_0, long P_1, void* P_2)
	{
		void* result = GlobalFunctionImplementations.vector_unsigned_int_class_std_allocator_unsigned_int_Constructor(P_0, P_1, P_2);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?data@?$vector@IV?$allocator@I@std@@@std@@QEAAPEAIXZ")]
	[DemangledName("public: unsigned int * __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::data(void)")]
	[CleanName("data")]
	public unsafe static void* data_uf9yj3b(void* P_0)
	{
		return GlobalFunctionImplementations.data_uf9yj3b(P_0);
	}

	[MangledName("?READ_RGB_PIXEL@fpng@@YAIPEBX@Z")]
	[DemangledName("unsigned int __cdecl fpng::READ_RGB_PIXEL(void const *)")]
	public unsafe static int READ_RGB_PIXEL(void* P_0)
	{
		return GlobalFunctionImplementations.READ_RGB_PIXEL(P_0);
	}

	[MangledName("??$minimum@H@fpng@@YAHHH@Z")]
	[DemangledName("int __cdecl fpng::minimum<int>(int, int)")]
	[CleanName("minimum")]
	public static int minimum_ymfg3kb(int P_0, int P_1)
	{
		return GlobalFunctionImplementations.minimum_ymfg3kb(P_0, P_1);
	}

	[MangledName("?size@?$vector@IV?$allocator@I@std@@@std@@QEBA_KXZ")]
	[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::size(void) const")]
	[CleanName("size")]
	public unsafe static long size_wtrvsgc(void* P_0)
	{
		return GlobalFunctionImplementations.size_wtrvsgc(P_0);
	}

	[MangledName("?adjust_freq32@fpng@@YAXIPEAIPEAG@Z")]
	[DemangledName("void __cdecl fpng::adjust_freq32(unsigned int, unsigned int *, unsigned short *)")]
	public unsafe static void adjust_freq32(int P_0, void* P_1, void* P_2)
	{
		GlobalFunctionImplementations.adjust_freq32(P_0, P_1, P_2);
	}

	[MangledName("?defl_start_dynamic_block@fpng@@YA_NPEAUdefl_huff@1@PEAEAEAIIAEA_KAEAH@Z")]
	[DemangledName("bool __cdecl fpng::defl_start_dynamic_block(struct fpng::defl_huff *, unsigned char *, unsigned int &, unsigned int, unsigned __int64 &, int &)")]
	public unsafe static bool defl_start_dynamic_block(void* P_0, void* P_1, void* P_2, int P_3, void* P_4, void* P_5)
	{
		bool result = GlobalFunctionImplementations.defl_start_dynamic_block(P_0, P_1, P_2, P_3, P_4, P_5);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??A?$vector@IV?$allocator@I@std@@@std@@QEAAAEAI_K@Z")]
	[DemangledName("public: unsigned int & __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::operator[](unsigned __int64)")]
	[CleanName("operator")]
	public unsafe static void* operator_2nyjhmb(void* P_0, long P_1)
	{
		return GlobalFunctionImplementations.operator_2nyjhmb(P_0, P_1);
	}

	[MangledName("??1?$vector@IV?$allocator@I@std@@@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::~vector<unsigned int, class std::allocator<unsigned int>>(void)")]
	public unsafe static void vector_unsigned_int_class_std_allocator_unsigned_int_Destructor(void* P_0)
	{
		GlobalFunctionImplementations.vector_unsigned_int_class_std_allocator_unsigned_int_Destructor(P_0);
	}

	[MangledName("??$?0AEBV?$allocator@I@std@@$$V@?$_Compressed_pair@V?$allocator@I@std@@V?$_Vector_val@U?$_Simple_types@I@std@@@2@$00@std@@QEAA@U_One_then_variadic_args_t@1@AEBV?$allocator@I@1@@Z")]
	[DemangledName("public: __cdecl std::_Compressed_pair<class std::allocator<unsigned int>, class std::_Vector_val<struct std::_Simple_types<unsigned int>>, 1>::_Compressed_pair<class std::allocator<unsigned int>, class std::_Vector_val<struct std::_Simple_types<unsigned int>>, 1><class std::allocator<unsigned int> const &>(struct std::_One_then_variadic_args_t, class std::allocator<unsigned int> const &)")]
	public unsafe static void* Compressed_pair_class_std_allocator_unsigned_int_class_std_Vector_val_struct_std_Simple_types_unsigned_int_1_Constructor(void* P_0, sbyte P_1, void* P_2)
	{
		return GlobalFunctionImplementations.Compressed_pair_class_std_allocator_unsigned_int_class_std_Vector_val_struct_std_Simple_types_unsigned_int_1_Constructor(P_0, P_1, P_2);
	}

	[MangledName("??$_Construct_n@$$V@?$vector@IV?$allocator@I@std@@@std@@AEAAX_K@Z")]
	[DemangledName("private: void __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::_Construct_n<>(unsigned __int64)")]
	public unsafe static void Construct_n(void* P_0, long P_1)
	{
		GlobalFunctionImplementations.Construct_n(P_0, P_1);
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??0?$_Vector_val@U?$_Simple_types@I@std@@@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::_Vector_val<struct std::_Simple_types<unsigned int>>::_Vector_val<struct std::_Simple_types<unsigned int>>(void)")]
	public unsafe static void* Vector_val_struct_std_Simple_types_unsigned_int_Constructor(void* P_0)
	{
		return GlobalFunctionImplementations.Vector_val_struct_std_Simple_types_unsigned_int_Constructor(P_0);
	}

	[MangledName("?_Getal@?$vector@IV?$allocator@I@std@@@std@@AEAAAEAV?$allocator@I@2@XZ")]
	[DemangledName("private: class std::allocator<unsigned int> & __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::_Getal(void)")]
	[CleanName("Getal")]
	public unsafe static void* Getal_t2pmqoc(void* P_0)
	{
		return GlobalFunctionImplementations.Getal_t2pmqoc(P_0);
	}

	[MangledName("??0_Fake_proxy_ptr_impl@std@@QEAA@AEBU_Fake_allocator@1@AEBU_Container_base0@1@@Z")]
	[DemangledName("public: __cdecl std::_Fake_proxy_ptr_impl::_Fake_proxy_ptr_impl(struct std::_Fake_allocator const &, struct std::_Container_base0 const &)")]
	public unsafe static void* Fake_proxy_ptr_impl_Constructor(void* P_0, void* P_1, void* P_2)
	{
		return GlobalFunctionImplementations.Fake_proxy_ptr_impl_Constructor(P_0, P_1, P_2);
	}

	[MangledName("?_Buy_nonzero@?$vector@IV?$allocator@I@std@@@std@@AEAAX_K@Z")]
	[DemangledName("private: void __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::_Buy_nonzero(unsigned __int64)")]
	public unsafe static void Buy_nonzero(void* P_0, long P_1)
	{
		GlobalFunctionImplementations.Buy_nonzero(P_0, P_1);
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??$_Uninitialized_value_construct_n@V?$allocator@I@std@@@std@@YAPEAIPEAI_KAEAV?$allocator@I@0@@Z")]
	[DemangledName("unsigned int * __cdecl std::_Uninitialized_value_construct_n<class std::allocator<unsigned int>>(unsigned int *, unsigned __int64, class std::allocator<unsigned int> &)")]
	[CleanName("Uninitialized_value_construct_n")]
	public unsafe static void* Uninitialized_value_construct_n_zg4iwva(void* P_0, long P_1, void* P_2)
	{
		return GlobalFunctionImplementations.Uninitialized_value_construct_n_zg4iwva(P_0, P_1, P_2);
	}

	[MangledName("??1?$_Tidy_guard@V?$vector@IV?$allocator@I@std@@@std@@@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::_Tidy_guard<class std::vector<unsigned int, class std::allocator<unsigned int>>>::~_Tidy_guard<class std::vector<unsigned int, class std::allocator<unsigned int>>>(void)")]
	public unsafe static void Tidy_guard_class_std_vector_unsigned_int_class_std_allocator_unsigned_int_Destructor(void* P_0)
	{
		GlobalFunctionImplementations.Tidy_guard_class_std_vector_unsigned_int_class_std_allocator_unsigned_int_Destructor(P_0);
	}

	[MangledName("?_Release@_Fake_proxy_ptr_impl@std@@QEAAXXZ")]
	[DemangledName("public: void __cdecl std::_Fake_proxy_ptr_impl::_Release(void)")]
	public unsafe static void Release(void* P_0)
	{
		GlobalFunctionImplementations.Release(P_0);
	}

	[MangledName("?_Get_first@?$_Compressed_pair@V?$allocator@I@std@@V?$_Vector_val@U?$_Simple_types@I@std@@@2@$00@std@@QEAAAEAV?$allocator@I@2@XZ")]
	[DemangledName("public: class std::allocator<unsigned int> & __cdecl std::_Compressed_pair<class std::allocator<unsigned int>, class std::_Vector_val<struct std::_Simple_types<unsigned int>>, 1>::_Get_first(void)")]
	[CleanName("Get_first")]
	public unsafe static void* Get_first_evhdorb(void* P_0)
	{
		return GlobalFunctionImplementations.Get_first_evhdorb(P_0);
	}

	[MangledName("?max_size@?$vector@IV?$allocator@I@std@@@std@@QEBA_KXZ")]
	[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::max_size(void) const")]
	[CleanName("max_size")]
	public unsafe static long max_size_qdwnpha(void* P_0)
	{
		return GlobalFunctionImplementations.max_size_qdwnpha(P_0);
	}

	[MangledName("?_Xlength@?$vector@IV?$allocator@I@std@@@std@@CAXXZ")]
	[DemangledName("private: static void __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::_Xlength(void)")]
	[CleanName("Xlength")]
	public static void Xlength_nubzgpc()
	{
		GlobalFunctionImplementations.Xlength_nubzgpc();
	}

	[MangledName("?_Buy_raw@?$vector@IV?$allocator@I@std@@@std@@AEAAX_K@Z")]
	[DemangledName("private: void __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::_Buy_raw(unsigned __int64)")]
	public unsafe static void Buy_raw(void* P_0, long P_1)
	{
		GlobalFunctionImplementations.Buy_raw(P_0, P_1);
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??$min@_K@std@@YAAEB_KAEB_K0@Z")]
	[DemangledName("unsigned __int64 const & __cdecl std::min<unsigned __int64>(unsigned __int64 const &, unsigned __int64 const &)")]
	public unsafe static void* min(void* P_0, void* P_1)
	{
		return GlobalFunctionImplementations.min(P_0, P_1);
	}

	[MangledName("?max_size@?$_Default_allocator_traits@V?$allocator@I@std@@@std@@SA_KAEBV?$allocator@I@2@@Z")]
	[DemangledName("public: static unsigned __int64 __cdecl std::_Default_allocator_traits<class std::allocator<unsigned int>>::max_size(class std::allocator<unsigned int> const &)")]
	[CleanName("max_size")]
	public unsafe static long max_size_snq294b(void* P_0)
	{
		return GlobalFunctionImplementations.max_size_snq294b(P_0);
	}

	[MangledName("?_Getal@?$vector@IV?$allocator@I@std@@@std@@AEBAAEBV?$allocator@I@2@XZ")]
	[DemangledName("private: class std::allocator<unsigned int> const & __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::_Getal(void) const")]
	[CleanName("Getal")]
	public unsafe static void* Getal_r5wdlvb(void* P_0)
	{
		return GlobalFunctionImplementations.Getal_r5wdlvb(P_0);
	}

	[MangledName("??$_Max_limit@_J@std@@YA_JXZ")]
	[DemangledName("__int64 __cdecl std::_Max_limit<__int64>(void)")]
	public static long Max_limit()
	{
		return GlobalFunctionImplementations.Max_limit();
	}

	[MangledName("?_Get_first@?$_Compressed_pair@V?$allocator@I@std@@V?$_Vector_val@U?$_Simple_types@I@std@@@2@$00@std@@QEBAAEBV?$allocator@I@2@XZ")]
	[DemangledName("public: class std::allocator<unsigned int> const & __cdecl std::_Compressed_pair<class std::allocator<unsigned int>, class std::_Vector_val<struct std::_Simple_types<unsigned int>>, 1>::_Get_first(void) const")]
	[CleanName("Get_first")]
	public unsafe static void* Get_first_gs7mvkc(void* P_0)
	{
		return GlobalFunctionImplementations.Get_first_gs7mvkc(P_0);
	}

	[MangledName("??$_Allocate_at_least_helper@V?$allocator@I@std@@@std@@YAPEAIAEAV?$allocator@I@0@AEA_K@Z")]
	[DemangledName("unsigned int * __cdecl std::_Allocate_at_least_helper<class std::allocator<unsigned int>>(class std::allocator<unsigned int> &, unsigned __int64 &)")]
	[CleanName("Allocate_at_least_helper")]
	public unsafe static void* Allocate_at_least_helper_22hwyxd(void* P_0, void* P_1)
	{
		void* result = GlobalFunctionImplementations.Allocate_at_least_helper_22hwyxd(P_0, P_1);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?allocate@?$allocator@I@std@@QEAAPEAI_K@Z")]
	[DemangledName("public: unsigned int * __cdecl std::allocator<unsigned int>::allocate(unsigned __int64)")]
	[CleanName("allocate")]
	public unsafe static void* allocate_wor4ptd(void* P_0, long P_1)
	{
		void* result = GlobalFunctionImplementations.allocate_wor4ptd(P_0, P_1);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$_Allocate@$0BA@U_Default_allocate_traits@std@@@std@@YAPEAX_K@Z")]
	[DemangledName("void * __cdecl std::_Allocate<16, struct std::_Default_allocate_traits>(unsigned __int64)")]
	[CleanName("Allocate")]
	public unsafe static void* Allocate_i4jzs2a(long P_0)
	{
		void* result = GlobalFunctionImplementations.Allocate_i4jzs2a(P_0);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$_Get_size_of_n@$03@std@@YA_K_K@Z")]
	[DemangledName("unsigned __int64 __cdecl std::_Get_size_of_n<4>(unsigned __int64)")]
	[CleanName("Get_size_of_n")]
	public static long Get_size_of_n_rdjmi2b(long P_0)
	{
		long result = GlobalFunctionImplementations.Get_size_of_n_rdjmi2b(P_0);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$_Allocate_manually_vector_aligned@U_Default_allocate_traits@std@@@std@@YAPEAX_K@Z")]
	[DemangledName("void * __cdecl std::_Allocate_manually_vector_aligned<struct std::_Default_allocate_traits>(unsigned __int64)")]
	public unsafe static void* Allocate_manually_vector_aligned(long P_0)
	{
		void* result = GlobalFunctionImplementations.Allocate_manually_vector_aligned(P_0);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?_Allocate@_Default_allocate_traits@std@@SAPEAX_K@Z")]
	[DemangledName("public: static void * __cdecl std::_Default_allocate_traits::_Allocate(unsigned __int64)")]
	[CleanName("Allocate")]
	public unsafe static void* Allocate_ifu7fia(long P_0)
	{
		return GlobalFunctionImplementations.Allocate_ifu7fia(P_0);
	}

	[MangledName("?_Throw_bad_array_new_length@std@@YAXXZ")]
	[DemangledName("void __cdecl std::_Throw_bad_array_new_length(void)")]
	public static void Throw_bad_array_new_length()
	{
		GlobalFunctionImplementations.Throw_bad_array_new_length();
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??0bad_array_new_length@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::bad_array_new_length::bad_array_new_length(void)")]
	[CleanName("bad_array_new_length_Constructor")]
	public unsafe static void* bad_array_new_length_Constructor_fnjru5d(void* P_0)
	{
		return GlobalFunctionImplementations.bad_array_new_length_Constructor_fnjru5d(P_0);
	}

	[MangledName("??0bad_array_new_length@std@@QEAA@AEBV01@@Z")]
	[DemangledName("public: __cdecl std::bad_array_new_length::bad_array_new_length(class std::bad_array_new_length const &)")]
	[CleanName("bad_array_new_length_Constructor")]
	public unsafe static void* bad_array_new_length_Constructor_7fjuj3c(void* P_0, void* P_1)
	{
		return GlobalFunctionImplementations.bad_array_new_length_Constructor_7fjuj3c(P_0, P_1);
	}

	[MangledName("??0bad_alloc@std@@QEAA@AEBV01@@Z")]
	[DemangledName("public: __cdecl std::bad_alloc::bad_alloc(class std::bad_alloc const &)")]
	[CleanName("bad_alloc_Constructor")]
	public unsafe static void* bad_alloc_Constructor_3vdoaxb(void* P_0, void* P_1)
	{
		return GlobalFunctionImplementations.bad_alloc_Constructor_3vdoaxb(P_0, P_1);
	}

	[MangledName("??0exception@std@@QEAA@AEBV01@@Z")]
	[DemangledName("public: __cdecl std::exception::exception(class std::exception const &)")]
	[CleanName("exception_Constructor")]
	public unsafe static void* exception_Constructor_ikocrpb(void* P_0, void* P_1)
	{
		return GlobalFunctionImplementations.exception_Constructor_ikocrpb(P_0, P_1);
	}

	[MangledName("??1bad_array_new_length@std@@UEAA@XZ")]
	[DemangledName("public: virtual __cdecl std::bad_array_new_length::~bad_array_new_length(void)")]
	public unsafe static void bad_array_new_length_Destructor(void* P_0)
	{
		GlobalFunctionImplementations.bad_array_new_length_Destructor(P_0);
	}

	[MangledName("??0bad_alloc@std@@AEAA@QEBD@Z")]
	[DemangledName("private: __cdecl std::bad_alloc::bad_alloc(char const *const)")]
	[CleanName("bad_alloc_Constructor")]
	public unsafe static void* bad_alloc_Constructor_72dj2ea(void* P_0, void* P_1)
	{
		return GlobalFunctionImplementations.bad_alloc_Constructor_72dj2ea(P_0, P_1);
	}

	[MangledName("??_Gbad_array_new_length@std@@UEAAPEAXI@Z")]
	[DemangledName("public: virtual void * __cdecl std::bad_array_new_length::`scalar deleting dtor'(unsigned int)")]
	public unsafe static void* bad_array_new_length_Delete(void* P_0, int P_1)
	{
		return GlobalFunctionImplementations.bad_array_new_length_Delete(P_0, P_1);
	}

	[MangledName("?what@exception@std@@UEBAPEBDXZ")]
	[DemangledName("public: virtual char const * __cdecl std::exception::what(void) const")]
	public unsafe static void* what(void* P_0)
	{
		return GlobalFunctionImplementations.what(P_0);
	}

	[MangledName("??0exception@std@@QEAA@QEBDH@Z")]
	[DemangledName("public: __cdecl std::exception::exception(char const *const, int)")]
	[CleanName("exception_Constructor")]
	public unsafe static void* exception_Constructor_morlzmd(void* P_0, void* P_1, int P_2)
	{
		return GlobalFunctionImplementations.exception_Constructor_morlzmd(P_0, P_1, P_2);
	}

	[MangledName("??_Gbad_alloc@std@@UEAAPEAXI@Z")]
	[DemangledName("public: virtual void * __cdecl std::bad_alloc::`scalar deleting dtor'(unsigned int)")]
	public unsafe static void* bad_alloc_Delete(void* P_0, int P_1)
	{
		return GlobalFunctionImplementations.bad_alloc_Delete(P_0, P_1);
	}

	[MangledName("??_Gexception@std@@UEAAPEAXI@Z")]
	[DemangledName("public: virtual void * __cdecl std::exception::`scalar deleting dtor'(unsigned int)")]
	public unsafe static void* exception_Delete(void* P_0, int P_1)
	{
		return GlobalFunctionImplementations.exception_Delete(P_0, P_1);
	}

	[MangledName("??1exception@std@@UEAA@XZ")]
	[DemangledName("public: virtual __cdecl std::exception::~exception(void)")]
	public unsafe static void exception_Destructor(void* P_0)
	{
		GlobalFunctionImplementations.exception_Destructor(P_0);
	}

	[MangledName("??1bad_alloc@std@@UEAA@XZ")]
	[DemangledName("public: virtual __cdecl std::bad_alloc::~bad_alloc(void)")]
	public unsafe static void bad_alloc_Destructor(void* P_0)
	{
		GlobalFunctionImplementations.bad_alloc_Destructor(P_0);
	}

	[MangledName("??$_Unfancy@I@std@@YAPEAIPEAI@Z")]
	[DemangledName("unsigned int * __cdecl std::_Unfancy<unsigned int>(unsigned int *)")]
	[CleanName("Unfancy")]
	public unsafe static void* Unfancy_xjzn42c(void* P_0)
	{
		return GlobalFunctionImplementations.Unfancy_xjzn42c(P_0);
	}

	[MangledName("??$_Zero_range@PEAI@std@@YAPEAIQEAI0@Z")]
	[DemangledName("unsigned int * __cdecl std::_Zero_range<unsigned int *>(unsigned int *const, unsigned int *const)")]
	[CleanName("Zero_range")]
	public unsafe static void* Zero_range_dc39dpa(void* P_0, void* P_1)
	{
		return GlobalFunctionImplementations.Zero_range_dc39dpa(P_0, P_1);
	}

	[MangledName("??$_To_address@PEAI@std@@YA?A_PAEBQEAI@Z")]
	[DemangledName("auto __cdecl std::_To_address<unsigned int *>(unsigned int *const &)")]
	[CleanName("To_address")]
	public unsafe static void* To_address_aoz7nfb(void* P_0)
	{
		return GlobalFunctionImplementations.To_address_aoz7nfb(P_0);
	}

	[MangledName("?_Tidy@?$vector@IV?$allocator@I@std@@@std@@AEAAXXZ")]
	[DemangledName("private: void __cdecl std::vector<unsigned int, class std::allocator<unsigned int>>::_Tidy(void)")]
	[CleanName("Tidy")]
	public unsafe static void Tidy_kyqxybb(void* P_0)
	{
		GlobalFunctionImplementations.Tidy_kyqxybb(P_0);
	}

	[MangledName("?_Orphan_all@_Container_base0@std@@QEAAXXZ")]
	[DemangledName("public: void __cdecl std::_Container_base0::_Orphan_all(void)")]
	public unsafe static void Orphan_all(void* P_0)
	{
		GlobalFunctionImplementations.Orphan_all(P_0);
	}

	[MangledName("??$_Destroy_range@V?$allocator@I@std@@@std@@YAXPEAIQEAIAEAV?$allocator@I@0@@Z")]
	[DemangledName("void __cdecl std::_Destroy_range<class std::allocator<unsigned int>>(unsigned int *, unsigned int *const, class std::allocator<unsigned int> &)")]
	[CleanName("Destroy_range")]
	public unsafe static void Destroy_range_9rluabc(void* P_0, void* P_1, void* P_2)
	{
		GlobalFunctionImplementations.Destroy_range_9rluabc(P_0, P_1, P_2);
	}

	[MangledName("?deallocate@?$allocator@I@std@@QEAAXQEAI_K@Z")]
	[DemangledName("public: void __cdecl std::allocator<unsigned int>::deallocate(unsigned int *const, unsigned __int64)")]
	[CleanName("deallocate")]
	public unsafe static void deallocate_gfl4ncc(void* P_0, void* P_1, long P_2)
	{
		GlobalFunctionImplementations.deallocate_gfl4ncc(P_0, P_1, P_2);
	}

	[MangledName("??$_Deallocate@$0BA@@std@@YAXPEAX_K@Z")]
	[DemangledName("void __cdecl std::_Deallocate<16>(void *, unsigned __int64)")]
	public unsafe static void Deallocate(void* P_0, long P_1)
	{
		GlobalFunctionImplementations.Deallocate(P_0, P_1);
	}

	[MangledName("?_Adjust_manually_vector_aligned@std@@YAXAEAPEAXAEA_K@Z")]
	[DemangledName("void __cdecl std::_Adjust_manually_vector_aligned(void *&, unsigned __int64 &)")]
	public unsafe static void Adjust_manually_vector_aligned(void* P_0, void* P_1)
	{
		GlobalFunctionImplementations.Adjust_manually_vector_aligned(P_0, P_1);
	}

	[MangledName("??$_Unfancy_maybe_null@I@std@@YAPEAIPEAI@Z")]
	[DemangledName("unsigned int * __cdecl std::_Unfancy_maybe_null<unsigned int>(unsigned int *)")]
	[CleanName("Unfancy_maybe_null")]
	public unsafe static void* Unfancy_maybe_null_ys5czvb(void* P_0)
	{
		return GlobalFunctionImplementations.Unfancy_maybe_null_ys5czvb(P_0);
	}

	[MangledName("??$maximum@I@fpng@@YAIII@Z")]
	[DemangledName("unsigned int __cdecl fpng::maximum<unsigned int>(unsigned int, unsigned int)")]
	[CleanName("maximum")]
	public static int maximum_y5wzmwb(int P_0, int P_1)
	{
		return GlobalFunctionImplementations.maximum_y5wzmwb(P_0, P_1);
	}

	[MangledName("?defl_optimize_huffman_table@fpng@@YAXPEAUdefl_huff@1@HHHH@Z")]
	[DemangledName("void __cdecl fpng::defl_optimize_huffman_table(struct fpng::defl_huff *, int, int, int, int)")]
	public unsafe static void defl_optimize_huffman_table(void* P_0, int P_1, int P_2, int P_3, int P_4)
	{
		GlobalFunctionImplementations.defl_optimize_huffman_table(P_0, P_1, P_2, P_3, P_4);
	}

	[MangledName("??$maximum@H@fpng@@YAHHH@Z")]
	[DemangledName("int __cdecl fpng::maximum<int>(int, int)")]
	[CleanName("maximum")]
	public static int maximum_sfjssib(int P_0, int P_1)
	{
		return GlobalFunctionImplementations.maximum_sfjssib(P_0, P_1);
	}

	[MangledName("?defl_radix_sort_syms@fpng@@YAPEAUdefl_sym_freq@1@IPEAU21@0@Z")]
	[DemangledName("struct fpng::defl_sym_freq * __cdecl fpng::defl_radix_sort_syms(unsigned int, struct fpng::defl_sym_freq *, struct fpng::defl_sym_freq *)")]
	public unsafe static void* defl_radix_sort_syms(int P_0, void* P_1, void* P_2)
	{
		return GlobalFunctionImplementations.defl_radix_sort_syms(P_0, P_1, P_2);
	}

	[MangledName("?defl_calculate_minimum_redundancy@fpng@@YAXPEAUdefl_sym_freq@1@H@Z")]
	[DemangledName("void __cdecl fpng::defl_calculate_minimum_redundancy(struct fpng::defl_sym_freq *, int)")]
	public unsafe static void defl_calculate_minimum_redundancy(void* P_0, int P_1)
	{
		GlobalFunctionImplementations.defl_calculate_minimum_redundancy(P_0, P_1);
	}

	[MangledName("?defl_huffman_enforce_max_code_size@fpng@@YAXPEAHHH@Z")]
	[DemangledName("void __cdecl fpng::defl_huffman_enforce_max_code_size(int *, int, int)")]
	public unsafe static void defl_huffman_enforce_max_code_size(void* P_0, int P_1, int P_2)
	{
		GlobalFunctionImplementations.defl_huffman_enforce_max_code_size(P_0, P_1, P_2);
	}

	[MangledName("??0?$vector@_KV?$allocator@_K@std@@@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::vector<unsigned __int64, class std::allocator<unsigned __int64>>(void)")]
	public unsafe static void* vector_unsigned_int64_class_std_allocator_unsigned_int64_Constructor(void* P_0)
	{
		return GlobalFunctionImplementations.vector_unsigned_int64_class_std_allocator_unsigned_int64_Constructor(P_0);
	}

	[MangledName("?resize@?$vector@_KV?$allocator@_K@std@@@std@@QEAAX_K@Z")]
	[DemangledName("public: void __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::resize(unsigned __int64)")]
	[CleanName("resize")]
	public unsafe static void resize_d4pmvud(void* P_0, long P_1)
	{
		GlobalFunctionImplementations.resize_d4pmvud(P_0, P_1);
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?data@?$vector@_KV?$allocator@_K@std@@@std@@QEAAPEA_KXZ")]
	[DemangledName("public: unsigned __int64 * __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::data(void)")]
	[CleanName("data")]
	public unsafe static void* data_dtgl25a(void* P_0)
	{
		return GlobalFunctionImplementations.data_dtgl25a(P_0);
	}

	[MangledName("?size@?$vector@_KV?$allocator@_K@std@@@std@@QEBA_KXZ")]
	[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::size(void) const")]
	[CleanName("size")]
	public unsafe static long size_trt5i3d(void* P_0)
	{
		return GlobalFunctionImplementations.size_trt5i3d(P_0);
	}

	[MangledName("??A?$vector@_KV?$allocator@_K@std@@@std@@QEAAAEA_K_K@Z")]
	[DemangledName("public: unsigned __int64 & __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::operator[](unsigned __int64)")]
	[CleanName("operator")]
	public unsafe static void* operator_7d577ub(void* P_0, long P_1)
	{
		return GlobalFunctionImplementations.operator_7d577ub(P_0, P_1);
	}

	[MangledName("??1?$vector@_KV?$allocator@_K@std@@@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::~vector<unsigned __int64, class std::allocator<unsigned __int64>>(void)")]
	public unsafe static void vector_unsigned_int64_class_std_allocator_unsigned_int64_Destructor(void* P_0)
	{
		GlobalFunctionImplementations.vector_unsigned_int64_class_std_allocator_unsigned_int64_Destructor(P_0);
	}

	[MangledName("??$?0$$V@?$_Compressed_pair@V?$allocator@_K@std@@V?$_Vector_val@U?$_Simple_types@_K@std@@@2@$00@std@@QEAA@U_Zero_then_variadic_args_t@1@@Z")]
	[DemangledName("public: __cdecl std::_Compressed_pair<class std::allocator<unsigned __int64>, class std::_Vector_val<struct std::_Simple_types<unsigned __int64>>, 1>::_Compressed_pair<class std::allocator<unsigned __int64>, class std::_Vector_val<struct std::_Simple_types<unsigned __int64>>, 1><>(struct std::_Zero_then_variadic_args_t)")]
	public unsafe static void* Compressed_pair_class_std_allocator_unsigned_int64_class_std_Vector_val_struct_std_Simple_types_unsigned_int64_1_Constructor(void* P_0, sbyte P_1)
	{
		return GlobalFunctionImplementations.Compressed_pair_class_std_allocator_unsigned_int64_class_std_Vector_val_struct_std_Simple_types_unsigned_int64_1_Constructor(P_0, P_1);
	}

	[MangledName("?_Alloc_proxy@_Container_base0@std@@QEAAXAEBU_Fake_allocator@2@@Z")]
	[DemangledName("public: void __cdecl std::_Container_base0::_Alloc_proxy(struct std::_Fake_allocator const &)")]
	public unsafe static void Alloc_proxy(void* P_0, void* P_1)
	{
		GlobalFunctionImplementations.Alloc_proxy(P_0, P_1);
	}

	[MangledName("??0?$allocator@_K@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::allocator<unsigned __int64>::allocator<unsigned __int64>(void)")]
	public unsafe static void* allocator_unsigned_int64_Constructor(void* P_0)
	{
		return GlobalFunctionImplementations.allocator_unsigned_int64_Constructor(P_0);
	}

	[MangledName("??0?$_Vector_val@U?$_Simple_types@_K@std@@@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::_Vector_val<struct std::_Simple_types<unsigned __int64>>::_Vector_val<struct std::_Simple_types<unsigned __int64>>(void)")]
	public unsafe static void* Vector_val_struct_std_Simple_types_unsigned_int64_Constructor(void* P_0)
	{
		return GlobalFunctionImplementations.Vector_val_struct_std_Simple_types_unsigned_int64_Constructor(P_0);
	}

	[MangledName("??$_Resize@U_Value_init_tag@std@@@?$vector@_KV?$allocator@_K@std@@@std@@AEAAX_KAEBU_Value_init_tag@1@@Z")]
	[DemangledName("private: void __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Resize<struct std::_Value_init_tag>(unsigned __int64, struct std::_Value_init_tag const &)")]
	[CleanName("Resize")]
	public unsafe static void Resize_2s9rs9d(void* P_0, long P_1, void* P_2)
	{
		GlobalFunctionImplementations.Resize_2s9rs9d(P_0, P_1, P_2);
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?_Getal@?$vector@_KV?$allocator@_K@std@@@std@@AEAAAEAV?$allocator@_K@2@XZ")]
	[DemangledName("private: class std::allocator<unsigned __int64> & __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Getal(void)")]
	[CleanName("Getal")]
	public unsafe static void* Getal_kuj7nva(void* P_0)
	{
		return GlobalFunctionImplementations.Getal_kuj7nva(P_0);
	}

	[MangledName("?_Orphan_range@?$vector@_KV?$allocator@_K@std@@@std@@AEBAXPEA_K0@Z")]
	[DemangledName("private: void __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Orphan_range(unsigned __int64 *, unsigned __int64 *) const")]
	[CleanName("Orphan_range")]
	public unsafe static void Orphan_range_qciws4b(void* P_0, void* P_1, void* P_2)
	{
		GlobalFunctionImplementations.Orphan_range_qciws4b(P_0, P_1, P_2);
	}

	[MangledName("??$_Destroy_range@V?$allocator@_K@std@@@std@@YAXPEA_KQEA_KAEAV?$allocator@_K@0@@Z")]
	[DemangledName("void __cdecl std::_Destroy_range<class std::allocator<unsigned __int64>>(unsigned __int64 *, unsigned __int64 *const, class std::allocator<unsigned __int64> &)")]
	[CleanName("Destroy_range")]
	public unsafe static void Destroy_range_qbzp7xb(void* P_0, void* P_1, void* P_2)
	{
		GlobalFunctionImplementations.Destroy_range_qbzp7xb(P_0, P_1, P_2);
	}

	[MangledName("??$_Resize_reallocate@U_Value_init_tag@std@@@?$vector@_KV?$allocator@_K@std@@@std@@AEAAX_KAEBU_Value_init_tag@1@@Z")]
	[DemangledName("private: void __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Resize_reallocate<struct std::_Value_init_tag>(unsigned __int64, struct std::_Value_init_tag const &)")]
	[CleanName("Resize_reallocate")]
	public unsafe static void Resize_reallocate_ytnsorc(void* P_0, long P_1, void* P_2)
	{
		GlobalFunctionImplementations.Resize_reallocate_ytnsorc(P_0, P_1, P_2);
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??$_Uninitialized_value_construct_n@V?$allocator@_K@std@@@std@@YAPEA_KPEA_K_KAEAV?$allocator@_K@0@@Z")]
	[DemangledName("unsigned __int64 * __cdecl std::_Uninitialized_value_construct_n<class std::allocator<unsigned __int64>>(unsigned __int64 *, unsigned __int64, class std::allocator<unsigned __int64> &)")]
	[CleanName("Uninitialized_value_construct_n")]
	public unsafe static void* Uninitialized_value_construct_n_hqowyoc(void* P_0, long P_1, void* P_2)
	{
		return GlobalFunctionImplementations.Uninitialized_value_construct_n_hqowyoc(P_0, P_1, P_2);
	}

	[MangledName("?_Get_first@?$_Compressed_pair@V?$allocator@_K@std@@V?$_Vector_val@U?$_Simple_types@_K@std@@@2@$00@std@@QEAAAEAV?$allocator@_K@2@XZ")]
	[DemangledName("public: class std::allocator<unsigned __int64> & __cdecl std::_Compressed_pair<class std::allocator<unsigned __int64>, class std::_Vector_val<struct std::_Simple_types<unsigned __int64>>, 1>::_Get_first(void)")]
	[CleanName("Get_first")]
	public unsafe static void* Get_first_whlbtqb(void* P_0)
	{
		return GlobalFunctionImplementations.Get_first_whlbtqb(P_0);
	}

	[MangledName("?max_size@?$vector@_KV?$allocator@_K@std@@@std@@QEBA_KXZ")]
	[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::max_size(void) const")]
	[CleanName("max_size")]
	public unsafe static long max_size_kyvxnnb(void* P_0)
	{
		return GlobalFunctionImplementations.max_size_kyvxnnb(P_0);
	}

	[MangledName("?_Xlength@?$vector@_KV?$allocator@_K@std@@@std@@CAXXZ")]
	[DemangledName("private: static void __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Xlength(void)")]
	[CleanName("Xlength")]
	public static void Xlength_zmqdsxa()
	{
		GlobalFunctionImplementations.Xlength_zmqdsxa();
	}

	[MangledName("?_Calculate_growth@?$vector@_KV?$allocator@_K@std@@@std@@AEBA_K_K@Z")]
	[DemangledName("private: unsigned __int64 __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Calculate_growth(unsigned __int64) const")]
	[CleanName("Calculate_growth")]
	public unsafe static long Calculate_growth_vbhwmec(void* P_0, long P_1)
	{
		return GlobalFunctionImplementations.Calculate_growth_vbhwmec(P_0, P_1);
	}

	[MangledName("??$_Allocate_at_least_helper@V?$allocator@_K@std@@@std@@YAPEA_KAEAV?$allocator@_K@0@AEA_K@Z")]
	[DemangledName("unsigned __int64 * __cdecl std::_Allocate_at_least_helper<class std::allocator<unsigned __int64>>(class std::allocator<unsigned __int64> &, unsigned __int64 &)")]
	[CleanName("Allocate_at_least_helper")]
	public unsafe static void* Allocate_at_least_helper_l9zi7qb(void* P_0, void* P_1)
	{
		void* result = GlobalFunctionImplementations.Allocate_at_least_helper_l9zi7qb(P_0, P_1);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$_Uninitialized_move@PEA_KV?$allocator@_K@std@@@std@@YAPEA_KQEA_K0PEA_KAEAV?$allocator@_K@0@@Z")]
	[DemangledName("unsigned __int64 * __cdecl std::_Uninitialized_move<unsigned __int64 *, class std::allocator<unsigned __int64>>(unsigned __int64 *const, unsigned __int64 *const, unsigned __int64 *, class std::allocator<unsigned __int64> &)")]
	[CleanName("Uninitialized_move")]
	public unsafe static void* Uninitialized_move_cbc4pbc(void* P_0, void* P_1, void* P_2, void* P_3)
	{
		return GlobalFunctionImplementations.Uninitialized_move_cbc4pbc(P_0, P_1, P_2, P_3);
	}

	[MangledName("?_Change_array@?$vector@_KV?$allocator@_K@std@@@std@@AEAAXQEA_K_K1@Z")]
	[DemangledName("private: void __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Change_array(unsigned __int64 *const, unsigned __int64, unsigned __int64)")]
	[CleanName("Change_array")]
	public unsafe static void Change_array_hgqy2vc(void* P_0, void* P_1, long P_2, long P_3)
	{
		GlobalFunctionImplementations.Change_array_hgqy2vc(P_0, P_1, P_2, P_3);
	}

	[MangledName("??1_Reallocation_guard@?$vector@_KV?$allocator@_K@std@@@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Reallocation_guard::~_Reallocation_guard(void)")]
	[CleanName("Reallocation_guard_Destructor")]
	public unsafe static void Reallocation_guard_Destructor_jfaqped(void* P_0)
	{
		GlobalFunctionImplementations.Reallocation_guard_Destructor_jfaqped(P_0);
	}

	[MangledName("?max_size@?$_Default_allocator_traits@V?$allocator@_K@std@@@std@@SA_KAEBV?$allocator@_K@2@@Z")]
	[DemangledName("public: static unsigned __int64 __cdecl std::_Default_allocator_traits<class std::allocator<unsigned __int64>>::max_size(class std::allocator<unsigned __int64> const &)")]
	[CleanName("max_size")]
	public unsafe static long max_size_ngjedfc(void* P_0)
	{
		return GlobalFunctionImplementations.max_size_ngjedfc(P_0);
	}

	[MangledName("?_Getal@?$vector@_KV?$allocator@_K@std@@@std@@AEBAAEBV?$allocator@_K@2@XZ")]
	[DemangledName("private: class std::allocator<unsigned __int64> const & __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Getal(void) const")]
	[CleanName("Getal")]
	public unsafe static void* Getal_2reycsb(void* P_0)
	{
		return GlobalFunctionImplementations.Getal_2reycsb(P_0);
	}

	[MangledName("?_Get_first@?$_Compressed_pair@V?$allocator@_K@std@@V?$_Vector_val@U?$_Simple_types@_K@std@@@2@$00@std@@QEBAAEBV?$allocator@_K@2@XZ")]
	[DemangledName("public: class std::allocator<unsigned __int64> const & __cdecl std::_Compressed_pair<class std::allocator<unsigned __int64>, class std::_Vector_val<struct std::_Simple_types<unsigned __int64>>, 1>::_Get_first(void) const")]
	[CleanName("Get_first")]
	public unsafe static void* Get_first_gcgh4xa(void* P_0)
	{
		return GlobalFunctionImplementations.Get_first_gcgh4xa(P_0);
	}

	[MangledName("?capacity@?$vector@_KV?$allocator@_K@std@@@std@@QEBA_KXZ")]
	[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::capacity(void) const")]
	[CleanName("capacity")]
	public unsafe static long capacity_f49yk4c(void* P_0)
	{
		return GlobalFunctionImplementations.capacity_f49yk4c(P_0);
	}

	[MangledName("?allocate@?$allocator@_K@std@@QEAAPEA_K_K@Z")]
	[DemangledName("public: unsigned __int64 * __cdecl std::allocator<unsigned __int64>::allocate(unsigned __int64)")]
	[CleanName("allocate")]
	public unsafe static void* allocate_4vpkydd(void* P_0, long P_1)
	{
		void* result = GlobalFunctionImplementations.allocate_4vpkydd(P_0, P_1);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$_Get_size_of_n@$07@std@@YA_K_K@Z")]
	[DemangledName("unsigned __int64 __cdecl std::_Get_size_of_n<8>(unsigned __int64)")]
	[CleanName("Get_size_of_n")]
	public static long Get_size_of_n_siqup9d(long P_0)
	{
		long result = GlobalFunctionImplementations.Get_size_of_n_siqup9d(P_0);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$_Get_unwrapped@AEBQEA_K@std@@YA?A_TAEBQEA_K@Z")]
	[DemangledName("decltype(auto) __cdecl std::_Get_unwrapped<unsigned __int64 *const &>(unsigned __int64 *const &)")]
	[CleanName("Get_unwrapped")]
	public unsafe static void* Get_unwrapped_3jsimya(void* P_0)
	{
		return GlobalFunctionImplementations.Get_unwrapped_3jsimya(P_0);
	}

	[MangledName("??$_Copy_memmove@PEA_KPEA_K@std@@YAPEA_KPEA_K00@Z")]
	[DemangledName("unsigned __int64 * __cdecl std::_Copy_memmove<unsigned __int64 *, unsigned __int64 *>(unsigned __int64 *, unsigned __int64 *, unsigned __int64 *)")]
	[CleanName("Copy_memmove")]
	public unsafe static void* Copy_memmove_uofrjzc(void* P_0, void* P_1, void* P_2)
	{
		return GlobalFunctionImplementations.Copy_memmove_uofrjzc(P_0, P_1, P_2);
	}

	[MangledName("??$_Unfancy@_K@std@@YAPEA_KPEA_K@Z")]
	[DemangledName("unsigned __int64 * __cdecl std::_Unfancy<unsigned __int64>(unsigned __int64 *)")]
	[CleanName("Unfancy")]
	public unsafe static void* Unfancy_z2hkbxa(void* P_0)
	{
		return GlobalFunctionImplementations.Unfancy_z2hkbxa(P_0);
	}

	[MangledName("??$_To_address@PEA_K@std@@YA?A_PAEBQEA_K@Z")]
	[DemangledName("auto __cdecl std::_To_address<unsigned __int64 *>(unsigned __int64 *const &)")]
	[CleanName("To_address")]
	public unsafe static void* To_address_l9253rd(void* P_0)
	{
		return GlobalFunctionImplementations.To_address_l9253rd(P_0);
	}

	[MangledName("??$_Copy_memmove_tail@PEA_K@std@@YAPEA_KQEBDQEA_K_K2@Z")]
	[DemangledName("unsigned __int64 * __cdecl std::_Copy_memmove_tail<unsigned __int64 *>(char const *const, unsigned __int64 *const, unsigned __int64, unsigned __int64)")]
	[CleanName("Copy_memmove_tail")]
	public unsafe static void* Copy_memmove_tail_oluaukc(void* P_0, void* P_1, long P_2, long P_3)
	{
		return GlobalFunctionImplementations.Copy_memmove_tail_oluaukc(P_0, P_1, P_2, P_3);
	}

	[MangledName("?deallocate@?$allocator@_K@std@@QEAAXQEA_K_K@Z")]
	[DemangledName("public: void __cdecl std::allocator<unsigned __int64>::deallocate(unsigned __int64 *const, unsigned __int64)")]
	[CleanName("deallocate")]
	public unsafe static void deallocate_yb2gvqa(void* P_0, void* P_1, long P_2)
	{
		GlobalFunctionImplementations.deallocate_yb2gvqa(P_0, P_1, P_2);
	}

	[MangledName("??$_Zero_range@PEA_K@std@@YAPEA_KQEA_K0@Z")]
	[DemangledName("unsigned __int64 * __cdecl std::_Zero_range<unsigned __int64 *>(unsigned __int64 *const, unsigned __int64 *const)")]
	[CleanName("Zero_range")]
	public unsafe static void* Zero_range_lx9svca(void* P_0, void* P_1)
	{
		return GlobalFunctionImplementations.Zero_range_lx9svca(P_0, P_1);
	}

	[MangledName("??$_Unfancy_maybe_null@_K@std@@YAPEA_KPEA_K@Z")]
	[DemangledName("unsigned __int64 * __cdecl std::_Unfancy_maybe_null<unsigned __int64>(unsigned __int64 *)")]
	[CleanName("Unfancy_maybe_null")]
	public unsafe static void* Unfancy_maybe_null_uqd3pbd(void* P_0)
	{
		return GlobalFunctionImplementations.Unfancy_maybe_null_uqd3pbd(P_0);
	}

	[MangledName("?_Tidy@?$vector@_KV?$allocator@_K@std@@@std@@AEAAXXZ")]
	[DemangledName("private: void __cdecl std::vector<unsigned __int64, class std::allocator<unsigned __int64>>::_Tidy(void)")]
	[CleanName("Tidy")]
	public unsafe static void Tidy_hq3jjxb(void* P_0)
	{
		GlobalFunctionImplementations.Tidy_hq3jjxb(P_0);
	}

	[MangledName("??$minimum@I@fpng@@YAIII@Z")]
	[DemangledName("unsigned int __cdecl fpng::minimum<unsigned int>(unsigned int, unsigned int)")]
	[CleanName("minimum")]
	public static int minimum_su2nfub(int P_0, int P_1)
	{
		return GlobalFunctionImplementations.minimum_su2nfub(P_0, P_1);
	}

	[MangledName("?swap32@fpng@@YAII@Z")]
	[DemangledName("unsigned int __cdecl fpng::swap32(unsigned int)")]
	public static int swap32(int P_0)
	{
		return GlobalFunctionImplementations.swap32(P_0);
	}

	[MangledName("??$_Resize@U_Value_init_tag@std@@@?$vector@EV?$allocator@E@std@@@std@@AEAAX_KAEBU_Value_init_tag@1@@Z")]
	[DemangledName("private: void __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Resize<struct std::_Value_init_tag>(unsigned __int64, struct std::_Value_init_tag const &)")]
	[CleanName("Resize")]
	public unsafe static void Resize_p4x2rua(void* P_0, long P_1, void* P_2)
	{
		GlobalFunctionImplementations.Resize_p4x2rua(P_0, P_1, P_2);
		StackFrameList.ExitToUserCode();
	}

	[MangledName("?_Getal@?$vector@EV?$allocator@E@std@@@std@@AEAAAEAV?$allocator@E@2@XZ")]
	[DemangledName("private: class std::allocator<unsigned char> & __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Getal(void)")]
	[CleanName("Getal")]
	public unsafe static void* Getal_jms5hzb(void* P_0)
	{
		return GlobalFunctionImplementations.Getal_jms5hzb(P_0);
	}

	[MangledName("?_Orphan_range@?$vector@EV?$allocator@E@std@@@std@@AEBAXPEAE0@Z")]
	[DemangledName("private: void __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Orphan_range(unsigned char *, unsigned char *) const")]
	[CleanName("Orphan_range")]
	public unsafe static void Orphan_range_334quvb(void* P_0, void* P_1, void* P_2)
	{
		GlobalFunctionImplementations.Orphan_range_334quvb(P_0, P_1, P_2);
	}

	[MangledName("??$_Destroy_range@V?$allocator@E@std@@@std@@YAXPEAEQEAEAEAV?$allocator@E@0@@Z")]
	[DemangledName("void __cdecl std::_Destroy_range<class std::allocator<unsigned char>>(unsigned char *, unsigned char *const, class std::allocator<unsigned char> &)")]
	[CleanName("Destroy_range")]
	public unsafe static void Destroy_range_jjcob5a(void* P_0, void* P_1, void* P_2)
	{
		GlobalFunctionImplementations.Destroy_range_jjcob5a(P_0, P_1, P_2);
	}

	[MangledName("??$_Resize_reallocate@U_Value_init_tag@std@@@?$vector@EV?$allocator@E@std@@@std@@AEAAX_KAEBU_Value_init_tag@1@@Z")]
	[DemangledName("private: void __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Resize_reallocate<struct std::_Value_init_tag>(unsigned __int64, struct std::_Value_init_tag const &)")]
	[CleanName("Resize_reallocate")]
	public unsafe static void Resize_reallocate_dt5hjdb(void* P_0, long P_1, void* P_2)
	{
		GlobalFunctionImplementations.Resize_reallocate_dt5hjdb(P_0, P_1, P_2);
		StackFrameList.ExitToUserCode();
	}

	[MangledName("??$_Uninitialized_value_construct_n@V?$allocator@E@std@@@std@@YAPEAEPEAE_KAEAV?$allocator@E@0@@Z")]
	[DemangledName("unsigned char * __cdecl std::_Uninitialized_value_construct_n<class std::allocator<unsigned char>>(unsigned char *, unsigned __int64, class std::allocator<unsigned char> &)")]
	[CleanName("Uninitialized_value_construct_n")]
	public unsafe static void* Uninitialized_value_construct_n_cxm3ryd(void* P_0, long P_1, void* P_2)
	{
		return GlobalFunctionImplementations.Uninitialized_value_construct_n_cxm3ryd(P_0, P_1, P_2);
	}

	[MangledName("?_Get_first@?$_Compressed_pair@V?$allocator@E@std@@V?$_Vector_val@U?$_Simple_types@E@std@@@2@$00@std@@QEAAAEAV?$allocator@E@2@XZ")]
	[DemangledName("public: class std::allocator<unsigned char> & __cdecl std::_Compressed_pair<class std::allocator<unsigned char>, class std::_Vector_val<struct std::_Simple_types<unsigned char>>, 1>::_Get_first(void)")]
	[CleanName("Get_first")]
	public unsafe static void* Get_first_nkl7psd(void* P_0)
	{
		return GlobalFunctionImplementations.Get_first_nkl7psd(P_0);
	}

	[MangledName("?max_size@?$vector@EV?$allocator@E@std@@@std@@QEBA_KXZ")]
	[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::max_size(void) const")]
	[CleanName("max_size")]
	public unsafe static long max_size_2yjes5b(void* P_0)
	{
		return GlobalFunctionImplementations.max_size_2yjes5b(P_0);
	}

	[MangledName("?_Xlength@?$vector@EV?$allocator@E@std@@@std@@CAXXZ")]
	[DemangledName("private: static void __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Xlength(void)")]
	[CleanName("Xlength")]
	public static void Xlength_zpuxaia()
	{
		GlobalFunctionImplementations.Xlength_zpuxaia();
	}

	[MangledName("?_Calculate_growth@?$vector@EV?$allocator@E@std@@@std@@AEBA_K_K@Z")]
	[DemangledName("private: unsigned __int64 __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Calculate_growth(unsigned __int64) const")]
	[CleanName("Calculate_growth")]
	public unsafe static long Calculate_growth_scmxisc(void* P_0, long P_1)
	{
		return GlobalFunctionImplementations.Calculate_growth_scmxisc(P_0, P_1);
	}

	[MangledName("??$_Allocate_at_least_helper@V?$allocator@E@std@@@std@@YAPEAEAEAV?$allocator@E@0@AEA_K@Z")]
	[DemangledName("unsigned char * __cdecl std::_Allocate_at_least_helper<class std::allocator<unsigned char>>(class std::allocator<unsigned char> &, unsigned __int64 &)")]
	[CleanName("Allocate_at_least_helper")]
	public unsafe static void* Allocate_at_least_helper_wikabbc(void* P_0, void* P_1)
	{
		void* result = GlobalFunctionImplementations.Allocate_at_least_helper_wikabbc(P_0, P_1);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$_Uninitialized_move@PEAEV?$allocator@E@std@@@std@@YAPEAEQEAE0PEAEAEAV?$allocator@E@0@@Z")]
	[DemangledName("unsigned char * __cdecl std::_Uninitialized_move<unsigned char *, class std::allocator<unsigned char>>(unsigned char *const, unsigned char *const, unsigned char *, class std::allocator<unsigned char> &)")]
	[CleanName("Uninitialized_move")]
	public unsafe static void* Uninitialized_move_vysyj4a(void* P_0, void* P_1, void* P_2, void* P_3)
	{
		return GlobalFunctionImplementations.Uninitialized_move_vysyj4a(P_0, P_1, P_2, P_3);
	}

	[MangledName("?_Change_array@?$vector@EV?$allocator@E@std@@@std@@AEAAXQEAE_K1@Z")]
	[DemangledName("private: void __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Change_array(unsigned char *const, unsigned __int64, unsigned __int64)")]
	[CleanName("Change_array")]
	public unsafe static void Change_array_k9lpzqa(void* P_0, void* P_1, long P_2, long P_3)
	{
		GlobalFunctionImplementations.Change_array_k9lpzqa(P_0, P_1, P_2, P_3);
	}

	[MangledName("??1_Reallocation_guard@?$vector@EV?$allocator@E@std@@@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Reallocation_guard::~_Reallocation_guard(void)")]
	[CleanName("Reallocation_guard_Destructor")]
	public unsafe static void Reallocation_guard_Destructor_9xb7gra(void* P_0)
	{
		GlobalFunctionImplementations.Reallocation_guard_Destructor_9xb7gra(P_0);
	}

	[MangledName("?max_size@?$_Default_allocator_traits@V?$allocator@E@std@@@std@@SA_KAEBV?$allocator@E@2@@Z")]
	[DemangledName("public: static unsigned __int64 __cdecl std::_Default_allocator_traits<class std::allocator<unsigned char>>::max_size(class std::allocator<unsigned char> const &)")]
	[CleanName("max_size")]
	public unsafe static long max_size_hv9dl3d(void* P_0)
	{
		return GlobalFunctionImplementations.max_size_hv9dl3d(P_0);
	}

	[MangledName("?_Getal@?$vector@EV?$allocator@E@std@@@std@@AEBAAEBV?$allocator@E@2@XZ")]
	[DemangledName("private: class std::allocator<unsigned char> const & __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Getal(void) const")]
	[CleanName("Getal")]
	public unsafe static void* Getal_llls4cc(void* P_0)
	{
		return GlobalFunctionImplementations.Getal_llls4cc(P_0);
	}

	[MangledName("?_Get_first@?$_Compressed_pair@V?$allocator@E@std@@V?$_Vector_val@U?$_Simple_types@E@std@@@2@$00@std@@QEBAAEBV?$allocator@E@2@XZ")]
	[DemangledName("public: class std::allocator<unsigned char> const & __cdecl std::_Compressed_pair<class std::allocator<unsigned char>, class std::_Vector_val<struct std::_Simple_types<unsigned char>>, 1>::_Get_first(void) const")]
	[CleanName("Get_first")]
	public unsafe static void* Get_first_pnsruja(void* P_0)
	{
		return GlobalFunctionImplementations.Get_first_pnsruja(P_0);
	}

	[MangledName("?capacity@?$vector@EV?$allocator@E@std@@@std@@QEBA_KXZ")]
	[DemangledName("public: unsigned __int64 __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::capacity(void) const")]
	[CleanName("capacity")]
	public unsafe static long capacity_mz5ysja(void* P_0)
	{
		return GlobalFunctionImplementations.capacity_mz5ysja(P_0);
	}

	[MangledName("?allocate@?$allocator@E@std@@QEAAPEAE_K@Z")]
	[DemangledName("public: unsigned char * __cdecl std::allocator<unsigned char>::allocate(unsigned __int64)")]
	[CleanName("allocate")]
	public unsafe static void* allocate_qfop4bd(void* P_0, long P_1)
	{
		void* result = GlobalFunctionImplementations.allocate_qfop4bd(P_0, P_1);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("??$_Get_size_of_n@$00@std@@YA_K_K@Z")]
	[DemangledName("unsigned __int64 __cdecl std::_Get_size_of_n<1>(unsigned __int64)")]
	[CleanName("Get_size_of_n")]
	public static long Get_size_of_n_iqtw9sb(long P_0)
	{
		return GlobalFunctionImplementations.Get_size_of_n_iqtw9sb(P_0);
	}

	[MangledName("??$_Get_unwrapped@AEBQEAE@std@@YA?A_TAEBQEAE@Z")]
	[DemangledName("decltype(auto) __cdecl std::_Get_unwrapped<unsigned char *const &>(unsigned char *const &)")]
	[CleanName("Get_unwrapped")]
	public unsafe static void* Get_unwrapped_z99fpma(void* P_0)
	{
		return GlobalFunctionImplementations.Get_unwrapped_z99fpma(P_0);
	}

	[MangledName("??$_Copy_memmove@PEAEPEAE@std@@YAPEAEPEAE00@Z")]
	[DemangledName("unsigned char * __cdecl std::_Copy_memmove<unsigned char *, unsigned char *>(unsigned char *, unsigned char *, unsigned char *)")]
	[CleanName("Copy_memmove")]
	public unsafe static void* Copy_memmove_2kkdavd(void* P_0, void* P_1, void* P_2)
	{
		return GlobalFunctionImplementations.Copy_memmove_2kkdavd(P_0, P_1, P_2);
	}

	[MangledName("??$_Unfancy@E@std@@YAPEAEPEAE@Z")]
	[DemangledName("unsigned char * __cdecl std::_Unfancy<unsigned char>(unsigned char *)")]
	[CleanName("Unfancy")]
	public unsafe static void* Unfancy_aszk3nc(void* P_0)
	{
		return GlobalFunctionImplementations.Unfancy_aszk3nc(P_0);
	}

	[MangledName("??$_To_address@PEAE@std@@YA?A_PAEBQEAE@Z")]
	[DemangledName("auto __cdecl std::_To_address<unsigned char *>(unsigned char *const &)")]
	[CleanName("To_address")]
	public unsafe static void* To_address_enkoctc(void* P_0)
	{
		return GlobalFunctionImplementations.To_address_enkoctc(P_0);
	}

	[MangledName("??$_Copy_memmove_tail@PEAE@std@@YAPEAEQEBDQEAE_K2@Z")]
	[DemangledName("unsigned char * __cdecl std::_Copy_memmove_tail<unsigned char *>(char const *const, unsigned char *const, unsigned __int64, unsigned __int64)")]
	[CleanName("Copy_memmove_tail")]
	public unsafe static void* Copy_memmove_tail_x7ipzed(void* P_0, void* P_1, long P_2, long P_3)
	{
		return GlobalFunctionImplementations.Copy_memmove_tail_x7ipzed(P_0, P_1, P_2, P_3);
	}

	[MangledName("?deallocate@?$allocator@E@std@@QEAAXQEAE_K@Z")]
	[DemangledName("public: void __cdecl std::allocator<unsigned char>::deallocate(unsigned char *const, unsigned __int64)")]
	[CleanName("deallocate")]
	public unsafe static void deallocate_mc9rbjc(void* P_0, void* P_1, long P_2)
	{
		GlobalFunctionImplementations.deallocate_mc9rbjc(P_0, P_1, P_2);
	}

	[MangledName("??$_Zero_range@PEAE@std@@YAPEAEQEAE0@Z")]
	[DemangledName("unsigned char * __cdecl std::_Zero_range<unsigned char *>(unsigned char *const, unsigned char *const)")]
	[CleanName("Zero_range")]
	public unsafe static void* Zero_range_927ahid(void* P_0, void* P_1)
	{
		return GlobalFunctionImplementations.Zero_range_927ahid(P_0, P_1);
	}

	[MangledName("??$_Unfancy_maybe_null@E@std@@YAPEAEPEAE@Z")]
	[DemangledName("unsigned char * __cdecl std::_Unfancy_maybe_null<unsigned char>(unsigned char *)")]
	[CleanName("Unfancy_maybe_null")]
	public unsafe static void* Unfancy_maybe_null_pj5f7cb(void* P_0)
	{
		return GlobalFunctionImplementations.Unfancy_maybe_null_pj5f7cb(P_0);
	}

	[MangledName("??$?0$$V@?$_Compressed_pair@V?$allocator@E@std@@V?$_Vector_val@U?$_Simple_types@E@std@@@2@$00@std@@QEAA@U_Zero_then_variadic_args_t@1@@Z")]
	[DemangledName("public: __cdecl std::_Compressed_pair<class std::allocator<unsigned char>, class std::_Vector_val<struct std::_Simple_types<unsigned char>>, 1>::_Compressed_pair<class std::allocator<unsigned char>, class std::_Vector_val<struct std::_Simple_types<unsigned char>>, 1><>(struct std::_Zero_then_variadic_args_t)")]
	public unsafe static void* Compressed_pair_class_std_allocator_unsigned_char_class_std_Vector_val_struct_std_Simple_types_unsigned_char_1_Constructor(void* P_0, sbyte P_1)
	{
		return GlobalFunctionImplementations.Compressed_pair_class_std_allocator_unsigned_char_class_std_Vector_val_struct_std_Simple_types_unsigned_char_1_Constructor(P_0, P_1);
	}

	[MangledName("??0?$allocator@E@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::allocator<unsigned char>::allocator<unsigned char>(void)")]
	public unsafe static void* allocator_unsigned_char_Constructor(void* P_0)
	{
		return GlobalFunctionImplementations.allocator_unsigned_char_Constructor(P_0);
	}

	[MangledName("??0?$_Vector_val@U?$_Simple_types@E@std@@@std@@QEAA@XZ")]
	[DemangledName("public: __cdecl std::_Vector_val<struct std::_Simple_types<unsigned char>>::_Vector_val<struct std::_Simple_types<unsigned char>>(void)")]
	public unsafe static void* Vector_val_struct_std_Simple_types_unsigned_char_Constructor(void* P_0)
	{
		return GlobalFunctionImplementations.Vector_val_struct_std_Simple_types_unsigned_char_Constructor(P_0);
	}

	[MangledName("?_Tidy@?$vector@EV?$allocator@E@std@@@std@@AEAAXXZ")]
	[DemangledName("private: void __cdecl std::vector<unsigned char, class std::allocator<unsigned char>>::_Tidy(void)")]
	[CleanName("Tidy")]
	public unsafe static void Tidy_iono57d(void* P_0)
	{
		GlobalFunctionImplementations.Tidy_iono57d(P_0);
	}

	[MangledName("?fpng_pixel_zlib_raw_decompress@fpng@@YA_NPEBEIIPEAEIIII@Z")]
	[DemangledName("bool __cdecl fpng::fpng_pixel_zlib_raw_decompress(unsigned char const *, unsigned int, unsigned int, unsigned char *, unsigned int, unsigned int, unsigned int, unsigned int)")]
	public unsafe static bool fpng_pixel_zlib_raw_decompress(void* P_0, int P_1, int P_2, void* P_3, int P_4, int P_5, int P_6, int P_7)
	{
		bool result = GlobalFunctionImplementations.fpng_pixel_zlib_raw_decompress(P_0, P_1, P_2, P_3, P_4, P_5, P_6, P_7);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?prepare_dynamic_block@fpng@@YA_NPEBEIAEAI1AEA_KPEAII@Z")]
	[DemangledName("bool __cdecl fpng::prepare_dynamic_block(unsigned char const *, unsigned int, unsigned int &, unsigned int &, unsigned __int64 &, unsigned int *, unsigned int)")]
	public unsafe static bool prepare_dynamic_block(void* P_0, int P_1, void* P_2, void* P_3, void* P_4, void* P_5, int P_6)
	{
		bool result = GlobalFunctionImplementations.prepare_dynamic_block(P_0, P_1, P_2, P_3, P_4, P_5, P_6);
		StackFrameList.ExitToUserCode();
		return result;
	}

	[MangledName("?build_decoder_table@fpng@@YA_NIPEAEPEAI@Z")]
	[DemangledName("bool __cdecl fpng::build_decoder_table(unsigned int, unsigned char *, unsigned int *)")]
	public unsafe static bool build_decoder_table(int P_0, void* P_1, void* P_2)
	{
		bool result = GlobalFunctionImplementations.build_decoder_table(P_0, P_1, P_2);
		StackFrameList.ExitToUserCode();
		return result;
	}
}
