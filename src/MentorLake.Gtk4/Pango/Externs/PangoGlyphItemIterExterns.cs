using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;

public static class PangoGlyphItemIterExterns
{
	[DllImport(Libraries.Pango, EntryPoint = "pango_glyph_item_iter_copy")]
	internal static extern PangoGlyphItemIterHandle pango_glyph_item_iter_copy(this PangoGlyphItemIterHandle orig);

	[DllImport(Libraries.Pango, EntryPoint = "pango_glyph_item_iter_free")]
	internal static extern void pango_glyph_item_iter_free(this PangoGlyphItemIterHandle iter);

	[DllImport(Libraries.Pango, EntryPoint = "pango_glyph_item_iter_init_start")]
	internal static extern int pango_glyph_item_iter_init_start(this PangoGlyphItemIterHandle iter, PangoGlyphItemHandle glyph_item, string text);

	[DllImport(Libraries.Pango, EntryPoint = "pango_glyph_item_iter_init_end")]
	internal static extern int pango_glyph_item_iter_init_end(this PangoGlyphItemIterHandle iter, PangoGlyphItemHandle glyph_item, string text);

	[DllImport(Libraries.Pango, EntryPoint = "pango_glyph_item_iter_next_cluster")]
	internal static extern int pango_glyph_item_iter_next_cluster(this PangoGlyphItemIterHandle iter);

	[DllImport(Libraries.Pango, EntryPoint = "pango_glyph_item_iter_prev_cluster")]
	internal static extern int pango_glyph_item_iter_prev_cluster(this PangoGlyphItemIterHandle iter);
}
