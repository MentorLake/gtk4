using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Gsk;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSnapshotExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_free_to_node")]
    internal static extern GskRenderNodeHandle gtk_snapshot_free_to_node(this GtkSnapshotHandle snapshot);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_free_to_paintable")]
    internal static extern GdkPaintableHandle gtk_snapshot_free_to_paintable(this GtkSnapshotHandle snapshot, graphene_size_tHandle size);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_to_node")]
    internal static extern GskRenderNodeHandle gtk_snapshot_to_node(this GtkSnapshotHandle snapshot);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_to_paintable")]
    internal static extern GdkPaintableHandle gtk_snapshot_to_paintable(this GtkSnapshotHandle snapshot, graphene_size_tHandle size);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_push_debug")]
    internal static extern void gtk_snapshot_push_debug(this GtkSnapshotHandle snapshot, string message, IntPtr @__argList);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_push_opacity")]
    internal static extern void gtk_snapshot_push_opacity(this GtkSnapshotHandle snapshot, double opacity);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_push_blur")]
    internal static extern void gtk_snapshot_push_blur(this GtkSnapshotHandle snapshot, double radius);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_push_color_matrix")]
    internal static extern void gtk_snapshot_push_color_matrix(this GtkSnapshotHandle snapshot, graphene_matrix_tHandle color_matrix, graphene_vec4_tHandle color_offset);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_push_repeat")]
    internal static extern void gtk_snapshot_push_repeat(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_rect_tHandle child_bounds);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_push_clip")]
    internal static extern void gtk_snapshot_push_clip(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_push_rounded_clip")]
    internal static extern void gtk_snapshot_push_rounded_clip(this GtkSnapshotHandle snapshot, GskRoundedRectHandle bounds);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_push_shadow")]
    internal static extern void gtk_snapshot_push_shadow(this GtkSnapshotHandle snapshot, GskShadowHandle shadow, nuint n_shadows);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_push_blend")]
    internal static extern void gtk_snapshot_push_blend(this GtkSnapshotHandle snapshot, GskBlendMode blend_mode);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_push_cross_fade")]
    internal static extern void gtk_snapshot_push_cross_fade(this GtkSnapshotHandle snapshot, double progress);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_push_gl_shader")]
    internal static extern void gtk_snapshot_push_gl_shader(this GtkSnapshotHandle snapshot, GskGLShaderHandle shader, graphene_rect_tHandle bounds, GBytesHandle take_args);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_gl_shader_pop_texture")]
    internal static extern void gtk_snapshot_gl_shader_pop_texture(this GtkSnapshotHandle snapshot);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_pop")]
    internal static extern void gtk_snapshot_pop(this GtkSnapshotHandle snapshot);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_save")]
    internal static extern void gtk_snapshot_save(this GtkSnapshotHandle snapshot);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_restore")]
    internal static extern void gtk_snapshot_restore(this GtkSnapshotHandle snapshot);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_transform")]
    internal static extern void gtk_snapshot_transform(this GtkSnapshotHandle snapshot, GskTransformHandle transform);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_transform_matrix")]
    internal static extern void gtk_snapshot_transform_matrix(this GtkSnapshotHandle snapshot, graphene_matrix_tHandle matrix);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_translate")]
    internal static extern void gtk_snapshot_translate(this GtkSnapshotHandle snapshot, graphene_point_tHandle point);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_translate_3d")]
    internal static extern void gtk_snapshot_translate_3d(this GtkSnapshotHandle snapshot, graphene_point3d_tHandle point);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_rotate")]
    internal static extern void gtk_snapshot_rotate(this GtkSnapshotHandle snapshot, float angle);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_rotate_3d")]
    internal static extern void gtk_snapshot_rotate_3d(this GtkSnapshotHandle snapshot, float angle, graphene_vec3_tHandle axis);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_scale")]
    internal static extern void gtk_snapshot_scale(this GtkSnapshotHandle snapshot, float factor_x, float factor_y);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_scale_3d")]
    internal static extern void gtk_snapshot_scale_3d(this GtkSnapshotHandle snapshot, float factor_x, float factor_y, float factor_z);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_perspective")]
    internal static extern void gtk_snapshot_perspective(this GtkSnapshotHandle snapshot, float depth);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_append_node")]
    internal static extern void gtk_snapshot_append_node(this GtkSnapshotHandle snapshot, GskRenderNodeHandle node);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_append_cairo")]
    internal static extern cairoHandle gtk_snapshot_append_cairo(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_append_texture")]
    internal static extern void gtk_snapshot_append_texture(this GtkSnapshotHandle snapshot, GdkTextureHandle texture, graphene_rect_tHandle bounds);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_append_color")]
    internal static extern void gtk_snapshot_append_color(this GtkSnapshotHandle snapshot, GdkRGBAHandle color, graphene_rect_tHandle bounds);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_append_linear_gradient")]
    internal static extern void gtk_snapshot_append_linear_gradient(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_point_tHandle start_point, graphene_point_tHandle end_point, GskColorStopHandle stops, nuint n_stops);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_append_repeating_linear_gradient")]
    internal static extern void gtk_snapshot_append_repeating_linear_gradient(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_point_tHandle start_point, graphene_point_tHandle end_point, GskColorStopHandle stops, nuint n_stops);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_append_radial_gradient")]
    internal static extern void gtk_snapshot_append_radial_gradient(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_point_tHandle center, float hradius, float vradius, float start, float end, GskColorStopHandle stops, nuint n_stops);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_append_repeating_radial_gradient")]
    internal static extern void gtk_snapshot_append_repeating_radial_gradient(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_point_tHandle center, float hradius, float vradius, float start, float end, GskColorStopHandle stops, nuint n_stops);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_append_conic_gradient")]
    internal static extern void gtk_snapshot_append_conic_gradient(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_point_tHandle center, float rotation, GskColorStopHandle stops, nuint n_stops);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_append_border")]
    internal static extern void gtk_snapshot_append_border(this GtkSnapshotHandle snapshot, GskRoundedRectHandle outline, float[] border_width, GdkRGBA[] border_color);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_append_inset_shadow")]
    internal static extern void gtk_snapshot_append_inset_shadow(this GtkSnapshotHandle snapshot, GskRoundedRectHandle outline, GdkRGBAHandle color, float dx, float dy, float spread, float blur_radius);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_append_outset_shadow")]
    internal static extern void gtk_snapshot_append_outset_shadow(this GtkSnapshotHandle snapshot, GskRoundedRectHandle outline, GdkRGBAHandle color, float dx, float dy, float spread, float blur_radius);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_append_layout")]
    internal static extern void gtk_snapshot_append_layout(this GtkSnapshotHandle snapshot, PangoLayoutHandle layout, GdkRGBAHandle color);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_render_background")]
    internal static extern void gtk_snapshot_render_background(this GtkSnapshotHandle snapshot, GtkStyleContextHandle context, double x, double y, double width, double height);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_render_frame")]
    internal static extern void gtk_snapshot_render_frame(this GtkSnapshotHandle snapshot, GtkStyleContextHandle context, double x, double y, double width, double height);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_render_focus")]
    internal static extern void gtk_snapshot_render_focus(this GtkSnapshotHandle snapshot, GtkStyleContextHandle context, double x, double y, double width, double height);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_render_layout")]
    internal static extern void gtk_snapshot_render_layout(this GtkSnapshotHandle snapshot, GtkStyleContextHandle context, double x, double y, PangoLayoutHandle layout);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_snapshot_render_insertion_cursor")]
    internal static extern void gtk_snapshot_render_insertion_cursor(this GtkSnapshotHandle snapshot, GtkStyleContextHandle context, double x, double y, PangoLayoutHandle layout, int index, PangoDirection direction);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkSnapshotHandle gtk_snapshot_new();
}
