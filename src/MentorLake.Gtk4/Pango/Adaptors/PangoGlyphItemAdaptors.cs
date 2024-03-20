using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pango;
public static class PangoGlyphItemAdaptors
{
    public static PangoGlyphItemHandle Split(this PangoGlyphItemHandle orig, string text, int split_index)
    {
        return PangoGlyphItemExterns.pango_glyph_item_split(orig, text, split_index);
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

    public static GSListHandle ApplyAttrs(this PangoGlyphItemHandle glyph_item, string text, PangoAttrListHandle list)
    {
        return PangoGlyphItemExterns.pango_glyph_item_apply_attrs(glyph_item, text, list);
    }

    public static PangoGlyphItemHandle LetterSpace(this PangoGlyphItemHandle glyph_item, string text, PangoLogAttrHandle log_attrs, int letter_spacing)
    {
        PangoGlyphItemExterns.pango_glyph_item_letter_space(glyph_item, text, log_attrs, letter_spacing);
        return glyph_item;
    }

    public static PangoGlyphItemHandle GetLogicalWidths(this PangoGlyphItemHandle glyph_item, string text, out int logical_widths)
    {
        PangoGlyphItemExterns.pango_glyph_item_get_logical_widths(glyph_item, text, out logical_widths);
        return glyph_item;
    }
}
