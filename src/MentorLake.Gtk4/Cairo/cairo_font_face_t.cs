using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public class cairo_font_face_tHandle : BaseSafeHandle { }
public struct cairo_font_face_t { }

public static class cairo_font_faceAdaptors
{
	public static cairo_font_face_tHandle CairoFontFaceReference(this cairo_font_face_tHandle fontFaceT)
	{
		return cairo_font_faceExterns.cairo_font_face_reference(fontFaceT);
	}

	public static cairo_font_face_tHandle CairoFontFaceDestroy(this cairo_font_face_tHandle fontFaceT)
	{
		cairo_font_faceExterns.cairo_font_face_destroy(fontFaceT);
		return fontFaceT;
	}

	public static uint CairoFontFaceGetReferenceCount(this cairo_font_face_tHandle fontFaceT)
	{
		return cairo_font_faceExterns.cairo_font_face_get_reference_count(fontFaceT);
	}

	public static cairo_status_t CairoFontFaceStatus(this cairo_font_face_tHandle fontFaceT)
	{
		return cairo_font_faceExterns.cairo_font_face_status(fontFaceT);
	}

	public static cairo_font_type_t CairoFontFaceGetType(this cairo_font_face_tHandle fontFaceT)
	{
		return cairo_font_faceExterns.cairo_font_face_get_type(fontFaceT);
	}

	public static IntPtr CairoFontFaceGetUserData(this cairo_font_face_tHandle fontFaceT, cairo_user_data_key_tHandle keyT)
	{
		return cairo_font_faceExterns.cairo_font_face_get_user_data(fontFaceT, keyT);
	}

	public static cairo_status_t CairoFontFaceSetUserData(this cairo_font_face_tHandle fontFaceT, cairo_user_data_key_tHandle keyT, IntPtr user_data, cairo_destroy_func_t destroy)
	{
		return cairo_font_faceExterns.cairo_font_face_set_user_data(fontFaceT, keyT, user_data, destroy);
	}

	public static cairo_scaled_font_tHandle CairoScaledFontCreate(this cairo_font_face_tHandle fontFaceT, cairo_matrix_tHandle fontMatrixT, cairo_matrix_tHandle ctm, cairo_font_options_tHandle optionsT)
	{
		return cairo_font_faceExterns.cairo_scaled_font_create(fontFaceT, fontMatrixT, ctm, optionsT);
	}

	public static string CairoToyFontFaceGetFamily(this cairo_font_face_tHandle fontFaceT)
	{
		return cairo_font_faceExterns.cairo_toy_font_face_get_family(fontFaceT);
	}

	public static cairo_font_slant_t CairoToyFontFaceGetSlant(this cairo_font_face_tHandle fontFaceT)
	{
		return cairo_font_faceExterns.cairo_toy_font_face_get_slant(fontFaceT);
	}

	public static cairo_font_weight_t CairoToyFontFaceGetWeight(this cairo_font_face_tHandle fontFaceT)
	{
		return cairo_font_faceExterns.cairo_toy_font_face_get_weight(fontFaceT);
	}

	public static cairo_font_face_tHandle CairoUserFontFaceSetInitFunc(this cairo_font_face_tHandle fontFaceT, cairo_user_scaled_font_init_func_t init_func)
	{
		cairo_font_faceExterns.cairo_user_font_face_set_init_func(fontFaceT, init_func);
		return fontFaceT;
	}

	public static cairo_font_face_tHandle CairoUserFontFaceSetRenderGlyphFunc(this cairo_font_face_tHandle fontFaceT, cairo_user_scaled_font_render_glyph_func_t render_glyph_func)
	{
		cairo_font_faceExterns.cairo_user_font_face_set_render_glyph_func(fontFaceT, render_glyph_func);
		return fontFaceT;
	}

	public static cairo_font_face_tHandle CairoUserFontFaceSetTextToGlyphsFunc(this cairo_font_face_tHandle fontFaceT, cairo_user_scaled_font_text_to_glyphs_func_t text_to_glyphs_func)
	{
		cairo_font_faceExterns.cairo_user_font_face_set_text_to_glyphs_func(fontFaceT, text_to_glyphs_func);
		return fontFaceT;
	}

	public static cairo_font_face_tHandle CairoUserFontFaceSetUnicodeToGlyphFunc(this cairo_font_face_tHandle fontFaceT, cairo_user_scaled_font_unicode_to_glyph_func_t unicode_to_glyph_func)
	{
		cairo_font_faceExterns.cairo_user_font_face_set_unicode_to_glyph_func(fontFaceT, unicode_to_glyph_func);
		return fontFaceT;
	}

	public static IntPtr CairoUserFontFaceGetInitFunc(this cairo_font_face_tHandle fontFaceT)
	{
		return cairo_font_faceExterns.cairo_user_font_face_get_init_func(fontFaceT);
	}

	public static IntPtr CairoUserFontFaceGetRenderGlyphFunc(this cairo_font_face_tHandle fontFaceT)
	{
		return cairo_font_faceExterns.cairo_user_font_face_get_render_glyph_func(fontFaceT);
	}

	public static IntPtr CairoUserFontFaceGetTextToGlyphsFunc(this cairo_font_face_tHandle fontFaceT)
	{
		return cairo_font_faceExterns.cairo_user_font_face_get_text_to_glyphs_func(fontFaceT);
	}

	public static IntPtr CairoUserFontFaceGetUnicodeToGlyphFunc(this cairo_font_face_tHandle fontFaceT)
	{
		return cairo_font_faceExterns.cairo_user_font_face_get_unicode_to_glyph_func(fontFaceT);
	}
}

public static class cairo_font_faceExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_face_reference")]
	internal static extern cairo_font_face_tHandle cairo_font_face_reference(this cairo_font_face_tHandle fontFaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_face_destroy")]
	internal static extern void cairo_font_face_destroy(this cairo_font_face_tHandle fontFaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_face_get_reference_count")]
	internal static extern uint cairo_font_face_get_reference_count(this cairo_font_face_tHandle fontFaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_face_status")]
	internal static extern cairo_status_t cairo_font_face_status(this cairo_font_face_tHandle fontFaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_face_get_type")]
	internal static extern cairo_font_type_t cairo_font_face_get_type(this cairo_font_face_tHandle fontFaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_face_get_user_data")]
	internal static extern IntPtr cairo_font_face_get_user_data(this cairo_font_face_tHandle fontFaceT, cairo_user_data_key_tHandle keyT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_font_face_set_user_data")]
	internal static extern cairo_status_t cairo_font_face_set_user_data(this cairo_font_face_tHandle fontFaceT, cairo_user_data_key_tHandle keyT, IntPtr user_data, cairo_destroy_func_t destroy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_create")]
	internal static extern cairo_scaled_font_tHandle cairo_scaled_font_create(this cairo_font_face_tHandle fontFaceT, cairo_matrix_tHandle fontMatrixT, cairo_matrix_tHandle ctm, cairo_font_options_tHandle optionsT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_toy_font_face_get_family")]
	internal static extern string cairo_toy_font_face_get_family(this cairo_font_face_tHandle fontFaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_toy_font_face_get_slant")]
	internal static extern cairo_font_slant_t cairo_toy_font_face_get_slant(this cairo_font_face_tHandle fontFaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_toy_font_face_get_weight")]
	internal static extern cairo_font_weight_t cairo_toy_font_face_get_weight(this cairo_font_face_tHandle fontFaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_user_font_face_set_init_func")]
	internal static extern void cairo_user_font_face_set_init_func(this cairo_font_face_tHandle fontFaceT, cairo_user_scaled_font_init_func_t init_func);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_user_font_face_set_render_glyph_func")]
	internal static extern void cairo_user_font_face_set_render_glyph_func(this cairo_font_face_tHandle fontFaceT, cairo_user_scaled_font_render_glyph_func_t render_glyph_func);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_user_font_face_set_text_to_glyphs_func")]
	internal static extern void cairo_user_font_face_set_text_to_glyphs_func(this cairo_font_face_tHandle fontFaceT, cairo_user_scaled_font_text_to_glyphs_func_t text_to_glyphs_func);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_user_font_face_set_unicode_to_glyph_func")]
	internal static extern void cairo_user_font_face_set_unicode_to_glyph_func(this cairo_font_face_tHandle fontFaceT, cairo_user_scaled_font_unicode_to_glyph_func_t unicode_to_glyph_func);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_user_font_face_get_init_func")]
	internal static extern IntPtr cairo_user_font_face_get_init_func(this cairo_font_face_tHandle fontFaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_user_font_face_get_render_glyph_func")]
	internal static extern IntPtr cairo_user_font_face_get_render_glyph_func(this cairo_font_face_tHandle fontFaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_user_font_face_get_text_to_glyphs_func")]
	internal static extern IntPtr cairo_user_font_face_get_text_to_glyphs_func(this cairo_font_face_tHandle fontFaceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_user_font_face_get_unicode_to_glyph_func")]
	internal static extern IntPtr cairo_user_font_face_get_unicode_to_glyph_func(this cairo_font_face_tHandle fontFaceT);
}
