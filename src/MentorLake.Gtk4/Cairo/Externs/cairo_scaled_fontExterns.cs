using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public static class cairo_scaled_fontExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_reference")]
	internal static extern cairo_scaled_fontHandle cairo_scaled_font_reference(this cairo_scaled_fontHandle scaled_font);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_destroy")]
	internal static extern void cairo_scaled_font_destroy(this cairo_scaled_fontHandle scaled_font);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_get_reference_count")]
	internal static extern uint cairo_scaled_font_get_reference_count(this cairo_scaled_fontHandle scaled_font);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_status")]
	internal static extern _cairo_status cairo_scaled_font_status(this cairo_scaled_fontHandle scaled_font);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_get_type")]
	internal static extern _cairo_font_type cairo_scaled_font_get_type(this cairo_scaled_fontHandle scaled_font);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_get_user_data")]
	internal static extern IntPtr cairo_scaled_font_get_user_data(this cairo_scaled_fontHandle scaled_font, cairo_user_data_keyHandle key);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_set_user_data")]
	internal static extern _cairo_status cairo_scaled_font_set_user_data(this cairo_scaled_fontHandle scaled_font, cairo_user_data_keyHandle key, IntPtr user_data, cairo_destroy_func_t destroy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_extents")]
	internal static extern void cairo_scaled_font_extents(this cairo_scaled_fontHandle scaled_font, cairo_font_extents_tHandle extents);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_text_extents")]
	internal static extern void cairo_scaled_font_text_extents(this cairo_scaled_fontHandle scaled_font, string utf8, cairo_text_extents_tHandle extents);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_glyph_extents")]
	internal static extern void cairo_scaled_font_glyph_extents(this cairo_scaled_fontHandle scaled_font, cairo_glyph_tHandle glyphs, int num_glyphs, cairo_text_extents_tHandle extents);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_text_to_glyphs")]
	internal static extern _cairo_status cairo_scaled_font_text_to_glyphs(this cairo_scaled_fontHandle scaled_font, double x, double y, string utf8, int utf8_len, cairo_glyph_tHandle[] glyphs, ref int num_glyphs, cairo_text_cluster_tHandle[] clusters, ref int num_clusters, out _cairo_text_cluster_flags cluster_flags);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_get_font_face")]
	internal static extern cairo_font_faceHandle cairo_scaled_font_get_font_face(this cairo_scaled_fontHandle scaled_font);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_get_font_matrix")]
	internal static extern void cairo_scaled_font_get_font_matrix(this cairo_scaled_fontHandle scaled_font, cairo_matrixHandle font_matrix);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_get_ctm")]
	internal static extern void cairo_scaled_font_get_ctm(this cairo_scaled_fontHandle scaled_font, cairo_matrixHandle ctm);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_get_scale_matrix")]
	internal static extern void cairo_scaled_font_get_scale_matrix(this cairo_scaled_fontHandle scaled_font, cairo_matrixHandle scale_matrix);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_get_font_options")]
	internal static extern void cairo_scaled_font_get_font_options(this cairo_scaled_fontHandle scaled_font, cairo_font_optionsHandle options);
}
