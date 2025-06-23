using System;

namespace AssetRipper.Conversions.FastPng;

internal static partial class PointerIndices
{
	public unsafe static int GetIndex(void* ptr)
	{
		unchecked
		{
			if (ptr == (void*)(delegate*<void>)(&GlobalFunctionImplementations.fpng_init))
			{
				return 1;
			}
			if (ptr == (void*)(delegate*<bool>)(&GlobalFunctionImplementations.fpng_cpu_supports_sse41))
			{
				return 2;
			}
			if (ptr == (void*)(delegate*<void*, long, int, int>)(&GlobalFunctionImplementations.fpng_crc32))
			{
				return 3;
			}
			if (ptr == (void*)(delegate*<void*, long, int, int>)(&GlobalFunctionImplementations.crc32_slice_by_4))
			{
				return 4;
			}
			if (ptr == (void*)(delegate*<void*, long, int, int>)(&GlobalFunctionImplementations.fpng_adler32))
			{
				return 5;
			}
			if (ptr == (void*)(delegate*<void*, long, int, int>)(&GlobalFunctionImplementations.fpng_adler32_scalar))
			{
				return 6;
			}
			if (ptr == (void*)(delegate*<void*, int, int, int, void*, int, bool>)(&GlobalFunctionImplementations.fpng_encode_image_to_memory))
			{
				return 7;
			}
			if (ptr == (void*)(delegate*<bool>)(&GlobalFunctionImplementations.endian_check))
			{
				return 8;
			}
			if (ptr == (void*)(delegate*<void*, void*, int, void>)(&IntrinsicFunctions.Implemented.wassert))
			{
				return 9;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.vector_unsigned_char_class_std_allocator_unsigned_char_Constructor))
			{
				return 10;
			}
			if (ptr == (void*)(delegate*<void*, long, void>)(&GlobalFunctionImplementations.resize_wwmwtsa))
			{
				return 11;
			}
			if (ptr == (void*)(delegate*<ReadOnlySpan<nint>, int>)(&IntrinsicFunctions.Implemented.CxxFrameHandler3))
			{
				return 12;
			}
			if (ptr == (void*)(delegate*<void*, long, void*>)(&GlobalFunctionImplementations.operator_zukzlzc))
			{
				return 13;
			}
			if (ptr == (void*)(delegate*<int, int, int, int, int, void*, void*, void*, void>)(&GlobalFunctionImplementations.apply_filter))
			{
				return 14;
			}
			if (ptr == (void*)(delegate*<void*, int, int, void*, int, int>)(&GlobalFunctionImplementations.pixel_deflate_dyn_3_rle))
			{
				return 15;
			}
			if (ptr == (void*)(delegate*<void*, long>)(&GlobalFunctionImplementations.size_4io4p4d))
			{
				return 16;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.data_efhnzgd))
			{
				return 17;
			}
			if (ptr == (void*)(delegate*<void*, int, int, void*, int, int>)(&GlobalFunctionImplementations.pixel_deflate_dyn_3_rle_one_pass))
			{
				return 18;
			}
			if (ptr == (void*)(delegate*<void*, int, int, void*, int, int>)(&GlobalFunctionImplementations.pixel_deflate_dyn_4_rle))
			{
				return 19;
			}
			if (ptr == (void*)(delegate*<void*, int, int, void*, int, int>)(&GlobalFunctionImplementations.pixel_deflate_dyn_4_rle_one_pass))
			{
				return 20;
			}
			if (ptr == (void*)(delegate*<void*, int, void*, int, int>)(&GlobalFunctionImplementations.write_raw_block))
			{
				return 21;
			}
			if (ptr == (void*)(delegate*<void*, void*, long, bool, void>)(&IntrinsicFunctions.Implemented.llvm_memcpy_p0_p0_i64))
			{
				return 22;
			}
			if (ptr == (void*)(delegate*<void*, void*, long, void>)(&GlobalFunctionImplementations.vector_append))
			{
				return 23;
			}
			if (ptr == (void*)(delegate*<void*, void>)(&GlobalFunctionImplementations.vector_unsigned_char_class_std_allocator_unsigned_char_Destructor))
			{
				return 24;
			}
			if (ptr == (void*)(delegate*<void*, int, void*, void*, void*, int>)(&GlobalFunctionImplementations.fpng_get_info))
			{
				return 25;
			}
			if (ptr == (void*)(delegate*<void*, int, void*, void*, void*, void*, void*, int>)(&GlobalFunctionImplementations.fpng_get_info_internal))
			{
				return 26;
			}
			if (ptr == (void*)(delegate*<void*, int, void*, void*, void*, void*, int, int>)(&GlobalFunctionImplementations.fpng_decode_memory))
			{
				return 27;
			}
			if (ptr == (void*)(delegate*<void*, int, int, void*, int, int, bool>)(&GlobalFunctionImplementations.fpng_pixel_zlib_decompress_3_prmnnjb))
			{
				return 28;
			}
			if (ptr == (void*)(delegate*<void*, int, int, void*, int, int, bool>)(&GlobalFunctionImplementations.fpng_pixel_zlib_decompress_4_xygi9td))
			{
				return 29;
			}
			if (ptr == (void*)(delegate*<void*, int, int, void*, int, int, bool>)(&GlobalFunctionImplementations.fpng_pixel_zlib_decompress_3_yffw42c))
			{
				return 30;
			}
			if (ptr == (void*)(delegate*<void*, int, int, void*, int, int, bool>)(&GlobalFunctionImplementations.fpng_pixel_zlib_decompress_4_amptoaa))
			{
				return 31;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.allocator_unsigned_int_Constructor))
			{
				return 32;
			}
			if (ptr == (void*)(delegate*<void*, long, void*, void*>)(&GlobalFunctionImplementations.vector_unsigned_int_class_std_allocator_unsigned_int_Constructor))
			{
				return 33;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.data_uf9yj3b))
			{
				return 34;
			}
			if (ptr == (void*)(delegate*<void*, sbyte, long, bool, void>)(&IntrinsicFunctions.Implemented.llvm_memset_p0_i64))
			{
				return 35;
			}
			if (ptr == (void*)(delegate*<void*, int>)(&GlobalFunctionImplementations.READ_RGB_PIXEL))
			{
				return 36;
			}
			if (ptr == (void*)(delegate*<int, int, int>)(&GlobalFunctionImplementations.minimum_ymfg3kb))
			{
				return 37;
			}
			if (ptr == (void*)(delegate*<void*, long>)(&GlobalFunctionImplementations.size_wtrvsgc))
			{
				return 38;
			}
			if (ptr == (void*)(delegate*<int, void*, void*, void>)(&GlobalFunctionImplementations.adjust_freq32))
			{
				return 39;
			}
			if (ptr == (void*)(delegate*<void*, void*, void*, int, void*, void*, bool>)(&GlobalFunctionImplementations.defl_start_dynamic_block))
			{
				return 40;
			}
			if (ptr == (void*)(delegate*<void*, long, void*>)(&GlobalFunctionImplementations.operator_2nyjhmb))
			{
				return 41;
			}
			if (ptr == (void*)(delegate*<void*, void>)(&GlobalFunctionImplementations.vector_unsigned_int_class_std_allocator_unsigned_int_Destructor))
			{
				return 42;
			}
			if (ptr == (void*)(delegate*<void*, sbyte, void*, void*>)(&GlobalFunctionImplementations.Compressed_pair_class_std_allocator_unsigned_int_class_std_Vector_val_struct_std_Simple_types_unsigned_int_1_Constructor))
			{
				return 43;
			}
			if (ptr == (void*)(delegate*<void*, long, void>)(&GlobalFunctionImplementations.Construct_n))
			{
				return 44;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.Vector_val_struct_std_Simple_types_unsigned_int_Constructor))
			{
				return 45;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.Getal_t2pmqoc))
			{
				return 46;
			}
			if (ptr == (void*)(delegate*<void*, void*, void*, void*>)(&GlobalFunctionImplementations.Fake_proxy_ptr_impl_Constructor))
			{
				return 47;
			}
			if (ptr == (void*)(delegate*<void*, long, void>)(&GlobalFunctionImplementations.Buy_nonzero))
			{
				return 48;
			}
			if (ptr == (void*)(delegate*<void*, long, void*, void*>)(&GlobalFunctionImplementations.Uninitialized_value_construct_n_zg4iwva))
			{
				return 49;
			}
			if (ptr == (void*)(delegate*<void*, void>)(&GlobalFunctionImplementations.Tidy_guard_class_std_vector_unsigned_int_class_std_allocator_unsigned_int_Destructor))
			{
				return 50;
			}
			if (ptr == (void*)(delegate*<void*, void>)(&GlobalFunctionImplementations.Release))
			{
				return 51;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.Get_first_evhdorb))
			{
				return 52;
			}
			if (ptr == (void*)(delegate*<void*, long>)(&GlobalFunctionImplementations.max_size_qdwnpha))
			{
				return 53;
			}
			if (ptr == (void*)(delegate*<void>)(&GlobalFunctionImplementations.Xlength_nubzgpc))
			{
				return 54;
			}
			if (ptr == (void*)(delegate*<void*, long, void>)(&GlobalFunctionImplementations.Buy_raw))
			{
				return 55;
			}
			if (ptr == (void*)(delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.min))
			{
				return 56;
			}
			if (ptr == (void*)(delegate*<void*, long>)(&GlobalFunctionImplementations.max_size_snq294b))
			{
				return 57;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.Getal_r5wdlvb))
			{
				return 58;
			}
			if (ptr == (void*)(delegate*<long>)(&GlobalFunctionImplementations.Max_limit))
			{
				return 59;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.Get_first_gs7mvkc))
			{
				return 60;
			}
			if (ptr == (void*)(delegate*<void*, void>)(&IntrinsicFunctions.Unimplemented.Xlength_error))
			{
				return 61;
			}
			if (ptr == (void*)(delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.Allocate_at_least_helper_22hwyxd))
			{
				return 62;
			}
			if (ptr == (void*)(delegate*<void*, long, void*>)(&GlobalFunctionImplementations.allocate_wor4ptd))
			{
				return 63;
			}
			if (ptr == (void*)(delegate*<long, void*>)(&GlobalFunctionImplementations.Allocate_i4jzs2a))
			{
				return 64;
			}
			if (ptr == (void*)(delegate*<long, long>)(&GlobalFunctionImplementations.Get_size_of_n_rdjmi2b))
			{
				return 65;
			}
			if (ptr == (void*)(delegate*<long, void*>)(&GlobalFunctionImplementations.Allocate_manually_vector_aligned))
			{
				return 66;
			}
			if (ptr == (void*)(delegate*<long, void*>)(&GlobalFunctionImplementations.Allocate_ifu7fia))
			{
				return 67;
			}
			if (ptr == (void*)(delegate*<void>)(&GlobalFunctionImplementations.Throw_bad_array_new_length))
			{
				return 68;
			}
			if (ptr == (void*)(delegate*<void*, void*, void*, int, long, void>)(&IntrinsicFunctions.Implemented.invoke_watson))
			{
				return 69;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.bad_array_new_length_Constructor_fnjru5d))
			{
				return 70;
			}
			if (ptr == (void*)(delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.bad_array_new_length_Constructor_7fjuj3c))
			{
				return 71;
			}
			if (ptr == (void*)(delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.bad_alloc_Constructor_3vdoaxb))
			{
				return 72;
			}
			if (ptr == (void*)(delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.exception_Constructor_ikocrpb))
			{
				return 73;
			}
			if (ptr == (void*)(delegate*<void*, void>)(&GlobalFunctionImplementations.bad_array_new_length_Destructor))
			{
				return 74;
			}
			if (ptr == (void*)(delegate*<void*, void*, void>)(&IntrinsicFunctions.Implemented.CxxThrowException))
			{
				return 75;
			}
			if (ptr == (void*)(delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.bad_alloc_Constructor_72dj2ea))
			{
				return 76;
			}
			if (ptr == (void*)(delegate*<void*, int, void*>)(&GlobalFunctionImplementations.bad_array_new_length_Delete))
			{
				return 77;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.what))
			{
				return 78;
			}
			if (ptr == (void*)(delegate*<void*, void*, int, void*>)(&GlobalFunctionImplementations.exception_Constructor_morlzmd))
			{
				return 79;
			}
			if (ptr == (void*)(delegate*<void*, int, void*>)(&GlobalFunctionImplementations.bad_alloc_Delete))
			{
				return 80;
			}
			if (ptr == (void*)(delegate*<void*, int, void*>)(&GlobalFunctionImplementations.exception_Delete))
			{
				return 81;
			}
			if (ptr == (void*)(delegate*<void*, void>)(&GlobalFunctionImplementations.exception_Destructor))
			{
				return 82;
			}
			if (ptr == (void*)(delegate*<void*, long, void>)(&IntrinsicFunctions.Implemented.Delete))
			{
				return 83;
			}
			if (ptr == (void*)(delegate*<void*, void>)(&IntrinsicFunctions.Unimplemented.std_exception_destroy))
			{
				return 84;
			}
			if (ptr == (void*)(delegate*<void>)(&IntrinsicFunctions.Implemented.std_terminate))
			{
				return 85;
			}
			if (ptr == (void*)(delegate*<void*, void>)(&GlobalFunctionImplementations.bad_alloc_Destructor))
			{
				return 86;
			}
			if (ptr == (void*)(delegate*<void*, void*, void>)(&IntrinsicFunctions.Unimplemented.std_exception_copy))
			{
				return 87;
			}
			if (ptr == (void*)(delegate*<long, void*>)(&IntrinsicFunctions.Implemented.New))
			{
				return 88;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.Unfancy_xjzn42c))
			{
				return 89;
			}
			if (ptr == (void*)(delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.Zero_range_dc39dpa))
			{
				return 90;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.To_address_aoz7nfb))
			{
				return 91;
			}
			if (ptr == (void*)(delegate*<void*, void>)(&GlobalFunctionImplementations.Tidy_kyqxybb))
			{
				return 92;
			}
			if (ptr == (void*)(delegate*<void*, void>)(&GlobalFunctionImplementations.Orphan_all))
			{
				return 93;
			}
			if (ptr == (void*)(delegate*<void*, void*, void*, void>)(&GlobalFunctionImplementations.Destroy_range_9rluabc))
			{
				return 94;
			}
			if (ptr == (void*)(delegate*<void*, void*, long, void>)(&GlobalFunctionImplementations.deallocate_gfl4ncc))
			{
				return 95;
			}
			if (ptr == (void*)(delegate*<void*, long, void>)(&GlobalFunctionImplementations.Deallocate))
			{
				return 96;
			}
			if (ptr == (void*)(delegate*<void*, void*, void>)(&GlobalFunctionImplementations.Adjust_manually_vector_aligned))
			{
				return 97;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.Unfancy_maybe_null_ys5czvb))
			{
				return 98;
			}
			if (ptr == (void*)(delegate*<int, int, int>)(&GlobalFunctionImplementations.maximum_y5wzmwb))
			{
				return 99;
			}
			if (ptr == (void*)(delegate*<void*, int, int, int, int, void>)(&GlobalFunctionImplementations.defl_optimize_huffman_table))
			{
				return 100;
			}
			if (ptr == (void*)(delegate*<int, int, int>)(&GlobalFunctionImplementations.maximum_sfjssib))
			{
				return 101;
			}
			if (ptr == (void*)(delegate*<int, void*, void*, void*>)(&GlobalFunctionImplementations.defl_radix_sort_syms))
			{
				return 102;
			}
			if (ptr == (void*)(delegate*<void*, int, void>)(&GlobalFunctionImplementations.defl_calculate_minimum_redundancy))
			{
				return 103;
			}
			if (ptr == (void*)(delegate*<void*, int, int, void>)(&GlobalFunctionImplementations.defl_huffman_enforce_max_code_size))
			{
				return 104;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.vector_unsigned_int64_class_std_allocator_unsigned_int64_Constructor))
			{
				return 105;
			}
			if (ptr == (void*)(delegate*<void*, long, void>)(&GlobalFunctionImplementations.resize_d4pmvud))
			{
				return 106;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.data_dtgl25a))
			{
				return 107;
			}
			if (ptr == (void*)(delegate*<void*, long>)(&GlobalFunctionImplementations.size_trt5i3d))
			{
				return 108;
			}
			if (ptr == (void*)(delegate*<void*, long, void*>)(&GlobalFunctionImplementations.operator_7d577ub))
			{
				return 109;
			}
			if (ptr == (void*)(delegate*<void*, void>)(&GlobalFunctionImplementations.vector_unsigned_int64_class_std_allocator_unsigned_int64_Destructor))
			{
				return 110;
			}
			if (ptr == (void*)(delegate*<void*, sbyte, void*>)(&GlobalFunctionImplementations.Compressed_pair_class_std_allocator_unsigned_int64_class_std_Vector_val_struct_std_Simple_types_unsigned_int64_1_Constructor))
			{
				return 111;
			}
			if (ptr == (void*)(delegate*<void*, void*, void>)(&GlobalFunctionImplementations.Alloc_proxy))
			{
				return 112;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.allocator_unsigned_int64_Constructor))
			{
				return 113;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.Vector_val_struct_std_Simple_types_unsigned_int64_Constructor))
			{
				return 114;
			}
			if (ptr == (void*)(delegate*<void*, long, void*, void>)(&GlobalFunctionImplementations.Resize_2s9rs9d))
			{
				return 115;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.Getal_kuj7nva))
			{
				return 116;
			}
			if (ptr == (void*)(delegate*<void*, void*, void*, void>)(&GlobalFunctionImplementations.Orphan_range_qciws4b))
			{
				return 117;
			}
			if (ptr == (void*)(delegate*<void*, void*, void*, void>)(&GlobalFunctionImplementations.Destroy_range_qbzp7xb))
			{
				return 118;
			}
			if (ptr == (void*)(delegate*<void*, long, void*, void>)(&GlobalFunctionImplementations.Resize_reallocate_ytnsorc))
			{
				return 119;
			}
			if (ptr == (void*)(delegate*<void*, long, void*, void*>)(&GlobalFunctionImplementations.Uninitialized_value_construct_n_hqowyoc))
			{
				return 120;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.Get_first_whlbtqb))
			{
				return 121;
			}
			if (ptr == (void*)(delegate*<void*, long>)(&GlobalFunctionImplementations.max_size_kyvxnnb))
			{
				return 122;
			}
			if (ptr == (void*)(delegate*<void>)(&GlobalFunctionImplementations.Xlength_zmqdsxa))
			{
				return 123;
			}
			if (ptr == (void*)(delegate*<void*, long, long>)(&GlobalFunctionImplementations.Calculate_growth_vbhwmec))
			{
				return 124;
			}
			if (ptr == (void*)(delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.Allocate_at_least_helper_l9zi7qb))
			{
				return 125;
			}
			if (ptr == (void*)(delegate*<void*, void*, void*, void*, void*>)(&GlobalFunctionImplementations.Uninitialized_move_cbc4pbc))
			{
				return 126;
			}
			if (ptr == (void*)(delegate*<void*, void*, long, long, void>)(&GlobalFunctionImplementations.Change_array_hgqy2vc))
			{
				return 127;
			}
			if (ptr == (void*)(delegate*<void*, void>)(&GlobalFunctionImplementations.Reallocation_guard_Destructor_jfaqped))
			{
				return 128;
			}
			if (ptr == (void*)(delegate*<void*, long>)(&GlobalFunctionImplementations.max_size_ngjedfc))
			{
				return 129;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.Getal_2reycsb))
			{
				return 130;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.Get_first_gcgh4xa))
			{
				return 131;
			}
			if (ptr == (void*)(delegate*<void*, long>)(&GlobalFunctionImplementations.capacity_f49yk4c))
			{
				return 132;
			}
			if (ptr == (void*)(delegate*<void*, long, void*>)(&GlobalFunctionImplementations.allocate_4vpkydd))
			{
				return 133;
			}
			if (ptr == (void*)(delegate*<long, long>)(&GlobalFunctionImplementations.Get_size_of_n_siqup9d))
			{
				return 134;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.Get_unwrapped_3jsimya))
			{
				return 135;
			}
			if (ptr == (void*)(delegate*<void*, void*, void*, void*>)(&GlobalFunctionImplementations.Copy_memmove_uofrjzc))
			{
				return 136;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.Unfancy_z2hkbxa))
			{
				return 137;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.To_address_l9253rd))
			{
				return 138;
			}
			if (ptr == (void*)(delegate*<void*, void*, long, long, void*>)(&GlobalFunctionImplementations.Copy_memmove_tail_oluaukc))
			{
				return 139;
			}
			if (ptr == (void*)(delegate*<void*, void*, long, bool, void>)(&IntrinsicFunctions.Implemented.llvm_memmove_p0_p0_i64))
			{
				return 140;
			}
			if (ptr == (void*)(delegate*<void*, void*, long, void>)(&GlobalFunctionImplementations.deallocate_yb2gvqa))
			{
				return 141;
			}
			if (ptr == (void*)(delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.Zero_range_lx9svca))
			{
				return 142;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.Unfancy_maybe_null_uqd3pbd))
			{
				return 143;
			}
			if (ptr == (void*)(delegate*<void*, void>)(&GlobalFunctionImplementations.Tidy_hq3jjxb))
			{
				return 144;
			}
			if (ptr == (void*)(delegate*<int, int, int>)(&GlobalFunctionImplementations.minimum_su2nfub))
			{
				return 145;
			}
			if (ptr == (void*)(delegate*<void*, void*, long, int>)(&IntrinsicFunctions.Implemented.memcmp))
			{
				return 146;
			}
			if (ptr == (void*)(delegate*<int, int>)(&GlobalFunctionImplementations.swap32))
			{
				return 147;
			}
			if (ptr == (void*)(delegate*<void*, void*, int>)(&IntrinsicFunctions.Implemented.strcmp))
			{
				return 148;
			}
			if (ptr == (void*)(delegate*<int, int>)(&IntrinsicFunctions.Implemented.llvm_bswap_i32))
			{
				return 149;
			}
			if (ptr == (void*)(delegate*<void*, long, void*, void>)(&GlobalFunctionImplementations.Resize_p4x2rua))
			{
				return 150;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.Getal_jms5hzb))
			{
				return 151;
			}
			if (ptr == (void*)(delegate*<void*, void*, void*, void>)(&GlobalFunctionImplementations.Orphan_range_334quvb))
			{
				return 152;
			}
			if (ptr == (void*)(delegate*<void*, void*, void*, void>)(&GlobalFunctionImplementations.Destroy_range_jjcob5a))
			{
				return 153;
			}
			if (ptr == (void*)(delegate*<void*, long, void*, void>)(&GlobalFunctionImplementations.Resize_reallocate_dt5hjdb))
			{
				return 154;
			}
			if (ptr == (void*)(delegate*<void*, long, void*, void*>)(&GlobalFunctionImplementations.Uninitialized_value_construct_n_cxm3ryd))
			{
				return 155;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.Get_first_nkl7psd))
			{
				return 156;
			}
			if (ptr == (void*)(delegate*<void*, long>)(&GlobalFunctionImplementations.max_size_2yjes5b))
			{
				return 157;
			}
			if (ptr == (void*)(delegate*<void>)(&GlobalFunctionImplementations.Xlength_zpuxaia))
			{
				return 158;
			}
			if (ptr == (void*)(delegate*<void*, long, long>)(&GlobalFunctionImplementations.Calculate_growth_scmxisc))
			{
				return 159;
			}
			if (ptr == (void*)(delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.Allocate_at_least_helper_wikabbc))
			{
				return 160;
			}
			if (ptr == (void*)(delegate*<void*, void*, void*, void*, void*>)(&GlobalFunctionImplementations.Uninitialized_move_vysyj4a))
			{
				return 161;
			}
			if (ptr == (void*)(delegate*<void*, void*, long, long, void>)(&GlobalFunctionImplementations.Change_array_k9lpzqa))
			{
				return 162;
			}
			if (ptr == (void*)(delegate*<void*, void>)(&GlobalFunctionImplementations.Reallocation_guard_Destructor_9xb7gra))
			{
				return 163;
			}
			if (ptr == (void*)(delegate*<void*, long>)(&GlobalFunctionImplementations.max_size_hv9dl3d))
			{
				return 164;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.Getal_llls4cc))
			{
				return 165;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.Get_first_pnsruja))
			{
				return 166;
			}
			if (ptr == (void*)(delegate*<void*, long>)(&GlobalFunctionImplementations.capacity_mz5ysja))
			{
				return 167;
			}
			if (ptr == (void*)(delegate*<void*, long, void*>)(&GlobalFunctionImplementations.allocate_qfop4bd))
			{
				return 168;
			}
			if (ptr == (void*)(delegate*<long, long>)(&GlobalFunctionImplementations.Get_size_of_n_iqtw9sb))
			{
				return 169;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.Get_unwrapped_z99fpma))
			{
				return 170;
			}
			if (ptr == (void*)(delegate*<void*, void*, void*, void*>)(&GlobalFunctionImplementations.Copy_memmove_2kkdavd))
			{
				return 171;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.Unfancy_aszk3nc))
			{
				return 172;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.To_address_enkoctc))
			{
				return 173;
			}
			if (ptr == (void*)(delegate*<void*, void*, long, long, void*>)(&GlobalFunctionImplementations.Copy_memmove_tail_x7ipzed))
			{
				return 174;
			}
			if (ptr == (void*)(delegate*<void*, void*, long, void>)(&GlobalFunctionImplementations.deallocate_mc9rbjc))
			{
				return 175;
			}
			if (ptr == (void*)(delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.Zero_range_927ahid))
			{
				return 176;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.Unfancy_maybe_null_pj5f7cb))
			{
				return 177;
			}
			if (ptr == (void*)(delegate*<void*, sbyte, void*>)(&GlobalFunctionImplementations.Compressed_pair_class_std_allocator_unsigned_char_class_std_Vector_val_struct_std_Simple_types_unsigned_char_1_Constructor))
			{
				return 178;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.allocator_unsigned_char_Constructor))
			{
				return 179;
			}
			if (ptr == (void*)(delegate*<void*, void*>)(&GlobalFunctionImplementations.Vector_val_struct_std_Simple_types_unsigned_char_Constructor))
			{
				return 180;
			}
			if (ptr == (void*)(delegate*<void*, void>)(&GlobalFunctionImplementations.Tidy_iono57d))
			{
				return 181;
			}
			if (ptr == (void*)(delegate*<void*, int, int, void*, int, int, int, int, bool>)(&GlobalFunctionImplementations.fpng_pixel_zlib_raw_decompress))
			{
				return 182;
			}
			if (ptr == (void*)(delegate*<void*, int, void*, void*, void*, void*, int, bool>)(&GlobalFunctionImplementations.prepare_dynamic_block))
			{
				return 183;
			}
			if (ptr == (void*)(delegate*<int, void*, void*, bool>)(&GlobalFunctionImplementations.build_decoder_table))
			{
				return 184;
			}
			if (ptr == GlobalVariablePointers.Avx2WmemEnabledWeakValue)
			{
				return -1;
			}
			if (ptr == GlobalVariablePointers.String_uxbkrtb)
			{
				return -2;
			}
			if (ptr == GlobalVariablePointers.String_kdrammb)
			{
				return -3;
			}
			if (ptr == GlobalVariablePointers.String_bik4erc)
			{
				return -4;
			}
			if (ptr == GlobalVariablePointers.String_dqvhqxc)
			{
				return -5;
			}
			if (ptr == GlobalVariablePointers.s_color_type)
			{
				return -6;
			}
			if (ptr == GlobalVariablePointers.String_nz3h57a)
			{
				return -7;
			}
			if (ptr == GlobalVariablePointers.g_crc32_4)
			{
				return -8;
			}
			if (ptr == GlobalVariablePointers.String_uc52kza)
			{
				return -9;
			}
			if (ptr == GlobalVariablePointers.String_9hewgtd)
			{
				return -10;
			}
			if (ptr == GlobalVariablePointers.String_ooiduua)
			{
				return -11;
			}
			if (ptr == GlobalVariablePointers.String_mggwlgb)
			{
				return -12;
			}
			if (ptr == GlobalVariablePointers.g_defl_len_sym)
			{
				return -13;
			}
			if (ptr == GlobalVariablePointers.String_bjvsuxc)
			{
				return -14;
			}
			if (ptr == GlobalVariablePointers.String_hsgehfc)
			{
				return -15;
			}
			if (ptr == GlobalVariablePointers.String_vpte4cc)
			{
				return -16;
			}
			if (ptr == GlobalVariablePointers.String_df5ko9b)
			{
				return -17;
			}
			if (ptr == GlobalVariablePointers.String_isj2lib)
			{
				return -18;
			}
			if (ptr == GlobalVariablePointers.g_bitmasks)
			{
				return -19;
			}
			if (ptr == GlobalVariablePointers.g_defl_len_extra)
			{
				return -20;
			}
			if (ptr == GlobalVariablePointers.String_2ej5tjb)
			{
				return -21;
			}
			if (ptr == GlobalVariablePointers.String_7b7kt9c)
			{
				return -22;
			}
			if (ptr == GlobalVariablePointers._7type_info)
			{
				return -23;
			}
			if (ptr == GlobalVariablePointers.R0_AVbad_array_new_length)
			{
				return -24;
			}
			if (ptr == GlobalVariablePointers.ImageBase)
			{
				return -25;
			}
			if (ptr == GlobalVariablePointers.CT_R0_AVbad_array_new_length_std_8_0bad_array_new_length_std_QEAA_AEBV01_Z24)
			{
				return -26;
			}
			if (ptr == GlobalVariablePointers.R0_AVbad_alloc)
			{
				return -27;
			}
			if (ptr == GlobalVariablePointers.CT_R0_AVbad_alloc_std_8_0bad_alloc_std_QEAA_AEBV01_Z24)
			{
				return -28;
			}
			if (ptr == GlobalVariablePointers.R0_AVexception)
			{
				return -29;
			}
			if (ptr == GlobalVariablePointers.CT_R0_AVexception_std_8_0exception_std_QEAA_AEBV01_Z24)
			{
				return -30;
			}
			if (ptr == GlobalVariablePointers.CTA3_AVbad_array_new_length_std)
			{
				return -31;
			}
			if (ptr == GlobalVariablePointers.TI3_AVbad_array_new_length_std)
			{
				return -32;
			}
			if (ptr == GlobalVariablePointers.String_gudorqc)
			{
				return -33;
			}
			if (ptr == GlobalVariablePointers.Variable_4yxjuqa)
			{
				return -34;
			}
			if (ptr == GlobalVariablePointers.R4bad_array_new_length)
			{
				return -35;
			}
			if (ptr == GlobalVariablePointers.R3bad_array_new_length)
			{
				return -36;
			}
			if (ptr == GlobalVariablePointers.R2bad_array_new_length)
			{
				return -37;
			}
			if (ptr == GlobalVariablePointers.R1A_9w7p7zd)
			{
				return -38;
			}
			if (ptr == GlobalVariablePointers.R1A_vzsilob)
			{
				return -39;
			}
			if (ptr == GlobalVariablePointers.R3bad_alloc)
			{
				return -40;
			}
			if (ptr == GlobalVariablePointers.R2bad_alloc)
			{
				return -41;
			}
			if (ptr == GlobalVariablePointers.R1A_bbqer2a)
			{
				return -42;
			}
			if (ptr == GlobalVariablePointers.R3exception)
			{
				return -43;
			}
			if (ptr == GlobalVariablePointers.R2exception)
			{
				return -44;
			}
			if (ptr == GlobalVariablePointers.Variable_zdor9mc)
			{
				return -45;
			}
			if (ptr == GlobalVariablePointers.R4bad_alloc)
			{
				return -46;
			}
			if (ptr == GlobalVariablePointers.Variable_x4f2ufc)
			{
				return -47;
			}
			if (ptr == GlobalVariablePointers.R4exception)
			{
				return -48;
			}
			if (ptr == GlobalVariablePointers.String_ja3ma5d)
			{
				return -49;
			}
			if (ptr == GlobalVariablePointers.g_defl_packed_code_size_syms_swizzle)
			{
				return -50;
			}
			if (ptr == GlobalVariablePointers.String_erkdsbd)
			{
				return -51;
			}
			if (ptr == GlobalVariablePointers.String_o9ulvgb)
			{
				return -52;
			}
			if (ptr == GlobalVariablePointers.g_dyn_huff_3)
			{
				return -53;
			}
			if (ptr == GlobalVariablePointers.g_dyn_huff_3_codes)
			{
				return -54;
			}
			if (ptr == GlobalVariablePointers.g_dyn_huff_4)
			{
				return -55;
			}
			if (ptr == GlobalVariablePointers.g_dyn_huff_4_codes)
			{
				return -56;
			}
			if (ptr == GlobalVariablePointers.s_png_sig)
			{
				return -57;
			}
			if (ptr == GlobalVariablePointers.String_qjc9xdd)
			{
				return -58;
			}
			if (ptr == GlobalVariablePointers.String_p7olgfc)
			{
				return -59;
			}
			if (ptr == GlobalVariablePointers.String_22lii4a)
			{
				return -60;
			}
			if (ptr == GlobalVariablePointers.String_497patd)
			{
				return -61;
			}
			if (ptr == GlobalVariablePointers.String_aa3exrc)
			{
				return -62;
			}
			if (ptr == GlobalVariablePointers.String_ktv524d)
			{
				return -63;
			}
			if (ptr == GlobalVariablePointers.String_mf9hyza)
			{
				return -64;
			}
			if (ptr == GlobalVariablePointers.s_length_range)
			{
				return -65;
			}
			if (ptr == GlobalVariablePointers.s_length_extra)
			{
				return -66;
			}
			if (ptr == GlobalVariablePointers.String_ftb25bb)
			{
				return -67;
			}
			if (ptr == GlobalVariablePointers.String_bahgbqd)
			{
				return -68;
			}
			if (ptr == GlobalVariablePointers.String_a5rp7bb)
			{
				return -69;
			}
			if (ptr == GlobalVariablePointers.g_run_len3_to_4)
			{
				return -70;
			}
			if (ptr == GlobalVariablePointers.String_zixkhbc)
			{
				return -71;
			}
			if (ptr == GlobalVariablePointers.String_kppxlqc)
			{
				return -72;
			}
			if (ptr == GlobalVariablePointers.String_ji2h3xd)
			{
				return -73;
			}
			if (ptr == GlobalVariablePointers.s_bit_length_order)
			{
				return -74;
			}
			if (ptr == GlobalVariablePointers.String_nlshwsc)
			{
				return -75;
			}
			if (ptr == GlobalVariablePointers.String_32otbnd)
			{
				return -76;
			}
			return 0;
		}
	}

	public unsafe static void* GetPointer(int index)
	{
		return index switch
		{
			1 => (delegate*<void>)(&GlobalFunctionImplementations.fpng_init), 
			2 => (delegate*<bool>)(&GlobalFunctionImplementations.fpng_cpu_supports_sse41), 
			3 => (delegate*<void*, long, int, int>)(&GlobalFunctionImplementations.fpng_crc32), 
			4 => (delegate*<void*, long, int, int>)(&GlobalFunctionImplementations.crc32_slice_by_4), 
			5 => (delegate*<void*, long, int, int>)(&GlobalFunctionImplementations.fpng_adler32), 
			6 => (delegate*<void*, long, int, int>)(&GlobalFunctionImplementations.fpng_adler32_scalar), 
			7 => (delegate*<void*, int, int, int, void*, int, bool>)(&GlobalFunctionImplementations.fpng_encode_image_to_memory), 
			8 => (delegate*<bool>)(&GlobalFunctionImplementations.endian_check), 
			9 => (delegate*<void*, void*, int, void>)(&IntrinsicFunctions.Implemented.wassert), 
			10 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.vector_unsigned_char_class_std_allocator_unsigned_char_Constructor), 
			11 => (delegate*<void*, long, void>)(&GlobalFunctionImplementations.resize_wwmwtsa), 
			12 => (delegate*<ReadOnlySpan<nint>, int>)(&IntrinsicFunctions.Implemented.CxxFrameHandler3), 
			13 => (delegate*<void*, long, void*>)(&GlobalFunctionImplementations.operator_zukzlzc), 
			14 => (delegate*<int, int, int, int, int, void*, void*, void*, void>)(&GlobalFunctionImplementations.apply_filter), 
			15 => (delegate*<void*, int, int, void*, int, int>)(&GlobalFunctionImplementations.pixel_deflate_dyn_3_rle), 
			16 => (delegate*<void*, long>)(&GlobalFunctionImplementations.size_4io4p4d), 
			17 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.data_efhnzgd), 
			18 => (delegate*<void*, int, int, void*, int, int>)(&GlobalFunctionImplementations.pixel_deflate_dyn_3_rle_one_pass), 
			19 => (delegate*<void*, int, int, void*, int, int>)(&GlobalFunctionImplementations.pixel_deflate_dyn_4_rle), 
			20 => (delegate*<void*, int, int, void*, int, int>)(&GlobalFunctionImplementations.pixel_deflate_dyn_4_rle_one_pass), 
			21 => (delegate*<void*, int, void*, int, int>)(&GlobalFunctionImplementations.write_raw_block), 
			22 => (delegate*<void*, void*, long, bool, void>)(&IntrinsicFunctions.Implemented.llvm_memcpy_p0_p0_i64), 
			23 => (delegate*<void*, void*, long, void>)(&GlobalFunctionImplementations.vector_append), 
			24 => (delegate*<void*, void>)(&GlobalFunctionImplementations.vector_unsigned_char_class_std_allocator_unsigned_char_Destructor), 
			25 => (delegate*<void*, int, void*, void*, void*, int>)(&GlobalFunctionImplementations.fpng_get_info), 
			26 => (delegate*<void*, int, void*, void*, void*, void*, void*, int>)(&GlobalFunctionImplementations.fpng_get_info_internal), 
			27 => (delegate*<void*, int, void*, void*, void*, void*, int, int>)(&GlobalFunctionImplementations.fpng_decode_memory), 
			28 => (delegate*<void*, int, int, void*, int, int, bool>)(&GlobalFunctionImplementations.fpng_pixel_zlib_decompress_3_prmnnjb), 
			29 => (delegate*<void*, int, int, void*, int, int, bool>)(&GlobalFunctionImplementations.fpng_pixel_zlib_decompress_4_xygi9td), 
			30 => (delegate*<void*, int, int, void*, int, int, bool>)(&GlobalFunctionImplementations.fpng_pixel_zlib_decompress_3_yffw42c), 
			31 => (delegate*<void*, int, int, void*, int, int, bool>)(&GlobalFunctionImplementations.fpng_pixel_zlib_decompress_4_amptoaa), 
			32 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.allocator_unsigned_int_Constructor), 
			33 => (delegate*<void*, long, void*, void*>)(&GlobalFunctionImplementations.vector_unsigned_int_class_std_allocator_unsigned_int_Constructor), 
			34 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.data_uf9yj3b), 
			35 => (delegate*<void*, sbyte, long, bool, void>)(&IntrinsicFunctions.Implemented.llvm_memset_p0_i64), 
			36 => (delegate*<void*, int>)(&GlobalFunctionImplementations.READ_RGB_PIXEL), 
			37 => (delegate*<int, int, int>)(&GlobalFunctionImplementations.minimum_ymfg3kb), 
			38 => (delegate*<void*, long>)(&GlobalFunctionImplementations.size_wtrvsgc), 
			39 => (delegate*<int, void*, void*, void>)(&GlobalFunctionImplementations.adjust_freq32), 
			40 => (delegate*<void*, void*, void*, int, void*, void*, bool>)(&GlobalFunctionImplementations.defl_start_dynamic_block), 
			41 => (delegate*<void*, long, void*>)(&GlobalFunctionImplementations.operator_2nyjhmb), 
			42 => (delegate*<void*, void>)(&GlobalFunctionImplementations.vector_unsigned_int_class_std_allocator_unsigned_int_Destructor), 
			43 => (delegate*<void*, sbyte, void*, void*>)(&GlobalFunctionImplementations.Compressed_pair_class_std_allocator_unsigned_int_class_std_Vector_val_struct_std_Simple_types_unsigned_int_1_Constructor), 
			44 => (delegate*<void*, long, void>)(&GlobalFunctionImplementations.Construct_n), 
			45 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.Vector_val_struct_std_Simple_types_unsigned_int_Constructor), 
			46 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.Getal_t2pmqoc), 
			47 => (delegate*<void*, void*, void*, void*>)(&GlobalFunctionImplementations.Fake_proxy_ptr_impl_Constructor), 
			48 => (delegate*<void*, long, void>)(&GlobalFunctionImplementations.Buy_nonzero), 
			49 => (delegate*<void*, long, void*, void*>)(&GlobalFunctionImplementations.Uninitialized_value_construct_n_zg4iwva), 
			50 => (delegate*<void*, void>)(&GlobalFunctionImplementations.Tidy_guard_class_std_vector_unsigned_int_class_std_allocator_unsigned_int_Destructor), 
			51 => (delegate*<void*, void>)(&GlobalFunctionImplementations.Release), 
			52 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.Get_first_evhdorb), 
			53 => (delegate*<void*, long>)(&GlobalFunctionImplementations.max_size_qdwnpha), 
			54 => (delegate*<void>)(&GlobalFunctionImplementations.Xlength_nubzgpc), 
			55 => (delegate*<void*, long, void>)(&GlobalFunctionImplementations.Buy_raw), 
			56 => (delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.min), 
			57 => (delegate*<void*, long>)(&GlobalFunctionImplementations.max_size_snq294b), 
			58 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.Getal_r5wdlvb), 
			59 => (delegate*<long>)(&GlobalFunctionImplementations.Max_limit), 
			60 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.Get_first_gs7mvkc), 
			61 => (delegate*<void*, void>)(&IntrinsicFunctions.Unimplemented.Xlength_error), 
			62 => (delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.Allocate_at_least_helper_22hwyxd), 
			63 => (delegate*<void*, long, void*>)(&GlobalFunctionImplementations.allocate_wor4ptd), 
			64 => (delegate*<long, void*>)(&GlobalFunctionImplementations.Allocate_i4jzs2a), 
			65 => (delegate*<long, long>)(&GlobalFunctionImplementations.Get_size_of_n_rdjmi2b), 
			66 => (delegate*<long, void*>)(&GlobalFunctionImplementations.Allocate_manually_vector_aligned), 
			67 => (delegate*<long, void*>)(&GlobalFunctionImplementations.Allocate_ifu7fia), 
			68 => (delegate*<void>)(&GlobalFunctionImplementations.Throw_bad_array_new_length), 
			69 => (delegate*<void*, void*, void*, int, long, void>)(&IntrinsicFunctions.Implemented.invoke_watson), 
			70 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.bad_array_new_length_Constructor_fnjru5d), 
			71 => (delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.bad_array_new_length_Constructor_7fjuj3c), 
			72 => (delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.bad_alloc_Constructor_3vdoaxb), 
			73 => (delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.exception_Constructor_ikocrpb), 
			74 => (delegate*<void*, void>)(&GlobalFunctionImplementations.bad_array_new_length_Destructor), 
			75 => (delegate*<void*, void*, void>)(&IntrinsicFunctions.Implemented.CxxThrowException), 
			76 => (delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.bad_alloc_Constructor_72dj2ea), 
			77 => (delegate*<void*, int, void*>)(&GlobalFunctionImplementations.bad_array_new_length_Delete), 
			78 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.what), 
			79 => (delegate*<void*, void*, int, void*>)(&GlobalFunctionImplementations.exception_Constructor_morlzmd), 
			80 => (delegate*<void*, int, void*>)(&GlobalFunctionImplementations.bad_alloc_Delete), 
			81 => (delegate*<void*, int, void*>)(&GlobalFunctionImplementations.exception_Delete), 
			82 => (delegate*<void*, void>)(&GlobalFunctionImplementations.exception_Destructor), 
			83 => (delegate*<void*, long, void>)(&IntrinsicFunctions.Implemented.Delete), 
			84 => (delegate*<void*, void>)(&IntrinsicFunctions.Unimplemented.std_exception_destroy), 
			85 => (delegate*<void>)(&IntrinsicFunctions.Implemented.std_terminate), 
			86 => (delegate*<void*, void>)(&GlobalFunctionImplementations.bad_alloc_Destructor), 
			87 => (delegate*<void*, void*, void>)(&IntrinsicFunctions.Unimplemented.std_exception_copy), 
			88 => (delegate*<long, void*>)(&IntrinsicFunctions.Implemented.New), 
			89 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.Unfancy_xjzn42c), 
			90 => (delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.Zero_range_dc39dpa), 
			91 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.To_address_aoz7nfb), 
			92 => (delegate*<void*, void>)(&GlobalFunctionImplementations.Tidy_kyqxybb), 
			93 => (delegate*<void*, void>)(&GlobalFunctionImplementations.Orphan_all), 
			94 => (delegate*<void*, void*, void*, void>)(&GlobalFunctionImplementations.Destroy_range_9rluabc), 
			95 => (delegate*<void*, void*, long, void>)(&GlobalFunctionImplementations.deallocate_gfl4ncc), 
			96 => (delegate*<void*, long, void>)(&GlobalFunctionImplementations.Deallocate), 
			97 => (delegate*<void*, void*, void>)(&GlobalFunctionImplementations.Adjust_manually_vector_aligned), 
			98 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.Unfancy_maybe_null_ys5czvb), 
			99 => (delegate*<int, int, int>)(&GlobalFunctionImplementations.maximum_y5wzmwb), 
			100 => (delegate*<void*, int, int, int, int, void>)(&GlobalFunctionImplementations.defl_optimize_huffman_table), 
			101 => (delegate*<int, int, int>)(&GlobalFunctionImplementations.maximum_sfjssib), 
			102 => (delegate*<int, void*, void*, void*>)(&GlobalFunctionImplementations.defl_radix_sort_syms), 
			103 => (delegate*<void*, int, void>)(&GlobalFunctionImplementations.defl_calculate_minimum_redundancy), 
			104 => (delegate*<void*, int, int, void>)(&GlobalFunctionImplementations.defl_huffman_enforce_max_code_size), 
			105 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.vector_unsigned_int64_class_std_allocator_unsigned_int64_Constructor), 
			106 => (delegate*<void*, long, void>)(&GlobalFunctionImplementations.resize_d4pmvud), 
			107 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.data_dtgl25a), 
			108 => (delegate*<void*, long>)(&GlobalFunctionImplementations.size_trt5i3d), 
			109 => (delegate*<void*, long, void*>)(&GlobalFunctionImplementations.operator_7d577ub), 
			110 => (delegate*<void*, void>)(&GlobalFunctionImplementations.vector_unsigned_int64_class_std_allocator_unsigned_int64_Destructor), 
			111 => (delegate*<void*, sbyte, void*>)(&GlobalFunctionImplementations.Compressed_pair_class_std_allocator_unsigned_int64_class_std_Vector_val_struct_std_Simple_types_unsigned_int64_1_Constructor), 
			112 => (delegate*<void*, void*, void>)(&GlobalFunctionImplementations.Alloc_proxy), 
			113 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.allocator_unsigned_int64_Constructor), 
			114 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.Vector_val_struct_std_Simple_types_unsigned_int64_Constructor), 
			115 => (delegate*<void*, long, void*, void>)(&GlobalFunctionImplementations.Resize_2s9rs9d), 
			116 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.Getal_kuj7nva), 
			117 => (delegate*<void*, void*, void*, void>)(&GlobalFunctionImplementations.Orphan_range_qciws4b), 
			118 => (delegate*<void*, void*, void*, void>)(&GlobalFunctionImplementations.Destroy_range_qbzp7xb), 
			119 => (delegate*<void*, long, void*, void>)(&GlobalFunctionImplementations.Resize_reallocate_ytnsorc), 
			120 => (delegate*<void*, long, void*, void*>)(&GlobalFunctionImplementations.Uninitialized_value_construct_n_hqowyoc), 
			121 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.Get_first_whlbtqb), 
			122 => (delegate*<void*, long>)(&GlobalFunctionImplementations.max_size_kyvxnnb), 
			123 => (delegate*<void>)(&GlobalFunctionImplementations.Xlength_zmqdsxa), 
			124 => (delegate*<void*, long, long>)(&GlobalFunctionImplementations.Calculate_growth_vbhwmec), 
			125 => (delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.Allocate_at_least_helper_l9zi7qb), 
			126 => (delegate*<void*, void*, void*, void*, void*>)(&GlobalFunctionImplementations.Uninitialized_move_cbc4pbc), 
			127 => (delegate*<void*, void*, long, long, void>)(&GlobalFunctionImplementations.Change_array_hgqy2vc), 
			128 => (delegate*<void*, void>)(&GlobalFunctionImplementations.Reallocation_guard_Destructor_jfaqped), 
			129 => (delegate*<void*, long>)(&GlobalFunctionImplementations.max_size_ngjedfc), 
			130 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.Getal_2reycsb), 
			131 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.Get_first_gcgh4xa), 
			132 => (delegate*<void*, long>)(&GlobalFunctionImplementations.capacity_f49yk4c), 
			133 => (delegate*<void*, long, void*>)(&GlobalFunctionImplementations.allocate_4vpkydd), 
			134 => (delegate*<long, long>)(&GlobalFunctionImplementations.Get_size_of_n_siqup9d), 
			135 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.Get_unwrapped_3jsimya), 
			136 => (delegate*<void*, void*, void*, void*>)(&GlobalFunctionImplementations.Copy_memmove_uofrjzc), 
			137 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.Unfancy_z2hkbxa), 
			138 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.To_address_l9253rd), 
			139 => (delegate*<void*, void*, long, long, void*>)(&GlobalFunctionImplementations.Copy_memmove_tail_oluaukc), 
			140 => (delegate*<void*, void*, long, bool, void>)(&IntrinsicFunctions.Implemented.llvm_memmove_p0_p0_i64), 
			141 => (delegate*<void*, void*, long, void>)(&GlobalFunctionImplementations.deallocate_yb2gvqa), 
			142 => (delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.Zero_range_lx9svca), 
			143 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.Unfancy_maybe_null_uqd3pbd), 
			144 => (delegate*<void*, void>)(&GlobalFunctionImplementations.Tidy_hq3jjxb), 
			145 => (delegate*<int, int, int>)(&GlobalFunctionImplementations.minimum_su2nfub), 
			146 => (delegate*<void*, void*, long, int>)(&IntrinsicFunctions.Implemented.memcmp), 
			147 => (delegate*<int, int>)(&GlobalFunctionImplementations.swap32), 
			148 => (delegate*<void*, void*, int>)(&IntrinsicFunctions.Implemented.strcmp), 
			149 => (delegate*<int, int>)(&IntrinsicFunctions.Implemented.llvm_bswap_i32), 
			150 => (delegate*<void*, long, void*, void>)(&GlobalFunctionImplementations.Resize_p4x2rua), 
			151 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.Getal_jms5hzb), 
			152 => (delegate*<void*, void*, void*, void>)(&GlobalFunctionImplementations.Orphan_range_334quvb), 
			153 => (delegate*<void*, void*, void*, void>)(&GlobalFunctionImplementations.Destroy_range_jjcob5a), 
			154 => (delegate*<void*, long, void*, void>)(&GlobalFunctionImplementations.Resize_reallocate_dt5hjdb), 
			155 => (delegate*<void*, long, void*, void*>)(&GlobalFunctionImplementations.Uninitialized_value_construct_n_cxm3ryd), 
			156 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.Get_first_nkl7psd), 
			157 => (delegate*<void*, long>)(&GlobalFunctionImplementations.max_size_2yjes5b), 
			158 => (delegate*<void>)(&GlobalFunctionImplementations.Xlength_zpuxaia), 
			159 => (delegate*<void*, long, long>)(&GlobalFunctionImplementations.Calculate_growth_scmxisc), 
			160 => (delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.Allocate_at_least_helper_wikabbc), 
			161 => (delegate*<void*, void*, void*, void*, void*>)(&GlobalFunctionImplementations.Uninitialized_move_vysyj4a), 
			162 => (delegate*<void*, void*, long, long, void>)(&GlobalFunctionImplementations.Change_array_k9lpzqa), 
			163 => (delegate*<void*, void>)(&GlobalFunctionImplementations.Reallocation_guard_Destructor_9xb7gra), 
			164 => (delegate*<void*, long>)(&GlobalFunctionImplementations.max_size_hv9dl3d), 
			165 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.Getal_llls4cc), 
			166 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.Get_first_pnsruja), 
			167 => (delegate*<void*, long>)(&GlobalFunctionImplementations.capacity_mz5ysja), 
			168 => (delegate*<void*, long, void*>)(&GlobalFunctionImplementations.allocate_qfop4bd), 
			169 => (delegate*<long, long>)(&GlobalFunctionImplementations.Get_size_of_n_iqtw9sb), 
			170 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.Get_unwrapped_z99fpma), 
			171 => (delegate*<void*, void*, void*, void*>)(&GlobalFunctionImplementations.Copy_memmove_2kkdavd), 
			172 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.Unfancy_aszk3nc), 
			173 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.To_address_enkoctc), 
			174 => (delegate*<void*, void*, long, long, void*>)(&GlobalFunctionImplementations.Copy_memmove_tail_x7ipzed), 
			175 => (delegate*<void*, void*, long, void>)(&GlobalFunctionImplementations.deallocate_mc9rbjc), 
			176 => (delegate*<void*, void*, void*>)(&GlobalFunctionImplementations.Zero_range_927ahid), 
			177 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.Unfancy_maybe_null_pj5f7cb), 
			178 => (delegate*<void*, sbyte, void*>)(&GlobalFunctionImplementations.Compressed_pair_class_std_allocator_unsigned_char_class_std_Vector_val_struct_std_Simple_types_unsigned_char_1_Constructor), 
			179 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.allocator_unsigned_char_Constructor), 
			180 => (delegate*<void*, void*>)(&GlobalFunctionImplementations.Vector_val_struct_std_Simple_types_unsigned_char_Constructor), 
			181 => (delegate*<void*, void>)(&GlobalFunctionImplementations.Tidy_iono57d), 
			182 => (delegate*<void*, int, int, void*, int, int, int, int, bool>)(&GlobalFunctionImplementations.fpng_pixel_zlib_raw_decompress), 
			183 => (delegate*<void*, int, void*, void*, void*, void*, int, bool>)(&GlobalFunctionImplementations.prepare_dynamic_block), 
			184 => (delegate*<int, void*, void*, bool>)(&GlobalFunctionImplementations.build_decoder_table), 
			-1 => GlobalVariablePointers.Avx2WmemEnabledWeakValue, 
			-2 => GlobalVariablePointers.String_uxbkrtb, 
			-3 => GlobalVariablePointers.String_kdrammb, 
			-4 => GlobalVariablePointers.String_bik4erc, 
			-5 => GlobalVariablePointers.String_dqvhqxc, 
			-6 => GlobalVariablePointers.s_color_type, 
			-7 => GlobalVariablePointers.String_nz3h57a, 
			-8 => GlobalVariablePointers.g_crc32_4, 
			-9 => GlobalVariablePointers.String_uc52kza, 
			-10 => GlobalVariablePointers.String_9hewgtd, 
			-11 => GlobalVariablePointers.String_ooiduua, 
			-12 => GlobalVariablePointers.String_mggwlgb, 
			-13 => GlobalVariablePointers.g_defl_len_sym, 
			-14 => GlobalVariablePointers.String_bjvsuxc, 
			-15 => GlobalVariablePointers.String_hsgehfc, 
			-16 => GlobalVariablePointers.String_vpte4cc, 
			-17 => GlobalVariablePointers.String_df5ko9b, 
			-18 => GlobalVariablePointers.String_isj2lib, 
			-19 => GlobalVariablePointers.g_bitmasks, 
			-20 => GlobalVariablePointers.g_defl_len_extra, 
			-21 => GlobalVariablePointers.String_2ej5tjb, 
			-22 => GlobalVariablePointers.String_7b7kt9c, 
			-23 => GlobalVariablePointers._7type_info, 
			-24 => GlobalVariablePointers.R0_AVbad_array_new_length, 
			-25 => GlobalVariablePointers.ImageBase, 
			-26 => GlobalVariablePointers.CT_R0_AVbad_array_new_length_std_8_0bad_array_new_length_std_QEAA_AEBV01_Z24, 
			-27 => GlobalVariablePointers.R0_AVbad_alloc, 
			-28 => GlobalVariablePointers.CT_R0_AVbad_alloc_std_8_0bad_alloc_std_QEAA_AEBV01_Z24, 
			-29 => GlobalVariablePointers.R0_AVexception, 
			-30 => GlobalVariablePointers.CT_R0_AVexception_std_8_0exception_std_QEAA_AEBV01_Z24, 
			-31 => GlobalVariablePointers.CTA3_AVbad_array_new_length_std, 
			-32 => GlobalVariablePointers.TI3_AVbad_array_new_length_std, 
			-33 => GlobalVariablePointers.String_gudorqc, 
			-34 => GlobalVariablePointers.Variable_4yxjuqa, 
			-35 => GlobalVariablePointers.R4bad_array_new_length, 
			-36 => GlobalVariablePointers.R3bad_array_new_length, 
			-37 => GlobalVariablePointers.R2bad_array_new_length, 
			-38 => GlobalVariablePointers.R1A_9w7p7zd, 
			-39 => GlobalVariablePointers.R1A_vzsilob, 
			-40 => GlobalVariablePointers.R3bad_alloc, 
			-41 => GlobalVariablePointers.R2bad_alloc, 
			-42 => GlobalVariablePointers.R1A_bbqer2a, 
			-43 => GlobalVariablePointers.R3exception, 
			-44 => GlobalVariablePointers.R2exception, 
			-45 => GlobalVariablePointers.Variable_zdor9mc, 
			-46 => GlobalVariablePointers.R4bad_alloc, 
			-47 => GlobalVariablePointers.Variable_x4f2ufc, 
			-48 => GlobalVariablePointers.R4exception, 
			-49 => GlobalVariablePointers.String_ja3ma5d, 
			-50 => GlobalVariablePointers.g_defl_packed_code_size_syms_swizzle, 
			-51 => GlobalVariablePointers.String_erkdsbd, 
			-52 => GlobalVariablePointers.String_o9ulvgb, 
			-53 => GlobalVariablePointers.g_dyn_huff_3, 
			-54 => GlobalVariablePointers.g_dyn_huff_3_codes, 
			-55 => GlobalVariablePointers.g_dyn_huff_4, 
			-56 => GlobalVariablePointers.g_dyn_huff_4_codes, 
			-57 => GlobalVariablePointers.s_png_sig, 
			-58 => GlobalVariablePointers.String_qjc9xdd, 
			-59 => GlobalVariablePointers.String_p7olgfc, 
			-60 => GlobalVariablePointers.String_22lii4a, 
			-61 => GlobalVariablePointers.String_497patd, 
			-62 => GlobalVariablePointers.String_aa3exrc, 
			-63 => GlobalVariablePointers.String_ktv524d, 
			-64 => GlobalVariablePointers.String_mf9hyza, 
			-65 => GlobalVariablePointers.s_length_range, 
			-66 => GlobalVariablePointers.s_length_extra, 
			-67 => GlobalVariablePointers.String_ftb25bb, 
			-68 => GlobalVariablePointers.String_bahgbqd, 
			-69 => GlobalVariablePointers.String_a5rp7bb, 
			-70 => GlobalVariablePointers.g_run_len3_to_4, 
			-71 => GlobalVariablePointers.String_zixkhbc, 
			-72 => GlobalVariablePointers.String_kppxlqc, 
			-73 => GlobalVariablePointers.String_ji2h3xd, 
			-74 => GlobalVariablePointers.s_bit_length_order, 
			-75 => GlobalVariablePointers.String_nlshwsc, 
			-76 => GlobalVariablePointers.String_32otbnd, 
			_ => null, 
		};
	}
}
