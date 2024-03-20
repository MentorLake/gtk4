using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public static class cairo_glyph_tExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_glyph_free")]
	internal static extern void cairo_glyph_free(this cairo_glyph_tHandle glyphs);
}
