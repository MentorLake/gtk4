using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public static class cairoExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_reference")]
	internal static extern cairoHandle cairo_reference(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_destroy")]
	internal static extern void cairo_destroy(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_reference_count")]
	internal static extern uint cairo_get_reference_count(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_user_data")]
	internal static extern IntPtr cairo_get_user_data(this cairoHandle cr, cairo_user_data_keyHandle key);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_user_data")]
	internal static extern _cairo_status cairo_set_user_data(this cairoHandle cr, cairo_user_data_keyHandle key, IntPtr user_data, cairo_destroy_func_t destroy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_save")]
	internal static extern void cairo_save(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_restore")]
	internal static extern void cairo_restore(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_push_group")]
	internal static extern void cairo_push_group(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_push_group_with_content")]
	internal static extern void cairo_push_group_with_content(this cairoHandle cr, _cairo_content content);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pop_group")]
	internal static extern cairo_patternHandle cairo_pop_group(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_pop_group_to_source")]
	internal static extern void cairo_pop_group_to_source(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_operator")]
	internal static extern void cairo_set_operator(this cairoHandle cr, _cairo_operator op);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_source")]
	internal static extern void cairo_set_source(this cairoHandle cr, cairo_patternHandle source);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_source_rgb")]
	internal static extern void cairo_set_source_rgb(this cairoHandle cr, double red, double green, double blue);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_source_rgba")]
	internal static extern void cairo_set_source_rgba(this cairoHandle cr, double red, double green, double blue, double alpha);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_source_surface")]
	internal static extern void cairo_set_source_surface(this cairoHandle cr, cairo_surfaceHandle surface, double x, double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_tolerance")]
	internal static extern void cairo_set_tolerance(this cairoHandle cr, double tolerance);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_antialias")]
	internal static extern void cairo_set_antialias(this cairoHandle cr, _cairo_antialias antialias);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_fill_rule")]
	internal static extern void cairo_set_fill_rule(this cairoHandle cr, _cairo_fill_rule fill_rule);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_line_width")]
	internal static extern void cairo_set_line_width(this cairoHandle cr, double width);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_line_cap")]
	internal static extern void cairo_set_line_cap(this cairoHandle cr, _cairo_line_cap line_cap);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_line_join")]
	internal static extern void cairo_set_line_join(this cairoHandle cr, _cairo_line_join line_join);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_dash")]
	internal static extern void cairo_set_dash(this cairoHandle cr, double[] dashes, int num_dashes, double offset);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_miter_limit")]
	internal static extern void cairo_set_miter_limit(this cairoHandle cr, double limit);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_translate")]
	internal static extern void cairo_translate(this cairoHandle cr, double tx, double ty);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scale")]
	internal static extern void cairo_scale(this cairoHandle cr, double sx, double sy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_rotate")]
	internal static extern void cairo_rotate(this cairoHandle cr, double angle);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_transform")]
	internal static extern void cairo_transform(this cairoHandle cr, cairo_matrixHandle matrix);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_matrix")]
	internal static extern void cairo_set_matrix(this cairoHandle cr, cairo_matrixHandle matrix);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_identity_matrix")]
	internal static extern void cairo_identity_matrix(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_user_to_device")]
	internal static extern void cairo_user_to_device(this cairoHandle cr, ref double x, ref double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_user_to_device_distance")]
	internal static extern void cairo_user_to_device_distance(this cairoHandle cr, ref double dx, ref double dy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_to_user")]
	internal static extern void cairo_device_to_user(this cairoHandle cr, ref double x, ref double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_to_user_distance")]
	internal static extern void cairo_device_to_user_distance(this cairoHandle cr, ref double dx, ref double dy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_new_path")]
	internal static extern void cairo_new_path(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_move_to")]
	internal static extern void cairo_move_to(this cairoHandle cr, double x, double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_new_sub_path")]
	internal static extern void cairo_new_sub_path(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_line_to")]
	internal static extern void cairo_line_to(this cairoHandle cr, double x, double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_curve_to")]
	internal static extern void cairo_curve_to(this cairoHandle cr, double x1, double y1, double x2, double y2, double x3, double y3);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_arc")]
	internal static extern void cairo_arc(this cairoHandle cr, double xc, double yc, double radius, double angle1, double angle2);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_arc_negative")]
	internal static extern void cairo_arc_negative(this cairoHandle cr, double xc, double yc, double radius, double angle1, double angle2);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_rel_move_to")]
	internal static extern void cairo_rel_move_to(this cairoHandle cr, double dx, double dy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_rel_line_to")]
	internal static extern void cairo_rel_line_to(this cairoHandle cr, double dx, double dy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_rel_curve_to")]
	internal static extern void cairo_rel_curve_to(this cairoHandle cr, double dx1, double dy1, double dx2, double dy2, double dx3, double dy3);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_rectangle")]
	internal static extern void cairo_rectangle(this cairoHandle cr, double x, double y, double width, double height);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_close_path")]
	internal static extern void cairo_close_path(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_path_extents")]
	internal static extern void cairo_path_extents(this cairoHandle cr, out double x1, out double y1, out double x2, out double y2);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_paint")]
	internal static extern void cairo_paint(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_paint_with_alpha")]
	internal static extern void cairo_paint_with_alpha(this cairoHandle cr, double alpha);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mask")]
	internal static extern void cairo_mask(this cairoHandle cr, cairo_patternHandle pattern);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_mask_surface")]
	internal static extern void cairo_mask_surface(this cairoHandle cr, cairo_surfaceHandle surface, double surface_x, double surface_y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_stroke")]
	internal static extern void cairo_stroke(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_stroke_preserve")]
	internal static extern void cairo_stroke_preserve(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_fill")]
	internal static extern void cairo_fill(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_fill_preserve")]
	internal static extern void cairo_fill_preserve(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_copy_page")]
	internal static extern void cairo_copy_page(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_show_page")]
	internal static extern void cairo_show_page(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_in_stroke")]
	internal static extern int cairo_in_stroke(this cairoHandle cr, double x, double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_in_fill")]
	internal static extern int cairo_in_fill(this cairoHandle cr, double x, double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_in_clip")]
	internal static extern int cairo_in_clip(this cairoHandle cr, double x, double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_stroke_extents")]
	internal static extern void cairo_stroke_extents(this cairoHandle cr, out double x1, out double y1, out double x2, out double y2);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_fill_extents")]
	internal static extern void cairo_fill_extents(this cairoHandle cr, out double x1, out double y1, out double x2, out double y2);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_reset_clip")]
	internal static extern void cairo_reset_clip(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_clip")]
	internal static extern void cairo_clip(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_clip_preserve")]
	internal static extern void cairo_clip_preserve(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_clip_extents")]
	internal static extern void cairo_clip_extents(this cairoHandle cr, out double x1, out double y1, out double x2, out double y2);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_copy_clip_rectangle_list")]
	internal static extern cairo_rectangle_listHandle cairo_copy_clip_rectangle_list(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_tag_begin")]
	internal static extern void cairo_tag_begin(this cairoHandle cr, string tag_name, string attributes);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_tag_end")]
	internal static extern void cairo_tag_end(this cairoHandle cr, string tag_name);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_select_font_face")]
	internal static extern void cairo_select_font_face(this cairoHandle cr, string family, _cairo_font_slant slant, _cairo_font_weight weight);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_font_size")]
	internal static extern void cairo_set_font_size(this cairoHandle cr, double size);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_font_matrix")]
	internal static extern void cairo_set_font_matrix(this cairoHandle cr, cairo_matrixHandle matrix);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_font_matrix")]
	internal static extern void cairo_get_font_matrix(this cairoHandle cr, cairo_matrixHandle matrix);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_font_options")]
	internal static extern void cairo_set_font_options(this cairoHandle cr, cairo_font_optionsHandle options);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_font_options")]
	internal static extern void cairo_get_font_options(this cairoHandle cr, cairo_font_optionsHandle options);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_font_face")]
	internal static extern void cairo_set_font_face(this cairoHandle cr, cairo_font_faceHandle font_face);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_font_face")]
	internal static extern cairo_font_faceHandle cairo_get_font_face(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_set_scaled_font")]
	internal static extern void cairo_set_scaled_font(this cairoHandle cr, cairo_scaled_fontHandle scaled_font);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_scaled_font")]
	internal static extern cairo_scaled_fontHandle cairo_get_scaled_font(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_show_text")]
	internal static extern void cairo_show_text(this cairoHandle cr, string utf8);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_show_glyphs")]
	internal static extern void cairo_show_glyphs(this cairoHandle cr, cairo_glyph_tHandle glyphs, int num_glyphs);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_show_text_glyphs")]
	internal static extern void cairo_show_text_glyphs(this cairoHandle cr, string utf8, int utf8_len, cairo_glyph_tHandle glyphs, int num_glyphs, cairo_text_cluster_tHandle clusters, int num_clusters, _cairo_text_cluster_flags cluster_flags);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_text_path")]
	internal static extern void cairo_text_path(this cairoHandle cr, string utf8);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_glyph_path")]
	internal static extern void cairo_glyph_path(this cairoHandle cr, cairo_glyph_tHandle glyphs, int num_glyphs);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_text_extents")]
	internal static extern void cairo_text_extents(this cairoHandle cr, string utf8, cairo_text_extents_tHandle extents);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_glyph_extents")]
	internal static extern void cairo_glyph_extents(this cairoHandle cr, cairo_glyph_tHandle glyphs, int num_glyphs, cairo_text_extents_tHandle extents);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_extents")]
	internal static extern void cairo_font_extents(this cairoHandle cr, cairo_font_extents_tHandle extents);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_operator")]
	internal static extern _cairo_operator cairo_get_operator(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_source")]
	internal static extern cairo_patternHandle cairo_get_source(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_tolerance")]
	internal static extern double cairo_get_tolerance(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_antialias")]
	internal static extern _cairo_antialias cairo_get_antialias(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_has_current_point")]
	internal static extern int cairo_has_current_point(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_current_point")]
	internal static extern void cairo_get_current_point(this cairoHandle cr, out double x, out double y);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_fill_rule")]
	internal static extern _cairo_fill_rule cairo_get_fill_rule(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_line_width")]
	internal static extern double cairo_get_line_width(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_line_cap")]
	internal static extern _cairo_line_cap cairo_get_line_cap(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_line_join")]
	internal static extern _cairo_line_join cairo_get_line_join(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_miter_limit")]
	internal static extern double cairo_get_miter_limit(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_dash_count")]
	internal static extern int cairo_get_dash_count(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_dash")]
	internal static extern void cairo_get_dash(this cairoHandle cr, out double dashes, out double offset);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_matrix")]
	internal static extern void cairo_get_matrix(this cairoHandle cr, cairo_matrixHandle matrix);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_target")]
	internal static extern cairo_surfaceHandle cairo_get_target(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_get_group_target")]
	internal static extern cairo_surfaceHandle cairo_get_group_target(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_copy_path")]
	internal static extern cairo_pathHandle cairo_copy_path(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_copy_path_flat")]
	internal static extern cairo_pathHandle cairo_copy_path_flat(this cairoHandle cr);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_append_path")]
	internal static extern void cairo_append_path(this cairoHandle cr, cairo_pathHandle path);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_status")]
	internal static extern _cairo_status cairo_status(this cairoHandle cr);
}
