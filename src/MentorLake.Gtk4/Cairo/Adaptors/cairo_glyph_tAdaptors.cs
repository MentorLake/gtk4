using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;
public static class cairo_glyph_tAdaptors
{
    public static cairo_glyph_tHandle CairoGlyphFree(this cairo_glyph_tHandle glyphs)
    {
        cairo_glyph_tExterns.cairo_glyph_free(glyphs);
        return glyphs;
    }
}
