using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoGlyphItemIterAdaptors
{
    public static PangoGlyphItemIterHandle Copy(this PangoGlyphItemIterHandle orig)
    {
        return PangoGlyphItemIterExterns.pango_glyph_item_iter_copy(orig);
    }

    public static PangoGlyphItemIterHandle Free(this PangoGlyphItemIterHandle iter)
    {
        PangoGlyphItemIterExterns.pango_glyph_item_iter_free(iter);
        return iter;
    }

    public static int InitStart(this PangoGlyphItemIterHandle iter, PangoGlyphItemHandle glyph_item, string text)
    {
        return PangoGlyphItemIterExterns.pango_glyph_item_iter_init_start(iter, glyph_item, text);
    }

    public static int InitEnd(this PangoGlyphItemIterHandle iter, PangoGlyphItemHandle glyph_item, string text)
    {
        return PangoGlyphItemIterExterns.pango_glyph_item_iter_init_end(iter, glyph_item, text);
    }

    public static int NextCluster(this PangoGlyphItemIterHandle iter)
    {
        return PangoGlyphItemIterExterns.pango_glyph_item_iter_next_cluster(iter);
    }

    public static int PrevCluster(this PangoGlyphItemIterHandle iter)
    {
        return PangoGlyphItemIterExterns.pango_glyph_item_iter_prev_cluster(iter);
    }
}
