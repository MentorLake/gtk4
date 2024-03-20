using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;
public static class cairoAdaptors
{
    public static cairoHandle CairoReference(this cairoHandle cr)
    {
        return cairoExterns.cairo_reference(cr);
    }

    public static cairoHandle CairoDestroy(this cairoHandle cr)
    {
        cairoExterns.cairo_destroy(cr);
        return cr;
    }

    public static uint CairoGetReferenceCount(this cairoHandle cr)
    {
        return cairoExterns.cairo_get_reference_count(cr);
    }

    public static IntPtr CairoGetUserData(this cairoHandle cr, cairo_user_data_keyHandle key)
    {
        return cairoExterns.cairo_get_user_data(cr, key);
    }

    public static _cairo_status CairoSetUserData(this cairoHandle cr, cairo_user_data_keyHandle key, IntPtr user_data, cairo_destroy_func_t destroy)
    {
        return cairoExterns.cairo_set_user_data(cr, key, user_data, destroy);
    }

    public static cairoHandle CairoSave(this cairoHandle cr)
    {
        cairoExterns.cairo_save(cr);
        return cr;
    }

    public static cairoHandle CairoRestore(this cairoHandle cr)
    {
        cairoExterns.cairo_restore(cr);
        return cr;
    }

    public static cairoHandle CairoPushGroup(this cairoHandle cr)
    {
        cairoExterns.cairo_push_group(cr);
        return cr;
    }

    public static cairoHandle CairoPushGroupWithContent(this cairoHandle cr, _cairo_content content)
    {
        cairoExterns.cairo_push_group_with_content(cr, content);
        return cr;
    }

    public static cairo_patternHandle CairoPopGroup(this cairoHandle cr)
    {
        return cairoExterns.cairo_pop_group(cr);
    }

    public static cairoHandle CairoPopGroupToSource(this cairoHandle cr)
    {
        cairoExterns.cairo_pop_group_to_source(cr);
        return cr;
    }

    public static cairoHandle CairoSetOperator(this cairoHandle cr, _cairo_operator op)
    {
        cairoExterns.cairo_set_operator(cr, op);
        return cr;
    }

    public static cairoHandle CairoSetSource(this cairoHandle cr, cairo_patternHandle source)
    {
        cairoExterns.cairo_set_source(cr, source);
        return cr;
    }

    public static cairoHandle CairoSetSourceRgb(this cairoHandle cr, double red, double green, double blue)
    {
        cairoExterns.cairo_set_source_rgb(cr, red, green, blue);
        return cr;
    }

    public static cairoHandle CairoSetSourceRgba(this cairoHandle cr, double red, double green, double blue, double alpha)
    {
        cairoExterns.cairo_set_source_rgba(cr, red, green, blue, alpha);
        return cr;
    }

    public static cairoHandle CairoSetSourceSurface(this cairoHandle cr, cairo_surfaceHandle surface, double x, double y)
    {
        cairoExterns.cairo_set_source_surface(cr, surface, x, y);
        return cr;
    }

    public static cairoHandle CairoSetTolerance(this cairoHandle cr, double tolerance)
    {
        cairoExterns.cairo_set_tolerance(cr, tolerance);
        return cr;
    }

    public static cairoHandle CairoSetAntialias(this cairoHandle cr, _cairo_antialias antialias)
    {
        cairoExterns.cairo_set_antialias(cr, antialias);
        return cr;
    }

    public static cairoHandle CairoSetFillRule(this cairoHandle cr, _cairo_fill_rule fill_rule)
    {
        cairoExterns.cairo_set_fill_rule(cr, fill_rule);
        return cr;
    }

    public static cairoHandle CairoSetLineWidth(this cairoHandle cr, double width)
    {
        cairoExterns.cairo_set_line_width(cr, width);
        return cr;
    }

    public static cairoHandle CairoSetLineCap(this cairoHandle cr, _cairo_line_cap line_cap)
    {
        cairoExterns.cairo_set_line_cap(cr, line_cap);
        return cr;
    }

    public static cairoHandle CairoSetLineJoin(this cairoHandle cr, _cairo_line_join line_join)
    {
        cairoExterns.cairo_set_line_join(cr, line_join);
        return cr;
    }

    public static cairoHandle CairoSetDash(this cairoHandle cr, double[] dashes, int num_dashes, double offset)
    {
        cairoExterns.cairo_set_dash(cr, dashes, num_dashes, offset);
        return cr;
    }

    public static cairoHandle CairoSetMiterLimit(this cairoHandle cr, double limit)
    {
        cairoExterns.cairo_set_miter_limit(cr, limit);
        return cr;
    }

    public static cairoHandle CairoTranslate(this cairoHandle cr, double tx, double ty)
    {
        cairoExterns.cairo_translate(cr, tx, ty);
        return cr;
    }

    public static cairoHandle CairoScale(this cairoHandle cr, double sx, double sy)
    {
        cairoExterns.cairo_scale(cr, sx, sy);
        return cr;
    }

    public static cairoHandle CairoRotate(this cairoHandle cr, double angle)
    {
        cairoExterns.cairo_rotate(cr, angle);
        return cr;
    }

    public static cairoHandle CairoTransform(this cairoHandle cr, cairo_matrixHandle matrix)
    {
        cairoExterns.cairo_transform(cr, matrix);
        return cr;
    }

    public static cairoHandle CairoSetMatrix(this cairoHandle cr, cairo_matrixHandle matrix)
    {
        cairoExterns.cairo_set_matrix(cr, matrix);
        return cr;
    }

    public static cairoHandle CairoIdentityMatrix(this cairoHandle cr)
    {
        cairoExterns.cairo_identity_matrix(cr);
        return cr;
    }

    public static cairoHandle CairoUserToDevice(this cairoHandle cr, ref double x, ref double y)
    {
        cairoExterns.cairo_user_to_device(cr, ref x, ref y);
        return cr;
    }

    public static cairoHandle CairoUserToDeviceDistance(this cairoHandle cr, ref double dx, ref double dy)
    {
        cairoExterns.cairo_user_to_device_distance(cr, ref dx, ref dy);
        return cr;
    }

    public static cairoHandle CairoDeviceToUser(this cairoHandle cr, ref double x, ref double y)
    {
        cairoExterns.cairo_device_to_user(cr, ref x, ref y);
        return cr;
    }

    public static cairoHandle CairoDeviceToUserDistance(this cairoHandle cr, ref double dx, ref double dy)
    {
        cairoExterns.cairo_device_to_user_distance(cr, ref dx, ref dy);
        return cr;
    }

    public static cairoHandle CairoNewPath(this cairoHandle cr)
    {
        cairoExterns.cairo_new_path(cr);
        return cr;
    }

    public static cairoHandle CairoMoveTo(this cairoHandle cr, double x, double y)
    {
        cairoExterns.cairo_move_to(cr, x, y);
        return cr;
    }

    public static cairoHandle CairoNewSubPath(this cairoHandle cr)
    {
        cairoExterns.cairo_new_sub_path(cr);
        return cr;
    }

    public static cairoHandle CairoLineTo(this cairoHandle cr, double x, double y)
    {
        cairoExterns.cairo_line_to(cr, x, y);
        return cr;
    }

    public static cairoHandle CairoCurveTo(this cairoHandle cr, double x1, double y1, double x2, double y2, double x3, double y3)
    {
        cairoExterns.cairo_curve_to(cr, x1, y1, x2, y2, x3, y3);
        return cr;
    }

    public static cairoHandle CairoArc(this cairoHandle cr, double xc, double yc, double radius, double angle1, double angle2)
    {
        cairoExterns.cairo_arc(cr, xc, yc, radius, angle1, angle2);
        return cr;
    }

    public static cairoHandle CairoArcNegative(this cairoHandle cr, double xc, double yc, double radius, double angle1, double angle2)
    {
        cairoExterns.cairo_arc_negative(cr, xc, yc, radius, angle1, angle2);
        return cr;
    }

    public static cairoHandle CairoRelMoveTo(this cairoHandle cr, double dx, double dy)
    {
        cairoExterns.cairo_rel_move_to(cr, dx, dy);
        return cr;
    }

    public static cairoHandle CairoRelLineTo(this cairoHandle cr, double dx, double dy)
    {
        cairoExterns.cairo_rel_line_to(cr, dx, dy);
        return cr;
    }

    public static cairoHandle CairoRelCurveTo(this cairoHandle cr, double dx1, double dy1, double dx2, double dy2, double dx3, double dy3)
    {
        cairoExterns.cairo_rel_curve_to(cr, dx1, dy1, dx2, dy2, dx3, dy3);
        return cr;
    }

    public static cairoHandle CairoRectangle(this cairoHandle cr, double x, double y, double width, double height)
    {
        cairoExterns.cairo_rectangle(cr, x, y, width, height);
        return cr;
    }

    public static cairoHandle CairoClosePath(this cairoHandle cr)
    {
        cairoExterns.cairo_close_path(cr);
        return cr;
    }

    public static cairoHandle CairoPathExtents(this cairoHandle cr, out double x1, out double y1, out double x2, out double y2)
    {
        cairoExterns.cairo_path_extents(cr, out x1, out y1, out x2, out y2);
        return cr;
    }

    public static cairoHandle CairoPaint(this cairoHandle cr)
    {
        cairoExterns.cairo_paint(cr);
        return cr;
    }

    public static cairoHandle CairoPaintWithAlpha(this cairoHandle cr, double alpha)
    {
        cairoExterns.cairo_paint_with_alpha(cr, alpha);
        return cr;
    }

    public static cairoHandle CairoMask(this cairoHandle cr, cairo_patternHandle pattern)
    {
        cairoExterns.cairo_mask(cr, pattern);
        return cr;
    }

    public static cairoHandle CairoMaskSurface(this cairoHandle cr, cairo_surfaceHandle surface, double surface_x, double surface_y)
    {
        cairoExterns.cairo_mask_surface(cr, surface, surface_x, surface_y);
        return cr;
    }

    public static cairoHandle CairoStroke(this cairoHandle cr)
    {
        cairoExterns.cairo_stroke(cr);
        return cr;
    }

    public static cairoHandle CairoStrokePreserve(this cairoHandle cr)
    {
        cairoExterns.cairo_stroke_preserve(cr);
        return cr;
    }

    public static cairoHandle CairoFill(this cairoHandle cr)
    {
        cairoExterns.cairo_fill(cr);
        return cr;
    }

    public static cairoHandle CairoFillPreserve(this cairoHandle cr)
    {
        cairoExterns.cairo_fill_preserve(cr);
        return cr;
    }

    public static cairoHandle CairoCopyPage(this cairoHandle cr)
    {
        cairoExterns.cairo_copy_page(cr);
        return cr;
    }

    public static cairoHandle CairoShowPage(this cairoHandle cr)
    {
        cairoExterns.cairo_show_page(cr);
        return cr;
    }

    public static int CairoInStroke(this cairoHandle cr, double x, double y)
    {
        return cairoExterns.cairo_in_stroke(cr, x, y);
    }

    public static int CairoInFill(this cairoHandle cr, double x, double y)
    {
        return cairoExterns.cairo_in_fill(cr, x, y);
    }

    public static int CairoInClip(this cairoHandle cr, double x, double y)
    {
        return cairoExterns.cairo_in_clip(cr, x, y);
    }

    public static cairoHandle CairoStrokeExtents(this cairoHandle cr, out double x1, out double y1, out double x2, out double y2)
    {
        cairoExterns.cairo_stroke_extents(cr, out x1, out y1, out x2, out y2);
        return cr;
    }

    public static cairoHandle CairoFillExtents(this cairoHandle cr, out double x1, out double y1, out double x2, out double y2)
    {
        cairoExterns.cairo_fill_extents(cr, out x1, out y1, out x2, out y2);
        return cr;
    }

    public static cairoHandle CairoResetClip(this cairoHandle cr)
    {
        cairoExterns.cairo_reset_clip(cr);
        return cr;
    }

    public static cairoHandle CairoClip(this cairoHandle cr)
    {
        cairoExterns.cairo_clip(cr);
        return cr;
    }

    public static cairoHandle CairoClipPreserve(this cairoHandle cr)
    {
        cairoExterns.cairo_clip_preserve(cr);
        return cr;
    }

    public static cairoHandle CairoClipExtents(this cairoHandle cr, out double x1, out double y1, out double x2, out double y2)
    {
        cairoExterns.cairo_clip_extents(cr, out x1, out y1, out x2, out y2);
        return cr;
    }

    public static cairo_rectangle_listHandle CairoCopyClipRectangleList(this cairoHandle cr)
    {
        return cairoExterns.cairo_copy_clip_rectangle_list(cr);
    }

    public static cairoHandle CairoTagBegin(this cairoHandle cr, string tag_name, string attributes)
    {
        cairoExterns.cairo_tag_begin(cr, tag_name, attributes);
        return cr;
    }

    public static cairoHandle CairoTagEnd(this cairoHandle cr, string tag_name)
    {
        cairoExterns.cairo_tag_end(cr, tag_name);
        return cr;
    }

    public static cairoHandle CairoSelectFontFace(this cairoHandle cr, string family, _cairo_font_slant slant, _cairo_font_weight weight)
    {
        cairoExterns.cairo_select_font_face(cr, family, slant, weight);
        return cr;
    }

    public static cairoHandle CairoSetFontSize(this cairoHandle cr, double size)
    {
        cairoExterns.cairo_set_font_size(cr, size);
        return cr;
    }

    public static cairoHandle CairoSetFontMatrix(this cairoHandle cr, cairo_matrixHandle matrix)
    {
        cairoExterns.cairo_set_font_matrix(cr, matrix);
        return cr;
    }

    public static cairoHandle CairoGetFontMatrix(this cairoHandle cr, cairo_matrixHandle matrix)
    {
        cairoExterns.cairo_get_font_matrix(cr, matrix);
        return cr;
    }

    public static cairoHandle CairoSetFontOptions(this cairoHandle cr, cairo_font_optionsHandle options)
    {
        cairoExterns.cairo_set_font_options(cr, options);
        return cr;
    }

    public static cairoHandle CairoGetFontOptions(this cairoHandle cr, cairo_font_optionsHandle options)
    {
        cairoExterns.cairo_get_font_options(cr, options);
        return cr;
    }

    public static cairoHandle CairoSetFontFace(this cairoHandle cr, cairo_font_faceHandle font_face)
    {
        cairoExterns.cairo_set_font_face(cr, font_face);
        return cr;
    }

    public static cairo_font_faceHandle CairoGetFontFace(this cairoHandle cr)
    {
        return cairoExterns.cairo_get_font_face(cr);
    }

    public static cairoHandle CairoSetScaledFont(this cairoHandle cr, cairo_scaled_fontHandle scaled_font)
    {
        cairoExterns.cairo_set_scaled_font(cr, scaled_font);
        return cr;
    }

    public static cairo_scaled_fontHandle CairoGetScaledFont(this cairoHandle cr)
    {
        return cairoExterns.cairo_get_scaled_font(cr);
    }

    public static cairoHandle CairoShowText(this cairoHandle cr, string utf8)
    {
        cairoExterns.cairo_show_text(cr, utf8);
        return cr;
    }

    public static cairoHandle CairoShowGlyphs(this cairoHandle cr, cairo_glyph_tHandle glyphs, int num_glyphs)
    {
        cairoExterns.cairo_show_glyphs(cr, glyphs, num_glyphs);
        return cr;
    }

    public static cairoHandle CairoShowTextGlyphs(this cairoHandle cr, string utf8, int utf8_len, cairo_glyph_tHandle glyphs, int num_glyphs, cairo_text_cluster_tHandle clusters, int num_clusters, _cairo_text_cluster_flags cluster_flags)
    {
        cairoExterns.cairo_show_text_glyphs(cr, utf8, utf8_len, glyphs, num_glyphs, clusters, num_clusters, cluster_flags);
        return cr;
    }

    public static cairoHandle CairoTextPath(this cairoHandle cr, string utf8)
    {
        cairoExterns.cairo_text_path(cr, utf8);
        return cr;
    }

    public static cairoHandle CairoGlyphPath(this cairoHandle cr, cairo_glyph_tHandle glyphs, int num_glyphs)
    {
        cairoExterns.cairo_glyph_path(cr, glyphs, num_glyphs);
        return cr;
    }

    public static cairoHandle CairoTextExtents(this cairoHandle cr, string utf8, cairo_text_extents_tHandle extents)
    {
        cairoExterns.cairo_text_extents(cr, utf8, extents);
        return cr;
    }

    public static cairoHandle CairoGlyphExtents(this cairoHandle cr, cairo_glyph_tHandle glyphs, int num_glyphs, cairo_text_extents_tHandle extents)
    {
        cairoExterns.cairo_glyph_extents(cr, glyphs, num_glyphs, extents);
        return cr;
    }

    public static cairoHandle CairoFontExtents(this cairoHandle cr, cairo_font_extents_tHandle extents)
    {
        cairoExterns.cairo_font_extents(cr, extents);
        return cr;
    }

    public static _cairo_operator CairoGetOperator(this cairoHandle cr)
    {
        return cairoExterns.cairo_get_operator(cr);
    }

    public static cairo_patternHandle CairoGetSource(this cairoHandle cr)
    {
        return cairoExterns.cairo_get_source(cr);
    }

    public static double CairoGetTolerance(this cairoHandle cr)
    {
        return cairoExterns.cairo_get_tolerance(cr);
    }

    public static _cairo_antialias CairoGetAntialias(this cairoHandle cr)
    {
        return cairoExterns.cairo_get_antialias(cr);
    }

    public static int CairoHasCurrentPoint(this cairoHandle cr)
    {
        return cairoExterns.cairo_has_current_point(cr);
    }

    public static cairoHandle CairoGetCurrentPoint(this cairoHandle cr, out double x, out double y)
    {
        cairoExterns.cairo_get_current_point(cr, out x, out y);
        return cr;
    }

    public static _cairo_fill_rule CairoGetFillRule(this cairoHandle cr)
    {
        return cairoExterns.cairo_get_fill_rule(cr);
    }

    public static double CairoGetLineWidth(this cairoHandle cr)
    {
        return cairoExterns.cairo_get_line_width(cr);
    }

    public static _cairo_line_cap CairoGetLineCap(this cairoHandle cr)
    {
        return cairoExterns.cairo_get_line_cap(cr);
    }

    public static _cairo_line_join CairoGetLineJoin(this cairoHandle cr)
    {
        return cairoExterns.cairo_get_line_join(cr);
    }

    public static double CairoGetMiterLimit(this cairoHandle cr)
    {
        return cairoExterns.cairo_get_miter_limit(cr);
    }

    public static int CairoGetDashCount(this cairoHandle cr)
    {
        return cairoExterns.cairo_get_dash_count(cr);
    }

    public static cairoHandle CairoGetDash(this cairoHandle cr, out double dashes, out double offset)
    {
        cairoExterns.cairo_get_dash(cr, out dashes, out offset);
        return cr;
    }

    public static cairoHandle CairoGetMatrix(this cairoHandle cr, cairo_matrixHandle matrix)
    {
        cairoExterns.cairo_get_matrix(cr, matrix);
        return cr;
    }

    public static cairo_surfaceHandle CairoGetTarget(this cairoHandle cr)
    {
        return cairoExterns.cairo_get_target(cr);
    }

    public static cairo_surfaceHandle CairoGetGroupTarget(this cairoHandle cr)
    {
        return cairoExterns.cairo_get_group_target(cr);
    }

    public static cairo_pathHandle CairoCopyPath(this cairoHandle cr)
    {
        return cairoExterns.cairo_copy_path(cr);
    }

    public static cairo_pathHandle CairoCopyPathFlat(this cairoHandle cr)
    {
        return cairoExterns.cairo_copy_path_flat(cr);
    }

    public static cairoHandle CairoAppendPath(this cairoHandle cr, cairo_pathHandle path)
    {
        cairoExterns.cairo_append_path(cr, path);
        return cr;
    }

    public static _cairo_status CairoStatus(this cairoHandle cr)
    {
        return cairoExterns.cairo_status(cr);
    }
}
