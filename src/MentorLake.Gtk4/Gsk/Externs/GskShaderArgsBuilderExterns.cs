using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.Graphene;

namespace MentorLake.Gtk4.Gsk;

public static class GskShaderArgsBuilderExterns
{
	[DllImport(Libraries.Gsk, EntryPoint = "gsk_shader_args_builder_to_args")]
	internal static extern GBytesHandle gsk_shader_args_builder_to_args(this GskShaderArgsBuilderHandle builder);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_shader_args_builder_free_to_args")]
	internal static extern GBytesHandle gsk_shader_args_builder_free_to_args(this GskShaderArgsBuilderHandle builder);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_shader_args_builder_ref")]
	internal static extern GskShaderArgsBuilderHandle gsk_shader_args_builder_ref(this GskShaderArgsBuilderHandle builder);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_shader_args_builder_unref")]
	internal static extern void gsk_shader_args_builder_unref(this GskShaderArgsBuilderHandle builder);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_shader_args_builder_set_float")]
	internal static extern void gsk_shader_args_builder_set_float(this GskShaderArgsBuilderHandle builder, int idx, float value);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_shader_args_builder_set_int")]
	internal static extern void gsk_shader_args_builder_set_int(this GskShaderArgsBuilderHandle builder, int idx, int value);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_shader_args_builder_set_uint")]
	internal static extern void gsk_shader_args_builder_set_uint(this GskShaderArgsBuilderHandle builder, int idx, uint value);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_shader_args_builder_set_bool")]
	internal static extern void gsk_shader_args_builder_set_bool(this GskShaderArgsBuilderHandle builder, int idx, int value);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_shader_args_builder_set_vec2")]
	internal static extern void gsk_shader_args_builder_set_vec2(this GskShaderArgsBuilderHandle builder, int idx, graphene_vec2_tHandle value);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_shader_args_builder_set_vec3")]
	internal static extern void gsk_shader_args_builder_set_vec3(this GskShaderArgsBuilderHandle builder, int idx, graphene_vec3_tHandle value);

	[DllImport(Libraries.Gsk, EntryPoint = "gsk_shader_args_builder_set_vec4")]
	internal static extern void gsk_shader_args_builder_set_vec4(this GskShaderArgsBuilderHandle builder, int idx, graphene_vec4_tHandle value);
}
