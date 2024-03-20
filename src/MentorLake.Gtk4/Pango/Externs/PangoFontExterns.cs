using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pango;

public static class PangoFontExterns
{
	[DllImport(Libraries.Pango, EntryPoint = "pango_font_describe")]
	internal static extern PangoFontDescriptionHandle pango_font_describe(this PangoFontHandle font);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_describe_with_absolute_size")]
	internal static extern PangoFontDescriptionHandle pango_font_describe_with_absolute_size(this PangoFontHandle font);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_get_coverage")]
	internal static extern PangoCoverageHandle pango_font_get_coverage(this PangoFontHandle font, PangoLanguageHandle language);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_find_shaper")]
	internal static extern PangoEngineShapeHandle pango_font_find_shaper(this PangoFontHandle font, PangoLanguageHandle language, uint ch);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_get_metrics")]
	internal static extern PangoFontMetricsHandle pango_font_get_metrics(this PangoFontHandle font, PangoLanguageHandle language);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_get_glyph_extents")]
	internal static extern void pango_font_get_glyph_extents(this PangoFontHandle font, PangoGlyph glyph, PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_get_font_map")]
	internal static extern PangoFontMapHandle pango_font_get_font_map(this PangoFontHandle font);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_get_face")]
	internal static extern PangoFontFaceHandle pango_font_get_face(this PangoFontHandle font);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_has_char")]
	internal static extern int pango_font_has_char(this PangoFontHandle font, uint wc);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_get_features")]
	internal static extern void pango_font_get_features(this PangoFontHandle font, IntPtr features, uint len, out uint num_features);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_get_hb_font")]
	internal static extern IntPtr pango_font_get_hb_font(this PangoFontHandle font);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_get_languages")]
	internal static extern PangoLanguageHandle[] pango_font_get_languages(this PangoFontHandle font);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_serialize")]
	internal static extern GBytesHandle pango_font_serialize(this PangoFontHandle font);
}
