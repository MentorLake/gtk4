namespace MentorLake.Gtk4.Pango;

public class PangoGlyphItemHandle : BaseSafeHandle
{
}


public static class PangoGlyphItemHandleExtensions
{
	public static GSListHandle ApplyAttrs(this PangoGlyphItemHandle glyph_item, string text, PangoAttrListHandle list)
	{
		return PangoGlyphItemExterns.pango_glyph_item_apply_attrs(glyph_item, text, list);
	}

	public static PangoGlyphItemHandle Copy(this PangoGlyphItemHandle orig)
	{
		return PangoGlyphItemExterns.pango_glyph_item_copy(orig);
	}

	public static PangoGlyphItemHandle Free(this PangoGlyphItemHandle glyph_item)
	{
		PangoGlyphItemExterns.pango_glyph_item_free(glyph_item);
		return glyph_item;
	}

	public static PangoGlyphItemHandle GetLogicalWidths(this PangoGlyphItemHandle glyph_item, string text, int[] logical_widths)
	{
		PangoGlyphItemExterns.pango_glyph_item_get_logical_widths(glyph_item, text, logical_widths);
		return glyph_item;
	}

	public static PangoGlyphItemHandle LetterSpace(this PangoGlyphItemHandle glyph_item, string text, PangoLogAttr[] log_attrs, int letter_spacing)
	{
		PangoGlyphItemExterns.pango_glyph_item_letter_space(glyph_item, text, log_attrs, letter_spacing);
		return glyph_item;
	}

	public static PangoGlyphItemHandle Split(this PangoGlyphItemHandle orig, string text, int split_index)
	{
		return PangoGlyphItemExterns.pango_glyph_item_split(orig, text, split_index);
	}

}
internal class PangoGlyphItemExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern GSListHandle pango_glyph_item_apply_attrs(PangoGlyphItemHandle glyph_item, string text, PangoAttrListHandle list);

	[DllImport(Libraries.Pango)]
	internal static extern PangoGlyphItemHandle pango_glyph_item_copy(PangoGlyphItemHandle orig);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_glyph_item_free(PangoGlyphItemHandle glyph_item);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_glyph_item_get_logical_widths(PangoGlyphItemHandle glyph_item, string text, int[] logical_widths);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_glyph_item_letter_space(PangoGlyphItemHandle glyph_item, string text, PangoLogAttr[] log_attrs, int letter_spacing);

	[DllImport(Libraries.Pango)]
	internal static extern PangoGlyphItemHandle pango_glyph_item_split(PangoGlyphItemHandle orig, string text, int split_index);

}

public struct PangoGlyphItem
{
	public PangoItemHandle item;
	public PangoGlyphStringHandle glyphs;
	public int y_offset;
	public int start_x_offset;
	public int end_x_offset;
}
