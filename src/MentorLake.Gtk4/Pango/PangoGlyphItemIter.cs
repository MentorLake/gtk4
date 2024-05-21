namespace MentorLake.Gtk4.Pango;

public class PangoGlyphItemIterHandle : BaseSafeHandle
{
}


public static class PangoGlyphItemIterHandleExtensions
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

	public static bool InitEnd(this PangoGlyphItemIterHandle iter, PangoGlyphItemHandle glyph_item, string text)
	{
		return PangoGlyphItemIterExterns.pango_glyph_item_iter_init_end(iter, glyph_item, text);
	}

	public static bool InitStart(this PangoGlyphItemIterHandle iter, PangoGlyphItemHandle glyph_item, string text)
	{
		return PangoGlyphItemIterExterns.pango_glyph_item_iter_init_start(iter, glyph_item, text);
	}

	public static bool NextCluster(this PangoGlyphItemIterHandle iter)
	{
		return PangoGlyphItemIterExterns.pango_glyph_item_iter_next_cluster(iter);
	}

	public static bool PrevCluster(this PangoGlyphItemIterHandle iter)
	{
		return PangoGlyphItemIterExterns.pango_glyph_item_iter_prev_cluster(iter);
	}

}
internal class PangoGlyphItemIterExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoGlyphItemIterHandle pango_glyph_item_iter_copy(PangoGlyphItemIterHandle orig);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_glyph_item_iter_free(PangoGlyphItemIterHandle iter);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_glyph_item_iter_init_end(PangoGlyphItemIterHandle iter, PangoGlyphItemHandle glyph_item, string text);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_glyph_item_iter_init_start(PangoGlyphItemIterHandle iter, PangoGlyphItemHandle glyph_item, string text);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_glyph_item_iter_next_cluster(PangoGlyphItemIterHandle iter);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_glyph_item_iter_prev_cluster(PangoGlyphItemIterHandle iter);

}

public struct PangoGlyphItemIter
{
	public PangoGlyphItemHandle glyph_item;
	public string text;
	public int start_glyph;
	public int start_index;
	public int start_char;
	public int end_glyph;
	public int end_index;
	public int end_char;
}
