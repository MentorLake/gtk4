using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public class cairo_glyph_tHandle : BaseSafeHandle { }

public struct cairo_glyph_t
{
	public double x;
	public double y;
}

public static class cairo_glyph_tAdaptors
{
	public static cairo_glyph_tHandle CairoGlyphFree(this cairo_glyph_tHandle glyphs)
	{
		cairo_glyph_tExterns.cairo_glyph_free(glyphs);
		return glyphs;
	}
}

public static class cairo_glyph_tExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_glyph_free")]
	internal static extern void cairo_glyph_free(this cairo_glyph_tHandle glyphs);
}
