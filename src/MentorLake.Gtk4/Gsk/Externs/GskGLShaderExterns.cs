using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.Graphene;

namespace MentorLake.Gtk4.Gsk;
public static class GskGLShaderExterns
{
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_compile")]
    internal static extern int gsk_gl_shader_compile(this GskGLShaderHandle shader, GskRendererHandle renderer, out GErrorHandle error);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_get_source")]
    internal static extern GBytesHandle gsk_gl_shader_get_source(this GskGLShaderHandle shader);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_get_resource")]
    internal static extern string gsk_gl_shader_get_resource(this GskGLShaderHandle shader);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_get_n_textures")]
    internal static extern int gsk_gl_shader_get_n_textures(this GskGLShaderHandle shader);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_get_n_uniforms")]
    internal static extern int gsk_gl_shader_get_n_uniforms(this GskGLShaderHandle shader);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_get_uniform_name")]
    internal static extern string gsk_gl_shader_get_uniform_name(this GskGLShaderHandle shader, int idx);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_find_uniform_by_name")]
    internal static extern int gsk_gl_shader_find_uniform_by_name(this GskGLShaderHandle shader, string name);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_get_uniform_type")]
    internal static extern GskGLUniformType gsk_gl_shader_get_uniform_type(this GskGLShaderHandle shader, int idx);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_get_uniform_offset")]
    internal static extern int gsk_gl_shader_get_uniform_offset(this GskGLShaderHandle shader, int idx);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_get_args_size")]
    internal static extern nuint gsk_gl_shader_get_args_size(this GskGLShaderHandle shader);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_format_args_va")]
    internal static extern GBytesHandle gsk_gl_shader_format_args_va(this GskGLShaderHandle shader, IntPtr @__argList);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_format_args")]
    internal static extern GBytesHandle gsk_gl_shader_format_args(this GskGLShaderHandle shader, IntPtr @__argList);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_get_arg_float")]
    internal static extern float gsk_gl_shader_get_arg_float(this GskGLShaderHandle shader, GBytesHandle args, int idx);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_get_arg_int")]
    internal static extern int gsk_gl_shader_get_arg_int(this GskGLShaderHandle shader, GBytesHandle args, int idx);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_get_arg_uint")]
    internal static extern uint gsk_gl_shader_get_arg_uint(this GskGLShaderHandle shader, GBytesHandle args, int idx);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_get_arg_bool")]
    internal static extern int gsk_gl_shader_get_arg_bool(this GskGLShaderHandle shader, GBytesHandle args, int idx);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_get_arg_vec2")]
    internal static extern void gsk_gl_shader_get_arg_vec2(this GskGLShaderHandle shader, GBytesHandle args, int idx, graphene_vec2_tHandle out_value);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_get_arg_vec3")]
    internal static extern void gsk_gl_shader_get_arg_vec3(this GskGLShaderHandle shader, GBytesHandle args, int idx, graphene_vec3_tHandle out_value);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_get_arg_vec4")]
    internal static extern void gsk_gl_shader_get_arg_vec4(this GskGLShaderHandle shader, GBytesHandle args, int idx, graphene_vec4_tHandle out_value);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_shader_args_builder_new")]
    internal static extern GskShaderArgsBuilderHandle gsk_shader_args_builder_new(this GskGLShaderHandle shader, GBytesHandle initial_values);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_node_new")]
    internal static extern GskRenderNodeHandle gsk_gl_shader_node_new(this GskGLShaderHandle shader, graphene_rect_tHandle bounds, GBytesHandle args, GskRenderNodeHandle[] children, uint n_children);
    [DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GskGLShaderHandle gsk_gl_shader_new_from_bytes(GBytesHandle sourcecode);
    [DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GskGLShaderHandle gsk_gl_shader_new_from_resource(string resource_path);
}
