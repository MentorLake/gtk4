using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;

public static class PangoFontMapExterns
{
	[DllImport(Libraries.Pango, EntryPoint = "pango_font_map_create_context")]
	internal static extern PangoContextHandle pango_font_map_create_context(this PangoFontMapHandle fontmap);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_map_load_font")]
	internal static extern PangoFontHandle pango_font_map_load_font(this PangoFontMapHandle fontmap, PangoContextHandle context, PangoFontDescriptionHandle desc);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_map_load_fontset")]
	internal static extern PangoFontsetHandle pango_font_map_load_fontset(this PangoFontMapHandle fontmap, PangoContextHandle context, PangoFontDescriptionHandle desc, PangoLanguageHandle language);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_map_list_families")]
	internal static extern void pango_font_map_list_families(this PangoFontMapHandle fontmap, out PangoFontFamily[] families, out int n_families);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_map_get_serial")]
	internal static extern uint pango_font_map_get_serial(this PangoFontMapHandle fontmap);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_map_changed")]
	internal static extern void pango_font_map_changed(this PangoFontMapHandle fontmap);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_map_get_family")]
	internal static extern PangoFontFamilyHandle pango_font_map_get_family(this PangoFontMapHandle fontmap, string name);
}
