using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;

public static class PangoLanguageExterns
{
	[DllImport(Libraries.Pango, EntryPoint = "pango_language_to_string")]
	internal static extern string pango_language_to_string(this PangoLanguageHandle language);

	[DllImport(Libraries.Pango, EntryPoint = "pango_language_get_sample_string")]
	internal static extern string pango_language_get_sample_string(this PangoLanguageHandle language);

	[DllImport(Libraries.Pango, EntryPoint = "pango_language_matches")]
	internal static extern int pango_language_matches(this PangoLanguageHandle language, string range_list);

	[DllImport(Libraries.Pango, EntryPoint = "pango_language_includes_script")]
	internal static extern int pango_language_includes_script(this PangoLanguageHandle language, PangoScript script);

	[DllImport(Libraries.Pango, EntryPoint = "pango_language_get_scripts")]
	internal static extern PangoScript[] pango_language_get_scripts(this PangoLanguageHandle language, out int num_scripts);

	[DllImport(Libraries.Pango, EntryPoint = "pango_attr_language_new")]
	internal static extern PangoAttributeHandle pango_attr_language_new(this PangoLanguageHandle language);

	[DllImport(Libraries.Pango, EntryPoint = "pango_fontset_simple_new")]
	internal static extern PangoFontsetSimpleHandle pango_fontset_simple_new(this PangoLanguageHandle language);
}
