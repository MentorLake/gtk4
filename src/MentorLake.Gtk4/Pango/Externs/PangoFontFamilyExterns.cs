using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;

public static class PangoFontFamilyExterns
{
	[DllImport(Libraries.Pango, EntryPoint = "pango_font_family_list_faces")]
	internal static extern void pango_font_family_list_faces(this PangoFontFamilyHandle family, out PangoFontFaceHandle faces, out int n_faces);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_family_get_name")]
	internal static extern string pango_font_family_get_name(this PangoFontFamilyHandle family);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_family_is_monospace")]
	internal static extern int pango_font_family_is_monospace(this PangoFontFamilyHandle family);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_family_is_variable")]
	internal static extern int pango_font_family_is_variable(this PangoFontFamilyHandle family);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_family_get_face")]
	internal static extern PangoFontFaceHandle pango_font_family_get_face(this PangoFontFamilyHandle family, string name);
}
