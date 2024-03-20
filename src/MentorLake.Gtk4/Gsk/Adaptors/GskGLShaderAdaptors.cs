using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.Graphene;

namespace MentorLake.Gtk4.Gsk;
public static class GskGLShaderAdaptors
{
	public static int GskGlShaderCompile(this GskGLShaderHandle shader, GskRendererHandle renderer, out GErrorHandle error)
	{
		return GskGLShaderExterns.gsk_gl_shader_compile(shader, renderer, out error);
	}

	public static GBytesHandle GskGlShaderGetSource(this GskGLShaderHandle shader)
	{
		return GskGLShaderExterns.gsk_gl_shader_get_source(shader);
	}

	public static string GskGlShaderGetResource(this GskGLShaderHandle shader)
	{
		return GskGLShaderExterns.gsk_gl_shader_get_resource(shader);
	}

	public static int GskGlShaderGetNTextures(this GskGLShaderHandle shader)
	{
		return GskGLShaderExterns.gsk_gl_shader_get_n_textures(shader);
	}

	public static int GskGlShaderGetNUniforms(this GskGLShaderHandle shader)
	{
		return GskGLShaderExterns.gsk_gl_shader_get_n_uniforms(shader);
	}

	public static string GskGlShaderGetUniformName(this GskGLShaderHandle shader, int idx)
	{
		return GskGLShaderExterns.gsk_gl_shader_get_uniform_name(shader, idx);
	}

	public static int GskGlShaderFindUniformByName(this GskGLShaderHandle shader, string name)
	{
		return GskGLShaderExterns.gsk_gl_shader_find_uniform_by_name(shader, name);
	}

	public static GskGLUniformType GskGlShaderGetUniformType(this GskGLShaderHandle shader, int idx)
	{
		return GskGLShaderExterns.gsk_gl_shader_get_uniform_type(shader, idx);
	}

	public static int GskGlShaderGetUniformOffset(this GskGLShaderHandle shader, int idx)
	{
		return GskGLShaderExterns.gsk_gl_shader_get_uniform_offset(shader, idx);
	}

	public static nuint GskGlShaderGetArgsSize(this GskGLShaderHandle shader)
	{
		return GskGLShaderExterns.gsk_gl_shader_get_args_size(shader);
	}

	public static GBytesHandle GskGlShaderFormatArgsVa(this GskGLShaderHandle shader, IntPtr @__argList)
	{
		return GskGLShaderExterns.gsk_gl_shader_format_args_va(shader, @__argList);
	}

	public static GBytesHandle GskGlShaderFormatArgs(this GskGLShaderHandle shader, IntPtr @__argList)
	{
		return GskGLShaderExterns.gsk_gl_shader_format_args(shader, @__argList);
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

	public static int GskGlShaderGetArgBool(this GskGLShaderHandle shader, GBytesHandle args, int idx)
	{
		return GskGLShaderExterns.gsk_gl_shader_get_arg_bool(shader, args, idx);
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

	public static GskShaderArgsBuilderHandle GskShaderArgsBuilderNew(this GskGLShaderHandle shader, GBytesHandle initial_values)
	{
		return GskGLShaderExterns.gsk_shader_args_builder_new(shader, initial_values);
	}

	public static GskRenderNodeHandle GskGlShaderNodeNew(this GskGLShaderHandle shader, graphene_rect_tHandle bounds, GBytesHandle args, GskRenderNodeHandle[] children, uint n_children)
	{
		return GskGLShaderExterns.gsk_gl_shader_node_new(shader, bounds, args, children, n_children);
	}

	public static GskGLShaderHandle GskGlShaderNewFromResource(string resource_path)
	{
		return GskGLShaderExterns.gsk_gl_shader_new_from_resource(resource_path);
	}
}
