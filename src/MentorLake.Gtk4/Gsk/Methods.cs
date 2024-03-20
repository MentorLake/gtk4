using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gsk;

public static class Methods
{
	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_gl_shader_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_shader_args_builder_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_render_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark gsk_serialization_error_quark();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_debug_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_color_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_texture_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_linear_gradient_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_repeating_linear_gradient_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_conic_gradient_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_radial_gradient_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_repeating_radial_gradient_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_border_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_inset_shadow_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_outset_shadow_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_cairo_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_container_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_transform_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_opacity_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_color_matrix_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_repeat_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_clip_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_rounded_clip_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_shadow_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_blend_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_cross_fade_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_text_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_blur_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_gl_shader_node_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_renderer_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_transform_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int gsk_transform_parse(string @string, out GskTransformHandle out_transform);

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_cairo_renderer_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_render_node_type_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_scaling_filter_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_blend_mode_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_corner_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_serialization_error_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_transform_category_get_type();

	[DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType gsk_gl_uniform_type_get_type();
}
