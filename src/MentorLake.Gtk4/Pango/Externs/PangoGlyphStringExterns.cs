using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoGlyphStringExterns
{
    [DllImport(Libraries.Pango, EntryPoint = "pango_glyph_string_set_size")]
    internal static extern void pango_glyph_string_set_size(this PangoGlyphStringHandle @string, int new_len);
    [DllImport(Libraries.Pango, EntryPoint = "pango_glyph_string_copy")]
    internal static extern PangoGlyphStringHandle pango_glyph_string_copy(this PangoGlyphStringHandle @string);
    [DllImport(Libraries.Pango, EntryPoint = "pango_glyph_string_free")]
    internal static extern void pango_glyph_string_free(this PangoGlyphStringHandle @string);
    [DllImport(Libraries.Pango, EntryPoint = "pango_glyph_string_extents")]
    internal static extern void pango_glyph_string_extents(this PangoGlyphStringHandle glyphs, PangoFontHandle font, PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect);
    [DllImport(Libraries.Pango, EntryPoint = "pango_glyph_string_get_width")]
    internal static extern int pango_glyph_string_get_width(this PangoGlyphStringHandle glyphs);
    [DllImport(Libraries.Pango, EntryPoint = "pango_glyph_string_extents_range")]
    internal static extern void pango_glyph_string_extents_range(this PangoGlyphStringHandle glyphs, int start, int end, PangoFontHandle font, PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect);
    [DllImport(Libraries.Pango, EntryPoint = "pango_glyph_string_get_logical_widths")]
    internal static extern void pango_glyph_string_get_logical_widths(this PangoGlyphStringHandle glyphs, string text, int length, int embedding_level, out int logical_widths);
    [DllImport(Libraries.Pango, EntryPoint = "pango_glyph_string_index_to_x")]
    internal static extern void pango_glyph_string_index_to_x(this PangoGlyphStringHandle glyphs, string text, int length, PangoAnalysisHandle analysis, int index_, int trailing, out int x_pos);
    [DllImport(Libraries.Pango, EntryPoint = "pango_glyph_string_x_to_index")]
    internal static extern void pango_glyph_string_x_to_index(this PangoGlyphStringHandle glyphs, string text, int length, PangoAnalysisHandle analysis, int x_pos, out int index_, out int trailing);
    [DllImport(Libraries.Pango, EntryPoint = "pango_glyph_string_index_to_x_full")]
    internal static extern void pango_glyph_string_index_to_x_full(this PangoGlyphStringHandle glyphs, string text, int length, PangoAnalysisHandle analysis, PangoLogAttrHandle attrs, int index_, int trailing, out int x_pos);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoGlyphStringHandle pango_glyph_string_new();
}
