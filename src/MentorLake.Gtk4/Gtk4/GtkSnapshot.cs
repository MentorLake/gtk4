using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkSnapshotHandle : GdkSnapshotHandle
{
	public static GtkSnapshotHandle New()
	{
		return GtkSnapshotExterns.gtk_snapshot_new();
	}
}

public static class GtkSnapshotSignals
{
}

public static class GtkSnapshotHandleExtensions
{
	public static GtkSnapshotHandle AppendBorder(this GtkSnapshotHandle snapshot, GskRoundedRectHandle outline, float[] border_width, GdkRGBA[] border_color)
	{
		GtkSnapshotExterns.gtk_snapshot_append_border(snapshot, outline, border_width, border_color);
		return snapshot;
	}

	public static cairo_tHandle AppendCairo(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds)
	{
		return GtkSnapshotExterns.gtk_snapshot_append_cairo(snapshot, bounds);
	}

	public static GtkSnapshotHandle AppendColor(this GtkSnapshotHandle snapshot, GdkRGBAHandle color, graphene_rect_tHandle bounds)
	{
		GtkSnapshotExterns.gtk_snapshot_append_color(snapshot, color, bounds);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendConicGradient(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_point_tHandle center, float rotation, GskColorStop[] stops, int n_stops)
	{
		GtkSnapshotExterns.gtk_snapshot_append_conic_gradient(snapshot, bounds, center, rotation, stops, n_stops);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendFill(this GtkSnapshotHandle snapshot, GskPathHandle path, GskFillRule fill_rule, GdkRGBAHandle color)
	{
		GtkSnapshotExterns.gtk_snapshot_append_fill(snapshot, path, fill_rule, color);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendInsetShadow(this GtkSnapshotHandle snapshot, GskRoundedRectHandle outline, GdkRGBAHandle color, float dx, float dy, float spread, float blur_radius)
	{
		GtkSnapshotExterns.gtk_snapshot_append_inset_shadow(snapshot, outline, color, dx, dy, spread, blur_radius);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendLayout(this GtkSnapshotHandle snapshot, PangoLayoutHandle layout, GdkRGBAHandle color)
	{
		GtkSnapshotExterns.gtk_snapshot_append_layout(snapshot, layout, color);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendLinearGradient(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_point_tHandle start_point, graphene_point_tHandle end_point, GskColorStop[] stops, int n_stops)
	{
		GtkSnapshotExterns.gtk_snapshot_append_linear_gradient(snapshot, bounds, start_point, end_point, stops, n_stops);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendNode(this GtkSnapshotHandle snapshot, GskRenderNodeHandle node)
	{
		GtkSnapshotExterns.gtk_snapshot_append_node(snapshot, node);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendOutsetShadow(this GtkSnapshotHandle snapshot, GskRoundedRectHandle outline, GdkRGBAHandle color, float dx, float dy, float spread, float blur_radius)
	{
		GtkSnapshotExterns.gtk_snapshot_append_outset_shadow(snapshot, outline, color, dx, dy, spread, blur_radius);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendRadialGradient(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_point_tHandle center, float hradius, float vradius, float start, float end, GskColorStop[] stops, int n_stops)
	{
		GtkSnapshotExterns.gtk_snapshot_append_radial_gradient(snapshot, bounds, center, hradius, vradius, start, end, stops, n_stops);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendRepeatingLinearGradient(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_point_tHandle start_point, graphene_point_tHandle end_point, GskColorStop[] stops, int n_stops)
	{
		GtkSnapshotExterns.gtk_snapshot_append_repeating_linear_gradient(snapshot, bounds, start_point, end_point, stops, n_stops);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendRepeatingRadialGradient(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_point_tHandle center, float hradius, float vradius, float start, float end, GskColorStop[] stops, int n_stops)
	{
		GtkSnapshotExterns.gtk_snapshot_append_repeating_radial_gradient(snapshot, bounds, center, hradius, vradius, start, end, stops, n_stops);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendScaledTexture(this GtkSnapshotHandle snapshot, GdkTextureHandle texture, GskScalingFilter filter, graphene_rect_tHandle bounds)
	{
		GtkSnapshotExterns.gtk_snapshot_append_scaled_texture(snapshot, texture, filter, bounds);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendStroke(this GtkSnapshotHandle snapshot, GskPathHandle path, GskStrokeHandle stroke, GdkRGBAHandle color)
	{
		GtkSnapshotExterns.gtk_snapshot_append_stroke(snapshot, path, stroke, color);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendTexture(this GtkSnapshotHandle snapshot, GdkTextureHandle texture, graphene_rect_tHandle bounds)
	{
		GtkSnapshotExterns.gtk_snapshot_append_texture(snapshot, texture, bounds);
		return snapshot;
	}

	public static GskRenderNodeHandle FreeToNode(this GtkSnapshotHandle snapshot)
	{
		return GtkSnapshotExterns.gtk_snapshot_free_to_node(snapshot);
	}

	public static GdkPaintableHandle FreeToPaintable(this GtkSnapshotHandle snapshot, graphene_size_tHandle size)
	{
		return GtkSnapshotExterns.gtk_snapshot_free_to_paintable(snapshot, size);
	}

	public static GtkSnapshotHandle GlShaderPopTexture(this GtkSnapshotHandle snapshot)
	{
		GtkSnapshotExterns.gtk_snapshot_gl_shader_pop_texture(snapshot);
		return snapshot;
	}

	public static GtkSnapshotHandle Perspective(this GtkSnapshotHandle snapshot, float depth)
	{
		GtkSnapshotExterns.gtk_snapshot_perspective(snapshot, depth);
		return snapshot;
	}

	public static GtkSnapshotHandle Pop(this GtkSnapshotHandle snapshot)
	{
		GtkSnapshotExterns.gtk_snapshot_pop(snapshot);
		return snapshot;
	}

	public static GtkSnapshotHandle PushBlend(this GtkSnapshotHandle snapshot, GskBlendMode blend_mode)
	{
		GtkSnapshotExterns.gtk_snapshot_push_blend(snapshot, blend_mode);
		return snapshot;
	}

	public static GtkSnapshotHandle PushBlur(this GtkSnapshotHandle snapshot, double radius)
	{
		GtkSnapshotExterns.gtk_snapshot_push_blur(snapshot, radius);
		return snapshot;
	}

	public static GtkSnapshotHandle PushClip(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds)
	{
		GtkSnapshotExterns.gtk_snapshot_push_clip(snapshot, bounds);
		return snapshot;
	}

	public static GtkSnapshotHandle PushColorMatrix(this GtkSnapshotHandle snapshot, graphene_matrix_tHandle color_matrix, graphene_vec4_tHandle color_offset)
	{
		GtkSnapshotExterns.gtk_snapshot_push_color_matrix(snapshot, color_matrix, color_offset);
		return snapshot;
	}

	public static GtkSnapshotHandle PushCrossFade(this GtkSnapshotHandle snapshot, double progress)
	{
		GtkSnapshotExterns.gtk_snapshot_push_cross_fade(snapshot, progress);
		return snapshot;
	}

	public static GtkSnapshotHandle PushDebug(this GtkSnapshotHandle snapshot, string message, IntPtr @__arglist)
	{
		GtkSnapshotExterns.gtk_snapshot_push_debug(snapshot, message, @__arglist);
		return snapshot;
	}

	public static GtkSnapshotHandle PushFill(this GtkSnapshotHandle snapshot, GskPathHandle path, GskFillRule fill_rule)
	{
		GtkSnapshotExterns.gtk_snapshot_push_fill(snapshot, path, fill_rule);
		return snapshot;
	}

	public static GtkSnapshotHandle PushGlShader(this GtkSnapshotHandle snapshot, GskGLShaderHandle shader, graphene_rect_tHandle bounds, GBytesHandle take_args)
	{
		GtkSnapshotExterns.gtk_snapshot_push_gl_shader(snapshot, shader, bounds, take_args);
		return snapshot;
	}

	public static GtkSnapshotHandle PushMask(this GtkSnapshotHandle snapshot, GskMaskMode mask_mode)
	{
		GtkSnapshotExterns.gtk_snapshot_push_mask(snapshot, mask_mode);
		return snapshot;
	}

	public static GtkSnapshotHandle PushOpacity(this GtkSnapshotHandle snapshot, double opacity)
	{
		GtkSnapshotExterns.gtk_snapshot_push_opacity(snapshot, opacity);
		return snapshot;
	}

	public static GtkSnapshotHandle PushRepeat(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_rect_tHandle child_bounds)
	{
		GtkSnapshotExterns.gtk_snapshot_push_repeat(snapshot, bounds, child_bounds);
		return snapshot;
	}

	public static GtkSnapshotHandle PushRoundedClip(this GtkSnapshotHandle snapshot, GskRoundedRectHandle bounds)
	{
		GtkSnapshotExterns.gtk_snapshot_push_rounded_clip(snapshot, bounds);
		return snapshot;
	}

	public static GtkSnapshotHandle PushShadow(this GtkSnapshotHandle snapshot, GskShadow[] shadow, int n_shadows)
	{
		GtkSnapshotExterns.gtk_snapshot_push_shadow(snapshot, shadow, n_shadows);
		return snapshot;
	}

	public static GtkSnapshotHandle PushStroke(this GtkSnapshotHandle snapshot, GskPathHandle path, GskStrokeHandle stroke)
	{
		GtkSnapshotExterns.gtk_snapshot_push_stroke(snapshot, path, stroke);
		return snapshot;
	}

	public static GtkSnapshotHandle RenderBackground(this GtkSnapshotHandle snapshot, GtkStyleContextHandle context, double x, double y, double width, double height)
	{
		GtkSnapshotExterns.gtk_snapshot_render_background(snapshot, context, x, y, width, height);
		return snapshot;
	}

	public static GtkSnapshotHandle RenderFocus(this GtkSnapshotHandle snapshot, GtkStyleContextHandle context, double x, double y, double width, double height)
	{
		GtkSnapshotExterns.gtk_snapshot_render_focus(snapshot, context, x, y, width, height);
		return snapshot;
	}

	public static GtkSnapshotHandle RenderFrame(this GtkSnapshotHandle snapshot, GtkStyleContextHandle context, double x, double y, double width, double height)
	{
		GtkSnapshotExterns.gtk_snapshot_render_frame(snapshot, context, x, y, width, height);
		return snapshot;
	}

	public static GtkSnapshotHandle RenderInsertionCursor(this GtkSnapshotHandle snapshot, GtkStyleContextHandle context, double x, double y, PangoLayoutHandle layout, int index, PangoDirection direction)
	{
		GtkSnapshotExterns.gtk_snapshot_render_insertion_cursor(snapshot, context, x, y, layout, index, direction);
		return snapshot;
	}

	public static GtkSnapshotHandle RenderLayout(this GtkSnapshotHandle snapshot, GtkStyleContextHandle context, double x, double y, PangoLayoutHandle layout)
	{
		GtkSnapshotExterns.gtk_snapshot_render_layout(snapshot, context, x, y, layout);
		return snapshot;
	}

	public static GtkSnapshotHandle Restore(this GtkSnapshotHandle snapshot)
	{
		GtkSnapshotExterns.gtk_snapshot_restore(snapshot);
		return snapshot;
	}

	public static GtkSnapshotHandle Rotate(this GtkSnapshotHandle snapshot, float angle)
	{
		GtkSnapshotExterns.gtk_snapshot_rotate(snapshot, angle);
		return snapshot;
	}

	public static GtkSnapshotHandle Rotate3D(this GtkSnapshotHandle snapshot, float angle, graphene_vec3_tHandle axis)
	{
		GtkSnapshotExterns.gtk_snapshot_rotate_3d(snapshot, angle, axis);
		return snapshot;
	}

	public static GtkSnapshotHandle Save(this GtkSnapshotHandle snapshot)
	{
		GtkSnapshotExterns.gtk_snapshot_save(snapshot);
		return snapshot;
	}

	public static GtkSnapshotHandle Scale(this GtkSnapshotHandle snapshot, float factor_x, float factor_y)
	{
		GtkSnapshotExterns.gtk_snapshot_scale(snapshot, factor_x, factor_y);
		return snapshot;
	}

	public static GtkSnapshotHandle Scale3D(this GtkSnapshotHandle snapshot, float factor_x, float factor_y, float factor_z)
	{
		GtkSnapshotExterns.gtk_snapshot_scale_3d(snapshot, factor_x, factor_y, factor_z);
		return snapshot;
	}

	public static GskRenderNodeHandle ToNode(this GtkSnapshotHandle snapshot)
	{
		return GtkSnapshotExterns.gtk_snapshot_to_node(snapshot);
	}

	public static GdkPaintableHandle ToPaintable(this GtkSnapshotHandle snapshot, graphene_size_tHandle size)
	{
		return GtkSnapshotExterns.gtk_snapshot_to_paintable(snapshot, size);
	}

	public static GtkSnapshotHandle Transform(this GtkSnapshotHandle snapshot, GskTransformHandle transform)
	{
		GtkSnapshotExterns.gtk_snapshot_transform(snapshot, transform);
		return snapshot;
	}

	public static GtkSnapshotHandle TransformMatrix(this GtkSnapshotHandle snapshot, graphene_matrix_tHandle matrix)
	{
		GtkSnapshotExterns.gtk_snapshot_transform_matrix(snapshot, matrix);
		return snapshot;
	}

	public static GtkSnapshotHandle Translate(this GtkSnapshotHandle snapshot, graphene_point_tHandle point)
	{
		GtkSnapshotExterns.gtk_snapshot_translate(snapshot, point);
		return snapshot;
	}

	public static GtkSnapshotHandle Translate3D(this GtkSnapshotHandle snapshot, graphene_point3d_tHandle point)
	{
		GtkSnapshotExterns.gtk_snapshot_translate_3d(snapshot, point);
		return snapshot;
	}

}

internal class GtkSnapshotExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_append_border(GtkSnapshotHandle snapshot, GskRoundedRectHandle outline, float[] border_width, GdkRGBA[] border_color);
	[DllImport(Libraries.Gtk4)]
	internal static extern cairo_tHandle gtk_snapshot_append_cairo(GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_append_color(GtkSnapshotHandle snapshot, GdkRGBAHandle color, graphene_rect_tHandle bounds);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_append_conic_gradient(GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_point_tHandle center, float rotation, GskColorStop[] stops, int n_stops);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_append_fill(GtkSnapshotHandle snapshot, GskPathHandle path, GskFillRule fill_rule, GdkRGBAHandle color);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_append_inset_shadow(GtkSnapshotHandle snapshot, GskRoundedRectHandle outline, GdkRGBAHandle color, float dx, float dy, float spread, float blur_radius);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_append_layout(GtkSnapshotHandle snapshot, PangoLayoutHandle layout, GdkRGBAHandle color);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_append_linear_gradient(GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_point_tHandle start_point, graphene_point_tHandle end_point, GskColorStop[] stops, int n_stops);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_append_node(GtkSnapshotHandle snapshot, GskRenderNodeHandle node);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_append_outset_shadow(GtkSnapshotHandle snapshot, GskRoundedRectHandle outline, GdkRGBAHandle color, float dx, float dy, float spread, float blur_radius);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_append_radial_gradient(GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_point_tHandle center, float hradius, float vradius, float start, float end, GskColorStop[] stops, int n_stops);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_append_repeating_linear_gradient(GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_point_tHandle start_point, graphene_point_tHandle end_point, GskColorStop[] stops, int n_stops);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_append_repeating_radial_gradient(GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_point_tHandle center, float hradius, float vradius, float start, float end, GskColorStop[] stops, int n_stops);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_append_scaled_texture(GtkSnapshotHandle snapshot, GdkTextureHandle texture, GskScalingFilter filter, graphene_rect_tHandle bounds);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_append_stroke(GtkSnapshotHandle snapshot, GskPathHandle path, GskStrokeHandle stroke, GdkRGBAHandle color);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_append_texture(GtkSnapshotHandle snapshot, GdkTextureHandle texture, graphene_rect_tHandle bounds);
	[DllImport(Libraries.Gtk4)]
	internal static extern GskRenderNodeHandle gtk_snapshot_free_to_node(GtkSnapshotHandle snapshot);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkPaintableHandle gtk_snapshot_free_to_paintable(GtkSnapshotHandle snapshot, graphene_size_tHandle size);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_gl_shader_pop_texture(GtkSnapshotHandle snapshot);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_perspective(GtkSnapshotHandle snapshot, float depth);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_pop(GtkSnapshotHandle snapshot);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_push_blend(GtkSnapshotHandle snapshot, GskBlendMode blend_mode);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_push_blur(GtkSnapshotHandle snapshot, double radius);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_push_clip(GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_push_color_matrix(GtkSnapshotHandle snapshot, graphene_matrix_tHandle color_matrix, graphene_vec4_tHandle color_offset);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_push_cross_fade(GtkSnapshotHandle snapshot, double progress);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_push_debug(GtkSnapshotHandle snapshot, string message, IntPtr @__arglist);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_push_fill(GtkSnapshotHandle snapshot, GskPathHandle path, GskFillRule fill_rule);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_push_gl_shader(GtkSnapshotHandle snapshot, GskGLShaderHandle shader, graphene_rect_tHandle bounds, GBytesHandle take_args);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_push_mask(GtkSnapshotHandle snapshot, GskMaskMode mask_mode);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_push_opacity(GtkSnapshotHandle snapshot, double opacity);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_push_repeat(GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_rect_tHandle child_bounds);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_push_rounded_clip(GtkSnapshotHandle snapshot, GskRoundedRectHandle bounds);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_push_shadow(GtkSnapshotHandle snapshot, GskShadow[] shadow, int n_shadows);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_push_stroke(GtkSnapshotHandle snapshot, GskPathHandle path, GskStrokeHandle stroke);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_render_background(GtkSnapshotHandle snapshot, GtkStyleContextHandle context, double x, double y, double width, double height);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_render_focus(GtkSnapshotHandle snapshot, GtkStyleContextHandle context, double x, double y, double width, double height);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_render_frame(GtkSnapshotHandle snapshot, GtkStyleContextHandle context, double x, double y, double width, double height);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_render_insertion_cursor(GtkSnapshotHandle snapshot, GtkStyleContextHandle context, double x, double y, PangoLayoutHandle layout, int index, PangoDirection direction);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_render_layout(GtkSnapshotHandle snapshot, GtkStyleContextHandle context, double x, double y, PangoLayoutHandle layout);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_restore(GtkSnapshotHandle snapshot);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_rotate(GtkSnapshotHandle snapshot, float angle);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_rotate_3d(GtkSnapshotHandle snapshot, float angle, graphene_vec3_tHandle axis);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_save(GtkSnapshotHandle snapshot);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_scale(GtkSnapshotHandle snapshot, float factor_x, float factor_y);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_scale_3d(GtkSnapshotHandle snapshot, float factor_x, float factor_y, float factor_z);
	[DllImport(Libraries.Gtk4)]
	internal static extern GskRenderNodeHandle gtk_snapshot_to_node(GtkSnapshotHandle snapshot);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkPaintableHandle gtk_snapshot_to_paintable(GtkSnapshotHandle snapshot, graphene_size_tHandle size);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_transform(GtkSnapshotHandle snapshot, GskTransformHandle transform);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_transform_matrix(GtkSnapshotHandle snapshot, graphene_matrix_tHandle matrix);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_translate(GtkSnapshotHandle snapshot, graphene_point_tHandle point);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_snapshot_translate_3d(GtkSnapshotHandle snapshot, graphene_point3d_tHandle point);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSnapshotHandle gtk_snapshot_new();
}
