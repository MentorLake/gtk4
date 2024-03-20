using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gsk;
public static class GskRenderNodeExterns
{
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_render_node_ref")]
    internal static extern GskRenderNodeHandle gsk_render_node_ref(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_render_node_unref")]
    internal static extern void gsk_render_node_unref(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_render_node_get_node_type")]
    internal static extern GskRenderNodeType gsk_render_node_get_node_type(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_render_node_get_bounds")]
    internal static extern void gsk_render_node_get_bounds(this GskRenderNodeHandle node, graphene_rect_tHandle bounds);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_render_node_draw")]
    internal static extern void gsk_render_node_draw(this GskRenderNodeHandle node, cairoHandle cr);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_render_node_serialize")]
    internal static extern GBytesHandle gsk_render_node_serialize(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_render_node_write_to_file")]
    internal static extern int gsk_render_node_write_to_file(this GskRenderNodeHandle node, string filename, out GErrorHandle error);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_debug_node_new")]
    internal static extern GskRenderNodeHandle gsk_debug_node_new(this GskRenderNodeHandle child, string message);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_debug_node_get_child")]
    internal static extern GskRenderNodeHandle gsk_debug_node_get_child(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_debug_node_get_message")]
    internal static extern string gsk_debug_node_get_message(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_color_node_get_color")]
    internal static extern GdkRGBAHandle gsk_color_node_get_color(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_texture_node_get_texture")]
    internal static extern GdkTextureHandle gsk_texture_node_get_texture(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_linear_gradient_node_get_start")]
    internal static extern graphene_point_tHandle gsk_linear_gradient_node_get_start(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_linear_gradient_node_get_end")]
    internal static extern graphene_point_tHandle gsk_linear_gradient_node_get_end(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_linear_gradient_node_get_n_color_stops")]
    internal static extern nuint gsk_linear_gradient_node_get_n_color_stops(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_linear_gradient_node_get_color_stops")]
    internal static extern GskColorStopHandle gsk_linear_gradient_node_get_color_stops(this GskRenderNodeHandle node, out nuint n_stops);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_conic_gradient_node_get_center")]
    internal static extern graphene_point_tHandle gsk_conic_gradient_node_get_center(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_conic_gradient_node_get_rotation")]
    internal static extern float gsk_conic_gradient_node_get_rotation(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_conic_gradient_node_get_angle")]
    internal static extern float gsk_conic_gradient_node_get_angle(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_conic_gradient_node_get_n_color_stops")]
    internal static extern nuint gsk_conic_gradient_node_get_n_color_stops(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_conic_gradient_node_get_color_stops")]
    internal static extern GskColorStopHandle gsk_conic_gradient_node_get_color_stops(this GskRenderNodeHandle node, out nuint n_stops);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_radial_gradient_node_get_n_color_stops")]
    internal static extern nuint gsk_radial_gradient_node_get_n_color_stops(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_radial_gradient_node_get_color_stops")]
    internal static extern GskColorStopHandle gsk_radial_gradient_node_get_color_stops(this GskRenderNodeHandle node, out nuint n_stops);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_radial_gradient_node_get_center")]
    internal static extern graphene_point_tHandle gsk_radial_gradient_node_get_center(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_radial_gradient_node_get_hradius")]
    internal static extern float gsk_radial_gradient_node_get_hradius(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_radial_gradient_node_get_vradius")]
    internal static extern float gsk_radial_gradient_node_get_vradius(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_radial_gradient_node_get_start")]
    internal static extern float gsk_radial_gradient_node_get_start(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_radial_gradient_node_get_end")]
    internal static extern float gsk_radial_gradient_node_get_end(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_border_node_get_outline")]
    internal static extern GskRoundedRectHandle gsk_border_node_get_outline(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_border_node_get_widths")]
    internal static extern float[] gsk_border_node_get_widths(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_border_node_get_colors")]
    internal static extern GdkRGBAHandle gsk_border_node_get_colors(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_inset_shadow_node_get_outline")]
    internal static extern GskRoundedRectHandle gsk_inset_shadow_node_get_outline(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_inset_shadow_node_get_color")]
    internal static extern GdkRGBAHandle gsk_inset_shadow_node_get_color(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_inset_shadow_node_get_dx")]
    internal static extern float gsk_inset_shadow_node_get_dx(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_inset_shadow_node_get_dy")]
    internal static extern float gsk_inset_shadow_node_get_dy(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_inset_shadow_node_get_spread")]
    internal static extern float gsk_inset_shadow_node_get_spread(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_inset_shadow_node_get_blur_radius")]
    internal static extern float gsk_inset_shadow_node_get_blur_radius(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_outset_shadow_node_get_outline")]
    internal static extern GskRoundedRectHandle gsk_outset_shadow_node_get_outline(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_outset_shadow_node_get_color")]
    internal static extern GdkRGBAHandle gsk_outset_shadow_node_get_color(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_outset_shadow_node_get_dx")]
    internal static extern float gsk_outset_shadow_node_get_dx(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_outset_shadow_node_get_dy")]
    internal static extern float gsk_outset_shadow_node_get_dy(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_outset_shadow_node_get_spread")]
    internal static extern float gsk_outset_shadow_node_get_spread(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_outset_shadow_node_get_blur_radius")]
    internal static extern float gsk_outset_shadow_node_get_blur_radius(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_cairo_node_get_draw_context")]
    internal static extern cairoHandle gsk_cairo_node_get_draw_context(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_cairo_node_get_surface")]
    internal static extern cairo_surfaceHandle gsk_cairo_node_get_surface(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_container_node_new")]
    internal static extern GskRenderNodeHandle gsk_container_node_new(GskRenderNodeHandle[] children, uint n_children);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_container_node_get_n_children")]
    internal static extern uint gsk_container_node_get_n_children(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_container_node_get_child")]
    internal static extern GskRenderNodeHandle gsk_container_node_get_child(this GskRenderNodeHandle node, uint idx);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_node_new")]
    internal static extern GskRenderNodeHandle gsk_transform_node_new(this GskRenderNodeHandle child, GskTransformHandle transform);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_node_get_child")]
    internal static extern GskRenderNodeHandle gsk_transform_node_get_child(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_transform_node_get_transform")]
    internal static extern GskTransformHandle gsk_transform_node_get_transform(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_opacity_node_new")]
    internal static extern GskRenderNodeHandle gsk_opacity_node_new(this GskRenderNodeHandle child, float opacity);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_opacity_node_get_child")]
    internal static extern GskRenderNodeHandle gsk_opacity_node_get_child(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_opacity_node_get_opacity")]
    internal static extern float gsk_opacity_node_get_opacity(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_color_matrix_node_new")]
    internal static extern GskRenderNodeHandle gsk_color_matrix_node_new(this GskRenderNodeHandle child, graphene_matrix_tHandle color_matrix, graphene_vec4_tHandle color_offset);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_color_matrix_node_get_child")]
    internal static extern GskRenderNodeHandle gsk_color_matrix_node_get_child(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_color_matrix_node_get_color_matrix")]
    internal static extern graphene_matrix_tHandle gsk_color_matrix_node_get_color_matrix(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_color_matrix_node_get_color_offset")]
    internal static extern graphene_vec4_tHandle gsk_color_matrix_node_get_color_offset(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_repeat_node_get_child")]
    internal static extern GskRenderNodeHandle gsk_repeat_node_get_child(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_repeat_node_get_child_bounds")]
    internal static extern graphene_rect_tHandle gsk_repeat_node_get_child_bounds(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_clip_node_new")]
    internal static extern GskRenderNodeHandle gsk_clip_node_new(this GskRenderNodeHandle child, graphene_rect_tHandle clip);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_clip_node_get_child")]
    internal static extern GskRenderNodeHandle gsk_clip_node_get_child(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_clip_node_get_clip")]
    internal static extern graphene_rect_tHandle gsk_clip_node_get_clip(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_rounded_clip_node_new")]
    internal static extern GskRenderNodeHandle gsk_rounded_clip_node_new(this GskRenderNodeHandle child, GskRoundedRectHandle clip);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_rounded_clip_node_get_child")]
    internal static extern GskRenderNodeHandle gsk_rounded_clip_node_get_child(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_rounded_clip_node_get_clip")]
    internal static extern GskRoundedRectHandle gsk_rounded_clip_node_get_clip(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_shadow_node_new")]
    internal static extern GskRenderNodeHandle gsk_shadow_node_new(this GskRenderNodeHandle child, GskShadowHandle shadows, nuint n_shadows);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_shadow_node_get_child")]
    internal static extern GskRenderNodeHandle gsk_shadow_node_get_child(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_shadow_node_get_shadow")]
    internal static extern GskShadowHandle gsk_shadow_node_get_shadow(this GskRenderNodeHandle node, nuint i);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_shadow_node_get_n_shadows")]
    internal static extern nuint gsk_shadow_node_get_n_shadows(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_blend_node_new")]
    internal static extern GskRenderNodeHandle gsk_blend_node_new(this GskRenderNodeHandle bottom, GskRenderNodeHandle top, GskBlendMode blend_mode);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_blend_node_get_bottom_child")]
    internal static extern GskRenderNodeHandle gsk_blend_node_get_bottom_child(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_blend_node_get_top_child")]
    internal static extern GskRenderNodeHandle gsk_blend_node_get_top_child(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_blend_node_get_blend_mode")]
    internal static extern GskBlendMode gsk_blend_node_get_blend_mode(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_cross_fade_node_new")]
    internal static extern GskRenderNodeHandle gsk_cross_fade_node_new(this GskRenderNodeHandle start, GskRenderNodeHandle end, float progress);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_cross_fade_node_get_start_child")]
    internal static extern GskRenderNodeHandle gsk_cross_fade_node_get_start_child(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_cross_fade_node_get_end_child")]
    internal static extern GskRenderNodeHandle gsk_cross_fade_node_get_end_child(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_cross_fade_node_get_progress")]
    internal static extern float gsk_cross_fade_node_get_progress(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_text_node_get_font")]
    internal static extern PangoFontHandle gsk_text_node_get_font(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_text_node_has_color_glyphs")]
    internal static extern int gsk_text_node_has_color_glyphs(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_text_node_get_num_glyphs")]
    internal static extern uint gsk_text_node_get_num_glyphs(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_text_node_get_glyphs")]
    internal static extern PangoGlyphInfoHandle[] gsk_text_node_get_glyphs(this GskRenderNodeHandle node, out uint[] n_glyphs);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_text_node_get_color")]
    internal static extern GdkRGBAHandle gsk_text_node_get_color(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_text_node_get_offset")]
    internal static extern graphene_point_tHandle gsk_text_node_get_offset(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_blur_node_new")]
    internal static extern GskRenderNodeHandle gsk_blur_node_new(this GskRenderNodeHandle child, float radius);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_blur_node_get_child")]
    internal static extern GskRenderNodeHandle gsk_blur_node_get_child(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_blur_node_get_radius")]
    internal static extern float gsk_blur_node_get_radius(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_node_get_n_children")]
    internal static extern uint gsk_gl_shader_node_get_n_children(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_node_get_child")]
    internal static extern GskRenderNodeHandle gsk_gl_shader_node_get_child(this GskRenderNodeHandle node, uint idx);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_node_get_args")]
    internal static extern GBytesHandle gsk_gl_shader_node_get_args(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, EntryPoint = "gsk_gl_shader_node_get_shader")]
    internal static extern GskGLShaderHandle gsk_gl_shader_node_get_shader(this GskRenderNodeHandle node);
    [DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GskRenderNodeHandle gsk_color_node_new(GdkRGBAHandle rgba, graphene_rect_tHandle bounds);
    [DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GskRenderNodeHandle gsk_texture_node_new(GdkTextureHandle texture, graphene_rect_tHandle bounds);
    [DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GskRenderNodeHandle gsk_linear_gradient_node_new(graphene_rect_tHandle bounds, graphene_point_tHandle start, graphene_point_tHandle end, GskColorStopHandle color_stops, nuint n_color_stops);
    [DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GskRenderNodeHandle gsk_repeating_linear_gradient_node_new(graphene_rect_tHandle bounds, graphene_point_tHandle start, graphene_point_tHandle end, GskColorStopHandle color_stops, nuint n_color_stops);
    [DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GskRenderNodeHandle gsk_conic_gradient_node_new(graphene_rect_tHandle bounds, graphene_point_tHandle center, float rotation, GskColorStopHandle color_stops, nuint n_color_stops);
    [DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GskRenderNodeHandle gsk_radial_gradient_node_new(graphene_rect_tHandle bounds, graphene_point_tHandle center, float hradius, float vradius, float start, float end, GskColorStopHandle color_stops, nuint n_color_stops);
    [DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GskRenderNodeHandle gsk_repeating_radial_gradient_node_new(graphene_rect_tHandle bounds, graphene_point_tHandle center, float hradius, float vradius, float start, float end, GskColorStopHandle color_stops, nuint n_color_stops);
    [DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GskRenderNodeHandle gsk_cairo_node_new(graphene_rect_tHandle bounds);
    [DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GskRenderNodeHandle gsk_repeat_node_new(graphene_rect_tHandle bounds, GskRenderNodeHandle child, graphene_rect_tHandle child_bounds);
    [DllImport(Libraries.Gsk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GskRenderNodeHandle gsk_text_node_new(PangoFontHandle font, PangoGlyphStringHandle glyphs, GdkRGBAHandle color, graphene_point_tHandle offset);
}
