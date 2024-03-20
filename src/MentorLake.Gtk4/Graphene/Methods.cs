namespace MentorLake.Gtk4.Graphene;

public static class Methods
{
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_init(float x, float y, float z, float w);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_init_zero();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_init_4f([NativeTypeName("const float *")] float* v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_init_3f([NativeTypeName("const float *")] float* v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_init_2f([NativeTypeName("const float *")] float* v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_simd4f_dup_4f([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s, float* v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_simd4f_dup_3f([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s, float* v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_simd4f_dup_2f([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s, float* v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_simd4f_get([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s, [NativeTypeName("unsigned int")] uint i);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_simd4f_get_x([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_simd4f_get_y([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_simd4f_get_z([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_simd4f_get_w([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_splat(float v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_splat_x([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_splat_y([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_splat_z([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_splat_w([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_add([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float a, [NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_sub([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float a, [NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_mul([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float a, [NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_div([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float a, [NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_sqrt([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_reciprocal([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_rsqrt([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_cross3([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float a, [NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_dot3([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float a, [NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_simd4f_dot3_scalar([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float a, [NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_min([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float a, [NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_max([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float a, [NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_shuffle_wxyz([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_shuffle_zwxy([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_shuffle_yzwx([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_zero_w([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_zero_zw([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_merge_high([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float a, [NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_merge_low([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float a, [NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_merge_w([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s, float v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_flip_sign_0101([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_flip_sign_1010([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_simd4f_cmp_eq([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float a, [NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_simd4f_cmp_neq([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float a, [NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_simd4f_cmp_lt([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float a, [NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_simd4f_cmp_le([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float a, [NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_simd4f_cmp_ge([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float a, [NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_simd4f_cmp_gt([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float a, [NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("graphene_simd4f_t")]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float graphene_simd4f_neg([NativeTypeName("const graphene_simd4f_t")] __attribute__((__vector_size__(4 * sizeof(float)))) float s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern __attribute__((__vector_size__(4 * sizeof(float)))) float __builtin_ia32_shufps(__attribute__((__vector_size__(4 * sizeof(float)))) float param0, __attribute__((__vector_size__(4 * sizeof(float)))) float param1, int param2);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_simd4x4f_transpose_in_place(graphene_simd4x4f_t* s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec2_tHandle graphene_vec2_alloc();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec2_free(graphene_vec2_tHandle v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec2_tHandle graphene_vec2_init(graphene_vec2_tHandle v, float x, float y);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec2_tHandle graphene_vec2_init_from_vec2(graphene_vec2_tHandle v, graphene_vec2_tHandle src);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec2_tHandle graphene_vec2_init_from_float(graphene_vec2_tHandle v, [NativeTypeName("const float *")] float* src);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec2_to_float(graphene_vec2_tHandle v, float* dest);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec2_add(graphene_vec2_tHandle a, graphene_vec2_tHandle b, graphene_vec2_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec2_subtract(graphene_vec2_tHandle a, graphene_vec2_tHandle b, graphene_vec2_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec2_multiply(graphene_vec2_tHandle a, graphene_vec2_tHandle b, graphene_vec2_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec2_divide(graphene_vec2_tHandle a, graphene_vec2_tHandle b, graphene_vec2_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_vec2_dot(graphene_vec2_tHandle a, graphene_vec2_tHandle b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_vec2_length(graphene_vec2_tHandle v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec2_normalize(graphene_vec2_tHandle v, graphene_vec2_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec2_scale(graphene_vec2_tHandle v, float factor, graphene_vec2_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec2_negate(graphene_vec2_tHandle v, graphene_vec2_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_vec2_near(graphene_vec2_tHandle v1, graphene_vec2_tHandle v2, float epsilon);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_vec2_equal(graphene_vec2_tHandle v1, graphene_vec2_tHandle v2);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec2_min(graphene_vec2_tHandle a, graphene_vec2_tHandle b, graphene_vec2_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec2_max(graphene_vec2_tHandle a, graphene_vec2_tHandle b, graphene_vec2_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec2_interpolate(graphene_vec2_tHandle v1, graphene_vec2_tHandle v2, double factor, graphene_vec2_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_vec2_get_x(graphene_vec2_tHandle v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_vec2_get_y(graphene_vec2_tHandle v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec2_tHandle graphene_vec2_zero();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec2_tHandle graphene_vec2_one();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec2_tHandle graphene_vec2_x_axis();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec2_tHandle graphene_vec2_y_axis();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec3_tHandle graphene_vec3_alloc();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec3_free(graphene_vec3_tHandle v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec3_tHandle graphene_vec3_init(graphene_vec3_tHandle v, float x, float y, float z);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec3_tHandle graphene_vec3_init_from_vec3(graphene_vec3_tHandle v, graphene_vec3_tHandle src);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec3_tHandle graphene_vec3_init_from_float(graphene_vec3_tHandle v, [NativeTypeName("const float *")] float* src);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec3_to_float(graphene_vec3_tHandle v, float* dest);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec3_add(graphene_vec3_tHandle a, graphene_vec3_tHandle b, graphene_vec3_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec3_subtract(graphene_vec3_tHandle a, graphene_vec3_tHandle b, graphene_vec3_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec3_multiply(graphene_vec3_tHandle a, graphene_vec3_tHandle b, graphene_vec3_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec3_divide(graphene_vec3_tHandle a, graphene_vec3_tHandle b, graphene_vec3_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec3_cross(graphene_vec3_tHandle a, graphene_vec3_tHandle b, graphene_vec3_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_vec3_dot(graphene_vec3_tHandle a, graphene_vec3_tHandle b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_vec3_length(graphene_vec3_tHandle v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec3_normalize(graphene_vec3_tHandle v, graphene_vec3_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec3_scale(graphene_vec3_tHandle v, float factor, graphene_vec3_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec3_negate(graphene_vec3_tHandle v, graphene_vec3_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_vec3_equal(graphene_vec3_tHandle v1, graphene_vec3_tHandle v2);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_vec3_near(graphene_vec3_tHandle v1, graphene_vec3_tHandle v2, float epsilon);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec3_min(graphene_vec3_tHandle a, graphene_vec3_tHandle b, graphene_vec3_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec3_max(graphene_vec3_tHandle a, graphene_vec3_tHandle b, graphene_vec3_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec3_interpolate(graphene_vec3_tHandle v1, graphene_vec3_tHandle v2, double factor, graphene_vec3_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_vec3_get_x(graphene_vec3_tHandle v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_vec3_get_y(graphene_vec3_tHandle v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_vec3_get_z(graphene_vec3_tHandle v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec3_get_xy(graphene_vec3_tHandle v, graphene_vec2_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec3_get_xy0(graphene_vec3_tHandle v, graphene_vec3_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec3_get_xyz0(graphene_vec3_tHandle v, graphene_vec4_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec3_get_xyz1(graphene_vec3_tHandle v, graphene_vec4_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec3_get_xyzw(graphene_vec3_tHandle v, float w, graphene_vec4_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec3_tHandle graphene_vec3_zero();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec3_tHandle graphene_vec3_one();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec3_tHandle graphene_vec3_x_axis();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec3_tHandle graphene_vec3_y_axis();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec3_tHandle graphene_vec3_z_axis();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec4_tHandle graphene_vec4_alloc();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec4_free(graphene_vec4_tHandle v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec4_tHandle graphene_vec4_init(graphene_vec4_tHandle v, float x, float y, float z, float w);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec4_tHandle graphene_vec4_init_from_vec4(graphene_vec4_tHandle v, graphene_vec4_tHandle src);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec4_tHandle graphene_vec4_init_from_vec3(graphene_vec4_tHandle v, graphene_vec3_tHandle src, float w);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec4_tHandle graphene_vec4_init_from_vec2(graphene_vec4_tHandle v, graphene_vec2_tHandle src, float z, float w);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec4_tHandle graphene_vec4_init_from_float(graphene_vec4_tHandle v, [NativeTypeName("const float *")] float* src);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec4_to_float(graphene_vec4_tHandle v, float* dest);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec4_add(graphene_vec4_tHandle a, graphene_vec4_tHandle b, graphene_vec4_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec4_subtract(graphene_vec4_tHandle a, graphene_vec4_tHandle b, graphene_vec4_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec4_multiply(graphene_vec4_tHandle a, graphene_vec4_tHandle b, graphene_vec4_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec4_divide(graphene_vec4_tHandle a, graphene_vec4_tHandle b, graphene_vec4_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_vec4_dot(graphene_vec4_tHandle a, graphene_vec4_tHandle b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_vec4_length(graphene_vec4_tHandle v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec4_normalize(graphene_vec4_tHandle v, graphene_vec4_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec4_scale(graphene_vec4_tHandle v, float factor, graphene_vec4_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec4_negate(graphene_vec4_tHandle v, graphene_vec4_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_vec4_equal(graphene_vec4_tHandle v1, graphene_vec4_tHandle v2);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_vec4_near(graphene_vec4_tHandle v1, graphene_vec4_tHandle v2, float epsilon);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec4_min(graphene_vec4_tHandle a, graphene_vec4_tHandle b, graphene_vec4_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec4_max(graphene_vec4_tHandle a, graphene_vec4_tHandle b, graphene_vec4_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec4_interpolate(graphene_vec4_tHandle v1, graphene_vec4_tHandle v2, double factor, graphene_vec4_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_vec4_get_x(graphene_vec4_tHandle v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_vec4_get_y(graphene_vec4_tHandle v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_vec4_get_z(graphene_vec4_tHandle v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_vec4_get_w(graphene_vec4_tHandle v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec4_get_xy(graphene_vec4_tHandle v, graphene_vec2_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_vec4_get_xyz(graphene_vec4_tHandle v, graphene_vec3_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec4_tHandle graphene_vec4_zero();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec4_tHandle graphene_vec4_one();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec4_tHandle graphene_vec4_x_axis();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec4_tHandle graphene_vec4_y_axis();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec4_tHandle graphene_vec4_z_axis();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_vec4_tHandle graphene_vec4_w_axis();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_matrix_tHandle graphene_matrix_alloc();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_free(graphene_matrix_tHandle m);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_matrix_tHandle graphene_matrix_init_identity(graphene_matrix_tHandle m);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_matrix_tHandle graphene_matrix_init_from_float(graphene_matrix_tHandle m, [NativeTypeName("const float *")] float* v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_matrix_tHandle graphene_matrix_init_from_vec4(graphene_matrix_tHandle m, graphene_vec4_tHandle v0, graphene_vec4_tHandle v1, graphene_vec4_tHandle v2, graphene_vec4_tHandle v3);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_matrix_tHandle graphene_matrix_init_from_matrix(graphene_matrix_tHandle m, graphene_matrix_tHandle src);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_matrix_tHandle graphene_matrix_init_perspective(graphene_matrix_tHandle m, float fovy, float aspect, float z_near, float z_far);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_matrix_tHandle graphene_matrix_init_ortho(graphene_matrix_tHandle m, float left, float right, float top, float bottom, float z_near, float z_far);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_matrix_tHandle graphene_matrix_init_look_at(graphene_matrix_tHandle m, graphene_vec3_tHandle eye, graphene_vec3_tHandle center, graphene_vec3_tHandle up);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_matrix_tHandle graphene_matrix_init_frustum(graphene_matrix_tHandle m, float left, float right, float bottom, float top, float z_near, float z_far);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_matrix_tHandle graphene_matrix_init_scale(graphene_matrix_tHandle m, float x, float y, float z);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_matrix_tHandle graphene_matrix_init_translate(graphene_matrix_tHandle m, graphene_point3d_tHandle p);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_matrix_tHandle graphene_matrix_init_rotate(graphene_matrix_tHandle m, float angle, graphene_vec3_tHandle axis);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_matrix_tHandle graphene_matrix_init_skew(graphene_matrix_tHandle m, float x_skew, float y_skew);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_matrix_tHandle graphene_matrix_init_from_2d(graphene_matrix_tHandle m, double xx, double yx, double xy, double yy, double x_0, double y_0);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_matrix_is_identity(graphene_matrix_tHandle m);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_matrix_is_2d(graphene_matrix_tHandle m);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_matrix_is_backface_visible(graphene_matrix_tHandle m);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_matrix_is_singular(graphene_matrix_tHandle m);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_to_float(graphene_matrix_tHandle m, float* v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_matrix_to_2d(graphene_matrix_tHandle m, double* xx, double* yx, double* xy, double* yy, double* x_0, double* y_0);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_get_row(graphene_matrix_tHandle m, [NativeTypeName("unsigned int")] uint index_, graphene_vec4_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_matrix_get_value(graphene_matrix_tHandle m, [NativeTypeName("unsigned int")] uint row, [NativeTypeName("unsigned int")] uint col);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_multiply(graphene_matrix_tHandle a, graphene_matrix_tHandle b, graphene_matrix_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_matrix_determinant(graphene_matrix_tHandle m);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_transform_vec4(graphene_matrix_tHandle m, graphene_vec4_tHandle v, graphene_vec4_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_transform_vec3(graphene_matrix_tHandle m, graphene_vec3_tHandle v, graphene_vec3_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_transform_point(graphene_matrix_tHandle m, graphene_point_tHandle p, graphene_point_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_transform_point3d(graphene_matrix_tHandle m, graphene_point3d_tHandle p, graphene_point3d_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_transform_rect(graphene_matrix_tHandle m, graphene_rect_tHandle r, graphene_quad_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_transform_bounds(graphene_matrix_tHandle m, graphene_rect_tHandle r, graphene_rect_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_transform_sphere(graphene_matrix_tHandle m, graphene_sphere_tHandle s, graphene_sphere_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_transform_box(graphene_matrix_tHandle m, graphene_box_tHandle b, graphene_box_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_transform_ray(graphene_matrix_tHandle m, graphene_ray_tHandle r, graphene_ray_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_project_point(graphene_matrix_tHandle m, graphene_point_tHandle p, graphene_point_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_project_rect_bounds(graphene_matrix_tHandle m, graphene_rect_tHandle r, graphene_rect_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_project_rect(graphene_matrix_tHandle m, graphene_rect_tHandle r, graphene_quad_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_matrix_untransform_point(graphene_matrix_tHandle m, graphene_point_tHandle p, graphene_rect_tHandle bounds, graphene_point_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_untransform_bounds(graphene_matrix_tHandle m, graphene_rect_tHandle r, graphene_rect_tHandle bounds, graphene_rect_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_unproject_point3d(graphene_matrix_tHandle projection, graphene_matrix_tHandle modelview, graphene_point3d_tHandle point, graphene_point3d_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_translate(graphene_matrix_tHandle m, graphene_point3d_tHandle pos);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_rotate(graphene_matrix_tHandle m, float angle, graphene_vec3_tHandle axis);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_rotate_x(graphene_matrix_tHandle m, float angle);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_rotate_y(graphene_matrix_tHandle m, float angle);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_rotate_z(graphene_matrix_tHandle m, float angle);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_rotate_quaternion(graphene_matrix_tHandle m, graphene_quaternion_tHandle q);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_rotate_euler(graphene_matrix_tHandle m, graphene_euler_tHandle e);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_scale(graphene_matrix_tHandle m, float factor_x, float factor_y, float factor_z);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_skew_xy(graphene_matrix_tHandle m, float factor);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_skew_xz(graphene_matrix_tHandle m, float factor);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_skew_yz(graphene_matrix_tHandle m, float factor);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_transpose(graphene_matrix_tHandle m, graphene_matrix_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_matrix_inverse(graphene_matrix_tHandle m, graphene_matrix_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_perspective(graphene_matrix_tHandle m, float depth, graphene_matrix_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_normalize(graphene_matrix_tHandle m, graphene_matrix_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_matrix_get_x_translation(graphene_matrix_tHandle m);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_matrix_get_y_translation(graphene_matrix_tHandle m);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_matrix_get_z_translation(graphene_matrix_tHandle m);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_matrix_get_x_scale(graphene_matrix_tHandle m);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_matrix_get_y_scale(graphene_matrix_tHandle m);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_matrix_get_z_scale(graphene_matrix_tHandle m);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_interpolate(graphene_matrix_tHandle a, graphene_matrix_tHandle b, double factor, graphene_matrix_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_matrix_near(graphene_matrix_tHandle a, graphene_matrix_tHandle b, float epsilon);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_matrix_equal(graphene_matrix_tHandle a, graphene_matrix_tHandle b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_matrix_equal_fast(graphene_matrix_tHandle a, graphene_matrix_tHandle b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_matrix_print(graphene_matrix_tHandle m);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_matrix_decompose(graphene_matrix_tHandle m, graphene_vec3_tHandle translate, graphene_vec3_tHandle scale, graphene_quaternion_tHandle rotate, graphene_vec3_tHandle shear, graphene_vec4_tHandle perspective);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_point_tHandle graphene_point_alloc();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_point_free(graphene_point_tHandle p);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_point_tHandle graphene_point_init(graphene_point_tHandle p, float x, float y);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_point_tHandle graphene_point_init_from_point(graphene_point_tHandle p, graphene_point_tHandle src);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_point_tHandle graphene_point_init_from_vec2(graphene_point_tHandle p, graphene_vec2_tHandle src);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_point_equal(graphene_point_tHandle a, graphene_point_tHandle b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_point_distance(graphene_point_tHandle a, graphene_point_tHandle b, float* d_x, float* d_y);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_point_near(graphene_point_tHandle a, graphene_point_tHandle b, float epsilon);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_point_interpolate(graphene_point_tHandle a, graphene_point_tHandle b, double factor, graphene_point_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_point_to_vec2(graphene_point_tHandle p, graphene_vec2_tHandle v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_point_tHandle graphene_point_zero();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_size_tHandle graphene_size_alloc();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_size_free(graphene_size_tHandle s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_size_tHandle graphene_size_init(graphene_size_tHandle s, float width, float height);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_size_tHandle graphene_size_init_from_size(graphene_size_tHandle s, graphene_size_tHandle src);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_size_equal(graphene_size_tHandle a, graphene_size_tHandle b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_size_scale(graphene_size_tHandle s, float factor, graphene_size_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_size_interpolate(graphene_size_tHandle a, graphene_size_tHandle b, double factor, graphene_size_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_size_tHandle graphene_size_zero();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_rect_tHandle graphene_rect_alloc();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_rect_free(graphene_rect_tHandle r);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_rect_tHandle graphene_rect_init(graphene_rect_tHandle r, float x, float y, float width, float height);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_rect_tHandle graphene_rect_init_from_rect(graphene_rect_tHandle r, graphene_rect_tHandle src);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_rect_equal(graphene_rect_tHandle a, graphene_rect_tHandle b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_rect_tHandle graphene_rect_normalize(graphene_rect_tHandle r);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_rect_normalize_r(graphene_rect_tHandle r, graphene_rect_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_rect_get_center(graphene_rect_tHandle r, graphene_point_tHandle p);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_rect_get_top_left(graphene_rect_tHandle r, graphene_point_tHandle p);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_rect_get_top_right(graphene_rect_tHandle r, graphene_point_tHandle p);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_rect_get_bottom_right(graphene_rect_tHandle r, graphene_point_tHandle p);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_rect_get_bottom_left(graphene_rect_tHandle r, graphene_point_tHandle p);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_rect_get_vertices(graphene_rect_tHandle r, graphene_vec2_t[] vertices);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_rect_get_x(graphene_rect_tHandle r);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_rect_get_y(graphene_rect_tHandle r);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_rect_get_width(graphene_rect_tHandle r);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_rect_get_height(graphene_rect_tHandle r);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_rect_get_area(graphene_rect_tHandle r);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_rect_union(graphene_rect_tHandle a, graphene_rect_tHandle b, graphene_rect_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_rect_intersection(graphene_rect_tHandle a, graphene_rect_tHandle b, graphene_rect_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_rect_contains_point(graphene_rect_tHandle r, graphene_point_tHandle p);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_rect_contains_rect(graphene_rect_tHandle a, graphene_rect_tHandle b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_rect_tHandle graphene_rect_offset(graphene_rect_tHandle r, float d_x, float d_y);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_rect_offset_r(graphene_rect_tHandle r, float d_x, float d_y, graphene_rect_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_rect_tHandle graphene_rect_inset(graphene_rect_tHandle r, float d_x, float d_y);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_rect_inset_r(graphene_rect_tHandle r, float d_x, float d_y, graphene_rect_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_rect_tHandle graphene_rect_round_to_pixel(graphene_rect_tHandle r);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_rect_round(graphene_rect_tHandle r, graphene_rect_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_rect_round_extents(graphene_rect_tHandle r, graphene_rect_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_rect_interpolate(graphene_rect_tHandle a, graphene_rect_tHandle b, double factor, graphene_rect_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_rect_expand(graphene_rect_tHandle r, graphene_point_tHandle p, graphene_rect_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_rect_tHandle graphene_rect_zero();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_rect_scale(graphene_rect_tHandle r, float s_h, float s_v, graphene_rect_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_point3d_tHandle graphene_point3d_alloc();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_point3d_free(graphene_point3d_tHandle p);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_point3d_tHandle graphene_point3d_init(graphene_point3d_tHandle p, float x, float y, float z);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_point3d_tHandle graphene_point3d_init_from_point(graphene_point3d_tHandle p, graphene_point3d_tHandle src);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_point3d_tHandle graphene_point3d_init_from_vec3(graphene_point3d_tHandle p, graphene_vec3_tHandle v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_point3d_to_vec3(graphene_point3d_tHandle p, graphene_vec3_tHandle v);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_point3d_equal(graphene_point3d_tHandle a, graphene_point3d_tHandle b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_point3d_near(graphene_point3d_tHandle a, graphene_point3d_tHandle b, float epsilon);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_point3d_scale(graphene_point3d_tHandle p, float factor, graphene_point3d_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_point3d_cross(graphene_point3d_tHandle a, graphene_point3d_tHandle b, graphene_point3d_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_point3d_dot(graphene_point3d_tHandle a, graphene_point3d_tHandle b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_point3d_length(graphene_point3d_tHandle p);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_point3d_normalize(graphene_point3d_tHandle p, graphene_point3d_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_point3d_distance(graphene_point3d_tHandle a, graphene_point3d_tHandle b, graphene_vec3_tHandle delta);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_point3d_interpolate(graphene_point3d_tHandle a, graphene_point3d_tHandle b, double factor, graphene_point3d_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_point3d_normalize_viewport(graphene_point3d_tHandle p, graphene_rect_tHandle viewport, float z_near, float z_far, graphene_point3d_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_point3d_tHandle graphene_point3d_zero();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_quad_tHandle graphene_quad_alloc();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_quad_free(graphene_quad_tHandle q);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_quad_tHandle graphene_quad_init(graphene_quad_tHandle q, graphene_point_tHandle p1, graphene_point_tHandle p2, graphene_point_tHandle p3, graphene_point_tHandle p4);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_quad_tHandle graphene_quad_init_from_rect(graphene_quad_tHandle q, graphene_rect_tHandle r);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_quad_tHandle graphene_quad_init_from_points(graphene_quad_tHandle q, graphene_point_t[] points);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_quad_contains(graphene_quad_tHandle q, graphene_point_tHandle p);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_quad_bounds(graphene_quad_tHandle q, graphene_rect_tHandle r);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_point_tHandle graphene_quad_get_point(graphene_quad_tHandle q, [NativeTypeName("unsigned int")] uint index_);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_quaternion_tHandle graphene_quaternion_alloc();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_quaternion_free(graphene_quaternion_tHandle q);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_quaternion_tHandle graphene_quaternion_init(graphene_quaternion_tHandle q, float x, float y, float z, float w);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_quaternion_tHandle graphene_quaternion_init_identity(graphene_quaternion_tHandle q);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_quaternion_tHandle graphene_quaternion_init_from_quaternion(graphene_quaternion_tHandle q, graphene_quaternion_tHandle src);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_quaternion_tHandle graphene_quaternion_init_from_vec4(graphene_quaternion_tHandle q, graphene_vec4_tHandle src);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_quaternion_tHandle graphene_quaternion_init_from_matrix(graphene_quaternion_tHandle q, graphene_matrix_tHandle m);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_quaternion_tHandle graphene_quaternion_init_from_angles(graphene_quaternion_tHandle q, float deg_x, float deg_y, float deg_z);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_quaternion_tHandle graphene_quaternion_init_from_radians(graphene_quaternion_tHandle q, float rad_x, float rad_y, float rad_z);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_quaternion_tHandle graphene_quaternion_init_from_angle_vec3(graphene_quaternion_tHandle q, float angle, graphene_vec3_tHandle axis);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_quaternion_tHandle graphene_quaternion_init_from_euler(graphene_quaternion_tHandle q, graphene_euler_tHandle e);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_quaternion_to_vec4(graphene_quaternion_tHandle q, graphene_vec4_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_quaternion_to_matrix(graphene_quaternion_tHandle q, graphene_matrix_tHandle m);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_quaternion_to_angles(graphene_quaternion_tHandle q, float* deg_x, float* deg_y, float* deg_z);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_quaternion_to_radians(graphene_quaternion_tHandle q, float* rad_x, float* rad_y, float* rad_z);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_quaternion_to_angle_vec3(graphene_quaternion_tHandle q, float* angle, graphene_vec3_tHandle axis);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_quaternion_equal(graphene_quaternion_tHandle a, graphene_quaternion_tHandle b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_quaternion_dot(graphene_quaternion_tHandle a, graphene_quaternion_tHandle b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_quaternion_invert(graphene_quaternion_tHandle q, graphene_quaternion_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_quaternion_normalize(graphene_quaternion_tHandle q, graphene_quaternion_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_quaternion_slerp(graphene_quaternion_tHandle a, graphene_quaternion_tHandle b, float factor, graphene_quaternion_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_quaternion_multiply(graphene_quaternion_tHandle a, graphene_quaternion_tHandle b, graphene_quaternion_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_quaternion_scale(graphene_quaternion_tHandle q, float factor, graphene_quaternion_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_quaternion_add(graphene_quaternion_tHandle a, graphene_quaternion_tHandle b, graphene_quaternion_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_euler_tHandle graphene_euler_alloc();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_euler_free(graphene_euler_tHandle e);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_euler_tHandle graphene_euler_init(graphene_euler_tHandle e, float x, float y, float z);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_euler_tHandle graphene_euler_init_with_order(graphene_euler_tHandle e, float x, float y, float z, graphene_euler_order_t order);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_euler_tHandle graphene_euler_init_from_matrix(graphene_euler_tHandle e, graphene_matrix_tHandle m, graphene_euler_order_t order);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_euler_tHandle graphene_euler_init_from_quaternion(graphene_euler_tHandle e, graphene_quaternion_tHandle q, graphene_euler_order_t order);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_euler_tHandle graphene_euler_init_from_vec3(graphene_euler_tHandle e, graphene_vec3_tHandle v, graphene_euler_order_t order);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_euler_tHandle graphene_euler_init_from_euler(graphene_euler_tHandle e, graphene_euler_tHandle src);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_euler_tHandle graphene_euler_init_from_radians(graphene_euler_tHandle e, float x, float y, float z, graphene_euler_order_t order);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_euler_equal(graphene_euler_tHandle a, graphene_euler_tHandle b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_euler_get_x(graphene_euler_tHandle e);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_euler_get_y(graphene_euler_tHandle e);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_euler_get_z(graphene_euler_tHandle e);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_euler_order_t graphene_euler_get_order(graphene_euler_tHandle e);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_euler_get_alpha(graphene_euler_tHandle e);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_euler_get_beta(graphene_euler_tHandle e);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_euler_get_gamma(graphene_euler_tHandle e);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_euler_to_vec3(graphene_euler_tHandle e, graphene_vec3_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_euler_to_matrix(graphene_euler_tHandle e, graphene_matrix_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_euler_to_quaternion(graphene_euler_tHandle e, graphene_quaternion_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_euler_reorder(graphene_euler_tHandle e, graphene_euler_order_t order, graphene_euler_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_plane_tHandle graphene_plane_alloc();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_plane_free(graphene_plane_tHandle p);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_plane_tHandle graphene_plane_init(graphene_plane_tHandle p, graphene_vec3_tHandle normal, float constant);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_plane_tHandle graphene_plane_init_from_vec4(graphene_plane_tHandle p, graphene_vec4_tHandle src);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_plane_tHandle graphene_plane_init_from_plane(graphene_plane_tHandle p, graphene_plane_tHandle src);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_plane_tHandle graphene_plane_init_from_point(graphene_plane_tHandle p, graphene_vec3_tHandle normal, graphene_point3d_tHandle point);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_plane_tHandle graphene_plane_init_from_points(graphene_plane_tHandle p, graphene_point3d_tHandle a, graphene_point3d_tHandle b, graphene_point3d_tHandle c);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_plane_normalize(graphene_plane_tHandle p, graphene_plane_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_plane_negate(graphene_plane_tHandle p, graphene_plane_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_plane_equal(graphene_plane_tHandle a, graphene_plane_tHandle b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_plane_distance(graphene_plane_tHandle p, graphene_point3d_tHandle point);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_plane_get_normal(graphene_plane_tHandle p, graphene_vec3_tHandle normal);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_plane_get_constant(graphene_plane_tHandle p);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_plane_transform(graphene_plane_tHandle p, graphene_matrix_tHandle matrix, graphene_matrix_tHandle normal_matrix, graphene_plane_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_frustum_tHandle graphene_frustum_alloc();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_frustum_free(graphene_frustum_tHandle f);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_frustum_tHandle graphene_frustum_init(graphene_frustum_tHandle f, graphene_plane_tHandle p0, graphene_plane_tHandle p1, graphene_plane_tHandle p2, graphene_plane_tHandle p3, graphene_plane_tHandle p4, graphene_plane_tHandle p5);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_frustum_tHandle graphene_frustum_init_from_frustum(graphene_frustum_tHandle f, graphene_frustum_tHandle src);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_frustum_tHandle graphene_frustum_init_from_matrix(graphene_frustum_tHandle f, graphene_matrix_tHandle matrix);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_frustum_contains_point(graphene_frustum_tHandle f, graphene_point3d_tHandle point);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_frustum_intersects_sphere(graphene_frustum_tHandle f, graphene_sphere_tHandle sphere);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_frustum_intersects_box(graphene_frustum_tHandle f, graphene_box_tHandle box);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_frustum_get_planes(graphene_frustum_tHandle f, graphene_plane_t[] planes);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_frustum_equal(graphene_frustum_tHandle a, graphene_frustum_tHandle b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_sphere_tHandle graphene_sphere_alloc();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_sphere_free(graphene_sphere_tHandle s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_sphere_tHandle graphene_sphere_init(graphene_sphere_tHandle s, graphene_point3d_tHandle center, float radius);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_sphere_tHandle graphene_sphere_init_from_points(graphene_sphere_tHandle s, [NativeTypeName("unsigned int")] uint n_points, graphene_point3d_tHandle points, graphene_point3d_tHandle center);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_sphere_tHandle graphene_sphere_init_from_vectors(graphene_sphere_tHandle s, [NativeTypeName("unsigned int")] uint n_vectors, graphene_vec3_tHandle vectors, graphene_point3d_tHandle center);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_sphere_get_center(graphene_sphere_tHandle s, graphene_point3d_tHandle center);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_sphere_get_radius(graphene_sphere_tHandle s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_sphere_is_empty(graphene_sphere_tHandle s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_sphere_equal(graphene_sphere_tHandle a, graphene_sphere_tHandle b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_sphere_contains_point(graphene_sphere_tHandle s, graphene_point3d_tHandle point);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_sphere_distance(graphene_sphere_tHandle s, graphene_point3d_tHandle point);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_sphere_get_bounding_box(graphene_sphere_tHandle s, graphene_box_tHandle box);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_sphere_translate(graphene_sphere_tHandle s, graphene_point3d_tHandle point, graphene_sphere_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_box_tHandle graphene_box_alloc();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_box_free(graphene_box_tHandle box);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_box_tHandle graphene_box_init(graphene_box_tHandle box, graphene_point3d_tHandle min, graphene_point3d_tHandle max);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_box_tHandle graphene_box_init_from_points(graphene_box_tHandle box, [NativeTypeName("unsigned int")] uint n_points, graphene_point3d_tHandle points);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_box_tHandle graphene_box_init_from_vectors(graphene_box_tHandle box, [NativeTypeName("unsigned int")] uint n_vectors, graphene_vec3_tHandle vectors);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_box_tHandle graphene_box_init_from_box(graphene_box_tHandle box, graphene_box_tHandle src);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_box_tHandle graphene_box_init_from_vec3(graphene_box_tHandle box, graphene_vec3_tHandle min, graphene_vec3_tHandle max);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_box_expand(graphene_box_tHandle box, graphene_point3d_tHandle point, graphene_box_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_box_expand_vec3(graphene_box_tHandle box, graphene_vec3_tHandle vec, graphene_box_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_box_expand_scalar(graphene_box_tHandle box, float scalar, graphene_box_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_box_union(graphene_box_tHandle a, graphene_box_tHandle b, graphene_box_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_box_intersection(graphene_box_tHandle a, graphene_box_tHandle b, graphene_box_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_box_get_width(graphene_box_tHandle box);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_box_get_height(graphene_box_tHandle box);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_box_get_depth(graphene_box_tHandle box);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_box_get_size(graphene_box_tHandle box, graphene_vec3_tHandle size);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_box_get_center(graphene_box_tHandle box, graphene_point3d_tHandle center);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_box_get_min(graphene_box_tHandle box, graphene_point3d_tHandle min);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_box_get_max(graphene_box_tHandle box, graphene_point3d_tHandle max);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_box_get_vertices(graphene_box_tHandle box, graphene_vec3_t[] vertices);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_box_get_bounding_sphere(graphene_box_tHandle box, graphene_sphere_tHandle sphere);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_box_contains_point(graphene_box_tHandle box, graphene_point3d_tHandle point);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_box_contains_box(graphene_box_tHandle a, graphene_box_tHandle b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_box_equal(graphene_box_tHandle a, graphene_box_tHandle b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_box_tHandle graphene_box_zero();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_box_tHandle graphene_box_one();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_box_tHandle graphene_box_minus_one();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_box_tHandle graphene_box_one_minus_one();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_box_tHandle graphene_box_infinite();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_box_tHandle graphene_box_empty();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_triangle_tHandle graphene_triangle_alloc();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_triangle_free(graphene_triangle_tHandle t);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_triangle_tHandle graphene_triangle_init_from_point3d(graphene_triangle_tHandle t, graphene_point3d_tHandle a, graphene_point3d_tHandle b, graphene_point3d_tHandle c);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_triangle_tHandle graphene_triangle_init_from_vec3(graphene_triangle_tHandle t, graphene_vec3_tHandle a, graphene_vec3_tHandle b, graphene_vec3_tHandle c);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_triangle_tHandle graphene_triangle_init_from_float(graphene_triangle_tHandle t, [NativeTypeName("const float *")] float* a, [NativeTypeName("const float *")] float* b, [NativeTypeName("const float *")] float* c);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_triangle_get_points(graphene_triangle_tHandle t, graphene_point3d_tHandle a, graphene_point3d_tHandle b, graphene_point3d_tHandle c);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_triangle_get_vertices(graphene_triangle_tHandle t, graphene_vec3_tHandle a, graphene_vec3_tHandle b, graphene_vec3_tHandle c);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_triangle_get_area(graphene_triangle_tHandle t);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_triangle_get_midpoint(graphene_triangle_tHandle t, graphene_point3d_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_triangle_get_normal(graphene_triangle_tHandle t, graphene_vec3_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_triangle_get_plane(graphene_triangle_tHandle t, graphene_plane_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_triangle_get_bounding_box(graphene_triangle_tHandle t, graphene_box_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_triangle_get_barycoords(graphene_triangle_tHandle t, graphene_point3d_tHandle p, graphene_vec2_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_triangle_get_uv(graphene_triangle_tHandle t, graphene_point3d_tHandle p, graphene_vec2_tHandle uv_a, graphene_vec2_tHandle uv_b, graphene_vec2_tHandle uv_c, graphene_vec2_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_triangle_contains_point(graphene_triangle_tHandle t, graphene_point3d_tHandle p);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_triangle_equal(graphene_triangle_tHandle a, graphene_triangle_tHandle b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_ray_tHandle graphene_ray_alloc();
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_ray_free(graphene_ray_tHandle r);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_ray_tHandle graphene_ray_init(graphene_ray_tHandle r, graphene_point3d_tHandle origin, graphene_vec3_tHandle direction);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_ray_tHandle graphene_ray_init_from_ray(graphene_ray_tHandle r, graphene_ray_tHandle src);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_ray_tHandle graphene_ray_init_from_vec3(graphene_ray_tHandle r, graphene_vec3_tHandle origin, graphene_vec3_tHandle direction);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_ray_get_origin(graphene_ray_tHandle r, graphene_point3d_tHandle origin);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_ray_get_direction(graphene_ray_tHandle r, graphene_vec3_tHandle direction);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_ray_get_position_at(graphene_ray_tHandle r, float t, graphene_point3d_tHandle position);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_ray_get_distance_to_point(graphene_ray_tHandle r, graphene_point3d_tHandle p);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern float graphene_ray_get_distance_to_plane(graphene_ray_tHandle r, graphene_plane_tHandle p);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_ray_equal(graphene_ray_tHandle a, graphene_ray_tHandle b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void graphene_ray_get_closest_point_to_point(graphene_ray_tHandle r, graphene_point3d_tHandle p, graphene_point3d_tHandle res);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_ray_intersection_kind_t graphene_ray_intersect_sphere(graphene_ray_tHandle r, graphene_sphere_tHandle s, float* t_out);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_ray_intersects_sphere(graphene_ray_tHandle r, graphene_sphere_tHandle s);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_ray_intersection_kind_t graphene_ray_intersect_box(graphene_ray_tHandle r, graphene_box_tHandle b, float* t_out);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_ray_intersects_box(graphene_ray_tHandle r, graphene_box_tHandle b);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern graphene_ray_intersection_kind_t graphene_ray_intersect_triangle(graphene_ray_tHandle r, graphene_triangle_tHandle t, float* t_out);
	//
	// [DllImport("libgtk-4.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("bool")]
	// public static extern byte graphene_ray_intersects_triangle(graphene_ray_tHandle r, graphene_triangle_tHandle t);
	//
	//     public const float GRAPHENE_PI = 3.1415926535897932384626434f;
	//
	//     public const float GRAPHENE_PI_2 = 1.5707963267948966192313217f;
	//
	//     public const int GRAPHENE_MAJOR_VERSION = (1);
	//
	//     public const int GRAPHENE_MINOR_VERSION = (10);
	//
	//     public const int GRAPHENE_MICRO_VERSION = (8);
	//
	//     public const int GRAPHENE_VERSION = (((1)) << 24 | ((10)) << 16 | ((8)) << 8);
	//
	//     public const int GRAPHENE_VERSION_CUR_STABLE = ((((1)) << 16 | ((10)) << 8));
	//
	//     public const int GRAPHENE_VERSION_PREV_STABLE = ((((1)) << 16 | ((10) - 2) << 8));
	//
	//     public const int GRAPHENE_VERSION_1_0 = (((1) << 16 | (0) << 8));
	//
	//     public const int GRAPHENE_VERSION_1_2 = (((1) << 16 | (2) << 8));
	//
	//     public const int GRAPHENE_VERSION_1_4 = (((1) << 16 | (4) << 8));
	//
	//     public const int GRAPHENE_VERSION_1_6 = (((1) << 16 | (6) << 8));
	//
	//     public const int GRAPHENE_VERSION_1_8 = (((1) << 16 | (8) << 8));
	//
	//     public const int GRAPHENE_VERSION_1_10 = (((1) << 16 | (10) << 8));
	//
	//     public const int GRAPHENE_VERSION_MIN_REQUIRED = ((((1) << 16 | (0) << 8)));
	//
	//     public const int GRAPHENE_VERSION_MAX_ALLOWED = (((((1)) << 16 | ((10)) << 8)));
	//
	//     public const int GRAPHENE_VEC2_LEN = 2;
	//
	//     public const int GRAPHENE_VEC3_LEN = 3;
	//
	//     public const int GRAPHENE_VEC4_LEN = 4;
	//
	//     public static ref readonly _graphene_point_t GRAPHENE_POINT_INIT_ZERO
	// {
	//     get
	//     {
	//     }
	// }
	//
	//     public static ref readonly _graphene_size_t GRAPHENE_SIZE_INIT_ZERO
	// {
	//     get
	//     {
	//     }
	// }
	//
	//     public static ref readonly _graphene_rect_t GRAPHENE_RECT_INIT_ZERO
	// {
	//     get
	//     {
	//     }
	// }
	//
	//     public static ref readonly _graphene_point3d_t GRAPHENE_POINT3D_INIT_ZERO
	// {
	//     get
	//     {
	//     }
	// }
}
