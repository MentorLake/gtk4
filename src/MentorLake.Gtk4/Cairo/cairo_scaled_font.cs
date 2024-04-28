using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public class cairo_scaled_font_tHandle : BaseSafeHandle { }
public struct cairo_scaled_font_t { }

public static class cairo_scaled_fontAdaptors
{
	public static cairo_scaled_font_tHandle CairoScaledFontReference(this cairo_scaled_font_tHandle scaledFontT)
	{
		return cairo_scaled_fontExterns.cairo_scaled_font_reference(scaledFontT);
	}

	public static cairo_scaled_font_tHandle CairoScaledFontDestroy(this cairo_scaled_font_tHandle scaledFontT)
	{
		cairo_scaled_fontExterns.cairo_scaled_font_destroy(scaledFontT);
		return scaledFontT;
	}

	public static uint CairoScaledFontGetReferenceCount(this cairo_scaled_font_tHandle scaledFontT)
	{
		return cairo_scaled_fontExterns.cairo_scaled_font_get_reference_count(scaledFontT);
	}

	public static cairo_status_t CairoScaledFontStatus(this cairo_scaled_font_tHandle scaledFontT)
	{
		return cairo_scaled_fontExterns.cairo_scaled_font_status(scaledFontT);
	}

	public static cairo_font_type_t CairoScaledFontGetType(this cairo_scaled_font_tHandle scaledFontT)
	{
		return cairo_scaled_fontExterns.cairo_scaled_font_get_type(scaledFontT);
	}

	public static IntPtr CairoScaledFontGetUserData(this cairo_scaled_font_tHandle scaledFontT, cairo_user_data_key_tHandle keyT)
	{
		return cairo_scaled_fontExterns.cairo_scaled_font_get_user_data(scaledFontT, keyT);
	}

	public static cairo_status_t CairoScaledFontSetUserData(this cairo_scaled_font_tHandle scaledFontT, cairo_user_data_key_tHandle keyT, IntPtr user_data, cairo_destroy_func_t destroy)
	{
		return cairo_scaled_fontExterns.cairo_scaled_font_set_user_data(scaledFontT, keyT, user_data, destroy);
	}

	public static cairo_scaled_font_tHandle CairoScaledFontExtents(this cairo_scaled_font_tHandle scaledFontT, cairo_font_extents_tHandle extents)
	{
		cairo_scaled_fontExterns.cairo_scaled_font_extents(scaledFontT, extents);
		return scaledFontT;
	}

	public static cairo_scaled_font_tHandle CairoScaledFontTextExtents(this cairo_scaled_font_tHandle scaledFontT, string utf8, cairo_text_extents_tHandle extents)
	{
		cairo_scaled_fontExterns.cairo_scaled_font_text_extents(scaledFontT, utf8, extents);
		return scaledFontT;
	}

	public static cairo_scaled_font_tHandle CairoScaledFontGlyphExtents(this cairo_scaled_font_tHandle scaledFontT, cairo_glyph_tHandle glyphs, int num_glyphs, cairo_text_extents_tHandle extents)
	{
		cairo_scaled_fontExterns.cairo_scaled_font_glyph_extents(scaledFontT, glyphs, num_glyphs, extents);
		return scaledFontT;
	}

	public static cairo_status_t CairoScaledFontTextToGlyphs(this cairo_scaled_font_tHandle scaledFontT, double x, double y, string utf8, int utf8_len, cairo_glyph_tHandle[] glyphs, ref int num_glyphs, cairo_text_cluster_tHandle[] clusters, ref int num_clusters, out cairo_text_cluster_flags_t cluster_flags)
	{
		return cairo_scaled_fontExterns.cairo_scaled_font_text_to_glyphs(scaledFontT, x, y, utf8, utf8_len, glyphs, ref num_glyphs, clusters, ref num_clusters, out cluster_flags);
	}

	public static cairo_font_face_tHandle CairoScaledFontGetFontFace(this cairo_scaled_font_tHandle scaledFontT)
	{
		return cairo_scaled_fontExterns.cairo_scaled_font_get_font_face(scaledFontT);
	}

	public static cairo_scaled_font_tHandle CairoScaledFontGetFontMatrix(this cairo_scaled_font_tHandle scaledFontT, cairo_matrix_tHandle fontMatrixT)
	{
		cairo_scaled_fontExterns.cairo_scaled_font_get_font_matrix(scaledFontT, fontMatrixT);
		return scaledFontT;
	}

	public static cairo_scaled_font_tHandle CairoScaledFontGetCtm(this cairo_scaled_font_tHandle scaledFontT, cairo_matrix_tHandle ctm)
	{
		cairo_scaled_fontExterns.cairo_scaled_font_get_ctm(scaledFontT, ctm);
		return scaledFontT;
	}

	public static cairo_scaled_font_tHandle CairoScaledFontGetScaleMatrix(this cairo_scaled_font_tHandle scaledFontT, cairo_matrix_tHandle scaleMatrixT)
	{
		cairo_scaled_fontExterns.cairo_scaled_font_get_scale_matrix(scaledFontT, scaleMatrixT);
		return scaledFontT;
	}

	public static cairo_scaled_font_tHandle CairoScaledFontGetFontOptions(this cairo_scaled_font_tHandle scaledFontT, cairo_font_options_tHandle optionsT)
	{
		cairo_scaled_fontExterns.cairo_scaled_font_get_font_options(scaledFontT, optionsT);
		return scaledFontT;
	}
}

public static class cairo_scaled_fontExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_reference")]
	internal static extern cairo_scaled_font_tHandle cairo_scaled_font_reference(this cairo_scaled_font_tHandle scaledFontT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_destroy")]
	internal static extern void cairo_scaled_font_destroy(this cairo_scaled_font_tHandle scaledFontT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_get_reference_count")]
	internal static extern uint cairo_scaled_font_get_reference_count(this cairo_scaled_font_tHandle scaledFontT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_status")]
	internal static extern cairo_status_t cairo_scaled_font_status(this cairo_scaled_font_tHandle scaledFontT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_get_type")]
	internal static extern cairo_font_type_t cairo_scaled_font_get_type(this cairo_scaled_font_tHandle scaledFontT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_get_user_data")]
	internal static extern IntPtr cairo_scaled_font_get_user_data(this cairo_scaled_font_tHandle scaledFontT, cairo_user_data_key_tHandle keyT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_set_user_data")]
	internal static extern cairo_status_t cairo_scaled_font_set_user_data(this cairo_scaled_font_tHandle scaledFontT, cairo_user_data_key_tHandle keyT, IntPtr user_data, cairo_destroy_func_t destroy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_extents")]
	internal static extern void cairo_scaled_font_extents(this cairo_scaled_font_tHandle scaledFontT, cairo_font_extents_tHandle extents);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_text_extents")]
	internal static extern void cairo_scaled_font_text_extents(this cairo_scaled_font_tHandle scaledFontT, string utf8, cairo_text_extents_tHandle extents);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_glyph_extents")]
	internal static extern void cairo_scaled_font_glyph_extents(this cairo_scaled_font_tHandle scaledFontT, cairo_glyph_tHandle glyphs, int num_glyphs, cairo_text_extents_tHandle extents);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_text_to_glyphs")]
	internal static extern cairo_status_t cairo_scaled_font_text_to_glyphs(this cairo_scaled_font_tHandle scaledFontT, double x, double y, string utf8, int utf8_len, cairo_glyph_tHandle[] glyphs, ref int num_glyphs, cairo_text_cluster_tHandle[] clusters, ref int num_clusters, out cairo_text_cluster_flags_t cluster_flags);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_get_font_face")]
	internal static extern cairo_font_face_tHandle cairo_scaled_font_get_font_face(this cairo_scaled_font_tHandle scaledFontT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_get_font_matrix")]
	internal static extern void cairo_scaled_font_get_font_matrix(this cairo_scaled_font_tHandle scaledFontT, cairo_matrix_tHandle fontMatrixT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_get_ctm")]
	internal static extern void cairo_scaled_font_get_ctm(this cairo_scaled_font_tHandle scaledFontT, cairo_matrix_tHandle ctm);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_get_scale_matrix")]
	internal static extern void cairo_scaled_font_get_scale_matrix(this cairo_scaled_font_tHandle scaledFontT, cairo_matrix_tHandle scaleMatrixT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_scaled_font_get_font_options")]
	internal static extern void cairo_scaled_font_get_font_options(this cairo_scaled_font_tHandle scaledFontT, cairo_font_options_tHandle optionsT);
}
