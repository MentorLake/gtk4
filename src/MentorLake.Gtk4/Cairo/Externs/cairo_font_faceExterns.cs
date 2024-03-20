using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public static class cairo_font_faceExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_face_reference")]
	internal static extern cairo_font_faceHandle cairo_font_face_reference(this cairo_font_faceHandle font_face);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_face_destroy")]
	internal static extern void cairo_font_face_destroy(this cairo_font_faceHandle font_face);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_face_get_reference_count")]
	internal static extern uint cairo_font_face_get_reference_count(this cairo_font_faceHandle font_face);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_face_status")]
	internal static extern _cairo_status cairo_font_face_status(this cairo_font_faceHandle font_face);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_face_get_type")]
	internal static extern _cairo_font_type cairo_font_face_get_type(this cairo_font_faceHandle font_face);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_face_get_user_data")]
	internal static extern IntPtr cairo_font_face_get_user_data(this cairo_font_faceHandle font_face, cairo_user_data_keyHandle key);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_face_set_user_data")]
	internal static extern _cairo_status cairo_font_face_set_user_data(this cairo_font_faceHandle font_face, cairo_user_data_keyHandle key, IntPtr user_data, cairo_destroy_func_t destroy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_create")]
	internal static extern cairo_scaled_fontHandle cairo_scaled_font_create(this cairo_font_faceHandle font_face, cairo_matrixHandle font_matrix, cairo_matrixHandle ctm, cairo_font_optionsHandle options);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_toy_font_face_get_family")]
	internal static extern string cairo_toy_font_face_get_family(this cairo_font_faceHandle font_face);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_toy_font_face_get_slant")]
	internal static extern _cairo_font_slant cairo_toy_font_face_get_slant(this cairo_font_faceHandle font_face);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_toy_font_face_get_weight")]
	internal static extern _cairo_font_weight cairo_toy_font_face_get_weight(this cairo_font_faceHandle font_face);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_user_font_face_set_init_func")]
	internal static extern void cairo_user_font_face_set_init_func(this cairo_font_faceHandle font_face, cairo_user_scaled_font_init_func_t init_func);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_user_font_face_set_render_glyph_func")]
	internal static extern void cairo_user_font_face_set_render_glyph_func(this cairo_font_faceHandle font_face, cairo_user_scaled_font_render_glyph_func_t render_glyph_func);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_user_font_face_set_text_to_glyphs_func")]
	internal static extern void cairo_user_font_face_set_text_to_glyphs_func(this cairo_font_faceHandle font_face, cairo_user_scaled_font_text_to_glyphs_func_t text_to_glyphs_func);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_user_font_face_set_unicode_to_glyph_func")]
	internal static extern void cairo_user_font_face_set_unicode_to_glyph_func(this cairo_font_faceHandle font_face, cairo_user_scaled_font_unicode_to_glyph_func_t unicode_to_glyph_func);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_user_font_face_get_init_func")]
	internal static extern IntPtr cairo_user_font_face_get_init_func(this cairo_font_faceHandle font_face);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_user_font_face_get_render_glyph_func")]
	internal static extern IntPtr cairo_user_font_face_get_render_glyph_func(this cairo_font_faceHandle font_face);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_user_font_face_get_text_to_glyphs_func")]
	internal static extern IntPtr cairo_user_font_face_get_text_to_glyphs_func(this cairo_font_faceHandle font_face);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_user_font_face_get_unicode_to_glyph_func")]
	internal static extern IntPtr cairo_user_font_face_get_unicode_to_glyph_func(this cairo_font_faceHandle font_face);
}
