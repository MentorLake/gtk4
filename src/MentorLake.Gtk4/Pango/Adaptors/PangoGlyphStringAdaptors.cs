using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoGlyphStringAdaptors
{
	public static PangoGlyphStringHandle SetSize(this PangoGlyphStringHandle @string, int new_len)
	{
		PangoGlyphStringExterns.pango_glyph_string_set_size(@string, new_len);
		return @string;
	}

	public static PangoGlyphStringHandle Copy(this PangoGlyphStringHandle @string)
	{
		return PangoGlyphStringExterns.pango_glyph_string_copy(@string);
	}

	public static PangoGlyphStringHandle Free(this PangoGlyphStringHandle @string)
	{
		PangoGlyphStringExterns.pango_glyph_string_free(@string);
		return @string;
	}

	public static PangoGlyphStringHandle Extents(this PangoGlyphStringHandle glyphs, PangoFontHandle font, PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect)
	{
		PangoGlyphStringExterns.pango_glyph_string_extents(glyphs, font, ink_rect, logical_rect);
		return glyphs;
	}

	public static int GetWidth(this PangoGlyphStringHandle glyphs)
	{
		return PangoGlyphStringExterns.pango_glyph_string_get_width(glyphs);
	}

	public static PangoGlyphStringHandle ExtentsRange(this PangoGlyphStringHandle glyphs, int start, int end, PangoFontHandle font, PangoRectangleHandle ink_rect, PangoRectangleHandle logical_rect)
	{
		PangoGlyphStringExterns.pango_glyph_string_extents_range(glyphs, start, end, font, ink_rect, logical_rect);
		return glyphs;
	}

	public static PangoGlyphStringHandle GetLogicalWidths(this PangoGlyphStringHandle glyphs, string text, int length, int embedding_level, out int logical_widths)
	{
		PangoGlyphStringExterns.pango_glyph_string_get_logical_widths(glyphs, text, length, embedding_level, out logical_widths);
		return glyphs;
	}

	public static PangoGlyphStringHandle IndexToX(this PangoGlyphStringHandle glyphs, string text, int length, PangoAnalysisHandle analysis, int index_, int trailing, out int x_pos)
	{
		PangoGlyphStringExterns.pango_glyph_string_index_to_x(glyphs, text, length, analysis, index_, trailing, out x_pos);
		return glyphs;
	}

	public static PangoGlyphStringHandle XToIndex(this PangoGlyphStringHandle glyphs, string text, int length, PangoAnalysisHandle analysis, int x_pos, out int index_, out int trailing)
	{
		PangoGlyphStringExterns.pango_glyph_string_x_to_index(glyphs, text, length, analysis, x_pos, out index_, out trailing);
		return glyphs;
	}

	public static PangoGlyphStringHandle IndexToXFull(this PangoGlyphStringHandle glyphs, string text, int length, PangoAnalysisHandle analysis, PangoLogAttrHandle attrs, int index_, int trailing, out int x_pos)
	{
		PangoGlyphStringExterns.pango_glyph_string_index_to_x_full(glyphs, text, length, analysis, attrs, index_, trailing, out x_pos);
		return glyphs;
	}
}
