using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;

public static class PangoFontFaceExterns
{
	[DllImport(Libraries.Pango, EntryPoint = "pango_font_face_describe")]
	internal static extern PangoFontDescriptionHandle pango_font_face_describe(this PangoFontFaceHandle face);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_face_get_face_name")]
	internal static extern string pango_font_face_get_face_name(this PangoFontFaceHandle face);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_face_list_sizes")]
	internal static extern void pango_font_face_list_sizes(this PangoFontFaceHandle face, out int[] sizes, out int n_sizes);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_face_is_synthesized")]
	internal static extern int pango_font_face_is_synthesized(this PangoFontFaceHandle face);

	[DllImport(Libraries.Pango, EntryPoint = "pango_font_face_get_family")]
	internal static extern PangoFontFamilyHandle pango_font_face_get_family(this PangoFontFaceHandle face);
}
