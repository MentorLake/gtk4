namespace MentorLake.Gtk4.Gsk4;

public class GskGLShaderHandle : GObjectHandle
{
	public static GskGLShaderHandle GskGlShaderNewFromBytes(GBytesHandle sourcecode)
	{
		return GskGLShaderExterns.gsk_gl_shader_new_from_bytes(sourcecode);
	}

	public static GskGLShaderHandle GskGlShaderNewFromResource(string resource_path)
	{
		return GskGLShaderExterns.gsk_gl_shader_new_from_resource(resource_path);
	}

}

public static class GskGLShaderHandleExtensions
{
	public static bool GskGlShaderCompile(this GskGLShaderHandle shader, GskRendererHandle renderer, out GErrorHandle error)
	{
		return GskGLShaderExterns.gsk_gl_shader_compile(shader, renderer, out error);
	}

	public static int GskGlShaderFindUniformByName(this GskGLShaderHandle shader, string name)
	{
		return GskGLShaderExterns.gsk_gl_shader_find_uniform_by_name(shader, name);
	}

	public static GBytesHandle GskGlShaderFormatArgs(this GskGLShaderHandle shader, IntPtr @__arglist)
	{
		return GskGLShaderExterns.gsk_gl_shader_format_args(shader, @__arglist);
	}

	public static GBytesHandle GskGlShaderFormatArgsVa(this GskGLShaderHandle shader, IntPtr uniforms)
	{
		return GskGLShaderExterns.gsk_gl_shader_format_args_va(shader, uniforms);
	}

	public static bool GskGlShaderGetArgBool(this GskGLShaderHandle shader, GBytesHandle args, int idx)
	{
		return GskGLShaderExterns.gsk_gl_shader_get_arg_bool(shader, args, idx);
	}

	public static float GskGlShaderGetArgFloat(this GskGLShaderHandle shader, GBytesHandle args, int idx)
	{
		return GskGLShaderExterns.gsk_gl_shader_get_arg_float(shader, args, idx);
	}

	public static int GskGlShaderGetArgInt(this GskGLShaderHandle shader, GBytesHandle args, int idx)
	{
		return GskGLShaderExterns.gsk_gl_shader_get_arg_int(shader, args, idx);
	}

	public static uint GskGlShaderGetArgUint(this GskGLShaderHandle shader, GBytesHandle args, int idx)
	{
		return GskGLShaderExterns.gsk_gl_shader_get_arg_uint(shader, args, idx);
	}

	public static GskGLShaderHandle GskGlShaderGetArgVec2(this GskGLShaderHandle shader, GBytesHandle args, int idx, graphene_vec2_tHandle out_value)
	{
		GskGLShaderExterns.gsk_gl_shader_get_arg_vec2(shader, args, idx, out_value);
		return shader;
	}

	public static GskGLShaderHandle GskGlShaderGetArgVec3(this GskGLShaderHandle shader, GBytesHandle args, int idx, graphene_vec3_tHandle out_value)
	{
		GskGLShaderExterns.gsk_gl_shader_get_arg_vec3(shader, args, idx, out_value);
		return shader;
	}

	public static GskGLShaderHandle GskGlShaderGetArgVec4(this GskGLShaderHandle shader, GBytesHandle args, int idx, graphene_vec4_tHandle out_value)
	{
		GskGLShaderExterns.gsk_gl_shader_get_arg_vec4(shader, args, idx, out_value);
		return shader;
	}

	public static int GskGlShaderGetArgsSize(this GskGLShaderHandle shader)
	{
		return GskGLShaderExterns.gsk_gl_shader_get_args_size(shader);
	}

	public static int GskGlShaderGetNTextures(this GskGLShaderHandle shader)
	{
		return GskGLShaderExterns.gsk_gl_shader_get_n_textures(shader);
	}

	public static int GskGlShaderGetNUniforms(this GskGLShaderHandle shader)
	{
		return GskGLShaderExterns.gsk_gl_shader_get_n_uniforms(shader);
	}

	public static string GskGlShaderGetResource(this GskGLShaderHandle shader)
	{
		return GskGLShaderExterns.gsk_gl_shader_get_resource(shader);
	}

	public static GBytesHandle GskGlShaderGetSource(this GskGLShaderHandle shader)
	{
		return GskGLShaderExterns.gsk_gl_shader_get_source(shader);
	}

	public static string GskGlShaderGetUniformName(this GskGLShaderHandle shader, int idx)
	{
		return GskGLShaderExterns.gsk_gl_shader_get_uniform_name(shader, idx);
	}

	public static int GskGlShaderGetUniformOffset(this GskGLShaderHandle shader, int idx)
	{
		return GskGLShaderExterns.gsk_gl_shader_get_uniform_offset(shader, idx);
	}

	public static GskGLUniformType GskGlShaderGetUniformType(this GskGLShaderHandle shader, int idx)
	{
		return GskGLShaderExterns.gsk_gl_shader_get_uniform_type(shader, idx);
	}

}

internal class GskGLShaderExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskGLShaderHandle gsk_gl_shader_new_from_bytes(GBytesHandle sourcecode);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskGLShaderHandle gsk_gl_shader_new_from_resource(string resource_path);

	[DllImport(Libraries.Gsk4)]
	internal static extern bool gsk_gl_shader_compile(GskGLShaderHandle shader, GskRendererHandle renderer, out GErrorHandle error);

	[DllImport(Libraries.Gsk4)]
	internal static extern int gsk_gl_shader_find_uniform_by_name(GskGLShaderHandle shader, string name);

	[DllImport(Libraries.Gsk4)]
	internal static extern GBytesHandle gsk_gl_shader_format_args(GskGLShaderHandle shader, IntPtr @__arglist);

	[DllImport(Libraries.Gsk4)]
	internal static extern GBytesHandle gsk_gl_shader_format_args_va(GskGLShaderHandle shader, IntPtr uniforms);

	[DllImport(Libraries.Gsk4)]
	internal static extern bool gsk_gl_shader_get_arg_bool(GskGLShaderHandle shader, GBytesHandle args, int idx);

	[DllImport(Libraries.Gsk4)]
	internal static extern float gsk_gl_shader_get_arg_float(GskGLShaderHandle shader, GBytesHandle args, int idx);

	[DllImport(Libraries.Gsk4)]
	internal static extern int gsk_gl_shader_get_arg_int(GskGLShaderHandle shader, GBytesHandle args, int idx);

	[DllImport(Libraries.Gsk4)]
	internal static extern uint gsk_gl_shader_get_arg_uint(GskGLShaderHandle shader, GBytesHandle args, int idx);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_gl_shader_get_arg_vec2(GskGLShaderHandle shader, GBytesHandle args, int idx, graphene_vec2_tHandle out_value);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_gl_shader_get_arg_vec3(GskGLShaderHandle shader, GBytesHandle args, int idx, graphene_vec3_tHandle out_value);

	[DllImport(Libraries.Gsk4)]
	internal static extern void gsk_gl_shader_get_arg_vec4(GskGLShaderHandle shader, GBytesHandle args, int idx, graphene_vec4_tHandle out_value);

	[DllImport(Libraries.Gsk4)]
	internal static extern int gsk_gl_shader_get_args_size(GskGLShaderHandle shader);

	[DllImport(Libraries.Gsk4)]
	internal static extern int gsk_gl_shader_get_n_textures(GskGLShaderHandle shader);

	[DllImport(Libraries.Gsk4)]
	internal static extern int gsk_gl_shader_get_n_uniforms(GskGLShaderHandle shader);

	[DllImport(Libraries.Gsk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gsk_gl_shader_get_resource(GskGLShaderHandle shader);

	[DllImport(Libraries.Gsk4)]
	internal static extern GBytesHandle gsk_gl_shader_get_source(GskGLShaderHandle shader);

	[DllImport(Libraries.Gsk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gsk_gl_shader_get_uniform_name(GskGLShaderHandle shader, int idx);

	[DllImport(Libraries.Gsk4)]
	internal static extern int gsk_gl_shader_get_uniform_offset(GskGLShaderHandle shader, int idx);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskGLUniformType gsk_gl_shader_get_uniform_type(GskGLShaderHandle shader, int idx);

}
