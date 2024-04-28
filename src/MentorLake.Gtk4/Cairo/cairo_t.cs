using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public class cairo_tHandle : BaseSafeHandle { }
public struct cairo_t { }

public static class cairoAdaptors
{
	public static cairo_tHandle CairoReference(this cairo_tHandle cr)
	{
		return cairoExterns.cairo_reference(cr);
	}

	public static cairo_tHandle CairoDestroy(this cairo_tHandle cr)
	{
		cairoExterns.cairo_destroy(cr);
		return cr;
	}

	public static uint CairoGetReferenceCount(this cairo_tHandle cr)
	{
		return cairoExterns.cairo_get_reference_count(cr);
	}

	public static IntPtr CairoGetUserData(this cairo_tHandle cr, cairo_user_data_key_tHandle keyT)
	{
		return cairoExterns.cairo_get_user_data(cr, keyT);
	}

	public static cairo_status_t CairoSetUserData(this cairo_tHandle cr, cairo_user_data_key_tHandle keyT, IntPtr user_data, cairo_destroy_func_t destroy)
	{
		return cairoExterns.cairo_set_user_data(cr, keyT, user_data, destroy);
	}

	public static cairo_tHandle CairoSave(this cairo_tHandle cr)
	{
		cairoExterns.cairo_save(cr);
		return cr;
	}

	public static cairo_tHandle CairoRestore(this cairo_tHandle cr)
	{
		cairoExterns.cairo_restore(cr);
		return cr;
	}

	public static cairo_tHandle CairoPushGroup(this cairo_tHandle cr)
	{
		cairoExterns.cairo_push_group(cr);
		return cr;
	}

	public static cairo_tHandle CairoPushGroupWithContent(this cairo_tHandle cr, cairo_content_t contentT)
	{
		cairoExterns.cairo_push_group_with_content(cr, contentT);
		return cr;
	}

	public static cairo_pattern_tHandle CairoPopGroup(this cairo_tHandle cr)
	{
		return cairoExterns.cairo_pop_group(cr);
	}

	public static cairo_tHandle CairoPopGroupToSource(this cairo_tHandle cr)
	{
		cairoExterns.cairo_pop_group_to_source(cr);
		return cr;
	}

	public static cairo_tHandle CairoSetOperator(this cairo_tHandle cr, cairo_operator_t op)
	{
		cairoExterns.cairo_set_operator(cr, op);
		return cr;
	}

	public static cairo_tHandle CairoSetSource(this cairo_tHandle cr, cairo_pattern_tHandle source)
	{
		cairoExterns.cairo_set_source(cr, source);
		return cr;
	}

	public static cairo_tHandle CairoSetSourceRgb(this cairo_tHandle cr, double red, double green, double blue)
	{
		cairoExterns.cairo_set_source_rgb(cr, red, green, blue);
		return cr;
	}

	public static cairo_tHandle CairoSetSourceRgba(this cairo_tHandle cr, double red, double green, double blue, double alpha)
	{
		cairoExterns.cairo_set_source_rgba(cr, red, green, blue, alpha);
		return cr;
	}

	public static cairo_tHandle CairoSetSourceSurface(this cairo_tHandle cr, cairo_surface_tHandle surfaceT, double x, double y)
	{
		cairoExterns.cairo_set_source_surface(cr, surfaceT, x, y);
		return cr;
	}

	public static cairo_tHandle CairoSetTolerance(this cairo_tHandle cr, double tolerance)
	{
		cairoExterns.cairo_set_tolerance(cr, tolerance);
		return cr;
	}

	public static cairo_tHandle CairoSetAntialias(this cairo_tHandle cr, cairo_antialias_t antialias)
	{
		cairoExterns.cairo_set_antialias(cr, antialias);
		return cr;
	}

	public static cairo_tHandle CairoSetFillRule(this cairo_tHandle cr, cairo_fill_rule_t fill_rule)
	{
		cairoExterns.cairo_set_fill_rule(cr, fill_rule);
		return cr;
	}

	public static cairo_tHandle CairoSetLineWidth(this cairo_tHandle cr, double width)
	{
		cairoExterns.cairo_set_line_width(cr, width);
		return cr;
	}

	public static cairo_tHandle CairoSetLineCap(this cairo_tHandle cr, cairo_line_cap_t line_cap)
	{
		cairoExterns.cairo_set_line_cap(cr, line_cap);
		return cr;
	}

	public static cairo_tHandle CairoSetLineJoin(this cairo_tHandle cr, cairo_line_join_t line_join)
	{
		cairoExterns.cairo_set_line_join(cr, line_join);
		return cr;
	}

	public static cairo_tHandle CairoSetDash(this cairo_tHandle cr, double[] dashes, int num_dashes, double offset)
	{
		cairoExterns.cairo_set_dash(cr, dashes, num_dashes, offset);
		return cr;
	}

	public static cairo_tHandle CairoSetMiterLimit(this cairo_tHandle cr, double limit)
	{
		cairoExterns.cairo_set_miter_limit(cr, limit);
		return cr;
	}

	public static cairo_tHandle CairoTranslate(this cairo_tHandle cr, double tx, double ty)
	{
		cairoExterns.cairo_translate(cr, tx, ty);
		return cr;
	}

	public static cairo_tHandle CairoScale(this cairo_tHandle cr, double sx, double sy)
	{
		cairoExterns.cairo_scale(cr, sx, sy);
		return cr;
	}

	public static cairo_tHandle CairoRotate(this cairo_tHandle cr, double angle)
	{
		cairoExterns.cairo_rotate(cr, angle);
		return cr;
	}

	public static cairo_tHandle CairoTransform(this cairo_tHandle cr, cairo_matrix_tHandle matrixT)
	{
		cairoExterns.cairo_transform(cr, matrixT);
		return cr;
	}

	public static cairo_tHandle CairoSetMatrix(this cairo_tHandle cr, cairo_matrix_tHandle matrixT)
	{
		cairoExterns.cairo_set_matrix(cr, matrixT);
		return cr;
	}

	public static cairo_tHandle CairoIdentityMatrix(this cairo_tHandle cr)
	{
		cairoExterns.cairo_identity_matrix(cr);
		return cr;
	}

	public static cairo_tHandle CairoUserToDevice(this cairo_tHandle cr, ref double x, ref double y)
	{
		cairoExterns.cairo_user_to_device(cr, ref x, ref y);
		return cr;
	}

	public static cairo_tHandle CairoUserToDeviceDistance(this cairo_tHandle cr, ref double dx, ref double dy)
	{
		cairoExterns.cairo_user_to_device_distance(cr, ref dx, ref dy);
		return cr;
	}

	public static cairo_tHandle CairoDeviceToUser(this cairo_tHandle cr, ref double x, ref double y)
	{
		cairoExterns.cairo_device_to_user(cr, ref x, ref y);
		return cr;
	}

	public static cairo_tHandle CairoDeviceToUserDistance(this cairo_tHandle cr, ref double dx, ref double dy)
	{
		cairoExterns.cairo_device_to_user_distance(cr, ref dx, ref dy);
		return cr;
	}

	public static cairo_tHandle CairoNewPath(this cairo_tHandle cr)
	{
		cairoExterns.cairo_new_path(cr);
		return cr;
	}

	public static cairo_tHandle CairoMoveTo(this cairo_tHandle cr, double x, double y)
	{
		cairoExterns.cairo_move_to(cr, x, y);
		return cr;
	}

	public static cairo_tHandle CairoNewSubPath(this cairo_tHandle cr)
	{
		cairoExterns.cairo_new_sub_path(cr);
		return cr;
	}

	public static cairo_tHandle CairoLineTo(this cairo_tHandle cr, double x, double y)
	{
		cairoExterns.cairo_line_to(cr, x, y);
		return cr;
	}

	public static cairo_tHandle CairoCurveTo(this cairo_tHandle cr, double x1, double y1, double x2, double y2, double x3, double y3)
	{
		cairoExterns.cairo_curve_to(cr, x1, y1, x2, y2, x3, y3);
		return cr;
	}

	public static cairo_tHandle CairoArc(this cairo_tHandle cr, double xc, double yc, double radius, double angle1, double angle2)
	{
		cairoExterns.cairo_arc(cr, xc, yc, radius, angle1, angle2);
		return cr;
	}

	public static cairo_tHandle CairoArcNegative(this cairo_tHandle cr, double xc, double yc, double radius, double angle1, double angle2)
	{
		cairoExterns.cairo_arc_negative(cr, xc, yc, radius, angle1, angle2);
		return cr;
	}

	public static cairo_tHandle CairoRelMoveTo(this cairo_tHandle cr, double dx, double dy)
	{
		cairoExterns.cairo_rel_move_to(cr, dx, dy);
		return cr;
	}

	public static cairo_tHandle CairoRelLineTo(this cairo_tHandle cr, double dx, double dy)
	{
		cairoExterns.cairo_rel_line_to(cr, dx, dy);
		return cr;
	}

	public static cairo_tHandle CairoRelCurveTo(this cairo_tHandle cr, double dx1, double dy1, double dx2, double dy2, double dx3, double dy3)
	{
		cairoExterns.cairo_rel_curve_to(cr, dx1, dy1, dx2, dy2, dx3, dy3);
		return cr;
	}

	public static cairo_tHandle CairoRectangle(this cairo_tHandle cr, double x, double y, double width, double height)
	{
		cairoExterns.cairo_rectangle(cr, x, y, width, height);
		return cr;
	}

	public static cairo_tHandle CairoClosePath(this cairo_tHandle cr)
	{
		cairoExterns.cairo_close_path(cr);
		return cr;
	}

	public static cairo_tHandle CairoPathExtents(this cairo_tHandle cr, out double x1, out double y1, out double x2, out double y2)
	{
		cairoExterns.cairo_path_extents(cr, out x1, out y1, out x2, out y2);
		return cr;
	}

	public static cairo_tHandle CairoPaint(this cairo_tHandle cr)
	{
		cairoExterns.cairo_paint(cr);
		return cr;
	}

	public static cairo_tHandle CairoPaintWithAlpha(this cairo_tHandle cr, double alpha)
	{
		cairoExterns.cairo_paint_with_alpha(cr, alpha);
		return cr;
	}

	public static cairo_tHandle CairoMask(this cairo_tHandle cr, cairo_pattern_tHandle patternT)
	{
		cairoExterns.cairo_mask(cr, patternT);
		return cr;
	}

	public static cairo_tHandle CairoMaskSurface(this cairo_tHandle cr, cairo_surface_tHandle surfaceT, double surface_x, double surface_y)
	{
		cairoExterns.cairo_mask_surface(cr, surfaceT, surface_x, surface_y);
		return cr;
	}

	public static cairo_tHandle CairoStroke(this cairo_tHandle cr)
	{
		cairoExterns.cairo_stroke(cr);
		return cr;
	}

	public static cairo_tHandle CairoStrokePreserve(this cairo_tHandle cr)
	{
		cairoExterns.cairo_stroke_preserve(cr);
		return cr;
	}

	public static cairo_tHandle CairoFill(this cairo_tHandle cr)
	{
		cairoExterns.cairo_fill(cr);
		return cr;
	}

	public static cairo_tHandle CairoFillPreserve(this cairo_tHandle cr)
	{
		cairoExterns.cairo_fill_preserve(cr);
		return cr;
	}

	public static cairo_tHandle CairoCopyPage(this cairo_tHandle cr)
	{
		cairoExterns.cairo_copy_page(cr);
		return cr;
	}

	public static cairo_tHandle CairoShowPage(this cairo_tHandle cr)
	{
		cairoExterns.cairo_show_page(cr);
		return cr;
	}

	public static int CairoInStroke(this cairo_tHandle cr, double x, double y)
	{
		return cairoExterns.cairo_in_stroke(cr, x, y);
	}

	public static int CairoInFill(this cairo_tHandle cr, double x, double y)
	{
		return cairoExterns.cairo_in_fill(cr, x, y);
	}

	public static int CairoInClip(this cairo_tHandle cr, double x, double y)
	{
		return cairoExterns.cairo_in_clip(cr, x, y);
	}

	public static cairo_tHandle CairoStrokeExtents(this cairo_tHandle cr, out double x1, out double y1, out double x2, out double y2)
	{
		cairoExterns.cairo_stroke_extents(cr, out x1, out y1, out x2, out y2);
		return cr;
	}

	public static cairo_tHandle CairoFillExtents(this cairo_tHandle cr, out double x1, out double y1, out double x2, out double y2)
	{
		cairoExterns.cairo_fill_extents(cr, out x1, out y1, out x2, out y2);
		return cr;
	}

	public static cairo_tHandle CairoResetClip(this cairo_tHandle cr)
	{
		cairoExterns.cairo_reset_clip(cr);
		return cr;
	}

	public static cairo_tHandle CairoClip(this cairo_tHandle cr)
	{
		cairoExterns.cairo_clip(cr);
		return cr;
	}

	public static cairo_tHandle CairoClipPreserve(this cairo_tHandle cr)
	{
		cairoExterns.cairo_clip_preserve(cr);
		return cr;
	}

	public static cairo_tHandle CairoClipExtents(this cairo_tHandle cr, out double x1, out double y1, out double x2, out double y2)
	{
		cairoExterns.cairo_clip_extents(cr, out x1, out y1, out x2, out y2);
		return cr;
	}

	public static cairo_rectangle_list_tHandle CairoCopyClipRectangleList(this cairo_tHandle cr)
	{
		return cairoExterns.cairo_copy_clip_rectangle_list(cr);
	}

	public static cairo_tHandle CairoTagBegin(this cairo_tHandle cr, string tag_name, string attributes)
	{
		cairoExterns.cairo_tag_begin(cr, tag_name, attributes);
		return cr;
	}

	public static cairo_tHandle CairoTagEnd(this cairo_tHandle cr, string tag_name)
	{
		cairoExterns.cairo_tag_end(cr, tag_name);
		return cr;
	}

	public static cairo_tHandle CairoSelectFontFace(this cairo_tHandle cr, string family, cairo_font_slant_t slant, cairo_font_weight_t weight)
	{
		cairoExterns.cairo_select_font_face(cr, family, slant, weight);
		return cr;
	}

	public static cairo_tHandle CairoSetFontSize(this cairo_tHandle cr, double size)
	{
		cairoExterns.cairo_set_font_size(cr, size);
		return cr;
	}

	public static cairo_tHandle CairoSetFontMatrix(this cairo_tHandle cr, cairo_matrix_tHandle matrixT)
	{
		cairoExterns.cairo_set_font_matrix(cr, matrixT);
		return cr;
	}

	public static cairo_tHandle CairoGetFontMatrix(this cairo_tHandle cr, cairo_matrix_tHandle matrixT)
	{
		cairoExterns.cairo_get_font_matrix(cr, matrixT);
		return cr;
	}

	public static cairo_tHandle CairoSetFontOptions(this cairo_tHandle cr, cairo_font_options_tHandle optionsT)
	{
		cairoExterns.cairo_set_font_options(cr, optionsT);
		return cr;
	}

	public static cairo_tHandle CairoGetFontOptions(this cairo_tHandle cr, cairo_font_options_tHandle optionsT)
	{
		cairoExterns.cairo_get_font_options(cr, optionsT);
		return cr;
	}

	public static cairo_tHandle CairoSetFontFace(this cairo_tHandle cr, cairo_font_face_tHandle fontFaceT)
	{
		cairoExterns.cairo_set_font_face(cr, fontFaceT);
		return cr;
	}

	public static cairo_font_face_tHandle CairoGetFontFace(this cairo_tHandle cr)
	{
		return cairoExterns.cairo_get_font_face(cr);
	}

	public static cairo_tHandle CairoSetScaledFont(this cairo_tHandle cr, cairo_scaled_font_tHandle scaledFontT)
	{
		cairoExterns.cairo_set_scaled_font(cr, scaledFontT);
		return cr;
	}

	public static cairo_scaled_font_tHandle CairoGetScaledFont(this cairo_tHandle cr)
	{
		return cairoExterns.cairo_get_scaled_font(cr);
	}

	public static cairo_tHandle CairoShowText(this cairo_tHandle cr, string utf8)
	{
		cairoExterns.cairo_show_text(cr, utf8);
		return cr;
	}

	public static cairo_tHandle CairoShowGlyphs(this cairo_tHandle cr, cairo_glyph_tHandle glyphs, int num_glyphs)
	{
		cairoExterns.cairo_show_glyphs(cr, glyphs, num_glyphs);
		return cr;
	}

	public static cairo_tHandle CairoShowTextGlyphs(this cairo_tHandle cr, string utf8, int utf8_len, cairo_glyph_tHandle glyphs, int num_glyphs, cairo_text_cluster_tHandle clusters, int num_clusters, cairo_text_cluster_flags_t cluster_flags)
	{
		cairoExterns.cairo_show_text_glyphs(cr, utf8, utf8_len, glyphs, num_glyphs, clusters, num_clusters, cluster_flags);
		return cr;
	}

	public static cairo_tHandle CairoTextPath(this cairo_tHandle cr, string utf8)
	{
		cairoExterns.cairo_text_path(cr, utf8);
		return cr;
	}

	public static cairo_tHandle CairoGlyphPath(this cairo_tHandle cr, cairo_glyph_tHandle glyphs, int num_glyphs)
	{
		cairoExterns.cairo_glyph_path(cr, glyphs, num_glyphs);
		return cr;
	}

	public static cairo_tHandle CairoTextExtents(this cairo_tHandle cr, string utf8, cairo_text_extents_tHandle extents)
	{
		cairoExterns.cairo_text_extents(cr, utf8, extents);
		return cr;
	}

	public static cairo_tHandle CairoGlyphExtents(this cairo_tHandle cr, cairo_glyph_tHandle glyphs, int num_glyphs, cairo_text_extents_tHandle extents)
	{
		cairoExterns.cairo_glyph_extents(cr, glyphs, num_glyphs, extents);
		return cr;
	}

	public static cairo_tHandle CairoFontExtents(this cairo_tHandle cr, cairo_font_extents_tHandle extents)
	{
		cairoExterns.cairo_font_extents(cr, extents);
		return cr;
	}

	public static cairo_operator_t CairoGetOperator(this cairo_tHandle cr)
	{
		return cairoExterns.cairo_get_operator(cr);
	}

	public static cairo_pattern_tHandle CairoGetSource(this cairo_tHandle cr)
	{
		return cairoExterns.cairo_get_source(cr);
	}

	public static double CairoGetTolerance(this cairo_tHandle cr)
	{
		return cairoExterns.cairo_get_tolerance(cr);
	}

	public static cairo_antialias_t CairoGetAntialias(this cairo_tHandle cr)
	{
		return cairoExterns.cairo_get_antialias(cr);
	}

	public static int CairoHasCurrentPoint(this cairo_tHandle cr)
	{
		return cairoExterns.cairo_has_current_point(cr);
	}

	public static cairo_tHandle CairoGetCurrentPoint(this cairo_tHandle cr, out double x, out double y)
	{
		cairoExterns.cairo_get_current_point(cr, out x, out y);
		return cr;
	}

	public static cairo_fill_rule_t CairoGetFillRule(this cairo_tHandle cr)
	{
		return cairoExterns.cairo_get_fill_rule(cr);
	}

	public static double CairoGetLineWidth(this cairo_tHandle cr)
	{
		return cairoExterns.cairo_get_line_width(cr);
	}

	public static cairo_line_cap_t CairoGetLineCap(this cairo_tHandle cr)
	{
		return cairoExterns.cairo_get_line_cap(cr);
	}

	public static cairo_line_join_t CairoGetLineJoin(this cairo_tHandle cr)
	{
		return cairoExterns.cairo_get_line_join(cr);
	}

	public static double CairoGetMiterLimit(this cairo_tHandle cr)
	{
		return cairoExterns.cairo_get_miter_limit(cr);
	}

	public static int CairoGetDashCount(this cairo_tHandle cr)
	{
		return cairoExterns.cairo_get_dash_count(cr);
	}

	public static cairo_tHandle CairoGetDash(this cairo_tHandle cr, out double dashes, out double offset)
	{
		cairoExterns.cairo_get_dash(cr, out dashes, out offset);
		return cr;
	}

	public static cairo_tHandle CairoGetMatrix(this cairo_tHandle cr, cairo_matrix_tHandle matrixT)
	{
		cairoExterns.cairo_get_matrix(cr, matrixT);
		return cr;
	}

	public static cairo_surface_tHandle CairoGetTarget(this cairo_tHandle cr)
	{
		return cairoExterns.cairo_get_target(cr);
	}

	public static cairo_surface_tHandle CairoGetGroupTarget(this cairo_tHandle cr)
	{
		return cairoExterns.cairo_get_group_target(cr);
	}

	public static cairo_path_tHandle CairoCopyPath(this cairo_tHandle cr)
	{
		return cairoExterns.cairo_copy_path(cr);
	}

	public static cairo_path_tHandle CairoCopyPathFlat(this cairo_tHandle cr)
	{
		return cairoExterns.cairo_copy_path_flat(cr);
	}

	public static cairo_tHandle CairoAppendPath(this cairo_tHandle cr, cairo_path_tHandle pathT)
	{
		cairoExterns.cairo_append_path(cr, pathT);
		return cr;
	}

	public static cairo_status_t CairoStatus(this cairo_tHandle cr)
	{
		return cairoExterns.cairo_status(cr);
	}
}

public static class cairoExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_reference")]
	internal static extern cairo_tHandle cairo_reference(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_destroy")]
	internal static extern void cairo_destroy(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_reference_count")]
	internal static extern uint cairo_get_reference_count(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_user_data")]
	internal static extern IntPtr cairo_get_user_data(this cairo_tHandle cr, cairo_user_data_key_tHandle keyT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_user_data")]
	internal static extern cairo_status_t cairo_set_user_data(this cairo_tHandle cr, cairo_user_data_key_tHandle keyT, IntPtr user_data, cairo_destroy_func_t destroy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_save")]
	internal static extern void cairo_save(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_restore")]
	internal static extern void cairo_restore(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_push_group")]
	internal static extern void cairo_push_group(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_push_group_with_content")]
	internal static extern void cairo_push_group_with_content(this cairo_tHandle cr, cairo_content_t contentT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pop_group")]
	internal static extern cairo_pattern_tHandle cairo_pop_group(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pop_group_to_source")]
	internal static extern void cairo_pop_group_to_source(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_operator")]
	internal static extern void cairo_set_operator(this cairo_tHandle cr, cairo_operator_t op);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_source")]
	internal static extern void cairo_set_source(this cairo_tHandle cr, cairo_pattern_tHandle source);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_source_rgb")]
	internal static extern void cairo_set_source_rgb(this cairo_tHandle cr, double red, double green, double blue);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_source_rgba")]
	internal static extern void cairo_set_source_rgba(this cairo_tHandle cr, double red, double green, double blue, double alpha);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_source_surface")]
	internal static extern void cairo_set_source_surface(this cairo_tHandle cr, cairo_surface_tHandle surfaceT, double x, double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_tolerance")]
	internal static extern void cairo_set_tolerance(this cairo_tHandle cr, double tolerance);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_antialias")]
	internal static extern void cairo_set_antialias(this cairo_tHandle cr, cairo_antialias_t antialias);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_fill_rule")]
	internal static extern void cairo_set_fill_rule(this cairo_tHandle cr, cairo_fill_rule_t fill_rule);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_line_width")]
	internal static extern void cairo_set_line_width(this cairo_tHandle cr, double width);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_line_cap")]
	internal static extern void cairo_set_line_cap(this cairo_tHandle cr, cairo_line_cap_t line_cap);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_line_join")]
	internal static extern void cairo_set_line_join(this cairo_tHandle cr, cairo_line_join_t line_join);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_dash")]
	internal static extern void cairo_set_dash(this cairo_tHandle cr, double[] dashes, int num_dashes, double offset);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_miter_limit")]
	internal static extern void cairo_set_miter_limit(this cairo_tHandle cr, double limit);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_translate")]
	internal static extern void cairo_translate(this cairo_tHandle cr, double tx, double ty);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scale")]
	internal static extern void cairo_scale(this cairo_tHandle cr, double sx, double sy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_rotate")]
	internal static extern void cairo_rotate(this cairo_tHandle cr, double angle);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_transform")]
	internal static extern void cairo_transform(this cairo_tHandle cr, cairo_matrix_tHandle matrixT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_matrix")]
	internal static extern void cairo_set_matrix(this cairo_tHandle cr, cairo_matrix_tHandle matrixT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_identity_matrix")]
	internal static extern void cairo_identity_matrix(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_user_to_device")]
	internal static extern void cairo_user_to_device(this cairo_tHandle cr, ref double x, ref double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_user_to_device_distance")]
	internal static extern void cairo_user_to_device_distance(this cairo_tHandle cr, ref double dx, ref double dy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_to_user")]
	internal static extern void cairo_device_to_user(this cairo_tHandle cr, ref double x, ref double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_to_user_distance")]
	internal static extern void cairo_device_to_user_distance(this cairo_tHandle cr, ref double dx, ref double dy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_new_path")]
	internal static extern void cairo_new_path(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_move_to")]
	internal static extern void cairo_move_to(this cairo_tHandle cr, double x, double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_new_sub_path")]
	internal static extern void cairo_new_sub_path(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_line_to")]
	internal static extern void cairo_line_to(this cairo_tHandle cr, double x, double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_curve_to")]
	internal static extern void cairo_curve_to(this cairo_tHandle cr, double x1, double y1, double x2, double y2, double x3, double y3);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_arc")]
	internal static extern void cairo_arc(this cairo_tHandle cr, double xc, double yc, double radius, double angle1, double angle2);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_arc_negative")]
	internal static extern void cairo_arc_negative(this cairo_tHandle cr, double xc, double yc, double radius, double angle1, double angle2);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_rel_move_to")]
	internal static extern void cairo_rel_move_to(this cairo_tHandle cr, double dx, double dy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_rel_line_to")]
	internal static extern void cairo_rel_line_to(this cairo_tHandle cr, double dx, double dy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_rel_curve_to")]
	internal static extern void cairo_rel_curve_to(this cairo_tHandle cr, double dx1, double dy1, double dx2, double dy2, double dx3, double dy3);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_rectangle")]
	internal static extern void cairo_rectangle(this cairo_tHandle cr, double x, double y, double width, double height);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_close_path")]
	internal static extern void cairo_close_path(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_path_extents")]
	internal static extern void cairo_path_extents(this cairo_tHandle cr, out double x1, out double y1, out double x2, out double y2);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_paint")]
	internal static extern void cairo_paint(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_paint_with_alpha")]
	internal static extern void cairo_paint_with_alpha(this cairo_tHandle cr, double alpha);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mask")]
	internal static extern void cairo_mask(this cairo_tHandle cr, cairo_pattern_tHandle patternT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mask_surface")]
	internal static extern void cairo_mask_surface(this cairo_tHandle cr, cairo_surface_tHandle surfaceT, double surface_x, double surface_y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_stroke")]
	internal static extern void cairo_stroke(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_stroke_preserve")]
	internal static extern void cairo_stroke_preserve(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_fill")]
	internal static extern void cairo_fill(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_fill_preserve")]
	internal static extern void cairo_fill_preserve(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_copy_page")]
	internal static extern void cairo_copy_page(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_show_page")]
	internal static extern void cairo_show_page(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_in_stroke")]
	internal static extern int cairo_in_stroke(this cairo_tHandle cr, double x, double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_in_fill")]
	internal static extern int cairo_in_fill(this cairo_tHandle cr, double x, double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_in_clip")]
	internal static extern int cairo_in_clip(this cairo_tHandle cr, double x, double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_stroke_extents")]
	internal static extern void cairo_stroke_extents(this cairo_tHandle cr, out double x1, out double y1, out double x2, out double y2);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_fill_extents")]
	internal static extern void cairo_fill_extents(this cairo_tHandle cr, out double x1, out double y1, out double x2, out double y2);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_reset_clip")]
	internal static extern void cairo_reset_clip(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_clip")]
	internal static extern void cairo_clip(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_clip_preserve")]
	internal static extern void cairo_clip_preserve(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_clip_extents")]
	internal static extern void cairo_clip_extents(this cairo_tHandle cr, out double x1, out double y1, out double x2, out double y2);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_copy_clip_rectangle_list")]
	internal static extern cairo_rectangle_list_tHandle cairo_copy_clip_rectangle_list(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_tag_begin")]
	internal static extern void cairo_tag_begin(this cairo_tHandle cr, string tag_name, string attributes);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_tag_end")]
	internal static extern void cairo_tag_end(this cairo_tHandle cr, string tag_name);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_select_font_face")]
	internal static extern void cairo_select_font_face(this cairo_tHandle cr, string family, cairo_font_slant_t slant, cairo_font_weight_t weight);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_font_size")]
	internal static extern void cairo_set_font_size(this cairo_tHandle cr, double size);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_font_matrix")]
	internal static extern void cairo_set_font_matrix(this cairo_tHandle cr, cairo_matrix_tHandle matrixT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_font_matrix")]
	internal static extern void cairo_get_font_matrix(this cairo_tHandle cr, cairo_matrix_tHandle matrixT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_font_options")]
	internal static extern void cairo_set_font_options(this cairo_tHandle cr, cairo_font_options_tHandle optionsT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_font_options")]
	internal static extern void cairo_get_font_options(this cairo_tHandle cr, cairo_font_options_tHandle optionsT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_font_face")]
	internal static extern void cairo_set_font_face(this cairo_tHandle cr, cairo_font_face_tHandle fontFaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_font_face")]
	internal static extern cairo_font_face_tHandle cairo_get_font_face(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_scaled_font")]
	internal static extern void cairo_set_scaled_font(this cairo_tHandle cr, cairo_scaled_font_tHandle scaledFontT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_scaled_font")]
	internal static extern cairo_scaled_font_tHandle cairo_get_scaled_font(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_show_text")]
	internal static extern void cairo_show_text(this cairo_tHandle cr, string utf8);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_show_glyphs")]
	internal static extern void cairo_show_glyphs(this cairo_tHandle cr, cairo_glyph_tHandle glyphs, int num_glyphs);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_show_text_glyphs")]
	internal static extern void cairo_show_text_glyphs(this cairo_tHandle cr, string utf8, int utf8_len, cairo_glyph_tHandle glyphs, int num_glyphs, cairo_text_cluster_tHandle clusters, int num_clusters, cairo_text_cluster_flags_t cluster_flags);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_text_path")]
	internal static extern void cairo_text_path(this cairo_tHandle cr, string utf8);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_glyph_path")]
	internal static extern void cairo_glyph_path(this cairo_tHandle cr, cairo_glyph_tHandle glyphs, int num_glyphs);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_text_extents")]
	internal static extern void cairo_text_extents(this cairo_tHandle cr, string utf8, cairo_text_extents_tHandle extents);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_glyph_extents")]
	internal static extern void cairo_glyph_extents(this cairo_tHandle cr, cairo_glyph_tHandle glyphs, int num_glyphs, cairo_text_extents_tHandle extents);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_extents")]
	internal static extern void cairo_font_extents(this cairo_tHandle cr, cairo_font_extents_tHandle extents);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_operator")]
	internal static extern cairo_operator_t cairo_get_operator(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_source")]
	internal static extern cairo_pattern_tHandle cairo_get_source(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_tolerance")]
	internal static extern double cairo_get_tolerance(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_antialias")]
	internal static extern cairo_antialias_t cairo_get_antialias(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_has_current_point")]
	internal static extern int cairo_has_current_point(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_current_point")]
	internal static extern void cairo_get_current_point(this cairo_tHandle cr, out double x, out double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_fill_rule")]
	internal static extern cairo_fill_rule_t cairo_get_fill_rule(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_line_width")]
	internal static extern double cairo_get_line_width(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_line_cap")]
	internal static extern cairo_line_cap_t cairo_get_line_cap(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_line_join")]
	internal static extern cairo_line_join_t cairo_get_line_join(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_miter_limit")]
	internal static extern double cairo_get_miter_limit(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_dash_count")]
	internal static extern int cairo_get_dash_count(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_dash")]
	internal static extern void cairo_get_dash(this cairo_tHandle cr, out double dashes, out double offset);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_matrix")]
	internal static extern void cairo_get_matrix(this cairo_tHandle cr, cairo_matrix_tHandle matrixT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_target")]
	internal static extern cairo_surface_tHandle cairo_get_target(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_group_target")]
	internal static extern cairo_surface_tHandle cairo_get_group_target(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_copy_path")]
	internal static extern cairo_path_tHandle cairo_copy_path(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_copy_path_flat")]
	internal static extern cairo_path_tHandle cairo_copy_path_flat(this cairo_tHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_append_path")]
	internal static extern void cairo_append_path(this cairo_tHandle cr, cairo_path_tHandle pathT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_status")]
	internal static extern cairo_status_t cairo_status(this cairo_tHandle cr);
}
