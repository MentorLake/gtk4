using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Gsk;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSnapshotAdaptors
{
	public static GskRenderNodeHandle FreeToNode(this GtkSnapshotHandle snapshot)
	{
		return GtkSnapshotExterns.gtk_snapshot_free_to_node(snapshot);
	}

	public static GdkPaintableHandle FreeToPaintable(this GtkSnapshotHandle snapshot, graphene_size_tHandle size)
	{
		return GtkSnapshotExterns.gtk_snapshot_free_to_paintable(snapshot, size);
	}

	public static GskRenderNodeHandle ToNode(this GtkSnapshotHandle snapshot)
	{
		return GtkSnapshotExterns.gtk_snapshot_to_node(snapshot);
	}

	public static GdkPaintableHandle ToPaintable(this GtkSnapshotHandle snapshot, graphene_size_tHandle size)
	{
		return GtkSnapshotExterns.gtk_snapshot_to_paintable(snapshot, size);
	}

	public static GtkSnapshotHandle PushDebug(this GtkSnapshotHandle snapshot, string message, IntPtr @__argList)
	{
		GtkSnapshotExterns.gtk_snapshot_push_debug(snapshot, message, @__argList);
		return snapshot;
	}

	public static GtkSnapshotHandle PushOpacity(this GtkSnapshotHandle snapshot, double opacity)
	{
		GtkSnapshotExterns.gtk_snapshot_push_opacity(snapshot, opacity);
		return snapshot;
	}

	public static GtkSnapshotHandle PushBlur(this GtkSnapshotHandle snapshot, double radius)
	{
		GtkSnapshotExterns.gtk_snapshot_push_blur(snapshot, radius);
		return snapshot;
	}

	public static GtkSnapshotHandle PushColorMatrix(this GtkSnapshotHandle snapshot, graphene_matrix_tHandle color_matrix, graphene_vec4_tHandle color_offset)
	{
		GtkSnapshotExterns.gtk_snapshot_push_color_matrix(snapshot, color_matrix, color_offset);
		return snapshot;
	}

	public static GtkSnapshotHandle PushRepeat(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_rect_tHandle child_bounds)
	{
		GtkSnapshotExterns.gtk_snapshot_push_repeat(snapshot, bounds, child_bounds);
		return snapshot;
	}

	public static GtkSnapshotHandle PushClip(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds)
	{
		GtkSnapshotExterns.gtk_snapshot_push_clip(snapshot, bounds);
		return snapshot;
	}

	public static GtkSnapshotHandle PushRoundedClip(this GtkSnapshotHandle snapshot, GskRoundedRectHandle bounds)
	{
		GtkSnapshotExterns.gtk_snapshot_push_rounded_clip(snapshot, bounds);
		return snapshot;
	}

	public static GtkSnapshotHandle PushShadow(this GtkSnapshotHandle snapshot, GskShadowHandle shadow, nuint n_shadows)
	{
		GtkSnapshotExterns.gtk_snapshot_push_shadow(snapshot, shadow, n_shadows);
		return snapshot;
	}

	public static GtkSnapshotHandle PushBlend(this GtkSnapshotHandle snapshot, GskBlendMode blend_mode)
	{
		GtkSnapshotExterns.gtk_snapshot_push_blend(snapshot, blend_mode);
		return snapshot;
	}

	public static GtkSnapshotHandle PushCrossFade(this GtkSnapshotHandle snapshot, double progress)
	{
		GtkSnapshotExterns.gtk_snapshot_push_cross_fade(snapshot, progress);
		return snapshot;
	}

	public static GtkSnapshotHandle PushGlShader(this GtkSnapshotHandle snapshot, GskGLShaderHandle shader, graphene_rect_tHandle bounds, GBytesHandle take_args)
	{
		GtkSnapshotExterns.gtk_snapshot_push_gl_shader(snapshot, shader, bounds, take_args);
		return snapshot;
	}

	public static GtkSnapshotHandle GlShaderPopTexture(this GtkSnapshotHandle snapshot)
	{
		GtkSnapshotExterns.gtk_snapshot_gl_shader_pop_texture(snapshot);
		return snapshot;
	}

	public static GtkSnapshotHandle Pop(this GtkSnapshotHandle snapshot)
	{
		GtkSnapshotExterns.gtk_snapshot_pop(snapshot);
		return snapshot;
	}

	public static GtkSnapshotHandle Save(this GtkSnapshotHandle snapshot)
	{
		GtkSnapshotExterns.gtk_snapshot_save(snapshot);
		return snapshot;
	}

	public static GtkSnapshotHandle Restore(this GtkSnapshotHandle snapshot)
	{
		GtkSnapshotExterns.gtk_snapshot_restore(snapshot);
		return snapshot;
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

	public static GtkSnapshotHandle Perspective(this GtkSnapshotHandle snapshot, float depth)
	{
		GtkSnapshotExterns.gtk_snapshot_perspective(snapshot, depth);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendNode(this GtkSnapshotHandle snapshot, GskRenderNodeHandle node)
	{
		GtkSnapshotExterns.gtk_snapshot_append_node(snapshot, node);
		return snapshot;
	}

	public static cairoHandle AppendCairo(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds)
	{
		return GtkSnapshotExterns.gtk_snapshot_append_cairo(snapshot, bounds);
	}

	public static GtkSnapshotHandle AppendTexture(this GtkSnapshotHandle snapshot, GdkTextureHandle texture, graphene_rect_tHandle bounds)
	{
		GtkSnapshotExterns.gtk_snapshot_append_texture(snapshot, texture, bounds);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendColor(this GtkSnapshotHandle snapshot, GdkRGBAHandle color, graphene_rect_tHandle bounds)
	{
		GtkSnapshotExterns.gtk_snapshot_append_color(snapshot, color, bounds);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendLinearGradient(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_point_tHandle start_point, graphene_point_tHandle end_point, GskColorStopHandle stops, nuint n_stops)
	{
		GtkSnapshotExterns.gtk_snapshot_append_linear_gradient(snapshot, bounds, start_point, end_point, stops, n_stops);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendRepeatingLinearGradient(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_point_tHandle start_point, graphene_point_tHandle end_point, GskColorStopHandle stops, nuint n_stops)
	{
		GtkSnapshotExterns.gtk_snapshot_append_repeating_linear_gradient(snapshot, bounds, start_point, end_point, stops, n_stops);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendRadialGradient(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_point_tHandle center, float hradius, float vradius, float start, float end, GskColorStopHandle stops, nuint n_stops)
	{
		GtkSnapshotExterns.gtk_snapshot_append_radial_gradient(snapshot, bounds, center, hradius, vradius, start, end, stops, n_stops);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendRepeatingRadialGradient(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_point_tHandle center, float hradius, float vradius, float start, float end, GskColorStopHandle stops, nuint n_stops)
	{
		GtkSnapshotExterns.gtk_snapshot_append_repeating_radial_gradient(snapshot, bounds, center, hradius, vradius, start, end, stops, n_stops);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendConicGradient(this GtkSnapshotHandle snapshot, graphene_rect_tHandle bounds, graphene_point_tHandle center, float rotation, GskColorStopHandle stops, nuint n_stops)
	{
		GtkSnapshotExterns.gtk_snapshot_append_conic_gradient(snapshot, bounds, center, rotation, stops, n_stops);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendBorder(this GtkSnapshotHandle snapshot, GskRoundedRectHandle outline, float[] border_width, GdkRGBA[] border_color)
	{
		GtkSnapshotExterns.gtk_snapshot_append_border(snapshot, outline, border_width, border_color);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendInsetShadow(this GtkSnapshotHandle snapshot, GskRoundedRectHandle outline, GdkRGBAHandle color, float dx, float dy, float spread, float blur_radius)
	{
		GtkSnapshotExterns.gtk_snapshot_append_inset_shadow(snapshot, outline, color, dx, dy, spread, blur_radius);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendOutsetShadow(this GtkSnapshotHandle snapshot, GskRoundedRectHandle outline, GdkRGBAHandle color, float dx, float dy, float spread, float blur_radius)
	{
		GtkSnapshotExterns.gtk_snapshot_append_outset_shadow(snapshot, outline, color, dx, dy, spread, blur_radius);
		return snapshot;
	}

	public static GtkSnapshotHandle AppendLayout(this GtkSnapshotHandle snapshot, PangoLayoutHandle layout, GdkRGBAHandle color)
	{
		GtkSnapshotExterns.gtk_snapshot_append_layout(snapshot, layout, color);
		return snapshot;
	}

	public static GtkSnapshotHandle RenderBackground(this GtkSnapshotHandle snapshot, GtkStyleContextHandle context, double x, double y, double width, double height)
	{
		GtkSnapshotExterns.gtk_snapshot_render_background(snapshot, context, x, y, width, height);
		return snapshot;
	}

	public static GtkSnapshotHandle RenderFrame(this GtkSnapshotHandle snapshot, GtkStyleContextHandle context, double x, double y, double width, double height)
	{
		GtkSnapshotExterns.gtk_snapshot_render_frame(snapshot, context, x, y, width, height);
		return snapshot;
	}

	public static GtkSnapshotHandle RenderFocus(this GtkSnapshotHandle snapshot, GtkStyleContextHandle context, double x, double y, double width, double height)
	{
		GtkSnapshotExterns.gtk_snapshot_render_focus(snapshot, context, x, y, width, height);
		return snapshot;
	}

	public static GtkSnapshotHandle RenderLayout(this GtkSnapshotHandle snapshot, GtkStyleContextHandle context, double x, double y, PangoLayoutHandle layout)
	{
		GtkSnapshotExterns.gtk_snapshot_render_layout(snapshot, context, x, y, layout);
		return snapshot;
	}

	public static GtkSnapshotHandle RenderInsertionCursor(this GtkSnapshotHandle snapshot, GtkStyleContextHandle context, double x, double y, PangoLayoutHandle layout, int index, PangoDirection direction)
	{
		GtkSnapshotExterns.gtk_snapshot_render_insertion_cursor(snapshot, context, x, y, layout, index, direction);
		return snapshot;
	}
}
